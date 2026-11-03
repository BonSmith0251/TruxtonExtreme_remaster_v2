namespace System.Xml;

[Token(Token = "0x200009C")]
public class XmlImplementation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000472")]
	private XmlNameTable nameTable; //Field offset: 0x10

	[Token(Token = "0x17000238")]
	internal XmlNameTable NameTable
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000892")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x251CA90", Offset = "0x251BE90", Length = "0x66")]
	[Token(Token = "0x600088F")]
	public XmlImplementation() { }

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x6000890")]
	public XmlImplementation(XmlNameTable nt) { }

	[Address(RVA = "0x251CA30", Offset = "0x251BE30", Length = "0x54")]
	[Token(Token = "0x6000891")]
	public override XmlDocument CreateDocument() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000892")]
	internal XmlNameTable get_NameTable() { }

}

