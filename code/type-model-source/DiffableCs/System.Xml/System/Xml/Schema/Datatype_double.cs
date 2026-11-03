namespace System.Xml.Schema;

[Token(Token = "0x2000182")]
internal class Datatype_double : Datatype_anySimpleType
{
	[Token(Token = "0x4000819")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400081A")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x1700043D")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6001000")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000439")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A3270", Offset = "0x25A2670", Length = "0x4F")]
		[Token(Token = "0x6000FFC")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700043C")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A32C0", Offset = "0x25A26C0", Length = "0x4F")]
		[Token(Token = "0x6000FFF")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700043A")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
		[Token(Token = "0x6000FFD")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700043E")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x25A2370", Offset = "0x25A1770", Length = "0x6")]
		[Token(Token = "0x6001001")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700043B")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A3310", Offset = "0x25A2710", Length = "0x4E")]
		[Token(Token = "0x6000FFE")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A3130", Offset = "0x25A2530", Length = "0xBB")]
	[Token(Token = "0x6001005")]
	private static Datatype_double() { }

	[Address(RVA = "0x25A31F0", Offset = "0x25A25F0", Length = "0x7A")]
	[Token(Token = "0x6001004")]
	public Datatype_double() { }

	[Address(RVA = "0x25A2F30", Offset = "0x25A2330", Length = "0x61")]
	[Token(Token = "0x6001002")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A2FA0", Offset = "0x25A23A0", Length = "0xA")]
	[Token(Token = "0x6000FFB")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6001000")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x25A3270", Offset = "0x25A2670", Length = "0x4F")]
	[Token(Token = "0x6000FFC")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A32C0", Offset = "0x25A26C0", Length = "0x4F")]
	[Token(Token = "0x6000FFF")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
	[Token(Token = "0x6000FFD")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A2370", Offset = "0x25A1770", Length = "0x6")]
	[Token(Token = "0x6001001")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A3310", Offset = "0x25A2710", Length = "0x4E")]
	[Token(Token = "0x6000FFE")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A2FB0", Offset = "0x25A23B0", Length = "0x175")]
	[Token(Token = "0x6001003")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

