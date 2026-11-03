namespace OutGame.Extra;

[Token(Token = "0x2000177")]
public class HowToPage5 : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000694")]
	private GameObject _pipiruville; //Field offset: 0x20

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000958")]
	public HowToPage5() { }

	[Address(RVA = "0x21FDA80", Offset = "0x21FCE80", Length = "0x74")]
	[Token(Token = "0x6000957")]
	private void Start() { }

}

