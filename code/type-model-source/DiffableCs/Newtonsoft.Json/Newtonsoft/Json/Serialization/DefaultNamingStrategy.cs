namespace Newtonsoft.Json.Serialization;

[Token(Token = "0x2000106")]
public class DefaultNamingStrategy : NamingStrategy
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60007A0")]
	public DefaultNamingStrategy() { }

	[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
	[NullableContext(1)]
	[Token(Token = "0x600079F")]
	protected virtual string ResolvePropertyName(string name) { }

}

