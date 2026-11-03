namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002C4")]
internal struct XAppCaptureDiagnosticScreenshotResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400076F")]
	internal long fileCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000770")]
	internal XAppCaptureScreenshotFile[] files; //Field offset: 0x8

}

