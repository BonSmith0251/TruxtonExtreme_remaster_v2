namespace Steamworks;

[CallbackIdentity(4514)]
[Token(Token = "0x2000062")]
public struct HTML_JSAlert_t
{
	[Token(Token = "0x40000E3")]
	public const int k_iCallback = 4514; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E4")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000E5")]
	public string pchMessage; //Field offset: 0x8

}

