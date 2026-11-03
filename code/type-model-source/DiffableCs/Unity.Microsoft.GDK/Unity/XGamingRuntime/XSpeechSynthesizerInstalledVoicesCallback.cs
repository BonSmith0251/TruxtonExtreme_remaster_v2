namespace Unity.XGamingRuntime;

[Token(Token = "0x200025F")]
public sealed class XSpeechSynthesizerInstalledVoicesCallback : MulticastDelegate
{

	[Address(RVA = "0x2B82510", Offset = "0x2B81910", Length = "0xB5")]
	[Token(Token = "0x6000C4C")]
	public XSpeechSynthesizerInstalledVoicesCallback(object object, IntPtr method) { }

	[Address(RVA = "0x2B82470", Offset = "0x2B81870", Length = "0x5C")]
	[Token(Token = "0x6000C4E")]
	public override IAsyncResult BeginInvoke(in XSpeechSynthesizerVoiceInformation information, IntPtr context, AsyncCallback callback, object object) { }

	[Address(RVA = "0x2B824D0", Offset = "0x2B818D0", Length = "0x30")]
	[Token(Token = "0x6000C4F")]
	public override bool EndInvoke(in XSpeechSynthesizerVoiceInformation information, IAsyncResult result) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x6000C4D")]
	public override bool Invoke(in XSpeechSynthesizerVoiceInformation information, IntPtr context) { }

}

