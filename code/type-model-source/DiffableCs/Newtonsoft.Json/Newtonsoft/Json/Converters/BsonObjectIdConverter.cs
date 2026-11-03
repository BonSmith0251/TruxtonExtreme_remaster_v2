namespace Newtonsoft.Json.Converters;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
[Token(Token = "0x20001AC")]
public class BsonObjectIdConverter : JsonConverter
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000E9F")]
	public BsonObjectIdConverter() { }

	[Address(RVA = "0x2190E90", Offset = "0x2190290", Length = "0x67")]
	[Token(Token = "0x6000E9E")]
	public virtual bool CanConvert(Type objectType) { }

	[Address(RVA = "0x2190F00", Offset = "0x2190300", Length = "0x18D")]
	[Token(Token = "0x6000E9D")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x2191090", Offset = "0x2190490", Length = "0xF7")]
	[Token(Token = "0x6000E9C")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

