namespace System.Xml.Schema;

[Token(Token = "0x20001AE")]
internal class Datatype_unsignedShort : Datatype_unsignedInt
{
	[Token(Token = "0x4000842")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000843")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x4000844")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x170004B0")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A7EA0", Offset = "0x25A72A0", Length = "0x4F")]
		[Token(Token = "0x60010DA")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004B3")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A7EF0", Offset = "0x25A72F0", Length = "0x4F")]
		[Token(Token = "0x60010DE")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004B1")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A7F40", Offset = "0x25A7340", Length = "0x6")]
		[Token(Token = "0x60010DB")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170004B2")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A7F50", Offset = "0x25A7350", Length = "0x4E")]
		[Token(Token = "0x60010DD")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A7CA0", Offset = "0x25A70A0", Length = "0x17D")]
	[Token(Token = "0x60010E1")]
	private static Datatype_unsignedShort() { }

	[Address(RVA = "0x25A7E20", Offset = "0x25A7220", Length = "0x7A")]
	[Token(Token = "0x60010E0")]
	public Datatype_unsignedShort() { }

	[Address(RVA = "0x25A7AD0", Offset = "0x25A6ED0", Length = "0x5D")]
	[Token(Token = "0x60010DC")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A7EA0", Offset = "0x25A72A0", Length = "0x4F")]
	[Token(Token = "0x60010DA")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A7EF0", Offset = "0x25A72F0", Length = "0x4F")]
	[Token(Token = "0x60010DE")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x25A7F40", Offset = "0x25A7340", Length = "0x6")]
	[Token(Token = "0x60010DB")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A7F50", Offset = "0x25A7350", Length = "0x4E")]
	[Token(Token = "0x60010DD")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A7B30", Offset = "0x25A6F30", Length = "0x16C")]
	[Token(Token = "0x60010DF")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

