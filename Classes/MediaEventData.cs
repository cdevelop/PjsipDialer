//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class MediaEventData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MediaEventData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MediaEventData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MediaEventData() {
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
          pjsua2PINVOKE.delete_MediaEventData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public MediaFmtChangedEvent fmtChanged {
    set {
      pjsua2PINVOKE.MediaEventData_fmtChanged_set(swigCPtr, MediaFmtChangedEvent.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.MediaEventData_fmtChanged_get(swigCPtr);
      MediaFmtChangedEvent ret = (cPtr == global::System.IntPtr.Zero) ? null : new MediaFmtChangedEvent(cPtr, false);
      return ret;
    } 
  }

  public AudDevErrorEvent audDevError {
    set {
      pjsua2PINVOKE.MediaEventData_audDevError_set(swigCPtr, AudDevErrorEvent.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.MediaEventData_audDevError_get(swigCPtr);
      AudDevErrorEvent ret = (cPtr == global::System.IntPtr.Zero) ? null : new AudDevErrorEvent(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void ptr {
    set {
      pjsua2PINVOKE.MediaEventData_ptr_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.MediaEventData_ptr_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public MediaEventData() : this(pjsua2PINVOKE.new_MediaEventData(), true) {
  }

}
