namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002C3")]
internal struct XAppCaptureScreenshotFile
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400076B")]
	internal string path; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400076C")]
	internal long fileSize; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400076D")]
	internal uint width; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400076E")]
	internal uint height; //Field offset: 0x14

}

