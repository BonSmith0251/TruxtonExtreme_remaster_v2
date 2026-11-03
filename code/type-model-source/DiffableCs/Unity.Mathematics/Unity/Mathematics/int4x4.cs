namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200004C")]
public struct int4x4 : IEquatable<int4x4>, IFormattable
{
	[Token(Token = "0x4000133")]
	public static readonly int4x4 identity; //Field offset: 0x0
	[Token(Token = "0x4000134")]
	public static readonly int4x4 zero; //Field offset: 0x40
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400012F")]
	public int4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000130")]
	public int4 c1; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000131")]
	public int4 c2; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000132")]
	public int4 c3; //Field offset: 0x30

	[Token(Token = "0x1700099C")]
	public int4 Item
	{
		[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
		[Token(Token = "0x6001E34")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2B0EE30", Offset = "0x2B0E230", Length = "0x62")]
	[Token(Token = "0x6001E3A")]
	private static int4x4() { }

	[Address(RVA = "0x2B0EFD0", Offset = "0x2B0E3D0", Length = "0xE3")]
	[Token(Token = "0x6001DF9")]
	public int4x4(double4x4 v) { }

	[Address(RVA = "0x2B0EEA0", Offset = "0x2B0E2A0", Length = "0xA4")]
	[Token(Token = "0x6001DF8")]
	public int4x4(double v) { }

	[Address(RVA = "0x2A1B4A0", Offset = "0x2A1A8A0", Length = "0x1188")]
	[Token(Token = "0x6001DF7")]
	public int4x4(float4x4 v) { }

	[Address(RVA = "0x2B0EF90", Offset = "0x2B0E390", Length = "0x3F")]
	[Token(Token = "0x6001DF6")]
	public int4x4(float v) { }

	[Address(RVA = "0x2A99340", Offset = "0x2A98740", Length = "0xD6")]
	[Token(Token = "0x6001DF5")]
	public int4x4(uint4x4 v) { }

	[Address(RVA = "0x2A99310", Offset = "0x2A98710", Length = "0x23")]
	[Token(Token = "0x6001DEF")]
	public int4x4(int4 c0, int4 c1, int4 c2, int4 c3) { }

	[Address(RVA = "0x2A1B360", Offset = "0x2A1A760", Length = "0x137")]
	[Token(Token = "0x6001DF3")]
	public int4x4(bool4x4 v) { }

	[Address(RVA = "0x2B0EF50", Offset = "0x2B0E350", Length = "0x40")]
	[Token(Token = "0x6001DF2")]
	public int4x4(bool v) { }

	[Address(RVA = "0x2A992B0", Offset = "0x2A986B0", Length = "0x5B")]
	[Token(Token = "0x6001DF1")]
	public int4x4(int v) { }

	[Address(RVA = "0x2A99420", Offset = "0x2A98820", Length = "0xA9")]
	[Token(Token = "0x6001DF0")]
	public int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33) { }

	[Address(RVA = "0x2A992B0", Offset = "0x2A986B0", Length = "0x5B")]
	[Token(Token = "0x6001DF4")]
	public int4x4(uint v) { }

	[Address(RVA = "0x2A96040", Offset = "0x2A95440", Length = "0xDF6")]
	[Token(Token = "0x6001E35")]
	public override bool Equals(int4x4 rhs) { }

	[Address(RVA = "0x2B0E020", Offset = "0x2B0D420", Length = "0xAB")]
	[Token(Token = "0x6001E36")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x6001E34")]
	public int4 get_Item(int index) { }

	[Address(RVA = "0x2B0E0D0", Offset = "0x2B0D4D0", Length = "0x38")]
	[Token(Token = "0x6001E37")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A994D0", Offset = "0x2A988D0", Length = "0x136")]
	[Token(Token = "0x6001E08")]
	public static int4x4 op_Addition(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A99610", Offset = "0x2A98A10", Length = "0x13E")]
	[Token(Token = "0x6001E07")]
	public static int4x4 op_Addition(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2A99750", Offset = "0x2A98B50", Length = "0x1AA")]
	[Token(Token = "0x6001E06")]
	public static int4x4 op_Addition(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A99900", Offset = "0x2A98D00", Length = "0x1AA")]
	[Token(Token = "0x6001E2B")]
	public static int4x4 op_BitwiseAnd(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A99BE0", Offset = "0x2A98FE0", Length = "0x137")]
	[Token(Token = "0x6001E2C")]
	public static int4x4 op_BitwiseAnd(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2A99AB0", Offset = "0x2A98EB0", Length = "0x12F")]
	[Token(Token = "0x6001E2D")]
	public static int4x4 op_BitwiseAnd(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A99ED0", Offset = "0x2A992D0", Length = "0x137")]
	[Token(Token = "0x6001E2F")]
	public static int4x4 op_BitwiseOr(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2A9A010", Offset = "0x2A99410", Length = "0x12F")]
	[Token(Token = "0x6001E30")]
	public static int4x4 op_BitwiseOr(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A99D20", Offset = "0x2A99120", Length = "0x1AA")]
	[Token(Token = "0x6001E2E")]
	public static int4x4 op_BitwiseOr(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A9A140", Offset = "0x2A99540", Length = "0x13D")]
	[Token(Token = "0x6001E13")]
	public static int4x4 op_Decrement(int4x4 val) { }

	[Address(RVA = "0x2B0F0C0", Offset = "0x2B0E4C0", Length = "0x168")]
	[Token(Token = "0x6001E0E")]
	public static int4x4 op_Division(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2B0F390", Offset = "0x2B0E790", Length = "0x1C4")]
	[Token(Token = "0x6001E0C")]
	public static int4x4 op_Division(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2B0F230", Offset = "0x2B0E630", Length = "0x151")]
	[Token(Token = "0x6001E0D")]
	public static int4x4 op_Division(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2A9A9A0", Offset = "0x2A99DA0", Length = "0xEB")]
	[Token(Token = "0x6001E25")]
	public static bool4x4 op_Equality(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2A9A750", Offset = "0x2A99B50", Length = "0x154")]
	[Token(Token = "0x6001E24")]
	public static bool4x4 op_Equality(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A9A8B0", Offset = "0x2A99CB0", Length = "0xE3")]
	[Token(Token = "0x6001E26")]
	public static bool4x4 op_Equality(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A9AA90", Offset = "0x2A99E90", Length = "0x137")]
	[Token(Token = "0x6001E32")]
	public static int4x4 op_ExclusiveOr(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2A9ABD0", Offset = "0x2A99FD0", Length = "0x12F")]
	[Token(Token = "0x6001E33")]
	public static int4x4 op_ExclusiveOr(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A9AD00", Offset = "0x2A9A100", Length = "0x1AA")]
	[Token(Token = "0x6001E31")]
	public static int4x4 op_ExclusiveOr(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2B0F560", Offset = "0x2B0E960", Length = "0x54")]
	[Token(Token = "0x6001E00")]
	public static int4x4 op_Explicit(float4x4 v) { }

	[Address(RVA = "0x2A45680", Offset = "0x2A44A80", Length = "0xE8")]
	[Token(Token = "0x6001E02")]
	public static int4x4 op_Explicit(double4x4 v) { }

	[Address(RVA = "0x2A45440", Offset = "0x2A44840", Length = "0x42")]
	[Token(Token = "0x6001DFF")]
	public static int4x4 op_Explicit(float v) { }

	[Address(RVA = "0x2A455E0", Offset = "0x2A449E0", Length = "0xA0")]
	[Token(Token = "0x6001DFE")]
	public static int4x4 op_Explicit(uint4x4 v) { }

	[Address(RVA = "0x2A453E0", Offset = "0x2A447E0", Length = "0x5E")]
	[Token(Token = "0x6001DFD")]
	public static int4x4 op_Explicit(uint v) { }

	[Address(RVA = "0x2A9AEE0", Offset = "0x2A9A2E0", Length = "0x39")]
	[Token(Token = "0x6001DFC")]
	public static int4x4 op_Explicit(bool4x4 v) { }

	[Address(RVA = "0x2A45290", Offset = "0x2A44690", Length = "0x43")]
	[Token(Token = "0x6001DFB")]
	public static int4x4 op_Explicit(bool v) { }

	[Address(RVA = "0x2A45770", Offset = "0x2A44B70", Length = "0xA7")]
	[Token(Token = "0x6001E01")]
	public static int4x4 op_Explicit(double v) { }

	[Address(RVA = "0x2B0FB50", Offset = "0x2B0EF50", Length = "0xE3")]
	[Token(Token = "0x6001E1C")]
	public static bool4x4 op_GreaterThan(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2B0FA60", Offset = "0x2B0EE60", Length = "0xEB")]
	[Token(Token = "0x6001E1B")]
	public static bool4x4 op_GreaterThan(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2B0F900", Offset = "0x2B0ED00", Length = "0x154")]
	[Token(Token = "0x6001E1A")]
	public static bool4x4 op_GreaterThan(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2B0F6B0", Offset = "0x2B0EAB0", Length = "0x154")]
	[Token(Token = "0x6001E1D")]
	public static bool4x4 op_GreaterThanOrEqual(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2B0F5C0", Offset = "0x2B0E9C0", Length = "0xEB")]
	[Token(Token = "0x6001E1E")]
	public static bool4x4 op_GreaterThanOrEqual(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2B0F810", Offset = "0x2B0EC10", Length = "0xE3")]
	[Token(Token = "0x6001E1F")]
	public static bool4x4 op_GreaterThanOrEqual(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A453E0", Offset = "0x2A447E0", Length = "0x5E")]
	[Token(Token = "0x6001DFA")]
	public static int4x4 op_Implicit(int v) { }

	[Address(RVA = "0x2A9B5A0", Offset = "0x2A9A9A0", Length = "0x13D")]
	[Token(Token = "0x6001E12")]
	public static int4x4 op_Increment(int4x4 val) { }

	[Address(RVA = "0x2A9B6E0", Offset = "0x2A9AAE0", Length = "0xE3")]
	[Token(Token = "0x6001E29")]
	public static bool4x4 op_Inequality(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A9B7D0", Offset = "0x2A9ABD0", Length = "0xEB")]
	[Token(Token = "0x6001E28")]
	public static bool4x4 op_Inequality(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2A9B8C0", Offset = "0x2A9ACC0", Length = "0x154")]
	[Token(Token = "0x6001E27")]
	public static bool4x4 op_Inequality(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A9BA20", Offset = "0x2A9AE20", Length = "0x135")]
	[Token(Token = "0x6001E22")]
	public static int4x4 op_LeftShift(int4x4 x, int n) { }

	[Address(RVA = "0x2B10160", Offset = "0x2B0F560", Length = "0x154")]
	[Token(Token = "0x6001E14")]
	public static bool4x4 op_LessThan(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2B0FF80", Offset = "0x2B0F380", Length = "0xE3")]
	[Token(Token = "0x6001E16")]
	public static bool4x4 op_LessThan(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2B10070", Offset = "0x2B0F470", Length = "0xEB")]
	[Token(Token = "0x6001E15")]
	public static bool4x4 op_LessThan(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2B0FC40", Offset = "0x2B0F040", Length = "0xEB")]
	[Token(Token = "0x6001E18")]
	public static bool4x4 op_LessThanOrEqual(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2B0FE90", Offset = "0x2B0F290", Length = "0xE3")]
	[Token(Token = "0x6001E19")]
	public static bool4x4 op_LessThanOrEqual(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2B0FD30", Offset = "0x2B0F130", Length = "0x154")]
	[Token(Token = "0x6001E17")]
	public static bool4x4 op_LessThanOrEqual(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2B10420", Offset = "0x2B0F820", Length = "0x1C4")]
	[Token(Token = "0x6001E0F")]
	public static int4x4 op_Modulus(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2B105F0", Offset = "0x2B0F9F0", Length = "0x168")]
	[Token(Token = "0x6001E11")]
	public static int4x4 op_Modulus(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2B102C0", Offset = "0x2B0F6C0", Length = "0x151")]
	[Token(Token = "0x6001E10")]
	public static int4x4 op_Modulus(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2A9C9C0", Offset = "0x2A9BDC0", Length = "0x13F")]
	[Token(Token = "0x6001E05")]
	public static int4x4 op_Multiply(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A9C6B0", Offset = "0x2A9BAB0", Length = "0x147")]
	[Token(Token = "0x6001E04")]
	public static int4x4 op_Multiply(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2A9C800", Offset = "0x2A9BC00", Length = "0x1BA")]
	[Token(Token = "0x6001E03")]
	public static int4x4 op_Multiply(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A9CB00", Offset = "0x2A9BF00", Length = "0x127")]
	[Token(Token = "0x6001E2A")]
	public static int4x4 op_OnesComplement(int4x4 val) { }

	[Address(RVA = "0x2B10760", Offset = "0x2B0FB60", Length = "0x135")]
	[Token(Token = "0x6001E23")]
	public static int4x4 op_RightShift(int4x4 x, int n) { }

	[Address(RVA = "0x2A9D060", Offset = "0x2A9C460", Length = "0x155")]
	[Token(Token = "0x6001E0B")]
	public static int4x4 op_Subtraction(int lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A9CD70", Offset = "0x2A9C170", Length = "0x137")]
	[Token(Token = "0x6001E0A")]
	public static int4x4 op_Subtraction(int4x4 lhs, int rhs) { }

	[Address(RVA = "0x2A9CEB0", Offset = "0x2A9C2B0", Length = "0x1AA")]
	[Token(Token = "0x6001E09")]
	public static int4x4 op_Subtraction(int4x4 lhs, int4x4 rhs) { }

	[Address(RVA = "0x2A9D1C0", Offset = "0x2A9C5C0", Length = "0x127")]
	[Token(Token = "0x6001E20")]
	public static int4x4 op_UnaryNegation(int4x4 val) { }

	[Address(RVA = "0x2A9D2F0", Offset = "0x2A9C6F0", Length = "0x9AC")]
	[Token(Token = "0x6001E21")]
	public static int4x4 op_UnaryPlus(int4x4 val) { }

	[Address(RVA = "0x2B0E790", Offset = "0x2B0DB90", Length = "0x69B")]
	[Token(Token = "0x6001E38")]
	public virtual string ToString() { }

	[Address(RVA = "0x2B0E110", Offset = "0x2B0D510", Length = "0x676")]
	[Token(Token = "0x6001E39")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

