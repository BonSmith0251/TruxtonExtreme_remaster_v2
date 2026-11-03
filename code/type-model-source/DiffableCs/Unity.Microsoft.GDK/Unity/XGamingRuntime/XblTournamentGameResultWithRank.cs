namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001A6")]
public class XblTournamentGameResultWithRank
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000419")]
	private readonly XblTournamentGameResult <Result>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400041A")]
	private readonly ulong <Ranking>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700017C")]
	public ulong Ranking
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000916")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700017B")]
	public XblTournamentGameResult Result
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000915")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x2B8CB40", Offset = "0x2B8BF40", Length = "0x2F")]
	[Token(Token = "0x6000914")]
	internal XblTournamentGameResultWithRank(XblTournamentGameResultWithRank interopStruct) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000916")]
	public ulong get_Ranking() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000915")]
	public XblTournamentGameResult get_Result() { }

}

