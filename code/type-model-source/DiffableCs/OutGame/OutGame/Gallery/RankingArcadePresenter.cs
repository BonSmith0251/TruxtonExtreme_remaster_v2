namespace OutGame.Gallery;

[Token(Token = "0x20001DE")]
public class RankingArcadePresenter : RankingPresenterBase
{
	[Token(Token = "0x400083B")]
	public static readonly String[] _rankingString; //Field offset: 0x0
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x400083A")]
	private RankDisplayArcade[] _rankingTable; //Field offset: 0x88

	[Token(Token = "0x170002B2")]
	protected virtual String[] RankingString
	{
		[Address(RVA = "0x22163E0", Offset = "0x22157E0", Length = "0x4E")]
		[Token(Token = "0x6000BFB")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x22161D0", Offset = "0x22155D0", Length = "0x61")]
	[Token(Token = "0x6000BF9")]
	protected virtual void _clearRank() { }

	[Address(RVA = "0x2216290", Offset = "0x2215690", Length = "0x14B")]
	[Token(Token = "0x6000BFA")]
	protected virtual void _dispRank(int rankIndex, int focusRankIndex = -1) { }

	[Address(RVA = "0x2216100", Offset = "0x2215500", Length = "0xCA")]
	[Token(Token = "0x6000BFD")]
	private static RankingArcadePresenter() { }

	[Address(RVA = "0x2216240", Offset = "0x2215640", Length = "0x49")]
	[Token(Token = "0x6000BFC")]
	public RankingArcadePresenter() { }

	[Address(RVA = "0x22163E0", Offset = "0x22157E0", Length = "0x4E")]
	[Token(Token = "0x6000BFB")]
	protected virtual String[] get_RankingString() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000BF7")]
	public static bool IsNew() { }

	[Address(RVA = "0x2216430", Offset = "0x2215830", Length = "0xC")]
	[Token(Token = "0x6000BF8")]
	protected virtual ID rankingTableId() { }

}

