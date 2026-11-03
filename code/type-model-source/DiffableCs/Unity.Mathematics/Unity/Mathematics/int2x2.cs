namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000040")]
public struct int2x2 : IEquatable<int2x2>, IFormattable
{
	[Token(Token = "0x4000100")]
	public static readonly int2x2 identity; //Field offset: 0x0
	[Token(Token = "0x4000101")]
	public static readonly int2x2 zero; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000FE")]
	public int2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000FF")]
	public int2 c1; //Field offset: 0x8

	[Token(Token = "0x170007CD")]
	public int2 Item
	{
		[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
		[Token(Token = "0x600192B")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2AF67A0", Offset = "0x2AF5BA0", Length = "0x66")]
	[Token(Token = "0x6001931")]
	private static int2x2() { }

	[Address(RVA = "0x2AF6850", Offset = "0x2AF5C50", Length = "0x3B")]
	[Token(Token = "0x60018F0")]
	public int2x2(double2x2 v) { }

	[Address(RVA = "0x2AF68C0", Offset = "0x2AF5CC0", Length = "0x32")]
	[Token(Token = "0x60018EF")]
	public int2x2(double v) { }

	[Address(RVA = "0x2AF6900", Offset = "0x2AF5D00", Length = "0x42")]
	[Token(Token = "0x60018EE")]
	public int2x2(float2x2 v) { }

	[Address(RVA = "0x2AF6810", Offset = "0x2AF5C10", Length = "0x32")]
	[Token(Token = "0x60018ED")]
	public int2x2(float v) { }

	[Address(RVA = "0x2AF69E0", Offset = "0x2AF5DE0", Length = "0x31")]
	[Token(Token = "0x60018EC")]
	public int2x2(uint2x2 v) { }

	[Address(RVA = "0xE1C7E0", Offset = "0xE1BBE0", Length = "0x8")]
	[Token(Token = "0x60018E6")]
	public int2x2(int2 c0, int2 c1) { }

	[Address(RVA = "0x2A1ABA0", Offset = "0x2A19FA0", Length = "0x9A")]
	[Token(Token = "0x60018EA")]
	public int2x2(bool2x2 v) { }

	[Address(RVA = "0x2AF6950", Offset = "0x2AF5D50", Length = "0x53")]
	[Token(Token = "0x60018E9")]
	public int2x2(bool v) { }

	[Address(RVA = "0x2AF6890", Offset = "0x2AF5C90", Length = "0x22")]
	[Token(Token = "0x60018E8")]
	public int2x2(int v) { }

	[Address(RVA = "0x2AF69B0", Offset = "0x2AF5DB0", Length = "0x28")]
	[Token(Token = "0x60018E7")]
	public int2x2(int m00, int m01, int m10, int m11) { }

	[Address(RVA = "0x2AF6890", Offset = "0x2AF5C90", Length = "0x22")]
	[Token(Token = "0x60018EB")]
	public int2x2(uint v) { }

	[Address(RVA = "0x2AF61E0", Offset = "0x2AF55E0", Length = "0x27")]
	[Token(Token = "0x600192C")]
	public override bool Equals(int2x2 rhs) { }

	[Address(RVA = "0x2AF6210", Offset = "0x2AF5610", Length = "0xAB")]
	[Token(Token = "0x600192D")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
	[Token(Token = "0x600192B")]
	public int2 get_Item(int index) { }

	[Address(RVA = "0x2AF62C0", Offset = "0x2AF56C0", Length = "0xC8")]
	[Token(Token = "0x600192E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AF6A20", Offset = "0x2AF5E20", Length = "0x42")]
	[Token(Token = "0x60018FF")]
	public static int2x2 op_Addition(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF6AD0", Offset = "0x2AF5ED0", Length = "0x43")]
	[Token(Token = "0x60018FE")]
	public static int2x2 op_Addition(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF6A70", Offset = "0x2AF5E70", Length = "0x54")]
	[Token(Token = "0x60018FD")]
	public static int2x2 op_Addition(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF6BC0", Offset = "0x2AF5FC0", Length = "0x57")]
	[Token(Token = "0x6001922")]
	public static int2x2 op_BitwiseAnd(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF6B70", Offset = "0x2AF5F70", Length = "0x46")]
	[Token(Token = "0x6001923")]
	public static int2x2 op_BitwiseAnd(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF6B20", Offset = "0x2AF5F20", Length = "0x46")]
	[Token(Token = "0x6001924")]
	public static int2x2 op_BitwiseAnd(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF6CD0", Offset = "0x2AF60D0", Length = "0x46")]
	[Token(Token = "0x6001926")]
	public static int2x2 op_BitwiseOr(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF6C80", Offset = "0x2AF6080", Length = "0x46")]
	[Token(Token = "0x6001927")]
	public static int2x2 op_BitwiseOr(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF6C20", Offset = "0x2AF6020", Length = "0x57")]
	[Token(Token = "0x6001925")]
	public static int2x2 op_BitwiseOr(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF6D20", Offset = "0x2AF6120", Length = "0x43")]
	[Token(Token = "0x600190A")]
	public static int2x2 op_Decrement(int2x2 val) { }

	[Address(RVA = "0x2AF6D70", Offset = "0x2AF6170", Length = "0x52")]
	[Token(Token = "0x6001905")]
	public static int2x2 op_Division(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF6E30", Offset = "0x2AF6230", Length = "0x6D")]
	[Token(Token = "0x6001903")]
	public static int2x2 op_Division(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF6DD0", Offset = "0x2AF61D0", Length = "0x53")]
	[Token(Token = "0x6001904")]
	public static int2x2 op_Division(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF6F90", Offset = "0x2AF6390", Length = "0x68")]
	[Token(Token = "0x600191C")]
	public static bool2x2 op_Equality(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF6F10", Offset = "0x2AF6310", Length = "0x79")]
	[Token(Token = "0x600191B")]
	public static bool2x2 op_Equality(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF6EA0", Offset = "0x2AF62A0", Length = "0x6C")]
	[Token(Token = "0x600191D")]
	public static bool2x2 op_Equality(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7000", Offset = "0x2AF6400", Length = "0x46")]
	[Token(Token = "0x6001929")]
	public static int2x2 op_ExclusiveOr(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF70B0", Offset = "0x2AF64B0", Length = "0x46")]
	[Token(Token = "0x600192A")]
	public static int2x2 op_ExclusiveOr(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7050", Offset = "0x2AF6450", Length = "0x57")]
	[Token(Token = "0x6001928")]
	public static int2x2 op_ExclusiveOr(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2A42CC0", Offset = "0x2A420C0", Length = "0x4A")]
	[Token(Token = "0x60018F7")]
	public static int2x2 op_Explicit(float2x2 v) { }

	[Address(RVA = "0x2A42D70", Offset = "0x2A42170", Length = "0x4C")]
	[Token(Token = "0x60018F9")]
	public static int2x2 op_Explicit(double2x2 v) { }

	[Address(RVA = "0x2A42DC0", Offset = "0x2A421C0", Length = "0x35")]
	[Token(Token = "0x60018F6")]
	public static int2x2 op_Explicit(float v) { }

	[Address(RVA = "0x2A42E00", Offset = "0x2A42200", Length = "0x49")]
	[Token(Token = "0x60018F5")]
	public static int2x2 op_Explicit(uint2x2 v) { }

	[Address(RVA = "0x2A42D10", Offset = "0x2A42110", Length = "0x25")]
	[Token(Token = "0x60018F4")]
	public static int2x2 op_Explicit(uint v) { }

	[Address(RVA = "0x2AF7100", Offset = "0x2AF6500", Length = "0x20")]
	[Token(Token = "0x60018F3")]
	public static int2x2 op_Explicit(bool2x2 v) { }

	[Address(RVA = "0x2A42E90", Offset = "0x2A42290", Length = "0x59")]
	[Token(Token = "0x60018F2")]
	public static int2x2 op_Explicit(bool v) { }

	[Address(RVA = "0x2A42E50", Offset = "0x2A42250", Length = "0x35")]
	[Token(Token = "0x60018F8")]
	public static int2x2 op_Explicit(double v) { }

	[Address(RVA = "0x2AF7370", Offset = "0x2AF6770", Length = "0x6C")]
	[Token(Token = "0x6001913")]
	public static bool2x2 op_GreaterThan(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7300", Offset = "0x2AF6700", Length = "0x68")]
	[Token(Token = "0x6001912")]
	public static bool2x2 op_GreaterThan(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF7280", Offset = "0x2AF6680", Length = "0x79")]
	[Token(Token = "0x6001911")]
	public static bool2x2 op_GreaterThan(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7200", Offset = "0x2AF6600", Length = "0x79")]
	[Token(Token = "0x6001914")]
	public static bool2x2 op_GreaterThanOrEqual(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7120", Offset = "0x2AF6520", Length = "0x68")]
	[Token(Token = "0x6001915")]
	public static bool2x2 op_GreaterThanOrEqual(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF7190", Offset = "0x2AF6590", Length = "0x6C")]
	[Token(Token = "0x6001916")]
	public static bool2x2 op_GreaterThanOrEqual(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2A42D10", Offset = "0x2A42110", Length = "0x25")]
	[Token(Token = "0x60018F1")]
	public static int2x2 op_Implicit(int v) { }

	[Address(RVA = "0x2AF73E0", Offset = "0x2AF67E0", Length = "0x43")]
	[Token(Token = "0x6001909")]
	public static int2x2 op_Increment(int2x2 val) { }

	[Address(RVA = "0x2AF74B0", Offset = "0x2AF68B0", Length = "0x6C")]
	[Token(Token = "0x6001920")]
	public static bool2x2 op_Inequality(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7520", Offset = "0x2AF6920", Length = "0x68")]
	[Token(Token = "0x600191F")]
	public static bool2x2 op_Inequality(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF7430", Offset = "0x2AF6830", Length = "0x79")]
	[Token(Token = "0x600191E")]
	public static bool2x2 op_Inequality(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7590", Offset = "0x2AF6990", Length = "0x4D")]
	[Token(Token = "0x6001919")]
	public static int2x2 op_LeftShift(int2x2 x, int n) { }

	[Address(RVA = "0x2AF77B0", Offset = "0x2AF6BB0", Length = "0x79")]
	[Token(Token = "0x600190B")]
	public static bool2x2 op_LessThan(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7740", Offset = "0x2AF6B40", Length = "0x6C")]
	[Token(Token = "0x600190D")]
	public static bool2x2 op_LessThan(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7830", Offset = "0x2AF6C30", Length = "0x68")]
	[Token(Token = "0x600190C")]
	public static bool2x2 op_LessThan(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF76D0", Offset = "0x2AF6AD0", Length = "0x68")]
	[Token(Token = "0x600190F")]
	public static bool2x2 op_LessThanOrEqual(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF7660", Offset = "0x2AF6A60", Length = "0x6C")]
	[Token(Token = "0x6001910")]
	public static bool2x2 op_LessThanOrEqual(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF75E0", Offset = "0x2AF69E0", Length = "0x79")]
	[Token(Token = "0x600190E")]
	public static bool2x2 op_LessThanOrEqual(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7960", Offset = "0x2AF6D60", Length = "0x6D")]
	[Token(Token = "0x6001906")]
	public static int2x2 op_Modulus(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7900", Offset = "0x2AF6D00", Length = "0x52")]
	[Token(Token = "0x6001908")]
	public static int2x2 op_Modulus(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF78A0", Offset = "0x2AF6CA0", Length = "0x53")]
	[Token(Token = "0x6001907")]
	public static int2x2 op_Modulus(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF7A30", Offset = "0x2AF6E30", Length = "0x4A")]
	[Token(Token = "0x60018FC")]
	public static int2x2 op_Multiply(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7A80", Offset = "0x2AF6E80", Length = "0x4A")]
	[Token(Token = "0x60018FB")]
	public static int2x2 op_Multiply(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF79D0", Offset = "0x2AF6DD0", Length = "0x5B")]
	[Token(Token = "0x60018FA")]
	public static int2x2 op_Multiply(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7AD0", Offset = "0x2AF6ED0", Length = "0x43")]
	[Token(Token = "0x6001921")]
	public static int2x2 op_OnesComplement(int2x2 val) { }

	[Address(RVA = "0x2AF7B20", Offset = "0x2AF6F20", Length = "0x4D")]
	[Token(Token = "0x600191A")]
	public static int2x2 op_RightShift(int2x2 x, int n) { }

	[Address(RVA = "0x2AF7B70", Offset = "0x2AF6F70", Length = "0x4B")]
	[Token(Token = "0x6001902")]
	public static int2x2 op_Subtraction(int lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7C20", Offset = "0x2AF7020", Length = "0x46")]
	[Token(Token = "0x6001901")]
	public static int2x2 op_Subtraction(int2x2 lhs, int rhs) { }

	[Address(RVA = "0x2AF7BC0", Offset = "0x2AF6FC0", Length = "0x57")]
	[Token(Token = "0x6001900")]
	public static int2x2 op_Subtraction(int2x2 lhs, int2x2 rhs) { }

	[Address(RVA = "0x2AF7C70", Offset = "0x2AF7070", Length = "0x43")]
	[Token(Token = "0x6001917")]
	public static int2x2 op_UnaryNegation(int2x2 val) { }

	[Address(RVA = "0x2AF7CC0", Offset = "0x2AF70C0", Length = "0x34")]
	[Token(Token = "0x6001918")]
	public static int2x2 op_UnaryPlus(int2x2 val) { }

	[Address(RVA = "0x2AF6390", Offset = "0x2AF5790", Length = "0x1F4")]
	[Token(Token = "0x600192F")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AF6590", Offset = "0x2AF5990", Length = "0x20A")]
	[Token(Token = "0x6001930")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

