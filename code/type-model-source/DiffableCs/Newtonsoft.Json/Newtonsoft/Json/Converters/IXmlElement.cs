namespace Newtonsoft.Json.Converters;

[NullableContext(1)]
[Token(Token = "0x20001C7")]
internal interface IXmlElement : IXmlNode
{

	[Token(Token = "0x17000271")]
	public bool IsEmpty
	{
		[Token(Token = "0x6000F47")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000F47")]
	public bool get_IsEmpty() { }

	[Token(Token = "0x6000F46")]
	public string GetPrefixOfNamespace(string namespaceUri) { }

	[Token(Token = "0x6000F45")]
	public void SetAttributeNode(IXmlNode attribute) { }

}

