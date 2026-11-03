namespace InGame.Kernel.Enemy;

[RequireComponent(typeof(Rigidbody))]
[Token(Token = "0x200022D")]
public class PhysicsMove : MonoBehaviour, IEnemyUpdater, IPhysicsUpdater
{
	[Token(Token = "0x400137A")]
	private static readonly float _RotateScale; //Field offset: 0x0
	[Token(Token = "0x400137B")]
	public static readonly string MeteoTag; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400136E")]
	private Transform _parent; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400136F")]
	private PawnEnemy _enemy; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001370")]
	private EnemyMover _mover; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001371")]
	private Rigidbody _rigidbody; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001372")]
	private float _prate; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4001373")]
	private Quaternion _rotNow; //Field offset: 0x44
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001374")]
	private Quaternion _rotOld; //Field offset: 0x54
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001375")]
	protected Transform _transformCache; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001376")]
	protected Transform _modelTop; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001377")]
	private Vector3 _angularVelocity; //Field offset: 0x78
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4001378")]
	private Vector3 _rotateVector; //Field offset: 0x84
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001379")]
	private bool _isMovestepEnd; //Field offset: 0x90

	[Address(RVA = "0x1D19B00", Offset = "0x1D18F00", Length = "0x1BE")]
	[Token(Token = "0x60010A8")]
	private void _initializeRigid() { }

	[Address(RVA = "0x1D199E0", Offset = "0x1D18DE0", Length = "0x7B")]
	[Token(Token = "0x60010AC")]
	private static PhysicsMove() { }

	[Address(RVA = "0x1D19A60", Offset = "0x1D18E60", Length = "0x94")]
	[Token(Token = "0x60010AB")]
	public PhysicsMove() { }

	[Address(RVA = "0x1D18EE0", Offset = "0x1D182E0", Length = "0x82")]
	[Token(Token = "0x60010A1")]
	public override void ApplyTransformFromPhysics() { }

	[Address(RVA = "0x1D18F70", Offset = "0x1D18370", Length = "0x145")]
	[Token(Token = "0x60010A9")]
	private void MoveStepEnd() { }

	[Address(RVA = "0x1D190C0", Offset = "0x1D184C0", Length = "0x7")]
	[Token(Token = "0x60010A7")]
	private void OnDestroy() { }

	[Address(RVA = "0x1D19790", Offset = "0x1D18B90", Length = "0x148")]
	[Token(Token = "0x60010A0")]
	public override void Progress(float dt) { }

	[Address(RVA = "0x1D190C0", Offset = "0x1D184C0", Length = "0x7")]
	[Token(Token = "0x60010A4")]
	public override void ProgressDisable() { }

	[Address(RVA = "0x1D190C0", Offset = "0x1D184C0", Length = "0x7")]
	[Token(Token = "0x60010A3")]
	public override void ProgressEnd() { }

	[Address(RVA = "0x1D190D0", Offset = "0x1D184D0", Length = "0x1C4")]
	[Token(Token = "0x600109D")]
	public override void ProgressInitialize() { }

	[Address(RVA = "0x1CFEBB0", Offset = "0x1CFDFB0", Length = "0x6")]
	[Token(Token = "0x60010A5")]
	public override int ProgressPriority() { }

	[Address(RVA = "0x1D192A0", Offset = "0x1D186A0", Length = "0x78")]
	[Token(Token = "0x600109E")]
	public override void ProgressReset() { }

	[Address(RVA = "0x1D19320", Offset = "0x1D18720", Length = "0x438")]
	[Token(Token = "0x600109F")]
	public override void ProgressStart() { }

	[Address(RVA = "0x1D19760", Offset = "0x1D18B60", Length = "0x2B")]
	[Token(Token = "0x60010A2")]
	public override void ProgressTerminate() { }

	[Address(RVA = "0x1D198E0", Offset = "0x1D18CE0", Length = "0x11")]
	[Token(Token = "0x60010A6")]
	public void SetSuside() { }

	[Address(RVA = "0x1D19900", Offset = "0x1D18D00", Length = "0xDD")]
	[Token(Token = "0x60010AA")]
	private void SleepRigidBody() { }

}

