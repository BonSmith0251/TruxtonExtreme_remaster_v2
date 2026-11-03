namespace InGame.Kernel.Enemy;

[Token(Token = "0x20001A7")]
public class Ene_Bos05_Arm : PawnEnemy
{
	[Token(Token = "0x20001A8")]
	private enum Mode : int
	{
		Grow = 0,
		Fire = 1,
		Turn = 2,
		Move = 3,
	}

	[Token(Token = "0x4000D84")]
	public static readonly float _GrowTime; //Field offset: 0x0
	[Token(Token = "0x4000D8D")]
	private const float UpPosY = 50; //Field offset: 0x0
	[Token(Token = "0x4000D8E")]
	private const float UpTime = 3; //Field offset: 0x0
	[Token(Token = "0x4000D85")]
	private static readonly float _TwistSpeed; //Field offset: 0x4
	[Token(Token = "0x4000D86")]
	private static readonly float _AcceleTime; //Field offset: 0x8
	[Token(Token = "0x4000D87")]
	private static readonly float _StartMoveTime; //Field offset: 0xC
	[Token(Token = "0x4000D88")]
	private static readonly float _TurnBaseSpeed; //Field offset: 0x10
	[Token(Token = "0x4000D89")]
	private static readonly float _TurnAngleSpeedInner; //Field offset: 0x14
	[Token(Token = "0x4000D8A")]
	private static readonly float _TurnAngleSpeedOuter; //Field offset: 0x18
	[Token(Token = "0x4000D8B")]
	public static readonly Vector3 _minGrowScale; //Field offset: 0x1C
	[Token(Token = "0x4000D8C")]
	public static readonly Vector3 _maxGrowScale; //Field offset: 0x28
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000D8F")]
	private float _upTimer; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x4000D90")]
	private EnemyCollisionModel _collision; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x4000D91")]
	private Transform _scaleNode; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000D92")]
	private Ene_Bos05 _parent; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000D93")]
	private Transform _root; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000D94")]
	private Vector3 _parentOffset; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x4000D95")]
	private float _targetSpeed; //Field offset: 0x1E4
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000D96")]
	private float _speed; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4000D97")]
	private float _twist; //Field offset: 0x1EC
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000D98")]
	private Vector3 _bornPosition; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1FC")]
	[Token(Token = "0x4000D99")]
	private Vector3 _launchPosition; //Field offset: 0x1FC
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000D9A")]
	private Quaternion _baseRotation; //Field offset: 0x208
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D9B")]
	private Mode _mode; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[Token(Token = "0x4000D9C")]
	private float _timer; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D9D")]
	private Vector3 _direction; //Field offset: 0x220
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000D9E")]
	private float _turnAngle; //Field offset: 0x22C
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000D9F")]
	private bool _turnClockwise; //Field offset: 0x230
	[FieldOffset(Offset = "0x231")]
	[Token(Token = "0x4000DA0")]
	private bool _turnInner; //Field offset: 0x231
	[FieldOffset(Offset = "0x232")]
	[Token(Token = "0x4000DA1")]
	private bool _leftArm; //Field offset: 0x232
	[FieldOffset(Offset = "0x233")]
	[Token(Token = "0x4000DA2")]
	private bool _sePlayed; //Field offset: 0x233

	[Address(RVA = "0x1D94180", Offset = "0x1D93580", Length = "0x4BB")]
	[Token(Token = "0x6000CF2")]
	private void _UpdateTransform(float deltaTime) { }

	[Address(RVA = "0x1D94640", Offset = "0x1D93A40", Length = "0x12B")]
	[Token(Token = "0x6000CF1")]
	private void _UpdateTurn(float deltaTime) { }

	[Address(RVA = "0x1D94770", Offset = "0x1D93B70", Length = "0x127")]
	[Token(Token = "0x6000CF4")]
	private static Ene_Bos05_Arm() { }

	[Address(RVA = "0x1D948A0", Offset = "0x1D93CA0", Length = "0x18D")]
	[Token(Token = "0x6000CF3")]
	public Ene_Bos05_Arm() { }

	[Address(RVA = "0x1D92FF0", Offset = "0x1D923F0", Length = "0x8C4")]
	[Token(Token = "0x6000CEF")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1D938C0", Offset = "0x1D92CC0", Length = "0x53")]
	[Token(Token = "0x6000CED")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D93920", Offset = "0x1D92D20", Length = "0x762")]
	[Token(Token = "0x6000CEE")]
	public void Setup(Ene_Bos05 parent, Transform root, Vector3 born, Vector3 launch, Quaternion rotation, Vector3 scale, bool isInner, bool isLeft) { }

	[Address(RVA = "0x1D94090", Offset = "0x1D93490", Length = "0xE1")]
	[Token(Token = "0x6000CF0")]
	public virtual void ToDestroid() { }

}

