namespace System.Drawing;

[Token(Token = "0x200000A")]
public struct Size : IEquatable<Size>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C3")]
	private int width; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000C4")]
	private int height; //Field offset: 0x4

	[Token(Token = "0x17000015")]
	public int Height
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x600003A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000014")]
	public int Width
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6000039")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x6000036")]
	public Size(int width, int height) { }

	[Address(RVA = "0x23DED10", Offset = "0x23DE110", Length = "0x8F")]
	[Token(Token = "0x600003B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x23DE070", Offset = "0x23DD470", Length = "0x18")]
	[Token(Token = "0x600003C")]
	public override bool Equals(Size other) { }

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x600003A")]
	public int get_Height() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000039")]
	public int get_Width() { }

	[Address(RVA = "0x23DEDA0", Offset = "0x23DE1A0", Length = "0x5E")]
	[Token(Token = "0x600003D")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23DE2C0", Offset = "0x23DD6C0", Length = "0x15")]
	[Token(Token = "0x6000037")]
	public static bool op_Equality(Size sz1, Size sz2) { }

	[Address(RVA = "0x23DEF20", Offset = "0x23DE320", Length = "0x1DA")]
	[Token(Token = "0x6000038")]
	public static bool op_Inequality(Size sz1, Size sz2) { }

	[Address(RVA = "0x23DEE00", Offset = "0x23DE200", Length = "0x11C")]
	[Token(Token = "0x600003E")]
	public virtual string ToString() { }

}

