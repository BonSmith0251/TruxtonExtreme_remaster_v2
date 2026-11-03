namespace Unity.XGamingRuntime;

[Token(Token = "0x200000A")]
public sealed class HCWebSocketBinaryMessageFunction : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000028")]
	public HCWebSocketBinaryMessageFunction(object object, IntPtr method) { }

	[Address(RVA = "0x639C50", Offset = "0x639050", Length = "0x31")]
	[Token(Token = "0x600002A")]
	public override IAsyncResult BeginInvoke(HCWebsocketHandle websocket, Byte[] payloadBytes, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x600002B")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000029")]
	public override void Invoke(HCWebsocketHandle websocket, Byte[] payloadBytes) { }

}

