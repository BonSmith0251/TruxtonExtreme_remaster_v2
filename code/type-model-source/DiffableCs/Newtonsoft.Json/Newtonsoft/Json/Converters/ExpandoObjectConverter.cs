namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001B7")]
public class ExpandoObjectConverter : JsonConverter
{

	[Token(Token = "0x1700024D")]
	public virtual bool CanWrite
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000ECB")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000ECC")]
	public ExpandoObjectConverter() { }

	[Address(RVA = "0x21951B0", Offset = "0x21945B0", Length = "0x67")]
	[Token(Token = "0x6000ECA")]
	public virtual bool CanConvert(Type objectType) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000ECB")]
	public virtual bool get_CanWrite() { }

	[Address(RVA = "0x2195220", Offset = "0x2194620", Length = "0x8")]
	[Token(Token = "0x6000EC6")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x2195230", Offset = "0x2194630", Length = "0x124")]
	[Token(Token = "0x6000EC8")]
	private object ReadList(JsonReader reader) { }

	[Address(RVA = "0x2195360", Offset = "0x2194760", Length = "0x1CB")]
	[Token(Token = "0x6000EC9")]
	private object ReadObject(JsonReader reader) { }

	[Address(RVA = "0x2195530", Offset = "0x2194930", Length = "0x292")]
	[Token(Token = "0x6000EC7")]
	private object ReadValue(JsonReader reader) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000EC5")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

