namespace OutGame.UI;

[Token(Token = "0x2000138")]
public class PlayListOne : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x400052E")]
	public UITextMeshPro _stage; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400052F")]
	private TXERSelecter _first; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000530")]
	private TXERSelecter _second; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000531")]
	private TXERSelecter _boss; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000532")]
	public List<TXERSelecter> Selecters; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000533")]
	public List<RectTransform> SelecterRects; //Field offset: 0x48

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60007CC")]
	public PlayListOne() { }

	[Address(RVA = "0x21F4140", Offset = "0x21F3540", Length = "0x1E")]
	[Token(Token = "0x60007CB")]
	public void Initialize(string stageName) { }

	[Address(RVA = "0x21F4160", Offset = "0x21F3560", Length = "0x3F6")]
	[Token(Token = "0x60007C9")]
	private void Start() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007CA")]
	private void Update() { }

}

