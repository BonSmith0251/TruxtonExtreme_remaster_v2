namespace Unity.XGamingRuntime.Interop;

[Token(Token = "0x20002C1")]
internal struct XAppCaptureTakeScreenshotResult
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000761")]
	internal string localId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000762")]
	internal XAppCaptureScreenshotFormatFlag availableScreenshotFormats; //Field offset: 0x8

}

