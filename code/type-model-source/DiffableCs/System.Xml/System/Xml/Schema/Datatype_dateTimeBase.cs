namespace System.Xml.Schema;

[Token(Token = "0x2000187")]
internal class Datatype_dateTimeBase : Datatype_anySimpleType
{
	[Token(Token = "0x4000820")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000821")]
	private static readonly Type listValueType; //Field offset: 0x8
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000822")]
	private XsdDateTimeFlags dateTimeFlags; //Field offset: 0x38

	[Token(Token = "0x17000451")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6001028")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700044D")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A22D0", Offset = "0x25A16D0", Length = "0x4F")]
		[Token(Token = "0x6001023")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000450")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A2320", Offset = "0x25A1720", Length = "0x4F")]
		[Token(Token = "0x6001027")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700044E")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x1E82360", Offset = "0x1E81760", Length = "0x6")]
		[Token(Token = "0x6001024")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000452")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x25A2370", Offset = "0x25A1770", Length = "0x6")]
		[Token(Token = "0x6001029")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700044F")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A2380", Offset = "0x25A1780", Length = "0x4E")]
		[Token(Token = "0x6001026")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A2170", Offset = "0x25A1570", Length = "0xC6")]
	[Token(Token = "0x600102C")]
	private static Datatype_dateTimeBase() { }

	[Address(RVA = "0x25A2240", Offset = "0x25A1640", Length = "0x89")]
	[Token(Token = "0x6001025")]
	internal Datatype_dateTimeBase(XsdDateTimeFlags dateTimeFlags) { }

	[Address(RVA = "0x25A1CA0", Offset = "0x25A10A0", Length = "0x164")]
	[Token(Token = "0x600102A")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A1E10", Offset = "0x25A1210", Length = "0xA")]
	[Token(Token = "0x6001022")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6001028")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x25A22D0", Offset = "0x25A16D0", Length = "0x4F")]
	[Token(Token = "0x6001023")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A2320", Offset = "0x25A1720", Length = "0x4F")]
	[Token(Token = "0x6001027")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x1E82360", Offset = "0x1E81760", Length = "0x6")]
	[Token(Token = "0x6001024")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A2370", Offset = "0x25A1770", Length = "0x6")]
	[Token(Token = "0x6001029")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A2380", Offset = "0x25A1780", Length = "0x4E")]
	[Token(Token = "0x6001026")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A1E20", Offset = "0x25A1220", Length = "0x34E")]
	[Token(Token = "0x600102B")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

