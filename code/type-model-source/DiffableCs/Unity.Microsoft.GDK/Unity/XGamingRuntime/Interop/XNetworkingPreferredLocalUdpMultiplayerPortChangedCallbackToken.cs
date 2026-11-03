namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000370")]
internal class XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken : XRegistrationToken<XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback>
{

	[Address(RVA = "0x2BA2CE0", Offset = "0x2BA20E0", Length = "0x116")]
	[Token(Token = "0x60011EA")]
	public XNetworkingPreferredLocalUdpMultiplayerPortChangedCallbackToken(XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2BA2A60", Offset = "0x2BA1E60", Length = "0x9B")]
	[Token(Token = "0x60011EC")]
	protected virtual void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x2BA2B00", Offset = "0x2BA1F00", Length = "0x11F")]
	[MonoPInvokeCallback(typeof(XNetworkingPreferredLocalUdpMultiplayerPortChangedCallback))]
	[Token(Token = "0x60011E9")]
	private static void OnPreferredLocalUdpMultiplayerPortChanged(IntPtr context, ushort preferredLocalUdpMultiplayerPort) { }

	[Address(RVA = "0x2BA2C20", Offset = "0x2BA2020", Length = "0xB7")]
	[Token(Token = "0x60011EB")]
	public bool Unregister(bool wait) { }

}

