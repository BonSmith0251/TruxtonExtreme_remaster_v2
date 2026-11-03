namespace TXEKernel;

[Token(Token = "0x2000099")]
public abstract class StageInformation
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000326")]
	protected InGameResult _gameResult; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000327")]
	protected int _reachedStage; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000328")]
	private Dictionary<String, Int32> _enemyDestoryed; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000329")]
	private float _enemyDestructionRate; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400032A")]
	private int _bossTime; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400032B")]
	private bool _isBossDestroy; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400032C")]
	private bool _isGameEnd; //Field offset: 0x31

	[Token(Token = "0x170001A6")]
	public override PlayActor Actor
	{
		[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
		[Token(Token = "0x600050D")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001AB")]
	public int BossTime
	{
		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[Token(Token = "0x6000512")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001A9")]
	public Dictionary<String, Int32> EnemyDestoryed
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000510")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001AA")]
	public float EnemyDestructionRate
	{
		[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
		[Token(Token = "0x6000511")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001A7")]
	public InGameResult GameResult
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600050E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001B1")]
	public override bool InfiniteLives
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000518")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001AC")]
	public bool IsBossDestroy
	{
		[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
		[Token(Token = "0x6000513")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001AD")]
	public bool IsGameEnd
	{
		[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
		[Token(Token = "0x6000514")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001AF")]
	public override bool IsRoundLoop
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000516")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001B0")]
	public override int PlayerNo
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000517")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001AE")]
	public override int ReachedRound
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000515")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001A8")]
	public int ReachedStage
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x600050F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001A5")]
	public abstract PlayMode StageMode
	{
		[Token(Token = "0x600050C")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x26F85C0", Offset = "0x26F79C0", Length = "0x1E4")]
	[Token(Token = "0x6000508")]
	public StageInformation(int stage, InGameResult gameResult) { }

	[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
	[Token(Token = "0x600050D")]
	public override PlayActor get_Actor() { }

	[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
	[Token(Token = "0x6000512")]
	public int get_BossTime() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000510")]
	public Dictionary<String, Int32> get_EnemyDestoryed() { }

	[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
	[Token(Token = "0x6000511")]
	public float get_EnemyDestructionRate() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600050E")]
	public InGameResult get_GameResult() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000518")]
	public override bool get_InfiniteLives() { }

	[Address(RVA = "0xD998E0", Offset = "0xD98CE0", Length = "0x5")]
	[Token(Token = "0x6000513")]
	public bool get_IsBossDestroy() { }

	[Address(RVA = "0x1E075B0", Offset = "0x1E069B0", Length = "0x5")]
	[Token(Token = "0x6000514")]
	public bool get_IsGameEnd() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000516")]
	public override bool get_IsRoundLoop() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000517")]
	public override int get_PlayerNo() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000515")]
	public override int get_ReachedRound() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x600050F")]
	public int get_ReachedStage() { }

	[Token(Token = "0x600050C")]
	public abstract PlayMode get_StageMode() { }

	[Address(RVA = "0x26F85B0", Offset = "0x26F79B0", Length = "0x8")]
	[Token(Token = "0x6000509")]
	public override bool IsBonusFailed() { }

	[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
	[Token(Token = "0x600050A")]
	public void SetGameEnd(bool tflag) { }

	[Token(Token = "0x600050B")]
	public abstract string StageName() { }

}

