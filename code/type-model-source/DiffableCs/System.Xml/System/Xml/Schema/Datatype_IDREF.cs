namespace System.Xml.Schema;

[Token(Token = "0x20001A1")]
internal class Datatype_IDREF : Datatype_NCName
{

	[Token(Token = "0x17000484")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6001087")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000483")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x2268DB0", Offset = "0x22681B0", Length = "0x6")]
		[Token(Token = "0x6001086")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x259DF30", Offset = "0x259D330", Length = "0x7")]
	[Token(Token = "0x6001088")]
	public Datatype_IDREF() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6001087")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x2268DB0", Offset = "0x22681B0", Length = "0x6")]
	[Token(Token = "0x6001086")]
	public virtual XmlTypeCode get_TypeCode() { }

}

