namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000025")]
public struct double4x2 : IEquatable<double4x2>, IFormattable
{
	[Token(Token = "0x400009B")]
	public static readonly double4x2 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000099")]
	public double4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009A")]
	public double4 c1; //Field offset: 0x20

	[Token(Token = "0x170003D8")]
	public double4 Item
	{
		[Address(RVA = "0x9D75B0", Offset = "0x9D69B0", Length = "0xB")]
		[Token(Token = "0x6000FE1")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2ABCDB0", Offset = "0x2ABC1B0", Length = "0x20")]
	[Token(Token = "0x6000FA8")]
	public double4x2(double4 c0, double4 c1) { }

	[Address(RVA = "0x2ABCD70", Offset = "0x2ABC170", Length = "0x35")]
	[Token(Token = "0x6000FB1")]
	public double4x2(float v) { }

	[Address(RVA = "0x2ABCCA0", Offset = "0x2ABC0A0", Length = "0x92")]
	[Token(Token = "0x6000FB0")]
	public double4x2(uint4x2 v) { }

	[Address(RVA = "0x2ABCB10", Offset = "0x2ABBF10", Length = "0x70")]
	[Token(Token = "0x6000FAF")]
	public double4x2(uint v) { }

	[Address(RVA = "0x2ABCB80", Offset = "0x2ABBF80", Length = "0x82")]
	[Token(Token = "0x6000FAE")]
	public double4x2(int4x2 v) { }

	[Address(RVA = "0x2ABCDD0", Offset = "0x2ABC1D0", Length = "0x7D")]
	[Token(Token = "0x6000FB2")]
	public double4x2(float4x2 v) { }

	[Address(RVA = "0x2A184C0", Offset = "0x2A178C0", Length = "0xA3")]
	[Token(Token = "0x6000FAC")]
	public double4x2(bool4x2 v) { }

	[Address(RVA = "0x2ABCC10", Offset = "0x2ABC010", Length = "0x3B")]
	[Token(Token = "0x6000FAB")]
	public double4x2(bool v) { }

	[Address(RVA = "0x2ABCD40", Offset = "0x2ABC140", Length = "0x29")]
	[Token(Token = "0x6000FAA")]
	public double4x2(double v) { }

	[Address(RVA = "0x2ABCC50", Offset = "0x2ABC050", Length = "0x41")]
	[Token(Token = "0x6000FA9")]
	public double4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31) { }

	[Address(RVA = "0x2ABCE50", Offset = "0x2ABC250", Length = "0x44")]
	[Token(Token = "0x6000FAD")]
	public double4x2(int v) { }

	[Address(RVA = "0x2ABC1D0", Offset = "0x2ABB5D0", Length = "0x114")]
	[Token(Token = "0x6000FE3")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2ABC2F0", Offset = "0x2ABB6F0", Length = "0x98")]
	[Token(Token = "0x6000FE2")]
	public override bool Equals(double4x2 rhs) { }

	[Address(RVA = "0x9D75B0", Offset = "0x9D69B0", Length = "0xB")]
	[Token(Token = "0x6000FE1")]
	public double4 get_Item(int index) { }

	[Address(RVA = "0x2ABC390", Offset = "0x2ABB790", Length = "0x38")]
	[Token(Token = "0x6000FE4")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2ABCEA0", Offset = "0x2ABC2A0", Length = "0x9C")]
	[Token(Token = "0x6000FC0")]
	public static double4x2 op_Addition(double4x2 lhs, double rhs) { }

	[Address(RVA = "0x2ABCF40", Offset = "0x2ABC340", Length = "0x9F")]
	[Token(Token = "0x6000FC1")]
	public static double4x2 op_Addition(double lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABCFE0", Offset = "0x2ABC3E0", Length = "0xCB")]
	[Token(Token = "0x6000FBF")]
	public static double4x2 op_Addition(double4x2 lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABD0B0", Offset = "0x2ABC4B0", Length = "0x8D")]
	[Token(Token = "0x6000FCC")]
	public static double4x2 op_Decrement(double4x2 val) { }

	[Address(RVA = "0x2ABD140", Offset = "0x2ABC540", Length = "0x9C")]
	[Token(Token = "0x6000FC6")]
	public static double4x2 op_Division(double4x2 lhs, double rhs) { }

	[Address(RVA = "0x2ABD1E0", Offset = "0x2ABC5E0", Length = "0xCD")]
	[Token(Token = "0x6000FC5")]
	public static double4x2 op_Division(double4x2 lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABD2B0", Offset = "0x2ABC6B0", Length = "0xBA")]
	[Token(Token = "0x6000FC7")]
	public static double4x2 op_Division(double lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABD370", Offset = "0x2ABC770", Length = "0x11C")]
	[Token(Token = "0x6000FDC")]
	public static bool4x2 op_Equality(double4x2 lhs, double rhs) { }

	[Address(RVA = "0x2ABD490", Offset = "0x2ABC890", Length = "0x14C")]
	[Token(Token = "0x6000FDB")]
	public static bool4x2 op_Equality(double4x2 lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABD5E0", Offset = "0x2ABC9E0", Length = "0x11F")]
	[Token(Token = "0x6000FDD")]
	public static bool4x2 op_Equality(double lhs, double4x2 rhs) { }

	[Address(RVA = "0x2A2F960", Offset = "0x2A2ED60", Length = "0x41")]
	[Token(Token = "0x6000FB4")]
	public static double4x2 op_Explicit(bool v) { }

	[Address(RVA = "0x2ABD700", Offset = "0x2ABCB00", Length = "0x2C")]
	[Token(Token = "0x6000FB5")]
	public static double4x2 op_Explicit(bool4x2 v) { }

	[Address(RVA = "0x2ABDB10", Offset = "0x2ABCF10", Length = "0xDF")]
	[Token(Token = "0x6000FD3")]
	public static bool4x2 op_GreaterThan(double4x2 lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABD990", Offset = "0x2ABCD90", Length = "0xC0")]
	[Token(Token = "0x6000FD4")]
	public static bool4x2 op_GreaterThan(double4x2 lhs, double rhs) { }

	[Address(RVA = "0x2ABDA50", Offset = "0x2ABCE50", Length = "0xC0")]
	[Token(Token = "0x6000FD5")]
	public static bool4x2 op_GreaterThan(double lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABD8B0", Offset = "0x2ABCCB0", Length = "0xDF")]
	[Token(Token = "0x6000FD6")]
	public static bool4x2 op_GreaterThanOrEqual(double4x2 lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABD730", Offset = "0x2ABCB30", Length = "0xC0")]
	[Token(Token = "0x6000FD7")]
	public static bool4x2 op_GreaterThanOrEqual(double4x2 lhs, double rhs) { }

	[Address(RVA = "0x2ABD7F0", Offset = "0x2ABCBF0", Length = "0xC0")]
	[Token(Token = "0x6000FD8")]
	public static bool4x2 op_GreaterThanOrEqual(double lhs, double4x2 rhs) { }

	[Address(RVA = "0x2A2FA30", Offset = "0x2A2EE30", Length = "0x88")]
	[Token(Token = "0x6000FBB")]
	public static double4x2 op_Implicit(float4x2 v) { }

	[Address(RVA = "0x2A2F850", Offset = "0x2A2EC50", Length = "0x8A")]
	[Token(Token = "0x6000FB7")]
	public static double4x2 op_Implicit(int4x2 v) { }

	[Address(RVA = "0x2A2F8E0", Offset = "0x2A2ECE0", Length = "0x2C")]
	[Token(Token = "0x6000FB3")]
	public static double4x2 op_Implicit(double v) { }

	[Address(RVA = "0x2A2F9B0", Offset = "0x2A2EDB0", Length = "0x73")]
	[Token(Token = "0x6000FB8")]
	public static double4x2 op_Implicit(uint v) { }

	[Address(RVA = "0x2A2FBC0", Offset = "0x2A2EFC0", Length = "0x9A")]
	[Token(Token = "0x6000FB9")]
	public static double4x2 op_Implicit(uint4x2 v) { }

	[Address(RVA = "0x2A2F910", Offset = "0x2A2ED10", Length = "0x47")]
	[Token(Token = "0x6000FB6")]
	public static double4x2 op_Implicit(int v) { }

	[Address(RVA = "0x2A2F7E0", Offset = "0x2A2EBE0", Length = "0x38")]
	[Token(Token = "0x6000FBA")]
	public static double4x2 op_Implicit(float v) { }

	[Address(RVA = "0x2ABDBF0", Offset = "0x2ABCFF0", Length = "0x8D")]
	[Token(Token = "0x6000FCB")]
	public static double4x2 op_Increment(double4x2 val) { }

	[Address(RVA = "0x2ABDDA0", Offset = "0x2ABD1A0", Length = "0x14C")]
	[Token(Token = "0x6000FDE")]
	public static bool4x2 op_Inequality(double4x2 lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABDEF0", Offset = "0x2ABD2F0", Length = "0x11F")]
	[Token(Token = "0x6000FE0")]
	public static bool4x2 op_Inequality(double lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABDC80", Offset = "0x2ABD080", Length = "0x11C")]
	[Token(Token = "0x6000FDF")]
	public static bool4x2 op_Inequality(double4x2 lhs, double rhs) { }

	[Address(RVA = "0x2ABE270", Offset = "0x2ABD670", Length = "0xDF")]
	[Token(Token = "0x6000FCD")]
	public static bool4x2 op_LessThan(double4x2 lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABE410", Offset = "0x2ABD810", Length = "0xC0")]
	[Token(Token = "0x6000FCF")]
	public static bool4x2 op_LessThan(double lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABE350", Offset = "0x2ABD750", Length = "0xC0")]
	[Token(Token = "0x6000FCE")]
	public static bool4x2 op_LessThan(double4x2 lhs, double rhs) { }

	[Address(RVA = "0x2ABE190", Offset = "0x2ABD590", Length = "0xDF")]
	[Token(Token = "0x6000FD0")]
	public static bool4x2 op_LessThanOrEqual(double4x2 lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABE010", Offset = "0x2ABD410", Length = "0xC0")]
	[Token(Token = "0x6000FD1")]
	public static bool4x2 op_LessThanOrEqual(double4x2 lhs, double rhs) { }

	[Address(RVA = "0x2ABE0D0", Offset = "0x2ABD4D0", Length = "0xC0")]
	[Token(Token = "0x6000FD2")]
	public static bool4x2 op_LessThanOrEqual(double lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABE4D0", Offset = "0x2ABD8D0", Length = "0x149")]
	[Token(Token = "0x6000FCA")]
	public static double4x2 op_Modulus(double lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABE620", Offset = "0x2ABDA20", Length = "0x146")]
	[Token(Token = "0x6000FC9")]
	public static double4x2 op_Modulus(double4x2 lhs, double rhs) { }

	[Address(RVA = "0x2ABE770", Offset = "0x2ABDB70", Length = "0x175")]
	[Token(Token = "0x6000FC8")]
	public static double4x2 op_Modulus(double4x2 lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABE8F0", Offset = "0x2ABDCF0", Length = "0x9F")]
	[Token(Token = "0x6000FBE")]
	public static double4x2 op_Multiply(double lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABEA60", Offset = "0x2ABDE60", Length = "0x9C")]
	[Token(Token = "0x6000FBD")]
	public static double4x2 op_Multiply(double4x2 lhs, double rhs) { }

	[Address(RVA = "0x2ABE990", Offset = "0x2ABDD90", Length = "0xCB")]
	[Token(Token = "0x6000FBC")]
	public static double4x2 op_Multiply(double4x2 lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABEBA0", Offset = "0x2ABDFA0", Length = "0xBA")]
	[Token(Token = "0x6000FC4")]
	public static double4x2 op_Subtraction(double lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABEB00", Offset = "0x2ABDF00", Length = "0x9C")]
	[Token(Token = "0x6000FC3")]
	public static double4x2 op_Subtraction(double4x2 lhs, double rhs) { }

	[Address(RVA = "0x2ABEC60", Offset = "0x2ABE060", Length = "0xCD")]
	[Token(Token = "0x6000FC2")]
	public static double4x2 op_Subtraction(double4x2 lhs, double4x2 rhs) { }

	[Address(RVA = "0x2ABED30", Offset = "0x2ABE130", Length = "0x99")]
	[Token(Token = "0x6000FD9")]
	public static double4x2 op_UnaryNegation(double4x2 val) { }

	[Address(RVA = "0x2ABEDD0", Offset = "0x2ABE1D0", Length = "0x71")]
	[Token(Token = "0x6000FDA")]
	public static double4x2 op_UnaryPlus(double4x2 val) { }

	[Address(RVA = "0x2ABC750", Offset = "0x2ABBB50", Length = "0x3B0")]
	[Token(Token = "0x6000FE5")]
	public virtual string ToString() { }

	[Address(RVA = "0x2ABC3D0", Offset = "0x2ABB7D0", Length = "0x37E")]
	[Token(Token = "0x6000FE6")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

