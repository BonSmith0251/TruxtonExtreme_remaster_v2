namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x2000380")]
internal struct XSpeechSynthesizerVoiceInformation
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F0")]
	internal string Description; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40009F1")]
	internal string DisplayName; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009F2")]
	internal XSpeechSynthesizerVoiceGender Gender; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009F3")]
	internal string VoiceId; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009F4")]
	internal string Language; //Field offset: 0x20

}

