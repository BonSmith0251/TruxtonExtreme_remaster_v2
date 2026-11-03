namespace System.Xml.Linq;

[Token(Token = "0x200000C")]
public class XDeclaration
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000013")]
	private string _version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000014")]
	private string _encoding; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000015")]
	private string _standalone; //Field offset: 0x20

	[Token(Token = "0x1700000B")]
	public string Encoding
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000043")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000044")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000C")]
	public string Standalone
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000045")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x6000046")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000D")]
	public string Version
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000047")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xA96E10", Offset = "0xA96210", Length = "0x6B")]
	[Token(Token = "0x6000041")]
	public XDeclaration(string version, string encoding, string standalone) { }

	[Address(RVA = "0x240A790", Offset = "0x2409B90", Length = "0xA1")]
	[Token(Token = "0x6000042")]
	public XDeclaration(XDeclaration other) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000043")]
	public string get_Encoding() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000045")]
	public string get_Standalone() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000047")]
	public string get_Version() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000044")]
	public void set_Encoding(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x6000046")]
	public void set_Standalone(string value) { }

	[Address(RVA = "0x240A5D0", Offset = "0x24099D0", Length = "0x1BC")]
	[Token(Token = "0x6000048")]
	public virtual string ToString() { }

}

