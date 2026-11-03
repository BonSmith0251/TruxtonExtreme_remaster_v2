namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002C8")]
internal class XIsAppBroadcastingChangedRegistrationToken : XRegistrationToken<XAppBroadcastMonitorCallback>
{

	[Address(RVA = "0x2BA2460", Offset = "0x2BA1860", Length = "0x116")]
	[Token(Token = "0x6000F97")]
	public XIsAppBroadcastingChangedRegistrationToken(XAppBroadcastMonitorCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA21F0", Offset = "0x2BA15F0", Length = "0x9B")]
	[Token(Token = "0x6000F99")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA2290", Offset = "0x2BA1690", Length = "0x10B")]
	[MonoPInvokeCallback(typeof(XAppBroadcastMonitorCallback))]
	[Token(Token = "0x6000F96")]
	private static void OnIsAppBroadcastingChanged(IntPtr context) { }

	[Address(RVA = "0x2BA23A0", Offset = "0x2BA17A0", Length = "0xB7")]
	[Token(Token = "0x6000F98")]
	public bool Unregister(bool wait) { }

}

