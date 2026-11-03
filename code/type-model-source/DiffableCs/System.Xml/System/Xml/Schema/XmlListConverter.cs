namespace System.Xml.Schema;

[Token(Token = "0x200025F")]
internal class XmlListConverter : XmlBaseConverter
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000CA9")]
	protected XmlValueConverter atomicConverter; //Field offset: 0x28

	[Address(RVA = "0x24B3B00", Offset = "0x24B2F00", Length = "0x69")]
	[Token(Token = "0x600187A")]
	protected XmlListConverter(XmlBaseConverter atomicConverter) { }

	[Address(RVA = "0x24B9570", Offset = "0x24B8970", Length = "0x79")]
	[Token(Token = "0x600187B")]
	protected XmlListConverter(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	[Address(RVA = "0x24B95F0", Offset = "0x24B89F0", Length = "0x59")]
	[Token(Token = "0x600187C")]
	protected XmlListConverter(XmlSchemaType schemaType) { }

	[Address(RVA = "0x24B7520", Offset = "0x24B6920", Length = "0x104C")]
	[Token(Token = "0x600187F")]
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24B8570", Offset = "0x24B7970", Length = "0x119")]
	[Token(Token = "0x600187E")]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24B8990", Offset = "0x24B7D90", Length = "0x1C4")]
	[Token(Token = "0x600187D")]
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	[Address(RVA = "0x24B8690", Offset = "0x24B7A90", Length = "0x2FB")]
	[Token(Token = "0x6001885")]
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	[Address(RVA = "0x24B8B60", Offset = "0x24B7F60", Length = "0x19F")]
	[Token(Token = "0x6001880")]
	private bool IsListType(Type type) { }

	[Address(RVA = "0x24B8D00", Offset = "0x24B8100", Length = "0x29C")]
	[Token(Token = "0x6001884")]
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24B8FA0", Offset = "0x24B83A0", Length = "0x92")]
	[Token(Token = "0x6001883")]
	private List<String> StringAsList(string value) { }

	[Address(RVA = "0x9E7710", Offset = "0x9E6B10", Length = "0x595")]
	[Token(Token = "0x6001881")]
	private T[] ToArray(object list, IXmlNamespaceResolver nsResolver) { }

	[Address(RVA = "0x24B9040", Offset = "0x24B8440", Length = "0x52D")]
	[Token(Token = "0x6001882")]
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

}

