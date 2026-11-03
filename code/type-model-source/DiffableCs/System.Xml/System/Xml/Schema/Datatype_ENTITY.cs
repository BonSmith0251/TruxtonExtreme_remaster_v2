namespace System.Xml.Schema;

[Token(Token = "0x20001A2")]
internal class Datatype_ENTITY : Datatype_NCName
{

	[Token(Token = "0x17000486")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
		[Token(Token = "0x600108A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000485")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x259DF40", Offset = "0x259D340", Length = "0x6")]
		[Token(Token = "0x6001089")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x259DF30", Offset = "0x259D330", Length = "0x7")]
	[Token(Token = "0x600108B")]
	public Datatype_ENTITY() { }

	[Address(RVA = "0x9DCB80", Offset = "0x9DBF80", Length = "0x6")]
	[Token(Token = "0x600108A")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x259DF40", Offset = "0x259D340", Length = "0x6")]
	[Token(Token = "0x6001089")]
	public virtual XmlTypeCode get_TypeCode() { }

}

