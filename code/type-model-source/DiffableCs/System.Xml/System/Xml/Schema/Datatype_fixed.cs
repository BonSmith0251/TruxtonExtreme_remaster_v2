namespace System.Xml.Schema;

[Token(Token = "0x20001B6")]
internal class Datatype_fixed : Datatype_decimal
{

	[Address(RVA = "0x25A3C60", Offset = "0x25A3060", Length = "0x49")]
	[Token(Token = "0x6001104")]
	public Datatype_fixed() { }

	[Address(RVA = "0x25A3850", Offset = "0x25A2C50", Length = "0x265")]
	[Token(Token = "0x6001102")]
	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	[Address(RVA = "0x25A3AC0", Offset = "0x25A2EC0", Length = "0x19C")]
	[Token(Token = "0x6001103")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

