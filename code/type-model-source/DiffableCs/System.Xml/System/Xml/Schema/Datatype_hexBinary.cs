namespace System.Xml.Schema;

[Token(Token = "0x2000194")]
internal class Datatype_hexBinary : Datatype_anySimpleType
{
	[Token(Token = "0x4000823")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000824")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x1700045E")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6001045")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700045A")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A46A0", Offset = "0x25A3AA0", Length = "0x4F")]
		[Token(Token = "0x6001041")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700045D")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A46F0", Offset = "0x25A3AF0", Length = "0x4F")]
		[Token(Token = "0x6001044")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700045B")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A4740", Offset = "0x25A3B40", Length = "0x6")]
		[Token(Token = "0x6001042")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700045F")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
		[Token(Token = "0x6001046")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700045C")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A4750", Offset = "0x25A3B50", Length = "0x4E")]
		[Token(Token = "0x6001043")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A4550", Offset = "0x25A3950", Length = "0xC6")]
	[Token(Token = "0x600104A")]
	private static Datatype_hexBinary() { }

	[Address(RVA = "0x25A4620", Offset = "0x25A3A20", Length = "0x7A")]
	[Token(Token = "0x6001049")]
	public Datatype_hexBinary() { }

	[Address(RVA = "0x25A42C0", Offset = "0x25A36C0", Length = "0x127")]
	[Token(Token = "0x6001047")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x259F320", Offset = "0x259E720", Length = "0xA")]
	[Token(Token = "0x6001040")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6001045")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x25A46A0", Offset = "0x25A3AA0", Length = "0x4F")]
	[Token(Token = "0x6001041")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A46F0", Offset = "0x25A3AF0", Length = "0x4F")]
	[Token(Token = "0x6001044")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x25A4740", Offset = "0x25A3B40", Length = "0x6")]
	[Token(Token = "0x6001042")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
	[Token(Token = "0x6001046")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A4750", Offset = "0x25A3B50", Length = "0x4E")]
	[Token(Token = "0x6001043")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A43F0", Offset = "0x25A37F0", Length = "0x15C")]
	[Token(Token = "0x6001048")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

