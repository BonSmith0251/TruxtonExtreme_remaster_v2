namespace Steamworks;

[CallbackIdentity(4511)]
[Token(Token = "0x200005F")]
public struct HTML_HorizontalScroll_t
{
	[Token(Token = "0x40000CE")]
	public const int k_iCallback = 4511; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000CF")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000D0")]
	public uint unScrollMax; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000D1")]
	public uint unScrollCurrent; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000D2")]
	public float flPageScale; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D3")]
	public bool bVisible; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000D4")]
	public uint unPageSize; //Field offset: 0x14

}

