namespace System.Xml.Schema;

[Token(Token = "0x2000259")]
internal class XmlBooleanConverter : XmlBaseConverter
{

	[Address(RVA = "0x24B4FE0", Offset = "0x24B43E0", Length = "0x59")]
	[Token(Token = "0x6001825")]
	protected XmlBooleanConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24B3B70", Offset = "0x24B2F70", Length = "0x319")]
	[Token(Token = "0x600182B")]
	public virtual object ChangeType(bool value, Type destinationType) { }

	[Address(RVA = "0x24B4540", Offset = "0x24B3940", Length = "0x34C")]
	[Token(Token = "0x600182C")]
	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24B3E90", Offset = "0x24B3290", Length = "0x6A2")]
	[Token(Token = "0x600182D")]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24B4890", Offset = "0x24B3C90", Length = "0x85")]
	[Token(Token = "0x6001826")]
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24B4C10", Offset = "0x24B4010", Length = "0x96")]
	[Token(Token = "0x6001827")]
	public virtual bool ToBoolean(string value) { }

	[Address(RVA = "0x24B4920", Offset = "0x24B3D20", Length = "0x2E8")]
	[Token(Token = "0x6001828")]
	public virtual bool ToBoolean(object value) { }

	[Address(RVA = "0x24B4F90", Offset = "0x24B4390", Length = "0x49")]
	[Token(Token = "0x6001829")]
	public virtual string ToString(bool value) { }

	[Address(RVA = "0x24B4CB0", Offset = "0x24B40B0", Length = "0x2DC")]
	[Token(Token = "0x600182A")]
	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

}

