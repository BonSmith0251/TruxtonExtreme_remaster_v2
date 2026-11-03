namespace InGame.Kernel.UI;

[Token(Token = "0x20000C6")]
public class ViewTimeup : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40005D4")]
	private UIImage _timeupLogo; //Field offset: 0x20

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000704")]
	public ViewTimeup() { }

	[Address(RVA = "0x1D47F40", Offset = "0x1D47340", Length = "0x1E")]
	[Token(Token = "0x6000703")]
	public void DisplayTimeup(bool isDisplay) { }

	[Address(RVA = "0x1D47F60", Offset = "0x1D47360", Length = "0x20")]
	[Token(Token = "0x6000702")]
	public void Setup() { }

}

