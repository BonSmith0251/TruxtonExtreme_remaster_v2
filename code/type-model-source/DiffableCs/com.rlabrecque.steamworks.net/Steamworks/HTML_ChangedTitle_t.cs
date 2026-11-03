namespace Steamworks;

[CallbackIdentity(4508)]
[Token(Token = "0x200005C")]
public struct HTML_ChangedTitle_t
{
	[Token(Token = "0x40000C3")]
	public const int k_iCallback = 4508; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C4")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000C5")]
	public string pchTitle; //Field offset: 0x8

}

