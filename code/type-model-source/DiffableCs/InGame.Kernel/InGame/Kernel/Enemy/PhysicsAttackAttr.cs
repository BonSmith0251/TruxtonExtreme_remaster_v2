namespace InGame.Kernel.Enemy;

[Token(Token = "0x2000229")]
public class PhysicsAttackAttr : MonoBehaviour
{

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6001089")]
	public PhysicsAttackAttr() { }

	[Address(RVA = "0x1D18570", Offset = "0x1D17970", Length = "0xC8")]
	[Token(Token = "0x6001088")]
	private void OnTriggerEnter(Collider other) { }

}

