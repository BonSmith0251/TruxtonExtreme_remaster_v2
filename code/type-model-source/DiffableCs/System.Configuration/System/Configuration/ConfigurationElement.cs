namespace System.Configuration;

[DefaultMember("Item")]
[Token(Token = "0x2000002")]
public abstract class ConfigurationElement
{

	[Token(Token = "0x17000001")]
	protected private override ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x2228BF0", Offset = "0x2227FF0", Length = "0x2C")]
		[Token(Token = "0x6000001")]
		private get { } //Length: 44
	}

	[Address(RVA = "0x2228BF0", Offset = "0x2227FF0", Length = "0x2C")]
	[Token(Token = "0x6000001")]
	protected private override ConfigurationPropertyCollection get_Properties() { }

	[Address(RVA = "0x2228B60", Offset = "0x2227F60", Length = "0x2C")]
	[Token(Token = "0x6000002")]
	protected private override bool IsModified() { }

	[Address(RVA = "0x2228BC0", Offset = "0x2227FC0", Length = "0x2C")]
	[Token(Token = "0x6000003")]
	protected private override void Reset(ConfigurationElement parentElement) { }

	[Address(RVA = "0x2228B90", Offset = "0x2227F90", Length = "0x2C")]
	[Token(Token = "0x6000004")]
	protected private override void ResetModified() { }

}

