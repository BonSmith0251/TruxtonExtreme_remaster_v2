namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000021")]
public struct double3x3 : IEquatable<double3x3>, IFormattable
{
	[Token(Token = "0x4000089")]
	public static readonly double3x3 identity; //Field offset: 0x0
	[Token(Token = "0x400008A")]
	public static readonly double3x3 zero; //Field offset: 0x48
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000086")]
	public double3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000087")]
	public double3 c1; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000088")]
	public double3 c2; //Field offset: 0x30

	[Token(Token = "0x17000285")]
	public double3 Item
	{
		[Address(RVA = "0x9D7550", Offset = "0x9D6950", Length = "0xC")]
		[Token(Token = "0x6000D8B")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x2AAF150", Offset = "0x2AAE550", Length = "0x5D")]
	[Token(Token = "0x6000D91")]
	private static double3x3() { }

	[Address(RVA = "0x2AAF320", Offset = "0x2AAE720", Length = "0x94")]
	[Token(Token = "0x6000D5C")]
	public double3x3(float3x3 v) { }

	[Address(RVA = "0x2AAF1B0", Offset = "0x2AAE5B0", Length = "0x59")]
	[Token(Token = "0x6000D5B")]
	public double3x3(float v) { }

	[Address(RVA = "0x2AAF3C0", Offset = "0x2AAE7C0", Length = "0xDD")]
	[Token(Token = "0x6000D5A")]
	public double3x3(uint3x3 v) { }

	[Address(RVA = "0x2AAF290", Offset = "0x2AAE690", Length = "0x89")]
	[Token(Token = "0x6000D59")]
	public double3x3(uint v) { }

	[Address(RVA = "0x2AAF510", Offset = "0x2AAE910", Length = "0xD1")]
	[Token(Token = "0x6000D58")]
	public double3x3(int3x3 v) { }

	[Address(RVA = "0x2AAF210", Offset = "0x2AAE610", Length = "0x37")]
	[Token(Token = "0x6000D52")]
	public double3x3(double3 c0, double3 c1, double3 c2) { }

	[Address(RVA = "0x2A17C70", Offset = "0x2A17070", Length = "0xD6")]
	[Token(Token = "0x6000D56")]
	public double3x3(bool3x3 v) { }

	[Address(RVA = "0x2AAF5F0", Offset = "0x2AAE9F0", Length = "0x7D")]
	[Token(Token = "0x6000D55")]
	public double3x3(bool v) { }

	[Address(RVA = "0x2AAF250", Offset = "0x2AAE650", Length = "0x38")]
	[Token(Token = "0x6000D54")]
	public double3x3(double v) { }

	[Address(RVA = "0x2AAF670", Offset = "0x2AAEA70", Length = "0x56")]
	[Token(Token = "0x6000D53")]
	public double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22) { }

	[Address(RVA = "0x2AAF4A0", Offset = "0x2AAE8A0", Length = "0x62")]
	[Token(Token = "0x6000D57")]
	public double3x3(int v) { }

	[Address(RVA = "0x2AAE840", Offset = "0x2AADC40", Length = "0xBC")]
	[Token(Token = "0x6000D8D")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2A9FAD0", Offset = "0x2A9EED0", Length = "0x8CA")]
	[Token(Token = "0x6000D8C")]
	public override bool Equals(double3x3 rhs) { }

	[Address(RVA = "0x9D7550", Offset = "0x9D6950", Length = "0xC")]
	[Token(Token = "0x6000D8B")]
	public double3 get_Item(int index) { }

	[Address(RVA = "0x2AAE900", Offset = "0x2AADD00", Length = "0x43")]
	[Token(Token = "0x6000D8E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AAF7D0", Offset = "0x2AAEBD0", Length = "0xC0")]
	[Token(Token = "0x6000D6B")]
	public static double3x3 op_Addition(double lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AAF890", Offset = "0x2AAEC90", Length = "0xBE")]
	[Token(Token = "0x6000D6A")]
	public static double3x3 op_Addition(double3x3 lhs, double rhs) { }

	[Address(RVA = "0x2AAF6D0", Offset = "0x2AAEAD0", Length = "0xF4")]
	[Token(Token = "0x6000D69")]
	public static double3x3 op_Addition(double3x3 lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AAF950", Offset = "0x2AAED50", Length = "0xDF")]
	[Token(Token = "0x6000D76")]
	public static double3x3 op_Decrement(double3x3 val) { }

	[Address(RVA = "0x2AAFB30", Offset = "0x2AAEF30", Length = "0xBE")]
	[Token(Token = "0x6000D70")]
	public static double3x3 op_Division(double3x3 lhs, double rhs) { }

	[Address(RVA = "0x2AAFA30", Offset = "0x2AAEE30", Length = "0xF5")]
	[Token(Token = "0x6000D6F")]
	public static double3x3 op_Division(double3x3 lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AAFBF0", Offset = "0x2AAEFF0", Length = "0xDD")]
	[Token(Token = "0x6000D71")]
	public static double3x3 op_Division(double lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AAFF20", Offset = "0x2AAF320", Length = "0x104")]
	[Token(Token = "0x6000D87")]
	public static bool3x3 op_Equality(double lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AAFDE0", Offset = "0x2AAF1E0", Length = "0x133")]
	[Token(Token = "0x6000D85")]
	public static bool3x3 op_Equality(double3x3 lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AAFCD0", Offset = "0x2AAF0D0", Length = "0x104")]
	[Token(Token = "0x6000D86")]
	public static bool3x3 op_Equality(double3x3 lhs, double rhs) { }

	[Address(RVA = "0x2A2E920", Offset = "0x2A2DD20", Length = "0x83")]
	[Token(Token = "0x6000D5E")]
	public static double3x3 op_Explicit(bool v) { }

	[Address(RVA = "0x2AB0030", Offset = "0x2AAF430", Length = "0x49")]
	[Token(Token = "0x6000D5F")]
	public static double3x3 op_Explicit(bool3x3 v) { }

	[Address(RVA = "0x2AB0370", Offset = "0x2AAF770", Length = "0xA2")]
	[Token(Token = "0x6000D7F")]
	public static bool3x3 op_GreaterThan(double lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB0420", Offset = "0x2AAF820", Length = "0xD7")]
	[Token(Token = "0x6000D7D")]
	public static bool3x3 op_GreaterThan(double3x3 lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB02C0", Offset = "0x2AAF6C0", Length = "0xAB")]
	[Token(Token = "0x6000D7E")]
	public static bool3x3 op_GreaterThan(double3x3 lhs, double rhs) { }

	[Address(RVA = "0x2AB0080", Offset = "0x2AAF480", Length = "0xA2")]
	[Token(Token = "0x6000D82")]
	public static bool3x3 op_GreaterThanOrEqual(double lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB0210", Offset = "0x2AAF610", Length = "0xAB")]
	[Token(Token = "0x6000D81")]
	public static bool3x3 op_GreaterThanOrEqual(double3x3 lhs, double rhs) { }

	[Address(RVA = "0x2AB0130", Offset = "0x2AAF530", Length = "0xD7")]
	[Token(Token = "0x6000D80")]
	public static bool3x3 op_GreaterThanOrEqual(double3x3 lhs, double3x3 rhs) { }

	[Address(RVA = "0x2A2E9F0", Offset = "0x2A2DDF0", Length = "0xDF")]
	[Token(Token = "0x6000D63")]
	public static double3x3 op_Implicit(uint3x3 v) { }

	[Address(RVA = "0x2A2E8B0", Offset = "0x2A2DCB0", Length = "0x65")]
	[Token(Token = "0x6000D60")]
	public static double3x3 op_Implicit(int v) { }

	[Address(RVA = "0x2A2E650", Offset = "0x2A2DA50", Length = "0x93")]
	[Token(Token = "0x6000D65")]
	public static double3x3 op_Implicit(float3x3 v) { }

	[Address(RVA = "0x2A2EAD0", Offset = "0x2A2DED0", Length = "0x3B")]
	[Token(Token = "0x6000D5D")]
	public static double3x3 op_Implicit(double v) { }

	[Address(RVA = "0x2A2E750", Offset = "0x2A2DB50", Length = "0x8C")]
	[Token(Token = "0x6000D62")]
	public static double3x3 op_Implicit(uint v) { }

	[Address(RVA = "0x2A2E7E0", Offset = "0x2A2DBE0", Length = "0xCF")]
	[Token(Token = "0x6000D61")]
	public static double3x3 op_Implicit(int3x3 v) { }

	[Address(RVA = "0x2A2E510", Offset = "0x2A2D910", Length = "0x5C")]
	[Token(Token = "0x6000D64")]
	public static double3x3 op_Implicit(float v) { }

	[Address(RVA = "0x2AB0500", Offset = "0x2AAF900", Length = "0xDF")]
	[Token(Token = "0x6000D75")]
	public static double3x3 op_Increment(double3x3 val) { }

	[Address(RVA = "0x2AB0830", Offset = "0x2AAFC30", Length = "0x104")]
	[Token(Token = "0x6000D8A")]
	public static bool3x3 op_Inequality(double lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB0720", Offset = "0x2AAFB20", Length = "0x104")]
	[Token(Token = "0x6000D89")]
	public static bool3x3 op_Inequality(double3x3 lhs, double rhs) { }

	[Address(RVA = "0x2AB05E0", Offset = "0x2AAF9E0", Length = "0x133")]
	[Token(Token = "0x6000D88")]
	public static bool3x3 op_Inequality(double3x3 lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB0D20", Offset = "0x2AB0120", Length = "0xB1")]
	[Token(Token = "0x6000D79")]
	public static bool3x3 op_LessThan(double lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB0B90", Offset = "0x2AAFF90", Length = "0xA3")]
	[Token(Token = "0x6000D78")]
	public static bool3x3 op_LessThan(double3x3 lhs, double rhs) { }

	[Address(RVA = "0x2AB0C40", Offset = "0x2AB0040", Length = "0xDB")]
	[Token(Token = "0x6000D77")]
	public static bool3x3 op_LessThan(double3x3 lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB0940", Offset = "0x2AAFD40", Length = "0xB1")]
	[Token(Token = "0x6000D7C")]
	public static bool3x3 op_LessThanOrEqual(double lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB0A00", Offset = "0x2AAFE00", Length = "0xDB")]
	[Token(Token = "0x6000D7A")]
	public static bool3x3 op_LessThanOrEqual(double3x3 lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB0AE0", Offset = "0x2AAFEE0", Length = "0xA3")]
	[Token(Token = "0x6000D7B")]
	public static bool3x3 op_LessThanOrEqual(double3x3 lhs, double rhs) { }

	[Address(RVA = "0x2AB0F70", Offset = "0x2AB0370", Length = "0x1B1")]
	[Token(Token = "0x6000D72")]
	public static double3x3 op_Modulus(double3x3 lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB1130", Offset = "0x2AB0530", Length = "0x184")]
	[Token(Token = "0x6000D74")]
	public static double3x3 op_Modulus(double lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB0DE0", Offset = "0x2AB01E0", Length = "0x181")]
	[Token(Token = "0x6000D73")]
	public static double3x3 op_Modulus(double3x3 lhs, double rhs) { }

	[Address(RVA = "0x2AB12C0", Offset = "0x2AB06C0", Length = "0xC0")]
	[Token(Token = "0x6000D68")]
	public static double3x3 op_Multiply(double lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB1380", Offset = "0x2AB0780", Length = "0xF4")]
	[Token(Token = "0x6000D66")]
	public static double3x3 op_Multiply(double3x3 lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB1480", Offset = "0x2AB0880", Length = "0xBE")]
	[Token(Token = "0x6000D67")]
	public static double3x3 op_Multiply(double3x3 lhs, double rhs) { }

	[Address(RVA = "0x2AB1540", Offset = "0x2AB0940", Length = "0xDD")]
	[Token(Token = "0x6000D6E")]
	public static double3x3 op_Subtraction(double lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB1720", Offset = "0x2AB0B20", Length = "0xBE")]
	[Token(Token = "0x6000D6D")]
	public static double3x3 op_Subtraction(double3x3 lhs, double rhs) { }

	[Address(RVA = "0x2AB1620", Offset = "0x2AB0A20", Length = "0xF5")]
	[Token(Token = "0x6000D6C")]
	public static double3x3 op_Subtraction(double3x3 lhs, double3x3 rhs) { }

	[Address(RVA = "0x2AB17E0", Offset = "0x2AB0BE0", Length = "0xB8")]
	[Token(Token = "0x6000D83")]
	public static double3x3 op_UnaryNegation(double3x3 val) { }

	[Address(RVA = "0x2AB18A0", Offset = "0x2AB0CA0", Length = "0x89")]
	[Token(Token = "0x6000D84")]
	public static double3x3 op_UnaryPlus(double3x3 val) { }

	[Address(RVA = "0x2AAED70", Offset = "0x2AAE170", Length = "0x3DA")]
	[Token(Token = "0x6000D90")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x2AAE950", Offset = "0x2AADD50", Length = "0x416")]
	[Token(Token = "0x6000D8F")]
	public virtual string ToString() { }

}

