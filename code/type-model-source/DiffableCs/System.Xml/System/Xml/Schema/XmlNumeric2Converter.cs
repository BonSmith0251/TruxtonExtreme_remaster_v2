namespace System.Xml.Schema;

[Token(Token = "0x2000257")]
internal class XmlNumeric2Converter : XmlBaseConverter
{

	[Address(RVA = "0x24C1720", Offset = "0x24C0B20", Length = "0x59")]
	[Token(Token = "0x600180A")]
	protected XmlNumeric2Converter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24C0570", Offset = "0x24BF970", Length = "0x37A")]
	[Token(Token = "0x6001814")]
	public virtual object ChangeType(double value, Type destinationType) { }

	[Address(RVA = "0x24BF990", Offset = "0x24BED90", Length = "0x3C1")]
	[Token(Token = "0x6001815")]
	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24BFD60", Offset = "0x24BF160", Length = "0x808")]
	[Token(Token = "0x6001816")]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24C08F0", Offset = "0x24BFCF0", Length = "0x85")]
	[Token(Token = "0x600180B")]
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24C0CF0", Offset = "0x24C00F0", Length = "0xCF")]
	[Token(Token = "0x600180C")]
	public virtual double ToDouble(string value) { }

	[Address(RVA = "0x24C0980", Offset = "0x24BFD80", Length = "0x363")]
	[Token(Token = "0x600180D")]
	public virtual double ToDouble(object value) { }

	[Address(RVA = "0x24C0E90", Offset = "0x24C0290", Length = "0x8")]
	[Token(Token = "0x600180E")]
	public virtual float ToSingle(double value) { }

	[Address(RVA = "0x24C0DC0", Offset = "0x24C01C0", Length = "0xCF")]
	[Token(Token = "0x600180F")]
	public virtual float ToSingle(string value) { }

	[Address(RVA = "0x24C0EA0", Offset = "0x24C02A0", Length = "0x3C0")]
	[Token(Token = "0x6001810")]
	public virtual float ToSingle(object value) { }

	[Address(RVA = "0x24C1270", Offset = "0x24C0670", Length = "0xA1")]
	[Token(Token = "0x6001811")]
	public virtual string ToString(double value) { }

	[Address(RVA = "0x24C1690", Offset = "0x24C0A90", Length = "0x82")]
	[Token(Token = "0x6001812")]
	public virtual string ToString(float value) { }

	[Address(RVA = "0x24C1320", Offset = "0x24C0720", Length = "0x36C")]
	[Token(Token = "0x6001813")]
	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

}

