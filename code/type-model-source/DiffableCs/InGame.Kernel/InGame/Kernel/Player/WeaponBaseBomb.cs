namespace InGame.Kernel.Player;

[Token(Token = "0x2000124")]
public class WeaponBaseBomb : MonoBehaviour
{
	[Token(Token = "0x4000835")]
	protected static Vector3 _bombPositionOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000836")]
	protected int _playerNo; //Field offset: 0x20

	[Address(RVA = "0x1D577C0", Offset = "0x1D56BC0", Length = "0x4D")]
	[Token(Token = "0x6000923")]
	private static WeaponBaseBomb() { }

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000922")]
	public WeaponBaseBomb() { }

}

