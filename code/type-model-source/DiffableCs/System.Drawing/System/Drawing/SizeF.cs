namespace System.Drawing;

[Token(Token = "0x200000B")]
public struct SizeF : IEquatable<SizeF>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C5")]
	private float width; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000C6")]
	private float height; //Field offset: 0x4

	[Token(Token = "0x17000017")]
	public float Height
	{
		[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
		[Token(Token = "0x6000041")]
		 get { } //Length: 388
	}

	[Token(Token = "0x17000016")]
	public float Width
	{
		[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
		[Token(Token = "0x6000040")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x23DEAC0", Offset = "0x23DDEC0", Length = "0x99")]
	[Token(Token = "0x6000042")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x23DDDB0", Offset = "0x23DD1B0", Length = "0x2D")]
	[Token(Token = "0x6000043")]
	public override bool Equals(SizeF other) { }

	[Address(RVA = "0x6640E0", Offset = "0x6634E0", Length = "0x184")]
	[Token(Token = "0x6000041")]
	public float get_Height() { }

	[Address(RVA = "0x6640D0", Offset = "0x6634D0", Length = "0x5")]
	[Token(Token = "0x6000040")]
	public float get_Width() { }

	[Address(RVA = "0x23DEB60", Offset = "0x23DDF60", Length = "0x8A")]
	[Token(Token = "0x6000044")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x23DE030", Offset = "0x23DD430", Length = "0x38")]
	[Token(Token = "0x600003F")]
	public static bool op_Equality(SizeF sz1, SizeF sz2) { }

	[Address(RVA = "0x23DEBF0", Offset = "0x23DDFF0", Length = "0x11C")]
	[Token(Token = "0x6000045")]
	public virtual string ToString() { }

}

