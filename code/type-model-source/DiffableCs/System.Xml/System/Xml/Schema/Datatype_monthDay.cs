namespace System.Xml.Schema;

[Token(Token = "0x2000191")]
internal class Datatype_monthDay : Datatype_dateTimeBase
{

	[Token(Token = "0x17000457")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x1F890D0", Offset = "0x1F884D0", Length = "0x6")]
		[Token(Token = "0x600103A")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A5250", Offset = "0x25A4650", Length = "0x4F")]
	[Token(Token = "0x600103B")]
	internal Datatype_monthDay() { }

	[Address(RVA = "0x1F890D0", Offset = "0x1F884D0", Length = "0x6")]
	[Token(Token = "0x600103A")]
	public virtual XmlTypeCode get_TypeCode() { }

}

