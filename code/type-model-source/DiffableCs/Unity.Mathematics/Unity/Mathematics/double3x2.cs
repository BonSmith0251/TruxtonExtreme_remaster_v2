namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000020")]
public struct double3x2 : IEquatable<double3x2>, IFormattable
{
	[Token(Token = "0x4000085")]
	public static readonly double3x2 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000083")]
	public double3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000084")]
	public double3 c1; //Field offset: 0x18

	[Token(Token = "0x17000284")]
	public double3 Item
	{
		[Address(RVA = "0x9D7550", Offset = "0x9D6950", Length = "0xC")]
		[Token(Token = "0x6000D4C")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x2AAD2B0", Offset = "0x2AAC6B0", Length = "0x24")]
	[Token(Token = "0x6000D13")]
	public double3x2(double3 c0, double3 c1) { }

	[Address(RVA = "0x2AACF30", Offset = "0x2AAC330", Length = "0x3F")]
	[Token(Token = "0x6000D1C")]
	public double3x2(float v) { }

	[Address(RVA = "0x2AACFB0", Offset = "0x2AAC3B0", Length = "0x90")]
	[Token(Token = "0x6000D1B")]
	public double3x2(uint3x2 v) { }

	[Address(RVA = "0x2AAD040", Offset = "0x2AAC440", Length = "0x5E")]
	[Token(Token = "0x6000D1A")]
	public double3x2(uint v) { }

	[Address(RVA = "0x2AAD220", Offset = "0x2AAC620", Length = "0x88")]
	[Token(Token = "0x6000D19")]
	public double3x2(int3x2 v) { }

	[Address(RVA = "0x2AAD0D0", Offset = "0x2AAC4D0", Length = "0x65")]
	[Token(Token = "0x6000D1D")]
	public double3x2(float3x2 v) { }

	[Address(RVA = "0x2AAD140", Offset = "0x2AAC540", Length = "0x90")]
	[Token(Token = "0x6000D17")]
	public double3x2(bool3x2 v) { }

	[Address(RVA = "0x2A17C00", Offset = "0x2A17000", Length = "0x6B")]
	[Token(Token = "0x6000D16")]
	public double3x2(bool v) { }

	[Address(RVA = "0x2AAD0A0", Offset = "0x2AAC4A0", Length = "0x28")]
	[Token(Token = "0x6000D15")]
	public double3x2(double v) { }

	[Address(RVA = "0x2AACF70", Offset = "0x2AAC370", Length = "0x37")]
	[Token(Token = "0x6000D14")]
	public double3x2(double m00, double m01, double m10, double m11, double m20, double m21) { }

	[Address(RVA = "0x2AAD1D0", Offset = "0x2AAC5D0", Length = "0x44")]
	[Token(Token = "0x6000D18")]
	public double3x2(int v) { }

	[Address(RVA = "0x2AAC740", Offset = "0x2AABB40", Length = "0xE7")]
	[Token(Token = "0x6000D4E")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AAC830", Offset = "0x2AABC30", Length = "0x7C")]
	[Token(Token = "0x6000D4D")]
	public override bool Equals(double3x2 rhs) { }

	[Address(RVA = "0x9D7550", Offset = "0x9D6950", Length = "0xC")]
	[Token(Token = "0x6000D4C")]
	public double3 get_Item(int index) { }

	[Address(RVA = "0x2AAC8B0", Offset = "0x2AABCB0", Length = "0xD0")]
	[Token(Token = "0x6000D4F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AAD3E0", Offset = "0x2AAC7E0", Length = "0x69")]
	[Token(Token = "0x6000D2B")]
	public static double3x2 op_Addition(double3x2 lhs, double rhs) { }

	[Address(RVA = "0x2AAD370", Offset = "0x2AAC770", Length = "0x6D")]
	[Token(Token = "0x6000D2C")]
	public static double3x2 op_Addition(double lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAD2E0", Offset = "0x2AAC6E0", Length = "0x85")]
	[Token(Token = "0x6000D2A")]
	public static double3x2 op_Addition(double3x2 lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAD450", Offset = "0x2AAC850", Length = "0x76")]
	[Token(Token = "0x6000D37")]
	public static double3x2 op_Decrement(double3x2 val) { }

	[Address(RVA = "0x2AAD5E0", Offset = "0x2AAC9E0", Length = "0x69")]
	[Token(Token = "0x6000D31")]
	public static double3x2 op_Division(double3x2 lhs, double rhs) { }

	[Address(RVA = "0x2AAD4D0", Offset = "0x2AAC8D0", Length = "0x85")]
	[Token(Token = "0x6000D30")]
	public static double3x2 op_Division(double3x2 lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAD560", Offset = "0x2AAC960", Length = "0x78")]
	[Token(Token = "0x6000D32")]
	public static double3x2 op_Division(double lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAD650", Offset = "0x2AACA50", Length = "0xAF")]
	[Token(Token = "0x6000D47")]
	public static bool3x2 op_Equality(double3x2 lhs, double rhs) { }

	[Address(RVA = "0x2AAD7B0", Offset = "0x2AACBB0", Length = "0xCD")]
	[Token(Token = "0x6000D46")]
	public static bool3x2 op_Equality(double3x2 lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAD700", Offset = "0x2AACB00", Length = "0xAB")]
	[Token(Token = "0x6000D48")]
	public static bool3x2 op_Equality(double lhs, double3x2 rhs) { }

	[Address(RVA = "0x2A2E240", Offset = "0x2A2D640", Length = "0x71")]
	[Token(Token = "0x6000D1F")]
	public static double3x2 op_Explicit(bool v) { }

	[Address(RVA = "0x2A2E2C0", Offset = "0x2A2D6C0", Length = "0x98")]
	[Token(Token = "0x6000D20")]
	public static double3x2 op_Explicit(bool3x2 v) { }

	[Address(RVA = "0x2AADA90", Offset = "0x2AACE90", Length = "0x8D")]
	[Token(Token = "0x6000D3E")]
	public static bool3x2 op_GreaterThan(double3x2 lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AADB20", Offset = "0x2AACF20", Length = "0x78")]
	[Token(Token = "0x6000D3F")]
	public static bool3x2 op_GreaterThan(double3x2 lhs, double rhs) { }

	[Address(RVA = "0x2AADA10", Offset = "0x2AACE10", Length = "0x71")]
	[Token(Token = "0x6000D40")]
	public static bool3x2 op_GreaterThan(double lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAD900", Offset = "0x2AACD00", Length = "0x8D")]
	[Token(Token = "0x6000D41")]
	public static bool3x2 op_GreaterThanOrEqual(double3x2 lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAD880", Offset = "0x2AACC80", Length = "0x78")]
	[Token(Token = "0x6000D42")]
	public static bool3x2 op_GreaterThanOrEqual(double3x2 lhs, double rhs) { }

	[Address(RVA = "0x2AAD990", Offset = "0x2AACD90", Length = "0x71")]
	[Token(Token = "0x6000D43")]
	public static bool3x2 op_GreaterThanOrEqual(double lhs, double3x2 rhs) { }

	[Address(RVA = "0x2A2E0F0", Offset = "0x2A2D4F0", Length = "0x6B")]
	[Token(Token = "0x6000D26")]
	public static double3x2 op_Implicit(float3x2 v) { }

	[Address(RVA = "0x2A2E360", Offset = "0x2A2D760", Length = "0x9D")]
	[Token(Token = "0x6000D22")]
	public static double3x2 op_Implicit(int3x2 v) { }

	[Address(RVA = "0x2A2E160", Offset = "0x2A2D560", Length = "0x2B")]
	[Token(Token = "0x6000D1E")]
	public static double3x2 op_Implicit(double v) { }

	[Address(RVA = "0x2A2E080", Offset = "0x2A2D480", Length = "0x61")]
	[Token(Token = "0x6000D23")]
	public static double3x2 op_Implicit(uint v) { }

	[Address(RVA = "0x2A2E190", Offset = "0x2A2D590", Length = "0xA9")]
	[Token(Token = "0x6000D24")]
	public static double3x2 op_Implicit(uint3x2 v) { }

	[Address(RVA = "0x2A2E490", Offset = "0x2A2D890", Length = "0x47")]
	[Token(Token = "0x6000D21")]
	public static double3x2 op_Implicit(int v) { }

	[Address(RVA = "0x2A2E440", Offset = "0x2A2D840", Length = "0x42")]
	[Token(Token = "0x6000D25")]
	public static double3x2 op_Implicit(float v) { }

	[Address(RVA = "0x2AADBA0", Offset = "0x2AACFA0", Length = "0x76")]
	[Token(Token = "0x6000D36")]
	public static double3x2 op_Increment(double3x2 val) { }

	[Address(RVA = "0x2AADCD0", Offset = "0x2AAD0D0", Length = "0xCD")]
	[Token(Token = "0x6000D49")]
	public static bool3x2 op_Inequality(double3x2 lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AADC20", Offset = "0x2AAD020", Length = "0xAB")]
	[Token(Token = "0x6000D4B")]
	public static bool3x2 op_Inequality(double lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AADDA0", Offset = "0x2AAD1A0", Length = "0xAF")]
	[Token(Token = "0x6000D4A")]
	public static bool3x2 op_Inequality(double3x2 lhs, double rhs) { }

	[Address(RVA = "0x2AAE050", Offset = "0x2AAD450", Length = "0x8D")]
	[Token(Token = "0x6000D38")]
	public static bool3x2 op_LessThan(double3x2 lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AADFD0", Offset = "0x2AAD3D0", Length = "0x7C")]
	[Token(Token = "0x6000D3A")]
	public static bool3x2 op_LessThan(double lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAE0E0", Offset = "0x2AAD4E0", Length = "0x70")]
	[Token(Token = "0x6000D39")]
	public static bool3x2 op_LessThan(double3x2 lhs, double rhs) { }

	[Address(RVA = "0x2AADEC0", Offset = "0x2AAD2C0", Length = "0x8D")]
	[Token(Token = "0x6000D3B")]
	public static bool3x2 op_LessThanOrEqual(double3x2 lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AADE50", Offset = "0x2AAD250", Length = "0x70")]
	[Token(Token = "0x6000D3C")]
	public static bool3x2 op_LessThanOrEqual(double3x2 lhs, double rhs) { }

	[Address(RVA = "0x2AADF50", Offset = "0x2AAD350", Length = "0x7C")]
	[Token(Token = "0x6000D3D")]
	public static bool3x2 op_LessThanOrEqual(double lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAE380", Offset = "0x2AAD780", Length = "0x102")]
	[Token(Token = "0x6000D35")]
	public static double3x2 op_Modulus(double lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAE280", Offset = "0x2AAD680", Length = "0xFF")]
	[Token(Token = "0x6000D34")]
	public static double3x2 op_Modulus(double3x2 lhs, double rhs) { }

	[Address(RVA = "0x2AAE150", Offset = "0x2AAD550", Length = "0x127")]
	[Token(Token = "0x6000D33")]
	public static double3x2 op_Modulus(double3x2 lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAE500", Offset = "0x2AAD900", Length = "0x6D")]
	[Token(Token = "0x6000D29")]
	public static double3x2 op_Multiply(double lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAE490", Offset = "0x2AAD890", Length = "0x69")]
	[Token(Token = "0x6000D28")]
	public static double3x2 op_Multiply(double3x2 lhs, double rhs) { }

	[Address(RVA = "0x2AAE570", Offset = "0x2AAD970", Length = "0x85")]
	[Token(Token = "0x6000D27")]
	public static double3x2 op_Multiply(double3x2 lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAE670", Offset = "0x2AADA70", Length = "0x78")]
	[Token(Token = "0x6000D2F")]
	public static double3x2 op_Subtraction(double lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAE600", Offset = "0x2AADA00", Length = "0x69")]
	[Token(Token = "0x6000D2E")]
	public static double3x2 op_Subtraction(double3x2 lhs, double rhs) { }

	[Address(RVA = "0x2AAE6F0", Offset = "0x2AADAF0", Length = "0x85")]
	[Token(Token = "0x6000D2D")]
	public static double3x2 op_Subtraction(double3x2 lhs, double3x2 rhs) { }

	[Address(RVA = "0x2AAE780", Offset = "0x2AADB80", Length = "0x68")]
	[Token(Token = "0x6000D44")]
	public static double3x2 op_UnaryNegation(double3x2 val) { }

	[Address(RVA = "0x2AAE7F0", Offset = "0x2AADBF0", Length = "0x47")]
	[Token(Token = "0x6000D45")]
	public static double3x2 op_UnaryPlus(double3x2 val) { }

	[Address(RVA = "0x2AACC50", Offset = "0x2AAC050", Length = "0x2D8")]
	[Token(Token = "0x6000D50")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AAC980", Offset = "0x2AABD80", Length = "0x2C6")]
	[Token(Token = "0x6000D51")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

