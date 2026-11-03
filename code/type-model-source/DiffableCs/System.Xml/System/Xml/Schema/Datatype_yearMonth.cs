namespace System.Xml.Schema;

[Token(Token = "0x200018F")]
internal class Datatype_yearMonth : Datatype_dateTimeBase
{

	[Token(Token = "0x17000455")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x2216F30", Offset = "0x2216330", Length = "0x6")]
		[Token(Token = "0x6001036")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A8710", Offset = "0x25A7B10", Length = "0x4F")]
	[Token(Token = "0x6001037")]
	internal Datatype_yearMonth() { }

	[Address(RVA = "0x2216F30", Offset = "0x2216330", Length = "0x6")]
	[Token(Token = "0x6001036")]
	public virtual XmlTypeCode get_TypeCode() { }

}

