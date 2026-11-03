namespace System.Drawing;

[Token(Token = "0x2000007")]
public struct PointF : IEquatable<PointF>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B9")]
	private float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000BA")]
	private float y; //Field offset: 0x4

	[Token(Token = "0x1700000A")]
	public float X
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x600001D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700000B")]
	public float Y
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 388
	}

	[Address(RVA = "0x23DDDE0", Offset = "0x23DD1E0", Length = "0x99")]
	[Token(Token = "0x6000020")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x23DDDB0", Offset = "0x23DD1B0", Length = "0x2D")]
	[Token(Token = "0x6000021")]
	public override bool Equals(PointF other) { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x600001D")]
	public float get_X() { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[Token(Token = "0x600001E")]
	public float get_Y() { }

	[Address(RVA = "0x23DDE80", Offset = "0x23DD280", Length = "0x8A")]
	[Token(Token = "0x6000022")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23DE030", Offset = "0x23DD430", Length = "0x38")]
	[Token(Token = "0x600001F")]
	public static bool op_Equality(PointF left, PointF right) { }

	[Address(RVA = "0x23DDF10", Offset = "0x23DD310", Length = "0x11C")]
	[Token(Token = "0x6000023")]
	public virtual string ToString() { }

}

