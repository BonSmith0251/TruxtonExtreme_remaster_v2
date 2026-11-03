namespace System.Xml;

[Token(Token = "0x2000044")]
internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400014F")]
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; //Field offset: 0x20

	[Address(RVA = "0x24EE0A0", Offset = "0x24ED4A0", Length = "0xAD")]
	[Token(Token = "0x6000226")]
	public XmlAsyncCheckReaderWithNS(XmlReader reader) { }

	[Address(RVA = "0x24EDF80", Offset = "0x24ED380", Length = "0x54")]
	[Token(Token = "0x6000227")]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Address(RVA = "0x24EDFE0", Offset = "0x24ED3E0", Length = "0x58")]
	[Token(Token = "0x6000228")]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[Address(RVA = "0x24EE040", Offset = "0x24ED440", Length = "0x58")]
	[Token(Token = "0x6000229")]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

}

