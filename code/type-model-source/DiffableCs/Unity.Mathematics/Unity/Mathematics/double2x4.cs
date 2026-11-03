namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200001D")]
public struct double2x4 : IEquatable<double2x4>, IFormattable
{
	[Token(Token = "0x400007B")]
	public static readonly double2x4 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000077")]
	public double2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000078")]
	public double2 c1; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000079")]
	public double2 c2; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400007A")]
	public double2 c3; //Field offset: 0x30

	[Token(Token = "0x1700020D")]
	public double2 Item
	{
		[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
		[Token(Token = "0x6000C45")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2A99310", Offset = "0x2A98710", Length = "0x23")]
	[Token(Token = "0x6000C0C")]
	public double2x4(double2 c0, double2 c1, double2 c2, double2 c3) { }

	[Address(RVA = "0x2AA8D70", Offset = "0x2AA8170", Length = "0x59")]
	[Token(Token = "0x6000C15")]
	public double2x4(float v) { }

	[Address(RVA = "0x2AA8DD0", Offset = "0x2AA81D0", Length = "0x98")]
	[Token(Token = "0x6000C14")]
	public double2x4(uint2x4 v) { }

	[Address(RVA = "0x2AA9000", Offset = "0x2AA8400", Length = "0x78")]
	[Token(Token = "0x6000C13")]
	public double2x4(uint v) { }

	[Address(RVA = "0x2AA9080", Offset = "0x2AA8480", Length = "0x87")]
	[Token(Token = "0x6000C12")]
	public double2x4(int2x4 v) { }

	[Address(RVA = "0x2AA8ED0", Offset = "0x2AA82D0", Length = "0x71")]
	[Token(Token = "0x6000C16")]
	public double2x4(float2x4 v) { }

	[Address(RVA = "0x2A178D0", Offset = "0x2A16CD0", Length = "0xB0")]
	[Token(Token = "0x6000C10")]
	public double2x4(bool2x4 v) { }

	[Address(RVA = "0x2AA8F50", Offset = "0x2AA8350", Length = "0x32")]
	[Token(Token = "0x6000C0F")]
	public double2x4(bool v) { }

	[Address(RVA = "0x2AA8FE0", Offset = "0x2AA83E0", Length = "0x14")]
	[Token(Token = "0x6000C0E")]
	public double2x4(double v) { }

	[Address(RVA = "0x2AA8F90", Offset = "0x2AA8390", Length = "0x46")]
	[Token(Token = "0x6000C0D")]
	public double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13) { }

	[Address(RVA = "0x2AA8E70", Offset = "0x2AA8270", Length = "0x5F")]
	[Token(Token = "0x6000C11")]
	public double2x4(int v) { }

	[Address(RVA = "0x2AA84D0", Offset = "0x2AA78D0", Length = "0x114")]
	[Token(Token = "0x6000C47")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AA8430", Offset = "0x2AA7830", Length = "0x9C")]
	[Token(Token = "0x6000C46")]
	public override bool Equals(double2x4 rhs) { }

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x6000C45")]
	public double2 get_Item(int index) { }

	[Address(RVA = "0x2AA85F0", Offset = "0x2AA79F0", Length = "0x38")]
	[Token(Token = "0x6000C48")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AA9170", Offset = "0x2AA8570", Length = "0x47")]
	[Token(Token = "0x6000C24")]
	public static double2x4 op_Addition(double2x4 lhs, double rhs) { }

	[Address(RVA = "0x2AA9110", Offset = "0x2AA8510", Length = "0x5A")]
	[Token(Token = "0x6000C25")]
	public static double2x4 op_Addition(double lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AA91C0", Offset = "0x2AA85C0", Length = "0x87")]
	[Token(Token = "0x6000C23")]
	public static double2x4 op_Addition(double2x4 lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AA9250", Offset = "0x2AA8650", Length = "0xB0")]
	[Token(Token = "0x6000C30")]
	public static double2x4 op_Decrement(double2x4 val) { }

	[Address(RVA = "0x2AA9300", Offset = "0x2AA8700", Length = "0x47")]
	[Token(Token = "0x6000C2A")]
	public static double2x4 op_Division(double2x4 lhs, double rhs) { }

	[Address(RVA = "0x2AA9350", Offset = "0x2AA8750", Length = "0x87")]
	[Token(Token = "0x6000C29")]
	public static double2x4 op_Division(double2x4 lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AA93E0", Offset = "0x2AA87E0", Length = "0x74")]
	[Token(Token = "0x6000C2B")]
	public static double2x4 op_Division(double lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AA96C0", Offset = "0x2AA8AC0", Length = "0x12A")]
	[Token(Token = "0x6000C40")]
	public static bool2x4 op_Equality(double2x4 lhs, double rhs) { }

	[Address(RVA = "0x2AA9570", Offset = "0x2AA8970", Length = "0x143")]
	[Token(Token = "0x6000C3F")]
	public static bool2x4 op_Equality(double2x4 lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AA9460", Offset = "0x2AA8860", Length = "0x10D")]
	[Token(Token = "0x6000C41")]
	public static bool2x4 op_Equality(double lhs, double2x4 rhs) { }

	[Address(RVA = "0x2A2D630", Offset = "0x2A2CA30", Length = "0x38")]
	[Token(Token = "0x6000C18")]
	public static double2x4 op_Explicit(bool v) { }

	[Address(RVA = "0x2AA97F0", Offset = "0x2AA8BF0", Length = "0x2C")]
	[Token(Token = "0x6000C19")]
	public static double2x4 op_Explicit(bool2x4 v) { }

	[Address(RVA = "0x2AA9BB0", Offset = "0x2AA8FB0", Length = "0xF9")]
	[Token(Token = "0x6000C37")]
	public static bool2x4 op_GreaterThan(double2x4 lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AA9CB0", Offset = "0x2AA90B0", Length = "0xE6")]
	[Token(Token = "0x6000C38")]
	public static bool2x4 op_GreaterThan(double2x4 lhs, double rhs) { }

	[Address(RVA = "0x2AA9AE0", Offset = "0x2AA8EE0", Length = "0xCB")]
	[Token(Token = "0x6000C39")]
	public static bool2x4 op_GreaterThan(double lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AA99E0", Offset = "0x2AA8DE0", Length = "0xF9")]
	[Token(Token = "0x6000C3A")]
	public static bool2x4 op_GreaterThanOrEqual(double2x4 lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AA98F0", Offset = "0x2AA8CF0", Length = "0xE6")]
	[Token(Token = "0x6000C3B")]
	public static bool2x4 op_GreaterThanOrEqual(double2x4 lhs, double rhs) { }

	[Address(RVA = "0x2AA9820", Offset = "0x2AA8C20", Length = "0xCB")]
	[Token(Token = "0x6000C3C")]
	public static bool2x4 op_GreaterThanOrEqual(double lhs, double2x4 rhs) { }

	[Address(RVA = "0x2A2D9F0", Offset = "0x2A2CDF0", Length = "0x94")]
	[Token(Token = "0x6000C1F")]
	public static double2x4 op_Implicit(float2x4 v) { }

	[Address(RVA = "0x2A2D810", Offset = "0x2A2CC10", Length = "0xC8")]
	[Token(Token = "0x6000C1B")]
	public static double2x4 op_Implicit(int2x4 v) { }

	[Address(RVA = "0x2A2D8E0", Offset = "0x2A2CCE0", Length = "0x17")]
	[Token(Token = "0x6000C17")]
	public static double2x4 op_Implicit(double v) { }

	[Address(RVA = "0x2A2D970", Offset = "0x2A2CD70", Length = "0x7B")]
	[Token(Token = "0x6000C1C")]
	public static double2x4 op_Implicit(uint v) { }

	[Address(RVA = "0x2A2D670", Offset = "0x2A2CA70", Length = "0xDA")]
	[Token(Token = "0x6000C1D")]
	public static double2x4 op_Implicit(uint2x4 v) { }

	[Address(RVA = "0x2A2DA90", Offset = "0x2A2CE90", Length = "0x6B")]
	[Token(Token = "0x6000C1A")]
	public static double2x4 op_Implicit(int v) { }

	[Address(RVA = "0x2A2D900", Offset = "0x2A2CD00", Length = "0x66")]
	[Token(Token = "0x6000C1E")]
	public static double2x4 op_Implicit(float v) { }

	[Address(RVA = "0x2AA9DA0", Offset = "0x2AA91A0", Length = "0xB0")]
	[Token(Token = "0x6000C2F")]
	public static double2x4 op_Increment(double2x4 val) { }

	[Address(RVA = "0x2AAA090", Offset = "0x2AA9490", Length = "0x143")]
	[Token(Token = "0x6000C42")]
	public static bool2x4 op_Inequality(double2x4 lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AA9E50", Offset = "0x2AA9250", Length = "0x10D")]
	[Token(Token = "0x6000C44")]
	public static bool2x4 op_Inequality(double lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AA9F60", Offset = "0x2AA9360", Length = "0x12A")]
	[Token(Token = "0x6000C43")]
	public static bool2x4 op_Inequality(double2x4 lhs, double rhs) { }

	[Address(RVA = "0x2AAA570", Offset = "0x2AA9970", Length = "0xF9")]
	[Token(Token = "0x6000C31")]
	public static bool2x4 op_LessThan(double2x4 lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AAA670", Offset = "0x2AA9A70", Length = "0xE6")]
	[Token(Token = "0x6000C33")]
	public static bool2x4 op_LessThan(double lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AAA4A0", Offset = "0x2AA98A0", Length = "0xCE")]
	[Token(Token = "0x6000C32")]
	public static bool2x4 op_LessThan(double2x4 lhs, double rhs) { }

	[Address(RVA = "0x2AAA3A0", Offset = "0x2AA97A0", Length = "0xF9")]
	[Token(Token = "0x6000C34")]
	public static bool2x4 op_LessThanOrEqual(double2x4 lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AAA2D0", Offset = "0x2AA96D0", Length = "0xCE")]
	[Token(Token = "0x6000C35")]
	public static bool2x4 op_LessThanOrEqual(double2x4 lhs, double rhs) { }

	[Address(RVA = "0x2AAA1E0", Offset = "0x2AA95E0", Length = "0xE6")]
	[Token(Token = "0x6000C36")]
	public static bool2x4 op_LessThanOrEqual(double lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AAA760", Offset = "0x2AA9B60", Length = "0xC8")]
	[Token(Token = "0x6000C2E")]
	public static double2x4 op_Modulus(double lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AAA920", Offset = "0x2AA9D20", Length = "0xC7")]
	[Token(Token = "0x6000C2D")]
	public static double2x4 op_Modulus(double2x4 lhs, double rhs) { }

	[Address(RVA = "0x2AAA830", Offset = "0x2AA9C30", Length = "0xE5")]
	[Token(Token = "0x6000C2C")]
	public static double2x4 op_Modulus(double2x4 lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AAAA40", Offset = "0x2AA9E40", Length = "0x5A")]
	[Token(Token = "0x6000C22")]
	public static double2x4 op_Multiply(double lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AAA9F0", Offset = "0x2AA9DF0", Length = "0x47")]
	[Token(Token = "0x6000C21")]
	public static double2x4 op_Multiply(double2x4 lhs, double rhs) { }

	[Address(RVA = "0x2AAAAA0", Offset = "0x2AA9EA0", Length = "0x87")]
	[Token(Token = "0x6000C20")]
	public static double2x4 op_Multiply(double2x4 lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AAAB30", Offset = "0x2AA9F30", Length = "0x74")]
	[Token(Token = "0x6000C28")]
	public static double2x4 op_Subtraction(double lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AAAC40", Offset = "0x2AAA040", Length = "0x47")]
	[Token(Token = "0x6000C27")]
	public static double2x4 op_Subtraction(double2x4 lhs, double rhs) { }

	[Address(RVA = "0x2AAABB0", Offset = "0x2AA9FB0", Length = "0x87")]
	[Token(Token = "0x6000C26")]
	public static double2x4 op_Subtraction(double2x4 lhs, double2x4 rhs) { }

	[Address(RVA = "0x2AAAC90", Offset = "0x2AAA090", Length = "0x45")]
	[Token(Token = "0x6000C3D")]
	public static double2x4 op_UnaryNegation(double2x4 val) { }

	[Address(RVA = "0x2AAACE0", Offset = "0x2AAA0E0", Length = "0x47")]
	[Token(Token = "0x6000C3E")]
	public static double2x4 op_UnaryPlus(double2x4 val) { }

	[Address(RVA = "0x2AA89B0", Offset = "0x2AA7DB0", Length = "0x3B0")]
	[Token(Token = "0x6000C49")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AA8630", Offset = "0x2AA7A30", Length = "0x37E")]
	[Token(Token = "0x6000C4A")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

