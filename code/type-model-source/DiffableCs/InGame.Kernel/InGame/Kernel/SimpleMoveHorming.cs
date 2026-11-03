namespace InGame.Kernel;

[Token(Token = "0x20000AE")]
public class SimpleMoveHorming : SimpleMove
{
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x4000532")]
	private bool _isPlayerSide; //Field offset: 0xE8
	[FieldOffset(Offset = "0xEC")]
	[SerializeField]
	[Token(Token = "0x4000533")]
	private float _homingAngle; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000534")]
	private float _homingEndTime; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	[Token(Token = "0x4000535")]
	private float _homingStartTime; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000536")]
	protected InGameCollisionBase _targetCollision; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000537")]
	private float _homingAngleF; //Field offset: 0x100

	[Address(RVA = "0x1D41490", Offset = "0x1D40890", Length = "0x297")]
	[Token(Token = "0x6000653")]
	protected virtual void _updateMove(float dt) { }

	[Address(RVA = "0x1D40F30", Offset = "0x1D40330", Length = "0x40")]
	[Token(Token = "0x6000659")]
	public SimpleMoveHorming() { }

	[Address(RVA = "0x1D40FE0", Offset = "0x1D403E0", Length = "0x19")]
	[Token(Token = "0x6000657")]
	public override void CancelHorming() { }

	[Address(RVA = "0x1D41000", Offset = "0x1D40400", Length = "0x8B")]
	[Token(Token = "0x6000658")]
	private Vector3 GetTargetPosition() { }

	[Address(RVA = "0x1D41090", Offset = "0x1D40490", Length = "0x8A")]
	[Token(Token = "0x6000650")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D41120", Offset = "0x1D40520", Length = "0x90")]
	[Token(Token = "0x6000655")]
	public bool IsEnableTarget() { }

	[Address(RVA = "0x1D411C0", Offset = "0x1D405C0", Length = "0xBA")]
	[Token(Token = "0x6000654")]
	public virtual bool IsHorming() { }

	[Address(RVA = "0x1D41280", Offset = "0x1D40680", Length = "0x119")]
	[Token(Token = "0x6000652")]
	protected override void SetStartTarget() { }

	[Address(RVA = "0x1D413A0", Offset = "0x1D407A0", Length = "0x13")]
	[Token(Token = "0x6000656")]
	public void SetTargetCollision(InGameCollisionBase tcol) { }

	[Address(RVA = "0x1D413C0", Offset = "0x1D407C0", Length = "0xC3")]
	[Token(Token = "0x6000651")]
	public virtual void StartMove(Vector3 s, Vector3 ndir, float speedRate, bool isLookAt = false, MoveType mt = 0) { }

}

