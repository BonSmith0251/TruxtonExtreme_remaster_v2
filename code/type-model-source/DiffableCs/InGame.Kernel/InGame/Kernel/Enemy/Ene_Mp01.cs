namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001FC")]
public class Ene_Mp01 : PawnEnemy
{
	[Token(Token = "0x20001FD")]
	private enum LaserSeq : int
	{
		NONE = -1,
		START = 0,
		AIM = 1,
		FIRE = 2,
		WAIT = 3,
	}

	[Token(Token = "0x40011EE")]
	private static readonly Rect gameScreenAreaMP01; //Field offset: 0x0
	[Token(Token = "0x40011F0")]
	private static readonly float LaserFirstTime; //Field offset: 0x10
	[Token(Token = "0x40011F1")]
	private static readonly float LaserRapidTime; //Field offset: 0x14
	[Token(Token = "0x40011F2")]
	private static readonly float PreLaserTime; //Field offset: 0x18
	[Token(Token = "0x40011F3")]
	private static readonly float AfterLaserTime; //Field offset: 0x1C
	[Token(Token = "0x40011F4")]
	private static readonly float RollSpeedHi; //Field offset: 0x20
	[Token(Token = "0x40011F5")]
	private static readonly float RollSpeedLow; //Field offset: 0x24
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40011ED")]
	private LaserSeq laserSeq; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[SerializeField]
	[Token(Token = "0x40011EF")]
	private Kind _item; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x40011F6")]
	private EnemyTurret _turret; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x40011F7")]
	private Transform _muzzle; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	[Token(Token = "0x40011F8")]
	private Transform _muzzleTop; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[Token(Token = "0x40011F9")]
	private string _bulletName; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x40011FA")]
	private BulletTemplate _bt; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x40011FB")]
	private bool _isStartArea; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x40011FC")]
	private float _localTime; //Field offset: 0x1E4

	[Address(RVA = "0x1CFD680", Offset = "0x1CFCA80", Length = "0x10D")]
	[Token(Token = "0x6000F29")]
	protected virtual void _callDeadEffect() { }

	[Address(RVA = "0x1CFD790", Offset = "0x1CFCB90", Length = "0xBC")]
	[Token(Token = "0x6000F2B")]
	private static Ene_Mp01() { }

	[Address(RVA = "0x1CFD850", Offset = "0x1CFCC50", Length = "0x6D")]
	[Token(Token = "0x6000F2A")]
	public Ene_Mp01() { }

	[Address(RVA = "0x1CFCEF0", Offset = "0x1CFC2F0", Length = "0x386")]
	[Token(Token = "0x6000F26")]
	private void ActionMove() { }

	[Address(RVA = "0x1CFD280", Offset = "0x1CFC680", Length = "0xBB")]
	[Token(Token = "0x6000F28")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1CFD340", Offset = "0x1CFC740", Length = "0xA5")]
	[Token(Token = "0x6000F24")]
	private void Init() { }

	[Address(RVA = "0x1CFD3F0", Offset = "0x1CFC7F0", Length = "0xBB")]
	[Token(Token = "0x6000F22")]
	public virtual void InitializeToPlay() { }

	[Address(RVA = "0x1CFD4B0", Offset = "0x1CFC8B0", Length = "0x20")]
	[Token(Token = "0x6000F25")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1CFD4D0", Offset = "0x1CFC8D0", Length = "0x187")]
	[Token(Token = "0x6000F27")]
	private bool Mp01IsStayPlayArea(InGameManager gm) { }

	[Address(RVA = "0x1CFD660", Offset = "0x1CFCA60", Length = "0x20")]
	[Token(Token = "0x6000F23")]
	public virtual void ReStart(bool withPlay) { }

}

