namespace Unity.Properties.Internal;

[Token(Token = "0x200006E")]
internal interface IAttributes
{

	[Token(Token = "0x17000050")]
	public List<Attribute> Attributes
	{
		[Token(Token = "0x6000265")]
		 get { } //Length: 0
		[Token(Token = "0x6000266")]
		 set { } //Length: 0
	}

	[Token(Token = "0x6000267")]
	public void AddAttribute(Attribute attribute) { }

	[Token(Token = "0x6000268")]
	public void AddAttributes(IEnumerable<Attribute> attributes) { }

	[Token(Token = "0x6000269")]
	public AttributesScope CreateAttributesScope(IAttributes attributes) { }

	[Token(Token = "0x6000265")]
	public List<Attribute> get_Attributes() { }

	[Token(Token = "0x6000266")]
	public void set_Attributes(List<Attribute> value) { }

}

