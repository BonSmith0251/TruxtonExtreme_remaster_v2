namespace System.Xml.Schema;

[Token(Token = "0x200017F")]
internal class Datatype_string : Datatype_anySimpleType
{

	[Token(Token = "0x17000428")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000FDE")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000429")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A5F90", Offset = "0x25A5390", Length = "0x4F")]
		[Token(Token = "0x6000FDF")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700042B")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000FE1")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700042A")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCC70", Offset = "0x9DC070", Length = "0x6")]
		[Token(Token = "0x6000FE0")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700042C")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
		[Token(Token = "0x6000FE2")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x25A5F10", Offset = "0x25A5310", Length = "0x7A")]
	[Token(Token = "0x6000FE4")]
	public Datatype_string() { }

	[Address(RVA = "0x25A5DF0", Offset = "0x25A51F0", Length = "0xA")]
	[Token(Token = "0x6000FDD")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000FDE")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x25A5F90", Offset = "0x25A5390", Length = "0x4F")]
	[Token(Token = "0x6000FDF")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000FE1")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x9DCC70", Offset = "0x9DC070", Length = "0x6")]
	[Token(Token = "0x6000FE0")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
	[Token(Token = "0x6000FE2")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A5E00", Offset = "0x25A5200", Length = "0x108")]
	[Token(Token = "0x6000FE3")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

