namespace System.Xml.Schema;

[Token(Token = "0x20001A0")]
internal class Datatype_ID : Datatype_NCName
{

	[Token(Token = "0x17000482")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6001084")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000481")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x259DF50", Offset = "0x259D350", Length = "0x6")]
		[Token(Token = "0x6001083")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x259DF30", Offset = "0x259D330", Length = "0x7")]
	[Token(Token = "0x6001085")]
	public Datatype_ID() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6001084")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x259DF50", Offset = "0x259D350", Length = "0x6")]
	[Token(Token = "0x6001083")]
	public virtual XmlTypeCode get_TypeCode() { }

}

