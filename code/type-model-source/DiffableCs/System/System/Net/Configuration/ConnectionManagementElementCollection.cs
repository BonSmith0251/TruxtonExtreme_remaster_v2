namespace System.Net.Configuration;

[ConfigurationCollection(typeof(ConnectionManagementElement))]
[DefaultMember("Item")]
[Token(Token = "0x2000331")]
public sealed class ConnectionManagementElementCollection : ConfigurationElementCollection
{

	[Address(RVA = "0x25DE450", Offset = "0x25DD850", Length = "0x2C")]
	[Token(Token = "0x60014F9")]
	public ConnectionManagementElementCollection() { }

}

