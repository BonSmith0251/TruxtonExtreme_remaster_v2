namespace Newtonsoft.Json.Serialization;

[Token(Token = "0x200013A")]
public class SnakeCaseNamingStrategy : NamingStrategy
{

	[Address(RVA = "0x216C6F0", Offset = "0x216BAF0", Length = "0x37")]
	[Token(Token = "0x6000997")]
	public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	[Address(RVA = "0x216C6A0", Offset = "0x216BAA0", Length = "0x49")]
	[Token(Token = "0x6000998")]
	public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000999")]
	public SnakeCaseNamingStrategy() { }

	[Address(RVA = "0x216D580", Offset = "0x216C980", Length = "0xA")]
	[NullableContext(1)]
	[Token(Token = "0x600099A")]
	protected virtual string ResolvePropertyName(string name) { }

}

