//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class OnCallMediaEventParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OnCallMediaEventParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OnCallMediaEventParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OnCallMediaEventParam() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_OnCallMediaEventParam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint medIdx {
    set {
      pjsua2PINVOKE.OnCallMediaEventParam_medIdx_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.OnCallMediaEventParam_medIdx_get(swigCPtr);
      return ret;
    } 
  }

  public MediaEvent ev {
    set {
      pjsua2PINVOKE.OnCallMediaEventParam_ev_set(swigCPtr, MediaEvent.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnCallMediaEventParam_ev_get(swigCPtr);
      MediaEvent ret = (cPtr == global::System.IntPtr.Zero) ? null : new MediaEvent(cPtr, false);
      return ret;
    } 
  }

  public OnCallMediaEventParam() : this(pjsua2PINVOKE.new_OnCallMediaEventParam(), true) {
  }

}
