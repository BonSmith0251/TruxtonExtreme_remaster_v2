namespace System.Xml.Schema;

[Token(Token = "0x20001C0")]
internal class DateTimeFacetsChecker : FacetsChecker
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600116D")]
	public DateTimeFacetsChecker() { }

	[Address(RVA = "0x25A8C20", Offset = "0x25A8020", Length = "0x83")]
	[Token(Token = "0x6001169")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25A87C0", Offset = "0x25A7BC0", Length = "0x453")]
	[Token(Token = "0x600116A")]
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25A8CB0", Offset = "0x25A80B0", Length = "0x8D")]
	[Token(Token = "0x600116B")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25A8D40", Offset = "0x25A8140", Length = "0x13B")]
	[Token(Token = "0x600116C")]
	private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}

