namespace InGame.Kernel.Enemy;

[Token(Token = "0x200020A")]
public class Ene_Sm01body : HybridCollisionModel
{

	[Address(RVA = "0x1D03300", Offset = "0x1D02700", Length = "0x49")]
	[Token(Token = "0x6000F6F")]
	public Ene_Sm01body() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000F6D")]
	public virtual bool IsBulletHit(HybridCollisions hitsubject) { }

	[Address(RVA = "0x1D03170", Offset = "0x1D02570", Length = "0x188")]
	[Token(Token = "0x6000F6E")]
	protected virtual bool IsHitSubject(HybridCollisionBridge bridge) { }

}

