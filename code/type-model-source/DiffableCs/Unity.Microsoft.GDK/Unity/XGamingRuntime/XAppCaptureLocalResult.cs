namespace Unity.XGamingRuntime;

[Token(Token = "0x20000F9")]
public class XAppCaptureLocalResult
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C8")]
	internal XAppCaptureLocalStreamHandle _clipHandle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C9")]
	internal SYSTEMTIME _clipStartTimestamp; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001CA")]
	internal XAppCaptureLocalResult interop; //Field offset: 0x20

	[Token(Token = "0x17000021")]
	public XAppCaptureLocalStreamHandle ClipHandle
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60005A7")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60005A8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000023")]
	public SYSTEMTIME ClipStartTimestamp
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60005AB")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60005AC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000028")]
	public XAppCaptureVideoColorFormat ColorFormat
	{
		[Address(RVA = "0x1CF2AF0", Offset = "0x1CF1EF0", Length = "0x5")]
		[Token(Token = "0x60005B5")]
		 get { } //Length: 5
		[Address(RVA = "0x1CEA8A0", Offset = "0x1CE9CA0", Length = "0x4")]
		[Token(Token = "0x60005B6")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000024")]
	public ulong DurationInMilliseconds
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60005AD")]
		 get { } //Length: 5
		[Address(RVA = "0x1116970", Offset = "0x1115D70", Length = "0x5")]
		[Token(Token = "0x60005AE")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000027")]
	public XAppCaptureVideoEncoding Encoding
	{
		[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
		[Token(Token = "0x60005B3")]
		 get { } //Length: 5
		[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
		[Token(Token = "0x60005B4")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000022")]
	public ulong FileSizeInBytes
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60005A9")]
		 get { } //Length: 5
		[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
		[Token(Token = "0x60005AA")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000026")]
	public uint Height
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x60005B1")]
		 get { } //Length: 4
		[Address(RVA = "0xFE2A70", Offset = "0xFE1E70", Length = "0x4")]
		[Token(Token = "0x60005B2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000025")]
	public uint Width
	{
		[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
		[Token(Token = "0x60005AF")]
		 get { } //Length: 4
		[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
		[Token(Token = "0x60005B0")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B7BFB0", Offset = "0x2B7B3B0", Length = "0xE3")]
	[Token(Token = "0x60005A6")]
	internal XAppCaptureLocalResult(XAppCaptureLocalResult interop) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60005A7")]
	public XAppCaptureLocalStreamHandle get_ClipHandle() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60005AB")]
	public SYSTEMTIME get_ClipStartTimestamp() { }

	[Address(RVA = "0x1CF2AF0", Offset = "0x1CF1EF0", Length = "0x5")]
	[Token(Token = "0x60005B5")]
	public XAppCaptureVideoColorFormat get_ColorFormat() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60005AD")]
	public ulong get_DurationInMilliseconds() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[Token(Token = "0x60005B3")]
	public XAppCaptureVideoEncoding get_Encoding() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60005A9")]
	public ulong get_FileSizeInBytes() { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x60005B1")]
	public uint get_Height() { }

	[Address(RVA = "0xE0D6C0", Offset = "0xE0CAC0", Length = "0x4")]
	[Token(Token = "0x60005AF")]
	public uint get_Width() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60005A8")]
	public void set_ClipHandle(XAppCaptureLocalStreamHandle value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x60005AC")]
	public void set_ClipStartTimestamp(SYSTEMTIME value) { }

	[Address(RVA = "0x1CEA8A0", Offset = "0x1CE9CA0", Length = "0x4")]
	[Token(Token = "0x60005B6")]
	public void set_ColorFormat(XAppCaptureVideoColorFormat value) { }

	[Address(RVA = "0x1116970", Offset = "0x1115D70", Length = "0x5")]
	[Token(Token = "0x60005AE")]
	public void set_DurationInMilliseconds(ulong value) { }

	[Address(RVA = "0x1D3A970", Offset = "0x1D39D70", Length = "0x4")]
	[Token(Token = "0x60005B4")]
	public void set_Encoding(XAppCaptureVideoEncoding value) { }

	[Address(RVA = "0x16C44D0", Offset = "0x16C38D0", Length = "0x5")]
	[Token(Token = "0x60005AA")]
	public void set_FileSizeInBytes(ulong value) { }

	[Address(RVA = "0xFE2A70", Offset = "0xFE1E70", Length = "0x4")]
	[Token(Token = "0x60005B2")]
	public void set_Height(uint value) { }

	[Address(RVA = "0xE0D7D0", Offset = "0xE0CBD0", Length = "0x4")]
	[Token(Token = "0x60005B0")]
	public void set_Width(uint value) { }

}

