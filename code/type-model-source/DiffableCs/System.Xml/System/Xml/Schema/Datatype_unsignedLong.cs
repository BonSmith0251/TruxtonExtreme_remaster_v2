namespace System.Xml.Schema;

[Token(Token = "0x20001AC")]
internal class Datatype_unsignedLong : Datatype_nonNegativeInteger
{
	[Token(Token = "0x400083C")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400083D")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x400083E")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x170004A8")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A79E0", Offset = "0x25A6DE0", Length = "0x4F")]
		[Token(Token = "0x60010CA")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004AB")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A7A30", Offset = "0x25A6E30", Length = "0x4F")]
		[Token(Token = "0x60010CE")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004A9")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCB60", Offset = "0x9DBF60", Length = "0x6")]
		[Token(Token = "0x60010CB")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170004AA")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A7A80", Offset = "0x25A6E80", Length = "0x4E")]
		[Token(Token = "0x60010CD")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A77E0", Offset = "0x25A6BE0", Length = "0x17F")]
	[Token(Token = "0x60010D1")]
	private static Datatype_unsignedLong() { }

	[Address(RVA = "0x25A7960", Offset = "0x25A6D60", Length = "0x7A")]
	[Token(Token = "0x60010D0")]
	public Datatype_unsignedLong() { }

	[Address(RVA = "0x25A75C0", Offset = "0x25A69C0", Length = "0x5F")]
	[Token(Token = "0x60010CC")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A79E0", Offset = "0x25A6DE0", Length = "0x4F")]
	[Token(Token = "0x60010CA")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A7A30", Offset = "0x25A6E30", Length = "0x4F")]
	[Token(Token = "0x60010CE")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x9DCB60", Offset = "0x9DBF60", Length = "0x6")]
	[Token(Token = "0x60010CB")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A7A80", Offset = "0x25A6E80", Length = "0x4E")]
	[Token(Token = "0x60010CD")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A7620", Offset = "0x25A6A20", Length = "0x1BB")]
	[Token(Token = "0x60010CF")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

