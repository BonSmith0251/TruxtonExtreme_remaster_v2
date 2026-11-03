namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001B9")]
public class JavaScriptDateTimeConverter : DateTimeConverterBase
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000ED8")]
	public JavaScriptDateTimeConverter() { }

	[Address(RVA = "0x21A2290", Offset = "0x21A1690", Length = "0x3AF")]
	[Token(Token = "0x6000ED7")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x21A2640", Offset = "0x21A1A40", Length = "0x21B")]
	[Token(Token = "0x6000ED6")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

