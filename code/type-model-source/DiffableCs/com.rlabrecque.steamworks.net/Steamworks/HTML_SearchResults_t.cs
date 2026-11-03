namespace Steamworks;

[CallbackIdentity(4509)]
[Token(Token = "0x200005D")]
public struct HTML_SearchResults_t
{
	[Token(Token = "0x40000C6")]
	public const int k_iCallback = 4509; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C7")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000C8")]
	public uint unResults; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000C9")]
	public uint unCurrentMatch; //Field offset: 0x8

}

