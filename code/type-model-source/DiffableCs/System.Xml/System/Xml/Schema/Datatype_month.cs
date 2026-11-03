namespace System.Xml.Schema;

[Token(Token = "0x2000193")]
internal class Datatype_month : Datatype_dateTimeBase
{

	[Token(Token = "0x17000459")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9E1990", Offset = "0x9E0D90", Length = "0x6")]
		[Token(Token = "0x600103E")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A52A0", Offset = "0x25A46A0", Length = "0x4F")]
	[Token(Token = "0x600103F")]
	internal Datatype_month() { }

	[Address(RVA = "0x9E1990", Offset = "0x9E0D90", Length = "0x6")]
	[Token(Token = "0x600103E")]
	public virtual XmlTypeCode get_TypeCode() { }

}

