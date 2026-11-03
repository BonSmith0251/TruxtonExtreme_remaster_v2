namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001AB")]
public class BinaryConverter : JsonConverter
{
	[Token(Token = "0x40007EF")]
	private const string BinaryTypeName = "System.Data.Linq.Binary"; //Field offset: 0x0
	[Token(Token = "0x40007F0")]
	private const string BinaryToArrayName = "ToArray"; //Field offset: 0x0
	[Nullable(2)]
	[Token(Token = "0x40007F1")]
	private static ReflectionObject _reflectionObject; //Field offset: 0x0

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000E9B")]
	public BinaryConverter() { }

	[Address(RVA = "0x218F0B0", Offset = "0x218E4B0", Length = "0x104")]
	[Token(Token = "0x6000E9A")]
	public virtual bool CanConvert(Type objectType) { }

	[Address(RVA = "0x218F1C0", Offset = "0x218E5C0", Length = "0x1A4")]
	[Token(Token = "0x6000E97")]
	private static void EnsureReflectionObject(Type t) { }

	[Address(RVA = "0x218F370", Offset = "0x218E770", Length = "0x22E")]
	[Token(Token = "0x6000E96")]
	private Byte[] GetByteArray(object value) { }

	[Address(RVA = "0x218F5A0", Offset = "0x218E9A0", Length = "0x256")]
	[Token(Token = "0x6000E99")]
	private Byte[] ReadByteArray(JsonReader reader) { }

	[Address(RVA = "0x218F800", Offset = "0x218EC00", Length = "0x47D")]
	[Token(Token = "0x6000E98")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x218FC80", Offset = "0x218F080", Length = "0x66")]
	[Token(Token = "0x6000E95")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

