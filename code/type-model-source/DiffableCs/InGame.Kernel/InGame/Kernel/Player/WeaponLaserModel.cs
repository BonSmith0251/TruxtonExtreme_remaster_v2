namespace InGame.Kernel.Player;

[Token(Token = "0x2000134")]
public class WeaponLaserModel : HybridCollisionModel
{
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40008CC")]
	private int _indexNumber; //Field offset: 0x70

	[Address(RVA = "0x1D74830", Offset = "0x1D73C30", Length = "0x49")]
	[Token(Token = "0x60009A9")]
	public WeaponLaserModel() { }

	[Address(RVA = "0x1D74630", Offset = "0x1D73A30", Length = "0x125")]
	[Token(Token = "0x60009A8")]
	protected virtual bool IsHitSubject(HybridCollisionBridge bridge) { }

	[Address(RVA = "0x1D74760", Offset = "0x1D73B60", Length = "0xC6")]
	[Token(Token = "0x60009A7")]
	public virtual void OwnerStart() { }

}

