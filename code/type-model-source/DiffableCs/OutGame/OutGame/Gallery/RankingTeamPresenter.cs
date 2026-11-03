namespace OutGame.Gallery;

[Token(Token = "0x2000200")]
public class RankingTeamPresenter : RankingPresenterBase
{
	[Token(Token = "0x40008BD")]
	public static readonly String[] _rankingString; //Field offset: 0x0
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x40008BC")]
	private RankDisplay[] _rankingTable; //Field offset: 0x88

	[Token(Token = "0x170002DC")]
	protected virtual String[] RankingString
	{
		[Address(RVA = "0x2226D40", Offset = "0x2226140", Length = "0x4E")]
		[Token(Token = "0x6000CB8")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x22161D0", Offset = "0x22155D0", Length = "0x61")]
	[Token(Token = "0x6000CB6")]
	protected virtual void _clearRank() { }

	[Address(RVA = "0x2216DC0", Offset = "0x22161C0", Length = "0x111")]
	[Token(Token = "0x6000CB7")]
	protected virtual void _dispRank(int rankIndex, int focusRankIndex = -1) { }

	[Address(RVA = "0x2226C40", Offset = "0x2226040", Length = "0xA4")]
	[Token(Token = "0x6000CBA")]
	private static RankingTeamPresenter() { }

	[Address(RVA = "0x2226CF0", Offset = "0x22260F0", Length = "0x49")]
	[Token(Token = "0x6000CB9")]
	public RankingTeamPresenter() { }

	[Address(RVA = "0x2226D40", Offset = "0x2226140", Length = "0x4E")]
	[Token(Token = "0x6000CB8")]
	protected virtual String[] get_RankingString() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000CB4")]
	public static bool IsNew() { }

	[Address(RVA = "0x1E82360", Offset = "0x1E81760", Length = "0x6")]
	[Token(Token = "0x6000CB5")]
	protected virtual ID rankingTableId() { }

}

