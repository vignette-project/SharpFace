//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CCNF_patch_expert : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CCNF_patch_expert(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CCNF_patch_expert obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CCNF_patch_expert() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LandmarkDetectorPINVOKE.delete_CCNF_patch_expert(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int width {
    set {
      LandmarkDetectorPINVOKE.CCNF_patch_expert_width_set(swigCPtr, value);
    } 
    get {
      int ret = LandmarkDetectorPINVOKE.CCNF_patch_expert_width_get(swigCPtr);
      return ret;
    } 
  }

  public int height {
    set {
      LandmarkDetectorPINVOKE.CCNF_patch_expert_height_set(swigCPtr, value);
    } 
    get {
      int ret = LandmarkDetectorPINVOKE.CCNF_patch_expert_height_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_LandmarkDetector__CCNF_neuron_t neurons {
    set {
      LandmarkDetectorPINVOKE.CCNF_patch_expert_neurons_set(swigCPtr, SWIGTYPE_p_std__vectorT_LandmarkDetector__CCNF_neuron_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.CCNF_patch_expert_neurons_get(swigCPtr);
      SWIGTYPE_p_std__vectorT_LandmarkDetector__CCNF_neuron_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_LandmarkDetector__CCNF_neuron_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_int_t window_sizes {
    set {
      LandmarkDetectorPINVOKE.CCNF_patch_expert_window_sizes_set(swigCPtr, SWIGTYPE_p_std__vectorT_int_t.getCPtr(value));
      if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_std__vectorT_int_t ret = new SWIGTYPE_p_std__vectorT_int_t(LandmarkDetectorPINVOKE.CCNF_patch_expert_window_sizes_get(swigCPtr), true);
      if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_cv__Mat_T_float_t_t Sigmas {
    set {
      LandmarkDetectorPINVOKE.CCNF_patch_expert_Sigmas_set(swigCPtr, SWIGTYPE_p_std__vectorT_cv__Mat_T_float_t_t.getCPtr(value));
      if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_std__vectorT_cv__Mat_T_float_t_t ret = new SWIGTYPE_p_std__vectorT_cv__Mat_T_float_t_t(LandmarkDetectorPINVOKE.CCNF_patch_expert_Sigmas_get(swigCPtr), true);
      if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_double_t betas {
    set {
      LandmarkDetectorPINVOKE.CCNF_patch_expert_betas_set(swigCPtr, SWIGTYPE_p_std__vectorT_double_t.getCPtr(value));
      if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_std__vectorT_double_t ret = new SWIGTYPE_p_std__vectorT_double_t(LandmarkDetectorPINVOKE.CCNF_patch_expert_betas_get(swigCPtr), true);
      if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double patch_confidence {
    set {
      LandmarkDetectorPINVOKE.CCNF_patch_expert_patch_confidence_set(swigCPtr, value);
    } 
    get {
      double ret = LandmarkDetectorPINVOKE.CCNF_patch_expert_patch_confidence_get(swigCPtr);
      return ret;
    } 
  }

  public CCNF_patch_expert() : this(LandmarkDetectorPINVOKE.new_CCNF_patch_expert__SWIG_0(), true) {
  }

  public CCNF_patch_expert(CCNF_patch_expert other) : this(LandmarkDetectorPINVOKE.new_CCNF_patch_expert__SWIG_1(CCNF_patch_expert.getCPtr(other)), true) {
    if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Read(SWIGTYPE_p_std__ifstream stream, SWIGTYPE_p_std__vectorT_int_t window_sizes, SWIGTYPE_p_std__vectorT_std__vectorT_cv__Mat_T_float_t_t_t sigma_components) {
    LandmarkDetectorPINVOKE.CCNF_patch_expert_Read(swigCPtr, SWIGTYPE_p_std__ifstream.getCPtr(stream), SWIGTYPE_p_std__vectorT_int_t.getCPtr(window_sizes), SWIGTYPE_p_std__vectorT_std__vectorT_cv__Mat_T_float_t_t_t.getCPtr(sigma_components));
    if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Response(SWIGTYPE_p_cv__Mat_T_float_t area_of_interest, SWIGTYPE_p_cv__Mat_T_float_t response) {
    LandmarkDetectorPINVOKE.CCNF_patch_expert_Response(swigCPtr, SWIGTYPE_p_cv__Mat_T_float_t.getCPtr(area_of_interest), SWIGTYPE_p_cv__Mat_T_float_t.getCPtr(response));
    if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ComputeSigmas(SWIGTYPE_p_std__vectorT_cv__Mat_T_float_t_t sigma_components, int window_size) {
    LandmarkDetectorPINVOKE.CCNF_patch_expert_ComputeSigmas(swigCPtr, SWIGTYPE_p_std__vectorT_cv__Mat_T_float_t_t.getCPtr(sigma_components), window_size);
    if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

}
