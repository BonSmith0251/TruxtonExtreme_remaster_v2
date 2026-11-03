namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200029F")]
public class XUserGetTokenAndSignatureUtf16HttpHeader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000724")]
	internal XUserGetTokenAndSignatureUtf16HttpHeader interop; //Field offset: 0x10

	[Token(Token = "0x170002FA")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000DA3")]
		 get { } //Length: 5
		[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
		[Token(Token = "0x6000DA4")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170002FB")]
	public string Value
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000DA5")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000DA6")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2B7C2C0", Offset = "0x2B7B6C0", Length = "0x33")]
	[Token(Token = "0x6000DA1")]
	internal XUserGetTokenAndSignatureUtf16HttpHeader(XUserGetTokenAndSignatureUtf16HttpHeader interop) { }

	[Address(RVA = "0x2B6E870", Offset = "0x2B6DC70", Length = "0x1D")]
	[Token(Token = "0x6000DA2")]
	public XUserGetTokenAndSignatureUtf16HttpHeader() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000DA3")]
	public string get_Name() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000DA5")]
	public string get_Value() { }

	[Address(RVA = "0x2B7C170", Offset = "0x2B7B570", Length = "0xC")]
	[Token(Token = "0x6000DA4")]
	public void set_Name(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000DA6")]
	public void set_Value(string value) { }

}

