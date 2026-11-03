namespace System.Xml.Schema;

[Token(Token = "0x2000183")]
internal class Datatype_decimal : Datatype_anySimpleType
{
	[Token(Token = "0x400081B")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400081C")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x400081D")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x17000443")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x600100B")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700043F")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A2C30", Offset = "0x25A2030", Length = "0x4F")]
		[Token(Token = "0x6001007")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000442")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A2C80", Offset = "0x25A2080", Length = "0x4F")]
		[Token(Token = "0x600100A")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000440")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCDA0", Offset = "0x9DC1A0", Length = "0x6")]
		[Token(Token = "0x6001008")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000444")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x25A2CD0", Offset = "0x25A20D0", Length = "0x6")]
		[Token(Token = "0x600100C")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000441")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A2CE0", Offset = "0x25A20E0", Length = "0x4E")]
		[Token(Token = "0x6001009")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A2A10", Offset = "0x25A1E10", Length = "0x19B")]
	[Token(Token = "0x6001010")]
	private static Datatype_decimal() { }

	[Address(RVA = "0x25A2BB0", Offset = "0x25A1FB0", Length = "0x7A")]
	[Token(Token = "0x600100F")]
	public Datatype_decimal() { }

	[Address(RVA = "0x25A27D0", Offset = "0x25A1BD0", Length = "0x98")]
	[Token(Token = "0x600100D")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A2870", Offset = "0x25A1C70", Length = "0xA")]
	[Token(Token = "0x6001006")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x600100B")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x25A2C30", Offset = "0x25A2030", Length = "0x4F")]
	[Token(Token = "0x6001007")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A2C80", Offset = "0x25A2080", Length = "0x4F")]
	[Token(Token = "0x600100A")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x9DCDA0", Offset = "0x9DC1A0", Length = "0x6")]
	[Token(Token = "0x6001008")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A2CD0", Offset = "0x25A20D0", Length = "0x6")]
	[Token(Token = "0x600100C")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A2CE0", Offset = "0x25A20E0", Length = "0x4E")]
	[Token(Token = "0x6001009")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A2880", Offset = "0x25A1C80", Length = "0x18D")]
	[Token(Token = "0x600100E")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

