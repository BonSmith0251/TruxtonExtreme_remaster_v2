namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001BB")]
public class RegexConverter : JsonConverter
{
	[Token(Token = "0x400080C")]
	private const string PatternName = "Pattern"; //Field offset: 0x0
	[Token(Token = "0x400080D")]
	private const string OptionsName = "Options"; //Field offset: 0x0

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000EE8")]
	public RegexConverter() { }

	[Address(RVA = "0x21A3920", Offset = "0x21A2D20", Length = "0x85")]
	[Token(Token = "0x6000EE6")]
	public virtual bool CanConvert(Type objectType) { }

	[Address(RVA = "0x1F225E0", Offset = "0x1F219E0", Length = "0xA")]
	[Token(Token = "0x6000EE0")]
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	[Address(RVA = "0x21A39B0", Offset = "0x21A2DB0", Length = "0x67")]
	[Token(Token = "0x6000EE7")]
	private bool IsRegex(Type objectType) { }

	[Address(RVA = "0x21A3A20", Offset = "0x21A2E20", Length = "0x1E6")]
	[Token(Token = "0x6000EE3")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x21A3C10", Offset = "0x21A3010", Length = "0x2CE")]
	[Token(Token = "0x6000EE5")]
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	[Address(RVA = "0x21A3EE0", Offset = "0x21A32E0", Length = "0x158")]
	[Token(Token = "0x6000EE4")]
	private object ReadRegexString(JsonReader reader) { }

	[Address(RVA = "0x21A4040", Offset = "0x21A3440", Length = "0x123")]
	[Token(Token = "0x6000EE1")]
	private void WriteBson(BsonWriter writer, Regex regex) { }

	[Address(RVA = "0x21A4350", Offset = "0x21A3750", Length = "0x206")]
	[Token(Token = "0x6000EDF")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	[Address(RVA = "0x21A4170", Offset = "0x21A3570", Length = "0x1D2")]
	[Token(Token = "0x6000EE2")]
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

}

