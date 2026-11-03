namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20001BC")]
public class StringEnumConverter : JsonConverter
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Nullable(2)]
	[Token(Token = "0x400080E")]
	private NamingStrategy <NamingStrategy>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400080F")]
	private bool <AllowIntegerValues>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000253")]
	public bool AllowIntegerValues
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000EED")]
		 get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000EEE")]
		 set { } //Length: 4
	}

	[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
	[Token(Token = "0x17000251")]
	public bool CamelCaseText
	{
		[Address(RVA = "0x21AFC60", Offset = "0x21AF060", Length = "0x69")]
		[Token(Token = "0x6000EE9")]
		 get { } //Length: 105
		[Address(RVA = "0x21AFCD0", Offset = "0x21AF0D0", Length = "0xD1")]
		[Token(Token = "0x6000EEA")]
		 set { } //Length: 209
	}

	[Nullable(2)]
	[Token(Token = "0x17000252")]
	public NamingStrategy NamingStrategy
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000EEB")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x6000EEC")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x21AFA40", Offset = "0x21AEE40", Length = "0xB")]
	[Token(Token = "0x6000EEF")]
	public StringEnumConverter() { }

	[Address(RVA = "0x21AF9C0", Offset = "0x21AEDC0", Length = "0x72")]
	[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
	[Token(Token = "0x6000EF0")]
	public StringEnumConverter(bool camelCaseText) { }

	[Address(RVA = "0x21AF970", Offset = "0x21AED70", Length = "0x48")]
	[Token(Token = "0x6000EF1")]
	public StringEnumConverter(NamingStrategy namingStrategy, bool allowIntegerValues = true) { }

	[Address(RVA = "0x21AFA50", Offset = "0x21AEE50", Length = "0x94")]
	[Token(Token = "0x6000EF2")]
	public StringEnumConverter(Type namingStrategyType) { }

	[Address(RVA = "0x21AFAF0", Offset = "0x21AEEF0", Length = "0xA2")]
	[Token(Token = "0x6000EF3")]
	public StringEnumConverter(Type namingStrategyType, Object[] namingStrategyParameters) { }

	[Address(RVA = "0x21AFBA0", Offset = "0x21AEFA0", Length = "0xB5")]
	[Token(Token = "0x6000EF4")]
	public StringEnumConverter(Type namingStrategyType, Object[] namingStrategyParameters, bool allowIntegerValues) { }

	[Address(RVA = "0x21AF290", Offset = "0x21AE690", Length = "0x64")]
	[Token(Token = "0x6000EF7")]
	public virtual bool CanConvert(Type objectType) { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000EED")]
	public bool get_AllowIntegerValues() { }

	[Address(RVA = "0x21AFC60", Offset = "0x21AF060", Length = "0x69")]
	[Token(Token = "0x6000EE9")]
	public bool get_CamelCaseText() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x6000EEB")]
	public NamingStrategy get_NamingStrategy() { }

	[Address(RVA = "0x21AF300", Offset = "0x21AE700", Length = "0x462")]
	[Token(Token = "0x6000EF6")]
	public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000EEE")]
	public void set_AllowIntegerValues(bool value) { }

	[Address(RVA = "0x21AFCD0", Offset = "0x21AF0D0", Length = "0xD1")]
	[Token(Token = "0x6000EEA")]
	public void set_CamelCaseText(bool value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x6000EEC")]
	public void set_NamingStrategy(NamingStrategy value) { }

	[Address(RVA = "0x21AF770", Offset = "0x21AEB70", Length = "0x1F7")]
	[Token(Token = "0x6000EF5")]
	public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

}

