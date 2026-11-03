namespace Steamworks;

[CallbackIdentity(4505)]
[Token(Token = "0x2000059")]
public struct HTML_URLChanged_t
{
	[Token(Token = "0x40000B5")]
	public const int k_iCallback = 4505; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B6")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000B7")]
	public string pchURL; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B8")]
	public string pchPostData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B9")]
	public bool bIsRedirect; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000BA")]
	public string pchPageTitle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000BB")]
	public bool bNewNavigation; //Field offset: 0x28

}

