//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AudioMediaPlayerInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AudioMediaPlayerInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AudioMediaPlayerInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AudioMediaPlayerInfo() {
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
          pjsua2PINVOKE.delete_AudioMediaPlayerInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public pjmedia_format_id formatId {
    set {
      pjsua2PINVOKE.AudioMediaPlayerInfo_formatId_set(swigCPtr, (int)value);
    } 
    get {
      pjmedia_format_id ret = (pjmedia_format_id)pjsua2PINVOKE.AudioMediaPlayerInfo_formatId_get(swigCPtr);
      return ret;
    } 
  }

  public uint payloadBitsPerSample {
    set {
      pjsua2PINVOKE.AudioMediaPlayerInfo_payloadBitsPerSample_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AudioMediaPlayerInfo_payloadBitsPerSample_get(swigCPtr);
      return ret;
    } 
  }

  public uint sizeBytes {
    set {
      pjsua2PINVOKE.AudioMediaPlayerInfo_sizeBytes_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AudioMediaPlayerInfo_sizeBytes_get(swigCPtr);
      return ret;
    } 
  }

  public uint sizeSamples {
    set {
      pjsua2PINVOKE.AudioMediaPlayerInfo_sizeSamples_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AudioMediaPlayerInfo_sizeSamples_get(swigCPtr);
      return ret;
    } 
  }

  public AudioMediaPlayerInfo() : this(pjsua2PINVOKE.new_AudioMediaPlayerInfo(), true) {
  }

}
