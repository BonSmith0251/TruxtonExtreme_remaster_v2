namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000205")]
public class XblUserStatisticsResult
{
	[CompilerGenerated]
	[Token(Token = "0x2000206")]
	private sealed class <>c
	{
		[Token(Token = "0x4000570")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000571")]
		public static Func<XblServiceConfigurationStatisticInternal, XblServiceConfigurationStatistic> <>9__0_0; //Field offset: 0x8

		[Address(RVA = "0x2B80A50", Offset = "0x2B7FE50", Length = "0x67")]
		[Token(Token = "0x6000AAA")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000AAB")]
		public <>c() { }

		[Address(RVA = "0x2B7FE20", Offset = "0x2B7F220", Length = "0x187")]
		[Token(Token = "0x6000AAC")]
		internal XblServiceConfigurationStatistic <.ctor>b__0_0(XblServiceConfigurationStatisticInternal scs) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400056E")]
	private ulong <XboxUserId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400056F")]
	private XblServiceConfigurationStatistic[] <ServiceConfigStatistics>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170001EA")]
	public private XblServiceConfigurationStatistic[] ServiceConfigStatistics
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA8")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA9")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001E9")]
	public private ulong XboxUserId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA6")]
		 get { } //Length: 5
		[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AA7")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x2B8CD70", Offset = "0x2B8C170", Length = "0x13F")]
	[Token(Token = "0x6000AA5")]
	internal XblUserStatisticsResult(XblUserStatisticsResultInternal interopResult) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA8")]
	public XblServiceConfigurationStatistic[] get_ServiceConfigStatistics() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA6")]
	public ulong get_XboxUserId() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA9")]
	private void set_ServiceConfigStatistics(XblServiceConfigurationStatistic[] value) { }

	[Address(RVA = "0x1160450", Offset = "0x115F850", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AA7")]
	private void set_XboxUserId(ulong value) { }

}

