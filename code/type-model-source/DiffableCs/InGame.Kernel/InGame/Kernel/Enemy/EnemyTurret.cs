namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000171")]
public class EnemyTurret : MonoBehaviour, IEnemyUpdater
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000A87")]
	private Transform _axisTransform; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000A88")]
	private Transform[] _muzzles; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Range(1, 1000)]
	[SerializeField]
	[Token(Token = "0x4000A89")]
	[Tooltip("角度/N 秒で回転")]
	private float _RollSpeed; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000A8A")]
	[Tooltip("切り替え待機")]
	private float _delayWait; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Range(0, 360)]
	[SerializeField]
	[Token(Token = "0x4000A8B")]
	[Tooltip("角度の単位")]
	private float _RollAngle; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000A8C")]
	private float _MinAngle; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000A8D")]
	private float _MaxAngle; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x4000A8E")]
	private bool _isRotX; //Field offset: 0x44
	[FieldOffset(Offset = "0x45")]
	[SerializeField]
	[Token(Token = "0x4000A8F")]
	private bool _isRotY; //Field offset: 0x45
	[FieldOffset(Offset = "0x46")]
	[SerializeField]
	[Token(Token = "0x4000A90")]
	private bool _isRotZ; //Field offset: 0x46
	[FieldOffset(Offset = "0x47")]
	[SerializeField]
	[Token(Token = "0x4000A91")]
	private bool _isGround; //Field offset: 0x47
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000A92")]
	private bool _isParent; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[SerializeField]
	[Token(Token = "0x4000A93")]
	private bool _isRangeMove; //Field offset: 0x49
	[FieldOffset(Offset = "0x4A")]
	[Token(Token = "0x4000A94")]
	private bool _isNoTurn; //Field offset: 0x4A
	[FieldOffset(Offset = "0x4B")]
	[Token(Token = "0x4000A95")]
	private bool _isLocked; //Field offset: 0x4B
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A96")]
	private Transform _transformCache; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A97")]
	private Transform _parentCache; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A98")]
	private Quaternion _startQuaternion; //Field offset: 0x60
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A99")]
	private Quaternion _targetQuaternion; //Field offset: 0x70
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A9A")]
	private float _localSec; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000A9B")]
	private float _targetSec; //Field offset: 0x84

	[Token(Token = "0x170001D2")]
	public bool IsLocked
	{
		[Address(RVA = "0x1D6F040", Offset = "0x1D6E440", Length = "0x5")]
		[Token(Token = "0x6000B84")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001D0")]
	public float RollSpeed
	{
		[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
		[Token(Token = "0x6000B82")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001D1")]
	public Vector3 WorldPosition
	{
		[Address(RVA = "0x1D11D20", Offset = "0x1D11120", Length = "0x3B")]
		[Token(Token = "0x6000B83")]
		 get { } //Length: 59
	}

	[Address(RVA = "0x1D6EAC0", Offset = "0x1D6DEC0", Length = "0x9E")]
	[Token(Token = "0x6000B81")]
	private float _getAngle(float tangle) { }

	[Address(RVA = "0x1D6EB60", Offset = "0x1D6DF60", Length = "0x49")]
	[Token(Token = "0x6000B7D")]
	private void _resetTarget() { }

	[Address(RVA = "0x1D6EBB0", Offset = "0x1D6DFB0", Length = "0x44F")]
	[Token(Token = "0x6000B7F")]
	private bool _updateTarget() { }

	[Address(RVA = "0x1D6F000", Offset = "0x1D6E400", Length = "0x3E")]
	[Token(Token = "0x6000B7C")]
	private void _updateTransform(Quaternion trot) { }

	[Address(RVA = "0x1D6E870", Offset = "0x1D6DC70", Length = "0x104")]
	[Token(Token = "0x6000B7B")]
	private void _updateTransform(float dt) { }

	[Address(RVA = "0x1D6EA20", Offset = "0x1D6DE20", Length = "0x96")]
	[Token(Token = "0x6000B85")]
	public EnemyTurret() { }

	[Address(RVA = "0x1D6F040", Offset = "0x1D6E440", Length = "0x5")]
	[Token(Token = "0x6000B84")]
	public bool get_IsLocked() { }

	[Address(RVA = "0x1D33230", Offset = "0x1D32630", Length = "0x6")]
	[Token(Token = "0x6000B82")]
	public float get_RollSpeed() { }

	[Address(RVA = "0x1D11D20", Offset = "0x1D11120", Length = "0x3B")]
	[Token(Token = "0x6000B83")]
	public Vector3 get_WorldPosition() { }

	[Address(RVA = "0x1D6E640", Offset = "0x1D6DA40", Length = "0x9D")]
	[Token(Token = "0x6000B7E")]
	private Vector3 GetAxisPosition() { }

	[Address(RVA = "0x1D6E6E0", Offset = "0x1D6DAE0", Length = "0x5D")]
	[Token(Token = "0x6000B79")]
	public bool IsChildMuzzle(Transform tchild) { }

	[Address(RVA = "0x1D6E740", Offset = "0x1D6DB40", Length = "0x15")]
	[Token(Token = "0x6000B80")]
	private bool IsRangeOver(float tarc) { }

	[Address(RVA = "0x1D6E760", Offset = "0x1D6DB60", Length = "0x1E")]
	[Token(Token = "0x6000B76")]
	public bool IsTurning() { }

	[Address(RVA = "0x1D6E870", Offset = "0x1D6DC70", Length = "0x104")]
	[Token(Token = "0x6000B6F")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B74")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B73")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1D6E780", Offset = "0x1D6DB80", Length = "0x4A")]
	[Token(Token = "0x6000B6E")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1D3E090", Offset = "0x1D3D490", Length = "0x6")]
	[Token(Token = "0x6000B75")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x1D6E7D0", Offset = "0x1D6DBD0", Length = "0x9F")]
	[Token(Token = "0x6000B70")]
	public override void ProgressReset() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B72")]
	public override void ProgressStart() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B71")]
	public override void ProgressTerminate() { }

	[Address(RVA = "0x1D6E980", Offset = "0x1D6DD80", Length = "0x4")]
	[Token(Token = "0x6000B78")]
	public void SetLocked(bool tflag) { }

	[Address(RVA = "0x1D6E990", Offset = "0x1D6DD90", Length = "0x4")]
	[Token(Token = "0x6000B77")]
	public void SetNoTrun(bool tflag) { }

	[Address(RVA = "0x1D6E9A0", Offset = "0x1D6DDA0", Length = "0x70")]
	[Token(Token = "0x6000B7A")]
	public void SetRollSpeed(float _rollSpeed) { }

}

