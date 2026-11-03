namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001BD")]
public class UnixDateTimeConverter : DateTimeConverterBase
{
	[Token(Token = "0x4000810")]
	internal static readonly DateTime UnixEpoch; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000811")]
	private bool <AllowPreEpoch>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000254")]
	public bool AllowPreEpoch
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF8")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000EF9")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x21B0570", Offset = "0x21AF970", Length = "0x73")]
	[Token(Token = "0x6000EFE")]
	private static UnixDateTimeConverter() { }

	[Address(RVA = "0x21B05F0", Offset = "0x21AF9F0", Length = "0x1A")]
	[Token(Token = "0x6000EFA")]
	public UnixDateTimeConverter() { }

	[Address(RVA = "0x21B0610", Offset = "0x21AFA10", Length = "0x26")]
	[Token(Token = "0x6000EFB")]
	public UnixDateTimeConverter(bool allowPreEpoch) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF8")]
	public bool get_AllowPreEpoch() { }

	[Address(RVA = "0x21AFDB0", Offset = "0x21AF1B0", Length = "0x4CE")]
	[Token(Token = "0x6000EFD")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000EF9")]
	public void set_AllowPreEpoch(bool value) { }

	[Address(RVA = "0x21B0280", Offset = "0x21AF680", Length = "0x2E2")]
	[Token(Token = "0x6000EFC")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

