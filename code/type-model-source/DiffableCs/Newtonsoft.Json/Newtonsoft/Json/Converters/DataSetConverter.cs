namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001AE")]
public class DataSetConverter : JsonConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000EA9")]
	public DataSetConverter() { }

	[Address(RVA = "0x21914C0", Offset = "0x21908C0", Length = "0x7D")]
	[Token(Token = "0x6000EA8")]
	public virtual bool CanConvert(Type valueType) { }

	[Address(RVA = "0x2191540", Offset = "0x2190940", Length = "0x2D1")]
	[Token(Token = "0x6000EA7")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x2191820", Offset = "0x2190C20", Length = "0x3FD")]
	[Token(Token = "0x6000EA6")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

