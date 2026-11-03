namespace Steamworks;

[CallbackIdentity(4524)]
[Token(Token = "0x2000068")]
public struct HTML_ShowToolTip_t
{
	[Token(Token = "0x40000FB")]
	public const int k_iCallback = 4524; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000FC")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000FD")]
	public string pchMsg; //Field offset: 0x8

}

