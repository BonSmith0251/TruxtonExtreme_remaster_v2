namespace System.Net.Configuration;

[Token(Token = "0x200033D")]
public sealed class WebRequestModulesSection : ConfigurationSection
{

	[Token(Token = "0x1700048D")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x25F6B90", Offset = "0x25F5F90", Length = "0x2C")]
		[Token(Token = "0x6001511")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x25F6B60", Offset = "0x25F5F60", Length = "0x2C")]
	[Token(Token = "0x6001510")]
	public WebRequestModulesSection() { }

	[Address(RVA = "0x25F6B90", Offset = "0x25F5F90", Length = "0x2C")]
	[Token(Token = "0x6001511")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

