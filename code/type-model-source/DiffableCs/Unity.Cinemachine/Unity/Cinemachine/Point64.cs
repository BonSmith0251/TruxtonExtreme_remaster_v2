namespace Unity.Cinemachine;

[Token(Token = "0x200016A")]
internal struct Point64
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400060F")]
	public long X; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000610")]
	public long Y; //Field offset: 0x8

	[Address(RVA = "0x289C960", Offset = "0x289BD60", Length = "0xF")]
	[Token(Token = "0x60006E5")]
	public Point64(Point64 pt) { }

	[Address(RVA = "0xE1C7E0", Offset = "0xE1BBE0", Length = "0x8")]
	[Token(Token = "0x60006E6")]
	public Point64(long x, long y) { }

	[Address(RVA = "0x289C8E0", Offset = "0x289BCE0", Length = "0x7B")]
	[Token(Token = "0x60006E7")]
	public Point64(double x, double y) { }

	[Address(RVA = "0x289C970", Offset = "0x289BD70", Length = "0x70")]
	[Token(Token = "0x60006E8")]
	public Point64(PointD pt) { }

	[Address(RVA = "0x289CA80", Offset = "0x289BE80", Length = "0x8D")]
	[Token(Token = "0x60006E9")]
	public Point64(Point64 pt, double scale) { }

	[Address(RVA = "0x289C9E0", Offset = "0x289BDE0", Length = "0x91")]
	[Token(Token = "0x60006EA")]
	public Point64(PointD pt, double scale) { }

	[Address(RVA = "0x289C7D0", Offset = "0x289BBD0", Length = "0x8B")]
	[Token(Token = "0x60006F0")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60006F1")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x27F7940", Offset = "0x27F6D40", Length = "0x19")]
	[Token(Token = "0x60006ED")]
	public static Point64 op_Addition(Point64 lhs, Point64 rhs) { }

	[Address(RVA = "0x289CB10", Offset = "0x289BF10", Length = "0x17")]
	[Token(Token = "0x60006EB")]
	public static bool op_Equality(Point64 lhs, Point64 rhs) { }

	[Address(RVA = "0x289CB30", Offset = "0x289BF30", Length = "0x17")]
	[Token(Token = "0x60006EC")]
	public static bool op_Inequality(Point64 lhs, Point64 rhs) { }

	[Address(RVA = "0x289CB50", Offset = "0x289BF50", Length = "0x19")]
	[Token(Token = "0x60006EE")]
	public static Point64 op_Subtraction(Point64 lhs, Point64 rhs) { }

	[Address(RVA = "0x289C860", Offset = "0x289BC60", Length = "0x7F")]
	[Token(Token = "0x60006EF")]
	public virtual string ToString() { }

}

