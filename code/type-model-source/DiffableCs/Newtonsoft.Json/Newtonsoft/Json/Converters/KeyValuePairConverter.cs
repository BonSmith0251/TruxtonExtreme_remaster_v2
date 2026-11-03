namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001BA")]
public class KeyValuePairConverter : JsonConverter
{
	[Token(Token = "0x4000809")]
	private const string KeyName = "Key"; //Field offset: 0x0
	[Token(Token = "0x400080A")]
	private const string ValueName = "Value"; //Field offset: 0x0
	[Token(Token = "0x400080B")]
	private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType; //Field offset: 0x0

	[Address(RVA = "0x21A3250", Offset = "0x21A2650", Length = "0xCB")]
	[Token(Token = "0x6000EDE")]
	private static KeyValuePairConverter() { }

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000EDD")]
	public KeyValuePairConverter() { }

	[Address(RVA = "0x21A2860", Offset = "0x21A1C60", Length = "0xEB")]
	[Token(Token = "0x6000EDC")]
	public virtual bool CanConvert(Type objectType) { }

	[Address(RVA = "0x21A2950", Offset = "0x21A1D50", Length = "0x1F9")]
	[Token(Token = "0x6000ED9")]
	private static ReflectionObject InitializeReflectionObject(Type t) { }

	[Address(RVA = "0x21A2B50", Offset = "0x21A1F50", Length = "0x461")]
	[Token(Token = "0x6000EDB")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x21A2FC0", Offset = "0x21A23C0", Length = "0x28A")]
	[Token(Token = "0x6000EDA")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

