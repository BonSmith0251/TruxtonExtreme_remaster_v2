namespace OutGame.Extra;

[Token(Token = "0x2000176")]
public class HowToPage3 : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000691")]
	private GameObject _howto01; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000692")]
	private GameObject _howto02Gold; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000693")]
	private GameObject _howto03Black; //Field offset: 0x30

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000956")]
	public HowToPage3() { }

	[Address(RVA = "0x21FD980", Offset = "0x21FCD80", Length = "0xF0")]
	[Token(Token = "0x6000955")]
	private void Start() { }

}

