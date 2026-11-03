namespace System.Xml.Schema;

[Token(Token = "0x20001A3")]
internal class Datatype_NOTATION : Datatype_anySimpleType
{
	[Token(Token = "0x400082B")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400082C")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x1700048D")]
	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6001093")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000487")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x259F910", Offset = "0x259ED10", Length = "0x52")]
		[Token(Token = "0x600108D")]
		internal get { } //Length: 82
	}

	[Token(Token = "0x1700048C")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x259F970", Offset = "0x259ED70", Length = "0x4F")]
		[Token(Token = "0x6001092")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000489")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
		[Token(Token = "0x600108F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000488")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9E1980", Offset = "0x9E0D80", Length = "0x6")]
		[Token(Token = "0x600108E")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700048A")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
		[Token(Token = "0x6001090")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700048B")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x259F9C0", Offset = "0x259EDC0", Length = "0x4E")]
		[Token(Token = "0x6001091")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x259F7C0", Offset = "0x259EBC0", Length = "0xC6")]
	[Token(Token = "0x6001097")]
	private static Datatype_NOTATION() { }

	[Address(RVA = "0x259F890", Offset = "0x259EC90", Length = "0x7A")]
	[Token(Token = "0x6001096")]
	public Datatype_NOTATION() { }

	[Address(RVA = "0x259F320", Offset = "0x259E720", Length = "0xA")]
	[Token(Token = "0x600108C")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6001093")]
	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	[Address(RVA = "0x259F910", Offset = "0x259ED10", Length = "0x52")]
	[Token(Token = "0x600108D")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x259F970", Offset = "0x259ED70", Length = "0x4F")]
	[Token(Token = "0x6001092")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
	[Token(Token = "0x600108F")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x9E1980", Offset = "0x9E0D80", Length = "0x6")]
	[Token(Token = "0x600108E")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
	[Token(Token = "0x6001090")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x259F9C0", Offset = "0x259EDC0", Length = "0x4E")]
	[Token(Token = "0x6001091")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x259F330", Offset = "0x259E730", Length = "0x1DA")]
	[Token(Token = "0x6001094")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	[Address(RVA = "0x259F510", Offset = "0x259E910", Length = "0x2A1")]
	[Token(Token = "0x6001095")]
	internal virtual void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

}

