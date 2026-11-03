namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001A9")]
public class XblTournamentTeamResult
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000429")]
	private readonly string <Team>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400042A")]
	private readonly XblTournamentGameResultWithRank <GameResult>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700017E")]
	public XblTournamentGameResultWithRank GameResult
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000919")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700017D")]
	public string Team
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000918")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B8CB70", Offset = "0x2B8BF70", Length = "0xD4")]
	[Token(Token = "0x6000917")]
	internal XblTournamentTeamResult(XblTournamentTeamResult interopStruct) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000919")]
	public XblTournamentGameResultWithRank get_GameResult() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000918")]
	public string get_Team() { }

}

