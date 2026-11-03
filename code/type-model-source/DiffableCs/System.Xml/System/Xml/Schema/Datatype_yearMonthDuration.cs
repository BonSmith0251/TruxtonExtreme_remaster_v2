namespace System.Xml.Schema;

[Token(Token = "0x2000185")]
internal class Datatype_yearMonthDuration : Datatype_duration
{

	[Token(Token = "0x1700044B")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x2263EC0", Offset = "0x22632C0", Length = "0x6")]
		[Token(Token = "0x600101D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A86C0", Offset = "0x25A7AC0", Length = "0x49")]
	[Token(Token = "0x600101E")]
	public Datatype_yearMonthDuration() { }

	[Address(RVA = "0x2263EC0", Offset = "0x22632C0", Length = "0x6")]
	[Token(Token = "0x600101D")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A84B0", Offset = "0x25A78B0", Length = "0x20B")]
	[Token(Token = "0x600101C")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

