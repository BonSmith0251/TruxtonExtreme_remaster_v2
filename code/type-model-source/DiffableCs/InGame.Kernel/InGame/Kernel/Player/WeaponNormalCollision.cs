namespace InGame.Kernel.Player;

[Token(Token = "0x200013A")]
public class WeaponNormalCollision : WeaponCollisionBase
{
	[Token(Token = "0x4000905")]
	private static readonly ID _hitEffetSE; //Field offset: 0x0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x40008FF")]
	protected Transform _imageTop; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x4000900")]
	private MeshRenderer _shotRenderer; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x4000901")]
	private MeshFilter _shotMeshFilter; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Range(0, 10)]
	[SerializeField]
	[Token(Token = "0x4000902")]
	[Tooltip("ExBoost時の大きさ")]
	private float _exBoostScale; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	[Token(Token = "0x4000903")]
	private Vector3 _hitEffectOffset; //Field offset: 0xD4
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x4000904")]
	private EffectCode _hitEffectCode; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000906")]
	protected SimpleMove _simpleMove; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x4000907")]
	[Tooltip("衝突時に消去？")]
	private bool isPassObject; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000908")]
	private Action _bankPoolAction; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000909")]
	private bool _isFirstMove; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Token(Token = "0x400090A")]
	private Vector3 _exBoostSize; //Field offset: 0x104

	[Address(RVA = "0x1D76A40", Offset = "0x1D75E40", Length = "0x39")]
	[Token(Token = "0x60009E1")]
	private static WeaponNormalCollision() { }

	[Address(RVA = "0x1D76A80", Offset = "0x1D75E80", Length = "0xDC")]
	[Token(Token = "0x60009E0")]
	public WeaponNormalCollision() { }

	[Address(RVA = "0x1D75E10", Offset = "0x1D75210", Length = "0x3A")]
	[Token(Token = "0x60009D6")]
	public virtual void AddDead() { }

	[Address(RVA = "0x1D75E50", Offset = "0x1D75250", Length = "0x2D")]
	[Token(Token = "0x60009DD")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x1D75E80", Offset = "0x1D75280", Length = "0x204")]
	[Token(Token = "0x60009D1")]
	protected override void CallHitEffect() { }

	[Address(RVA = "0x1D76090", Offset = "0x1D75490", Length = "0x72")]
	[Token(Token = "0x60009D4")]
	public override void EndMove() { }

	[Address(RVA = "0x1D76110", Offset = "0x1D75510", Length = "0x29")]
	[Token(Token = "0x60009DC")]
	public void FirstMove(float dt) { }

	[Address(RVA = "0x1D76140", Offset = "0x1D75540", Length = "0x18E")]
	[Token(Token = "0x60009D2")]
	protected override Vector3 GetHitEffectOffset() { }

	[Address(RVA = "0x1D762D0", Offset = "0x1D756D0", Length = "0x18F")]
	[Token(Token = "0x60009CF")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D76460", Offset = "0x1D75860", Length = "0x105")]
	[Token(Token = "0x60009D0")]
	protected virtual void OnHitProgress(CollisionOrder aData) { }

	[Address(RVA = "0x1D76570", Offset = "0x1D75970", Length = "0x53")]
	[Token(Token = "0x60009DB")]
	public virtual void ProgressMove(float dt) { }

	[Address(RVA = "0x1D765D0", Offset = "0x1D759D0", Length = "0x26")]
	[Token(Token = "0x60009D5")]
	public void RefreshRoot(Transform gmr) { }

	[Address(RVA = "0x1D76600", Offset = "0x1D75A00", Length = "0x21")]
	[Token(Token = "0x60009DE")]
	public void RendererEnable(bool tactive) { }

	[Address(RVA = "0x1D76630", Offset = "0x1D75A30", Length = "0x43")]
	[Token(Token = "0x60009DF")]
	public virtual void SetActiveBank(bool tactive) { }

	[Address(RVA = "0x1D76680", Offset = "0x1D75A80", Length = "0xA5")]
	[Token(Token = "0x60009D7")]
	public virtual void SetExBoost(bool isEx) { }

	[Address(RVA = "0x1D76730", Offset = "0x1D75B30", Length = "0x8A")]
	[Token(Token = "0x60009D9")]
	public void SetShotMaterial(Material tmat) { }

	[Address(RVA = "0x1D767C0", Offset = "0x1D75BC0", Length = "0x8A")]
	[Token(Token = "0x60009DA")]
	public void SetShotMesh(Mesh tmesh) { }

	[Address(RVA = "0x1D76850", Offset = "0x1D75C50", Length = "0x20")]
	[Token(Token = "0x60009D8")]
	public void SetUniqueId(int tid) { }

	[Address(RVA = "0x1D76880", Offset = "0x1D75C80", Length = "0x1BF")]
	[Token(Token = "0x60009D3")]
	public override void StartMove(Vector3 s, Vector3 e, float t, bool isLookAt, Action _poolAction) { }

}

