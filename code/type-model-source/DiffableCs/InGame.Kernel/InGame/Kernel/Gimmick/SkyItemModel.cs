namespace InGame.Kernel.Gimmick;

[Token(Token = "0x200014D")]
public class SkyItemModel : HybridCollisionModel
{

	[Address(RVA = "0x1D72BC0", Offset = "0x1D71FC0", Length = "0x49")]
	[Token(Token = "0x6000A5C")]
	public SkyItemModel() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000A5A")]
	public virtual bool AddDamage(float t, int pno, bool isExboost) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000A59")]
	public virtual bool IsEnableDamage() { }

	[Address(RVA = "0x1D72B60", Offset = "0x1D71F60", Length = "0x5B")]
	[Token(Token = "0x6000A5B")]
	protected virtual bool IsHitSubject(HybridCollisionBridge bridge) { }

}

