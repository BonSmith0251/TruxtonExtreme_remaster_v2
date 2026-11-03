namespace Newtonsoft.Json;

[AttributeUsage(1028, AllowMultiple = False)]
[Token(Token = "0x200001F")]
public sealed class JsonDictionaryAttribute : JsonContainerAttribute
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000093")]
	public JsonDictionaryAttribute() { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[NullableContext(1)]
	[Token(Token = "0x6000094")]
	public JsonDictionaryAttribute(string id) { }

}

