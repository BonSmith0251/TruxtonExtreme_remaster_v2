namespace System.Net.Configuration;

[Token(Token = "0x2000334")]
public sealed class ProxyElement : ConfigurationElement
{

	[Token(Token = "0x17000485")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x25E1840", Offset = "0x25E0C40", Length = "0x2C")]
		[Token(Token = "0x6001500")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x25E1810", Offset = "0x25E0C10", Length = "0x2C")]
	[Token(Token = "0x60014FF")]
	public ProxyElement() { }

	[Address(RVA = "0x25E1840", Offset = "0x25E0C40", Length = "0x2C")]
	[Token(Token = "0x6001500")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

