namespace OutGame.Gallery;

[Token(Token = "0x20001E4")]
public class RankingArenaPresenter : RankingPresenterBase
{
	[Token(Token = "0x400084C")]
	public static readonly String[] _rankingString; //Field offset: 0x0
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x400084B")]
	private RankDisplay[] _rankingTable; //Field offset: 0x88

	[Token(Token = "0x170002BC")]
	protected virtual String[] RankingString
	{
		[Address(RVA = "0x2216EE0", Offset = "0x22162E0", Length = "0x4E")]
		[Token(Token = "0x6000C26")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x22161D0", Offset = "0x22155D0", Length = "0x61")]
	[Token(Token = "0x6000C24")]
	protected virtual void _clearRank() { }

	[Address(RVA = "0x2216DC0", Offset = "0x22161C0", Length = "0x111")]
	[Token(Token = "0x6000C25")]
	protected virtual void _dispRank(int rankIndex, int focusRankIndex = -1) { }

	[Address(RVA = "0x2216CC0", Offset = "0x22160C0", Length = "0xA4")]
	[Token(Token = "0x6000C28")]
	private static RankingArenaPresenter() { }

	[Address(RVA = "0x2216D70", Offset = "0x2216170", Length = "0x49")]
	[Token(Token = "0x6000C27")]
	public RankingArenaPresenter() { }

	[Address(RVA = "0x2216EE0", Offset = "0x22162E0", Length = "0x4E")]
	[Token(Token = "0x6000C26")]
	protected virtual String[] get_RankingString() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000C22")]
	public static bool IsNew() { }

	[Address(RVA = "0x2216F30", Offset = "0x2216330", Length = "0x6")]
	[Token(Token = "0x6000C23")]
	protected virtual ID rankingTableId() { }

}

