namespace System.Drawing;

[Token(Token = "0x2000009")]
public struct RectangleF : IEquatable<RectangleF>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BF")]
	private float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000C0")]
	private float y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000C1")]
	private float width; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000C2")]
	private float height; //Field offset: 0xC

	[Token(Token = "0x17000013")]
	public float Height
	{
		[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000012")]
	public float Width
	{
		[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
		[Token(Token = "0x600002F")]
		 get { } //Length: 229
	}

	[Token(Token = "0x17000010")]
	public float X
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x600002D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000011")]
	public float Y
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[Token(Token = "0x600002E")]
		 get { } //Length: 388
	}

	[Address(RVA = "0x23DE2E0", Offset = "0x23DD6E0", Length = "0xC0")]
	[Token(Token = "0x6000031")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x23DE3B0", Offset = "0x23DD7B0", Length = "0x4C")]
	[Token(Token = "0x6000032")]
	public override bool Equals(RectangleF other) { }

	[Address(RVA = "0x5AA530", Offset = "0x5A9930", Length = "0x6")]
	[Token(Token = "0x6000030")]
	public float get_Height() { }

	[Address(RVA = "0x5AA540", Offset = "0x5A9940", Length = "0xE5")]
	[Token(Token = "0x600002F")]
	public float get_Width() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x600002D")]
	public float get_X() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[Token(Token = "0x600002E")]
	public float get_Y() { }

	[Address(RVA = "0x23DE400", Offset = "0x23DD800", Length = "0xEE")]
	[Token(Token = "0x6000034")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23DE6F0", Offset = "0x23DDAF0", Length = "0x38")]
	[Token(Token = "0x6000033")]
	public static bool op_Equality(RectangleF left, RectangleF right) { }

	[Address(RVA = "0x23DE4F0", Offset = "0x23DD8F0", Length = "0x1F7")]
	[Token(Token = "0x6000035")]
	public virtual string ToString() { }

}

