namespace InGame.Kernel;

[Token(Token = "0x200001E")]
public class InGameCollisionModel : HybridCollisionModel
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000D1")]
	private bool _isEnable; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[SerializeField]
	[Token(Token = "0x40000D2")]
	private bool _isSkipClip; //Field offset: 0x71
	[FieldOffset(Offset = "0x72")]
	[SerializeField]
	[Token(Token = "0x40000D3")]
	private bool _isSkipScaleCalc; //Field offset: 0x72
	[FieldOffset(Offset = "0x73")]
	[SerializeField]
	[Token(Token = "0x40000D4")]
	private bool _isSkipRotate; //Field offset: 0x73
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x40000D5")]
	private LayerMask noHitLayer; //Field offset: 0x74

	[Address(RVA = "0x1CCF6D0", Offset = "0x1CCEAD0", Length = "0x59")]
	[Token(Token = "0x600012B")]
	public InGameCollisionModel() { }

	[Address(RVA = "0x1CCF5D0", Offset = "0x1CCE9D0", Length = "0x6C")]
	[Token(Token = "0x6000124")]
	public virtual bool AddDamage(float tdamage, int pno, bool isExboost) { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x600012A")]
	public virtual bool IsEnableCollision() { }

	[Address(RVA = "0x1CCF640", Offset = "0x1CCEA40", Length = "0x5E")]
	[Token(Token = "0x6000128")]
	protected virtual bool IsHitSubject(HybridCollisionBridge bridge) { }

	[Address(RVA = "0x1CCF6A0", Offset = "0x1CCEAA0", Length = "0x5")]
	[Token(Token = "0x6000125")]
	public virtual bool IsSkipClip() { }

	[Address(RVA = "0x1CCF6B0", Offset = "0x1CCEAB0", Length = "0x5")]
	[Token(Token = "0x6000127")]
	public virtual bool IsSkipRotate() { }

	[Address(RVA = "0x1CCF6C0", Offset = "0x1CCEAC0", Length = "0x5")]
	[Token(Token = "0x6000126")]
	public virtual bool IsSkipScale() { }

	[Address(RVA = "0xD89260", Offset = "0xD88660", Length = "0x4")]
	[Token(Token = "0x6000129")]
	public void SetEnable(bool _v) { }

}

