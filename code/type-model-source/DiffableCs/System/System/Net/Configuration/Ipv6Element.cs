namespace System.Net.Configuration;

[Token(Token = "0x2000336")]
public sealed class Ipv6Element : ConfigurationElement
{

	[Token(Token = "0x17000487")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x25DEA70", Offset = "0x25DDE70", Length = "0x2C")]
		[Token(Token = "0x6001504")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x25DEA40", Offset = "0x25DDE40", Length = "0x2C")]
	[Token(Token = "0x6001503")]
	public Ipv6Element() { }

	[Address(RVA = "0x25DEA70", Offset = "0x25DDE70", Length = "0x2C")]
	[Token(Token = "0x6001504")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

