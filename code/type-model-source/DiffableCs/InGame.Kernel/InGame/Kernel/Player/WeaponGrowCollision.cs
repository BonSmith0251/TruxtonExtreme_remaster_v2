namespace InGame.Kernel.Player;

[Token(Token = "0x200012F")]
public class WeaponGrowCollision : WeaponNormalCollision
{
	[Token(Token = "0x4000875")]
	private static readonly float NormalSpeed; //Field offset: 0x0
	[Token(Token = "0x4000876")]
	private static readonly float GrowStartTime; //Field offset: 0x4
	[Token(Token = "0x4000877")]
	private static readonly float StopDistance; //Field offset: 0x8
	[Token(Token = "0x4000878")]
	private static readonly float StopDistanceEx; //Field offset: 0xC
	[Token(Token = "0x4000879")]
	private static readonly float GrowTime; //Field offset: 0x10
	[Token(Token = "0x400087A")]
	private static readonly float StayTime; //Field offset: 0x14
	[Token(Token = "0x400087B")]
	private static readonly float DegrowSpeed; //Field offset: 0x18
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x400087C")]
	[Tooltip("到達時のスケール")]
	private Vector3 _growScale; //Field offset: 0x110
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x400087D")]
	private Vector3 _currentScale; //Field offset: 0x11C
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400087E")]
	private float _speed; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x400087F")]
	private float _currentStep; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000880")]
	private float _growingTime; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x4000881")]
	private float _stayTime; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000882")]
	private Action _keepPoolAction; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000883")]
	private bool _isGrowing; //Field offset: 0x140
	[FieldOffset(Offset = "0x141")]
	[Token(Token = "0x4000884")]
	private bool _isMoving; //Field offset: 0x141
	[FieldOffset(Offset = "0x142")]
	[Token(Token = "0x4000885")]
	private bool _isFinish; //Field offset: 0x142
	[FieldOffset(Offset = "0x143")]
	[Token(Token = "0x4000886")]
	private bool _hitEffectCalled; //Field offset: 0x143

	[Address(RVA = "0x1D5AC00", Offset = "0x1D5A000", Length = "0x92")]
	[Token(Token = "0x600096C")]
	private void _localPoolAction() { }

	[Address(RVA = "0x1D5AAA0", Offset = "0x1D59EA0", Length = "0xC9")]
	[Token(Token = "0x6000974")]
	private static WeaponGrowCollision() { }

	[Address(RVA = "0x1D5AB70", Offset = "0x1D59F70", Length = "0x89")]
	[Token(Token = "0x6000973")]
	public WeaponGrowCollision() { }

	[Address(RVA = "0x1D59F50", Offset = "0x1D59350", Length = "0x12")]
	[Token(Token = "0x6000969")]
	public virtual bool AddDamageOwner(float n) { }

	[Address(RVA = "0x1D59F70", Offset = "0x1D59370", Length = "0x7")]
	[Token(Token = "0x6000968")]
	public virtual void AddDead() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000972")]
	protected virtual void CallHitEffect() { }

	[Address(RVA = "0x1D59F80", Offset = "0x1D59380", Length = "0x3E")]
	[Token(Token = "0x600096F")]
	private float GetGrowRange() { }

	[Address(RVA = "0x1D59FC0", Offset = "0x1D593C0", Length = "0x80")]
	[Token(Token = "0x600096E")]
	private float GetGrowRate() { }

	[Address(RVA = "0x1D5A040", Offset = "0x1D59440", Length = "0x89")]
	[Token(Token = "0x6000970")]
	private float GetStopDistance() { }

	[Address(RVA = "0x1D5A0D0", Offset = "0x1D594D0", Length = "0x3FD")]
	[Token(Token = "0x600096B")]
	private void GrothgAndDecay(float tdt) { }

	[Address(RVA = "0x1D5A4D0", Offset = "0x1D598D0", Length = "0x85")]
	[Token(Token = "0x600096A")]
	public virtual void ProgressMove(float tdt) { }

	[Address(RVA = "0x1D5A560", Offset = "0x1D59960", Length = "0x1CD")]
	[Token(Token = "0x6000967")]
	public virtual void StartMove(Vector3 s, Vector3 e, float tspeed, bool isLookAt, Action _poolAction) { }

	[Address(RVA = "0x1D5A730", Offset = "0x1D59B30", Length = "0x1FA")]
	[Token(Token = "0x6000971")]
	private void StartNapalm() { }

	[Address(RVA = "0x1D5A930", Offset = "0x1D59D30", Length = "0x168")]
	[Token(Token = "0x600096D")]
	private void SwapBowToCircle(bool isBow) { }

}

