namespace System.Xml.Schema;

[Token(Token = "0x20001A4")]
internal class Datatype_integer : Datatype_decimal
{

	[Token(Token = "0x1700048E")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCBB0", Offset = "0x9DBFB0", Length = "0x6")]
		[Token(Token = "0x6001098")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A4DB0", Offset = "0x25A41B0", Length = "0x49")]
	[Token(Token = "0x600109A")]
	public Datatype_integer() { }

	[Address(RVA = "0x9DCBB0", Offset = "0x9DBFB0", Length = "0x6")]
	[Token(Token = "0x6001098")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A4C50", Offset = "0x25A4050", Length = "0x15D")]
	[Token(Token = "0x6001099")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

