namespace Unity.XGamingRuntime;

[Token(Token = "0x200000B")]
public sealed class HCWebSocketCloseEventFunction : MulticastDelegate
{

	[Address(RVA = "0x1C4BDC0", Offset = "0x1C4B1C0", Length = "0x125")]
	[Token(Token = "0x600002C")]
	public HCWebSocketCloseEventFunction(object object, IntPtr method) { }

	[Address(RVA = "0x2B339F0", Offset = "0x2B32DF0", Length = "0x82")]
	[Token(Token = "0x600002E")]
	public override IAsyncResult BeginInvoke(HCWebsocketHandle websocket, HCWebSocketCloseStatus closeStatus, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x600002F")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x600002D")]
	public override void Invoke(HCWebsocketHandle websocket, HCWebSocketCloseStatus closeStatus) { }

}

