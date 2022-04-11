//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class OnCredAuthParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OnCredAuthParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OnCredAuthParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OnCredAuthParam() {
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
          pjsua2PINVOKE.delete_OnCredAuthParam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public DigestChallenge digestChallenge {
    set {
      pjsua2PINVOKE.OnCredAuthParam_digestChallenge_set(swigCPtr, DigestChallenge.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnCredAuthParam_digestChallenge_get(swigCPtr);
      DigestChallenge ret = (cPtr == global::System.IntPtr.Zero) ? null : new DigestChallenge(cPtr, false);
      return ret;
    } 
  }

  public AuthCredInfo credentialInfo {
    set {
      pjsua2PINVOKE.OnCredAuthParam_credentialInfo_set(swigCPtr, AuthCredInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnCredAuthParam_credentialInfo_get(swigCPtr);
      AuthCredInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new AuthCredInfo(cPtr, false);
      return ret;
    } 
  }

  public string method {
    set {
      pjsua2PINVOKE.OnCredAuthParam_method_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.OnCredAuthParam_method_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public DigestCredential digestCredential {
    set {
      pjsua2PINVOKE.OnCredAuthParam_digestCredential_set(swigCPtr, DigestCredential.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnCredAuthParam_digestCredential_get(swigCPtr);
      DigestCredential ret = (cPtr == global::System.IntPtr.Zero) ? null : new DigestCredential(cPtr, false);
      return ret;
    } 
  }

  public OnCredAuthParam() : this(pjsua2PINVOKE.new_OnCredAuthParam(), true) {
  }

}
