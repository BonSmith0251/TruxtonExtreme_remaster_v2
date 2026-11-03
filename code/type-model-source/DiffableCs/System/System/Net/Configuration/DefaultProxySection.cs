namespace System.Net.Configuration;

[Token(Token = "0x2000333")]
public sealed class DefaultProxySection : ConfigurationSection
{

	[Token(Token = "0x17000484")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x25DE770", Offset = "0x25DDB70", Length = "0x2C")]
		[Token(Token = "0x60014FD")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x25DE740", Offset = "0x25DDB40", Length = "0x2C")]
	[Token(Token = "0x60014FC")]
	public DefaultProxySection() { }

	[Address(RVA = "0x25DE770", Offset = "0x25DDB70", Length = "0x2C")]
	[Token(Token = "0x60014FD")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

	[Address(RVA = "0x25DE710", Offset = "0x25DDB10", Length = "0x2C")]
	[Token(Token = "0x60014FE")]
	protected virtual void Reset(ConfigurationElement parentElement) { }

}

