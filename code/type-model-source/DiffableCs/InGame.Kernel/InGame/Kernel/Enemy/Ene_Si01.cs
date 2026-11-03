namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000205")]
public class Ene_Si01 : PawnEnemy
{
	[Token(Token = "0x4001227")]
	private static readonly float _ParentDistance; //Field offset: 0x0
	[Token(Token = "0x4001228")]
	private static readonly float _ParentApart; //Field offset: 0x4
	[Token(Token = "0x4001229")]
	private static readonly float _ParentBodySize; //Field offset: 0x8
	[Token(Token = "0x400122A")]
	private static readonly float _SwayTimeX; //Field offset: 0xC
	[Token(Token = "0x400122B")]
	private static readonly float _SwayTimeY; //Field offset: 0x10
	[Token(Token = "0x400122C")]
	private static readonly float _SwayAngleX; //Field offset: 0x14
	[Token(Token = "0x400122D")]
	private static readonly float _SwayAngleY; //Field offset: 0x18
	[Token(Token = "0x400122E")]
	private static readonly float _FollowRate; //Field offset: 0x1C
	[Token(Token = "0x400122F")]
	private static readonly float _BodySize; //Field offset: 0x20
	[Token(Token = "0x4001230")]
	private static readonly float _AccelerateSpeed; //Field offset: 0x24
	[Token(Token = "0x4001231")]
	private static readonly float _ShotInterval; //Field offset: 0x28
	[Token(Token = "0x4001232")]
	private static readonly string _BulletName; //Field offset: 0x30
	[Token(Token = "0x4001233")]
	private static readonly float _TargetTurnTime; //Field offset: 0x38
	[Token(Token = "0x4001234")]
	private static readonly float _DistanceLimit; //Field offset: 0x3C
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x4001235")]
	public Transform _Muzzle; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4001236")]
	private int _targetPlayer; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4001237")]
	private Ene_Mk01 _queenEnemy; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4001238")]
	private Vector3 _firstPosition; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x4001239")]
	private float _swayX; //Field offset: 0x1D4
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x400123A")]
	private float _swayY; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x400123B")]
	private Quaternion _follow; //Field offset: 0x1DC
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x400123C")]
	private Vector3 _accelerate; //Field offset: 0x1EC
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x400123D")]
	private float _shotTime; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x400123E")]
	private List<BulletTemplate> _bulletTemplates; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400123F")]
	private float _rotateTime; //Field offset: 0x208
	[FieldOffset(Offset = "0x20C")]
	[Token(Token = "0x4001240")]
	private float _rotateAngle; //Field offset: 0x20C

	[Address(RVA = "0x1D00370", Offset = "0x1CFF770", Length = "0x10BC")]
	[Token(Token = "0x6000F4C")]
	private void _stateExec(float deltaTime) { }

	[Address(RVA = "0x1D000E0", Offset = "0x1CFF4E0", Length = "0x178")]
	[Token(Token = "0x6000F4F")]
	private static Ene_Si01() { }

	[Address(RVA = "0x1D00260", Offset = "0x1CFF660", Length = "0x105")]
	[Token(Token = "0x6000F4E")]
	public Ene_Si01() { }

	[Address(RVA = "0x1CFF740", Offset = "0x1CFEB40", Length = "0xD9")]
	[Token(Token = "0x6000F4B")]
	public virtual List<String> GetBulletTemplates() { }

	[Address(RVA = "0x1CFF820", Offset = "0x1CFEC20", Length = "0x31")]
	[Token(Token = "0x6000F4A")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1CFFDD0", Offset = "0x1CFF1D0", Length = "0x268")]
	[Token(Token = "0x6000F4D")]
	public void Repulsion(Ene_Si01 target) { }

	[Address(RVA = "0x1CFF860", Offset = "0x1CFEC60", Length = "0x564")]
	[Token(Token = "0x6000F48")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D00040", Offset = "0x1CFF440", Length = "0x9E")]
	[Token(Token = "0x6000F49")]
	public void SetTargetAndParent(int pindex, int targetPlayer, Ene_Mk01 tqueen, bool immediate) { }

}

