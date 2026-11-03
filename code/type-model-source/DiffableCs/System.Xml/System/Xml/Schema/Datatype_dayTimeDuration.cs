namespace System.Xml.Schema;

[Token(Token = "0x2000186")]
internal class Datatype_dayTimeDuration : Datatype_duration
{

	[Token(Token = "0x1700044C")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A2770", Offset = "0x25A1B70", Length = "0x6")]
		[Token(Token = "0x6001020")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A2720", Offset = "0x25A1B20", Length = "0x49")]
	[Token(Token = "0x6001021")]
	public Datatype_dayTimeDuration() { }

	[Address(RVA = "0x25A2770", Offset = "0x25A1B70", Length = "0x6")]
	[Token(Token = "0x6001020")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A2510", Offset = "0x25A1910", Length = "0x20B")]
	[Token(Token = "0x600101F")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

