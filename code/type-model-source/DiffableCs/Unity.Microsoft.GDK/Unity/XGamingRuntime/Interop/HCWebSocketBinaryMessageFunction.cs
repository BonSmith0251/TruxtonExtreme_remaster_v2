namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002AD")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class HCWebSocketBinaryMessageFunction : MulticastDelegate
{

	[Address(RVA = "0x2B84750", Offset = "0x2B83B50", Length = "0xA6")]
	[Token(Token = "0x6000DF2")]
	public HCWebSocketBinaryMessageFunction(object object, IntPtr method) { }

	[Address(RVA = "0x2B8E820", Offset = "0x2B8DC20", Length = "0xA9")]
	[Token(Token = "0x6000DF4")]
	public override IAsyncResult BeginInvoke(IntPtr websocket, IntPtr payloadBytes, uint payloadSize, IntPtr functionContext, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000DF5")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
	[Token(Token = "0x6000DF3")]
	public override void Invoke(IntPtr websocket, IntPtr payloadBytes, uint payloadSize, IntPtr functionContext) { }

}

