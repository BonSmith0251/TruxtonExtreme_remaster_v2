namespace KANAI.HybridCollision;

[Token(Token = "0x200000E")]
public abstract class HybridCollisions : MonoBehaviour
{
	[Token(Token = "0x4000057")]
	private static readonly Vector3 _vectorOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000058")]
	private HybridCollisionModel[] _collisions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Range(0, 99999)]
	[SerializeField]
	[Token(Token = "0x4000059")]
	protected float _HitPoint; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400005A")]
	[Tooltip("DB:ロックオンされる？")]
	protected bool _isLockonTarget; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2D")]
	[SerializeField]
	[Token(Token = "0x400005B")]
	[Tooltip("DB:レーザー貫通？")]
	protected bool _isLaserBlock; //Field offset: 0x2D
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400005C")]
	protected float _Damage; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400005D")]
	private bool _isInitialized; //Field offset: 0x34
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x400005E")]
	private bool _isPlaying; //Field offset: 0x35
	[FieldOffset(Offset = "0x36")]
	[Token(Token = "0x400005F")]
	private bool _isGround; //Field offset: 0x36
	[FieldOffset(Offset = "0x37")]
	[Token(Token = "0x4000060")]
	private bool _isUseLocal; //Field offset: 0x37
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000061")]
	private Action onDisableEvent; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000062")]
	protected List<CollisionOrder> _hitOrders; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000063")]
	protected int _hitIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000064")]
	private int _collisionsCount; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000065")]
	protected Transform _transformCache; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000066")]
	private GameObject _gameObjectCache; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000067")]
	protected Vector3 _currentPosition; //Field offset: 0x60
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000068")]
	protected Vector3 _beforePosition; //Field offset: 0x6C
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000069")]
	protected Vector3 _basePosition; //Field offset: 0x78
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x400006A")]
	protected float _collisionScale; //Field offset: 0x84

	[Token(Token = "0x17000023")]
	public int CollisionsCount
	{
		[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
		[Token(Token = "0x60000DF")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000025")]
	public Vector3 CurrentPosition
	{
		[Address(RVA = "0x1CC6A40", Offset = "0x1CC5E40", Length = "0x13")]
		[Token(Token = "0x60000E1")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000026")]
	public Vector3 DifferenceVector
	{
		[Address(RVA = "0x1DE14A0", Offset = "0x1DE08A0", Length = "0x40")]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000024")]
	protected GameObject GameObjectCache
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001D")]
	public float HitPoint
	{
		[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
		[Token(Token = "0x60000D7")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700001F")]
	public float HitPointRate
	{
		[Address(RVA = "0x1DE14E0", Offset = "0x1DE08E0", Length = "0x2C")]
		[Token(Token = "0x60000D9")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000020")]
	protected bool IsInitialized
	{
		[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
		[Token(Token = "0x60000DA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000021")]
	public override bool IsPrgoressMove
	{
		[Address(RVA = "0x1DDF8B0", Offset = "0x1DDECB0", Length = "0x2A")]
		[Token(Token = "0x60000DC")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000022")]
	protected bool IsUseLocal
	{
		[Address(RVA = "0x1DE1510", Offset = "0x1DE0910", Length = "0x5")]
		[Token(Token = "0x60000DE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001E")]
	public float RemainHitPoint
	{
		[Address(RVA = "0x1DE1520", Offset = "0x1DE0920", Length = "0xB")]
		[Token(Token = "0x60000D8")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x1DE0F30", Offset = "0x1DE0330", Length = "0x7F")]
	[Token(Token = "0x60000B6")]
	protected override Vector3 _getCurrentPosition() { }

	[Address(RVA = "0x1DE0FB0", Offset = "0x1DE03B0", Length = "0x3F9")]
	[Token(Token = "0x60000CE")]
	private void _hitEntry(HybridCollisionBridge otherBridge, int ctype) { }

	[Address(RVA = "0x1DE13B0", Offset = "0x1DE07B0", Length = "0xE5")]
	[Token(Token = "0x60000CF")]
	private bool _isContainEntryHit(HybridCollisionBridge hit, int ctype) { }

	[Address(RVA = "0x1DE0E50", Offset = "0x1DE0250", Length = "0x4D")]
	[Token(Token = "0x60000E5")]
	private static HybridCollisions() { }

	[Address(RVA = "0x1DE0EA0", Offset = "0x1DE02A0", Length = "0x88")]
	[Token(Token = "0x60000E4")]
	protected HybridCollisions() { }

	[Address(RVA = "0x1DDF0D0", Offset = "0x1DDE4D0", Length = "0xBA")]
	[Token(Token = "0x60000BF")]
	public override bool AddDamageOwner(float n) { }

	[Address(RVA = "0x1BBE260", Offset = "0x1BBD660", Length = "0x4")]
	[Token(Token = "0x60000C0")]
	public override float AddDamageParts(float damage, int parts, int pno, bool isExboost) { }

	[Address(RVA = "0x1DDF190", Offset = "0x1DDE590", Length = "0x19")]
	[Token(Token = "0x60000C4")]
	public override void AddDead() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C2")]
	public override void AddEnergyOwner(float n) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C3")]
	public override void AddScoreOwner(float n) { }

	[Address(RVA = "0x1DDF1B0", Offset = "0x1DDE5B0", Length = "0x90")]
	[Token(Token = "0x60000C5")]
	public override void CallDisabled() { }

	[Address(RVA = "0x1DDF250", Offset = "0x1DDE650", Length = "0x61")]
	[Token(Token = "0x60000D2")]
	public void ClearHitOrders() { }

	[Address(RVA = "0x1DDF2C0", Offset = "0x1DDE6C0", Length = "0x70")]
	[Token(Token = "0x60000C6")]
	public void CollisionFinish() { }

	[Address(RVA = "0x1DDF340", Offset = "0x1DDE740", Length = "0x50")]
	[Token(Token = "0x60000CD")]
	public override void EntryOwnersHitList(HybridCollisionBridge other, int ctype) { }

	[Address(RVA = "0xFE29C0", Offset = "0xFE1DC0", Length = "0x4")]
	[Token(Token = "0x60000DF")]
	public int get_CollisionsCount() { }

	[Address(RVA = "0x1CC6A40", Offset = "0x1CC5E40", Length = "0x13")]
	[Token(Token = "0x60000E1")]
	public Vector3 get_CurrentPosition() { }

	[Address(RVA = "0x1DE14A0", Offset = "0x1DE08A0", Length = "0x40")]
	[Token(Token = "0x60000E3")]
	public Vector3 get_DifferenceVector() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60000E0")]
	protected GameObject get_GameObjectCache() { }

	[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
	[Token(Token = "0x60000D7")]
	public float get_HitPoint() { }

	[Address(RVA = "0x1DE14E0", Offset = "0x1DE08E0", Length = "0x2C")]
	[Token(Token = "0x60000D9")]
	public float get_HitPointRate() { }

	[Address(RVA = "0xD85B50", Offset = "0xD84F50", Length = "0x5")]
	[Token(Token = "0x60000DA")]
	protected bool get_IsInitialized() { }

	[Address(RVA = "0x1DDF8B0", Offset = "0x1DDECB0", Length = "0x2A")]
	[Token(Token = "0x60000DC")]
	public override bool get_IsPrgoressMove() { }

	[Address(RVA = "0x1DE1510", Offset = "0x1DE0910", Length = "0x5")]
	[Token(Token = "0x60000DE")]
	protected bool get_IsUseLocal() { }

	[Address(RVA = "0x1DE1520", Offset = "0x1DE0920", Length = "0xB")]
	[Token(Token = "0x60000D8")]
	public float get_RemainHitPoint() { }

	[Address(RVA = "0x1DDF390", Offset = "0x1DDE790", Length = "0x16")]
	[Token(Token = "0x60000E2")]
	public override Vector3 GetBasePosition() { }

	[Address(RVA = "0x1DDF3B0", Offset = "0x1DDE7B0", Length = "0x2B")]
	[Token(Token = "0x60000D6")]
	public HybridCollisionModel GetCModel(int tindex) { }

	[Address(RVA = "0x1DDF3E0", Offset = "0x1DDE7E0", Length = "0x8F")]
	[Token(Token = "0x60000CB")]
	public Vector3 GetCollisionPosition(int n) { }

	[Address(RVA = "0x1DDF470", Offset = "0x1DDE870", Length = "0x1D")]
	[Token(Token = "0x60000C8")]
	public int GetLayer() { }

	[Address(RVA = "0x1DDF490", Offset = "0x1DDE890", Length = "0x5")]
	[Token(Token = "0x60000AA")]
	public override void GetStart() { }

	[Address(RVA = "0x1DDF4A0", Offset = "0x1DDE8A0", Length = "0x157")]
	[Token(Token = "0x60000A5")]
	public override void Initialize() { }

	[Address(RVA = "0x1DDF600", Offset = "0x1DDEA00", Length = "0x1D")]
	[Token(Token = "0x60000DB")]
	public override bool IsActiveSelf() { }

	[Address(RVA = "0x1DDF640", Offset = "0x1DDEA40", Length = "0x16")]
	[Token(Token = "0x60000AB")]
	public override bool IsAlive() { }

	[Address(RVA = "0x1DDF620", Offset = "0x1DDEA20", Length = "0x11")]
	[Token(Token = "0x60000AC")]
	public override bool IsAliveDamaged(float tdamage) { }

	[Address(RVA = "0x1DDF660", Offset = "0x1DDEA60", Length = "0x14")]
	[Token(Token = "0x60000B2")]
	public override bool IsBomberRange() { }

	[Address(RVA = "0x1DDF680", Offset = "0x1DDEA80", Length = "0xDA")]
	[Token(Token = "0x60000D5")]
	public bool IsContain(Collider2D target) { }

	[Address(RVA = "0x1DE1530", Offset = "0x1DE0930", Length = "0x100")]
	[Token(Token = "0x60000D0")]
	private bool isContainOwner(HybridCollisionBridge hit) { }

	[Address(RVA = "0x1DDF760", Offset = "0x1DDEB60", Length = "0x5C")]
	[Token(Token = "0x60000B3")]
	public override bool IsGamePlayArea() { }

	[Address(RVA = "0x1DDF7C0", Offset = "0x1DDEBC0", Length = "0x5")]
	[Token(Token = "0x60000B4")]
	public override bool IsGround() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60000AE")]
	public override bool IsHitEnable() { }

	[Address(RVA = "0x1DDF7D0", Offset = "0x1DDEBD0", Length = "0x66")]
	[Token(Token = "0x60000B1")]
	public override bool IsLaserBlock() { }

	[Address(RVA = "0x1DDF840", Offset = "0x1DDEC40", Length = "0x66")]
	[Token(Token = "0x60000B0")]
	public override bool IsLockOnTarget() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60000AF")]
	public override bool IsNoDamaged() { }

	[Address(RVA = "0x1DDF8B0", Offset = "0x1DDECB0", Length = "0x2A")]
	[Token(Token = "0x60000DD")]
	public override bool IsPlayingState() { }

	[Address(RVA = "0x1DDF8E0", Offset = "0x1DDECE0", Length = "0xD")]
	[Token(Token = "0x60000AD")]
	public bool IsRemainHP() { }

	[Address(RVA = "0x1DDF8F0", Offset = "0x1DDECF0", Length = "0x1B")]
	[Token(Token = "0x60000A4")]
	private void OnDestroy() { }

	[Token(Token = "0x60000BB")]
	protected abstract void OnHitProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x1DDF910", Offset = "0x1DDED10", Length = "0x16A")]
	[Token(Token = "0x60000D1")]
	public override void OnHitThisFrameSolution(bool isFirst) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000BD")]
	protected override void OnLeaveProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000BE")]
	protected override void OnMultiProgress(CollisionOrder nOther, bool isFirst) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000C1")]
	public override void OnPartsBreak(int parts) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000BC")]
	protected override void OnStayProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x1DDFA80", Offset = "0x1DDEE80", Length = "0xAC")]
	[Token(Token = "0x60000B8")]
	public void OutsideAll() { }

	[Address(RVA = "0x1DDFC50", Offset = "0x1DDF050", Length = "0xAE")]
	[Token(Token = "0x60000B5")]
	public override HybridCollisionBridge RepresentBridge() { }

	[Address(RVA = "0xD842D0", Offset = "0xD836D0", Length = "0x8")]
	[Token(Token = "0x60000A8")]
	public void ResetDamage() { }

	[Address(RVA = "0x1DDFB30", Offset = "0x1DDEF30", Length = "0x111")]
	[Token(Token = "0x60000A9")]
	public override void ReStart(bool withPlay) { }

	[Address(RVA = "0x1DDFD00", Offset = "0x1DDF100", Length = "0xC8")]
	[Token(Token = "0x60000CA")]
	public void SetCollisionLayers(int n) { }

	[Address(RVA = "0x1DDFDD0", Offset = "0x1DDF1D0", Length = "0x9")]
	[Token(Token = "0x60000D4")]
	public void SetCollisionScale(float t) { }

	[Address(RVA = "0x1DDFDE0", Offset = "0x1DDF1E0", Length = "0x15")]
	[Token(Token = "0x60000D3")]
	public void SetDisableAction(Action act) { }

	[Address(RVA = "0x1DDFE00", Offset = "0x1DDF200", Length = "0x5A")]
	[Token(Token = "0x60000CC")]
	public void SetGroundStay(bool v, bool isLocal) { }

	[Address(RVA = "0x1DDFE60", Offset = "0x1DDF260", Length = "0xD9")]
	[Token(Token = "0x60000C9")]
	public void SetLayers(int n) { }

	[Address(RVA = "0x1DDFF40", Offset = "0x1DDF340", Length = "0x3F")]
	[Token(Token = "0x60000A6")]
	public void SetupCache() { }

	[Address(RVA = "0x1DDFF80", Offset = "0x1DDF380", Length = "0xA1")]
	[Token(Token = "0x60000A7")]
	public override void Terminate() { }

	[Token(Token = "0x60000C7")]
	public abstract void ToDestroid() { }

	[Address(RVA = "0x1DE0030", Offset = "0x1DDF430", Length = "0xA67")]
	[Token(Token = "0x60000B9")]
	public void UpdateCollisions() { }

	[Address(RVA = "0x1DE0AA0", Offset = "0x1DDFEA0", Length = "0x35B")]
	[Token(Token = "0x60000BA")]
	public void UpdateOneCollision() { }

	[Address(RVA = "0x1DE0E00", Offset = "0x1DE0200", Length = "0x49")]
	[Token(Token = "0x60000B7")]
	public void UpdatePosition() { }

}

