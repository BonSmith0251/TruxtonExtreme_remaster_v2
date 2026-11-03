namespace System.Xml.Schema;

[Token(Token = "0x20001C6")]
internal class UnionFacetsChecker : FacetsChecker
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6001186")]
	public UnionFacetsChecker() { }

	[Address(RVA = "0x24343F0", Offset = "0x24337F0", Length = "0xF3")]
	[Token(Token = "0x6001184")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x24262A0", Offset = "0x24256A0", Length = "0xB4")]
	[Token(Token = "0x6001185")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}

