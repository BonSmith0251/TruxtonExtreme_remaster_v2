namespace System.Xml.Schema;

[Token(Token = "0x2000199")]
internal class Datatype_normalizedStringV1Compat : Datatype_string
{

	[Token(Token = "0x17000478")]
	internal virtual bool HasValueFacets
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001072")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000477")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A5780", Offset = "0x25A4B80", Length = "0x6")]
		[Token(Token = "0x6001071")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x259DF30", Offset = "0x259D330", Length = "0x7")]
	[Token(Token = "0x6001073")]
	public Datatype_normalizedStringV1Compat() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6001072")]
	internal virtual bool get_HasValueFacets() { }

	[Address(RVA = "0x25A5780", Offset = "0x25A4B80", Length = "0x6")]
	[Token(Token = "0x6001071")]
	public virtual XmlTypeCode get_TypeCode() { }

}

