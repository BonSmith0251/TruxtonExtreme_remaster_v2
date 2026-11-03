namespace MS.Internal.Xml.Cache;

[Token(Token = "0x2000287")]
internal sealed class XPathNodePageInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E67")]
	private int _pageNum; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000E68")]
	private int _nodeCount; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E69")]
	private XPathNode[] _pageNext; //Field offset: 0x18

	[Token(Token = "0x170006D5")]
	public XPathNode[] NextPage
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6001A0A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006D4")]
	public int NodeCount
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6001A09")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170006D3")]
	public int PageNumber
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6001A08")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6001A0A")]
	public XPathNode[] get_NextPage() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6001A09")]
	public int get_NodeCount() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6001A08")]
	public int get_PageNumber() { }

}

