namespace Unity.XGamingRuntime;

[Token(Token = "0x200010A")]
public sealed class XNetworkingQueryPreferredLocalUdpMultiplayerPortResultFunction : MulticastDelegate
{

	[Address(RVA = "0x2B7D040", Offset = "0x2B7C440", Length = "0xA6")]
	[Token(Token = "0x6000660")]
	public XNetworkingQueryPreferredLocalUdpMultiplayerPortResultFunction(object object, IntPtr method) { }

	[Address(RVA = "0x2B7CFC0", Offset = "0x2B7C3C0", Length = "0x75")]
	[Token(Token = "0x6000662")]
	public override IAsyncResult BeginInvoke(int errorCode, ushort preferredLocalUdpMultiplayerPort, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000663")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000661")]
	public override void Invoke(int errorCode, ushort preferredLocalUdpMultiplayerPort) { }

}

