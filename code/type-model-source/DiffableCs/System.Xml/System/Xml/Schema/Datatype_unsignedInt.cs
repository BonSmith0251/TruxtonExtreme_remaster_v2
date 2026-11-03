namespace System.Xml.Schema;

[Token(Token = "0x20001AD")]
internal class Datatype_unsignedInt : Datatype_unsignedLong
{
	[Token(Token = "0x400083F")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000840")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x4000841")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x170004AC")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A74C0", Offset = "0x25A68C0", Length = "0x4F")]
		[Token(Token = "0x60010D2")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004AF")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A7510", Offset = "0x25A6910", Length = "0x4F")]
		[Token(Token = "0x60010D6")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004AD")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A7560", Offset = "0x25A6960", Length = "0x6")]
		[Token(Token = "0x60010D3")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170004AE")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A7570", Offset = "0x25A6970", Length = "0x4E")]
		[Token(Token = "0x60010D5")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A72F0", Offset = "0x25A66F0", Length = "0x17D")]
	[Token(Token = "0x60010D9")]
	private static Datatype_unsignedInt() { }

	[Address(RVA = "0x25A7470", Offset = "0x25A6870", Length = "0x49")]
	[Token(Token = "0x60010D8")]
	public Datatype_unsignedInt() { }

	[Address(RVA = "0x25A7120", Offset = "0x25A6520", Length = "0x5C")]
	[Token(Token = "0x60010D4")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A74C0", Offset = "0x25A68C0", Length = "0x4F")]
	[Token(Token = "0x60010D2")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A7510", Offset = "0x25A6910", Length = "0x4F")]
	[Token(Token = "0x60010D6")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x25A7560", Offset = "0x25A6960", Length = "0x6")]
	[Token(Token = "0x60010D3")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A7570", Offset = "0x25A6970", Length = "0x4E")]
	[Token(Token = "0x60010D5")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A7180", Offset = "0x25A6580", Length = "0x168")]
	[Token(Token = "0x60010D7")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

