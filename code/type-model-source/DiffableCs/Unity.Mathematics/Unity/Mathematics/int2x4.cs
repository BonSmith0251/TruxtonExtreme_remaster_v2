namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000042")]
public struct int2x4 : IEquatable<int2x4>, IFormattable
{
	[Token(Token = "0x400010A")]
	public static readonly int2x4 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000106")]
	public int2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000107")]
	public int2 c1; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000108")]
	public int2 c2; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000109")]
	public int2 c3; //Field offset: 0x18

	[Token(Token = "0x170007CF")]
	public int2 Item
	{
		[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
		[Token(Token = "0x60019C2")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x27F6BF0", Offset = "0x27F5FF0", Length = "0x15")]
	[Token(Token = "0x600197D")]
	public int2x4(int2 c0, int2 c1, int2 c2, int2 c3) { }

	[Address(RVA = "0x2AFCAC0", Offset = "0x2AFBEC0", Length = "0x5A")]
	[Token(Token = "0x600197E")]
	public int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13) { }

	[Address(RVA = "0x2AFCBA0", Offset = "0x2AFBFA0", Length = "0x44")]
	[Token(Token = "0x600197F")]
	public int2x4(int v) { }

	[Address(RVA = "0x2A1AEF0", Offset = "0x2A1A2F0", Length = "0x97")]
	[Token(Token = "0x6001980")]
	public int2x4(bool v) { }

	[Address(RVA = "0x2A1ADB0", Offset = "0x2A1A1B0", Length = "0x13B")]
	[Token(Token = "0x6001981")]
	public int2x4(bool2x4 v) { }

	[Address(RVA = "0x2AFCBA0", Offset = "0x2AFBFA0", Length = "0x44")]
	[Token(Token = "0x6001982")]
	public int2x4(uint v) { }

	[Address(RVA = "0x2AFCA50", Offset = "0x2AFBE50", Length = "0x63")]
	[Token(Token = "0x6001983")]
	public int2x4(uint2x4 v) { }

	[Address(RVA = "0x2AFCBF0", Offset = "0x2AFBFF0", Length = "0x64")]
	[Token(Token = "0x6001984")]
	public int2x4(float v) { }

	[Address(RVA = "0x2AFC9D0", Offset = "0x2AFBDD0", Length = "0x78")]
	[Token(Token = "0x6001985")]
	public int2x4(float2x4 v) { }

	[Address(RVA = "0x2AFCC60", Offset = "0x2AFC060", Length = "0x64")]
	[Token(Token = "0x6001986")]
	public int2x4(double v) { }

	[Address(RVA = "0x2AFCB20", Offset = "0x2AFBF20", Length = "0x71")]
	[Token(Token = "0x6001987")]
	public int2x4(double2x4 v) { }

	[Address(RVA = "0x2AFC210", Offset = "0x2AFB610", Length = "0x74")]
	[Token(Token = "0x60019C3")]
	public override bool Equals(int2x4 rhs) { }

	[Address(RVA = "0x2AFC110", Offset = "0x2AFB510", Length = "0xF5")]
	[Token(Token = "0x60019C4")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
	[Token(Token = "0x60019C2")]
	public int2 get_Item(int index) { }

	[Address(RVA = "0x2AFC290", Offset = "0x2AFB690", Length = "0x26")]
	[Token(Token = "0x60019C5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AFCDF0", Offset = "0x2AFC1F0", Length = "0xAC")]
	[Token(Token = "0x6001994")]
	public static int2x4 op_Addition(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFCD60", Offset = "0x2AFC160", Length = "0x8D")]
	[Token(Token = "0x6001995")]
	public static int2x4 op_Addition(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFCCD0", Offset = "0x2AFC0D0", Length = "0x87")]
	[Token(Token = "0x6001996")]
	public static int2x4 op_Addition(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFCFD0", Offset = "0x2AFC3D0", Length = "0xB1")]
	[Token(Token = "0x60019B9")]
	public static int2x4 op_BitwiseAnd(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFCEA0", Offset = "0x2AFC2A0", Length = "0x93")]
	[Token(Token = "0x60019BA")]
	public static int2x4 op_BitwiseAnd(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFCF40", Offset = "0x2AFC340", Length = "0x8D")]
	[Token(Token = "0x60019BB")]
	public static int2x4 op_BitwiseAnd(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFD130", Offset = "0x2AFC530", Length = "0x8D")]
	[Token(Token = "0x60019BE")]
	public static int2x4 op_BitwiseOr(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFD1C0", Offset = "0x2AFC5C0", Length = "0xB1")]
	[Token(Token = "0x60019BC")]
	public static int2x4 op_BitwiseOr(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFD090", Offset = "0x2AFC490", Length = "0x93")]
	[Token(Token = "0x60019BD")]
	public static int2x4 op_BitwiseOr(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFD280", Offset = "0x2AFC680", Length = "0x8F")]
	[Token(Token = "0x60019A1")]
	public static int2x4 op_Decrement(int2x4 val) { }

	[Address(RVA = "0x2AFD3C0", Offset = "0x2AFC7C0", Length = "0xAB")]
	[Token(Token = "0x600199C")]
	public static int2x4 op_Division(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFD310", Offset = "0x2AFC710", Length = "0xAC")]
	[Token(Token = "0x600199B")]
	public static int2x4 op_Division(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFD470", Offset = "0x2AFC870", Length = "0xD2")]
	[Token(Token = "0x600199A")]
	public static int2x4 op_Division(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFD730", Offset = "0x2AFCB30", Length = "0xD8")]
	[Token(Token = "0x60019B4")]
	public static bool2x4 op_Equality(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFD550", Offset = "0x2AFC950", Length = "0xF4")]
	[Token(Token = "0x60019B2")]
	public static bool2x4 op_Equality(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFD650", Offset = "0x2AFCA50", Length = "0xD5")]
	[Token(Token = "0x60019B3")]
	public static bool2x4 op_Equality(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFD970", Offset = "0x2AFCD70", Length = "0x8D")]
	[Token(Token = "0x60019C1")]
	public static int2x4 op_ExclusiveOr(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFD8B0", Offset = "0x2AFCCB0", Length = "0xB1")]
	[Token(Token = "0x60019BF")]
	public static int2x4 op_ExclusiveOr(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFD810", Offset = "0x2AFCC10", Length = "0x93")]
	[Token(Token = "0x60019C0")]
	public static int2x4 op_ExclusiveOr(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2A433D0", Offset = "0x2A427D0", Length = "0x95")]
	[Token(Token = "0x600198C")]
	public static int2x4 op_Explicit(uint2x4 v) { }

	[Address(RVA = "0x2A43680", Offset = "0x2A42A80", Length = "0x67")]
	[Token(Token = "0x600198D")]
	public static int2x4 op_Explicit(float v) { }

	[Address(RVA = "0x2A435E0", Offset = "0x2A429E0", Length = "0x9B")]
	[Token(Token = "0x600198E")]
	public static int2x4 op_Explicit(float2x4 v) { }

	[Address(RVA = "0x2A43570", Offset = "0x2A42970", Length = "0x67")]
	[Token(Token = "0x600198F")]
	public static int2x4 op_Explicit(double v) { }

	[Address(RVA = "0x2A43380", Offset = "0x2A42780", Length = "0x47")]
	[Token(Token = "0x600198B")]
	public static int2x4 op_Explicit(uint v) { }

	[Address(RVA = "0x2AFDA00", Offset = "0x2AFCE00", Length = "0x24")]
	[Token(Token = "0x6001989")]
	public static int2x4 op_Explicit(bool v) { }

	[Address(RVA = "0x2A43350", Offset = "0x2A42750", Length = "0x24")]
	[Token(Token = "0x600198A")]
	public static int2x4 op_Explicit(bool2x4 v) { }

	[Address(RVA = "0x2A436F0", Offset = "0x2A42AF0", Length = "0x8E")]
	[Token(Token = "0x6001990")]
	public static int2x4 op_Explicit(double2x4 v) { }

	[Address(RVA = "0x2AFDCF0", Offset = "0x2AFD0F0", Length = "0xF4")]
	[Token(Token = "0x60019A8")]
	public static bool2x4 op_GreaterThan(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFDDF0", Offset = "0x2AFD1F0", Length = "0xD5")]
	[Token(Token = "0x60019A9")]
	public static bool2x4 op_GreaterThan(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFDED0", Offset = "0x2AFD2D0", Length = "0xD8")]
	[Token(Token = "0x60019AA")]
	public static bool2x4 op_GreaterThan(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFDA30", Offset = "0x2AFCE30", Length = "0xF4")]
	[Token(Token = "0x60019AB")]
	public static bool2x4 op_GreaterThanOrEqual(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFDB30", Offset = "0x2AFCF30", Length = "0xD5")]
	[Token(Token = "0x60019AC")]
	public static bool2x4 op_GreaterThanOrEqual(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFDC10", Offset = "0x2AFD010", Length = "0xD8")]
	[Token(Token = "0x60019AD")]
	public static bool2x4 op_GreaterThanOrEqual(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2A43380", Offset = "0x2A42780", Length = "0x47")]
	[Token(Token = "0x6001988")]
	public static int2x4 op_Implicit(int v) { }

	[Address(RVA = "0x2AFDFB0", Offset = "0x2AFD3B0", Length = "0x8F")]
	[Token(Token = "0x60019A0")]
	public static int2x4 op_Increment(int2x4 val) { }

	[Address(RVA = "0x2AFE120", Offset = "0x2AFD520", Length = "0xD5")]
	[Token(Token = "0x60019B6")]
	public static bool2x4 op_Inequality(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFE200", Offset = "0x2AFD600", Length = "0xF4")]
	[Token(Token = "0x60019B5")]
	public static bool2x4 op_Inequality(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFE040", Offset = "0x2AFD440", Length = "0xD8")]
	[Token(Token = "0x60019B7")]
	public static bool2x4 op_Inequality(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFE300", Offset = "0x2AFD700", Length = "0x94")]
	[Token(Token = "0x60019B0")]
	public static int2x4 op_LeftShift(int2x4 x, int n) { }

	[Address(RVA = "0x2AFE740", Offset = "0x2AFDB40", Length = "0xF4")]
	[Token(Token = "0x60019A2")]
	public static bool2x4 op_LessThan(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFE840", Offset = "0x2AFDC40", Length = "0xD8")]
	[Token(Token = "0x60019A4")]
	public static bool2x4 op_LessThan(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFE660", Offset = "0x2AFDA60", Length = "0xD5")]
	[Token(Token = "0x60019A3")]
	public static bool2x4 op_LessThan(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFE480", Offset = "0x2AFD880", Length = "0xD8")]
	[Token(Token = "0x60019A7")]
	public static bool2x4 op_LessThanOrEqual(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFE3A0", Offset = "0x2AFD7A0", Length = "0xD5")]
	[Token(Token = "0x60019A6")]
	public static bool2x4 op_LessThanOrEqual(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFE560", Offset = "0x2AFD960", Length = "0xF4")]
	[Token(Token = "0x60019A5")]
	public static bool2x4 op_LessThanOrEqual(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFE920", Offset = "0x2AFDD20", Length = "0xAB")]
	[Token(Token = "0x600199F")]
	public static int2x4 op_Modulus(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFE9D0", Offset = "0x2AFDDD0", Length = "0xD2")]
	[Token(Token = "0x600199D")]
	public static int2x4 op_Modulus(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFEAB0", Offset = "0x2AFDEB0", Length = "0xAC")]
	[Token(Token = "0x600199E")]
	public static int2x4 op_Modulus(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFEC00", Offset = "0x2AFE000", Length = "0xB9")]
	[Token(Token = "0x6001991")]
	public static int2x4 op_Multiply(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFEB60", Offset = "0x2AFDF60", Length = "0x95")]
	[Token(Token = "0x6001993")]
	public static int2x4 op_Multiply(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFECC0", Offset = "0x2AFE0C0", Length = "0x9B")]
	[Token(Token = "0x6001992")]
	public static int2x4 op_Multiply(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFED60", Offset = "0x2AFE160", Length = "0x8D")]
	[Token(Token = "0x60019B8")]
	public static int2x4 op_OnesComplement(int2x4 val) { }

	[Address(RVA = "0x2AFEDF0", Offset = "0x2AFE1F0", Length = "0x94")]
	[Token(Token = "0x60019B1")]
	public static int2x4 op_RightShift(int2x4 x, int n) { }

	[Address(RVA = "0x2AFEF50", Offset = "0x2AFE350", Length = "0x96")]
	[Token(Token = "0x6001999")]
	public static int2x4 op_Subtraction(int lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFEFF0", Offset = "0x2AFE3F0", Length = "0x93")]
	[Token(Token = "0x6001998")]
	public static int2x4 op_Subtraction(int2x4 lhs, int rhs) { }

	[Address(RVA = "0x2AFEE90", Offset = "0x2AFE290", Length = "0xB1")]
	[Token(Token = "0x6001997")]
	public static int2x4 op_Subtraction(int2x4 lhs, int2x4 rhs) { }

	[Address(RVA = "0x2AFF090", Offset = "0x2AFE490", Length = "0x8D")]
	[Token(Token = "0x60019AE")]
	public static int2x4 op_UnaryNegation(int2x4 val) { }

	[Address(RVA = "0x2AFF120", Offset = "0x2AFE520", Length = "0x6C")]
	[Token(Token = "0x60019AF")]
	public static int2x4 op_UnaryPlus(int2x4 val) { }

	[Address(RVA = "0x2AFC640", Offset = "0x2AFBA40", Length = "0x384")]
	[Token(Token = "0x60019C6")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AFC2C0", Offset = "0x2AFB6C0", Length = "0x37E")]
	[Token(Token = "0x60019C7")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

