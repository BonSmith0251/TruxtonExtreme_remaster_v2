namespace System.Xml.Schema;

[Token(Token = "0x20001C1")]
internal class StringFacetsChecker : FacetsChecker
{
	[Token(Token = "0x4000867")]
	private static Regex languagePattern; //Field offset: 0x0

	[Token(Token = "0x170004C5")]
	private static Regex LanguagePattern
	{
		[Address(RVA = "0x25B4EF0", Offset = "0x25B42F0", Length = "0xA9")]
		[Token(Token = "0x600116E")]
		private get { } //Length: 169
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001175")]
	public StringFacetsChecker() { }

	[Address(RVA = "0x25B4530", Offset = "0x25B3930", Length = "0x2BC")]
	[Token(Token = "0x6001174")]
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	[Address(RVA = "0x25B4840", Offset = "0x25B3C40", Length = "0x81")]
	[Token(Token = "0x600116F")]
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B4820", Offset = "0x25B3C20", Length = "0x1A")]
	[Token(Token = "0x6001170")]
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B48D0", Offset = "0x25B3CD0", Length = "0x24C")]
	[Token(Token = "0x6001171")]
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	[Address(RVA = "0x25B4EF0", Offset = "0x25B42F0", Length = "0xA9")]
	[Token(Token = "0x600116E")]
	private static Regex get_LanguagePattern() { }

	[Address(RVA = "0x25B4CF0", Offset = "0x25B40F0", Length = "0x1FF")]
	[Token(Token = "0x6001172")]
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	[Address(RVA = "0x25B4B20", Offset = "0x25B3F20", Length = "0x1CC")]
	[Token(Token = "0x6001173")]
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}

