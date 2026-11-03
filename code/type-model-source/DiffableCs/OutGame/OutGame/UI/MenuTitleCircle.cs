namespace OutGame.UI;

[Token(Token = "0x200011A")]
public class MenuTitleCircle : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004B5")]
	private RectTransform _rect; //Field offset: 0x20

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600070F")]
	public MenuTitleCircle() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600070D")]
	private void Start() { }

	[Address(RVA = "0x21EB060", Offset = "0x21EA460", Length = "0x66")]
	[Token(Token = "0x600070E")]
	private void Update() { }

}

