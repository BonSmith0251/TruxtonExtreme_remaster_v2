namespace Newtonsoft.Json.Serialization;

[Token(Token = "0x2000132")]
public class KebabCaseNamingStrategy : NamingStrategy
{

	[Address(RVA = "0x216C6F0", Offset = "0x216BAF0", Length = "0x37")]
	[Token(Token = "0x6000971")]
	public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	[Address(RVA = "0x216C6A0", Offset = "0x216BAA0", Length = "0x49")]
	[Token(Token = "0x6000972")]
	public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000973")]
	public KebabCaseNamingStrategy() { }

	[Address(RVA = "0x216C690", Offset = "0x216BA90", Length = "0xA")]
	[NullableContext(1)]
	[Token(Token = "0x6000974")]
	protected virtual string ResolvePropertyName(string name) { }

}

