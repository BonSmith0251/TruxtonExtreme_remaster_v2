namespace System.Xml;

[Token(Token = "0x2000046")]
internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000151")]
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; //Field offset: 0x28

	[Address(RVA = "0x24EDD30", Offset = "0x24ED130", Length = "0xAD")]
	[Token(Token = "0x600022E")]
	public XmlAsyncCheckReaderWithLineInfoNS(XmlReader reader) { }

	[Address(RVA = "0x24EDC10", Offset = "0x24ED010", Length = "0x54")]
	[Token(Token = "0x600022F")]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Address(RVA = "0x24EDC70", Offset = "0x24ED070", Length = "0x58")]
	[Token(Token = "0x6000230")]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[Address(RVA = "0x24EDCD0", Offset = "0x24ED0D0", Length = "0x58")]
	[Token(Token = "0x6000231")]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

