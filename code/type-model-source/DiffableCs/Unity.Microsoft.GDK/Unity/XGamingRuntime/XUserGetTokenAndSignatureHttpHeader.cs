namespace Unity.XGamingRuntime;

[Token(Token = "0x200029D")]
public class XUserGetTokenAndSignatureHttpHeader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000722")]
	internal XUserGetTokenAndSignatureHttpHeader interop; //Field offset: 0x10

	[Token(Token = "0x170002F4")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000D93")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000D94")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170002F5")]
	public string Value
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000D95")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000D96")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B7C2C0", Offset = "0x2B7B6C0", Length = "0x33")]
	[Token(Token = "0x6000D91")]
	internal XUserGetTokenAndSignatureHttpHeader(XUserGetTokenAndSignatureHttpHeader interop) { }

	[Address(RVA = "0x2B6E870", Offset = "0x2B6DC70", Length = "0x1D")]
	[Token(Token = "0x6000D92")]
	public XUserGetTokenAndSignatureHttpHeader() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000D93")]
	public string get_Name() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000D95")]
	public string get_Value() { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000D94")]
	public void set_Name(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000D96")]
	public void set_Value(string value) { }

}

