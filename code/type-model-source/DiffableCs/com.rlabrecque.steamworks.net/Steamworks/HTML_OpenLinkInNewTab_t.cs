namespace Steamworks;

[CallbackIdentity(4507)]
[Token(Token = "0x200005B")]
public struct HTML_OpenLinkInNewTab_t
{
	[Token(Token = "0x40000C0")]
	public const int k_iCallback = 4507; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C1")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000C2")]
	public string pchURL; //Field offset: 0x8

}

