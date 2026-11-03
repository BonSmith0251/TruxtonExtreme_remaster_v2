namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000227")]
public class PawnEnemyGround : PawnEnemyDD
{
	[Token(Token = "0x2000228")]
	internal enum RuinKind : int
	{
		None = 0,
		BurntSmall = 1,
		BurntMiddle = 2,
		BurntMini = 3,
	}

	[Token(Token = "0x4001353")]
	private static readonly Rect groundEnemyActiveArea; //Field offset: 0x0
	[Token(Token = "0x400135C")]
	public static readonly string ItemOfIndexString; //Field offset: 0x10
	[Token(Token = "0x400135D")]
	public static readonly string ItemOfScoreString; //Field offset: 0x18
	[Token(Token = "0x400135E")]
	private static readonly String[] BurntNames; //Field offset: 0x20
	[Token(Token = "0x400135F")]
	public static readonly string NoRuinName; //Field offset: 0x28
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[Token(Token = "0x4001354")]
	private string _ruinName; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	[Token(Token = "0x4001355")]
	private RuinKind _ruinBurnt; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1DC")]
	[SerializeField]
	[Token(Token = "0x4001356")]
	private Vector3 _groundRuinOffset; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	[Token(Token = "0x4001357")]
	private float _cameraRangeDistance; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1EC")]
	[SerializeField]
	[Token(Token = "0x4001358")]
	private bool _isPoseRecord; //Field offset: 0x1EC
	[FieldOffset(Offset = "0x1ED")]
	[Token(Token = "0x4001359")]
	protected bool _isInGamePlayArea; //Field offset: 0x1ED
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x400135A")]
	protected Vector3 _startPosition; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1FC")]
	[Token(Token = "0x400135B")]
	protected Kind _dropKind; //Field offset: 0x1FC

	[Token(Token = "0x17000224")]
	protected override Rect GroundEnemyActiveArea
	{
		[Address(RVA = "0x1D18510", Offset = "0x1D17910", Length = "0x5A")]
		[Token(Token = "0x6001085")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x1D17FE0", Offset = "0x1D173E0", Length = "0x2BE")]
	[Token(Token = "0x600107E")]
	protected virtual void _callDeadEffect() { }

	[Address(RVA = "0x1D182A0", Offset = "0x1D176A0", Length = "0x20B")]
	[Token(Token = "0x6001087")]
	private static PawnEnemyGround() { }

	[Address(RVA = "0x1D184B0", Offset = "0x1D178B0", Length = "0x5D")]
	[Token(Token = "0x6001086")]
	public PawnEnemyGround() { }

	[Address(RVA = "0x1D17690", Offset = "0x1D16A90", Length = "0x1DF")]
	[Token(Token = "0x600107F")]
	protected override bool DropItem(Kind dkind, Transform root, Vector3 curpos, float alivetime) { }

	[Address(RVA = "0x1D18510", Offset = "0x1D17910", Length = "0x5A")]
	[Token(Token = "0x6001085")]
	protected override Rect get_GroundEnemyActiveArea() { }

	[Address(RVA = "0x1D17870", Offset = "0x1D16C70", Length = "0x76")]
	[Token(Token = "0x6001083")]
	public string GetRuinName() { }

	[Address(RVA = "0x1D178F0", Offset = "0x1D16CF0", Length = "0x8C")]
	[Token(Token = "0x6001084")]
	public static string GetRuinName(string tstr) { }

	[Address(RVA = "0x1D17980", Offset = "0x1D16D80", Length = "0x48")]
	[Token(Token = "0x600107B")]
	public virtual void GetStart() { }

	[Address(RVA = "0x1D179D0", Offset = "0x1D16DD0", Length = "0x144")]
	[Token(Token = "0x6001079")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D17B20", Offset = "0x1D16F20", Length = "0x173")]
	[Token(Token = "0x6001081")]
	private bool IsGroundGamePlayArea() { }

	[Address(RVA = "0x1D17CA0", Offset = "0x1D170A0", Length = "0x13")]
	[Token(Token = "0x6001082")]
	public virtual bool IsPlayingState() { }

	[Address(RVA = "0x1D17CC0", Offset = "0x1D170C0", Length = "0x8")]
	[Token(Token = "0x600107D")]
	public virtual bool IsPoseRecord() { }

	[Address(RVA = "0x1D17CD0", Offset = "0x1D170D0", Length = "0x2E7")]
	[Token(Token = "0x6001080")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1D17FC0", Offset = "0x1D173C0", Length = "0xF")]
	[Token(Token = "0x600107A")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D17FD0", Offset = "0x1D173D0", Length = "0x7")]
	[Token(Token = "0x600107C")]
	public virtual void SetDropItem(Kind ditem) { }

}

