namespace System.Drawing;

[Token(Token = "0x2000008")]
public struct Rectangle : IEquatable<Rectangle>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BB")]
	private int x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000BC")]
	private int y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000BD")]
	private int width; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000BE")]
	private int height; //Field offset: 0xC

	[Token(Token = "0x1700000F")]
	public int Height
	{
		[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
		[Token(Token = "0x6000027")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000E")]
	public int Width
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000C")]
	public int X
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6000024")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700000D")]
	public int Y
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x6000025")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x23DE730", Offset = "0x23DDB30", Length = "0xBD")]
	[Token(Token = "0x6000028")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x23DE7F0", Offset = "0x23DDBF0", Length = "0x49")]
	[Token(Token = "0x6000029")]
	public override bool Equals(Rectangle other) { }

	[Address(RVA = "0x672E90", Offset = "0x672290", Length = "0x4")]
	[Token(Token = "0x6000027")]
	public int get_Height() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6000026")]
	public int get_Width() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000024")]
	public int get_X() { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x6000025")]
	public int get_Y() { }

	[Address(RVA = "0x23DE840", Offset = "0x23DDC40", Length = "0x8A")]
	[Token(Token = "0x600002B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2025640", Offset = "0x2024A40", Length = "0x23")]
	[Token(Token = "0x600002A")]
	public static bool op_Equality(Rectangle left, Rectangle right) { }

	[Address(RVA = "0x23DE8D0", Offset = "0x23DDCD0", Length = "0x1E7")]
	[Token(Token = "0x600002C")]
	public virtual string ToString() { }

}

