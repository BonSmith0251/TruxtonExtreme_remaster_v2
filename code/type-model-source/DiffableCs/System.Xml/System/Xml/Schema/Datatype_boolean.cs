namespace System.Xml.Schema;

[Token(Token = "0x2000180")]
internal class Datatype_boolean : Datatype_anySimpleType
{
	[Token(Token = "0x4000815")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000816")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x17000431")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000FEA")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700042D")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A12A0", Offset = "0x25A06A0", Length = "0x4F")]
		[Token(Token = "0x6000FE6")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000430")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A12F0", Offset = "0x25A06F0", Length = "0x4F")]
		[Token(Token = "0x6000FE9")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700042E")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x20482B0", Offset = "0x20476B0", Length = "0x6")]
		[Token(Token = "0x6000FE7")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000432")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x9DCBB0", Offset = "0x9DBFB0", Length = "0x6")]
		[Token(Token = "0x6000FEB")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700042F")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A1340", Offset = "0x25A0740", Length = "0x4E")]
		[Token(Token = "0x6000FE8")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A1160", Offset = "0x25A0560", Length = "0xBB")]
	[Token(Token = "0x6000FEF")]
	private static Datatype_boolean() { }

	[Address(RVA = "0x25A1220", Offset = "0x25A0620", Length = "0x7A")]
	[Token(Token = "0x6000FEE")]
	public Datatype_boolean() { }

	[Address(RVA = "0x25A0FC0", Offset = "0x25A03C0", Length = "0x6F")]
	[Token(Token = "0x6000FEC")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A1030", Offset = "0x25A0430", Length = "0xA")]
	[Token(Token = "0x6000FE5")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000FEA")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x25A12A0", Offset = "0x25A06A0", Length = "0x4F")]
	[Token(Token = "0x6000FE6")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A12F0", Offset = "0x25A06F0", Length = "0x4F")]
	[Token(Token = "0x6000FE9")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x20482B0", Offset = "0x20476B0", Length = "0x6")]
	[Token(Token = "0x6000FE7")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x9DCBB0", Offset = "0x9DBFB0", Length = "0x6")]
	[Token(Token = "0x6000FEB")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A1340", Offset = "0x25A0740", Length = "0x4E")]
	[Token(Token = "0x6000FE8")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A1040", Offset = "0x25A0440", Length = "0x110")]
	[Token(Token = "0x6000FED")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

