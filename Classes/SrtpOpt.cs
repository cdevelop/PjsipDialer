//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class SrtpOpt : PersistentObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SrtpOpt(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.SrtpOpt_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SrtpOpt obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_SrtpOpt(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public SrtpCryptoVector cryptos {
    set {
      pjsua2PINVOKE.SrtpOpt_cryptos_set(swigCPtr, SrtpCryptoVector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SrtpOpt_cryptos_get(swigCPtr);
      SrtpCryptoVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SrtpCryptoVector(cPtr, false);
      return ret;
    } 
  }

  public IntVector keyings {
    set {
      pjsua2PINVOKE.SrtpOpt_keyings_set(swigCPtr, IntVector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SrtpOpt_keyings_get(swigCPtr);
      IntVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntVector(cPtr, false);
      return ret;
    } 
  }

  public SrtpOpt() : this(pjsua2PINVOKE.new_SrtpOpt(), true) {
  }

  public override void readObject(ContainerNode node) {
    pjsua2PINVOKE.SrtpOpt_readObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public override void writeObject(ContainerNode node) {
    pjsua2PINVOKE.SrtpOpt_writeObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

}
