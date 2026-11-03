namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200001B")]
public abstract class JsonConverter
{

	[Token(Token = "0x17000013")]
	public override bool CanRead
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000085")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000014")]
	public override bool CanWrite
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000086")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000087")]
	protected JsonConverter() { }

	[Token(Token = "0x6000084")]
	public abstract bool CanConvert(Type objectType) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000085")]
	public override bool get_CanRead() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000086")]
	public override bool get_CanWrite() { }

	[Token(Token = "0x6000083")]
	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Token(Token = "0x6000082")]
	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

