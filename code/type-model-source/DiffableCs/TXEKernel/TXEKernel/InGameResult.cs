namespace TXEKernel;

[Token(Token = "0x2000097")]
public class InGameResult
{
	[Token(Token = "0x2000098")]
	internal enum TakenLabel : int
	{
		P5000 = 0,
		PlayerUp = 1,
		PowerUp = 2,
		SpeedUp = 3,
		BombStock = 4,
		ArmNormal = 20,
		ArmBeam = 21,
		ArmLaser = 22,
		ArmStarmine = 23,
		ArmHorming = 24,
		ArmGold = 25,
		ArmBlack = 26,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000312")]
	private Dictionary<String, Int32> _enemyDestoryed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000313")]
	private Dictionary<TakenLabel, Int32> _itemTakens; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000314")]
	private float _enemyDestRate; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000315")]
	private float _occRate; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000316")]
	private int _bossTime; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000317")]
	private bool _isComplete; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[Token(Token = "0x4000318")]
	private bool _isGameOver; //Field offset: 0x2D

	[Token(Token = "0x170001A0")]
	public float DestRate
	{
		[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
		[Token(Token = "0x6000503")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001A2")]
	public int DestTime
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x6000505")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700019E")]
	public Dictionary<String, Int32> EnemyDestroyed
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000501")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001A3")]
	public bool IsComplete
	{
		[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
		[Token(Token = "0x6000506")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001A4")]
	public bool IsGameOver
	{
		[Address(RVA = "0x25D7F70", Offset = "0x25D7370", Length = "0x5")]
		[Token(Token = "0x6000507")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700019F")]
	public Dictionary<TakenLabel, Int32> ItemTakens
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000502")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001A1")]
	public float OccRate
	{
		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[Token(Token = "0x6000504")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x26F4D60", Offset = "0x26F4160", Length = "0x112")]
	[Token(Token = "0x60004FF")]
	public InGameResult(Dictionary<String, Int32> _destroyed, Dictionary<TakenLabel, Int32> _takens, float drate, float tocc, int bossTime, bool isCompleteStage, bool isGameover) { }

	[Address(RVA = "0x26F4C40", Offset = "0x26F4040", Length = "0x111")]
	[Token(Token = "0x6000500")]
	public InGameResult(InGameResult other) { }

	[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
	[Token(Token = "0x6000503")]
	public float get_DestRate() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x6000505")]
	public int get_DestTime() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000501")]
	public Dictionary<String, Int32> get_EnemyDestroyed() { }

	[Address(RVA = "0x1CC5390", Offset = "0x1CC4790", Length = "0x5")]
	[Token(Token = "0x6000506")]
	public bool get_IsComplete() { }

	[Address(RVA = "0x25D7F70", Offset = "0x25D7370", Length = "0x5")]
	[Token(Token = "0x6000507")]
	public bool get_IsGameOver() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000502")]
	public Dictionary<TakenLabel, Int32> get_ItemTakens() { }

	[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
	[Token(Token = "0x6000504")]
	public float get_OccRate() { }

}

