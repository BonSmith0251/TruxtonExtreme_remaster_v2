namespace System.Xml.Schema;

[Token(Token = "0x200019D")]
internal class Datatype_NMTOKEN : Datatype_token
{

	[Token(Token = "0x1700047E")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
		[Token(Token = "0x600107C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700047D")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x24FB6F0", Offset = "0x24FAAF0", Length = "0x6")]
		[Token(Token = "0x600107B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x259DF30", Offset = "0x259D330", Length = "0x7")]
	[Token(Token = "0x600107D")]
	public Datatype_NMTOKEN() { }

	[Address(RVA = "0x9E1830", Offset = "0x9E0C30", Length = "0x6")]
	[Token(Token = "0x600107C")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x24FB6F0", Offset = "0x24FAAF0", Length = "0x6")]
	[Token(Token = "0x600107B")]
	public virtual XmlTypeCode get_TypeCode() { }

}

