namespace System.Net.Configuration;

[Token(Token = "0x200033C")]
public sealed class WebProxyScriptElement : ConfigurationElement
{

	[Token(Token = "0x1700048C")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x25F6B00", Offset = "0x25F5F00", Length = "0x2C")]
		[Token(Token = "0x600150F")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x25F6AD0", Offset = "0x25F5ED0", Length = "0x2C")]
	[Token(Token = "0x600150E")]
	public WebProxyScriptElement() { }

	[Address(RVA = "0x25F6B00", Offset = "0x25F5F00", Length = "0x2C")]
	[Token(Token = "0x600150F")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

