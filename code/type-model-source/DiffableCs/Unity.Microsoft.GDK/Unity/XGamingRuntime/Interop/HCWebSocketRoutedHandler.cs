namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002AF")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class HCWebSocketRoutedHandler : MulticastDelegate
{

	[Address(RVA = "0x2B8EB30", Offset = "0x2B8DF30", Length = "0xA6")]
	[Token(Token = "0x6000DFA")]
	public HCWebSocketRoutedHandler(object object, IntPtr method) { }

	[Address(RVA = "0x2B8EA20", Offset = "0x2B8DE20", Length = "0x10E")]
	[Token(Token = "0x6000DFC")]
	public override IAsyncResult BeginInvoke(IntPtr websocket, NativeBool receiving, IntPtr message, IntPtr payloadBytes, SizeT payloadSize, IntPtr conext, AsyncCallback callback, object object) { }

	[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
	[Token(Token = "0x6000DFD")]
	public override void EndInvoke(IAsyncResult result) { }

	[Address(RVA = "0x1C17FD0", Offset = "0x1C173D0", Length = "0x14")]
	[Token(Token = "0x6000DFB")]
	public override void Invoke(IntPtr websocket, NativeBool receiving, IntPtr message, IntPtr payloadBytes, SizeT payloadSize, IntPtr conext) { }

}

