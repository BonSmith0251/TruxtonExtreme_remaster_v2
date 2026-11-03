namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002AE")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class HCWebSocketCloseEventFunction : MulticastDelegate
{

	[Address(RVA = "0x2B8E970", Offset = "0x2B8DD70", Length = "0xA6")]
	[Token(Token = "0x6000DF6")]
	public HCWebSocketCloseEventFunction(object object, IntPtr method) { }

	[Address(RVA = "0x2B8E8D0", Offset = "0x2B8DCD0", Length = "0x9F")]
	[Token(Token = "0x6000DF8")]
	public override IAsyncResult BeginInvoke(IntPtr websocket, HCWebSocketCloseStatus closeStatus, IntPtr functionContext, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000DF9")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
	[Token(Token = "0x6000DF7")]
	public override void Invoke(IntPtr websocket, HCWebSocketCloseStatus closeStatus, IntPtr functionContext) { }

}

