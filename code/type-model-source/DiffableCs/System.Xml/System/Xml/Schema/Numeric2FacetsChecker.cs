namespace System.Xml.Schema;

[Token(Token = "0x20001BE")]
internal class Numeric2FacetsChecker : FacetsChecker
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001163")]
	public Numeric2FacetsChecker() { }

	[Address(RVA = "0x25B31E0", Offset = "0x25B25E0", Length = "0x83")]
	[Token(Token = "0x600115E")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B2E90", Offset = "0x25B2290", Length = "0x32D")]
	[Token(Token = "0x600115F")]
	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B31C0", Offset = "0x25B25C0", Length = "0x18")]
	[Token(Token = "0x6001160")]
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B3330", Offset = "0x25B2730", Length = "0x115")]
	[Token(Token = "0x6001161")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B3270", Offset = "0x25B2670", Length = "0xB5")]
	[Token(Token = "0x6001162")]
	private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

}

