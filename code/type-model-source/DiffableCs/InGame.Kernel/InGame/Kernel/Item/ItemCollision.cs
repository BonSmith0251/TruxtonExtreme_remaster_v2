namespace InGame.Kernel.Item;

[Token(Token = "0x2000141")]
public class ItemCollision : InGameCollisionBaseUpdate, IRuinObject, IPrefabBankObject
{
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000935")]
	private Kind _itemEffect; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	[Token(Token = "0x4000936")]
	private int _itemValue; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x4000937")]
	private ID _getSound; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	[Token(Token = "0x4000938")]
	private bool _isGetEffect; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000939")]
	private int _hashCode; //Field offset: 0xB0

	[Address(RVA = "0x1D6FB80", Offset = "0x1D6EF80", Length = "0x11")]
	[Token(Token = "0x6000A15")]
	public ItemCollision() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000A14")]
	public virtual bool AddDamageOwner(float n) { }

	[Address(RVA = "0x1D6F4D0", Offset = "0x1D6E8D0", Length = "0xF7")]
	[Token(Token = "0x6000A10")]
	public virtual void CallDisabled() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000A0A")]
	public override bool CheckTimeout(float dt) { }

	[Address(RVA = "0x1CCED80", Offset = "0x1CCE180", Length = "0x14")]
	[Token(Token = "0x6000A09")]
	public override void FinishRuin() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6000A0C")]
	public override GameObject GetObject() { }

	[Address(RVA = "0x1D6F5D0", Offset = "0x1D6E9D0", Length = "0x68")]
	[Token(Token = "0x6000A0D")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1D6F640", Offset = "0x1D6EA40", Length = "0x21")]
	[Token(Token = "0x6000A0E")]
	public virtual bool IsAlive() { }

	[Address(RVA = "0x1CCE430", Offset = "0x1CCD830", Length = "0x7")]
	[Token(Token = "0x6000A16")]
	private override void KANAI.Kernel.IPrefabBankObject.SetupCache() { }

	[Address(RVA = "0x1D6F670", Offset = "0x1D6EA70", Length = "0x144")]
	[Token(Token = "0x6000A12")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1D6F7C0", Offset = "0x1D6EBC0", Length = "0x295")]
	[Token(Token = "0x6000A13")]
	protected virtual void OnHitProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x1D0F630", Offset = "0x1D0EA30", Length = "0x1E")]
	[Token(Token = "0x6000A0B")]
	public override void SetActiveBank(bool tactive) { }

	[Address(RVA = "0x1D58B00", Offset = "0x1D57F00", Length = "0x7")]
	[Token(Token = "0x6000A11")]
	public void SetHashCode(int tcode) { }

	[Address(RVA = "0x1D6FA60", Offset = "0x1D6EE60", Length = "0x111")]
	[Token(Token = "0x6000A08")]
	public override void StartRuin(Vector3 pos, float aliveTime, bool isGround, Action _callback) { }

	[Address(RVA = "0x1CCED80", Offset = "0x1CCE180", Length = "0x14")]
	[Token(Token = "0x6000A0F")]
	public virtual void ToDestroid() { }

}

