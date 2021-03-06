//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SharpFace
{

    public class CVDoubleRectList : global::System.IDisposable, global::System.Collections.IEnumerable
        , global::System.Collections.Generic.IEnumerable<SWIGTYPE_p_cv__Rect_T_double_t>
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal CVDoubleRectList(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVDoubleRectList obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~CVDoubleRectList()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock(this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        LandmarkDetectorPINVOKE.delete_CVDoubleRectList(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public CVDoubleRectList(global::System.Collections.ICollection c) : this()
        {
            if (c == null)
                throw new global::System.ArgumentNullException("c");
            foreach (SWIGTYPE_p_cv__Rect_T_double_t element in c)
            {
                this.Add(element);
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public SWIGTYPE_p_cv__Rect_T_double_t this[int index]
        {
            get
            {
                return getitem(index);
            }
            set
            {
                setitem(index, value);
            }
        }

        public int Capacity
        {
            get
            {
                return (int)capacity();
            }
            set
            {
                if (value < size())
                    throw new global::System.ArgumentOutOfRangeException("Capacity");
                reserve((uint)value);
            }
        }

        public int Count
        {
            get
            {
                return (int)size();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public void CopyTo(SWIGTYPE_p_cv__Rect_T_double_t[] array)
        {
            CopyTo(0, array, 0, this.Count);
        }

        public void CopyTo(SWIGTYPE_p_cv__Rect_T_double_t[] array, int arrayIndex)
        {
            CopyTo(0, array, arrayIndex, this.Count);
        }

        public void CopyTo(int index, SWIGTYPE_p_cv__Rect_T_double_t[] array, int arrayIndex, int count)
        {
            if (array == null)
                throw new global::System.ArgumentNullException("array");
            if (index < 0)
                throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
            if (arrayIndex < 0)
                throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
            if (count < 0)
                throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
            if (array.Rank > 1)
                throw new global::System.ArgumentException("Multi dimensional array.", "array");
            if (index+count > this.Count || arrayIndex+count > array.Length)
                throw new global::System.ArgumentException("Number of elements to copy is too large.");
            for (int i=0; i<count; i++)
                array.SetValue(getitemcopy(index+i), arrayIndex+i);
        }

        global::System.Collections.Generic.IEnumerator<SWIGTYPE_p_cv__Rect_T_double_t> global::System.Collections.Generic.IEnumerable<SWIGTYPE_p_cv__Rect_T_double_t>.GetEnumerator()
        {
            return new CVDoubleRectListEnumerator(this);
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return new CVDoubleRectListEnumerator(this);
        }

        public CVDoubleRectListEnumerator GetEnumerator()
        {
            return new CVDoubleRectListEnumerator(this);
        }

        // Type-safe enumerator
        /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
        /// whenever the collection is modified. This has been done for changes in the size of the
        /// collection but not when one of the elements of the collection is modified as it is a bit
        /// tricky to detect unmanaged code that modifies the collection under our feet.
        public sealed class CVDoubleRectListEnumerator : global::System.Collections.IEnumerator
            , global::System.Collections.Generic.IEnumerator<SWIGTYPE_p_cv__Rect_T_double_t>
        {
            private CVDoubleRectList collectionRef;
            private int currentIndex;
            private object currentObject;
            private int currentSize;

            public CVDoubleRectListEnumerator(CVDoubleRectList collection)
            {
                collectionRef = collection;
                currentIndex = -1;
                currentObject = null;
                currentSize = collectionRef.Count;
            }

            // Type-safe iterator Current
            public SWIGTYPE_p_cv__Rect_T_double_t Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new global::System.InvalidOperationException("Enumeration not started.");
                    if (currentIndex > currentSize - 1)
                        throw new global::System.InvalidOperationException("Enumeration finished.");
                    if (currentObject == null)
                        throw new global::System.InvalidOperationException("Collection modified.");
                    return (SWIGTYPE_p_cv__Rect_T_double_t)currentObject;
                }
            }

            // Type-unsafe IEnumerator.Current
            object global::System.Collections.IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public bool MoveNext()
            {
                int size = collectionRef.Count;
                bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
                if (moveOkay)
                {
                    currentIndex++;
                    currentObject = collectionRef[currentIndex];
                }
                else
                {
                    currentObject = null;
                }
                return moveOkay;
            }

            public void Reset()
            {
                currentIndex = -1;
                currentObject = null;
                if (collectionRef.Count != currentSize)
                {
                    throw new global::System.InvalidOperationException("Collection modified.");
                }
            }

            public void Dispose()
            {
                currentIndex = -1;
                currentObject = null;
            }
        }

        public void Clear()
        {
            LandmarkDetectorPINVOKE.CVDoubleRectList_Clear(swigCPtr);
        }

        public void Add(SWIGTYPE_p_cv__Rect_T_double_t x)
        {
            LandmarkDetectorPINVOKE.CVDoubleRectList_Add(swigCPtr, SWIGTYPE_p_cv__Rect_T_double_t.getCPtr(x));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        private uint size()
        {
            uint ret = LandmarkDetectorPINVOKE.CVDoubleRectList_size(swigCPtr);
            return ret;
        }

        private uint capacity()
        {
            uint ret = LandmarkDetectorPINVOKE.CVDoubleRectList_capacity(swigCPtr);
            return ret;
        }

        private void reserve(uint n)
        {
            LandmarkDetectorPINVOKE.CVDoubleRectList_reserve(swigCPtr, n);
        }

        public CVDoubleRectList() : this(LandmarkDetectorPINVOKE.new_CVDoubleRectList__SWIG_0(), true)
        {
        }

        public CVDoubleRectList(CVDoubleRectList other) : this(LandmarkDetectorPINVOKE.new_CVDoubleRectList__SWIG_1(CVDoubleRectList.getCPtr(other)), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public CVDoubleRectList(int capacity) : this(LandmarkDetectorPINVOKE.new_CVDoubleRectList__SWIG_2(capacity), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        private SWIGTYPE_p_cv__Rect_T_double_t getitemcopy(int index)
        {
            SWIGTYPE_p_cv__Rect_T_double_t ret = new SWIGTYPE_p_cv__Rect_T_double_t(LandmarkDetectorPINVOKE.CVDoubleRectList_getitemcopy(swigCPtr, index), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private SWIGTYPE_p_cv__Rect_T_double_t getitem(int index)
        {
            SWIGTYPE_p_cv__Rect_T_double_t ret = new SWIGTYPE_p_cv__Rect_T_double_t(LandmarkDetectorPINVOKE.CVDoubleRectList_getitem(swigCPtr, index), false);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private void setitem(int index, SWIGTYPE_p_cv__Rect_T_double_t val)
        {
            LandmarkDetectorPINVOKE.CVDoubleRectList_setitem(swigCPtr, index, SWIGTYPE_p_cv__Rect_T_double_t.getCPtr(val));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void AddRange(CVDoubleRectList values)
        {
            LandmarkDetectorPINVOKE.CVDoubleRectList_AddRange(swigCPtr, CVDoubleRectList.getCPtr(values));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public CVDoubleRectList GetRange(int index, int count)
        {
            global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.CVDoubleRectList_GetRange(swigCPtr, index, count);
            CVDoubleRectList ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVDoubleRectList(cPtr, true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Insert(int index, SWIGTYPE_p_cv__Rect_T_double_t x)
        {
            LandmarkDetectorPINVOKE.CVDoubleRectList_Insert(swigCPtr, index, SWIGTYPE_p_cv__Rect_T_double_t.getCPtr(x));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void InsertRange(int index, CVDoubleRectList values)
        {
            LandmarkDetectorPINVOKE.CVDoubleRectList_InsertRange(swigCPtr, index, CVDoubleRectList.getCPtr(values));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveAt(int index)
        {
            LandmarkDetectorPINVOKE.CVDoubleRectList_RemoveAt(swigCPtr, index);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveRange(int index, int count)
        {
            LandmarkDetectorPINVOKE.CVDoubleRectList_RemoveRange(swigCPtr, index, count);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static CVDoubleRectList Repeat(SWIGTYPE_p_cv__Rect_T_double_t value, int count)
        {
            global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.CVDoubleRectList_Repeat(SWIGTYPE_p_cv__Rect_T_double_t.getCPtr(value), count);
            CVDoubleRectList ret = (cPtr == global::System.IntPtr.Zero) ? null : new CVDoubleRectList(cPtr, true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Reverse()
        {
            LandmarkDetectorPINVOKE.CVDoubleRectList_Reverse__SWIG_0(swigCPtr);
        }

        public void Reverse(int index, int count)
        {
            LandmarkDetectorPINVOKE.CVDoubleRectList_Reverse__SWIG_1(swigCPtr, index, count);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetRange(int index, CVDoubleRectList values)
        {
            LandmarkDetectorPINVOKE.CVDoubleRectList_SetRange(swigCPtr, index, CVDoubleRectList.getCPtr(values));
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

    }

}
