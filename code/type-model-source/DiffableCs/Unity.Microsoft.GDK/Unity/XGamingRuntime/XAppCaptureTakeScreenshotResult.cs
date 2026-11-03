namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20000FC")]
public class XAppCaptureTakeScreenshotResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CD")]
	internal XAppCaptureTakeScreenshotResult data; //Field offset: 0x10

	[Token(Token = "0x1700003D")]
	public XAppCaptureScreenshotFormatFlag AvailableScreenshotFormats
	{
		[Address(RVA = "0x10A5BC0", Offset = "0x10A4FC0", Length = "0x5")]
		[Token(Token = "0x60005E4")]
		 get { } //Length: 5
		[Address(RVA = "0x2B6E8F0", Offset = "0x2B6DCF0", Length = "0x5")]
		[Token(Token = "0x60005E5")]
		 set { } //Length: 5
	}

	[Obsolete("XAppScreenshotLocalId will be removed in future releases. Use XAppCaptureTakeScreenshotResult.localId", False)]
	[Token(Token = "0x1700003E")]
	public XAppScreenshotLocalId Id
	{
		[Address(RVA = "0x2B7C300", Offset = "0x2B7B700", Length = "0x90")]
		[Token(Token = "0x60005E6")]
		 get { } //Length: 144
	}

	[Token(Token = "0x1700003C")]
	public string LocalId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60005E2")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x60005E3")]
		 set { } //Length: 12
	}

	[Address(RVA = "0x2B7C2C0", Offset = "0x2B7B6C0", Length = "0x33")]
	[Token(Token = "0x60005E0")]
	internal XAppCaptureTakeScreenshotResult(XAppCaptureTakeScreenshotResult interop) { }

	[Address(RVA = "0x2B6E870", Offset = "0x2B6DC70", Length = "0x1D")]
	[Token(Token = "0x60005E1")]
	public XAppCaptureTakeScreenshotResult() { }

	[Address(RVA = "0x10A5BC0", Offset = "0x10A4FC0", Length = "0x5")]
	[Token(Token = "0x60005E4")]
	public XAppCaptureScreenshotFormatFlag get_AvailableScreenshotFormats() { }

	[Address(RVA = "0x2B7C300", Offset = "0x2B7B700", Length = "0x90")]
	[Token(Token = "0x60005E6")]
	public XAppScreenshotLocalId get_Id() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60005E2")]
	public string get_LocalId() { }

	[Address(RVA = "0x2B6E8F0", Offset = "0x2B6DCF0", Length = "0x5")]
	[Token(Token = "0x60005E5")]
	public void set_AvailableScreenshotFormats(XAppCaptureScreenshotFormatFlag value) { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x60005E3")]
	public void set_LocalId(string value) { }

}

