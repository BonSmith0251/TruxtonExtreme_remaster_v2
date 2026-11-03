namespace InGame.Kernel.Item;

[Token(Token = "0x2000144")]
public class ItemEnemy : PawnEnemy
{
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	[Token(Token = "0x400094E")]
	private Kind _itemEffect; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B4")]
	[SerializeField]
	[Token(Token = "0x400094F")]
	private int _itemValue; //Field offset: 0x1B4
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000950")]
	private float _bornPassed; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x4000951")]
	private float _outTime; //Field offset: 0x1BC

	[Address(RVA = "0x1D71210", Offset = "0x1D70610", Length = "0x134")]
	[Token(Token = "0x6000A29")]
	private void _displayScoreUp(int pno, bool withScore) { }

	[Address(RVA = "0x1D711C0", Offset = "0x1D705C0", Length = "0x49")]
	[Token(Token = "0x6000A2A")]
	public ItemEnemy() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000A25")]
	public virtual bool AddDamageOwner(float n) { }

	[Address(RVA = "0x1D70B00", Offset = "0x1D6FF00", Length = "0x130")]
	[Token(Token = "0x6000A23")]
	public virtual void EndRoute() { }

	[Address(RVA = "0x1D70C40", Offset = "0x1D70040", Length = "0xE4")]
	[Token(Token = "0x6000A1F")]
	public virtual void Initialize() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000A24")]
	public virtual bool IsAlive() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000A26")]
	public virtual bool IsDestroyRateTarget() { }

	[Address(RVA = "0x1D70D30", Offset = "0x1D70130", Length = "0x1B")]
	[Token(Token = "0x6000A22")]
	public virtual bool IsHitEnable() { }

	[Address(RVA = "0x1D70D50", Offset = "0x1D70150", Length = "0x95")]
	[Token(Token = "0x6000A21")]
	protected virtual void LocalLateUpdate(float dt) { }

	[Address(RVA = "0x1D70DF0", Offset = "0x1D701F0", Length = "0x305")]
	[Token(Token = "0x6000A27")]
	protected virtual void OnHitProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A28")]
	protected virtual void OnStayProgress(CollisionOrder nOther) { }

	[Address(RVA = "0x1D71100", Offset = "0x1D70500", Length = "0xB6")]
	[Token(Token = "0x6000A20")]
	public virtual void ReStart(bool withPlay) { }

}

