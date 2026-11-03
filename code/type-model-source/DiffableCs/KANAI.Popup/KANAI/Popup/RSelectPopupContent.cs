namespace KANAI.Popup;

[Token(Token = "0x2000035")]
public class RSelectPopupContent : PopupContentBase
{
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40000FE")]
	private ButtonBase arrowUp; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40000FF")]
	private ButtonBase arrowDown; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000100")]
	private GameObject buttonObject; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000101")]
	private GameObject textArea; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000102")]
	private int buttonDistance; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x4000103")]
	private int TextDistance; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000104")]
	private UITextMeshPro _buttonText; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000105")]
	private int _numButtons; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000106")]
	private int _cursorIndex; //Field offset: 0x94

	[Token(Token = "0x17000039")]
	public int CursorIndex
	{
		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[Token(Token = "0x6000168")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x1E0CB90", Offset = "0x1E0BF90", Length = "0x14C")]
	[Token(Token = "0x6000167")]
	private void _clickButton() { }

	[Address(RVA = "0x1E0CD10", Offset = "0x1E0C110", Length = "0xB7")]
	[Token(Token = "0x6000165")]
	private void _indexAdd() { }

	[Address(RVA = "0x1E0CDD0", Offset = "0x1E0C1D0", Length = "0xB7")]
	[Token(Token = "0x6000164")]
	private void _indexSub() { }

	[Address(RVA = "0x1E0CE90", Offset = "0x1E0C290", Length = "0x151")]
	[Token(Token = "0x6000166")]
	private void _setupButton() { }

	[Address(RVA = "0x1E0CCE0", Offset = "0x1E0C0E0", Length = "0x29")]
	[Token(Token = "0x6000169")]
	public RSelectPopupContent() { }

	[Address(RVA = "0x1E0C230", Offset = "0x1E0B630", Length = "0x2D6")]
	[Token(Token = "0x6000162")]
	public virtual void ContentUpdate() { }

	[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
	[Token(Token = "0x6000168")]
	public int get_CursorIndex() { }

	[Address(RVA = "0x1E0C510", Offset = "0x1E0B910", Length = "0x5A2")]
	[Token(Token = "0x6000160")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1E0CAC0", Offset = "0x1E0BEC0", Length = "0x2C")]
	[Token(Token = "0x6000163")]
	public void SetCursorIndex(int tindex) { }

	[Address(RVA = "0x1E0CAF0", Offset = "0x1E0BEF0", Length = "0x95")]
	[Token(Token = "0x6000161")]
	public virtual void StartActive() { }

}

