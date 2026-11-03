namespace Steamworks;

[CallbackIdentity(4512)]
[Token(Token = "0x2000060")]
public struct HTML_VerticalScroll_t
{
	[Token(Token = "0x40000D5")]
	public const int k_iCallback = 4512; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D6")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000D7")]
	public uint unScrollMax; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000D8")]
	public uint unScrollCurrent; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000D9")]
	public float flPageScale; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000DA")]
	public bool bVisible; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000DB")]
	public uint unPageSize; //Field offset: 0x14

}

