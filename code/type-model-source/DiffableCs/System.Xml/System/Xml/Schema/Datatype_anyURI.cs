namespace System.Xml.Schema;

[Token(Token = "0x2000196")]
internal class Datatype_anyURI : Datatype_anySimpleType
{
	[Token(Token = "0x4000827")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000828")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x1700046B")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600105C")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000466")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A09F0", Offset = "0x259FDF0", Length = "0x4F")]
		[Token(Token = "0x6001057")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000469")]
	internal virtual bool HasValueFacets
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x600105A")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700046A")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A0A40", Offset = "0x259FE40", Length = "0x4F")]
		[Token(Token = "0x600105B")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000467")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCC00", Offset = "0x9DC000", Length = "0x6")]
		[Token(Token = "0x6001058")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700046C")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
		[Token(Token = "0x600105D")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000468")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A0A90", Offset = "0x259FE90", Length = "0x4E")]
		[Token(Token = "0x6001059")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A08A0", Offset = "0x259FCA0", Length = "0xC6")]
	[Token(Token = "0x6001061")]
	private static Datatype_anyURI() { }

	[Address(RVA = "0x25A0970", Offset = "0x259FD70", Length = "0x7A")]
	[Token(Token = "0x6001060")]
	public Datatype_anyURI() { }

	[Address(RVA = "0x25A0610", Offset = "0x259FA10", Length = "0xC8")]
	[Token(Token = "0x600105E")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x259F320", Offset = "0x259E720", Length = "0xA")]
	[Token(Token = "0x6001056")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x600105C")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x25A09F0", Offset = "0x259FDF0", Length = "0x4F")]
	[Token(Token = "0x6001057")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600105A")]
	internal virtual bool get_HasValueFacets() { }

	[Address(RVA = "0x25A0A40", Offset = "0x259FE40", Length = "0x4F")]
	[Token(Token = "0x600105B")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x9DCC00", Offset = "0x9DC000", Length = "0x6")]
	[Token(Token = "0x6001058")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
	[Token(Token = "0x600105D")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A0A90", Offset = "0x259FE90", Length = "0x4E")]
	[Token(Token = "0x6001059")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A06E0", Offset = "0x259FAE0", Length = "0x1B1")]
	[Token(Token = "0x600105F")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

