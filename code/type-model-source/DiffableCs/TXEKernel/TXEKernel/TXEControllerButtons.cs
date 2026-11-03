namespace TXEKernel;

[Token(Token = "0x2000111")]
public class TXEControllerButtons : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000577")]
	public TXEControllerButtonIcon[] _buttons; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000578")]
	private readonly Buttons[] _keys; //Field offset: 0x28

	[Address(RVA = "0x2726890", Offset = "0x2725C90", Length = "0x7F")]
	[Token(Token = "0x60007B9")]
	public TXEControllerButtons() { }

	[Address(RVA = "0x27267B0", Offset = "0x2725BB0", Length = "0xD0")]
	[Token(Token = "0x60007B8")]
	public void Set(Buttons assign) { }

}

