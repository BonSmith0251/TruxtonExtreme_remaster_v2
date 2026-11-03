namespace OutGame.Arena;

[Token(Token = "0x20001BA")]
public class ArenaStageInformation : StageInformation
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007A5")]
	private int _playerNo; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40007A6")]
	private bool _infiniteLives; //Field offset: 0x3C

	[Token(Token = "0x17000265")]
	public virtual bool InfiniteLives
	{
		[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
		[Token(Token = "0x6000B09")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000264")]
	public virtual int PlayerNo
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000B08")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000263")]
	public virtual PlayMode StageMode
	{
		[Address(RVA = "0x20282A0", Offset = "0x20276A0", Length = "0x6")]
		[Token(Token = "0x6000B07")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2215480", Offset = "0x2214880", Length = "0x48")]
	[Token(Token = "0x6000B04")]
	public ArenaStageInformation(int playerNo, bool infiniteLives, int stage, InGameResult tresult) { }

	[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
	[Token(Token = "0x6000B09")]
	public virtual bool get_InfiniteLives() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000B08")]
	public virtual int get_PlayerNo() { }

	[Address(RVA = "0x20282A0", Offset = "0x20276A0", Length = "0x6")]
	[Token(Token = "0x6000B07")]
	public virtual PlayMode get_StageMode() { }

	[Address(RVA = "0xD99BB0", Offset = "0xD98FB0", Length = "0x8")]
	[Token(Token = "0x6000B05")]
	public virtual bool IsBonusFailed() { }

	[Address(RVA = "0x2215450", Offset = "0x2214850", Length = "0x2C")]
	[Token(Token = "0x6000B06")]
	public virtual string StageName() { }

}

