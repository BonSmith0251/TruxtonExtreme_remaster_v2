namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200001A")]
public static class JsonConvert
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x4000037")]
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; //Field offset: 0x0
	[Token(Token = "0x4000038")]
	public static readonly string True; //Field offset: 0x8
	[Token(Token = "0x4000039")]
	public static readonly string False; //Field offset: 0x10
	[Token(Token = "0x400003A")]
	public static readonly string Null; //Field offset: 0x18
	[Token(Token = "0x400003B")]
	public static readonly string Undefined; //Field offset: 0x20
	[Token(Token = "0x400003C")]
	public static readonly string PositiveInfinity; //Field offset: 0x28
	[Token(Token = "0x400003D")]
	public static readonly string NegativeInfinity; //Field offset: 0x30
	[Token(Token = "0x400003E")]
	public static readonly string NaN; //Field offset: 0x38

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x17000012")]
	public static Func<JsonSerializerSettings> DefaultSettings
	{
		[Address(RVA = "0x20CCCA0", Offset = "0x20CC0A0", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x600003A")]
		 get { } //Length: 78
		[Address(RVA = "0x20CCCF0", Offset = "0x20CC0F0", Length = "0x69")]
		[CompilerGenerated]
		[Token(Token = "0x600003B")]
		 set { } //Length: 105
	}

	[Address(RVA = "0x20CCAA0", Offset = "0x20CBEA0", Length = "0x1F9")]
	[Token(Token = "0x6000081")]
	private static JsonConvert() { }

	[Address(RVA = "0x84E230", Offset = "0x84D630", Length = "0xD5")]
	[DebuggerStepThrough]
	[Token(Token = "0x600006B")]
	public static T DeserializeAnonymousType(string value, T anonymousTypeObject) { }

	[Address(RVA = "0x84E140", Offset = "0x84D540", Length = "0xE5")]
	[DebuggerStepThrough]
	[Token(Token = "0x600006C")]
	public static T DeserializeAnonymousType(string value, T anonymousTypeObject, JsonSerializerSettings settings) { }

	[Address(RVA = "0x20C85E0", Offset = "0x20C79E0", Length = "0x4F")]
	[DebuggerStepThrough]
	[Token(Token = "0x6000067")]
	public static object DeserializeObject(string value) { }

	[Address(RVA = "0x20C83C0", Offset = "0x20C77C0", Length = "0x5B")]
	[DebuggerStepThrough]
	[Token(Token = "0x6000068")]
	public static object DeserializeObject(string value, JsonSerializerSettings settings) { }

	[Address(RVA = "0x20C8630", Offset = "0x20C7A30", Length = "0x5C")]
	[DebuggerStepThrough]
	[Token(Token = "0x6000069")]
	public static object DeserializeObject(string value, Type type) { }

	[Address(RVA = "0x84E430", Offset = "0x84D830", Length = "0xDD")]
	[DebuggerStepThrough]
	[NullableContext(2)]
	[Token(Token = "0x600006A")]
	public static T DeserializeObject(string value) { }

	[Address(RVA = "0x84E310", Offset = "0x84D710", Length = "0x11F")]
	[DebuggerStepThrough]
	[Token(Token = "0x600006D")]
	public static T DeserializeObject(string value, JsonConverter[] converters) { }

	[Address(RVA = "0x20C82F0", Offset = "0x20C76F0", Length = "0xC8")]
	[DebuggerStepThrough]
	[Token(Token = "0x600006F")]
	public static object DeserializeObject(string value, Type type, JsonConverter[] converters) { }

	[Address(RVA = "0x84E510", Offset = "0x84D910", Length = "0x11F")]
	[DebuggerStepThrough]
	[NullableContext(2)]
	[Token(Token = "0x600006E")]
	public static T DeserializeObject(string value, JsonSerializerSettings settings) { }

	[Address(RVA = "0x20C8420", Offset = "0x20C7820", Length = "0x1BE")]
	[NullableContext(2)]
	[Token(Token = "0x6000070")]
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	[Address(RVA = "0x20C8EF0", Offset = "0x20C82F0", Length = "0x80")]
	[Token(Token = "0x6000076")]
	public static XmlDocument DeserializeXmlNode(string value) { }

	[Address(RVA = "0x20C8F70", Offset = "0x20C8370", Length = "0x5C")]
	[NullableContext(2)]
	[Token(Token = "0x6000077")]
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName) { }

	[Address(RVA = "0x20C8B30", Offset = "0x20C7F30", Length = "0x1E2")]
	[NullableContext(2)]
	[Token(Token = "0x6000078")]
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { }

	[Address(RVA = "0x20C8D20", Offset = "0x20C8120", Length = "0x1C1")]
	[NullableContext(2)]
	[Token(Token = "0x6000079")]
	public static XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { }

	[Address(RVA = "0x20C8AB0", Offset = "0x20C7EB0", Length = "0x80")]
	[Token(Token = "0x600007D")]
	public static XDocument DeserializeXNode(string value) { }

	[Address(RVA = "0x20C8880", Offset = "0x20C7C80", Length = "0x5C")]
	[NullableContext(2)]
	[Token(Token = "0x600007E")]
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName) { }

	[Address(RVA = "0x20C8690", Offset = "0x20C7A90", Length = "0x1E2")]
	[NullableContext(2)]
	[Token(Token = "0x600007F")]
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { }

	[Address(RVA = "0x20C88E0", Offset = "0x20C7CE0", Length = "0x1C1")]
	[NullableContext(2)]
	[Token(Token = "0x6000080")]
	public static XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters) { }

	[Address(RVA = "0x20C90A0", Offset = "0x20C84A0", Length = "0x5A")]
	[Token(Token = "0x6000050")]
	private static string EnsureDecimalPlace(string text) { }

	[Address(RVA = "0x20C8FD0", Offset = "0x20C83D0", Length = "0xC4")]
	[Token(Token = "0x600004F")]
	private static string EnsureDecimalPlace(double value, string text) { }

	[Address(RVA = "0x20C9100", Offset = "0x20C8500", Length = "0x142")]
	[Token(Token = "0x600004C")]
	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	[Address(RVA = "0x20CCCA0", Offset = "0x20CC0A0", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x600003A")]
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	[Address(RVA = "0x20C9460", Offset = "0x20C8860", Length = "0x5C")]
	[DebuggerStepThrough]
	[Token(Token = "0x6000071")]
	public static void PopulateObject(string value, object target) { }

	[Address(RVA = "0x20C9250", Offset = "0x20C8650", Length = "0x20E")]
	[Token(Token = "0x6000072")]
	public static void PopulateObject(string value, object target, JsonSerializerSettings settings) { }

	[Address(RVA = "0x20C9880", Offset = "0x20C8C80", Length = "0x93")]
	[DebuggerStepThrough]
	[Token(Token = "0x600005E")]
	public static string SerializeObject(object value) { }

	[Address(RVA = "0x20C9AA0", Offset = "0x20C8EA0", Length = "0xD0")]
	[DebuggerStepThrough]
	[Token(Token = "0x6000061")]
	public static string SerializeObject(object value, Formatting formatting, JsonConverter[] converters) { }

	[Address(RVA = "0x20C9770", Offset = "0x20C8B70", Length = "0x10C")]
	[DebuggerStepThrough]
	[Token(Token = "0x6000060")]
	public static string SerializeObject(object value, JsonConverter[] converters) { }

	[Address(RVA = "0x20C9920", Offset = "0x20C8D20", Length = "0xF3")]
	[DebuggerStepThrough]
	[Token(Token = "0x600005F")]
	public static string SerializeObject(object value, Formatting formatting) { }

	[Address(RVA = "0x20C9A20", Offset = "0x20C8E20", Length = "0x71")]
	[DebuggerStepThrough]
	[NullableContext(2)]
	[Token(Token = "0x6000064")]
	public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings) { }

	[Address(RVA = "0x20C9B80", Offset = "0x20C8F80", Length = "0xC1")]
	[DebuggerStepThrough]
	[NullableContext(2)]
	[Token(Token = "0x6000065")]
	public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings) { }

	[Address(RVA = "0x20C9C50", Offset = "0x20C9050", Length = "0xB3")]
	[DebuggerStepThrough]
	[NullableContext(2)]
	[Token(Token = "0x6000062")]
	public static string SerializeObject(object value, JsonSerializerSettings settings) { }

	[Address(RVA = "0x20C96E0", Offset = "0x20C8AE0", Length = "0x90")]
	[DebuggerStepThrough]
	[NullableContext(2)]
	[Token(Token = "0x6000063")]
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	[Address(RVA = "0x20C94C0", Offset = "0x20C88C0", Length = "0x216")]
	[Token(Token = "0x6000066")]
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	[Address(RVA = "0x20CA1F0", Offset = "0x20C95F0", Length = "0x109")]
	[Token(Token = "0x6000075")]
	public static string SerializeXmlNode(XmlNode node, Formatting formatting, bool omitRootObject) { }

	[Address(RVA = "0x20CA300", Offset = "0x20C9700", Length = "0x102")]
	[Token(Token = "0x6000074")]
	public static string SerializeXmlNode(XmlNode node, Formatting formatting) { }

	[Address(RVA = "0x20CA0C0", Offset = "0x20C94C0", Length = "0x127")]
	[Token(Token = "0x6000073")]
	public static string SerializeXmlNode(XmlNode node) { }

	[Address(RVA = "0x20C9D10", Offset = "0x20C9110", Length = "0x15C")]
	[Token(Token = "0x600007A")]
	public static string SerializeXNode(XObject node) { }

	[Address(RVA = "0x20C9F80", Offset = "0x20C9380", Length = "0x13B")]
	[Token(Token = "0x600007B")]
	public static string SerializeXNode(XObject node, Formatting formatting) { }

	[Address(RVA = "0x20C9E70", Offset = "0x20C9270", Length = "0x109")]
	[Token(Token = "0x600007C")]
	public static string SerializeXNode(XObject node, Formatting formatting, bool omitRootObject) { }

	[Address(RVA = "0x20CCCF0", Offset = "0x20CC0F0", Length = "0x69")]
	[CompilerGenerated]
	[Token(Token = "0x600003B")]
	public static void set_DefaultSettings(Func<JsonSerializerSettings> value) { }

	[Address(RVA = "0x20CCA50", Offset = "0x20CBE50", Length = "0x46")]
	[Token(Token = "0x6000042")]
	public static string ToString(Enum value) { }

	[Address(RVA = "0x20CBAC0", Offset = "0x20CAEC0", Length = "0x57")]
	[Token(Token = "0x6000051")]
	public static string ToString(byte value) { }

	[Address(RVA = "0x20CA700", Offset = "0x20C9B00", Length = "0x6B")]
	[Token(Token = "0x6000041")]
	public static string ToString(char value) { }

	[Address(RVA = "0x20CBE80", Offset = "0x20CB280", Length = "0x82")]
	[Token(Token = "0x6000040")]
	public static string ToString(bool value) { }

	[Address(RVA = "0x20CBB20", Offset = "0x20CAF20", Length = "0x1D4")]
	[Token(Token = "0x600003F")]
	public static string ToString(DateTimeOffset value, DateFormatHandling format) { }

	[Address(RVA = "0x20CC7A0", Offset = "0x20CBBA0", Length = "0x57")]
	[Token(Token = "0x600003E")]
	public static string ToString(DateTimeOffset value) { }

	[Address(RVA = "0x20CBF10", Offset = "0x20CB310", Length = "0x1D8")]
	[Token(Token = "0x600003D")]
	public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling) { }

	[Address(RVA = "0x20CC740", Offset = "0x20CBB40", Length = "0x52")]
	[Token(Token = "0x600003C")]
	public static string ToString(DateTime value) { }

	[Address(RVA = "0x20CA770", Offset = "0x20C9B70", Length = "0x57")]
	[Token(Token = "0x6000043")]
	public static string ToString(int value) { }

	[Address(RVA = "0x20CC0F0", Offset = "0x20CB4F0", Length = "0x58")]
	[Token(Token = "0x6000044")]
	public static string ToString(short value) { }

	[Address(RVA = "0x20CA6A0", Offset = "0x20C9AA0", Length = "0x58")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000049")]
	public static string ToString(ulong value) { }

	[Address(RVA = "0x20CC1B0", Offset = "0x20CB5B0", Length = "0x57")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000046")]
	public static string ToString(uint value) { }

	[Address(RVA = "0x20CC5C0", Offset = "0x20CB9C0", Length = "0x57")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000052")]
	public static string ToString(sbyte value) { }

	[Address(RVA = "0x20CA4A0", Offset = "0x20C98A0", Length = "0xF9")]
	[Token(Token = "0x6000053")]
	public static string ToString(decimal value) { }

	[Address(RVA = "0x20CA5A0", Offset = "0x20C99A0", Length = "0xF9")]
	[Token(Token = "0x6000054")]
	public static string ToString(Guid value) { }

	[Address(RVA = "0x20CC800", Offset = "0x20CBC00", Length = "0xB9")]
	[Token(Token = "0x6000055")]
	internal static string ToString(Guid value, char quoteChar) { }

	[Address(RVA = "0x20CC390", Offset = "0x20CB790", Length = "0x124")]
	[Token(Token = "0x6000056")]
	public static string ToString(TimeSpan value) { }

	[Address(RVA = "0x20CC9C0", Offset = "0x20CBDC0", Length = "0x8C")]
	[Token(Token = "0x6000057")]
	internal static string ToString(TimeSpan value, char quoteChar) { }

	[Address(RVA = "0x20CC210", Offset = "0x20CB610", Length = "0x170")]
	[Token(Token = "0x6000058")]
	public static string ToString(Uri value) { }

	[Address(RVA = "0x20CBA40", Offset = "0x20CAE40", Length = "0x70")]
	[Token(Token = "0x6000059")]
	internal static string ToString(Uri value, char quoteChar) { }

	[Address(RVA = "0x20CBD00", Offset = "0x20CB100", Length = "0xBE")]
	[Token(Token = "0x600005A")]
	public static string ToString(string value) { }

	[Address(RVA = "0x20CB940", Offset = "0x20CAD40", Length = "0xFD")]
	[Token(Token = "0x600005B")]
	public static string ToString(string value, char delimiter) { }

	[Address(RVA = "0x20CB860", Offset = "0x20CAC60", Length = "0xD9")]
	[Token(Token = "0x600005C")]
	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	[Address(RVA = "0x20CC680", Offset = "0x20CBA80", Length = "0xB1")]
	[Token(Token = "0x600004D")]
	public static string ToString(double value) { }

	[Address(RVA = "0x20CC4C0", Offset = "0x20CB8C0", Length = "0x100")]
	[Token(Token = "0x600004B")]
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	[Address(RVA = "0x20CBDC0", Offset = "0x20CB1C0", Length = "0xB5")]
	[Token(Token = "0x600004A")]
	public static string ToString(float value) { }

	[Address(RVA = "0x20CC8C0", Offset = "0x20CBCC0", Length = "0xF8")]
	[Token(Token = "0x600004E")]
	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	[Address(RVA = "0x20CC620", Offset = "0x20CBA20", Length = "0x58")]
	[Token(Token = "0x6000047")]
	public static string ToString(long value) { }

	[Address(RVA = "0x20CC150", Offset = "0x20CB550", Length = "0x58")]
	[CLSCompliant(False)]
	[Token(Token = "0x6000045")]
	public static string ToString(ushort value) { }

	[Address(RVA = "0x20CA7D0", Offset = "0x20C9BD0", Length = "0xFF0")]
	[Token(Token = "0x600005D")]
	public static string ToString(object value) { }

	[Address(RVA = "0x20CA410", Offset = "0x20C9810", Length = "0x84")]
	[Token(Token = "0x6000048")]
	private static string ToStringInternal(BigInteger value) { }

}

