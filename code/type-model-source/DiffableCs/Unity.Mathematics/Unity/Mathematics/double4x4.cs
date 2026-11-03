namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000027")]
public struct double4x4 : IEquatable<double4x4>, IFormattable
{
	[Token(Token = "0x40000A4")]
	public static readonly double4x4 identity; //Field offset: 0x0
	[Token(Token = "0x40000A5")]
	public static readonly double4x4 zero; //Field offset: 0x80
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000A0")]
	public double4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A1")]
	public double4 c1; //Field offset: 0x20
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000A2")]
	public double4 c2; //Field offset: 0x40
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000A3")]
	public double4 c3; //Field offset: 0x60

	[Token(Token = "0x170003DA")]
	public double4 Item
	{
		[Address(RVA = "0x9D75B0", Offset = "0x9D69B0", Length = "0xB")]
		[Token(Token = "0x600105F")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2AC3930", Offset = "0x2AC2D30", Length = "0x6E")]
	[Token(Token = "0x6001065")]
	private static double4x4() { }

	[Address(RVA = "0x2A18720", Offset = "0x2A17B20", Length = "0xFB")]
	[Token(Token = "0x6001030")]
	public double4x4(float4x4 v) { }

	[Address(RVA = "0x2AC39A0", Offset = "0x2AC2DA0", Length = "0x70")]
	[Token(Token = "0x600102F")]
	public double4x4(float v) { }

	[Address(RVA = "0x2A18820", Offset = "0x2A17C20", Length = "0x122")]
	[Token(Token = "0x600102E")]
	public double4x4(uint4x4 v) { }

	[Address(RVA = "0x2A18950", Offset = "0x2A17D50", Length = "0xE0")]
	[Token(Token = "0x600102D")]
	public double4x4(uint v) { }

	[Address(RVA = "0x2A18B80", Offset = "0x2A17F80", Length = "0x106")]
	[Token(Token = "0x600102C")]
	public double4x4(int4x4 v) { }

	[Address(RVA = "0x2AC3AE0", Offset = "0x2AC2EE0", Length = "0x45")]
	[Token(Token = "0x6001026")]
	public double4x4(double4 c0, double4 c1, double4 c2, double4 c3) { }

	[Address(RVA = "0x2A18A30", Offset = "0x2A17E30", Length = "0x14D")]
	[Token(Token = "0x600102A")]
	public double4x4(bool4x4 v) { }

	[Address(RVA = "0x2AC3A70", Offset = "0x2AC2E70", Length = "0x6B")]
	[Token(Token = "0x6001029")]
	public double4x4(bool v) { }

	[Address(RVA = "0x2AC3A10", Offset = "0x2AC2E10", Length = "0x58")]
	[Token(Token = "0x6001028")]
	public double4x4(double v) { }

	[Address(RVA = "0x2AC3BC0", Offset = "0x2AC2FC0", Length = "0xC3")]
	[Token(Token = "0x6001027")]
	public double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33) { }

	[Address(RVA = "0x2AC3B30", Offset = "0x2AC2F30", Length = "0x88")]
	[Token(Token = "0x600102B")]
	public double4x4(int v) { }

	[Address(RVA = "0x2AC2A60", Offset = "0x2AC1E60", Length = "0xF0")]
	[Token(Token = "0x6001061")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AB3B00", Offset = "0x2AB2F00", Length = "0xED3")]
	[Token(Token = "0x6001060")]
	public override bool Equals(double4x4 rhs) { }

	[Address(RVA = "0x9D75B0", Offset = "0x9D69B0", Length = "0xB")]
	[Token(Token = "0x600105F")]
	public double4 get_Item(int index) { }

	[Address(RVA = "0x2AC2B60", Offset = "0x2AC1F60", Length = "0x5E")]
	[Token(Token = "0x6001062")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AC3C90", Offset = "0x2AC3090", Length = "0x187")]
	[Token(Token = "0x600103F")]
	public static double4x4 op_Addition(double lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC3E20", Offset = "0x2AC3220", Length = "0x186")]
	[Token(Token = "0x600103E")]
	public static double4x4 op_Addition(double4x4 lhs, double rhs) { }

	[Address(RVA = "0x2AC3FB0", Offset = "0x2AC33B0", Length = "0x1DA")]
	[Token(Token = "0x600103D")]
	public static double4x4 op_Addition(double4x4 lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC4190", Offset = "0x2AC3590", Length = "0x1C9")]
	[Token(Token = "0x600104A")]
	public static double4x4 op_Decrement(double4x4 val) { }

	[Address(RVA = "0x2AC4520", Offset = "0x2AC3920", Length = "0x186")]
	[Token(Token = "0x6001044")]
	public static double4x4 op_Division(double4x4 lhs, double rhs) { }

	[Address(RVA = "0x2AC46B0", Offset = "0x2AC3AB0", Length = "0x1E0")]
	[Token(Token = "0x6001043")]
	public static double4x4 op_Division(double4x4 lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC4360", Offset = "0x2AC3760", Length = "0x1BC")]
	[Token(Token = "0x6001045")]
	public static double4x4 op_Division(double lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC4890", Offset = "0x2AC3C90", Length = "0x1BA")]
	[Token(Token = "0x600105B")]
	public static bool4x4 op_Equality(double lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC4C10", Offset = "0x2AC4010", Length = "0x21A")]
	[Token(Token = "0x6001059")]
	public static bool4x4 op_Equality(double4x4 lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC4A50", Offset = "0x2AC3E50", Length = "0x1B8")]
	[Token(Token = "0x600105A")]
	public static bool4x4 op_Equality(double4x4 lhs, double rhs) { }

	[Address(RVA = "0x2A30480", Offset = "0x2A2F880", Length = "0x71")]
	[Token(Token = "0x6001032")]
	public static double4x4 op_Explicit(bool v) { }

	[Address(RVA = "0x2A30920", Offset = "0x2A2FD20", Length = "0x49")]
	[Token(Token = "0x6001033")]
	public static double4x4 op_Explicit(bool4x4 v) { }

	[Address(RVA = "0x2AC53B0", Offset = "0x2AC47B0", Length = "0xFF")]
	[Token(Token = "0x6001053")]
	public static bool4x4 op_GreaterThan(double lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC5270", Offset = "0x2AC4670", Length = "0x13B")]
	[Token(Token = "0x6001051")]
	public static bool4x4 op_GreaterThan(double4x4 lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC5170", Offset = "0x2AC4570", Length = "0xF4")]
	[Token(Token = "0x6001052")]
	public static bool4x4 op_GreaterThan(double4x4 lhs, double rhs) { }

	[Address(RVA = "0x2AC4E30", Offset = "0x2AC4230", Length = "0xFF")]
	[Token(Token = "0x6001056")]
	public static bool4x4 op_GreaterThanOrEqual(double lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC4F30", Offset = "0x2AC4330", Length = "0xF4")]
	[Token(Token = "0x6001055")]
	public static bool4x4 op_GreaterThanOrEqual(double4x4 lhs, double rhs) { }

	[Address(RVA = "0x2AC5030", Offset = "0x2AC4430", Length = "0x13B")]
	[Token(Token = "0x6001054")]
	public static bool4x4 op_GreaterThanOrEqual(double4x4 lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC5520", Offset = "0x2AC4920", Length = "0x64")]
	[Token(Token = "0x6001037")]
	public static double4x4 op_Implicit(uint4x4 v) { }

	[Address(RVA = "0x2A30970", Offset = "0x2A2FD70", Length = "0x8B")]
	[Token(Token = "0x6001034")]
	public static double4x4 op_Implicit(int v) { }

	[Address(RVA = "0x2AC55D0", Offset = "0x2AC49D0", Length = "0x64")]
	[Token(Token = "0x6001039")]
	public static double4x4 op_Implicit(float4x4 v) { }

	[Address(RVA = "0x2A30420", Offset = "0x2A2F820", Length = "0x5B")]
	[Token(Token = "0x6001031")]
	public static double4x4 op_Implicit(double v) { }

	[Address(RVA = "0x2AC5590", Offset = "0x2AC4990", Length = "0x3C")]
	[Token(Token = "0x6001036")]
	public static double4x4 op_Implicit(uint v) { }

	[Address(RVA = "0x2AC54B0", Offset = "0x2AC48B0", Length = "0x64")]
	[Token(Token = "0x6001035")]
	public static double4x4 op_Implicit(int4x4 v) { }

	[Address(RVA = "0x2A308A0", Offset = "0x2A2FCA0", Length = "0x73")]
	[Token(Token = "0x6001038")]
	public static double4x4 op_Implicit(float v) { }

	[Address(RVA = "0x2AC5640", Offset = "0x2AC4A40", Length = "0x1C9")]
	[Token(Token = "0x6001049")]
	public static double4x4 op_Increment(double4x4 val) { }

	[Address(RVA = "0x2AC59D0", Offset = "0x2AC4DD0", Length = "0x1BA")]
	[Token(Token = "0x600105E")]
	public static bool4x4 op_Inequality(double lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC5810", Offset = "0x2AC4C10", Length = "0x1B8")]
	[Token(Token = "0x600105D")]
	public static bool4x4 op_Inequality(double4x4 lhs, double rhs) { }

	[Address(RVA = "0x2AC5B90", Offset = "0x2AC4F90", Length = "0x21A")]
	[Token(Token = "0x600105C")]
	public static bool4x4 op_Inequality(double4x4 lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC60F0", Offset = "0x2AC54F0", Length = "0xFF")]
	[Token(Token = "0x600104D")]
	public static bool4x4 op_LessThan(double lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC61F0", Offset = "0x2AC55F0", Length = "0xF4")]
	[Token(Token = "0x600104C")]
	public static bool4x4 op_LessThan(double4x4 lhs, double rhs) { }

	[Address(RVA = "0x2AC62F0", Offset = "0x2AC56F0", Length = "0x13B")]
	[Token(Token = "0x600104B")]
	public static bool4x4 op_LessThan(double4x4 lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC5EF0", Offset = "0x2AC52F0", Length = "0xFF")]
	[Token(Token = "0x6001050")]
	public static bool4x4 op_LessThanOrEqual(double lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC5DB0", Offset = "0x2AC51B0", Length = "0x13B")]
	[Token(Token = "0x600104E")]
	public static bool4x4 op_LessThanOrEqual(double4x4 lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC5FF0", Offset = "0x2AC53F0", Length = "0xF4")]
	[Token(Token = "0x600104F")]
	public static bool4x4 op_LessThanOrEqual(double4x4 lhs, double rhs) { }

	[Address(RVA = "0x2AC6930", Offset = "0x2AC5D30", Length = "0x2C7")]
	[Token(Token = "0x6001046")]
	public static double4x4 op_Modulus(double4x4 lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC6430", Offset = "0x2AC5830", Length = "0x27D")]
	[Token(Token = "0x6001048")]
	public static double4x4 op_Modulus(double lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC66B0", Offset = "0x2AC5AB0", Length = "0x27A")]
	[Token(Token = "0x6001047")]
	public static double4x4 op_Modulus(double4x4 lhs, double rhs) { }

	[Address(RVA = "0x2AC6D90", Offset = "0x2AC6190", Length = "0x187")]
	[Token(Token = "0x600103C")]
	public static double4x4 op_Multiply(double lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC6F20", Offset = "0x2AC6320", Length = "0x1DA")]
	[Token(Token = "0x600103A")]
	public static double4x4 op_Multiply(double4x4 lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC6C00", Offset = "0x2AC6000", Length = "0x186")]
	[Token(Token = "0x600103B")]
	public static double4x4 op_Multiply(double4x4 lhs, double rhs) { }

	[Address(RVA = "0x2AC72E0", Offset = "0x2AC66E0", Length = "0x1BC")]
	[Token(Token = "0x6001042")]
	public static double4x4 op_Subtraction(double lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC74A0", Offset = "0x2AC68A0", Length = "0x186")]
	[Token(Token = "0x6001041")]
	public static double4x4 op_Subtraction(double4x4 lhs, double rhs) { }

	[Address(RVA = "0x2AC7100", Offset = "0x2AC6500", Length = "0x1E0")]
	[Token(Token = "0x6001040")]
	public static double4x4 op_Subtraction(double4x4 lhs, double4x4 rhs) { }

	[Address(RVA = "0x2AC7630", Offset = "0x2AC6A30", Length = "0x173")]
	[Token(Token = "0x6001057")]
	public static double4x4 op_UnaryNegation(double4x4 val) { }

	[Address(RVA = "0x2AC77B0", Offset = "0x2AC6BB0", Length = "0xB16")]
	[Token(Token = "0x6001058")]
	public static double4x4 op_UnaryPlus(double4x4 val) { }

	[Address(RVA = "0x2AC2BC0", Offset = "0x2AC1FC0", Length = "0x676")]
	[Token(Token = "0x6001064")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x2AC3240", Offset = "0x2AC2640", Length = "0x6E3")]
	[Token(Token = "0x6001063")]
	public virtual string ToString() { }

}

