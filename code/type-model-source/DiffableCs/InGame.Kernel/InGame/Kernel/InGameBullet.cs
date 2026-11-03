namespace InGame.Kernel;

[Token(Token = "0x200000C")]
public class InGameBullet : InGameCollisionBase, InGameBulletInterface, IPrefabBankObject
{
	[Token(Token = "0x400003B")]
	private static readonly float BulletDamage; //Field offset: 0x0
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400003C")]
	protected SimpleMove _simpleMove; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x400003D")]
	private Vector3 _hitEffectOffset; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	[Token(Token = "0x400003E")]
	private bool _isLookAtDirection; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB5")]
	[SerializeField]
	[Token(Token = "0x400003F")]
	private bool _isSimpleCalc; //Field offset: 0xB5
	[FieldOffset(Offset = "0xB6")]
	[Token(Token = "0x4000040")]
	private bool _isEntryedArea; //Field offset: 0xB6
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000041")]
	protected float _bornPassed; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000042")]
	private Action<Int32> _poolAction; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000043")]
	private int _poolIndex; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	[Token(Token = "0x4000044")]
	protected BulletKind _kindType; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x4000045")]
	protected BulletColorType _colorType; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x4000046")]
	protected MeshRenderer _bulletRender; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000047")]
	private attackType _causeOfDeath; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x4000048")]
	protected int _deathByPno; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000049")]
	private int _hitEffectCode; //Field offset: 0xE8

