namespace System.Net.Configuration;

[Token(Token = "0x2000338")]
public sealed class SettingsSection : ConfigurationSection
{

	[Token(Token = "0x17000488")]
	protected virtual ConfigurationPropertyCollection Properties
	{
		[Address(RVA = "0x25E2700", Offset = "0x25E1B00", Length = "0x2C")]
		[Token(Token = "0x6001507")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x25E26D0", Offset = "0x25E1AD0", Length = "0x2C")]
	[Token(Token = "0x6001506")]
	public SettingsSection() { }

	[Address(RVA = "0x25E2700", Offset = "0x25E1B00", Length = "0x2C")]
	[Token(Token = "0x6001507")]
	protected virtual ConfigurationPropertyCollection get_Properties() { }

}

