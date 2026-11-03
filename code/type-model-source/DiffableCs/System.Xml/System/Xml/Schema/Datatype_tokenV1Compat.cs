namespace System.Xml.Schema;

[Token(Token = "0x200019B")]
internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat
{

	[Token(Token = "0x1700047B")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
		[Token(Token = "0x6001077")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x259DF30", Offset = "0x259D330", Length = "0x7")]
	[Token(Token = "0x6001078")]
	public Datatype_tokenV1Compat() { }

	[Address(RVA = "0x9DCBC0", Offset = "0x9DBFC0", Length = "0x6")]
	[Token(Token = "0x6001077")]
	public virtual XmlTypeCode get_TypeCode() { }

}

