namespace TXEKernel.UI;

[Token(Token = "0x2000119")]
public class KeyboardSettingPartsBase : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000592")]
	private TXEFontButton _button; //Field offset: 0x20

	[Token(Token = "0x17000221")]
	public TXEFontButton Button
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60007E0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000223")]
	public override PopupButton KeyButton
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60007E2")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000222")]
	public override UISlideSelecter KeySelecter
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60007E1")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60007E3")]
	public KeyboardSettingPartsBase() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60007E0")]
	public TXEFontButton get_Button() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60007E2")]
	public override PopupButton get_KeyButton() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60007E1")]
	public override UISlideSelecter get_KeySelecter() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007DF")]
	public override void UpdateString(UIKeyboard key) { }

}

