namespace System.Xml.Schema;

[Token(Token = "0x200018E")]
internal class Datatype_date : Datatype_dateTimeBase
{

	[Token(Token = "0x17000454")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCC80", Offset = "0x9DC080", Length = "0x6")]
		[Token(Token = "0x6001034")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A24C0", Offset = "0x25A18C0", Length = "0x4F")]
	[Token(Token = "0x6001035")]
	internal Datatype_date() { }

	[Address(RVA = "0x9DCC80", Offset = "0x9DC080", Length = "0x6")]
	[Token(Token = "0x6001034")]
	public virtual XmlTypeCode get_TypeCode() { }

}

