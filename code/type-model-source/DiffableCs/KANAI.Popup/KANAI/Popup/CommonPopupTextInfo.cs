namespace KANAI.Popup;

[Token(Token = "0x200000B")]
public class CommonPopupTextInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000025")]
	public int FontSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000026")]
	public string Text; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000027")]
	public string LocalizeKey; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000028")]
	public PopupButtonType Type; //Field offset: 0x28

	[Address(RVA = "0x1E049F0", Offset = "0x1E03DF0", Length = "0x5B")]
	[Token(Token = "0x6000019")]
	public CommonPopupTextInfo() { }

}

