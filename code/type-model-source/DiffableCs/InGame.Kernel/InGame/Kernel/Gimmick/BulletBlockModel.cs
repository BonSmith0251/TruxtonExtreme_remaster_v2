namespace InGame.Kernel.Gimmick;

[Token(Token = "0x2000148")]
public class BulletBlockModel : HybridCollisionModel
{

	[Address(RVA = "0x1D607F0", Offset = "0x1D5FBF0", Length = "0x49")]
	[Token(Token = "0x6000A3D")]
	public BulletBlockModel() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000A38")]
	public virtual bool AddDamage(float t, int pno, bool isExboost) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A3A")]
	public virtual void EntryHitLists(Collider2D other) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A3C")]
	public virtual void EntryLeaveLists(Collider2D other) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000A3B")]
	public virtual void EntryStayLists(Collider2D other) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000A37")]
	public virtual bool IsEnableDamage() { }

	[Address(RVA = "0x1D606A0", Offset = "0x1D5FAA0", Length = "0x14A")]
	[Token(Token = "0x6000A39")]
	protected virtual bool IsHitSubject(HybridCollisionBridge bridge) { }

}

