namespace Steamworks;

[CallbackIdentity(4513)]
[Token(Token = "0x2000061")]
public struct HTML_LinkAtPosition_t
{
	[Token(Token = "0x40000DC")]
	public const int k_iCallback = 4513; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000DD")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000DE")]
	public uint x; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000DF")]
	public uint y; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000E0")]
	public string pchURL; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E1")]
	public bool bInput; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40000E2")]
	public bool bLiveLink; //Field offset: 0x19

}

