namespace InGame.Kernel;

[Token(Token = "0x200001D")]
public abstract class InGameCollisionBaseUpdate : InGameCollisionBase
{

	[Address(RVA = "0x1CCEFC0", Offset = "0x1CCE3C0", Length = "0x11")]
	[Token(Token = "0x6000123")]
	protected InGameCollisionBaseUpdate() { }

	[Address(RVA = "0x1CCEF30", Offset = "0x1CCE330", Length = "0x8B")]
	[Token(Token = "0x6000122")]
	private void LateUpdate() { }

}

