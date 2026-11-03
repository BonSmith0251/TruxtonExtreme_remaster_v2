namespace System.Xml.Schema;

[Token(Token = "0x200017A")]
internal class Datatype_List : Datatype_anySimpleType
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400080E")]
	private DatatypeImplementation itemType; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400080F")]
	private int minListSize; //Field offset: 0x40

	[Token(Token = "0x17000414")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x259F0C0", Offset = "0x259E4C0", Length = "0x52")]
		[Token(Token = "0x6000FB6")]
		internal get { } //Length: 82
	}

	[Token(Token = "0x17000413")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x259F120", Offset = "0x259E520", Length = "0x2A")]
		[Token(Token = "0x6000FB5")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x17000412")]
	public virtual XmlTokenizedType TokenizedType
	{
		[Address(RVA = "0x259F150", Offset = "0x259E550", Length = "0x2A")]
		[Token(Token = "0x6000FB4")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000415")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x259F180", Offset = "0x259E580", Length = "0x2A")]
		[Token(Token = "0x6000FB7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000416")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
		[Token(Token = "0x6000FB8")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000411")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x259F1C0", Offset = "0x259E5C0", Length = "0x14")]
		[Token(Token = "0x6000FB3")]
		 get { } //Length: 20
	}

	[Address(RVA = "0x259F010", Offset = "0x259E410", Length = "0xA7")]
	[Token(Token = "0x6000FB1")]
	internal Datatype_List(DatatypeImplementation type, int minListSize) { }

	[Address(RVA = "0x259DF60", Offset = "0x259D360", Length = "0x2C4")]
	[Token(Token = "0x6000FB2")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x259E230", Offset = "0x259D630", Length = "0x35F")]
	[Token(Token = "0x6000FB0")]
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x259F0C0", Offset = "0x259E4C0", Length = "0x52")]
	[Token(Token = "0x6000FB6")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x259F120", Offset = "0x259E520", Length = "0x2A")]
	[Token(Token = "0x6000FB5")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x259F150", Offset = "0x259E550", Length = "0x2A")]
	[Token(Token = "0x6000FB4")]
	public virtual XmlTokenizedType get_TokenizedType() { }

	[Address(RVA = "0x259F180", Offset = "0x259E580", Length = "0x2A")]
	[Token(Token = "0x6000FB7")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x259F1B0", Offset = "0x259E5B0", Length = "0x6")]
	[Token(Token = "0x6000FB8")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x259F1C0", Offset = "0x259E5C0", Length = "0x14")]
	[Token(Token = "0x6000FB3")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x259E590", Offset = "0x259D990", Length = "0x584")]
	[Token(Token = "0x6000FB9")]
	internal virtual Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	[Address(RVA = "0x259EB20", Offset = "0x259DF20", Length = "0x4ED")]
	[Token(Token = "0x6000FBA")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

