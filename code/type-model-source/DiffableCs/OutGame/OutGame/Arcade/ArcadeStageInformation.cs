namespace OutGame.Arcade;

[Token(Token = "0x20001CF")]
public class ArcadeStageInformation : StageInformation
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40007F8")]
	private int _reachedRound; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40007F9")]
	public bool _isRoundLoop; //Field offset: 0x3C

	[Token(Token = "0x17000293")]
	public virtual bool IsRoundLoop
	{
		[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
		[Token(Token = "0x6000B9E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000292")]
	public virtual int ReachedRound
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6000B9D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000291")]
	public virtual PlayMode StageMode
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000B9C")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2213740", Offset = "0x2212B40", Length = "0x56")]
	[Token(Token = "0x6000B9A")]
	public ArcadeStageInformation(int stage, InGameResult tresult, int reachedRound, bool isRoundLoop) { }

	[Address(RVA = "0x101DB70", Offset = "0x101CF70", Length = "0x5")]
	[Token(Token = "0x6000B9E")]
	public virtual bool get_IsRoundLoop() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6000B9D")]
	public virtual int get_ReachedRound() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000B9C")]
	public virtual PlayMode get_StageMode() { }

	[Address(RVA = "0x2213550", Offset = "0x2212950", Length = "0x1E4")]
	[Token(Token = "0x6000B9B")]
	public virtual string StageName() { }

}

