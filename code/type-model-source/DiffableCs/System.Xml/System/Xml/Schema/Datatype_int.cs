namespace System.Xml.Schema;

[Token(Token = "0x20001A8")]
internal class Datatype_int : Datatype_long
{
	[Token(Token = "0x4000832")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x4000833")]
	private static readonly Type listValueType; //Field offset: 0x8
	[Token(Token = "0x4000834")]
	private static readonly FacetsChecker numeric10FacetsChecker; //Field offset: 0x10

	[Token(Token = "0x17000499")]
	internal virtual FacetsChecker FacetsChecker
	{
		[Address(RVA = "0x25A4B60", Offset = "0x25A3F60", Length = "0x4F")]
		[Token(Token = "0x60010AD")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700049C")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A4BB0", Offset = "0x25A3FB0", Length = "0x4F")]
		[Token(Token = "0x60010B1")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700049A")]
	public virtual XmlTypeCode TypeCode
	{
		[Address(RVA = "0x9DCBE0", Offset = "0x9DBFE0", Length = "0x6")]
		[Token(Token = "0x60010AE")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700049B")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A4C00", Offset = "0x25A4000", Length = "0x4E")]
		[Token(Token = "0x60010B0")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A4970", Offset = "0x25A3D70", Length = "0x167")]
	[Token(Token = "0x60010B4")]
	private static Datatype_int() { }

	[Address(RVA = "0x25A4AE0", Offset = "0x25A3EE0", Length = "0x7A")]
	[Token(Token = "0x60010B3")]
	public Datatype_int() { }

	[Address(RVA = "0x25A47A0", Offset = "0x25A3BA0", Length = "0x5C")]
	[Token(Token = "0x60010AF")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A4B60", Offset = "0x25A3F60", Length = "0x4F")]
	[Token(Token = "0x60010AD")]
	internal virtual FacetsChecker get_FacetsChecker() { }

	[Address(RVA = "0x25A4BB0", Offset = "0x25A3FB0", Length = "0x4F")]
	[Token(Token = "0x60010B1")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x9DCBE0", Offset = "0x9DBFE0", Length = "0x6")]
	[Token(Token = "0x60010AE")]
	public virtual XmlTypeCode get_TypeCode() { }

	[Address(RVA = "0x25A4C00", Offset = "0x25A4000", Length = "0x4E")]
	[Token(Token = "0x60010B0")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A4800", Offset = "0x25A3C00", Length = "0x168")]
	[Token(Token = "0x60010B2")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

