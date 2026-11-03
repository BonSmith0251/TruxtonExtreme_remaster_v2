namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000381")]
[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
internal sealed class XSpeechSynthesizerInstalledVoicesCallback : MulticastDelegate
{

	[Address(RVA = "0x2BA4150", Offset = "0x2BA3550", Length = "0xB5")]
	[Token(Token = "0x6001212")]
	public XSpeechSynthesizerInstalledVoicesCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2BA40B0", Offset = "0x2BA34B0", Length = "0x97")]
	[Token(Token = "0x6001214")]
	public override IAsyncResult BeginInvoke(in XSpeechSynthesizerVoiceInformation information, IntPtr context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2B824D0", Offset = "0x2B818D0", Length = "0x30")]
	[Token(Token = "0x6001215")]
	public override bool EndInvoke(in XSpeechSynthesizerVoiceInformation information, IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6001213")]
	public override bool Invoke(in XSpeechSynthesizerVoiceInformation information, IntPtr context) { }

}

