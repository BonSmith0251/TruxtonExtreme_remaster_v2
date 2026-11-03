namespace KANAI.Popup;

[Token(Token = "0x200000C")]
public class CommonPopupParam
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000029")]
	public PopupSizeType SizeType; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400002A")]
	public PopupButtonOrder ButtonOrder; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002B")]
	public List<PopupButtonInfo> CustomButtonLists; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002C")]
	public PopupHeader HeaderType; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400002D")]
	public PopupFooter FooterType; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400002E")]
	public OutOfRangeTouch OutOfRangeAct; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400002F")]
	public bool BackgroundAct; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000030")]
	public string TitleOrKey; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000031")]
	public string MessageOrKey; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000032")]
	public int MessageFontSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000033")]
	public Dictionary<String, CommonPopupTextInfo> SubMessages; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000034")]
	public int Priority; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000035")]
	public int Index; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000036")]
	public PopupAttribute Attribute; //Field offset: 0x58

	[Address(RVA = "0x1E04970", Offset = "0x1E03D70", Length = "0x7B")]
	[Token(Token = "0x600001B")]
	public CommonPopupParam() { }

	[Address(RVA = "0x1E04900", Offset = "0x1E03D00", Length = "0x63")]
	[Token(Token = "0x600001A")]
	public void UpdateMarginType() { }

}

