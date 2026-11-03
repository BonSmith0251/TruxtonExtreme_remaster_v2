namespace Unity.Cinemachine;

[Token(Token = "0x200016C")]
internal struct Rect64
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000613")]
	public long left; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000614")]
	public long top; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000615")]
	public long right; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000616")]
	public long bottom; //Field offset: 0x18

	[Token(Token = "0x1700014B")]
	public long Height
	{
		[Address(RVA = "0x289D050", Offset = "0x289C450", Length = "0x9")]
		[Token(Token = "0x6000702")]
		 get { } //Length: 9
		[Address(RVA = "0x289D070", Offset = "0x289C470", Length = "0x9")]
		[Token(Token = "0x6000703")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700014A")]
	public long Width
	{
		[Address(RVA = "0x289D060", Offset = "0x289C460", Length = "0x8")]
		[Token(Token = "0x6000700")]
		 get { } //Length: 8
		[Address(RVA = "0x289D080", Offset = "0x289C480", Length = "0x8")]
		[Token(Token = "0x6000701")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x27F6BF0", Offset = "0x27F5FF0", Length = "0x15")]
	[Token(Token = "0x60006FE")]
	public Rect64(long l, long t, long r, long b) { }

	[Address(RVA = "0x289D030", Offset = "0x289C430", Length = "0x1F")]
	[Token(Token = "0x60006FF")]
	public Rect64(Rect64 rec) { }

	[Address(RVA = "0x289CF70", Offset = "0x289C370", Length = "0x2A")]
	[Token(Token = "0x6000706")]
	public bool Contains(Point64 pt) { }

	[Address(RVA = "0x289CFA0", Offset = "0x289C3A0", Length = "0x37")]
	[Token(Token = "0x6000707")]
	public bool Contains(Rect64 rec) { }

	[Address(RVA = "0x289D050", Offset = "0x289C450", Length = "0x9")]
	[Token(Token = "0x6000702")]
	public long get_Height() { }

	[Address(RVA = "0x289D060", Offset = "0x289C460", Length = "0x8")]
	[Token(Token = "0x6000700")]
	public long get_Width() { }

	[Address(RVA = "0x289CFE0", Offset = "0x289C3E0", Length = "0x18")]
	[Token(Token = "0x6000704")]
	public bool IsEmpty() { }

	[Address(RVA = "0x289D000", Offset = "0x289C400", Length = "0x2D")]
	[Token(Token = "0x6000705")]
	public Point64 MidPoint() { }

	[Address(RVA = "0x289D070", Offset = "0x289C470", Length = "0x9")]
	[Token(Token = "0x6000703")]
	public void set_Height(long value) { }

	[Address(RVA = "0x289D080", Offset = "0x289C480", Length = "0x8")]
	[Token(Token = "0x6000701")]
	public void set_Width(long value) { }

}

