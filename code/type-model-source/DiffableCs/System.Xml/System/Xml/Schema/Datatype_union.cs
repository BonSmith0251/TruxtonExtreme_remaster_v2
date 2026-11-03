namespace System.Xml.Schema;

[Token(Token = "0x200017B")]
internal class Datatype_union : Datatype_anySimpleType
{
	[Token(Token = "0x4000810")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000811")]
	private static readonly Type listValueType; //Field offset: 0x8
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000812")]
	private XmlSchemaSimpleType[] types; //Field offset: 0x38

	[Token(Token = "0x1700041C")]
	internal XmlSchemaSimpleType[] BaseMemberTypes
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000FC3")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000419")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A6B90", Offset = "0x25A5F90", Length = "0x52")]
		[Token(Token = "0x6000FC0")]
		internal get { } //Length: 82
	}

	[Token(Token = "0x1700041A")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A6BF0", Offset = "0x25A5FF0", Length = "0x4F")]
		[Token(Token = "0x6000FC1")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000418")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
		[Token(Token = "0x6000FBF")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700041B")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x9DCB20", Offset = "0x9DBF20", Length = "0x6")]
		[Token(Token = "0x6000FC2")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000417")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A6C40", Offset = "0x25A6040", Length = "0x4E")]
		[Token(Token = "0x6000FBE")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A6A30", Offset = "0x25A5E30", Length = "0xBB")]
	[Token(Token = "0x6000FC8")]
	private static Datatype_union() { }

	[Address(RVA = "0x25A6AF0", Offset = "0x25A5EF0", Length = "0x96")]
	[Token(Token = "0x6000FBC")]
	internal Datatype_union(XmlSchemaSimpleType[] types) { }

	[Address(RVA = "0x25A60E0", Offset = "0x25A54E0", Length = "0x109")]
	[Token(Token = "0x6000FBD")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A61F0", Offset = "0x25A55F0", Length = "0xA")]
	[Token(Token = "0x6000FBB")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000FC3")]
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	[Address(RVA = "0x25A6B90", Offset = "0x25A5F90", Length = "0x52")]
	[Token(Token = "0x6000FC0")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A6BF0", Offset = "0x25A5FF0", Length = "0x4F")]
	[Token(Token = "0x6000FC1")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x1D6CB40", Offset = "0x1D6BF40", Length = "0x6")]
	[Token(Token = "0x6000FBF")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x9DCB20", Offset = "0x9DBF20", Length = "0x6")]
	[Token(Token = "0x6000FC2")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A6C40", Offset = "0x25A6040", Length = "0x4E")]
	[Token(Token = "0x6000FBE")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A6200", Offset = "0x25A5600", Length = "0xA3")]
	[Token(Token = "0x6000FC4")]
	internal bool HasAtomicMembers() { }

	[Address(RVA = "0x25A62B0", Offset = "0x25A56B0", Length = "0xAB")]
	[Token(Token = "0x6000FC5")]
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	[Address(RVA = "0x25A6360", Offset = "0x25A5760", Length = "0x27F")]
	[Token(Token = "0x6000FC6")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	[Address(RVA = "0x25A65E0", Offset = "0x25A59E0", Length = "0x446")]
	[Token(Token = "0x6000FC7")]
	internal virtual Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

