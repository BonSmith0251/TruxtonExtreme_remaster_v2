namespace InGame.Kernel;

[Token(Token = "0x2000028")]
public class InGameEnemyBomber : InGameBullet, InGameBulletInterface
{
	[Token(Token = "0x4000110")]
	private static readonly float _EffectSize; //Field offset: 0x0
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000111")]
	private float _hitTime; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000112")]
	private ParticleSystem _hitEffect; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x4000113")]
	private float _hitTimeMax; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[SerializeField]
	[Token(Token = "0x4000114")]
	private float _hitScaleS; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x4000115")]
	private float _hitScaleE; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x4000116")]
	private GameObject _effectObject; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x4000117")]
	private ID _hitSoundID; //Field offset: 0x118

	[Address(RVA = "0x1CD2C60", Offset = "0x1CD2060", Length = "0x39")]
	[Token(Token = "0x6000181")]
	private static InGameEnemyBomber() { }

	[Address(RVA = "0x1CD2CA0", Offset = "0x1CD20A0", Length = "0x71")]
	[Token(Token = "0x6000180")]
	public InGameEnemyBomber() { }

	[Address(RVA = "0x1CD2530", Offset = "0x1CD1930", Length = "0xAC")]
	[Token(Token = "0x600017C")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1CD25E0", Offset = "0x1CD19E0", Length = "0x78")]
	[Token(Token = "0x600017F")]
	private void EndNapalm() { }

	[Address(RVA = "0x1CD2660", Offset = "0x1CD1A60", Length = "0xEE")]
	[Token(Token = "0x6000178")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1CD2750", Offset = "0x1CD1B50", Length = "0x109")]
	[Token(Token = "0x600017A")]
	protected virtual void OnHitProgress(CollisionOrder aData) { }

	[Address(RVA = "0x1CD2860", Offset = "0x1CD1C60", Length = "0xB3")]
	[Token(Token = "0x600017B")]
	public virtual void ProgressBullet(float dt) { }

	[Address(RVA = "0x1CD2920", Offset = "0x1CD1D20", Length = "0x62")]
	[Token(Token = "0x6000179")]
	public virtual void ReStart(bool withPlay) { }

	[Address(RVA = "0x1CD2990", Offset = "0x1CD1D90", Length = "0x233")]
	[Token(Token = "0x600017D")]
	public virtual void StartMove(Vector3 s, Vector3 tdir, float tspeed, MoveType moveType) { }

	[Address(RVA = "0x1CD2BD0", Offset = "0x1CD1FD0", Length = "0x80")]
	[Token(Token = "0x600017E")]
	private void StartSpark() { }

}

