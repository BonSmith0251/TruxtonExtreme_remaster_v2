namespace System.Xml;

[Token(Token = "0x200008C")]
internal class DomNameTable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400041D")]
	private XmlName[] entries; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400041E")]
	private int count; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400041F")]
	private int mask; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000420")]
	private XmlDocument ownerDocument; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000421")]
	private XmlNameTable nameTable; //Field offset: 0x28

	[Address(RVA = "0x2510F20", Offset = "0x2510320", Length = "0x9D")]
	[Token(Token = "0x600074B")]
	public DomNameTable(XmlDocument document) { }

	[Address(RVA = "0x25108A0", Offset = "0x250FCA0", Length = "0x3CA")]
	[Token(Token = "0x600074D")]
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x2510C70", Offset = "0x2510070", Length = "0x13D")]
	[Token(Token = "0x600074C")]
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	[Address(RVA = "0x2510DB0", Offset = "0x25101B0", Length = "0x161")]
	[Token(Token = "0x600074E")]
	private void Grow() { }

}

