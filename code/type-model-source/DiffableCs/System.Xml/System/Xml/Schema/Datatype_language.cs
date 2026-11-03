namespace System.Xml.Schema;

[Token(Token = "0x200019C")]
internal class Datatype_language : Datatype_token
{

	[Token(Token = "0x1700047C")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x2267D90", Offset = "0x2267190", Length = "0x6")]
		[Token(Token = "0x6001079")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x259DF30", Offset = "0x259D330", Length = "0x7")]
	[Token(Token = "0x600107A")]
	public Datatype_language() { }

	[Address(RVA = "0x2267D90", Offset = "0x2267190", Length = "0x6")]
	[Token(Token = "0x6001079")]
	public virtual XmlTypeCode get_TypeCode() { }

}

