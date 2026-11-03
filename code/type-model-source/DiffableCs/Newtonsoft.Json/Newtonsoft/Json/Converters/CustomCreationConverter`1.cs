namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001AD")]
public abstract class CustomCreationConverter : JsonConverter
{

	[Token(Token = "0x1700024C")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000EA4")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000EA5")]
	protected CustomCreationConverter`1() { }

	[Address(RVA = "0x17C8DD0", Offset = "0x17C81D0", Length = "0x69")]
	[Token(Token = "0x6000EA3")]
	public virtual bool CanConvert(Type objectType) { }

	[Token(Token = "0x6000EA2")]
	public abstract T Create(Type objectType) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000EA4")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x17C8E40", Offset = "0x17C8240", Length = "0x205")]
	[Token(Token = "0x6000EA1")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x17C9050", Offset = "0x17C8450", Length = "0x44")]
	[Token(Token = "0x6000EA0")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

