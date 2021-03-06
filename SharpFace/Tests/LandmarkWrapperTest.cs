﻿using OpenCvSharp;
using OpenCvSharp.Native;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpFace.Tests
{
    public class LandmarkWrapperTest : TestBase
    {
        LandmarkDetectorWrap wrap;
        CascadeClassifier cascade;
        Capture capture;
        Stopwatch sw;

        public LandmarkWrapperTest(int index = 0, string modelPath = "./")
        {
            wrap = new LandmarkDetectorWrap(modelPath);
            cascade = new CascadeClassifier();

            capture = NativeBindings.Kernal.NewCapture(index);
            capture.FrameReady += (sender, arg) =>
            {
                Proc(arg.Mat, arg);
            };

            sw = new Stopwatch();
            sw.Start();

            cascade.Load(wrap.Parameters.face_detector_location);

            wrap.Load();
            wrap.InVideo = true;
        }

        public override void Dispose()
        {
            if (wrap != null)
            {
                wrap.Dispose();
                wrap = null;
            }
        }

        public override void Start()
        {
            capture.Start();
        }

        public override void Stop()
        {
            capture.Stop();
        }

        public override void Wait()
        {
            capture.Wait();
        }

        private void DrawInROI(Mat mat, Rect roi, List<Point2d> pt)
        {
            foreach (var p in pt)
            {
                mat.DrawMarker((int)(roi.X + p.X), (int)(roi.Y + p.Y), Scalar.Red, MarkerStyle.CircleAndCross, 10, LineTypes.AntiAlias);
            }
        }

        private void DrawInfo(Mat mat, Point2d pt)
        {
            var rot = wrap.EularRotation;
            var pos = wrap.Transform;
            var fmt = "0.000";
            mat.PutText($"R:{rot[0].ToString(fmt)},{rot[1].ToString(fmt)},{rot[2].ToString(fmt)}", new Point(pt.X, pt.Y), HersheyFonts.HersheyPlain, 1, Scalar.Lime, 1, LineTypes.AntiAlias);
            mat.PutText($"T:{pos[0].ToString(fmt)},{pos[1].ToString(fmt)},{pos[2].ToString(fmt)}", new Point(pt.X, pt.Y+20), HersheyFonts.HersheyPlain, 1, Scalar.Lime, 1, LineTypes.AntiAlias);
        }

        long realLastMs = 0;
        long lastMs = 0;
        long time = 0;
        bool onFace = true;
        private void Proc(Mat read, FrameArgs args)
        {
            if (!read.Empty())
            {
                realLastMs = sw.ElapsedMilliseconds;
                if (onFace)
                {
                    var scale = Math.Max(read.Height, read.Width) / 300;
                    Cv2.Resize(read, read, new Size(read.Width / scale, read.Height / scale));
                    wrap.DetectImage(read);
                    wrap.Draw(read);
                    var box = wrap.BoundaryBox;
                    Cv2.Rectangle(read, new Rect((int)box.X, (int)box.Y, (int)box.Width, (int)box.Height), Scalar.Aqua, 2);
                    DrawInfo(read, new Point2d(10, 20));
                }
                else
                {
                    Cv2.Resize(read, read, new Size(320, 240));
                    wrap.CheckFocus(read);
                    var faces = cascade.DetectMultiScale(read, 1.4, 2, HaarDetectionType.ScaleImage, new Size(read.Width * 0.2, read.Height * 0.2), read.Size());
                    foreach (var face in faces)
                    {
                        wrap.DetectROI(read, face);
                        wrap.Draw(read);
                        DrawInfo(read, face.TopLeft);
                        read.Rectangle(face, Scalar.Blue, 2, LineTypes.AntiAlias);
                    }
                }
                time = sw.ElapsedMilliseconds - realLastMs;
                read.PutText($"realfps:{1000/time}", new Point(10, 100), HersheyFonts.HersheyPlain, 1, Scalar.Lime, 1, LineTypes.AntiAlias);
                read.PutText($"fps:{1000 / (sw.ElapsedMilliseconds - lastMs)}", new Point(10, 120), HersheyFonts.HersheyPlain, 1, Scalar.Lime, 1, LineTypes.AntiAlias);
                lastMs = sw.ElapsedMilliseconds;
                Cv2.ImShow("test", read);
            }

            switch (args.LastKey)
            {
                case 'r':
                    wrap.Reset();
                    break;
                case 'i':
                    wrap.InVideo = !wrap.InVideo;
                    break;
                case 'f':
                    onFace = !onFace;
                    break;
                case 'q':
                    args.Break = true;
                    break;
            }
        }
    }
}
