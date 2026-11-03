namespace System.Xml.Schema;

[Token(Token = "0x20001C4")]
internal class BinaryFacetsChecker : FacetsChecker
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6001180")]
	public BinaryFacetsChecker() { }

	[Address(RVA = "0x2425B70", Offset = "0x2424F70", Length = "0x95")]
	[Token(Token = "0x600117C")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x2425C10", Offset = "0x2425010", Length = "0x1D7")]
	[Token(Token = "0x600117D")]
	internal virtual Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x2425DF0", Offset = "0x24251F0", Length = "0x158")]
	[Token(Token = "0x600117E")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x2425F50", Offset = "0x2425350", Length = "0x108")]
	[Token(Token = "0x600117F")]
	private bool MatchEnumeration(Byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}

