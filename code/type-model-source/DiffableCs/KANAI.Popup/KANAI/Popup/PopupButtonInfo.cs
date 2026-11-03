namespace KANAI.Popup;

[Token(Token = "0x200001E")]
public class PopupButtonInfo : ICloneable
{
	[Token(Token = "0x400009C")]
	public static readonly string OK; //Field offset: 0x0
	[Token(Token = "0x400009D")]
	public static readonly string Close; //Field offset: 0x8
	[Token(Token = "0x400009E")]
	public static readonly string Cancel; //Field offset: 0x10
	[Token(Token = "0x400009F")]
	public static readonly string Yes; //Field offset: 0x18
	[Token(Token = "0x40000A0")]
	public static readonly string No; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000095")]
	public int ID; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000096")]
	public bool IsEnable; //Field offset: 0x14
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x4000097")]
	public bool IsDefault; //Field offset: 0x15
	[FieldOffset(Offset = "0x16")]
	[Token(Token = "0x4000098")]
	public bool IsSelectedStart; //Field offset: 0x16
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000099")]
	public PopupButtonType BtnType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009A")]
	public string DisplayText; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400009B")]
	public string LocalizeKey; //Field offset: 0x28

	[Address(RVA = "0x1E07980", Offset = "0x1E06D80", Length = "0x16E")]
	[Token(Token = "0x60000BE")]
	private static PopupButtonInfo() { }

	[Address(RVA = "0x1E07AF0", Offset = "0x1E06EF0", Length = "0x58")]
	[Token(Token = "0x60000BD")]
	public PopupButtonInfo() { }

	[Address(RVA = "0x1E07900", Offset = "0x1E06D00", Length = "0x71")]
	[Token(Token = "0x60000BC")]
	public override object Clone() { }

}

