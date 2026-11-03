namespace System.Xml.Schema;

[Token(Token = "0x2000198")]
internal class Datatype_normalizedString : Datatype_string
{

	[Token(Token = "0x17000475")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x600106E")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000476")]
	internal virtual bool HasValueFacets
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600106F")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000474")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A5780", Offset = "0x25A4B80", Length = "0x6")]
		[Token(Token = "0x600106D")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x259DF30", Offset = "0x259D330", Length = "0x7")]
	[Token(Token = "0x6001070")]
	public Datatype_normalizedString() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x600106E")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600106F")]
	internal virtual bool get_HasValueFacets() { }

	[Address(RVA = "0x25A5780", Offset = "0x25A4B80", Length = "0x6")]
	[Token(Token = "0x600106D")]
	public virtual XmlTypeCode get_TypeCode() { }

}

