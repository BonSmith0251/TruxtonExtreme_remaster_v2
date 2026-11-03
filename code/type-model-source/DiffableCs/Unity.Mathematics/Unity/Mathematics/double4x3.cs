namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000026")]
public struct double4x3 : IEquatable<double4x3>, IFormattable
{
	[Token(Token = "0x400009F")]
	public static readonly double4x3 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400009C")]
	public double4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009D")]
	public double4 c1; //Field offset: 0x20
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400009E")]
	public double4 c2; //Field offset: 0x40

	[Token(Token = "0x170003D9")]
	public double4 Item
	{
		[Address(RVA = "0x9D75B0", Offset = "0x9D69B0", Length = "0xB")]
		[Token(Token = "0x6001020")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2ABFDD0", Offset = "0x2ABF1D0", Length = "0x31")]
	[Token(Token = "0x6000FE7")]
	public double4x3(double4 c0, double4 c1, double4 c2) { }

	[Address(RVA = "0x2ABFC70", Offset = "0x2ABF070", Length = "0x54")]
	[Token(Token = "0x6000FF0")]
	public double4x3(float v) { }

	[Address(RVA = "0x2ABFB90", Offset = "0x2ABEF90", Length = "0xDA")]
	[Token(Token = "0x6000FEF")]
	public double4x3(uint4x3 v) { }

	[Address(RVA = "0x2A18570", Offset = "0x2A17970", Length = "0xA8")]
	[Token(Token = "0x6000FEE")]
	public double4x3(uint v) { }

	[Address(RVA = "0x2ABFAC0", Offset = "0x2ABEEC0", Length = "0xC4")]
	[Token(Token = "0x6000FED")]
	public double4x3(int4x3 v) { }

	[Address(RVA = "0x2ABFA00", Offset = "0x2ABEE00", Length = "0xBC")]
	[Token(Token = "0x6000FF1")]
	public double4x3(float4x3 v) { }

	[Address(RVA = "0x2A18620", Offset = "0x2A17A20", Length = "0xFB")]
	[Token(Token = "0x6000FEB")]
	public double4x3(bool4x3 v) { }

	[Address(RVA = "0x2ABFE10", Offset = "0x2ABF210", Length = "0x53")]
	[Token(Token = "0x6000FEA")]
	public double4x3(bool v) { }

	[Address(RVA = "0x2ABF9B0", Offset = "0x2ABEDB0", Length = "0x42")]
	[Token(Token = "0x6000FE9")]
	public double4x3(double v) { }

	[Address(RVA = "0x2ABFCD0", Offset = "0x2ABF0D0", Length = "0x8F")]
	[Token(Token = "0x6000FE8")]
	public double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32) { }

	[Address(RVA = "0x2ABFD60", Offset = "0x2ABF160", Length = "0x66")]
	[Token(Token = "0x6000FEC")]
	public double4x3(int v) { }

	[Address(RVA = "0x2ABEE50", Offset = "0x2ABE250", Length = "0xD0")]
	[Token(Token = "0x6001022")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AB2FD0", Offset = "0x2AB23D0", Length = "0xB23")]
	[Token(Token = "0x6001021")]
	public override bool Equals(double4x3 rhs) { }

	[Address(RVA = "0x9D75B0", Offset = "0x9D69B0", Length = "0xB")]
	[Token(Token = "0x6001020")]
	public double4 get_Item(int index) { }

	[Address(RVA = "0x2ABEF30", Offset = "0x2ABE330", Length = "0x4C")]
	[Token(Token = "0x6001023")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2ABFE70", Offset = "0x2ABF270", Length = "0x10F")]
	[Token(Token = "0x6000FFF")]
	public static double4x3 op_Addition(double4x3 lhs, double rhs) { }

	[Address(RVA = "0x2AC00E0", Offset = "0x2ABF4E0", Length = "0x116")]
	[Token(Token = "0x6001000")]
	public static double4x3 op_Addition(double lhs, double4x3 rhs) { }

	[Address(RVA = "0x2ABFF80", Offset = "0x2ABF380", Length = "0x15D")]
	[Token(Token = "0x6000FFE")]
	public static double4x3 op_Addition(double4x3 lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC0200", Offset = "0x2ABF600", Length = "0x13F")]
	[Token(Token = "0x600100B")]
	public static double4x3 op_Decrement(double4x3 val) { }

	[Address(RVA = "0x2AC04B0", Offset = "0x2ABF8B0", Length = "0x10F")]
	[Token(Token = "0x6001005")]
	public static double4x3 op_Division(double4x3 lhs, double rhs) { }

	[Address(RVA = "0x2AC0340", Offset = "0x2ABF740", Length = "0x162")]
	[Token(Token = "0x6001004")]
	public static double4x3 op_Division(double4x3 lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC05C0", Offset = "0x2ABF9C0", Length = "0x142")]
	[Token(Token = "0x6001006")]
	public static double4x3 op_Division(double lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC08B0", Offset = "0x2ABFCB0", Length = "0x147")]
	[Token(Token = "0x600101B")]
	public static bool4x3 op_Equality(double4x3 lhs, double rhs) { }

	[Address(RVA = "0x2AC0710", Offset = "0x2ABFB10", Length = "0x191")]
	[Token(Token = "0x600101A")]
	public static bool4x3 op_Equality(double4x3 lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC0A00", Offset = "0x2ABFE00", Length = "0x149")]
	[Token(Token = "0x600101C")]
	public static bool4x3 op_Equality(double lhs, double4x3 rhs) { }

	[Address(RVA = "0x2A301A0", Offset = "0x2A2F5A0", Length = "0x59")]
	[Token(Token = "0x6000FF3")]
	public static double4x3 op_Explicit(bool v) { }

	[Address(RVA = "0x2AC0B50", Offset = "0x2ABFF50", Length = "0x4A")]
	[Token(Token = "0x6000FF4")]
	public static double4x3 op_Explicit(bool4x3 v) { }

	[Address(RVA = "0x2AC0ED0", Offset = "0x2AC02D0", Length = "0xE8")]
	[Token(Token = "0x6001012")]
	public static bool4x3 op_GreaterThan(double4x3 lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC0E10", Offset = "0x2AC0210", Length = "0xB3")]
	[Token(Token = "0x6001013")]
	public static bool4x3 op_GreaterThan(double4x3 lhs, double rhs) { }

	[Address(RVA = "0x2AC0FC0", Offset = "0x2AC03C0", Length = "0xBC")]
	[Token(Token = "0x6001014")]
	public static bool4x3 op_GreaterThan(double lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC0BA0", Offset = "0x2ABFFA0", Length = "0xE8")]
	[Token(Token = "0x6001015")]
	public static bool4x3 op_GreaterThanOrEqual(double4x3 lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC0C90", Offset = "0x2AC0090", Length = "0xB3")]
	[Token(Token = "0x6001016")]
	public static bool4x3 op_GreaterThanOrEqual(double4x3 lhs, double rhs) { }

	[Address(RVA = "0x2AC0D50", Offset = "0x2AC0150", Length = "0xBC")]
	[Token(Token = "0x6001017")]
	public static bool4x3 op_GreaterThanOrEqual(double lhs, double4x3 rhs) { }

	[Address(RVA = "0x2A30260", Offset = "0x2A2F660", Length = "0xC7")]
	[Token(Token = "0x6000FFA")]
	public static double4x3 op_Implicit(float4x3 v) { }

	[Address(RVA = "0x2A300D0", Offset = "0x2A2F4D0", Length = "0xCA")]
	[Token(Token = "0x6000FF6")]
	public static double4x3 op_Implicit(int4x3 v) { }

	[Address(RVA = "0x2A2FD40", Offset = "0x2A2F140", Length = "0x45")]
	[Token(Token = "0x6000FF2")]
	public static double4x3 op_Implicit(double v) { }

	[Address(RVA = "0x2A30020", Offset = "0x2A2F420", Length = "0xAB")]
	[Token(Token = "0x6000FF7")]
	public static double4x3 op_Implicit(uint v) { }

	[Address(RVA = "0x2A2FC60", Offset = "0x2A2F060", Length = "0xE0")]
	[Token(Token = "0x6000FF8")]
	public static double4x3 op_Implicit(uint4x3 v) { }

	[Address(RVA = "0x2A2FF70", Offset = "0x2A2F370", Length = "0x69")]
	[Token(Token = "0x6000FF5")]
	public static double4x3 op_Implicit(int v) { }

	[Address(RVA = "0x2A30200", Offset = "0x2A2F600", Length = "0x57")]
	[Token(Token = "0x6000FF9")]
	public static double4x3 op_Implicit(float v) { }

	[Address(RVA = "0x2AC1080", Offset = "0x2AC0480", Length = "0x13F")]
	[Token(Token = "0x600100A")]
	public static double4x3 op_Increment(double4x3 val) { }

	[Address(RVA = "0x2AC11C0", Offset = "0x2AC05C0", Length = "0x191")]
	[Token(Token = "0x600101D")]
	public static bool4x3 op_Inequality(double4x3 lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC14B0", Offset = "0x2AC08B0", Length = "0x149")]
	[Token(Token = "0x600101F")]
	public static bool4x3 op_Inequality(double lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC1360", Offset = "0x2AC0760", Length = "0x147")]
	[Token(Token = "0x600101E")]
	public static bool4x3 op_Inequality(double4x3 lhs, double rhs) { }

	[Address(RVA = "0x2AC1870", Offset = "0x2AC0C70", Length = "0xE8")]
	[Token(Token = "0x600100C")]
	public static bool4x3 op_LessThan(double4x3 lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC1A20", Offset = "0x2AC0E20", Length = "0xBC")]
	[Token(Token = "0x600100E")]
	public static bool4x3 op_LessThan(double lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC1960", Offset = "0x2AC0D60", Length = "0xB3")]
	[Token(Token = "0x600100D")]
	public static bool4x3 op_LessThan(double4x3 lhs, double rhs) { }

	[Address(RVA = "0x2AC1600", Offset = "0x2AC0A00", Length = "0xE8")]
	[Token(Token = "0x600100F")]
	public static bool4x3 op_LessThanOrEqual(double4x3 lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC16F0", Offset = "0x2AC0AF0", Length = "0xB3")]
	[Token(Token = "0x6001010")]
	public static bool4x3 op_LessThanOrEqual(double4x3 lhs, double rhs) { }

	[Address(RVA = "0x2AC17B0", Offset = "0x2AC0BB0", Length = "0xBC")]
	[Token(Token = "0x6001011")]
	public static bool4x3 op_LessThanOrEqual(double lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC1F10", Offset = "0x2AC1310", Length = "0x1F3")]
	[Token(Token = "0x6001009")]
	public static double4x3 op_Modulus(double lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC1D10", Offset = "0x2AC1110", Length = "0x1F5")]
	[Token(Token = "0x6001008")]
	public static double4x3 op_Modulus(double4x3 lhs, double rhs) { }

	[Address(RVA = "0x2AC1AE0", Offset = "0x2AC0EE0", Length = "0x22E")]
	[Token(Token = "0x6001007")]
	public static double4x3 op_Modulus(double4x3 lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC2380", Offset = "0x2AC1780", Length = "0x116")]
	[Token(Token = "0x6000FFD")]
	public static double4x3 op_Multiply(double lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC2270", Offset = "0x2AC1670", Length = "0x10F")]
	[Token(Token = "0x6000FFC")]
	public static double4x3 op_Multiply(double4x3 lhs, double rhs) { }

	[Address(RVA = "0x2AC2110", Offset = "0x2AC1510", Length = "0x15D")]
	[Token(Token = "0x6000FFB")]
	public static double4x3 op_Multiply(double4x3 lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC24A0", Offset = "0x2AC18A0", Length = "0x142")]
	[Token(Token = "0x6001003")]
	public static double4x3 op_Subtraction(double lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC25F0", Offset = "0x2AC19F0", Length = "0x10F")]
	[Token(Token = "0x6001002")]
	public static double4x3 op_Subtraction(double4x3 lhs, double rhs) { }

	[Address(RVA = "0x2AC2700", Offset = "0x2AC1B00", Length = "0x162")]
	[Token(Token = "0x6001001")]
	public static double4x3 op_Subtraction(double4x3 lhs, double4x3 rhs) { }

	[Address(RVA = "0x2AC2870", Offset = "0x2AC1C70", Length = "0x107")]
	[Token(Token = "0x6001018")]
	public static double4x3 op_UnaryNegation(double4x3 val) { }

	[Address(RVA = "0x2AC2980", Offset = "0x2AC1D80", Length = "0xDD")]
	[Token(Token = "0x6001019")]
	public static double4x3 op_UnaryPlus(double4x3 val) { }

	[Address(RVA = "0x2ABF470", Offset = "0x2ABE870", Length = "0x533")]
	[Token(Token = "0x6001024")]
	public virtual string ToString() { }

	[Address(RVA = "0x2ABEF80", Offset = "0x2ABE380", Length = "0x4EE")]
	[Token(Token = "0x6001025")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

