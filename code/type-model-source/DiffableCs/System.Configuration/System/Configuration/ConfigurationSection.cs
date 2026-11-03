namespace System.Configuration;

[Token(Token = "0x2000003")]
public abstract class ConfigurationSection : ConfigurationElement
{

	[Address(RVA = "0x2228C20", Offset = "0x2228020", Length = "0x2C")]
	[Token(Token = "0x6000005")]
	protected private override void DeserializeSection(XmlReader reader) { }

	[Address(RVA = "0x2228C50", Offset = "0x2228050", Length = "0x2C")]
	[Token(Token = "0x6000006")]
	protected private virtual bool IsModified() { }

	[Address(RVA = "0x2228C80", Offset = "0x2228080", Length = "0x2C")]
	[Token(Token = "0x6000007")]
	protected private virtual void ResetModified() { }

	[Address(RVA = "0x2228CB0", Offset = "0x22280B0", Length = "0x2C")]
	[Token(Token = "0x6000008")]
	protected private override string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }

}

