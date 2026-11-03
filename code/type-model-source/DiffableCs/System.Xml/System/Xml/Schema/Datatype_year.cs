namespace System.Xml.Schema;

[Token(Token = "0x2000190")]
internal class Datatype_year : Datatype_dateTimeBase
{

	[Token(Token = "0x17000456")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A87B0", Offset = "0x25A7BB0", Length = "0x6")]
		[Token(Token = "0x6001038")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A8760", Offset = "0x25A7B60", Length = "0x4F")]
	[Token(Token = "0x6001039")]
	internal Datatype_year() { }

	[Address(RVA = "0x25A87B0", Offset = "0x25A7BB0", Length = "0x6")]
	[Token(Token = "0x6001038")]
	public virtual XmlTypeCode get_TypeCode() { }

}

