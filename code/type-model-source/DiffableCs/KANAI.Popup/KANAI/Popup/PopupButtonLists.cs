namespace KANAI.Popup;

[Token(Token = "0x200001F")]
public static class PopupButtonLists
{
	[Token(Token = "0x40000A1")]
	public static List<PopupButtonInfo> OKLayout; //Field offset: 0x0
	[Token(Token = "0x40000A2")]
	public static List<PopupButtonInfo> CancelLayout; //Field offset: 0x8
	[Token(Token = "0x40000A3")]
	public static List<PopupButtonInfo> YesNoLayout; //Field offset: 0x10
	[Token(Token = "0x40000A4")]
	public static List<PopupButtonInfo> NoYesLayout; //Field offset: 0x18
	[Token(Token = "0x40000A5")]
	public static List<PopupButtonInfo> OKCancelLayout; //Field offset: 0x20
	[Token(Token = "0x40000A6")]
	public static List<PopupButtonInfo> CloseLayout; //Field offset: 0x28

	[Address(RVA = "0x1E07B50", Offset = "0x1E06F50", Length = "0xA7B")]
	[Token(Token = "0x60000BF")]
	private static PopupButtonLists() { }

}

