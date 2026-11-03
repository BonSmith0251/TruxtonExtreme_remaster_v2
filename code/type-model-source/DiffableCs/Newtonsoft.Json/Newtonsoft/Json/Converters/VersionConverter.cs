namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001BE")]
public class VersionConverter : JsonConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000F02")]
	public VersionConverter() { }

	[Address(RVA = "0x21B0640", Offset = "0x21AFA40", Length = "0x67")]
	[Token(Token = "0x6000F01")]
	public virtual bool CanConvert(Type objectType) { }

	[Address(RVA = "0x21B06B0", Offset = "0x21AFAB0", Length = "0x248")]
	[Token(Token = "0x6000F00")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x21B0900", Offset = "0x21AFD00", Length = "0xF9")]
	[Token(Token = "0x6000EFF")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

