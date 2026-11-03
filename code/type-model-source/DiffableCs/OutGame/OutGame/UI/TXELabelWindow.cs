namespace OutGame.UI;

[RequireComponent(typeof(CanvasGroup))]
[Token(Token = "0x200014A")]
public class TXELabelWindow : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40005BB")]
	private UITextMeshPro _textMethPro; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40005BC")]
	private TXEUIFontText _txeUIFontTexit; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40005BD")]
	private CanvasGroup _canvasGroup; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40005BE")]
	private float _visibleToSeconds; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x40005BF")]
	private float _hiddenToSeconds; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005C0")]
	private float _durationSeconds; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40005C1")]
	private bool _isEnable; //Field offset: 0x44
	[FieldOffset(Offset = "0x45")]
	[Token(Token = "0x40005C2")]
	private bool _isVisible; //Field offset: 0x45
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005C3")]
	private float _alphaRate; //Field offset: 0x48

	[Address(RVA = "0x22044B0", Offset = "0x22038B0", Length = "0x84")]
	[Token(Token = "0x600083A")]
	private void _fadeAlpha(float durationSeconds) { }

	[Address(RVA = "0x2204540", Offset = "0x2203940", Length = "0x37")]
	[Token(Token = "0x600083B")]
	private void _hidden() { }

	[Address(RVA = "0x2204580", Offset = "0x2203980", Length = "0xA3")]
	[Token(Token = "0x6000839")]
	private void _updateContent() { }

	[Address(RVA = "0x2204490", Offset = "0x2203890", Length = "0x15")]
	[Token(Token = "0x600083C")]
	public TXELabelWindow() { }

	[Address(RVA = "0x22042C0", Offset = "0x22036C0", Length = "0xE")]
	[Token(Token = "0x6000834")]
	public void Initialize() { }

	[Address(RVA = "0x22042D0", Offset = "0x22036D0", Length = "0xB2")]
	[Token(Token = "0x6000836")]
	public void SetText(string text) { }

	[Address(RVA = "0x2204390", Offset = "0x2203790", Length = "0x3B")]
	[Token(Token = "0x6000835")]
	public void Terminate() { }

	[Address(RVA = "0x22043D0", Offset = "0x22037D0", Length = "0xAD")]
	[Token(Token = "0x6000838")]
	private void Update() { }

	[Address(RVA = "0x2204480", Offset = "0x2203880", Length = "0xB")]
	[Token(Token = "0x6000837")]
	public void Visible(bool isVisible = true) { }

}

