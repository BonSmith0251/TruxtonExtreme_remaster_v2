namespace System.Xml.Schema;

[Token(Token = "0x20001A9")]
internal class Datatype_short : Datatype_int
{
	[Token(Token = "0x4000835")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000836")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x4000837")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x1700049D")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A5CF0", Offset = "0x25A50F0", Length = "0x4F")]
		[Token(Token = "0x60010B5")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004A0")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A5D40", Offset = "0x25A5140", Length = "0x4F")]
		[Token(Token = "0x60010B9")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700049E")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A5D90", Offset = "0x25A5190", Length = "0x6")]
		[Token(Token = "0x60010B6")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700049F")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A5DA0", Offset = "0x25A51A0", Length = "0x4E")]
		[Token(Token = "0x60010B8")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A5B30", Offset = "0x25A4F30", Length = "0x167")]
	[Token(Token = "0x60010BC")]
	private static Datatype_short() { }

	[Address(RVA = "0x25A5CA0", Offset = "0x25A50A0", Length = "0x49")]
	[Token(Token = "0x60010BB")]
	public Datatype_short() { }

	[Address(RVA = "0x25A5960", Offset = "0x25A4D60", Length = "0x5D")]
	[Token(Token = "0x60010B7")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A5CF0", Offset = "0x25A50F0", Length = "0x4F")]
	[Token(Token = "0x60010B5")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A5D40", Offset = "0x25A5140", Length = "0x4F")]
	[Token(Token = "0x60010B9")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x25A5D90", Offset = "0x25A5190", Length = "0x6")]
	[Token(Token = "0x60010B6")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A5DA0", Offset = "0x25A51A0", Length = "0x4E")]
	[Token(Token = "0x60010B8")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A59C0", Offset = "0x25A4DC0", Length = "0x16C")]
	[Token(Token = "0x60010BA")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

