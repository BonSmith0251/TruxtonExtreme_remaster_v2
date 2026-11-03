namespace Steamworks;

[CallbackIdentity(4521)]
[Token(Token = "0x2000065")]
public struct HTML_NewWindow_t
{
	[Token(Token = "0x40000ED")]
	public const int k_iCallback = 4521; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000EE")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000EF")]
	public string pchURL; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000F0")]
	public uint unX; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000F1")]
	public uint unY; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000F2")]
	public uint unWide; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000F3")]
	public uint unTall; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000F4")]
	public HHTMLBrowser unNewWindow_BrowserHandle_IGNORE; //Field offset: 0x20

}

