namespace Unity.Cinemachine;

[Token(Token = "0x200016B")]
internal struct PointD
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000611")]
	public double x; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000612")]
	public double y; //Field offset: 0x8

	[Address(RVA = "0x289C960", Offset = "0x289BD60", Length = "0xF")]
	[Token(Token = "0x60006F2")]
	public PointD(PointD pt) { }

	[Address(RVA = "0x289CD30", Offset = "0x289C130", Length = "0x1B")]
	[Token(Token = "0x60006F3")]
	public PointD(Point64 pt) { }

	[Address(RVA = "0x289CD50", Offset = "0x289C150", Length = "0x12")]
	[Token(Token = "0x60006F4")]
	public PointD(PointD pt, double scale) { }

	[Address(RVA = "0x289CD00", Offset = "0x289C100", Length = "0x23")]
	[Token(Token = "0x60006F5")]
	public PointD(Point64 pt, double scale) { }

	[Address(RVA = "0x289CD70", Offset = "0x289C170", Length = "0x1A")]
	[Token(Token = "0x60006F6")]
	public PointD(long x, long y) { }

	[Address(RVA = "0x27F69D0", Offset = "0x27F5DD0", Length = "0xA")]
	[Token(Token = "0x60006F7")]
	public PointD(double x, double y) { }

	[Address(RVA = "0x289CB70", Offset = "0x289BF70", Length = "0x9A")]
	[Token(Token = "0x60006FC")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60006FD")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x289CC10", Offset = "0x289C010", Length = "0x5D")]
	[Token(Token = "0x60006F9")]
	private static bool IsAlmostZero(double value) { }

	[Address(RVA = "0x289CD90", Offset = "0x289C190", Length = "0xEC")]
	[Token(Token = "0x60006FA")]
	public static bool op_Equality(PointD lhs, PointD rhs) { }

	[Address(RVA = "0x289CE80", Offset = "0x289C280", Length = "0xEC")]
	[Token(Token = "0x60006FB")]
	public static bool op_Inequality(PointD lhs, PointD rhs) { }

	[Address(RVA = "0x289CC70", Offset = "0x289C070", Length = "0x83")]
	[Token(Token = "0x60006F8")]
	public virtual string ToString() { }

}

