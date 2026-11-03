namespace KANAI.HybridCollision;

[Token(Token = "0x200000D")]
public abstract class HybridCollisionModelBase : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400004F")]
	private bool _isSelfTransform; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000050")]
	protected GameObject _object2d; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000051")]
	protected HybridCollisionBridge _bridge; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000052")]
	protected Transform _transformCache; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000053")]
	private bool _isInBetweenArea; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000054")]
	private bool _isFinished; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000055")]
	protected bool _isGroundStay; //Field offset: 0x42
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000056")]
	protected HybridCollisions _rootOwner; //Field offset: 0x48

	[Token(Token = "0x17000017")]
	public HybridCollisionBridge Bridge
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600009D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001A")]
	protected bool IsFinished
	{
		[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
		[Token(Token = "0x60000A0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001B")]
	public bool IsGroundStay
	{
		[Address(RVA = "0x1DDDDC0", Offset = "0x1DDD1C0", Length = "0x5")]
		[Token(Token = "0x60000A1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000019")]
	public bool IsInBetweenArea
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x600009F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000016")]
	public bool IsSelfTransform
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x600009C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001C")]
	public HybridCollisions RootOwner
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60000A2")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000018")]
	public override Transform TransformCache
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600009E")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000082")]
	private void _modeChange() { }

	[Address(RVA = "0x1DDDC10", Offset = "0x1DDD010", Length = "0xE8")]
	[Token(Token = "0x6000092")]
	protected void _updateCapsule(Vector2 _size) { }

	[Address(RVA = "0x1DDDD00", Offset = "0x1DDD100", Length = "0xA3")]
	[Token(Token = "0x6000091")]
	protected void _updatePolygon(Vector2[] _pos) { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60000A3")]
	protected HybridCollisionModelBase() { }

	[Address(RVA = "0x1DDD1E0", Offset = "0x1DDC5E0", Length = "0x148")]
	[Token(Token = "0x600008D")]
	public GameObject CreateBox(Transform root, Vector2 size, Shape stype) { }

	[Address(RVA = "0x1DDD330", Offset = "0x1DDC730", Length = "0x16F")]
	[Token(Token = "0x6000090")]
	public GameObject CreateCapsule(Transform root, Vector2 _size) { }

	[Address(RVA = "0x1DDD4A0", Offset = "0x1DDC8A0", Length = "0x108")]
	[Token(Token = "0x600008C")]
	public GameObject CreateCircle(Transform root, float r, Shape stype) { }

	[Address(RVA = "0x1DDD5B0", Offset = "0x1DDC9B0", Length = "0xCC")]
	[Token(Token = "0x600008F")]
	public GameObject CreateEdge(Transform root, Vector2[] _pos) { }

	[Address(RVA = "0x1DDD680", Offset = "0x1DDCA80", Length = "0xCC")]
	[Token(Token = "0x600008E")]
	public GameObject CreatePolygon(Transform root, Vector2[] _pos) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000093")]
	public override void DebugDisplaySetup() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600007E")]
	public override void DeleteObject() { }

	[Token(Token = "0x6000099")]
	public abstract void EntryHitLists(Collider2D other) { }

	[Token(Token = "0x600009B")]
	public abstract void EntryLeaveLists(Collider2D other) { }

	[Token(Token = "0x600009A")]
	public abstract void EntryStayLists(Collider2D other) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600009D")]
	public HybridCollisionBridge get_Bridge() { }

	[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
	[Token(Token = "0x60000A0")]
	protected bool get_IsFinished() { }

	[Address(RVA = "0x1DDDDC0", Offset = "0x1DDD1C0", Length = "0x5")]
	[Token(Token = "0x60000A1")]
	public bool get_IsGroundStay() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x600009F")]
	public bool get_IsInBetweenArea() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x600009C")]
	public bool get_IsSelfTransform() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60000A2")]
	public HybridCollisions get_RootOwner() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600009E")]
	public override Transform get_TransformCache() { }

	[Address(RVA = "0x1DDD750", Offset = "0x1DDCB50", Length = "0x66")]
	[Token(Token = "0x6000089")]
	public Bounds GetBridgeBounds() { }

	[Address(RVA = "0x1DDD7C0", Offset = "0x1DDCBC0", Length = "0x3B")]
	[Token(Token = "0x6000097")]
	public Vector3 GetCollisionPosition() { }

	[Address(RVA = "0x1DDD7C0", Offset = "0x1DDCBC0", Length = "0x3B")]
	[Token(Token = "0x6000098")]
	public override Vector3 GetHitPosition() { }

	[Address(RVA = "0x1DDD800", Offset = "0x1DDCC00", Length = "0xF")]
	[Token(Token = "0x6000096")]
	public override Color GetLineColor() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x600008B")]
	public override string GetName() { }

	[Address(RVA = "0x1DDD810", Offset = "0x1DDCC10", Length = "0xDF")]
	[Token(Token = "0x6000084")]
	public void LateUpdateOnlyPosition(Vector3 pos) { }

	[Address(RVA = "0x1DDD8F0", Offset = "0x1DDCCF0", Length = "0x11D")]
	[Token(Token = "0x6000083")]
	public override void LateUpdatePosition(Vector3 pos, Quaternion _rotateZ, float lscale) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000086")]
	public void LateUpdatePositionDebug(Vector3 pos, Quaternion _rotateZ, Vector3 baseScale) { }

	[Address(RVA = "0x1DDDA10", Offset = "0x1DDCE10", Length = "0x28")]
	[Token(Token = "0x6000081")]
	public override void OwnerFinish() { }

	[Address(RVA = "0x1DDDA40", Offset = "0x1DDCE40", Length = "0x45")]
	[Token(Token = "0x600007F")]
	public override void OwnerStart() { }

	[Address(RVA = "0x1DDDA90", Offset = "0x1DDCE90", Length = "0x1E")]
	[Token(Token = "0x6000085")]
	public void SetCollisionScale(float tscale) { }

	[Address(RVA = "0x1DDDAB0", Offset = "0x1DDCEB0", Length = "0x4")]
	[Token(Token = "0x6000080")]
	public void SetFinishFlag(bool tvalue) { }

	[Address(RVA = "0x1DDDAC0", Offset = "0x1DDCEC0", Length = "0x4")]
	[Token(Token = "0x600008A")]
	public void SetGround(bool v) { }

	[Address(RVA = "0x1DDDAD0", Offset = "0x1DDCED0", Length = "0x62")]
	[Token(Token = "0x6000087")]
	public override void SetInArea(bool isInArea) { }

	[Address(RVA = "0x1DDDB40", Offset = "0x1DDCF40", Length = "0x61")]
	[Token(Token = "0x6000094")]
	public void SetLayer(int nLayer) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6000095")]
	public override void SetRootOwner(HybridCollisions _root) { }

	[Address(RVA = "0x1DDDBB0", Offset = "0x1DDCFB0", Length = "0x51")]
	[Token(Token = "0x6000088")]
	public void ToOutSide() { }

}

