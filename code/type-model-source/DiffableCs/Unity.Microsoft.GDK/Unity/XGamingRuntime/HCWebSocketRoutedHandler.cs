namespace Unity.XGamingRuntime;

[Token(Token = "0x200000D")]
public sealed class HCWebSocketRoutedHandler : MulticastDelegate
{

	[Address(RVA = "0x2B33B00", Offset = "0x2B32F00", Length = "0x125")]
	[Token(Token = "0x6000034")]
	public HCWebSocketRoutedHandler(object object, IntPtr method) { }

	[Address(RVA = "0x2B33A80", Offset = "0x2B32E80", Length = "0x7C")]
	[Token(Token = "0x6000036")]
	public override IAsyncResult BeginInvoke(HCWebsocketHandle websocket, bool receiving, string message, Byte[] payloadBytes, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000037")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
	[Token(Token = "0x6000035")]
	public override void Invoke(HCWebsocketHandle websocket, bool receiving, string message, Byte[] payloadBytes) { }

}

