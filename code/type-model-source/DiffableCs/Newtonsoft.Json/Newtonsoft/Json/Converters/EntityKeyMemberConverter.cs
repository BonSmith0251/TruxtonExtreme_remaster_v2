namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001B6")]
public class EntityKeyMemberConverter : JsonConverter
{
	[Token(Token = "0x4000800")]
	private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember"; //Field offset: 0x0
	[Token(Token = "0x4000801")]
	private const string KeyPropertyName = "Key"; //Field offset: 0x0
	[Token(Token = "0x4000802")]
	private const string TypePropertyName = "Type"; //Field offset: 0x0
	[Token(Token = "0x4000803")]
	private const string ValuePropertyName = "Value"; //Field offset: 0x0
	[Nullable(2)]
	[Token(Token = "0x4000804")]
	private static ReflectionObject _reflectionObject; //Field offset: 0x0

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000EC4")]
	public EntityKeyMemberConverter() { }

	[Address(RVA = "0x2194970", Offset = "0x2193D70", Length = "0x3F")]
	[Token(Token = "0x6000EC3")]
	public virtual bool CanConvert(Type objectType) { }

	[Address(RVA = "0x21949B0", Offset = "0x2193DB0", Length = "0xFE")]
	[Token(Token = "0x6000EC2")]
	private static void EnsureReflectionObject(Type objectType) { }

	[Address(RVA = "0x2194AB0", Offset = "0x2193EB0", Length = "0x110")]
	[Token(Token = "0x6000EC0")]
	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	[Address(RVA = "0x2194BD0", Offset = "0x2193FD0", Length = "0x274")]
	[Token(Token = "0x6000EC1")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x2194E50", Offset = "0x2194250", Length = "0x35D")]
	[Token(Token = "0x6000EBF")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

