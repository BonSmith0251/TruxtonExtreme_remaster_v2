namespace OutGame.UI;

[Token(Token = "0x2000158")]
public class TXERSelecter : UISlideSelecter
{
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000607")]
	private TXEBaseWindow _window; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000608")]
	private UITextMeshPro _labelText; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000609")]
	private bool _isLoop; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x400060A")]
	private bool _isSelected; //Field offset: 0x51
	[FieldOffset(Offset = "0x52")]
	[SerializeField]
	[Token(Token = "0x400060B")]
	private bool _useLocalizeKey; //Field offset: 0x52
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400060C")]
	private List<String> _texts; //Field offset: 0x58

	[Token(Token = "0x170001ED")]
	public bool IsSelected
	{
		[Address(RVA = "0x1CF2AF0", Offset = "0x1CF1EF0", Length = "0x5")]
		[Token(Token = "0x60008A8")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2206960", Offset = "0x2205D60", Length = "0x7B")]
	[Token(Token = "0x60008A9")]
	public TXERSelecter() { }

	[Address(RVA = "0x22064D0", Offset = "0x22058D0", Length = "0xA9")]
	[Token(Token = "0x60008A3")]
	public virtual void AddTextLabel(string tstr) { }

	[Address(RVA = "0x1CF2AF0", Offset = "0x1CF1EF0", Length = "0x5")]
	[Token(Token = "0x60008A8")]
	public bool get_IsSelected() { }

	[Address(RVA = "0x2206580", Offset = "0x2205980", Length = "0x81")]
	[Token(Token = "0x60008A4")]
	public virtual string GetTextLabel(int tno) { }

	[Address(RVA = "0x2206610", Offset = "0x2205A10", Length = "0x74")]
	[Token(Token = "0x60008A0")]
	public virtual void Initialize() { }

	[Address(RVA = "0xF4F630", Offset = "0xF4EA30", Length = "0x5")]
	[Token(Token = "0x60008A7")]
	public virtual bool IsLoop() { }

	[Address(RVA = "0x2206690", Offset = "0x2205A90", Length = "0xB3")]
	[Token(Token = "0x60008A5")]
	public virtual void RestoreText(String[] tstrs) { }

	[Address(RVA = "0x2206750", Offset = "0x2205B50", Length = "0x89")]
	[Token(Token = "0x60008A2")]
	public virtual void Selected(bool isSelect) { }

	[Address(RVA = "0x22067E0", Offset = "0x2205BE0", Length = "0x178")]
	[Token(Token = "0x60008A1")]
	public virtual void SetIndex(int n) { }

	[Address(RVA = "0x1CEB210", Offset = "0x1CEA610", Length = "0x4")]
	[Token(Token = "0x60008A6")]
	public void UseLocalizeKey(bool isUse) { }

}

