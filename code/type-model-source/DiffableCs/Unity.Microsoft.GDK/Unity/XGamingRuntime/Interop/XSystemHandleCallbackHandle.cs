namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200039A")]
internal class XSystemHandleCallbackHandle : XRegistrationToken<XSystemHandleCallback>
{

	[Address(RVA = "0x2BA4490", Offset = "0x2BA3890", Length = "0x116")]
	[Token(Token = "0x600122F")]
	public XSystemHandleCallbackHandle(XSystemHandleCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA42B0", Offset = "0x2BA36B0", Length = "0x7D")]
	[Token(Token = "0x6001231")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA4330", Offset = "0x2BA3730", Length = "0x154")]
	[MonoPInvokeCallback(typeof(XSystemHandleCallback))]
	[Token(Token = "0x600122E")]
	private static void OnHandle(IntPtr handle, XSystemHandleType type, XSystemHandleCallbackReason reason, IntPtr context) { }

	[Address(RVA = "0x2BA42B0", Offset = "0x2BA36B0", Length = "0x7D")]
	[Token(Token = "0x6001230")]
	public void Unregister() { }

}

