namespace System.Xml.Schema;

[Token(Token = "0x20001BD")]
internal class Numeric10FacetsChecker : FacetsChecker
{
	[Token(Token = "0x4000864")]
	private static readonly Char[] signs; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000865")]
	private decimal maxValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000866")]
	private decimal minValue; //Field offset: 0x20

	[Address(RVA = "0x25B2DB0", Offset = "0x25B21B0", Length = "0x90")]
	[Token(Token = "0x600115D")]
	private static Numeric10FacetsChecker() { }

	[Address(RVA = "0x25B2E50", Offset = "0x25B2250", Length = "0x3D")]
	[Token(Token = "0x6001154")]
	internal Numeric10FacetsChecker(decimal minVal, decimal maxVal) { }

	[Address(RVA = "0x25B1DB0", Offset = "0x25B11B0", Length = "0x3A2")]
	[Token(Token = "0x600115C")]
	internal Exception CheckTotalAndFractionDigits(decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	[Address(RVA = "0x25B21F0", Offset = "0x25B15F0", Length = "0x92")]
	[Token(Token = "0x6001155")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B2290", Offset = "0x25B1690", Length = "0x730")]
	[Token(Token = "0x6001156")]
	internal virtual Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B2A60", Offset = "0x25B1E60", Length = "0x8F")]
	[Token(Token = "0x6001157")]
	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B29D0", Offset = "0x25B1DD0", Length = "0x8D")]
	[Token(Token = "0x6001158")]
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B2160", Offset = "0x25B1560", Length = "0x8F")]
	[Token(Token = "0x6001159")]
	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B2AF0", Offset = "0x25B1EF0", Length = "0x18D")]
	[Token(Token = "0x600115A")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B2C80", Offset = "0x25B2080", Length = "0x120")]
	[Token(Token = "0x600115B")]
	internal bool MatchEnumeration(decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

}

