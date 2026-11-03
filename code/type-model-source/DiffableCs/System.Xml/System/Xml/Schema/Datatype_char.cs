namespace System.Xml.Schema;

[Token(Token = "0x20001B5")]
internal class Datatype_char : Datatype_anySimpleType
{
	[Token(Token = "0x400084B")]
	private static readonly Type atomicValueType; //Field offset: 0x0
	[Token(Token = "0x400084C")]
	private static readonly Type listValueType; //Field offset: 0x8

	[Token(Token = "0x170004BF")]
	internal virtual Type ListValueType
	{
		[Address(RVA = "0x25A1C00", Offset = "0x25A1000", Length = "0x4F")]
		[Token(Token = "0x60010FB")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x170004C0")]
	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60010FC")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170004BE")]
	public virtual Type ValueType
	{
		[Address(RVA = "0x25A1C50", Offset = "0x25A1050", Length = "0x4E")]
		[Token(Token = "0x60010FA")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x25A1AC0", Offset = "0x25A0EC0", Length = "0xBB")]
	[Token(Token = "0x6001101")]
	private static Datatype_char() { }

	[Address(RVA = "0x25A1B80", Offset = "0x25A0F80", Length = "0x7A")]
	[Token(Token = "0x6001100")]
	public Datatype_char() { }

	[Address(RVA = "0x25A1840", Offset = "0x25A0C40", Length = "0x72")]
	[Token(Token = "0x60010FD")]
	internal virtual int Compare(object value1, object value2) { }

	[Address(RVA = "0x25A1C00", Offset = "0x25A1000", Length = "0x4F")]
	[Token(Token = "0x60010FB")]
	internal virtual Type get_ListValueType() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60010FC")]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[Address(RVA = "0x25A1C50", Offset = "0x25A1050", Length = "0x4E")]
	[Token(Token = "0x60010FA")]
	public virtual Type get_ValueType() { }

	[Address(RVA = "0x25A18C0", Offset = "0x25A0CC0", Length = "0x14F")]
	[Token(Token = "0x60010FE")]
	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	[Address(RVA = "0x25A1A10", Offset = "0x25A0E10", Length = "0xA2")]
	[Token(Token = "0x60010FF")]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

