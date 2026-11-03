namespace Steamworks;

[CallbackIdentity(4510)]
[Token(Token = "0x200005E")]
public struct HTML_CanGoBackAndForward_t
{
	[Token(Token = "0x40000CA")]
	public const int k_iCallback = 4510; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000CB")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000CC")]
	public bool bCanGoBack; //Field offset: 0x4
	[FieldOffset(Offset = "0x5")]
	[Token(Token = "0x40000CD")]
	public bool bCanGoForward; //Field offset: 0x5

}

