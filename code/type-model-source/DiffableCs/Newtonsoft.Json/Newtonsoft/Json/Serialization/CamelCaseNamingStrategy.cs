namespace Newtonsoft.Json.Serialization;

[Token(Token = "0x20000F8")]
public class CamelCaseNamingStrategy : NamingStrategy
{

	[Address(RVA = "0x2134410", Offset = "0x2133810", Length = "0x37")]
	[Token(Token = "0x6000735")]
	public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	[Address(RVA = "0x21343C0", Offset = "0x21337C0", Length = "0x49")]
	[Token(Token = "0x6000736")]
	public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000737")]
	public CamelCaseNamingStrategy() { }

	[Address(RVA = "0x21343B0", Offset = "0x21337B0", Length = "0xA")]
	[NullableContext(1)]
	[Token(Token = "0x6000738")]
	protected virtual string ResolvePropertyName(string name) { }

}

