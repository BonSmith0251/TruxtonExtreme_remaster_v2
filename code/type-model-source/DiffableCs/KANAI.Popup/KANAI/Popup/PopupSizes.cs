namespace KANAI.Popup;

[Token(Token = "0x200002B")]
public class PopupSizes
{
	[Token(Token = "0x40000E6")]
	protected static readonly Dictionary<PopupSizeType, Vector2> SizeTypeLists; //Field offset: 0x0

	[Address(RVA = "0x1E0A5A0", Offset = "0x1E099A0", Length = "0x2A3")]
	[Token(Token = "0x600012F")]
	private static PopupSizes() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600012E")]
	public PopupSizes() { }

	[Address(RVA = "0x1E0A460", Offset = "0x1E09860", Length = "0x17")]
	[Token(Token = "0x600012C")]
	public static float GetFooterSize(PopupFooter ttype) { }

	[Address(RVA = "0x1E0A480", Offset = "0x1E09880", Length = "0x17")]
	[Token(Token = "0x600012B")]
	public static float GetHeaderSize(PopupHeader ttype) { }

	[Address(RVA = "0x1E0A4A0", Offset = "0x1E098A0", Length = "0x80")]
	[Token(Token = "0x600012D")]
	public static Vector2 GetMarginSize(PopupHeader h, PopupFooter f) { }

	[Address(RVA = "0x1E0A520", Offset = "0x1E09920", Length = "0x76")]
	[Token(Token = "0x600012A")]
	public static Vector2 GetWindowSize(PopupSizeType value) { }

}

