namespace System.Xml.Schema;

[Token(Token = "0x200025B")]
internal class XmlStringConverter : XmlBaseConverter
{

	[Address(RVA = "0x24C2200", Offset = "0x24C1600", Length = "0x59")]
	[Token(Token = "0x6001835")]
	protected XmlStringConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24C1780", Offset = "0x24C0B80", Length = "0x2C6")]
	[Token(Token = "0x6001838")]
	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24C1A50", Offset = "0x24C0E50", Length = "0x4DD")]
	[Token(Token = "0x6001839")]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24C1F30", Offset = "0x24C1330", Length = "0x85")]
	[Token(Token = "0x6001836")]
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24C1FC0", Offset = "0x24C13C0", Length = "0x23E")]
	[Token(Token = "0x6001837")]
	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

}

