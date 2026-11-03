namespace System.Xml.Schema;

[Token(Token = "0x200017C")]
internal class Datatype_anySimpleType : DatatypeImplementation
{
	[Token(Token = "0x4000813")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000814")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000423")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000FD0")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700041D")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A0520", Offset = "0x259F920", Length = "0x4F")]
		[Token(Token = "0x6000FCA")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000420")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A0570", Offset = "0x259F970", Length = "0x4F")]
		[Token(Token = "0x6000FCD")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000421")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x9DCC70", Offset = "0x9DC070", Length = "0x6")]
		[Token(Token = "0x6000FCE")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700041F")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
		[Token(Token = "0x6000FCC")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000422")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000FCF")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700041E")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A05C0", Offset = "0x259F9C0", Length = "0x4E")]
		[Token(Token = "0x6000FCB")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A0410", Offset = "0x259F810", Length = "0xBB")]
	[Token(Token = "0x6000FD4")]
	private static Datatype_anySimpleType() { }

	[Address(RVA = "0x25A04D0", Offset = "0x259F8D0", Length = "0x49")]
	[Token(Token = "0x6000FD3")]
	public Datatype_anySimpleType() { }

	[Address(RVA = "0x25A0320", Offset = "0x259F720", Length = "0x6D")]
	[Token(Token = "0x6000FD1")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A0390", Offset = "0x259F790", Length = "0x4E")]
	[Token(Token = "0x6000FC9")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000FD0")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x25A0520", Offset = "0x259F920", Length = "0x4F")]
	[Token(Token = "0x6000FCA")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A0570", Offset = "0x259F970", Length = "0x4F")]
	[Token(Token = "0x6000FCD")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x9DCC70", Offset = "0x9DC070", Length = "0x6")]
	[Token(Token = "0x6000FCE")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
	[Token(Token = "0x6000FCC")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000FCF")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A05C0", Offset = "0x259F9C0", Length = "0x4E")]
	[Token(Token = "0x6000FCB")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A03E0", Offset = "0x259F7E0", Length = "0x25")]
	[Token(Token = "0x6000FD2")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

