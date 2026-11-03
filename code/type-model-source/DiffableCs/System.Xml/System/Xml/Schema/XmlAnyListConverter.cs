namespace System.Xml.Schema;

[Token(Token = "0x200025E")]
internal class XmlAnyListConverter : XmlListConverter
{
	[Token(Token = "0x4000CA7")]
	public static readonly XmlValueConverter ItemList; //Field offset: 0x0
	[Token(Token = "0x4000CA8")]
	public static readonly XmlValueConverter AnyAtomicList; //Field offset: 0x8

	[Address(RVA = "0x24B38D0", Offset = "0x24B2CD0", Length = "0x22B")]
	[Token(Token = "0x6001879")]
	private static XmlAnyListConverter() { }

	[Address(RVA = "0x24B3B00", Offset = "0x24B2F00", Length = "0x69")]
	[Token(Token = "0x6001877")]
	protected XmlAnyListConverter(XmlBaseConverter atomicConverter) { }

	[Address(RVA = "0x24B3630", Offset = "0x24B2A30", Length = "0x298")]
	[Token(Token = "0x6001878")]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

}

