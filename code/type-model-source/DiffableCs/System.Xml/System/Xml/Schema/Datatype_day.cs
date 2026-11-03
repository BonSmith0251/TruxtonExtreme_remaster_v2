namespace System.Xml.Schema;

[Token(Token = "0x2000192")]
internal class Datatype_day : Datatype_dateTimeBase
{

	[Token(Token = "0x17000458")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCB20", Offset = "0x9DBF20", Length = "0x6")]
		[Token(Token = "0x600103C")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A2780", Offset = "0x25A1B80", Length = "0x4F")]
	[Token(Token = "0x600103D")]
	internal Datatype_day() { }

	[Address(RVA = "0x9DCB20", Offset = "0x9DBF20", Length = "0x6")]
	[Token(Token = "0x600103C")]
	public virtual XmlTypeCode get_TypeCode() { }

}

