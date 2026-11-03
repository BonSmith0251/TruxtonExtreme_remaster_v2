namespace System.Xml.Schema;

[Token(Token = "0x20001BF")]
internal class DurationFacetsChecker : FacetsChecker
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001168")]
	public DurationFacetsChecker() { }

	[Address(RVA = "0x25AC060", Offset = "0x25AB460", Length = "0x11B")]
	[Token(Token = "0x6001164")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25ABCB0", Offset = "0x25AB0B0", Length = "0x3A1")]
	[Token(Token = "0x6001165")]
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25AC180", Offset = "0x25AB580", Length = "0x83")]
	[Token(Token = "0x6001166")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25AC210", Offset = "0x25AB610", Length = "0x104")]
	[Token(Token = "0x6001167")]
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

}

