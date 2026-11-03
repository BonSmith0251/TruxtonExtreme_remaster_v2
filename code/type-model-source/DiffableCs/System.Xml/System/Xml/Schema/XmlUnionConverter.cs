namespace System.Xml.Schema;

[Token(Token = "0x2000260")]
internal class XmlUnionConverter : XmlBaseConverter
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000CAA")]
	private XmlValueConverter[] converters; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000CAB")]
	private bool hasAtomicMember; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x4000CAC")]
	private bool hasListMember; //Field offset: 0x31

	[Address(RVA = "0x24C2770", Offset = "0x24C1B70", Length = "0x2A8")]
	[Token(Token = "0x6001886")]
	protected XmlUnionConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24C2260", Offset = "0x24C1660", Length = "0x4AB")]
	[Token(Token = "0x6001888")]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24C2710", Offset = "0x24C1B10", Length = "0x54")]
	[Token(Token = "0x6001887")]
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

}

