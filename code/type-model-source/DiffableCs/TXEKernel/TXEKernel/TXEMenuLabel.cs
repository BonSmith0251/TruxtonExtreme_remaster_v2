namespace TXEKernel;

[Token(Token = "0x20000E3")]
public class TXEMenuLabel : SimpleButtonBase
{
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x400049A")]
	private UINew _newImage; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400049B")]
	private TXEUIFontText _labelText; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400049C")]
	private int _indexNo; //Field offset: 0x130

	[Token(Token = "0x170001F7")]
	public int IndexNo
	{
		[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
		[Token(Token = "0x60006BE")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001F6")]
	public UINew NewImage
	{
		[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
		[Token(Token = "0x60006BD")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2715DE0", Offset = "0x27151E0", Length = "0x7")]
	[Token(Token = "0x60006BF")]
	public TXEMenuLabel() { }

	[Address(RVA = "0x1D11BF0", Offset = "0x1D10FF0", Length = "0x7")]
	[Token(Token = "0x60006BE")]
	public int get_IndexNo() { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[Token(Token = "0x60006BD")]
	public UINew get_NewImage() { }

	[Address(RVA = "0x2715AB0", Offset = "0x2714EB0", Length = "0x51")]
	[Token(Token = "0x60006BA")]
	public void Initialize(int tindex) { }

	[Address(RVA = "0x2715DB0", Offset = "0x27151B0", Length = "0x2D")]
	[Token(Token = "0x60006BB")]
	public void SetText(string s) { }

	[Address(RVA = "0x2715B10", Offset = "0x2714F10", Length = "0x294")]
	[Token(Token = "0x60006BC")]
	public void SetTXEText(string s, bool isEnable) { }

}

