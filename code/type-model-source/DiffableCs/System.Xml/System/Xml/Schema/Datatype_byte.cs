namespace System.Xml.Schema;

[Token(Token = "0x20001AA")]
internal class Datatype_byte : Datatype_short
{
	[Token(Token = "0x4000838")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000839")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x400083A")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x170004A1")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A1750", Offset = "0x25A0B50", Length = "0x4F")]
		[Token(Token = "0x60010BD")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004A4")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A17A0", Offset = "0x25A0BA0", Length = "0x4F")]
		[Token(Token = "0x60010C1")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004A2")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x2230420", Offset = "0x222F820", Length = "0x6")]
		[Token(Token = "0x60010BE")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170004A3")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A17F0", Offset = "0x25A0BF0", Length = "0x4E")]
		[Token(Token = "0x60010C0")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A1560", Offset = "0x25A0960", Length = "0x167")]
	[Token(Token = "0x60010C4")]
	private static Datatype_byte() { }

	[Address(RVA = "0x25A16D0", Offset = "0x25A0AD0", Length = "0x7A")]
	[Token(Token = "0x60010C3")]
	public Datatype_byte() { }

	[Address(RVA = "0x25A1390", Offset = "0x25A0790", Length = "0x5A")]
	[Token(Token = "0x60010BF")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A1750", Offset = "0x25A0B50", Length = "0x4F")]
	[Token(Token = "0x60010BD")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A17A0", Offset = "0x25A0BA0", Length = "0x4F")]
	[Token(Token = "0x60010C1")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x2230420", Offset = "0x222F820", Length = "0x6")]
	[Token(Token = "0x60010BE")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A17F0", Offset = "0x25A0BF0", Length = "0x4E")]
	[Token(Token = "0x60010C0")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A13F0", Offset = "0x25A07F0", Length = "0x16D")]
	[Token(Token = "0x60010C2")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

