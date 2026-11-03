namespace System.Xml.Schema;

[Token(Token = "0x200025A")]
internal class XmlMiscConverter : XmlBaseConverter
{

	[Address(RVA = "0x24BB6A0", Offset = "0x24BAAA0", Length = "0x59")]
	[Token(Token = "0x600182E")]
	protected XmlMiscConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24B9910", Offset = "0x24B8D10", Length = "0x647")]
	[Token(Token = "0x6001831")]
	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24B9F60", Offset = "0x24B9360", Length = "0x100C")]
	[Token(Token = "0x6001832")]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24B9650", Offset = "0x24B8A50", Length = "0x141")]
	[Token(Token = "0x6001833")]
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24B97A0", Offset = "0x24B8BA0", Length = "0x16F")]
	[Token(Token = "0x6001834")]
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24BAF70", Offset = "0x24BA370", Length = "0x85")]
	[Token(Token = "0x600182F")]
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24BB000", Offset = "0x24BA400", Length = "0x695")]
	[Token(Token = "0x6001830")]
	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

}

