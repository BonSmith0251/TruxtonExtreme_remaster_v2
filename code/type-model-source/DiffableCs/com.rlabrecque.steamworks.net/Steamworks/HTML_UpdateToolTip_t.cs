namespace Steamworks;

[CallbackIdentity(4525)]
[Token(Token = "0x2000069")]
public struct HTML_UpdateToolTip_t
{
	[Token(Token = "0x40000FE")]
	public const int k_iCallback = 4525; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000FF")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000100")]
	public string pchMsg; //Field offset: 0x8

}

