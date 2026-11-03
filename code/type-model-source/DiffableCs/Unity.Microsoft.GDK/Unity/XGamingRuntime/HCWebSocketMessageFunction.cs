namespace Unity.XGamingRuntime;

[Token(Token = "0x2000009")]
public sealed class HCWebSocketMessageFunction : MulticastDelegate
{

	[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
	[Token(Token = "0x6000024")]
	public HCWebSocketMessageFunction(object object, IntPtr method) { }

	[Address(RVA = "0x639C50", Offset = "0x639050", Length = "0x31")]
	[Token(Token = "0x6000026")]
	public override IAsyncResult BeginInvoke(HCWebsocketHandle websocket, string incomingBodyString, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000027")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000025")]
	public override void Invoke(HCWebsocketHandle websocket, string incomingBodyString) { }

}

