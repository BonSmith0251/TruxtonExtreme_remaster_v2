namespace System.Xml.Schema;

[Token(Token = "0x200019E")]
internal class Datatype_Name : Datatype_token
{

	[Token(Token = "0x1700047F")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x259FA10", Offset = "0x259EE10", Length = "0x6")]
		[Token(Token = "0x600107E")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x259DF30", Offset = "0x259D330", Length = "0x7")]
	[Token(Token = "0x600107F")]
	public Datatype_Name() { }

	[Address(RVA = "0x259FA10", Offset = "0x259EE10", Length = "0x6")]
	[Token(Token = "0x600107E")]
	public virtual XmlTypeCode get_TypeCode() { }

}

