namespace InGame.Kernel.Enemy;

[Token(Token = "0x200016E")]
public class EnemyRuin : InGameObject, IRuinObject, IPrefabBankObject
{
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000A7C")]
	private Material[] _swapedMaterial; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A7D")]
	private Transform cachedTransform; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A7E")]
	private Action _finishCallback; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A7F")]
	private ParticleSystemRenderer[] _prenderers; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A80")]
	private float _aliveTime; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000A81")]
	private bool _isGroundSetted; //Field offset: 0x94

	[Address(RVA = "0x1D6E3C0", Offset = "0x1D6D7C0", Length = "0x7")]
	[Token(Token = "0x6000B62")]
	public EnemyRuin() { }

	[Address(RVA = "0x1D6DE50", Offset = "0x1D6D250", Length = "0x1E")]
	[Token(Token = "0x6000B5F")]
	public override bool CheckTimeout(float dt) { }

	[Address(RVA = "0x1D6DE70", Offset = "0x1D6D270", Length = "0x7F")]
	[Token(Token = "0x6000B5E")]
	public override void FinishRuin() { }

	[Address(RVA = "0x1D6DEF0", Offset = "0x1D6D2F0", Length = "0x31A")]
	[Token(Token = "0x6000B5B")]
	public virtual void Initialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000B60")]
	public virtual void SetActiveBank(bool tactive) { }

	[Address(RVA = "0x1D6E210", Offset = "0x1D6D610", Length = "0xC0")]
	[Token(Token = "0x6000B61")]
	private void SetRuinLayer(bool setGround) { }

	[Address(RVA = "0x1D6E2D0", Offset = "0x1D6D6D0", Length = "0xB4")]
	[Token(Token = "0x6000B5D")]
	public override void StartRuin(Vector3 pos, float aliveTime, bool isGround, Action _callback) { }

	[Address(RVA = "0x1D6E390", Offset = "0x1D6D790", Length = "0x2E")]
	[Token(Token = "0x6000B5C")]
	public virtual void Terminate() { }

}

