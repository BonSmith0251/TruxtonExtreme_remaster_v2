namespace System.Net.Configuration;

[Token(Token = "0x2000335")]
public sealed class HttpWebRequestElement : ConfigurationElement
{

	[Token(Token = "0x17000486")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x25DE830", Offset = "0x25DDC30", Length = "0x2C")]
		[Token(Token = "0x6001502")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x25DE800", Offset = "0x25DDC00", Length = "0x2C")]
	[Token(Token = "0x6001501")]
	public HttpWebRequestElement() { }

	[Address(RVA = "0x25DE830", Offset = "0x25DDC30", Length = "0x2C")]
	[Token(Token = "0x6001502")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

