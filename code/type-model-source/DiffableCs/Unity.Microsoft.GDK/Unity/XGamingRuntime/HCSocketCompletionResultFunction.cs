namespace Unity.XGamingRuntime;

[Token(Token = "0x200000C")]
public sealed class HCSocketCompletionResultFunction : MulticastDelegate
{

	[Address(RVA = "0x119BA70", Offset = "0x119AE70", Length = "0x125")]
	[Token(Token = "0x6000030")]
	public HCSocketCompletionResultFunction(object object, IntPtr method) { }

	[Address(RVA = "0x2B33970", Offset = "0x2B32D70", Length = "0x72")]
	[Token(Token = "0x6000032")]
	public override IAsyncResult BeginInvoke(HCWebsocketHandle websocket, int errorCode, uint platformErrorCode, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000033")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6000031")]
	public override void Invoke(HCWebsocketHandle websocket, int errorCode, uint platformErrorCode) { }

}

