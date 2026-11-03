namespace System.Xml.Schema;

[Token(Token = "0x2000184")]
internal class Datatype_duration : Datatype_anySimpleType
{
	[Token(Token = "0x400081E")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400081F")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000449")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6001016")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000445")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A3750", Offset = "0x25A2B50", Length = "0x52")]
		[Token(Token = "0x6001012")]
		internal get { } //Length: 82
	}

	[Token(Token = "0x17000448")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A37B0", Offset = "0x25A2BB0", Length = "0x4F")]
		[Token(Token = "0x6001015")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000446")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x1D31610", Offset = "0x1D30A10", Length = "0x6")]
		[Token(Token = "0x6001013")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700044A")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x25A2370", Offset = "0x25A1770", Length = "0x6")]
		[Token(Token = "0x6001017")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000447")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A3800", Offset = "0x25A2C00", Length = "0x4E")]
		[Token(Token = "0x6001014")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A3600", Offset = "0x25A2A00", Length = "0xC6")]
	[Token(Token = "0x600101B")]
	private static Datatype_duration() { }

	[Address(RVA = "0x25A36D0", Offset = "0x25A2AD0", Length = "0x7A")]
	[Token(Token = "0x600101A")]
	public Datatype_duration() { }

	[Address(RVA = "0x25A3360", Offset = "0x25A2760", Length = "0x99")]
	[Token(Token = "0x6001018")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x259F320", Offset = "0x259E720", Length = "0xA")]
	[Token(Token = "0x6001011")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6001016")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x25A3750", Offset = "0x25A2B50", Length = "0x52")]
	[Token(Token = "0x6001012")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A37B0", Offset = "0x25A2BB0", Length = "0x4F")]
	[Token(Token = "0x6001015")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x1D31610", Offset = "0x1D30A10", Length = "0x6")]
	[Token(Token = "0x6001013")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A2370", Offset = "0x25A1770", Length = "0x6")]
	[Token(Token = "0x6001017")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A3800", Offset = "0x25A2C00", Length = "0x4E")]
	[Token(Token = "0x6001014")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A3400", Offset = "0x25A2800", Length = "0x1FE")]
	[Token(Token = "0x6001019")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