	[Token(Token = "0x17000017")]
	public MeshRenderer BulletRender
	{
		[Address(RVA = "0x1CCEEE0", Offset = "0x1CCE2E0", Length = "0x8")]
		[Token(Token = "0x6000083")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000018")]
	public attackType CauseOfDeath
	{
		[Address(RVA = "0x1CCEEF0", Offset = "0x1CCE2F0", Length = "0x7")]
		[Token(Token = "0x6000085")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000019")]
	public int DeathByPno
	{
		[Address(RVA = "0x8425F0", Offset = "0x8419F0", Length = "0x7")]
		[Token(Token = "0x6000086")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000015")]
	private bool IsBulletLayer
	{
		[Address(RVA = "0x1CCEF00", Offset = "0x1CCE300", Length = "0x17")]
		[Token(Token = "0x6000081")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000016")]
	public BulletKind KindType
	{
		[Address(RVA = "0x1CCEF20", Offset = "0x1CCE320", Length = "0x7")]
		[Token(Token = "0x6000082")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1CCEE60", Offset = "0x1CCE260", Length = "0x7F")]
	[Token(Token = "0x600007B")]
	protected virtual Vector3 _getCurrentPosition() { }

	[Address(RVA = "0x1CCEDA0", Offset = "0x1CCE1A0", Length = "0x39")]
	[Token(Token = "0x6000088")]
	private static InGameBullet() { }

	[Address(RVA = "0x1CCEDE0", Offset = "0x1CCE1E0", Length = "0x80")]
	[Token(Token = "0x6000087")]
	public InGameBullet() { }

	[Address(RVA = "0x1CCDF30", Offset = "0x1CCD330", Length = "0x1F8")]
	[Token(Token = "0x600006A")]
	public virtual bool AddDamageOwner(float n) { }

	[Address(RVA = "0x1CCE130", Offset = "0x1CCD530", Length = "0x47")]
	[Token(Token = "0x6000070")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1CCE180", Offset = "0x1CCD580", Length = "0x25")]
	[Token(Token = "0x6000078")]
	protected void CallPoolAction() { }

	[Address(RVA = "0x1CCE1B0", Offset = "0x1CCD5B0", Length = "0x7")]
	[Token(Token = "0x6000084")]
	public override BulletColorType ColorType() { }

	[Address(RVA = "0x1CCEEE0", Offset = "0x1CCE2E0", Length = "0x8")]
	[Token(Token = "0x6000083")]
	public MeshRenderer get_BulletRender() { }

	[Address(RVA = "0x1CCEEF0", Offset = "0x1CCE2F0", Length = "0x7")]
	[Token(Token = "0x6000085")]
	public attackType get_CauseOfDeath() { }

	[Address(RVA = "0x8425F0", Offset = "0x8419F0", Length = "0x7")]
	[Token(Token = "0x6000086")]
	public int get_DeathByPno() { }

	[Address(RVA = "0x1CCEF00", Offset = "0x1CCE300", Length = "0x17")]
	[Token(Token = "0x6000081")]
	private bool get_IsBulletLayer() { }

	[Address(RVA = "0x1CCEF20", Offset = "0x1CCE320", Length = "0x7")]
	[Token(Token = "0x6000082")]
	public BulletKind get_KindType() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000080")]
	public override GameObject GetObject() { }

	[Address(RVA = "0x1CCE1C0", Offset = "0x1CCD5C0", Length = "0x25D")]
	[Token(Token = "0x6000067")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1CC9FE0", Offset = "0x1CC93E0", Length = "0x7")]
	[Token(Token = "0x600007D")]
	public override bool IsEnableScript() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600007C")]
	public override bool IsLaser() { }

	[Address(RVA = "0x1CCE420", Offset = "0x1CCD820", Length = "0x8")]
	[Token(Token = "0x600007E")]
	protected virtual bool IsSimpleCalc() { }

	[Address(RVA = "0x1CCE430", Offset = "0x1CCD830", Length = "0x7")]
	[Token(Token = "0x6000089")]
	private override void KANAI.Kernel.IPrefabBankObject.SetupCache() { }

	[Address(RVA = "0x1CCE440", Offset = "0x1CCD840", Length = "0x14")]
	[Token(Token = "0x600006D")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1CCE460", Offset = "0x1CCD860", Length = "0x27A")]
	[Token(Token = "0x6000069")]
	protected virtual void OnHitProgress(CollisionOrder aData) { }

	[Address(RVA = "0x1CCE6E0", Offset = "0x1CCDAE0", Length = "0x87")]
	[Token(Token = "0x600006C")]
	public override void ProgressBullet(float dt) { }

	[Address(RVA = "0x1CCE7C0", Offset = "0x1CCDBC0", Length = "0x26")]
	[Token(Token = "0x600006F")]
	public override void RefreshRoot(Transform gmr) { }

	[Address(RVA = "0x1CCE7F0", Offset = "0x1CCDBF0", Length = "0x1B7")]
	[Token(Token = "0x600006B")]
	private void RequestHitEffect() { }

	[Address(RVA = "0x1CCE770", Offset = "0x1CCDB70", Length = "0x4E")]
	[Token(Token = "0x6000068")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1CCE9B0", Offset = "0x1CCDDB0", Length = "0xE4")]
	[Token(Token = "0x600007F")]
	public override void SetActiveBank(bool tactive) { }

	[Address(RVA = "0x1CCEAA0", Offset = "0x1CCDEA0", Length = "0x17")]
	[Token(Token = "0x6000071")]
	public override void SetCauseOfDeath(int playerNo, attackType atkType, bool isExboost) { }

	[Address(RVA = "0x1CCEAC0", Offset = "0x1CCDEC0", Length = "0x27")]
	[Token(Token = "0x6000074")]
	public override void SetCurveData(AnimationCurve _curve, float r, float range) { }

	[Address(RVA = "0x1CCEAF0", Offset = "0x1CCDEF0", Length = "0x21")]
	[Token(Token = "0x6000073")]
	public override void SetCurveType(float r, float range) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000075")]
	public override void SetEmitterInformation(InGameEnemyMoveBase _m, Transform temit, Transform tdir, int nFire, bool isSelf) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000076")]
	public override void SetIrradiationTime(float t) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000079")]
	public override void SetOffsetPosition(Vector3 pos) { }

	[Address(RVA = "0x1CCEB20", Offset = "0x1CCDF20", Length = "0x34")]
	[Token(Token = "0x6000077")]
	public override void SetPoolAction(Action<Int32> _pool, int pindex) { }

	[Address(RVA = "0x1CCEB60", Offset = "0x1CCDF60", Length = "0x8A")]
	[Token(Token = "0x600007A")]
	public override void SetRenderMaterial(Material bmat) { }

	[Address(RVA = "0x1CCEBF0", Offset = "0x1CCDFF0", Length = "0x185")]
	[Token(Token = "0x6000072")]
	public override void StartMove(Vector3 s, Vector3 nDir, float tspeed, MoveType moveType) { }

	[Address(RVA = "0x1CCED80", Offset = "0x1CCE180", Length = "0x14")]
	[Token(Token = "0x600006E")]
	public virtual void ToDestroid() { }

}

