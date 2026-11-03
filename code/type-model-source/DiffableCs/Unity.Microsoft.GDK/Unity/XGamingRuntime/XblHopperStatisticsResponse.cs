namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000167")]
public class XblHopperStatisticsResponse
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A1")]
	private string <HopperName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002A2")]
	private long <EstimatedWaitTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002A3")]
	private uint <PlayersWaitingToMatch>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170000BF")]
	public long EstimatedWaitTime
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000802")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000803")]
		 set { } //Length: 5
	}

	[Token(Token = "0x170000BE")]
	public string HopperName
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000800")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000801")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000C0")]
	public uint PlayersWaitingToMatch
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000804")]
		 get { } //Length: 4
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000805")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x2B86230", Offset = "0x2B85630", Length = "0x52")]
	[Token(Token = "0x60007FE")]
	internal XblHopperStatisticsResponse() { }

	[Address(RVA = "0x2B86290", Offset = "0x2B85690", Length = "0x4A")]
	[Token(Token = "0x60007FF")]
	internal XblHopperStatisticsResponse(XblHopperStatisticsResponse interopHandle) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000802")]
	public long get_EstimatedWaitTime() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000800")]
	public string get_HopperName() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000804")]
	public uint get_PlayersWaitingToMatch() { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000803")]
	public void set_EstimatedWaitTime(long value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000801")]
	public void set_HopperName(string value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000805")]
	public void set_PlayersWaitingToMatch(uint value) { }

}

