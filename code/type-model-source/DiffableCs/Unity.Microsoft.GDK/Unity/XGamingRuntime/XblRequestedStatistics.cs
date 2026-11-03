namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001FB")]
public class XblRequestedStatistics
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000562")]
	private string <ServiceConfigurationId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000563")]
	private String[] <Statistics>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170001E2")]
	public private string ServiceConfigurationId
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A7C")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A7D")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001E3")]
	public private String[] Statistics
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A7E")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A7F")]
		private set { } //Length: 13
	}

	[Address(RVA = "0xE10830", Offset = "0xE0FC30", Length = "0x4E")]
	[Token(Token = "0x6000A7A")]
	private XblRequestedStatistics(string serviceConfigurationId, String[] statistics) { }

	[Address(RVA = "0x2B8B040", Offset = "0x2B8A440", Length = "0xCB")]
	[Token(Token = "0x6000A7B")]
	public static int Create(string serviceConfigurationId, String[] statistics, out XblRequestedStatistics requestedStatistics) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A7C")]
	public string get_ServiceConfigurationId() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A7E")]
	public String[] get_Statistics() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A7D")]
	private void set_ServiceConfigurationId(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A7F")]
	private void set_Statistics(String[] value) { }

}

