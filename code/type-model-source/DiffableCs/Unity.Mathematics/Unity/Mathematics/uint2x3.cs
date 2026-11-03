namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000057")]
public struct uint2x3 : IEquatable<uint2x3>, IFormattable
{
	[Token(Token = "0x400014B")]
	public static readonly uint2x3 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000148")]
	public uint2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000149")]
	public uint2 c1; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400014A")]
	public uint2 c2; //Field offset: 0x10

	[Token(Token = "0x170009BB")]
	public uint2 Item
	{
		[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
		[Token(Token = "0x6001FEC")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1F73700", Offset = "0x1F72B00", Length = "0xC")]
	[Token(Token = "0x6001FA7")]
	public uint2x3(uint2 c0, uint2 c1, uint2 c2) { }

	[Address(RVA = "0x2AF8630", Offset = "0x2AF7A30", Length = "0x41")]
	[Token(Token = "0x6001FA8")]
	public uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12) { }

	[Address(RVA = "0x2AF85A0", Offset = "0x2AF79A0", Length = "0x33")]
	[Token(Token = "0x6001FA9")]
	public uint2x3(uint v) { }

	[Address(RVA = "0x2A1AD30", Offset = "0x2A1A130", Length = "0x75")]
	[Token(Token = "0x6001FAA")]
	public uint2x3(bool v) { }

	[Address(RVA = "0x2A1AC40", Offset = "0x2A1A040", Length = "0xE8")]
	[Token(Token = "0x6001FAB")]
	public uint2x3(bool2x3 v) { }

	[Address(RVA = "0x2AF85A0", Offset = "0x2AF79A0", Length = "0x33")]
	[Token(Token = "0x6001FAC")]
	public uint2x3(int v) { }

	[Address(RVA = "0x2AF85E0", Offset = "0x2AF79E0", Length = "0x4A")]
	[Token(Token = "0x6001FAD")]
	public uint2x3(int2x3 v) { }

	[Address(RVA = "0x2A212E0", Offset = "0x2A206E0", Length = "0x93")]
	[Token(Token = "0x6001FAE")]
	public uint2x3(float v) { }

	[Address(RVA = "0x2A21170", Offset = "0x2A20570", Length = "0xC6")]
	[Token(Token = "0x6001FAF")]
	public uint2x3(float2x3 v) { }

	[Address(RVA = "0x2A21240", Offset = "0x2A20640", Length = "0x94")]
	[Token(Token = "0x6001FB0")]
	public uint2x3(double v) { }

	[Address(RVA = "0x2A21380", Offset = "0x2A20780", Length = "0xC3")]
	[Token(Token = "0x6001FB1")]
	public uint2x3(double2x3 v) { }

	[Address(RVA = "0x2AF7D00", Offset = "0x2AF7100", Length = "0x66")]
	[Token(Token = "0x6001FED")]
	public override bool Equals(uint2x3 rhs) { }

	[Address(RVA = "0x2B2E1B0", Offset = "0x2B2D5B0", Length = "0xF4")]
	[Token(Token = "0x6001FEE")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
	[Token(Token = "0x6001FEC")]
	public uint2 get_Item(int index) { }

	[Address(RVA = "0x2B2E2B0", Offset = "0x2B2D6B0", Length = "0x28")]
	[Token(Token = "0x6001FEF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AF86F0", Offset = "0x2AF7AF0", Length = "0x87")]
	[Token(Token = "0x6001FBE")]
	public static uint2x3 op_Addition(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF8780", Offset = "0x2AF7B80", Length = "0x6D")]
	[Token(Token = "0x6001FBF")]
	public static uint2x3 op_Addition(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2AF8680", Offset = "0x2AF7A80", Length = "0x69")]
	[Token(Token = "0x6001FC0")]
	public static uint2x3 op_Addition(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF87F0", Offset = "0x2AF7BF0", Length = "0x8B")]
	[Token(Token = "0x6001FE3")]
	public static uint2x3 op_BitwiseAnd(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF8880", Offset = "0x2AF7C80", Length = "0x72")]
	[Token(Token = "0x6001FE4")]
	public static uint2x3 op_BitwiseAnd(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2AF8900", Offset = "0x2AF7D00", Length = "0x6E")]
	[Token(Token = "0x6001FE5")]
	public static uint2x3 op_BitwiseAnd(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF8970", Offset = "0x2AF7D70", Length = "0x6E")]
	[Token(Token = "0x6001FE8")]
	public static uint2x3 op_BitwiseOr(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF89E0", Offset = "0x2AF7DE0", Length = "0x8B")]
	[Token(Token = "0x6001FE6")]
	public static uint2x3 op_BitwiseOr(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF8A70", Offset = "0x2AF7E70", Length = "0x72")]
	[Token(Token = "0x6001FE7")]
	public static uint2x3 op_BitwiseOr(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2AF8AF0", Offset = "0x2AF7EF0", Length = "0x6B")]
	[Token(Token = "0x6001FCB")]
	public static uint2x3 op_Decrement(uint2x3 val) { }

	[Address(RVA = "0x2B2E930", Offset = "0x2B2DD30", Length = "0x8D")]
	[Token(Token = "0x6001FC6")]
	public static uint2x3 op_Division(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2B2E9C0", Offset = "0x2B2DDC0", Length = "0x8D")]
	[Token(Token = "0x6001FC5")]
	public static uint2x3 op_Division(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2B2E880", Offset = "0x2B2DC80", Length = "0xA5")]
	[Token(Token = "0x6001FC4")]
	public static uint2x3 op_Division(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF8E10", Offset = "0x2AF8210", Length = "0x5F")]
	[Token(Token = "0x6001FDE")]
	public static bool2x3 op_Equality(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF8D20", Offset = "0x2AF8120", Length = "0x80")]
	[Token(Token = "0x6001FDC")]
	public static bool2x3 op_Equality(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF8DA0", Offset = "0x2AF81A0", Length = "0x65")]
	[Token(Token = "0x6001FDD")]
	public static bool2x3 op_Equality(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2AF8E70", Offset = "0x2AF8270", Length = "0x6E")]
	[Token(Token = "0x6001FEB")]
	public static uint2x3 op_ExclusiveOr(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF8F60", Offset = "0x2AF8360", Length = "0x8B")]
	[Token(Token = "0x6001FE9")]
	public static uint2x3 op_ExclusiveOr(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF8EE0", Offset = "0x2AF82E0", Length = "0x72")]
	[Token(Token = "0x6001FEA")]
	public static uint2x3 op_ExclusiveOr(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A42F90", Offset = "0x2A42390", Length = "0x8A")]
	[Token(Token = "0x6001FB6")]
	public static uint2x3 op_Explicit(int2x3 v) { }

	[Address(RVA = "0x2B2EA50", Offset = "0x2B2DE50", Length = "0x26")]
	[Token(Token = "0x6001FB7")]
	public static uint2x3 op_Explicit(float v) { }

	[Address(RVA = "0x2B2EB00", Offset = "0x2B2DF00", Length = "0x3E")]
	[Token(Token = "0x6001FB8")]
	public static uint2x3 op_Explicit(float2x3 v) { }

	[Address(RVA = "0x2B2EA80", Offset = "0x2B2DE80", Length = "0x26")]
	[Token(Token = "0x6001FB9")]
	public static uint2x3 op_Explicit(double v) { }

	[Address(RVA = "0x2A43020", Offset = "0x2A42420", Length = "0x36")]
	[Token(Token = "0x6001FB5")]
	public static uint2x3 op_Explicit(int v) { }

	[Address(RVA = "0x2AF8FF0", Offset = "0x2AF83F0", Length = "0x26")]
	[Token(Token = "0x6001FB3")]
	public static uint2x3 op_Explicit(bool v) { }

	[Address(RVA = "0x2AF9020", Offset = "0x2AF8420", Length = "0x3A")]
	[Token(Token = "0x6001FB4")]
	public static uint2x3 op_Explicit(bool2x3 v) { }

	[Address(RVA = "0x2B2EAB0", Offset = "0x2B2DEB0", Length = "0x45")]
	[Token(Token = "0x6001FBA")]
	public static uint2x3 op_Explicit(double2x3 v) { }

	[Address(RVA = "0x2B2EC90", Offset = "0x2B2E090", Length = "0x80")]
	[Token(Token = "0x6001FD2")]
	public static bool2x3 op_GreaterThan(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2B2ED10", Offset = "0x2B2E110", Length = "0x65")]
	[Token(Token = "0x6001FD3")]
	public static bool2x3 op_GreaterThan(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2B2ED80", Offset = "0x2B2E180", Length = "0x5F")]
	[Token(Token = "0x6001FD4")]
	public static bool2x3 op_GreaterThan(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2B2EC10", Offset = "0x2B2E010", Length = "0x80")]
	[Token(Token = "0x6001FD5")]
	public static bool2x3 op_GreaterThanOrEqual(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2B2EBA0", Offset = "0x2B2DFA0", Length = "0x65")]
	[Token(Token = "0x6001FD6")]
	public static bool2x3 op_GreaterThanOrEqual(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2B2EB40", Offset = "0x2B2DF40", Length = "0x5F")]
	[Token(Token = "0x6001FD7")]
	public static bool2x3 op_GreaterThanOrEqual(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2A43020", Offset = "0x2A42420", Length = "0x36")]
	[Token(Token = "0x6001FB2")]
	public static uint2x3 op_Implicit(uint v) { }

	[Address(RVA = "0x2AF9300", Offset = "0x2AF8700", Length = "0x6B")]
	[Token(Token = "0x6001FCA")]
	public static uint2x3 op_Increment(uint2x3 val) { }

	[Address(RVA = "0x2AF93F0", Offset = "0x2AF87F0", Length = "0x65")]
	[Token(Token = "0x6001FE0")]
	public static bool2x3 op_Inequality(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2AF9370", Offset = "0x2AF8770", Length = "0x80")]
	[Token(Token = "0x6001FDF")]
	public static bool2x3 op_Inequality(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF9460", Offset = "0x2AF8860", Length = "0x5F")]
	[Token(Token = "0x6001FE1")]
	public static bool2x3 op_Inequality(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF94C0", Offset = "0x2AF88C0", Length = "0x75")]
	[Token(Token = "0x6001FDA")]
	public static uint2x3 op_LeftShift(uint2x3 x, int n) { }

	[Address(RVA = "0x2B2F000", Offset = "0x2B2E400", Length = "0x80")]
	[Token(Token = "0x6001FCC")]
	public static bool2x3 op_LessThan(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2B2EFA0", Offset = "0x2B2E3A0", Length = "0x5F")]
	[Token(Token = "0x6001FCE")]
	public static bool2x3 op_LessThan(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2B2EF30", Offset = "0x2B2E330", Length = "0x65")]
	[Token(Token = "0x6001FCD")]
	public static bool2x3 op_LessThan(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2B2EED0", Offset = "0x2B2E2D0", Length = "0x5F")]
	[Token(Token = "0x6001FD1")]
	public static bool2x3 op_LessThanOrEqual(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2B2EE60", Offset = "0x2B2E260", Length = "0x65")]
	[Token(Token = "0x6001FD0")]
	public static bool2x3 op_LessThanOrEqual(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2B2EDE0", Offset = "0x2B2E1E0", Length = "0x80")]
	[Token(Token = "0x6001FCF")]
	public static bool2x3 op_LessThanOrEqual(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2B2F1C0", Offset = "0x2B2E5C0", Length = "0x8D")]
	[Token(Token = "0x6001FC9")]
	public static uint2x3 op_Modulus(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2B2F110", Offset = "0x2B2E510", Length = "0xA5")]
	[Token(Token = "0x6001FC7")]
	public static uint2x3 op_Modulus(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2B2F080", Offset = "0x2B2E480", Length = "0x8D")]
	[Token(Token = "0x6001FC8")]
	public static uint2x3 op_Modulus(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2AF9AA0", Offset = "0x2AF8EA0", Length = "0x91")]
	[Token(Token = "0x6001FBB")]
	public static uint2x3 op_Multiply(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF9A20", Offset = "0x2AF8E20", Length = "0x74")]
	[Token(Token = "0x6001FBD")]
	public static uint2x3 op_Multiply(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF99A0", Offset = "0x2AF8DA0", Length = "0x78")]
	[Token(Token = "0x6001FBC")]
	public static uint2x3 op_Multiply(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2AF9B40", Offset = "0x2AF8F40", Length = "0x68")]
	[Token(Token = "0x6001FE2")]
	public static uint2x3 op_OnesComplement(uint2x3 val) { }

	[Address(RVA = "0x2B2F250", Offset = "0x2B2E650", Length = "0x79")]
	[Token(Token = "0x6001FDB")]
	public static uint2x3 op_RightShift(uint2x3 x, int n) { }

	[Address(RVA = "0x2AF9C30", Offset = "0x2AF9030", Length = "0x75")]
	[Token(Token = "0x6001FC3")]
	public static uint2x3 op_Subtraction(uint lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF9D40", Offset = "0x2AF9140", Length = "0x72")]
	[Token(Token = "0x6001FC2")]
	public static uint2x3 op_Subtraction(uint2x3 lhs, uint rhs) { }

	[Address(RVA = "0x2AF9CB0", Offset = "0x2AF90B0", Length = "0x8B")]
	[Token(Token = "0x6001FC1")]
	public static uint2x3 op_Subtraction(uint2x3 lhs, uint2x3 rhs) { }

	[Address(RVA = "0x2AF9DC0", Offset = "0x2AF91C0", Length = "0x68")]
	[Token(Token = "0x6001FD8")]
	public static uint2x3 op_UnaryNegation(uint2x3 val) { }

	[Address(RVA = "0x2AF9E30", Offset = "0x2AF9230", Length = "0x22DA")]
	[Token(Token = "0x6001FD9")]
	public static uint2x3 op_UnaryPlus(uint2x3 val) { }

	[Address(RVA = "0x2B2E2E0", Offset = "0x2B2D6E0", Length = "0x2C0")]
	[Token(Token = "0x6001FF0")]
	public virtual string ToString() { }

	[Address(RVA = "0x2B2E5B0", Offset = "0x2B2D9B0", Length = "0x2C6")]
	[Token(Token = "0x6001FF1")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

