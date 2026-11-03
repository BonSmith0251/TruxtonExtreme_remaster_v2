namespace OutGame.Extra;

[Token(Token = "0x2000175")]
public class HowToPage2 : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400068D")]
	private GameObject _arcade; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400068E")]
	private GameObject _arena; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400068F")]
	private GameObject _dlc01; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000690")]
	private GameObject _dlc02; //Field offset: 0x38

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000954")]
	public HowToPage2() { }

	[Address(RVA = "0x21FD880", Offset = "0x21FCC80", Length = "0xF5")]
	[Token(Token = "0x6000953")]
	private void Start() { }

}

