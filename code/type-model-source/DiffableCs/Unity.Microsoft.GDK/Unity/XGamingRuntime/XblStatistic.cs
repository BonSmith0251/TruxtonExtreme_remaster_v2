namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001FE")]
public class XblStatistic
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000568")]
	private string <StatisticName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000569")]
	private string <StatisticType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400056A")]
	private string <Value>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170001E6")]
	public private string StatisticName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8A")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8B")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001E7")]
	public private string StatisticType
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8C")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8D")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001E8")]
	public private string Value
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8E")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A8F")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2B7D5D0", Offset = "0x2B7C9D0", Length = "0xCE")]
	[Token(Token = "0x6000A88")]
	internal XblStatistic(XblStatisticInternal interopStatistic) { }

	[Address(RVA = "0x2B8C4E0", Offset = "0x2B8B8E0", Length = "0x71")]
	[Token(Token = "0x6000A89")]
	internal XblStatistic(XblStatistic interopStatistic) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8A")]
	public string get_StatisticName() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8C")]
	public string get_StatisticType() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8E")]
	public string get_Value() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8B")]
	private void set_StatisticName(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8D")]
	private void set_StatisticType(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A8F")]
	private void set_Value(string value) { }

}

