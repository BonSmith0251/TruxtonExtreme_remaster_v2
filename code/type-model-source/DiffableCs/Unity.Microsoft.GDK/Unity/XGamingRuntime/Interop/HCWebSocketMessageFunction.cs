namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002AC")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class HCWebSocketMessageFunction : MulticastDelegate
{

	[Address(RVA = "0x60D9B0", Offset = "0x60CDB0", Length = "0xA6")]
	[Token(Token = "0x6000DEE")]
	public HCWebSocketMessageFunction(object object, IntPtr method) { }

	[Address(RVA = "0x60D920", Offset = "0x60CD20", Length = "0x83")]
	[Token(Token = "0x6000DF0")]
	public override IAsyncResult BeginInvoke(IntPtr websocket, IntPtr incomingBodyString, IntPtr functionContext, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000DF1")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6000DEF")]
	public override void Invoke(IntPtr websocket, IntPtr incomingBodyString, IntPtr functionContext) { }

}

