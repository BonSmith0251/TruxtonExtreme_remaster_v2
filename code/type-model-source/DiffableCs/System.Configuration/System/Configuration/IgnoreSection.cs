namespace System.Configuration;

[Token(Token = "0x2000009")]
public sealed class IgnoreSection : ConfigurationSection
{

	[Token(Token = "0x17000002")]
	protected private virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x2228E00", Offset = "0x2228200", Length = "0x2C")]
		[Token(Token = "0x600000B")]
		private get { } //Length: 44
	}

	[Address(RVA = "0x2228DD0", Offset = "0x22281D0", Length = "0x2C")]
	[Token(Token = "0x600000A")]
	public IgnoreSection() { }

	[Address(RVA = "0x2228CE0", Offset = "0x22280E0", Length = "0x2C")]
	[Token(Token = "0x600000C")]
	protected private virtual void DeserializeSection(XmlReader xmlReader) { }

	[Address(RVA = "0x2228E00", Offset = "0x2228200", Length = "0x2C")]
	[Token(Token = "0x600000B")]
	protected private virtual ConfigurationPropertyCollection get_Properties() { }

	[Address(RVA = "0x2228D10", Offset = "0x2228110", Length = "0x2C")]
	[Token(Token = "0x600000D")]
	protected private virtual bool IsModified() { }

	[Address(RVA = "0x2228D70", Offset = "0x2228170", Length = "0x2C")]
	[Token(Token = "0x600000E")]
	protected private virtual void Reset(ConfigurationElement parentSection) { }

	[Address(RVA = "0x2228D40", Offset = "0x2228140", Length = "0x2C")]
	[Token(Token = "0x600000F")]
	protected private virtual void ResetModified() { }

	[Address(RVA = "0x2228DA0", Offset = "0x22281A0", Length = "0x2C")]
	[Token(Token = "0x6000010")]
	protected private virtual string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }

}

