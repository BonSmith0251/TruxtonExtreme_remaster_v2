namespace Steamworks;

[CallbackIdentity(4515)]
[Token(Token = "0x2000063")]
public struct HTML_JSConfirm_t
{
	[Token(Token = "0x40000E6")]
	public const int k_iCallback = 4515; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E7")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000E8")]
	public string pchMessage; //Field offset: 0x8

}

