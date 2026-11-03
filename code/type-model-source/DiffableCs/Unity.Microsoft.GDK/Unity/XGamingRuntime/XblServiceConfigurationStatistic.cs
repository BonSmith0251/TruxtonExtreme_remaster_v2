namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001FC")]
public class XblServiceConfigurationStatistic
{
	[CompilerGenerated]
	[Token(Token = "0x20001FD")]
	private sealed class <>c
	{
		[Token(Token = "0x4000566")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000567")]
		public static Func<XblStatisticInternal, XblStatistic> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x2B80970", Offset = "0x2B7FD70", Length = "0x67")]
		[Token(Token = "0x6000A85")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A86")]
		public <>c() { }

		[Address(RVA = "0x2B7FB00", Offset = "0x2B7EF00", Length = "0xFC")]
		[Token(Token = "0x6000A87")]
		internal XblStatistic <.ctor>b__0_0(XblStatisticInternal s) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000564")]
	private string <ServiceConfigurationId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000565")]
	private XblStatistic[] <Statistics>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170001E4")]
	public private string ServiceConfigurationId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A81")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A82")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001E5")]
	public private XblStatistic[] Statistics
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A83")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A84")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x2B8B110", Offset = "0x2B8A510", Length = "0x150")]
	[Token(Token = "0x6000A80")]
	internal XblServiceConfigurationStatistic(XblServiceConfigurationStatisticInternal interopStatistic) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A81")]
	public string get_ServiceConfigurationId() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A83")]
	public XblStatistic[] get_Statistics() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A82")]
	private void set_ServiceConfigurationId(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A84")]
	private void set_Statistics(XblStatistic[] value) { }

}

