namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200001C")]
public struct double2x3 : IEquatable<double2x3>, IFormattable
{
	[Token(Token = "0x4000076")]
	public static readonly double2x3 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000073")]
	public double2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000074")]
	public double2 c1; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000075")]
	public double2 c2; //Field offset: 0x20

	[Token(Token = "0x1700020C")]
	public double2 Item
	{
		[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
		[Token(Token = "0x6000C06")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x1311590", Offset = "0x1310990", Length = "0x17")]
	[Token(Token = "0x6000BCD")]
	public double2x3(double2 c0, double2 c1, double2 c2) { }

	[Address(RVA = "0x2AA7150", Offset = "0x2AA6550", Length = "0x3E")]
	[Token(Token = "0x6000BD6")]
	public double2x3(float v) { }

	[Address(RVA = "0x2AA7010", Offset = "0x2AA6410", Length = "0x72")]
	[Token(Token = "0x6000BD5")]
	public double2x3(uint2x3 v) { }

	[Address(RVA = "0x2AA7220", Offset = "0x2AA6620", Length = "0x5A")]
	[Token(Token = "0x6000BD4")]
	public double2x3(uint v) { }

	[Address(RVA = "0x2AA6FA0", Offset = "0x2AA63A0", Length = "0x65")]
	[Token(Token = "0x6000BD3")]
	public double2x3(int2x3 v) { }

	[Address(RVA = "0x2AA71C0", Offset = "0x2AA65C0", Length = "0x57")]
	[Token(Token = "0x6000BD7")]
	public double2x3(float2x3 v) { }

	[Address(RVA = "0x2AA70D0", Offset = "0x2AA64D0", Length = "0x80")]
	[Token(Token = "0x6000BD1")]
	public double2x3(bool2x3 v) { }

	[Address(RVA = "0x2AA70A0", Offset = "0x2AA64A0", Length = "0x2A")]
	[Token(Token = "0x6000BD0")]
	public double2x3(bool v) { }

	[Address(RVA = "0x2AA7090", Offset = "0x2AA6490", Length = "0x10")]
	[Token(Token = "0x6000BCF")]
	public double2x3(double v) { }

	[Address(RVA = "0x2AA7190", Offset = "0x2AA6590", Length = "0x30")]
	[Token(Token = "0x6000BCE")]
	public double2x3(double m00, double m01, double m02, double m10, double m11, double m12) { }

	[Address(RVA = "0x2AA7280", Offset = "0x2AA6680", Length = "0x45")]
	[Token(Token = "0x6000BD2")]
	public double2x3(int v) { }

	[Address(RVA = "0x2AA68D0", Offset = "0x2AA5CD0", Length = "0xEA")]
	[Token(Token = "0x6000C08")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AA6850", Offset = "0x2AA5C50", Length = "0x76")]
	[Token(Token = "0x6000C07")]
	public override bool Equals(double2x3 rhs) { }

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x6000C06")]
	public double2 get_Item(int index) { }

	[Address(RVA = "0x2AA69C0", Offset = "0x2AA5DC0", Length = "0x2F")]
	[Token(Token = "0x6000C09")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AA7320", Offset = "0x2AA6720", Length = "0x3B")]
	[Token(Token = "0x6000BE5")]
	public static double2x3 op_Addition(double2x3 lhs, double rhs) { }

	[Address(RVA = "0x2AA72D0", Offset = "0x2AA66D0", Length = "0x4D")]
	[Token(Token = "0x6000BE6")]
	public static double2x3 op_Addition(double lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7360", Offset = "0x2AA6760", Length = "0x67")]
	[Token(Token = "0x6000BE4")]
	public static double2x3 op_Addition(double2x3 lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA73D0", Offset = "0x2AA67D0", Length = "0x70")]
	[Token(Token = "0x6000BF1")]
	public static double2x3 op_Decrement(double2x3 val) { }

	[Address(RVA = "0x2AA7440", Offset = "0x2AA6840", Length = "0x3B")]
	[Token(Token = "0x6000BEB")]
	public static double2x3 op_Division(double2x3 lhs, double rhs) { }

	[Address(RVA = "0x2AA74E0", Offset = "0x2AA68E0", Length = "0x67")]
	[Token(Token = "0x6000BEA")]
	public static double2x3 op_Division(double2x3 lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7480", Offset = "0x2AA6880", Length = "0x58")]
	[Token(Token = "0x6000BEC")]
	public static double2x3 op_Division(double lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7550", Offset = "0x2AA6950", Length = "0xAE")]
	[Token(Token = "0x6000C01")]
	public static bool2x3 op_Equality(double2x3 lhs, double rhs) { }

	[Address(RVA = "0x2AA76A0", Offset = "0x2AA6AA0", Length = "0xC1")]
	[Token(Token = "0x6000C00")]
	public static bool2x3 op_Equality(double2x3 lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7600", Offset = "0x2AA6A00", Length = "0xA0")]
	[Token(Token = "0x6000C02")]
	public static bool2x3 op_Equality(double lhs, double2x3 rhs) { }

	[Address(RVA = "0x2A2D2B0", Offset = "0x2A2C6B0", Length = "0x30")]
	[Token(Token = "0x6000BD9")]
	public static double2x3 op_Explicit(bool v) { }

	[Address(RVA = "0x2A2D400", Offset = "0x2A2C800", Length = "0xB1")]
	[Token(Token = "0x6000BDA")]
	public static double2x3 op_Explicit(bool2x3 v) { }

	[Address(RVA = "0x2AA79B0", Offset = "0x2AA6DB0", Length = "0x7F")]
	[Token(Token = "0x6000BF8")]
	public static bool2x3 op_GreaterThan(double2x3 lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7940", Offset = "0x2AA6D40", Length = "0x6F")]
	[Token(Token = "0x6000BF9")]
	public static bool2x3 op_GreaterThan(double2x3 lhs, double rhs) { }

	[Address(RVA = "0x2AA78D0", Offset = "0x2AA6CD0", Length = "0x64")]
	[Token(Token = "0x6000BFA")]
	public static bool2x3 op_GreaterThan(double lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7770", Offset = "0x2AA6B70", Length = "0x7F")]
	[Token(Token = "0x6000BFB")]
	public static bool2x3 op_GreaterThanOrEqual(double2x3 lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7860", Offset = "0x2AA6C60", Length = "0x6F")]
	[Token(Token = "0x6000BFC")]
	public static bool2x3 op_GreaterThanOrEqual(double2x3 lhs, double rhs) { }

	[Address(RVA = "0x2AA77F0", Offset = "0x2AA6BF0", Length = "0x64")]
	[Token(Token = "0x6000BFD")]
	public static bool2x3 op_GreaterThanOrEqual(double lhs, double2x3 rhs) { }

	[Address(RVA = "0x2A2D230", Offset = "0x2A2C630", Length = "0x74")]
	[Token(Token = "0x6000BE0")]
	public static double2x3 op_Implicit(float2x3 v) { }

	[Address(RVA = "0x2A2D4C0", Offset = "0x2A2C8C0", Length = "0xA6")]
	[Token(Token = "0x6000BDC")]
	public static double2x3 op_Implicit(int2x3 v) { }

	[Address(RVA = "0x2A2D210", Offset = "0x2A2C610", Length = "0x13")]
	[Token(Token = "0x6000BD8")]
	public static double2x3 op_Implicit(double v) { }

	[Address(RVA = "0x2A2D160", Offset = "0x2A2C560", Length = "0x5D")]
	[Token(Token = "0x6000BDD")]
	public static double2x3 op_Implicit(uint v) { }

	[Address(RVA = "0x2A2D340", Offset = "0x2A2C740", Length = "0xB2")]
	[Token(Token = "0x6000BDE")]
	public static double2x3 op_Implicit(uint2x3 v) { }

	[Address(RVA = "0x2A2D2E0", Offset = "0x2A2C6E0", Length = "0x51")]
	[Token(Token = "0x6000BDB")]
	public static double2x3 op_Implicit(int v) { }

	[Address(RVA = "0x2A2D1C0", Offset = "0x2A2C5C0", Length = "0x4B")]
	[Token(Token = "0x6000BDF")]
	public static double2x3 op_Implicit(float v) { }

	[Address(RVA = "0x2AA7A30", Offset = "0x2AA6E30", Length = "0x70")]
	[Token(Token = "0x6000BF0")]
	public static double2x3 op_Increment(double2x3 val) { }

	[Address(RVA = "0x2AA7B50", Offset = "0x2AA6F50", Length = "0xC1")]
	[Token(Token = "0x6000C03")]
	public static bool2x3 op_Inequality(double2x3 lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7C20", Offset = "0x2AA7020", Length = "0xA0")]
	[Token(Token = "0x6000C05")]
	public static bool2x3 op_Inequality(double lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7AA0", Offset = "0x2AA6EA0", Length = "0xAE")]
	[Token(Token = "0x6000C04")]
	public static bool2x3 op_Inequality(double2x3 lhs, double rhs) { }

	[Address(RVA = "0x2AA7EA0", Offset = "0x2AA72A0", Length = "0x7F")]
	[Token(Token = "0x6000BF2")]
	public static bool2x3 op_LessThan(double2x3 lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7E20", Offset = "0x2AA7220", Length = "0x77")]
	[Token(Token = "0x6000BF4")]
	public static bool2x3 op_LessThan(double lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7F20", Offset = "0x2AA7320", Length = "0x5F")]
	[Token(Token = "0x6000BF3")]
	public static bool2x3 op_LessThan(double2x3 lhs, double rhs) { }

	[Address(RVA = "0x2AA7DA0", Offset = "0x2AA71A0", Length = "0x7F")]
	[Token(Token = "0x6000BF5")]
	public static bool2x3 op_LessThanOrEqual(double2x3 lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7CC0", Offset = "0x2AA70C0", Length = "0x5F")]
	[Token(Token = "0x6000BF6")]
	public static bool2x3 op_LessThanOrEqual(double2x3 lhs, double rhs) { }

	[Address(RVA = "0x2AA7D20", Offset = "0x2AA7120", Length = "0x77")]
	[Token(Token = "0x6000BF7")]
	public static bool2x3 op_LessThanOrEqual(double lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA7F80", Offset = "0x2AA7380", Length = "0xA4")]
	[Token(Token = "0x6000BEF")]
	public static double2x3 op_Modulus(double lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA80F0", Offset = "0x2AA74F0", Length = "0xA3")]
	[Token(Token = "0x6000BEE")]
	public static double2x3 op_Modulus(double2x3 lhs, double rhs) { }

	[Address(RVA = "0x2AA8030", Offset = "0x2AA7430", Length = "0xBD")]
	[Token(Token = "0x6000BED")]
	public static double2x3 op_Modulus(double2x3 lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA81A0", Offset = "0x2AA75A0", Length = "0x4D")]
	[Token(Token = "0x6000BE3")]
	public static double2x3 op_Multiply(double lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA8260", Offset = "0x2AA7660", Length = "0x3B")]
	[Token(Token = "0x6000BE2")]
	public static double2x3 op_Multiply(double2x3 lhs, double rhs) { }

	[Address(RVA = "0x2AA81F0", Offset = "0x2AA75F0", Length = "0x67")]
	[Token(Token = "0x6000BE1")]
	public static double2x3 op_Multiply(double2x3 lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA82E0", Offset = "0x2AA76E0", Length = "0x58")]
	[Token(Token = "0x6000BE9")]
	public static double2x3 op_Subtraction(double lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA82A0", Offset = "0x2AA76A0", Length = "0x3B")]
	[Token(Token = "0x6000BE8")]
	public static double2x3 op_Subtraction(double2x3 lhs, double rhs) { }

	[Address(RVA = "0x2AA8340", Offset = "0x2AA7740", Length = "0x67")]
	[Token(Token = "0x6000BE7")]
	public static double2x3 op_Subtraction(double2x3 lhs, double2x3 rhs) { }

	[Address(RVA = "0x2AA83B0", Offset = "0x2AA77B0", Length = "0x3A")]
	[Token(Token = "0x6000BFE")]
	public static double2x3 op_UnaryNegation(double2x3 val) { }

	[Address(RVA = "0x2AA83F0", Offset = "0x2AA77F0", Length = "0x37")]
	[Token(Token = "0x6000BFF")]
	public static double2x3 op_UnaryPlus(double2x3 val) { }

	[Address(RVA = "0x2AA6CC0", Offset = "0x2AA60C0", Length = "0x2D8")]
	[Token(Token = "0x6000C0A")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AA69F0", Offset = "0x2AA5DF0", Length = "0x2C6")]
	[Token(Token = "0x6000C0B")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

