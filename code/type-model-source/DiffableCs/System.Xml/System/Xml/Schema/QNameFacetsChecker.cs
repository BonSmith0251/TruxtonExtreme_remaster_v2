namespace System.Xml.Schema;

[Token(Token = "0x20001C2")]
internal class QNameFacetsChecker : FacetsChecker
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600117A")]
	public QNameFacetsChecker() { }

	[Address(RVA = "0x2433FB0", Offset = "0x24333B0", Length = "0x131")]
	[Token(Token = "0x6001176")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x2433DC0", Offset = "0x24331C0", Length = "0x1EF")]
	[Token(Token = "0x6001177")]
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x2434200", Offset = "0x2433600", Length = "0x1E9")]
	[Token(Token = "0x6001178")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x24340F0", Offset = "0x24334F0", Length = "0x10E")]
	[Token(Token = "0x6001179")]
	private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration) { }

}

