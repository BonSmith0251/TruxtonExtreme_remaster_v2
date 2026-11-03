namespace System.Xml.Schema;

[Token(Token = "0x2000181")]
internal class Datatype_float : Datatype_anySimpleType
{
	[Token(Token = "0x4000817")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000818")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000437")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000FF5")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000433")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A41D0", Offset = "0x25A35D0", Length = "0x4F")]
		[Token(Token = "0x6000FF1")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000436")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A4220", Offset = "0x25A3620", Length = "0x4F")]
		[Token(Token = "0x6000FF4")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000434")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x209AC80", Offset = "0x209A080", Length = "0x6")]
		[Token(Token = "0x6000FF2")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000438")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x25A2370", Offset = "0x25A1770", Length = "0x6")]
		[Token(Token = "0x6000FF6")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000435")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A4270", Offset = "0x25A3670", Length = "0x4E")]
		[Token(Token = "0x6000FF3")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A4090", Offset = "0x25A3490", Length = "0xBB")]
	[Token(Token = "0x6000FFA")]
	private static Datatype_float() { }

	[Address(RVA = "0x25A4150", Offset = "0x25A3550", Length = "0x7A")]
	[Token(Token = "0x6000FF9")]
	public Datatype_float() { }

	[Address(RVA = "0x25A3EA0", Offset = "0x25A32A0", Length = "0x60")]
	[Token(Token = "0x6000FF7")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A2FA0", Offset = "0x25A23A0", Length = "0xA")]
	[Token(Token = "0x6000FF0")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000FF5")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x25A41D0", Offset = "0x25A35D0", Length = "0x4F")]
	[Token(Token = "0x6000FF1")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A4220", Offset = "0x25A3620", Length = "0x4F")]
	[Token(Token = "0x6000FF4")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x209AC80", Offset = "0x209A080", Length = "0x6")]
	[Token(Token = "0x6000FF2")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A2370", Offset = "0x25A1770", Length = "0x6")]
	[Token(Token = "0x6000FF6")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A4270", Offset = "0x25A3670", Length = "0x4E")]
	[Token(Token = "0x6000FF3")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A3F10", Offset = "0x25A3310", Length = "0x174")]
	[Token(Token = "0x6000FF8")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

