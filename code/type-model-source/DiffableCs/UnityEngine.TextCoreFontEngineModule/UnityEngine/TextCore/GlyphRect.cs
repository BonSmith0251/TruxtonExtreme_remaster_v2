namespace UnityEngine.TextCore;

[Token(Token = "0x2000004")]
[UsedByNativeCode]
public struct GlyphRect : IEquatable<GlyphRect>
{
	[Token(Token = "0x4000020")]
	private static readonly GlyphRect s_ZeroGlyphRect; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeName("x")]
	[SerializeField]
	[Token(Token = "0x400001C")]
	private int m_X; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("y")]
	[SerializeField]
	[Token(Token = "0x400001D")]
	private int m_Y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("width")]
	[SerializeField]
	[Token(Token = "0x400001E")]
	private int m_Width; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("height")]
	[SerializeField]
	[Token(Token = "0x400001F")]
	private int m_Height; //Field offset: 0xC

	[Token(Token = "0x17000018")]
	public int height
	{
		[Address(RVA = "0xD93EC0", Offset = "0xD932C0", Length = "0x6")]
		[Token(Token = "0x600001D")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000017")]
	public int width
	{
		[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000015")]
	public int x
	{
		[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000016")]
	public int y
	{
		[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
		[Token(Token = "0x600001B")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000019")]
	public static GlyphRect zero
	{
		[Address(RVA = "0x31716E0", Offset = "0x3170AE0", Length = "0x60")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 96
	}

	[Address(RVA = "0x31716A0", Offset = "0x3170AA0", Length = "0x39")]
	[Token(Token = "0x6000023")]
	private static GlyphRect() { }

	[Address(RVA = "0x27F6A90", Offset = "0x27F5E90", Length = "0x12")]
	[Token(Token = "0x600001F")]
	public GlyphRect(int x, int y, int width, int height) { }

	[Address(RVA = "0x31715F0", Offset = "0x31709F0", Length = "0x5E")]
	[Token(Token = "0x6000021")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3171570", Offset = "0x3170970", Length = "0x7A")]
	[Token(Token = "0x6000022")]
	public override bool Equals(GlyphRect other) { }

	[Address(RVA = "0xD93EC0", Offset = "0xD932C0", Length = "0x6")]
	[Token(Token = "0x600001D")]
	public int get_height() { }

	[Address(RVA = "0xD18C70", Offset = "0xD18070", Length = "0x6")]
	[Token(Token = "0x600001C")]
	public int get_width() { }

	[Address(RVA = "0xFD6370", Offset = "0xFD5770", Length = "0x5")]
	[Token(Token = "0x600001A")]
	public int get_x() { }

	[Address(RVA = "0xFD3C70", Offset = "0xFD3070", Length = "0x6")]
	[Token(Token = "0x600001B")]
	public int get_y() { }

	[Address(RVA = "0x31716E0", Offset = "0x3170AE0", Length = "0x60")]
	[Token(Token = "0x600001E")]
	public static GlyphRect get_zero() { }

	[Address(RVA = "0x3171650", Offset = "0x3170A50", Length = "0x4E")]
	[Token(Token = "0x6000020")]
	public virtual int GetHashCode() { }

}

