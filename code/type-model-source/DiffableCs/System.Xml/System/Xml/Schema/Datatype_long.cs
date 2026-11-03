namespace System.Xml.Schema;

[Token(Token = "0x20001A7")]
internal class Datatype_long : Datatype_integer
{
	[Token(Token = "0x400082F")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000830")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x4000831")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x17000494")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A5150", Offset = "0x25A4550", Length = "0x4F")]
		[Token(Token = "0x60010A4")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000495")]
	internal virtual bool HasValueFacets
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60010A5")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000498")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A51A0", Offset = "0x25A45A0", Length = "0x4F")]
		[Token(Token = "0x60010A9")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x17000496")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x25A51F0", Offset = "0x25A45F0", Length = "0x6")]
		[Token(Token = "0x60010A6")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000497")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A5200", Offset = "0x25A4600", Length = "0x4E")]
		[Token(Token = "0x60010A8")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A4FD0", Offset = "0x25A43D0", Length = "0x171")]
	[Token(Token = "0x60010AC")]
	private static Datatype_long() { }

	[Address(RVA = "0x25A4DB0", Offset = "0x25A41B0", Length = "0x49")]
	[Token(Token = "0x60010AB")]
	public Datatype_long() { }

	[Address(RVA = "0x25A4E00", Offset = "0x25A4200", Length = "0x5F")]
	[Token(Token = "0x60010A7")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A5150", Offset = "0x25A4550", Length = "0x4F")]
	[Token(Token = "0x60010A4")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60010A5")]
	internal virtual bool get_HasValueFacets() { }

	[Address(RVA = "0x25A51A0", Offset = "0x25A45A0", Length = "0x4F")]
	[Token(Token = "0x60010A9")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x25A51F0", Offset = "0x25A45F0", Length = "0x6")]
	[Token(Token = "0x60010A6")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A5200", Offset = "0x25A4600", Length = "0x4E")]
	[Token(Token = "0x60010A8")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A4E60", Offset = "0x25A4260", Length = "0x16C")]
	[Token(Token = "0x60010AA")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

