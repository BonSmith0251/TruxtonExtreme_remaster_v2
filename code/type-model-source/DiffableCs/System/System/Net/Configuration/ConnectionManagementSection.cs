namespace System.Net.Configuration;

[Token(Token = "0x2000332")]
public sealed class ConnectionManagementSection : ConfigurationSection
{

	[Token(Token = "0x17000483")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x25DE4B0", Offset = "0x25DD8B0", Length = "0x2C")]
		[Token(Token = "0x60014FB")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x25DE480", Offset = "0x25DD880", Length = "0x2C")]
	[Token(Token = "0x60014FA")]
	public ConnectionManagementSection() { }

	[Address(RVA = "0x25DE4B0", Offset = "0x25DD8B0", Length = "0x2C")]
	[Token(Token = "0x60014FB")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

