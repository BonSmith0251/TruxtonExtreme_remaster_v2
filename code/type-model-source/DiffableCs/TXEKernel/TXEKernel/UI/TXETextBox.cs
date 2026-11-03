namespace TXEKernel.UI;

[Token(Token = "0x200011A")]
public class TXETextBox : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000593")]
	private TXEBaseWindow _window; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000594")]
	private UITextMeshPro _Text; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000595")]
	private bool _isSelected; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	[Token(Token = "0x4000596")]
	private bool _useLocalizeKey; //Field offset: 0x31

	[Token(Token = "0x17000224")]
	private string text
	{
		[Address(RVA = "0x27284A0", Offset = "0x27278A0", Length = "0x44")]
		[Token(Token = "0x60007E7")]
		private get { } //Length: 68
		[Address(RVA = "0x27284F0", Offset = "0x27278F0", Length = "0x133")]
		[Token(Token = "0x60007E8")]
		private set { } //Length: 307
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60007E9")]
	public TXETextBox() { }

	[Address(RVA = "0x27284A0", Offset = "0x27278A0", Length = "0x44")]
	[Token(Token = "0x60007E7")]
	private string get_text() { }

	[Address(RVA = "0x27283F0", Offset = "0x27277F0", Length = "0x16")]
	[Token(Token = "0x60007E4")]
	public override void Initialize() { }

	[Address(RVA = "0x2728410", Offset = "0x2727810", Length = "0x89")]
	[Token(Token = "0x60007E5")]
	public override void Selected(bool isSelect) { }

	[Address(RVA = "0x27284F0", Offset = "0x27278F0", Length = "0x133")]
	[Token(Token = "0x60007E8")]
	private void set_text(string value) { }

	[Address(RVA = "0x1E075E0", Offset = "0x1E069E0", Length = "0x4")]
	[Token(Token = "0x60007E6")]
	public void UseLocalizeKey(bool isUse) { }

}

