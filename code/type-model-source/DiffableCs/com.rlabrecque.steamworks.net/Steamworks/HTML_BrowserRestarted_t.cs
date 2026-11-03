namespace Steamworks;

[CallbackIdentity(4527)]
[Token(Token = "0x200006B")]
public struct HTML_BrowserRestarted_t
{
	[Token(Token = "0x4000103")]
	public const int k_iCallback = 4527; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000104")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000105")]
	public HHTMLBrowser unOldBrowserHandle; //Field offset: 0x4

}

