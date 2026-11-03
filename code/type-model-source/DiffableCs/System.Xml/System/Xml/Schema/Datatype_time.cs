namespace System.Xml.Schema;

[Token(Token = "0x200018D")]
internal class Datatype_time : Datatype_dateTimeBase
{

	[Token(Token = "0x17000453")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A60D0", Offset = "0x25A54D0", Length = "0x6")]
		[Token(Token = "0x6001032")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x25A6080", Offset = "0x25A5480", Length = "0x4F")]
	[Token(Token = "0x6001033")]
	internal Datatype_time() { }

	[Address(RVA = "0x25A60D0", Offset = "0x25A54D0", Length = "0x6")]
	[Token(Token = "0x6001032")]
	public virtual XmlTypeCode get_TypeCode() { }

}

