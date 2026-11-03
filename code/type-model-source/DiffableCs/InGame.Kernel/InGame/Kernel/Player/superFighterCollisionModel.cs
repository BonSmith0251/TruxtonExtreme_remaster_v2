namespace InGame.Kernel.Player;

[Token(Token = "0x2000121")]
public class superFighterCollisionModel : HybridCollisionModel
{

	[Address(RVA = "0x1D5FEF0", Offset = "0x1D5F2F0", Length = "0x49")]
	[Token(Token = "0x600091A")]
	public superFighterCollisionModel() { }

	[Address(RVA = "0x1D5FDC0", Offset = "0x1D5F1C0", Length = "0x12B")]
	[Token(Token = "0x6000919")]
	protected virtual bool IsHitSubject(HybridCollisionBridge bridge) { }

}

