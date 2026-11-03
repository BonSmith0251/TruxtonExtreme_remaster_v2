namespace System.Xml.Schema;

[Token(Token = "0x20001E1")]
internal sealed class SchemaNotation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A2E")]
	private XmlQualifiedName name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A2F")]
	private string systemLiteral; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A30")]
	private string pubid; //Field offset: 0x20

	[Token(Token = "0x17000532")]
	internal XmlQualifiedName Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600131B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000534")]
	internal string Pubid
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x600131E")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x600131F")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000533")]
	internal string SystemLiteral
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600131C")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x600131D")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x600131A")]
	internal SchemaNotation(XmlQualifiedName name) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600131B")]
	internal XmlQualifiedName get_Name() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x600131E")]
	internal string get_Pubid() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600131C")]
	internal string get_SystemLiteral() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x600131F")]
	internal void set_Pubid(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x600131D")]
	internal void set_SystemLiteral(string value) { }

}

