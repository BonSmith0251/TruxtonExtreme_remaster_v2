namespace System.Xml.Schema;

[Token(Token = "0x20001AF")]
internal class Datatype_unsignedByte : Datatype_unsignedShort
{
	[Token(Token = "0x4000845")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000846")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x4000847")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x170004B4")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A7030", Offset = "0x25A6430", Length = "0x4F")]
		[Token(Token = "0x60010E2")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004B7")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A7080", Offset = "0x25A6480", Length = "0x4F")]
		[Token(Token = "0x60010E6")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004B5")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x2256780", Offset = "0x2255B80", Length = "0x6")]
		[Token(Token = "0x60010E3")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170004B6")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A70D0", Offset = "0x25A64D0", Length = "0x4E")]
		[Token(Token = "0x60010E5")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A6E60", Offset = "0x25A6260", Length = "0x17D")]
	[Token(Token = "0x60010E9")]
	private static Datatype_unsignedByte() { }

	[Address(RVA = "0x25A6FE0", Offset = "0x25A63E0", Length = "0x49")]
	[Token(Token = "0x60010E8")]
	public Datatype_unsignedByte() { }

	[Address(RVA = "0x25A6C90", Offset = "0x25A6090", Length = "0x5A")]
	[Token(Token = "0x60010E4")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A7030", Offset = "0x25A6430", Length = "0x4F")]
	[Token(Token = "0x60010E2")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A7080", Offset = "0x25A6480", Length = "0x4F")]
	[Token(Token = "0x60010E6")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x2256780", Offset = "0x2255B80", Length = "0x6")]
	[Token(Token = "0x60010E3")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A70D0", Offset = "0x25A64D0", Length = "0x4E")]
	[Token(Token = "0x60010E5")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A6CF0", Offset = "0x25A60F0", Length = "0x16D")]
	[Token(Token = "0x60010E7")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

