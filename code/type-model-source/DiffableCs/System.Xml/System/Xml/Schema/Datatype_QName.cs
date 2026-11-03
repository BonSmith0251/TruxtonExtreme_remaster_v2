namespace System.Xml.Schema;

[Token(Token = "0x2000197")]
internal class Datatype_QName : Datatype_anySimpleType
{
	[Token(Token = "0x4000829")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400082A")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000473")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6001069")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700046D")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A0150", Offset = "0x259F550", Length = "0x52")]
		[Token(Token = "0x6001063")]
		internal get { } //Length: 82
	}

	[Token(Token = "0x17000472")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A01B0", Offset = "0x259F5B0", Length = "0x4F")]
		[Token(Token = "0x6001068")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700046F")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
		[Token(Token = "0x6001065")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700046E")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9E1920", Offset = "0x9E0D20", Length = "0x6")]
		[Token(Token = "0x6001064")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000470")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
		[Token(Token = "0x6001066")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000471")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A0200", Offset = "0x259F600", Length = "0x4E")]
		[Token(Token = "0x6001067")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A0000", Offset = "0x259F400", Length = "0xC6")]
	[Token(Token = "0x600106C")]
	private static Datatype_QName() { }

	[Address(RVA = "0x25A00D0", Offset = "0x259F4D0", Length = "0x7A")]
	[Token(Token = "0x600106B")]
	public Datatype_QName() { }

	[Address(RVA = "0x259F320", Offset = "0x259E720", Length = "0xA")]
	[Token(Token = "0x6001062")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6001069")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x25A0150", Offset = "0x259F550", Length = "0x52")]
	[Token(Token = "0x6001063")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A01B0", Offset = "0x259F5B0", Length = "0x4F")]
	[Token(Token = "0x6001068")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
	[Token(Token = "0x6001065")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x9E1920", Offset = "0x9E0D20", Length = "0x6")]
	[Token(Token = "0x6001064")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
	[Token(Token = "0x6001066")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A0200", Offset = "0x259F600", Length = "0x4E")]
	[Token(Token = "0x6001067")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x259FE20", Offset = "0x259F220", Length = "0x1DA")]
	[Token(Token = "0x600106A")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

