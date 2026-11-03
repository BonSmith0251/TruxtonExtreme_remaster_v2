namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000056")]
public struct uint2x2 : IEquatable<uint2x2>, IFormattable
{
	[Token(Token = "0x4000146")]
	public static readonly uint2x2 identity; //Field offset: 0x0
	[Token(Token = "0x4000147")]
	public static readonly uint2x2 zero; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000144")]
	public uint2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000145")]
	public uint2 c1; //Field offset: 0x8

	[Token(Token = "0x170009BA")]
	public uint2 Item
	{
		[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
		[Token(Token = "0x6001FA0")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2B2D7C0", Offset = "0x2B2CBC0", Length = "0x66")]
	[Token(Token = "0x6001FA6")]
	private static uint2x2() { }

	[Address(RVA = "0x2B2D8C0", Offset = "0x2B2CCC0", Length = "0x86")]
	[Token(Token = "0x6001F65")]
	public uint2x2(double2x2 v) { }

	[Address(RVA = "0x2A21100", Offset = "0x2A20500", Length = "0x69")]
	[Token(Token = "0x6001F64")]
	public uint2x2(double v) { }

	[Address(RVA = "0x2B2D830", Offset = "0x2B2CC30", Length = "0x8B")]
	[Token(Token = "0x6001F63")]
	public uint2x2(float2x2 v) { }

	[Address(RVA = "0x2A21090", Offset = "0x2A20490", Length = "0x68")]
	[Token(Token = "0x6001F62")]
	public uint2x2(float v) { }

	[Address(RVA = "0x2AF69E0", Offset = "0x2AF5DE0", Length = "0x31")]
	[Token(Token = "0x6001F61")]
	public uint2x2(int2x2 v) { }

	[Address(RVA = "0xE1C7E0", Offset = "0xE1BBE0", Length = "0x8")]
	[Token(Token = "0x6001F5B")]
	public uint2x2(uint2 c0, uint2 c1) { }

	[Address(RVA = "0x2A1ABA0", Offset = "0x2A19FA0", Length = "0x9A")]
	[Token(Token = "0x6001F5F")]
	public uint2x2(bool2x2 v) { }

	[Address(RVA = "0x2AF6950", Offset = "0x2AF5D50", Length = "0x53")]
	[Token(Token = "0x6001F5E")]
	public uint2x2(bool v) { }

	[Address(RVA = "0x2AF6890", Offset = "0x2AF5C90", Length = "0x22")]
	[Token(Token = "0x6001F5D")]
	public uint2x2(uint v) { }

	[Address(RVA = "0x2AF69B0", Offset = "0x2AF5DB0", Length = "0x28")]
	[Token(Token = "0x6001F5C")]
	public uint2x2(uint m00, uint m01, uint m10, uint m11) { }

	[Address(RVA = "0x2AF6890", Offset = "0x2AF5C90", Length = "0x22")]
	[Token(Token = "0x6001F60")]
	public uint2x2(int v) { }

	[Address(RVA = "0x2AF61E0", Offset = "0x2AF55E0", Length = "0x27")]
	[Token(Token = "0x6001FA1")]
	public override bool Equals(uint2x2 rhs) { }

	[Address(RVA = "0x2B2D230", Offset = "0x2B2C630", Length = "0xAB")]
	[Token(Token = "0x6001FA2")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
	[Token(Token = "0x6001FA0")]
	public uint2 get_Item(int index) { }

	[Address(RVA = "0x2B2D2E0", Offset = "0x2B2C6E0", Length = "0xC8")]
	[Token(Token = "0x6001FA3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AF6A20", Offset = "0x2AF5E20", Length = "0x42")]
	[Token(Token = "0x6001F74")]
	public static uint2x2 op_Addition(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF6AD0", Offset = "0x2AF5ED0", Length = "0x43")]
	[Token(Token = "0x6001F73")]
	public static uint2x2 op_Addition(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2AF6A70", Offset = "0x2AF5E70", Length = "0x54")]
	[Token(Token = "0x6001F72")]
	public static uint2x2 op_Addition(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF6BC0", Offset = "0x2AF5FC0", Length = "0x57")]
	[Token(Token = "0x6001F97")]
	public static uint2x2 op_BitwiseAnd(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF6B70", Offset = "0x2AF5F70", Length = "0x46")]
	[Token(Token = "0x6001F98")]
	public static uint2x2 op_BitwiseAnd(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2AF6B20", Offset = "0x2AF5F20", Length = "0x46")]
	[Token(Token = "0x6001F99")]
	public static uint2x2 op_BitwiseAnd(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF6CD0", Offset = "0x2AF60D0", Length = "0x46")]
	[Token(Token = "0x6001F9B")]
	public static uint2x2 op_BitwiseOr(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2AF6C80", Offset = "0x2AF6080", Length = "0x46")]
	[Token(Token = "0x6001F9C")]
	public static uint2x2 op_BitwiseOr(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF6C20", Offset = "0x2AF6020", Length = "0x57")]
	[Token(Token = "0x6001F9A")]
	public static uint2x2 op_BitwiseOr(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF6D20", Offset = "0x2AF6120", Length = "0x43")]
	[Token(Token = "0x6001F7F")]
	public static uint2x2 op_Decrement(uint2x2 val) { }

	[Address(RVA = "0x2B2DA30", Offset = "0x2B2CE30", Length = "0x57")]
	[Token(Token = "0x6001F7A")]
	public static uint2x2 op_Division(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2B2D950", Offset = "0x2B2CD50", Length = "0x71")]
	[Token(Token = "0x6001F78")]
	public static uint2x2 op_Division(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2B2D9D0", Offset = "0x2B2CDD0", Length = "0x57")]
	[Token(Token = "0x6001F79")]
	public static uint2x2 op_Division(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2AF6F90", Offset = "0x2AF6390", Length = "0x68")]
	[Token(Token = "0x6001F91")]
	public static bool2x2 op_Equality(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2AF6F10", Offset = "0x2AF6310", Length = "0x79")]
	[Token(Token = "0x6001F90")]
	public static bool2x2 op_Equality(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF6EA0", Offset = "0x2AF62A0", Length = "0x6C")]
	[Token(Token = "0x6001F92")]
	public static bool2x2 op_Equality(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF7000", Offset = "0x2AF6400", Length = "0x46")]
	[Token(Token = "0x6001F9E")]
	public static uint2x2 op_ExclusiveOr(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2AF70B0", Offset = "0x2AF64B0", Length = "0x46")]
	[Token(Token = "0x6001F9F")]
	public static uint2x2 op_ExclusiveOr(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF7050", Offset = "0x2AF6450", Length = "0x57")]
	[Token(Token = "0x6001F9D")]
	public static uint2x2 op_ExclusiveOr(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2A6EDB0", Offset = "0x2A6E1B0", Length = "0x8C")]
	[Token(Token = "0x6001F6C")]
	public static uint2x2 op_Explicit(float2x2 v) { }

	[Address(RVA = "0x2A6ED10", Offset = "0x2A6E110", Length = "0x9C")]
	[Token(Token = "0x6001F6E")]
	public static uint2x2 op_Explicit(double2x2 v) { }

	[Address(RVA = "0x2A6EC30", Offset = "0x2A6E030", Length = "0x6E")]
	[Token(Token = "0x6001F6B")]
	public static uint2x2 op_Explicit(float v) { }

	[Address(RVA = "0x2A42E00", Offset = "0x2A42200", Length = "0x49")]
	[Token(Token = "0x6001F6A")]
	public static uint2x2 op_Explicit(int2x2 v) { }

	[Address(RVA = "0x2A42D10", Offset = "0x2A42110", Length = "0x25")]
	[Token(Token = "0x6001F69")]
	public static uint2x2 op_Explicit(int v) { }

	[Address(RVA = "0x2AF7100", Offset = "0x2AF6500", Length = "0x20")]
	[Token(Token = "0x6001F68")]
	public static uint2x2 op_Explicit(bool2x2 v) { }

	[Address(RVA = "0x2A42E90", Offset = "0x2A42290", Length = "0x59")]
	[Token(Token = "0x6001F67")]
	public static uint2x2 op_Explicit(bool v) { }

	[Address(RVA = "0x2A6ECA0", Offset = "0x2A6E0A0", Length = "0x6F")]
	[Token(Token = "0x6001F6D")]
	public static uint2x2 op_Explicit(double v) { }

	[Address(RVA = "0x2B2DBF0", Offset = "0x2B2CFF0", Length = "0x6C")]
	[Token(Token = "0x6001F88")]
	public static bool2x2 op_GreaterThan(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2B2DC60", Offset = "0x2B2D060", Length = "0x68")]
	[Token(Token = "0x6001F87")]
	public static bool2x2 op_GreaterThan(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B2DCD0", Offset = "0x2B2D0D0", Length = "0x79")]
	[Token(Token = "0x6001F86")]
	public static bool2x2 op_GreaterThan(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2B2DA90", Offset = "0x2B2CE90", Length = "0x79")]
	[Token(Token = "0x6001F89")]
	public static bool2x2 op_GreaterThanOrEqual(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2B2DB10", Offset = "0x2B2CF10", Length = "0x68")]
	[Token(Token = "0x6001F8A")]
	public static bool2x2 op_GreaterThanOrEqual(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B2DB80", Offset = "0x2B2CF80", Length = "0x6C")]
	[Token(Token = "0x6001F8B")]
	public static bool2x2 op_GreaterThanOrEqual(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2A42D10", Offset = "0x2A42110", Length = "0x25")]
	[Token(Token = "0x6001F66")]
	public static uint2x2 op_Implicit(uint v) { }

	[Address(RVA = "0x2AF73E0", Offset = "0x2AF67E0", Length = "0x43")]
	[Token(Token = "0x6001F7E")]
	public static uint2x2 op_Increment(uint2x2 val) { }

	[Address(RVA = "0x2AF74B0", Offset = "0x2AF68B0", Length = "0x6C")]
	[Token(Token = "0x6001F95")]
	public static bool2x2 op_Inequality(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF7520", Offset = "0x2AF6920", Length = "0x68")]
	[Token(Token = "0x6001F94")]
	public static bool2x2 op_Inequality(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2AF7430", Offset = "0x2AF6830", Length = "0x79")]
	[Token(Token = "0x6001F93")]
	public static bool2x2 op_Inequality(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF7590", Offset = "0x2AF6990", Length = "0x4D")]
	[Token(Token = "0x6001F8E")]
	public static uint2x2 op_LeftShift(uint2x2 x, int n) { }

	[Address(RVA = "0x2B2DF20", Offset = "0x2B2D320", Length = "0x79")]
	[Token(Token = "0x6001F80")]
	public static bool2x2 op_LessThan(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2B2DEB0", Offset = "0x2B2D2B0", Length = "0x6C")]
	[Token(Token = "0x6001F82")]
	public static bool2x2 op_LessThan(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2B2DFA0", Offset = "0x2B2D3A0", Length = "0x68")]
	[Token(Token = "0x6001F81")]
	public static bool2x2 op_LessThan(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B2DDC0", Offset = "0x2B2D1C0", Length = "0x68")]
	[Token(Token = "0x6001F84")]
	public static bool2x2 op_LessThanOrEqual(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2B2DD50", Offset = "0x2B2D150", Length = "0x6C")]
	[Token(Token = "0x6001F85")]
	public static bool2x2 op_LessThanOrEqual(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2B2DE30", Offset = "0x2B2D230", Length = "0x79")]
	[Token(Token = "0x6001F83")]
	public static bool2x2 op_LessThanOrEqual(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2B2E070", Offset = "0x2B2D470", Length = "0x71")]
	[Token(Token = "0x6001F7B")]
	public static uint2x2 op_Modulus(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2B2E0F0", Offset = "0x2B2D4F0", Length = "0x57")]
	[Token(Token = "0x6001F7D")]
	public static uint2x2 op_Modulus(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2B2E010", Offset = "0x2B2D410", Length = "0x57")]
	[Token(Token = "0x6001F7C")]
	public static uint2x2 op_Modulus(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2AF7A30", Offset = "0x2AF6E30", Length = "0x4A")]
	[Token(Token = "0x6001F71")]
	public static uint2x2 op_Multiply(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF7A80", Offset = "0x2AF6E80", Length = "0x4A")]
	[Token(Token = "0x6001F70")]
	public static uint2x2 op_Multiply(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2AF79D0", Offset = "0x2AF6DD0", Length = "0x5B")]
	[Token(Token = "0x6001F6F")]
	public static uint2x2 op_Multiply(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF7AD0", Offset = "0x2AF6ED0", Length = "0x43")]
	[Token(Token = "0x6001F96")]
	public static uint2x2 op_OnesComplement(uint2x2 val) { }

	[Address(RVA = "0x2B2E150", Offset = "0x2B2D550", Length = "0x51")]
	[Token(Token = "0x6001F8F")]
	public static uint2x2 op_RightShift(uint2x2 x, int n) { }

	[Address(RVA = "0x2AF7B70", Offset = "0x2AF6F70", Length = "0x4B")]
	[Token(Token = "0x6001F77")]
	public static uint2x2 op_Subtraction(uint lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF7C20", Offset = "0x2AF7020", Length = "0x46")]
	[Token(Token = "0x6001F76")]
	public static uint2x2 op_Subtraction(uint2x2 lhs, uint rhs) { }

	[Address(RVA = "0x2AF7BC0", Offset = "0x2AF6FC0", Length = "0x57")]
	[Token(Token = "0x6001F75")]
	public static uint2x2 op_Subtraction(uint2x2 lhs, uint2x2 rhs) { }

	[Address(RVA = "0x2AF7C70", Offset = "0x2AF7070", Length = "0x43")]
	[Token(Token = "0x6001F8C")]
	public static uint2x2 op_UnaryNegation(uint2x2 val) { }

	[Address(RVA = "0x2AF7CC0", Offset = "0x2AF70C0", Length = "0x34")]
	[Token(Token = "0x6001F8D")]
	public static uint2x2 op_UnaryPlus(uint2x2 val) { }

	[Address(RVA = "0x2B2D5C0", Offset = "0x2B2C9C0", Length = "0x1F4")]
	[Token(Token = "0x6001FA4")]
	public virtual string ToString() { }

	[Address(RVA = "0x2B2D3B0", Offset = "0x2B2C7B0", Length = "0x20A")]
	[Token(Token = "0x6001FA5")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

