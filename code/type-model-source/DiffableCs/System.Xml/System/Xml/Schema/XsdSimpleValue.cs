namespace System.Xml.Schema;

[Token(Token = "0x2000174")]
internal class XsdSimpleValue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400078F")]
	private XmlSchemaSimpleType xmlType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000790")]
	private object typedValue; //Field offset: 0x18

	[Token(Token = "0x170003FF")]
	public object TypedValue
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000F7C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170003FE")]
	public XmlSchemaSimpleType XmlType
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000F7B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000F7A")]
	public XsdSimpleValue(XmlSchemaSimpleType st, object value) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000F7C")]
	public object get_TypedValue() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000F7B")]
	public XmlSchemaSimpleType get_XmlType() { }

}

