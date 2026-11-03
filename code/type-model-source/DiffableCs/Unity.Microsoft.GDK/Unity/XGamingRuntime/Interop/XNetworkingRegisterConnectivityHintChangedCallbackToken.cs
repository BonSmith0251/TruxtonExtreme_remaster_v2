namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x200036F")]
internal class XNetworkingRegisterConnectivityHintChangedCallbackToken : XRegistrationToken<XNetworkingConnectivityHintChangedCallback>
{

	[Address(RVA = "0x2BA3090", Offset = "0x2BA2490", Length = "0x116")]
	[Token(Token = "0x60011E6")]
	public XNetworkingRegisterConnectivityHintChangedCallbackToken(XNetworkingConnectivityHintChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA2E00", Offset = "0x2BA2200", Length = "0x9B")]
	[Token(Token = "0x60011E8")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA2EA0", Offset = "0x2BA22A0", Length = "0x12C")]
	[MonoPInvokeCallback(typeof(XNetworkingConnectivityHintChangedCallback))]
	[Token(Token = "0x60011E5")]
	private static void OnConnectivityHintChanged(IntPtr context, XNetworkingConnectivityHint connectivityHint) { }

	[Address(RVA = "0x2BA2FD0", Offset = "0x2BA23D0", Length = "0xB7")]
	[Token(Token = "0x60011E7")]
	public bool Unregister(bool wait) { }

}

