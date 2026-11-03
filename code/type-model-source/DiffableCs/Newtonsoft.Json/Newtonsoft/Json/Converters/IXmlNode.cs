namespace Newtonsoft.Json.Converters;

[NullableContext(2)]
[Token(Token = "0x20001C8")]
internal interface IXmlNode
{

	[Nullable(1)]
	[Token(Token = "0x17000275")]
	public List<IXmlNode> Attributes
	{
		[NullableContext(1)]
		[Token(Token = "0x6000F4B")]
		 get { } //Length: 0
	}

	[Nullable(1)]
	[Token(Token = "0x17000274")]
	public List<IXmlNode> ChildNodes
	{
		[NullableContext(1)]
		[Token(Token = "0x6000F4A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000273")]
	public string LocalName
	{
		[Token(Token = "0x6000F49")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000278")]
	public string NamespaceUri
	{
		[Token(Token = "0x6000F50")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000272")]
	public XmlNodeType NodeType
	{
		[Token(Token = "0x6000F48")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000276")]
	public IXmlNode ParentNode
	{
		[Token(Token = "0x6000F4C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000277")]
	public string Value
	{
		[Token(Token = "0x6000F4D")]
		 get { } //Length: 0
		[Token(Token = "0x6000F4E")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000279")]
	public object WrappedNode
	{
		[Token(Token = "0x6000F51")]
		 get { } //Length: 0
	}

	[NullableContext(1)]
	[Token(Token = "0x6000F4F")]
	public IXmlNode AppendChild(IXmlNode newChild) { }

	[NullableContext(1)]
	[Token(Token = "0x6000F4B")]
	public List<IXmlNode> get_Attributes() { }

	[NullableContext(1)]
	[Token(Token = "0x6000F4A")]
	public List<IXmlNode> get_ChildNodes() { }

	[Token(Token = "0x6000F49")]
	public string get_LocalName() { }

	[Token(Token = "0x6000F50")]
	public string get_NamespaceUri() { }

	[Token(Token = "0x6000F48")]
	public XmlNodeType get_NodeType() { }

	[Token(Token = "0x6000F4C")]
	public IXmlNode get_ParentNode() { }

	[Token(Token = "0x6000F4D")]
	public string get_Value() { }

	[Token(Token = "0x6000F51")]
	public object get_WrappedNode() { }

	[Token(Token = "0x6000F4E")]
	public void set_Value(string value) { }

}

