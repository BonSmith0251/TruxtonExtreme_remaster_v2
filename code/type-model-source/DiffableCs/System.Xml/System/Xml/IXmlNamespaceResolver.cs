namespace System.Xml;

[Token(Token = "0x20000B6")]
public interface IXmlNamespaceResolver
{

	[Token(Token = "0x60009EE")]
	public IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	[Token(Token = "0x60009EF")]
	public string LookupNamespace(string prefix) { }

	[Token(Token = "0x60009F0")]
	public string LookupPrefix(string namespaceName) { }

}

