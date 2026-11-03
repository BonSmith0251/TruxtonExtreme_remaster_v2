namespace Steamworks;

[CallbackIdentity(4523)]
[Token(Token = "0x2000067")]
public struct HTML_StatusText_t
{
	[Token(Token = "0x40000F8")]
	public const int k_iCallback = 4523; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F9")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000FA")]
	public string pchMsg; //Field offset: 0x8

}

