namespace TXEKernel;

[Token(Token = "0x2000112")]
public class TXEFontButton : PopupButton
{
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000579")]
	private PopupBase _parentPopup; //Field offset: 0x168

	[Address(RVA = "0x2726E50", Offset = "0x2726250", Length = "0x7")]
	[Token(Token = "0x60007BD")]
	public TXEFontButton() { }

	[Address(RVA = "0x2726B80", Offset = "0x2725F80", Length = "0xE7")]
	[Token(Token = "0x60007BB")]
	protected virtual bool IsBlinkCursor() { }

	[Address(RVA = "0x2726C70", Offset = "0x2726070", Length = "0x1BB")]
	[Token(Token = "0x60007BA")]
	protected virtual void RefreshImage() { }

	[Address(RVA = "0x2726E30", Offset = "0x2726230", Length = "0x13")]
	[Token(Token = "0x60007BC")]
	public void SetParentPopup(PopupBase _popup) { }

}

