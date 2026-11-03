namespace Steamworks;

[CallbackIdentity(4516)]
[Token(Token = "0x2000064")]
public struct HTML_FileOpenDialog_t
{
	[Token(Token = "0x40000E9")]
	public const int k_iCallback = 4516; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000EA")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000EB")]
	public string pchTitle; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000EC")]
	public string pchInitialFile; //Field offset: 0x10

}

