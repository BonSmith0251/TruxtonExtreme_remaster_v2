namespace Steamworks;

[CallbackIdentity(4501)]
[Token(Token = "0x2000055")]
public struct HTML_BrowserReady_t
{
	[Token(Token = "0x400009E")]
	public const int k_iCallback = 4501; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009F")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0

}

