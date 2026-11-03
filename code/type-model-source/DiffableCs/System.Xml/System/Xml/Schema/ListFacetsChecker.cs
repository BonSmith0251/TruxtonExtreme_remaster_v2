namespace System.Xml.Schema;

[Token(Token = "0x20001C5")]
internal class ListFacetsChecker : FacetsChecker
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6001183")]
	public ListFacetsChecker() { }

	[Address(RVA = "0x2426060", Offset = "0x2425460", Length = "0x23E")]
	[Token(Token = "0x6001181")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x24262A0", Offset = "0x24256A0", Length = "0xB4")]
	[Token(Token = "0x6001182")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}

