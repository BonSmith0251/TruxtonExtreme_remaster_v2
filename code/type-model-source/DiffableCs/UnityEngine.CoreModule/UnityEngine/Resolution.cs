namespace UnityEngine;

[RequiredByNativeCode]
[Token(Token = "0x20000E5")]
public struct Resolution
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400027F")]
	private int m_Width; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000280")]
	private int m_Height; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000281")]
	private RefreshRate m_RefreshRate; //Field offset: 0x8

	[Token(Token = "0x17000131")]
	public int height
	{
		[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
		[Token(Token = "0x60006AC")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000132")]
	public RefreshRate refreshRateRatio
	{
		[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
		[Token(Token = "0x60006AD")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000130")]
	public int width
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x60006AB")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
	[Token(Token = "0x60006AC")]
	public int get_height() { }

	[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
	[Token(Token = "0x60006AD")]
	public RefreshRate get_refreshRateRatio() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x60006AB")]
	public int get_width() { }

	[Address(RVA = "0x3013720", Offset = "0x3012B20", Length = "0xA8")]
	[Token(Token = "0x60006AE")]
	public virtual string ToString() { }

}

