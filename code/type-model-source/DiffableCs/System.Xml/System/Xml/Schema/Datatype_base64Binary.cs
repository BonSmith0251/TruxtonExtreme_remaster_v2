namespace System.Xml.Schema;

[Token(Token = "0x2000195")]
internal class Datatype_base64Binary : Datatype_anySimpleType
{
	[Token(Token = "0x4000825")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000826")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000464")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6001050")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000460")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A0EC0", Offset = "0x25A02C0", Length = "0x4F")]
		[Token(Token = "0x600104C")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000463")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A0F10", Offset = "0x25A0310", Length = "0x4F")]
		[Token(Token = "0x600104F")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000461")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A0F60", Offset = "0x25A0360", Length = "0x6")]
		[Token(Token = "0x600104D")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000465")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
		[Token(Token = "0x6001051")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000462")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A0F70", Offset = "0x25A0370", Length = "0x4E")]
		[Token(Token = "0x600104E")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A0D70", Offset = "0x25A0170", Length = "0xC6")]
	[Token(Token = "0x6001055")]
	private static Datatype_base64Binary() { }

	[Address(RVA = "0x25A0E40", Offset = "0x25A0240", Length = "0x7A")]
	[Token(Token = "0x6001054")]
	public Datatype_base64Binary() { }

	[Address(RVA = "0x25A0AE0", Offset = "0x259FEE0", Length = "0x127")]
	[Token(Token = "0x6001052")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x259F320", Offset = "0x259E720", Length = "0xA")]
	[Token(Token = "0x600104B")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6001050")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x25A0EC0", Offset = "0x25A02C0", Length = "0x4F")]
	[Token(Token = "0x600104C")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A0F10", Offset = "0x25A0310", Length = "0x4F")]
	[Token(Token = "0x600104F")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x25A0F60", Offset = "0x25A0360", Length = "0x6")]
	[Token(Token = "0x600104D")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
	[Token(Token = "0x6001051")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A0F70", Offset = "0x25A0370", Length = "0x4E")]
	[Token(Token = "0x600104E")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A0C10", Offset = "0x25A0010", Length = "0x159")]
	[Token(Token = "0x6001053")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

