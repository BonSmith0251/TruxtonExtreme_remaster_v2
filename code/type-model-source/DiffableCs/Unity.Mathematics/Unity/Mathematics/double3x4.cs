namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000022")]
public struct double3x4 : IEquatable<double3x4>, IFormattable
{
	[Token(Token = "0x400008F")]
	public static readonly double3x4 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400008B")]
	public double3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008C")]
	public double3 c1; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400008D")]
	public double3 c2; //Field offset: 0x30
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400008E")]
	public double3 c3; //Field offset: 0x48

	[Token(Token = "0x17000286")]
	public double3 Item
	{
		[Address(RVA = "0x9D7550", Offset = "0x9D6950", Length = "0xC")]
		[Token(Token = "0x6000DCB")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x2AB5590", Offset = "0x2AB4990", Length = "0x4D")]
	[Token(Token = "0x6000D92")]
	public double3x4(double3 c0, double3 c1, double3 c2, double3 c3) { }

	[Address(RVA = "0x2AB58A0", Offset = "0x2AB4CA0", Length = "0x73")]
	[Token(Token = "0x6000D9B")]
	public double3x4(float v) { }

	[Address(RVA = "0x2A17F30", Offset = "0x2A17330", Length = "0x124")]
	[Token(Token = "0x6000D9A")]
	public double3x4(uint3x4 v) { }

	[Address(RVA = "0x2A17E70", Offset = "0x2A17270", Length = "0xB4")]
	[Token(Token = "0x6000D99")]
	public double3x4(uint v) { }

	[Address(RVA = "0x2A18060", Offset = "0x2A17460", Length = "0x114")]
	[Token(Token = "0x6000D98")]
	public double3x4(int3x4 v) { }

	[Address(RVA = "0x2AB57D0", Offset = "0x2AB4BD0", Length = "0xC3")]
	[Token(Token = "0x6000D9C")]
	public double3x4(float3x4 v) { }

	[Address(RVA = "0x2A17D50", Offset = "0x2A17150", Length = "0x117")]
	[Token(Token = "0x6000D96")]
	public double3x4(bool3x4 v) { }

	[Address(RVA = "0x2AB5730", Offset = "0x2AB4B30", Length = "0x92")]
	[Token(Token = "0x6000D95")]
	public double3x4(bool v) { }

	[Address(RVA = "0x2AB56E0", Offset = "0x2AB4AE0", Length = "0x48")]
	[Token(Token = "0x6000D94")]
	public double3x4(double v) { }

	[Address(RVA = "0x2AB55E0", Offset = "0x2AB49E0", Length = "0x7E")]
	[Token(Token = "0x6000D93")]
	public double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23) { }

	[Address(RVA = "0x2AB5660", Offset = "0x2AB4A60", Length = "0x80")]
	[Token(Token = "0x6000D97")]
	public double3x4(int v) { }

	[Address(RVA = "0x2AB4A30", Offset = "0x2AB3E30", Length = "0xD0")]
	[Token(Token = "0x6000DCD")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AB1930", Offset = "0x2AB0D30", Length = "0x1690")]
	[Token(Token = "0x6000DCC")]
	public override bool Equals(double3x4 rhs) { }

	[Address(RVA = "0x9D7550", Offset = "0x9D6950", Length = "0xC")]
	[Token(Token = "0x6000DCB")]
	public double3 get_Item(int index) { }

	[Address(RVA = "0x2AB4B10", Offset = "0x2AB3F10", Length = "0x4C")]
	[Token(Token = "0x6000DCE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AB5920", Offset = "0x2AB4D20", Length = "0x113")]
	[Token(Token = "0x6000DAA")]
	public static double3x4 op_Addition(double3x4 lhs, double rhs) { }

	[Address(RVA = "0x2AB5A40", Offset = "0x2AB4E40", Length = "0x115")]
	[Token(Token = "0x6000DAB")]
	public static double3x4 op_Addition(double lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB5B60", Offset = "0x2AB4F60", Length = "0x175")]
	[Token(Token = "0x6000DA9")]
	public static double3x4 op_Addition(double3x4 lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB5CE0", Offset = "0x2AB50E0", Length = "0x14B")]
	[Token(Token = "0x6000DB6")]
	public static double3x4 op_Decrement(double3x4 val) { }

	[Address(RVA = "0x2AB5E30", Offset = "0x2AB5230", Length = "0x113")]
	[Token(Token = "0x6000DB0")]
	public static double3x4 op_Division(double3x4 lhs, double rhs) { }

	[Address(RVA = "0x2AB6090", Offset = "0x2AB5490", Length = "0x179")]
	[Token(Token = "0x6000DAF")]
	public static double3x4 op_Division(double3x4 lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB5F50", Offset = "0x2AB5350", Length = "0x13F")]
	[Token(Token = "0x6000DB1")]
	public static double3x4 op_Division(double lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB6530", Offset = "0x2AB5930", Length = "0x16C")]
	[Token(Token = "0x6000DC6")]
	public static bool3x4 op_Equality(double3x4 lhs, double rhs) { }

	[Address(RVA = "0x2AB6210", Offset = "0x2AB5610", Length = "0x1AE")]
	[Token(Token = "0x6000DC5")]
	public static bool3x4 op_Equality(double3x4 lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB63C0", Offset = "0x2AB57C0", Length = "0x16E")]
	[Token(Token = "0x6000DC7")]
	public static bool3x4 op_Equality(double lhs, double3x4 rhs) { }

	[Address(RVA = "0x2A2F120", Offset = "0x2A2E520", Length = "0x98")]
	[Token(Token = "0x6000D9E")]
	public static double3x4 op_Explicit(bool v) { }

	[Address(RVA = "0x2AB66A0", Offset = "0x2AB5AA0", Length = "0x4A")]
	[Token(Token = "0x6000D9F")]
	public static double3x4 op_Explicit(bool3x4 v) { }

	[Address(RVA = "0x2AB6C10", Offset = "0x2AB6010", Length = "0x15C")]
	[Token(Token = "0x6000DBD")]
	public static bool3x4 op_GreaterThan(double3x4 lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB6B20", Offset = "0x2AB5F20", Length = "0xE4")]
	[Token(Token = "0x6000DBE")]
	public static bool3x4 op_GreaterThan(double3x4 lhs, double rhs) { }

	[Address(RVA = "0x2AB6A30", Offset = "0x2AB5E30", Length = "0xE1")]
	[Token(Token = "0x6000DBF")]
	public static bool3x4 op_GreaterThan(double lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB67E0", Offset = "0x2AB5BE0", Length = "0x15C")]
	[Token(Token = "0x6000DC0")]
	public static bool3x4 op_GreaterThanOrEqual(double3x4 lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB66F0", Offset = "0x2AB5AF0", Length = "0xE4")]
	[Token(Token = "0x6000DC1")]
	public static bool3x4 op_GreaterThanOrEqual(double3x4 lhs, double rhs) { }

	[Address(RVA = "0x2AB6940", Offset = "0x2AB5D40", Length = "0xE1")]
	[Token(Token = "0x6000DC2")]
	public static bool3x4 op_GreaterThanOrEqual(double lhs, double3x4 rhs) { }

	[Address(RVA = "0x2A2EC80", Offset = "0x2A2E080", Length = "0xCB")]
	[Token(Token = "0x6000DA5")]
	public static double3x4 op_Implicit(float3x4 v) { }

	[Address(RVA = "0x2AB6D70", Offset = "0x2AB6170", Length = "0x53")]
	[Token(Token = "0x6000DA1")]
	public static double3x4 op_Implicit(int3x4 v) { }

	[Address(RVA = "0x2A2EB10", Offset = "0x2A2DF10", Length = "0x4B")]
	[Token(Token = "0x6000D9D")]
	public static double3x4 op_Implicit(double v) { }

	[Address(RVA = "0x2AB6DD0", Offset = "0x2AB61D0", Length = "0x34")]
	[Token(Token = "0x6000DA2")]
	public static double3x4 op_Implicit(uint v) { }

	[Address(RVA = "0x2AB6E10", Offset = "0x2AB6210", Length = "0x53")]
	[Token(Token = "0x6000DA3")]
	public static double3x4 op_Implicit(uint3x4 v) { }

	[Address(RVA = "0x2A2EBF0", Offset = "0x2A2DFF0", Length = "0x83")]
	[Token(Token = "0x6000DA0")]
	public static double3x4 op_Implicit(int v) { }

	[Address(RVA = "0x2A2EEB0", Offset = "0x2A2E2B0", Length = "0x76")]
	[Token(Token = "0x6000DA4")]
	public static double3x4 op_Implicit(float v) { }

	[Address(RVA = "0x2AB6E70", Offset = "0x2AB6270", Length = "0x14B")]
	[Token(Token = "0x6000DB5")]
	public static double3x4 op_Increment(double3x4 val) { }

	[Address(RVA = "0x2AB72A0", Offset = "0x2AB66A0", Length = "0x1AE")]
	[Token(Token = "0x6000DC8")]
	public static bool3x4 op_Inequality(double3x4 lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB7130", Offset = "0x2AB6530", Length = "0x16E")]
	[Token(Token = "0x6000DCA")]
	public static bool3x4 op_Inequality(double lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB6FC0", Offset = "0x2AB63C0", Length = "0x16C")]
	[Token(Token = "0x6000DC9")]
	public static bool3x4 op_Inequality(double3x4 lhs, double rhs) { }

	[Address(RVA = "0x2AB7950", Offset = "0x2AB6D50", Length = "0x158")]
	[Token(Token = "0x6000DB7")]
	public static bool3x4 op_LessThan(double3x4 lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB7780", Offset = "0x2AB6B80", Length = "0xEC")]
	[Token(Token = "0x6000DB9")]
	public static bool3x4 op_LessThan(double lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB7870", Offset = "0x2AB6C70", Length = "0xD8")]
	[Token(Token = "0x6000DB8")]
	public static bool3x4 op_LessThan(double3x4 lhs, double rhs) { }

	[Address(RVA = "0x2AB7450", Offset = "0x2AB6850", Length = "0x158")]
	[Token(Token = "0x6000DBA")]
	public static bool3x4 op_LessThanOrEqual(double3x4 lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB75B0", Offset = "0x2AB69B0", Length = "0xD8")]
	[Token(Token = "0x6000DBB")]
	public static bool3x4 op_LessThanOrEqual(double3x4 lhs, double rhs) { }

	[Address(RVA = "0x2AB7690", Offset = "0x2AB6A90", Length = "0xEC")]
	[Token(Token = "0x6000DBC")]
	public static bool3x4 op_LessThanOrEqual(double lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB7CA0", Offset = "0x2AB70A0", Length = "0x1EE")]
	[Token(Token = "0x6000DB4")]
	public static double3x4 op_Modulus(double lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB7AB0", Offset = "0x2AB6EB0", Length = "0x1EB")]
	[Token(Token = "0x6000DB3")]
	public static double3x4 op_Modulus(double3x4 lhs, double rhs) { }

	[Address(RVA = "0x2AB7E90", Offset = "0x2AB7290", Length = "0x21F")]
	[Token(Token = "0x6000DB2")]
	public static double3x4 op_Modulus(double3x4 lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB80B0", Offset = "0x2AB74B0", Length = "0x115")]
	[Token(Token = "0x6000DA8")]
	public static double3x4 op_Multiply(double lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB81D0", Offset = "0x2AB75D0", Length = "0x113")]
	[Token(Token = "0x6000DA7")]
	public static double3x4 op_Multiply(double3x4 lhs, double rhs) { }

	[Address(RVA = "0x2AB82F0", Offset = "0x2AB76F0", Length = "0x175")]
	[Token(Token = "0x6000DA6")]
	public static double3x4 op_Multiply(double3x4 lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB85F0", Offset = "0x2AB79F0", Length = "0x13F")]
	[Token(Token = "0x6000DAE")]
	public static double3x4 op_Subtraction(double lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB8730", Offset = "0x2AB7B30", Length = "0x113")]
	[Token(Token = "0x6000DAD")]
	public static double3x4 op_Subtraction(double3x4 lhs, double rhs) { }

	[Address(RVA = "0x2AB8470", Offset = "0x2AB7870", Length = "0x179")]
	[Token(Token = "0x6000DAC")]
	public static double3x4 op_Subtraction(double3x4 lhs, double3x4 rhs) { }

	[Address(RVA = "0x2AB8850", Offset = "0x2AB7C50", Length = "0x10B")]
	[Token(Token = "0x6000DC3")]
	public static double3x4 op_UnaryNegation(double3x4 val) { }

	[Address(RVA = "0x2AB8960", Offset = "0x2AB7D60", Length = "0xD6")]
	[Token(Token = "0x6000DC4")]
	public static double3x4 op_UnaryPlus(double3x4 val) { }

	[Address(RVA = "0x2AB5050", Offset = "0x2AB4450", Length = "0x533")]
	[Token(Token = "0x6000DCF")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AB4B60", Offset = "0x2AB3F60", Length = "0x4EE")]
	[Token(Token = "0x6000DD0")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

