namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000355")]
internal class XGameProtocolActivationToken : XRegistrationToken<XGameProtocolActivationCallback>
{

	[Address(RVA = "0x2BA1370", Offset = "0x2BA0770", Length = "0x116")]
	[Token(Token = "0x60011C5")]
	public XGameProtocolActivationToken(XGameProtocolActivationCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA10F0", Offset = "0x2BA04F0", Length = "0x9B")]
	[Token(Token = "0x60011C7")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA1190", Offset = "0x2BA0590", Length = "0x11E")]
	[MonoPInvokeCallback(typeof(XGameProtocolActivationCallback))]
	[Token(Token = "0x60011C4")]
	private static void OnProtocolActivation(IntPtr context, string protocolUri) { }

	[Address(RVA = "0x2BA12B0", Offset = "0x2BA06B0", Length = "0xB7")]
	[Token(Token = "0x60011C6")]
	public bool Unregister(bool wait) { }

}

