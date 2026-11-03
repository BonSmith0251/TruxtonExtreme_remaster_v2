namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20000FA")]
public class XAppCaptureDiagnosticScreenshotResult
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CB")]
	private XAppCaptureScreenshotFile[] <Files>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000029")]
	public XAppCaptureScreenshotFile[] Files
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60005B7")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60005B8")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B7BDE0", Offset = "0x2B7B1E0", Length = "0x1C4")]
	[Token(Token = "0x60005B9")]
	internal XAppCaptureDiagnosticScreenshotResult(XAppCaptureDiagnosticScreenshotResult interop) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60005B7")]
	public XAppCaptureScreenshotFile[] get_Files() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60005B8")]
	public void set_Files(XAppCaptureScreenshotFile[] value) { }

}

