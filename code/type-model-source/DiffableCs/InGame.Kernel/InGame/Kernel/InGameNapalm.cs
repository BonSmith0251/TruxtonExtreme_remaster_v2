namespace InGame.Kernel;

[Token(Token = "0x200006D")]
public class InGameNapalm : InGameBullet, InGameBulletInterface
{
	[Token(Token = "0x4000384")]
	private static readonly float SparkDistance; //Field offset: 0x0
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000385")]
	private bool _isSparkStart; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF1")]
	[Token(Token = "0x4000386")]
	private bool _isSparkEnd; //Field offset: 0xF1
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4000387")]
	private float _hitTime; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x4000388")]
	private float _hitTimeMax; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[SerializeField]
	[Token(Token = "0x4000389")]
	private float _hitScaleS; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x400038A")]
	private float _hitScaleE; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x400038B")]
	private ParticleSystem _bulletEffect; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x400038C")]
	private ParticleSystem _hitEffect; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x400038D")]
	private ID _hitSoundID; //Field offset: 0x118

	[Address(RVA = "0x1D1BD30", Offset = "0x1D1B130", Length = "0x39")]
	[Token(Token = "0x6000480")]
	private static InGameNapalm() { }

	[Address(RVA = "0x1D1BD70", Offset = "0x1D1B170", Length = "0x71")]
	[Token(Token = "0x600047F")]
	public InGameNapalm() { }

	[Address(RVA = "0x1D1B5F0", Offset = "0x1D1A9F0", Length = "0x6A")]
	[Token(Token = "0x600047A")]
	public virtual bool AddDamageOwner(float n) { }

	[Address(RVA = "0x1D1B660", Offset = "0x1D1AA60", Length = "0x65")]
	[Token(Token = "0x600047B")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1D1B6D0", Offset = "0x1D1AAD0", Length = "0x5B")]
	[Token(Token = "0x600047E")]
	private void EndNapalm() { }

	[Address(RVA = "0x1D1B730", Offset = "0x1D1AB30", Length = "0x126")]
	[Token(Token = "0x6000478")]
	protected virtual void OnHitProgress(CollisionOrder aData) { }

	[Address(RVA = "0x1D1B860", Offset = "0x1D1AC60", Length = "0x296")]
	[Token(Token = "0x6000479")]
	public virtual void ProgressBullet(float dt) { }

	[Address(RVA = "0x1D1BB00", Offset = "0x1D1AF00", Length = "0x25")]
	[Token(Token = "0x6000477")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1D1BB30", Offset = "0x1D1AF30", Length = "0x152")]
	[Token(Token = "0x600047C")]
	public virtual void StartMove(Vector3 spos, Vector3 nDir, float tspeed, MoveType moveType) { }

	[Address(RVA = "0x1D1BC90", Offset = "0x1D1B090", Length = "0x94")]
	[Token(Token = "0x600047D")]
	private void StartSpark() { }

}

