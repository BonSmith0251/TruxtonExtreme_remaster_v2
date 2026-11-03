namespace UnityEngine.Splines;

[Token(Token = "0x2000047")]
public struct SplineKnotIndex : IEquatable<SplineKnotIndex>
{
	[Token(Token = "0x4000119")]
	public static SplineKnotIndex Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400011A")]
	public int Spline; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400011B")]
	public int Knot; //Field offset: 0x4

	[Address(RVA = "0x2E75BA0", Offset = "0x2E74FA0", Length = "0x44")]
	[Token(Token = "0x6000297")]
	private static SplineKnotIndex() { }

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x600028F")]
	public SplineKnotIndex(int spline, int knot) { }

	[Address(RVA = "0x2AF58C0", Offset = "0x2AF4CC0", Length = "0x12")]
	[Token(Token = "0x6000292")]
	public override bool Equals(SplineKnotIndex otherIndex) { }

	[Address(RVA = "0x2E75A40", Offset = "0x2E74E40", Length = "0xA3")]
	[Token(Token = "0x6000293")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2E75AF0", Offset = "0x2E74EF0", Length = "0xA")]
	[Token(Token = "0x6000295")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2E75B00", Offset = "0x2E74F00", Length = "0x11")]
	[Token(Token = "0x6000294")]
	public bool IsValid() { }

	[Address(RVA = "0x2E75BF0", Offset = "0x2E74FF0", Length = "0x72")]
	[Token(Token = "0x6000290")]
	public static bool op_Equality(SplineKnotIndex indexA, SplineKnotIndex indexB) { }

	[Address(RVA = "0x2E75C70", Offset = "0x2E75070", Length = "0x75")]
	[Token(Token = "0x6000291")]
	public static bool op_Inequality(SplineKnotIndex indexA, SplineKnotIndex indexB) { }

	[Address(RVA = "0x2E75B20", Offset = "0x2E74F20", Length = "0x7B")]
	[Token(Token = "0x6000296")]
	public virtual string ToString() { }

}

