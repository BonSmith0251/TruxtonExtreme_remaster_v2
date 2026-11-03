namespace System.Drawing;

[Token(Token = "0x2000006")]
public struct Point : IEquatable<Point>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B7")]
	private int x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000B8")]
	private int y; //Field offset: 0x4

	[Token(Token = "0x17000008")]
	public int X
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000009")]
	public int Y
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x23DE090", Offset = "0x23DD490", Length = "0x8F")]
	[Token(Token = "0x6000019")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x23DE070", Offset = "0x23DD470", Length = "0x18")]
	[Token(Token = "0x600001A")]
	public override bool Equals(Point other) { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000016")]
	public int get_X() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x6000017")]
	public int get_Y() { }

	[Address(RVA = "0x23DE120", Offset = "0x23DD520", Length = "0x5E")]
	[Token(Token = "0x600001B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23DE2C0", Offset = "0x23DD6C0", Length = "0x15")]
	[Token(Token = "0x6000018")]
	public static bool op_Equality(Point left, Point right) { }

	[Address(RVA = "0x23DE180", Offset = "0x23DD580", Length = "0x139")]
	[Token(Token = "0x600001C")]
	public virtual string ToString() { }

}

