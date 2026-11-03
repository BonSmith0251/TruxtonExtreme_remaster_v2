namespace InGame.Kernel.Player;

[Token(Token = "0x200012B")]
public abstract class WeaponCollisionBase : InGameCollisionBase, IPrefabBankObject
{
	[Token(Token = "0x200012C")]
	internal enum EffectCode : int
	{
		Hit10 = 0,
		Hit20 = 1,
		Hit30 = 2,
		Hit40 = 3,
		Hit50 = 4,
		Hit60 = 5,
		Hit70 = 6,
		None = 7,
	}

	[Token(Token = "0x4000865")]
	protected static readonly Int32[] EffectCodes; //Field offset: 0x0
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000860")]
	private attackType _attackType; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Range(0, 99999)]
	[SerializeField]
	[Token(Token = "0x4000861")]
	private float _FirstDamage; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Range(0, 99999)]
	[SerializeField]
	[Token(Token = "0x4000862")]
	private float _ContiniousDamage; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000863")]
	private bool _isExboost; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000864")]
	private int _indexNumber; //Field offset: 0xB0

	[Token(Token = "0x170001AF")]
	public attackType AttackType
	{
		[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
		[Token(Token = "0x6000953")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001B1")]
	public int IndexNumber
	{
		[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
		[Token(Token = "0x6000955")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001B0")]
	public bool IsExboost
	{
		[Address(RVA = "0x1D59150", Offset = "0x1D58550", Length = "0x8")]
		[Token(Token = "0x6000954")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1D58D60", Offset = "0x1D58160", Length = "0x3CE")]
	[Token(Token = "0x600094E")]
	private void _damageToEnemy(HybridCollisionModel model, float tdamage) { }

	[Address(RVA = "0x1D58B10", Offset = "0x1D57F10", Length = "0x217")]
	[Token(Token = "0x6000958")]
	private static WeaponCollisionBase() { }

	[Address(RVA = "0x1D58D30", Offset = "0x1D58130", Length = "0x25")]
	[Token(Token = "0x6000957")]
	protected WeaponCollisionBase() { }

	[Address(RVA = "0x1D589A0", Offset = "0x1D57DA0", Length = "0x9")]
	[Token(Token = "0x600094B")]
	protected override float ContiniousDamage() { }

	[Address(RVA = "0x1D589B0", Offset = "0x1D57DB0", Length = "0x9")]
	[Token(Token = "0x600094A")]
	protected override float FirstDamage() { }

	[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
	[Token(Token = "0x6000953")]
	public attackType get_AttackType() { }

	[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
	[Token(Token = "0x6000955")]
	public int get_IndexNumber() { }

	[Address(RVA = "0x1D59150", Offset = "0x1D58550", Length = "0x8")]
	[Token(Token = "0x6000954")]
	public bool get_IsExboost() { }

	[Address(RVA = "0x1D589C0", Offset = "0x1D57DC0", Length = "0x6D")]
	[Token(Token = "0x6000956")]
	public int GetEffectCode(EffectCode tcode) { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000952")]
	public override GameObject GetObject() { }

	[Address(RVA = "0x1D58A30", Offset = "0x1D57E30", Length = "0x17")]
	[Token(Token = "0x6000949")]
	public bool IsPlayerBulletType() { }

	[Address(RVA = "0x1CCE430", Offset = "0x1CCD830", Length = "0x7")]
	[Token(Token = "0x6000959")]
	private override void KANAI.Kernel.IPrefabBankObject.SetupCache() { }

	[Address(RVA = "0x1D58A50", Offset = "0x1D57E50", Length = "0x4C")]
	[Token(Token = "0x600094C")]
	protected virtual void OnHitProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x1D58AA0", Offset = "0x1D57EA0", Length = "0x4C")]
	[Token(Token = "0x600094D")]
	protected virtual void OnStayProgress(CollisionOrder aData) { }

	[Address(RVA = "0x1D0F630", Offset = "0x1D0EA30", Length = "0x1E")]
	[Token(Token = "0x6000951")]
	public override void SetActiveBank(bool tactive) { }

	[Address(RVA = "0x1D58AF0", Offset = "0x1D57EF0", Length = "0x7")]
	[Token(Token = "0x6000948")]
	public override void SetExBoost(bool v) { }

	[Address(RVA = "0x1D58B00", Offset = "0x1D57F00", Length = "0x7")]
	[Token(Token = "0x600094F")]
	public void SetIndexNumber(int n) { }

	[Address(RVA = "0x1CCED80", Offset = "0x1CCE180", Length = "0x14")]
	[Token(Token = "0x6000950")]
	public virtual void ToDestroid() { }

}

