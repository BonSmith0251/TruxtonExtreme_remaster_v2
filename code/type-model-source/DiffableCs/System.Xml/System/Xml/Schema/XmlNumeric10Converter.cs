namespace System.Xml.Schema;

[Token(Token = "0x2000256")]
internal class XmlNumeric10Converter : XmlBaseConverter
{

	[Address(RVA = "0x24BF930", Offset = "0x24BED30", Length = "0x59")]
	[Token(Token = "0x60017F5")]
	protected XmlNumeric10Converter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24BBF90", Offset = "0x24BB390", Length = "0x1189")]
	[Token(Token = "0x6001807")]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24BD560", Offset = "0x24BC960", Length = "0x452")]
	[Token(Token = "0x6001806")]
	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24BD120", Offset = "0x24BC520", Length = "0x437")]
	[Token(Token = "0x6001805")]
	public virtual object ChangeType(long value, Type destinationType) { }

	[Address(RVA = "0x24BD9C0", Offset = "0x24BCDC0", Length = "0x412")]
	[Token(Token = "0x6001804")]
	public virtual object ChangeType(int value, Type destinationType) { }

	[Address(RVA = "0x24BDDE0", Offset = "0x24BD1E0", Length = "0x490")]
	[Token(Token = "0x6001803")]
	public virtual object ChangeType(decimal value, Type destinationType) { }

	[Address(RVA = "0x24BB700", Offset = "0x24BAB00", Length = "0x41E")]
	[Token(Token = "0x6001808")]
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24BBB20", Offset = "0x24BAF20", Length = "0x46D")]
	[Token(Token = "0x6001809")]
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24BE280", Offset = "0x24BD680", Length = "0x85")]
	[Token(Token = "0x60017F6")]
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24BE310", Offset = "0x24BD710", Length = "0x497")]
	[Token(Token = "0x60017F8")]
	public virtual decimal ToDecimal(object value) { }

	[Address(RVA = "0x24BE7B0", Offset = "0x24BDBB0", Length = "0xE5")]
	[Token(Token = "0x60017F7")]
	public virtual decimal ToDecimal(string value) { }

	[Address(RVA = "0x24BEA10", Offset = "0x24BDE10", Length = "0x423")]
	[Token(Token = "0x60017FB")]
	public virtual int ToInt32(object value) { }

	[Address(RVA = "0x24BE8F0", Offset = "0x24BDCF0", Length = "0x115")]
	[Token(Token = "0x60017FA")]
	public virtual int ToInt32(string value) { }

	[Address(RVA = "0x24BE8A0", Offset = "0x24BDCA0", Length = "0x49")]
	[Token(Token = "0x60017F9")]
	public virtual int ToInt32(long value) { }

	[Address(RVA = "0x24BEE40", Offset = "0x24BE240", Length = "0x115")]
	[Token(Token = "0x60017FD")]
	public virtual long ToInt64(string value) { }

	[Address(RVA = "0x24BEF60", Offset = "0x24BE360", Length = "0x405")]
	[Token(Token = "0x60017FE")]
	public virtual long ToInt64(object value) { }

	[Address(RVA = "0x24BF370", Offset = "0x24BE770", Length = "0x4")]
	[Token(Token = "0x60017FC")]
	public virtual long ToInt64(int value) { }

	[Address(RVA = "0x24BF800", Offset = "0x24BEC00", Length = "0x47")]
	[Token(Token = "0x6001800")]
	public virtual string ToString(int value) { }

	[Address(RVA = "0x24BF380", Offset = "0x24BE780", Length = "0x49")]
	[Token(Token = "0x6001801")]
	public virtual string ToString(long value) { }

	[Address(RVA = "0x24BF3D0", Offset = "0x24BE7D0", Length = "0x42B")]
	[Token(Token = "0x6001802")]
	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24BF850", Offset = "0x24BEC50", Length = "0xDC")]
	[Token(Token = "0x60017FF")]
	public virtual string ToString(decimal value) { }

}

