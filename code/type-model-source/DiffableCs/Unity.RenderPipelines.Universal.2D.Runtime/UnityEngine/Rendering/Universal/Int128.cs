namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200000A")]
internal struct Int128
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000011")]
	private long hi; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000012")]
	private ulong lo; //Field offset: 0x8

	[Address(RVA = "0x2D18200", Offset = "0x2D17600", Length = "0xC")]
	[Token(Token = "0x600001C")]
	public Int128(long _lo) { }

	[Address(RVA = "0x2D18210", Offset = "0x2D17610", Length = "0x8")]
	[Token(Token = "0x600001D")]
	public Int128(long _hi, ulong _lo) { }

	[Address(RVA = "0x289C960", Offset = "0x289BD60", Length = "0xF")]
	[Token(Token = "0x600001E")]
	public Int128(Int128 val) { }

	[Address(RVA = "0x2D18070", Offset = "0x2D17470", Length = "0x8B")]
	[Token(Token = "0x6000022")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2D18100", Offset = "0x2D17500", Length = "0x2E")]
	[Token(Token = "0x6000023")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2D18130", Offset = "0x2D17530", Length = "0xBA")]
	[Token(Token = "0x600002A")]
	public static Int128 Int128Mul(long lhs, long rhs) { }

	[Address(RVA = "0x2D181F0", Offset = "0x2D175F0", Length = "0x8")]
	[Token(Token = "0x600001F")]
	public bool IsNegative() { }

	[Address(RVA = "0x2D18220", Offset = "0x2D17620", Length = "0x21")]
	[Token(Token = "0x6000026")]
	public static Int128 op_Addition(Int128 lhs, Int128 rhs) { }

	[Address(RVA = "0x2D18250", Offset = "0x2D17650", Length = "0xB2")]
	[Token(Token = "0x6000020")]
	public static bool op_Equality(Int128 val1, Int128 val2) { }

	[Address(RVA = "0x2D18310", Offset = "0x2D17710", Length = "0xAB")]
	[Token(Token = "0x6000029")]
	public static double op_Explicit(Int128 val) { }

	[Address(RVA = "0x2D183C0", Offset = "0x2D177C0", Length = "0x18")]
	[Token(Token = "0x6000024")]
	public static bool op_GreaterThan(Int128 val1, Int128 val2) { }

	[Address(RVA = "0x2D183E0", Offset = "0x2D177E0", Length = "0xB8")]
	[Token(Token = "0x6000021")]
	public static bool op_Inequality(Int128 val1, Int128 val2) { }

	[Address(RVA = "0x2D184A0", Offset = "0x2D178A0", Length = "0x18")]
	[Token(Token = "0x6000025")]
	public static bool op_LessThan(Int128 val1, Int128 val2) { }

	[Address(RVA = "0x2D184C0", Offset = "0x2D178C0", Length = "0x65")]
	[Token(Token = "0x6000027")]
	public static Int128 op_Subtraction(Int128 lhs, Int128 rhs) { }

	[Address(RVA = "0x2D18530", Offset = "0x2D17930", Length = "0x34")]
	[Token(Token = "0x6000028")]
	public static Int128 op_UnaryNegation(Int128 val) { }

}

