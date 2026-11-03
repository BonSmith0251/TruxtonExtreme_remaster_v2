namespace KANAI.Popup;

[Token(Token = "0x200001B")]
public class PopupButton : ButtonBase
{
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400008B")]
	private UIBlinker uIBlinker; //Field offset: 0x160

	[Address(RVA = "0x1E088B0", Offset = "0x1E07CB0", Length = "0x90")]
	[Token(Token = "0x60000BB")]
	public PopupButton() { }

	[Address(RVA = "0x1E085D0", Offset = "0x1E079D0", Length = "0x4A")]
	[Token(Token = "0x60000B6")]
	protected virtual void Awake() { }

	[Address(RVA = "0x1E08620", Offset = "0x1E07A20", Length = "0x1E")]
	[Token(Token = "0x60000BA")]
	protected override bool IsBlinkCursor() { }

	[Address(RVA = "0x1E08640", Offset = "0x1E07A40", Length = "0xF5")]
	[Token(Token = "0x60000B7")]
	public void SetInformation(PopupButtonInfo infos) { }

	[Address(RVA = "0x1E07860", Offset = "0x1E06C60", Length = "0x82")]
	[Token(Token = "0x60000B8")]
	public void SetText(string iText) { }

	[Address(RVA = "0x1E08740", Offset = "0x1E07B40", Length = "0x163")]
	[Token(Token = "0x60000B9")]
	protected virtual void Update() { }

}

