namespace System.Xml.Schema;

[Token(Token = "0x200019F")]
internal class Datatype_NCName : Datatype_Name
{

	[Token(Token = "0x17000480")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCC50", Offset = "0x9DC050", Length = "0x6")]
		[Token(Token = "0x6001080")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x259DF30", Offset = "0x259D330", Length = "0x7")]
	[Token(Token = "0x6001082")]
	public Datatype_NCName() { }

	[Address(RVA = "0x9DCC50", Offset = "0x9DC050", Length = "0x6")]
	[Token(Token = "0x6001080")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x259F1E0", Offset = "0x259E5E0", Length = "0x139")]
	[Token(Token = "0x6001081")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

