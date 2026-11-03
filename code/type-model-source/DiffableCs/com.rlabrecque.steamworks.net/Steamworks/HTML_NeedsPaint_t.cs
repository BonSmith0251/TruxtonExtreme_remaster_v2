namespace Steamworks;

[CallbackIdentity(4502)]
[Token(Token = "0x2000056")]
public struct HTML_NeedsPaint_t
{
	[Token(Token = "0x40000A0")]
	public const int k_iCallback = 4502; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A1")]
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000A2")]
	public IntPtr pBGRA; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000A3")]
	public uint unWide; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40000A4")]
	public uint unTall; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A5")]
	public uint unUpdateX; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000A6")]
	public uint unUpdateY; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A7")]
	public uint unUpdateWide; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000A8")]
	public uint unUpdateTall; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000A9")]
	public uint unScrollX; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40000AA")]
	public uint unScrollY; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000AB")]
	public float flPageScale; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000AC")]
	public uint unPageSerial; //Field offset: 0x34

}

