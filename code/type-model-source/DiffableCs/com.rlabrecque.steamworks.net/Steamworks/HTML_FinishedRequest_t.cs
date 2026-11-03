namespace Steamworks;

[CallbackIdentity(4506)]
[Token(Token = "0x200005A")]
public struct HTML_FinishedRequest_t
{
	[Token(Token = "0x40000BC")]
	public const int k_iCallback = 4506; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BD")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000BE")]
	public string pchURL; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000BF")]
	public string pchPageTitle; //Field offset: 0x10

}

