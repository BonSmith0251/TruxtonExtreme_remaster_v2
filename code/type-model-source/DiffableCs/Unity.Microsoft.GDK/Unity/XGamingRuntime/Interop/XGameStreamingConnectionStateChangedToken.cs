namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000362")]
internal class XGameStreamingConnectionStateChangedToken : XRegistrationToken<XGameStreamingConnectionStateChangedCallback>
{

	[Address(RVA = "0x2BA1BF0", Offset = "0x2BA0FF0", Length = "0x116")]
	[Token(Token = "0x60011D5")]
	public XGameStreamingConnectionStateChangedToken(XGameStreamingConnectionStateChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA1950", Offset = "0x2BA0D50", Length = "0x9B")]
	[Token(Token = "0x60011D7")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA19F0", Offset = "0x2BA0DF0", Length = "0x13C")]
	[MonoPInvokeCallback(typeof(XGameStreamingConnectionStateChangedCallback))]
	[Token(Token = "0x60011D4")]
	private static void OnConnectionStateChanged(IntPtr context, XGameStreamingClientId client, XGameStreamingConnectionState state) { }

	[Address(RVA = "0x2BA1B30", Offset = "0x2BA0F30", Length = "0xB7")]
	[Token(Token = "0x60011D6")]
	public bool Unregister(bool wait) { }

}

