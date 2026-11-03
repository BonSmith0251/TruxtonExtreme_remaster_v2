namespace Steamworks;

[CallbackIdentity(4522)]
[Token(Token = "0x2000066")]
public struct HTML_SetCursor_t
{
	[Token(Token = "0x40000F5")]
	public const int k_iCallback = 4522; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F6")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000F7")]
	public uint eMouseCursor; //Field offset: 0x4

}

