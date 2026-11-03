namespace OutGame.Extra;

[Token(Token = "0x2000174")]
public class HowToPage1 : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000689")]
	private GameObject _howTopage1PS5; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400068A")]
	private GameObject _howTopage1STEAM; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400068B")]
	private GameObject _howTopage1XBox; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x400068C")]
	private GameObject _howTopage1SWITCH2; //Field offset: 0x38

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000952")]
	public HowToPage1() { }

	[Address(RVA = "0x21FD820", Offset = "0x21FCC20", Length = "0x5F")]
	[Token(Token = "0x6000951")]
	private void Start() { }

}

