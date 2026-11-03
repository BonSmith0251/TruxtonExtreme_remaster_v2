namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000154")]
public class BulletTemplate : ScriptableObject
{
	[Flags]
	[Token(Token = "0x2000155")]
	internal enum BTFlag : int
	{
		None = 0,
		ScaleRapid = 1,
		ScaleSecond = 2,
		WideShot = 65536,
	}

	[Token(Token = "0x2000156")]
	internal enum LimitArcKind : int
	{
		none = 0,
		_div4 = 1,
		_div8 = 2,
		_div16 = 3,
		_div24 = 4,
		_div32 = 5,
		_div48 = 6,
		_div64 = 7,
	}

	[Token(Token = "0x4000986")]
	private static readonly Single[] _limitArcTable; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000966")]
	public int dataVersion; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000967")]
	public string bulletName; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000968")]
	public EnemyBullet bulletType; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000969")]
	public float nArc; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400096A")]
	public float nStartArc; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400096B")]
	public int nRandomArc; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400096C")]
	public LimitArcKind nLimitArc; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x400096D")]
	public BTFlag btFlag; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400096E")]
	public float nSpeed; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400096F")]
	public float nIrradiation; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000970")]
	public float nTempValue0; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x4000971")]
	public int nRapidCount; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000972")]
	public int nSoundLap; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x4000973")]
	public float nRapidInflation; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000974")]
	public float nRapidDistance; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x4000975")]
	public float nRapidRotation; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000976")]
	public EnemyBullet nRapidWaySwitch; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x4000977")]
	public float nRapidArcSwitch; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000978")]
	public MoveType moveType; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x4000979")]
	public CurveType curveType; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x400097A")]
	public float nCurveArc; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x400097B")]
	public float nCurveRange; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x400097C")]
	public float nFirePosRadius; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x400097D")]
	public bool isTarget; //Field offset: 0x7C
	[FieldOffset(Offset = "0x7D")]
	[SerializeField]
	[Token(Token = "0x400097E")]
	public bool isRapidTarget; //Field offset: 0x7D
	[FieldOffset(Offset = "0x7E")]
	[SerializeField]
	[Token(Token = "0x400097F")]
	public bool isReverse; //Field offset: 0x7E
	[FieldOffset(Offset = "0x7F")]
	[SerializeField]
	[Token(Token = "0x4000980")]
	public bool isSelfDir; //Field offset: 0x7F
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000981")]
	public bool isMuzzleEffect; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000982")]
	public AnimationCurve curveAnime; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000983")]
	public bool isLaser; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000984")]
	public BulletKind bKind; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000985")]
	public ID SeKind; //Field offset: 0x98

	[Token(Token = "0x170001C4")]
	public bool isWideShot
	{
		[Address(RVA = "0x1D61840", Offset = "0x1D60C40", Length = "0xB")]
		[Token(Token = "0x6000A6F")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x1D61730", Offset = "0x1D60B30", Length = "0x8C")]
	[Token(Token = "0x6000A71")]
	private static BulletTemplate() { }

	[Address(RVA = "0x1D617C0", Offset = "0x1D60BC0", Length = "0x7F")]
	[Token(Token = "0x6000A70")]
	public BulletTemplate() { }

	[Address(RVA = "0x1D614A0", Offset = "0x1D608A0", Length = "0x10")]
	[Token(Token = "0x6000A6D")]
	public void ChangeSE(BulletKind bk, ID seid) { }

	[Address(RVA = "0x1D61840", Offset = "0x1D60C40", Length = "0xB")]
	[Token(Token = "0x6000A6F")]
	public bool get_isWideShot() { }

	[Address(RVA = "0x1D614B0", Offset = "0x1D608B0", Length = "0x17A")]
	[Token(Token = "0x6000A6C")]
	public float GetLimitArc(float nArc) { }

	[Address(RVA = "0x1D61650", Offset = "0x1D60A50", Length = "0x13")]
	[Token(Token = "0x6000A6A")]
	public EnemyBullet GetWay(int nlap) { }

	[Address(RVA = "0x1D61630", Offset = "0x1D60A30", Length = "0x17")]
	[Token(Token = "0x6000A6B")]
	public float GetWayArc(int nlap) { }

	[Address(RVA = "0x1D61670", Offset = "0x1D60A70", Length = "0x5F")]
	[Token(Token = "0x6000A68")]
	public void Initialize() { }

	[Address(RVA = "0x1D616D0", Offset = "0x1D60AD0", Length = "0x45")]
	[Token(Token = "0x6000A69")]
	public void SetDefault() { }

	[Address(RVA = "0x1D61720", Offset = "0x1D60B20", Length = "0x4")]
	[Token(Token = "0x6000A6E")]
	public void SetFlag(BTFlag tflag) { }

}

