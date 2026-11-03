namespace Newtonsoft.Json.Converters;

[NullableContext(1)]
[Token(Token = "0x20001C4")]
internal interface IXmlDocument : IXmlNode
{

	[Nullable(2)]
	[Token(Token = "0x17000269")]
	public IXmlElement DocumentElement
	{
		[NullableContext(2)]
		[Token(Token = "0x6000F3B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000F39")]
	public IXmlNode CreateAttribute(string name, string value) { }

	[Token(Token = "0x6000F3A")]
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[Token(Token = "0x6000F31")]
	public IXmlNode CreateCDataSection(string data) { }

	[Token(Token = "0x6000F2F")]
	public IXmlNode CreateComment(string text) { }

	[Token(Token = "0x6000F37")]
	public IXmlElement CreateElement(string elementName) { }

	[Token(Token = "0x6000F38")]
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	[Token(Token = "0x6000F36")]
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	[Token(Token = "0x6000F33")]
	public IXmlNode CreateSignificantWhitespace(string text) { }

	[Token(Token = "0x6000F30")]
	public IXmlNode CreateTextNode(string text) { }

	[Token(Token = "0x6000F32")]
	public IXmlNode CreateWhitespace(string text) { }

	[Token(Token = "0x6000F34")]
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	[Token(Token = "0x6000F35")]
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	[NullableContext(2)]
	[Token(Token = "0x6000F3B")]
	public IXmlElement get_DocumentElement() { }

}

