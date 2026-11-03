namespace System.Net.Configuration;

[Token(Token = "0x200033A")]
public sealed class ServicePointManagerElement : ConfigurationElement
{

	[Token(Token = "0x1700048A")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x25E25B0", Offset = "0x25E19B0", Length = "0x2C")]
		[Token(Token = "0x600150B")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x25E2580", Offset = "0x25E1980", Length = "0x2C")]
	[Token(Token = "0x600150A")]
	public ServicePointManagerElement() { }

	[Address(RVA = "0x25E25B0", Offset = "0x25E19B0", Length = "0x2C")]
	[Token(Token = "0x600150B")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

