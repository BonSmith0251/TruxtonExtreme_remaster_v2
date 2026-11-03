namespace System.Xml.Schema;

[Token(Token = "0x20001E0")]
internal class SchemaNamespaceManager : XmlNamespaceManager
{
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A2D")]
	private XmlSchemaObject node; //Field offset: 0x50

	[Address(RVA = "0x2478570", Offset = "0x2477970", Length = "0x31")]
	[Token(Token = "0x6001317")]
	public SchemaNamespaceManager(XmlSchemaObject node) { }

	[Address(RVA = "0x2478190", Offset = "0x2477590", Length = "0x151")]
	[Token(Token = "0x6001318")]
	public virtual string LookupNamespace(string prefix) { }

	[Address(RVA = "0x24782F0", Offset = "0x24776F0", Length = "0x27E")]
	[Token(Token = "0x6001319")]
	public virtual string LookupPrefix(string ns) { }

}

