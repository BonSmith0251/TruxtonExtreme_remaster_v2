namespace InGame.Kernel.Enemy;

[Token(Token = "0x200016A")]
public class EnemyMoverSnake : EnemyMover
{
	[FieldOffset(Offset = "0x2C0")]
	[SerializeField]
	[Token(Token = "0x4000A70")]
	private Transform _head; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[SerializeField]
	[Token(Token = "0x4000A71")]
	private Transform[] _bones; //Field offset: 0x2C8
	[FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	[Token(Token = "0x4000A72")]
	private float _headDistance; //Field offset: 0x2D0
	[FieldOffset(Offset = "0x2D4")]
	[SerializeField]
	[Token(Token = "0x4000A73")]
	private float _boneDistance; //Field offset: 0x2D4
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000A74")]
	private readonly List<Vector3> _boneDirections; //Field offset: 0x2D8
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x4000A75")]
	private float _headRate; //Field offset: 0x2E0
	[FieldOffset(Offset = "0x2E4")]
	[Token(Token = "0x4000A76")]
	private float _boneRate; //Field offset: 0x2E4

	[Address(RVA = "0x1D6B310", Offset = "0x1D6A710", Length = "0x14F")]
	[Token(Token = "0x6000B4B")]
	private void _initializeBoneCaches() { }

	[Address(RVA = "0x1D6B460", Offset = "0x1D6A860", Length = "0xC46")]
	[Token(Token = "0x6000B4A")]
	private void _updateBones() { }

	[Address(RVA = "0x1D6B290", Offset = "0x1D6A690", Length = "0x7D")]
	[Token(Token = "0x6000B4C")]
	public EnemyMoverSnake() { }

	[Address(RVA = "0x1D6B1C0", Offset = "0x1D6A5C0", Length = "0x29")]
	[Token(Token = "0x6000B48")]
	public virtual void Clear() { }

	[Address(RVA = "0x1D6B210", Offset = "0x1D6A610", Length = "0x20")]
	[Token(Token = "0x6000B49")]
	public virtual void Progress(float dt) { }

	[Address(RVA = "0x1D6B1F0", Offset = "0x1D6A5F0", Length = "0x1F")]
	[Token(Token = "0x6000B46")]
	public virtual void ProgressInitialize() { }

	[Address(RVA = "0x1D6B230", Offset = "0x1D6A630", Length = "0x52")]
	[Token(Token = "0x6000B47")]
	public virtual void SetSpline(Spline spline, float length, string routeName) { }

}

