namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200001C")]
public abstract class JsonConverter : JsonConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600008D")]
	protected JsonConverter`1() { }

	[Address(RVA = "0xAC8D10", Offset = "0xAC8110", Length = "0x68")]
	[Token(Token = "0x600008C")]
	public virtual bool CanConvert(Type objectType) { }

	[Address(RVA = "0xAC8D80", Offset = "0xAC8180", Length = "0x2AB")]
	[Token(Token = "0x600008A")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Token(Token = "0x600008B")]
	public abstract T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer) { }

	[Address(RVA = "0xAC9030", Offset = "0xAC8430", Length = "0x244")]
	[Token(Token = "0x6000088")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	[Token(Token = "0x6000089")]
	public abstract void WriteJson(JsonWriter writer, T value, JsonSerializer serializer) { }

}

