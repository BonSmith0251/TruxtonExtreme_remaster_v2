namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000047")]
public struct int3x4 : IEquatable<int3x4>, IFormattable
{
	[Token(Token = "0x400011E")]
	public static readonly int3x4 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400011A")]
	public int3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400011B")]
	public int3 c1; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400011C")]
	public int3 c2; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400011D")]
	public int3 c3; //Field offset: 0x24

	[Token(Token = "0x17000848")]
	public int3 Item
	{
		[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
		[Token(Token = "0x6001B74")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x2A86E40", Offset = "0x2A86240", Length = "0x45")]
	[Token(Token = "0x6001B2F")]
	public int3x4(int3 c0, int3 c1, int3 c2, int3 c3) { }

	[Address(RVA = "0x2A86CD0", Offset = "0x2A860D0", Length = "0x81")]
	[Token(Token = "0x6001B30")]
	public int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23) { }

	[Address(RVA = "0x2A86C70", Offset = "0x2A86070", Length = "0x58")]
	[Token(Token = "0x6001B31")]
	public int3x4(int v) { }

	[Address(RVA = "0x2A1B0A0", Offset = "0x2A1A4A0", Length = "0xB5")]
	[Token(Token = "0x6001B32")]
	public int3x4(bool v) { }

	[Address(RVA = "0x2A1B160", Offset = "0x2A1A560", Length = "0x110")]
	[Token(Token = "0x6001B33")]
	public int3x4(bool3x4 v) { }

	[Address(RVA = "0x2A86C70", Offset = "0x2A86070", Length = "0x58")]
	[Token(Token = "0x6001B34")]
	public int3x4(uint v) { }

	[Address(RVA = "0x2A86D60", Offset = "0x2A86160", Length = "0xDC")]
	[Token(Token = "0x6001B35")]
	public int3x4(uint3x4 v) { }

	[Address(RVA = "0x2B054C0", Offset = "0x2B048C0", Length = "0x88")]
	[Token(Token = "0x6001B36")]
	public int3x4(float v) { }

	[Address(RVA = "0x2B05400", Offset = "0x2B04800", Length = "0xBD")]
	[Token(Token = "0x6001B37")]
	public int3x4(float3x4 v) { }

	[Address(RVA = "0x2B05550", Offset = "0x2B04950", Length = "0x88")]
	[Token(Token = "0x6001B38")]
	public int3x4(double v) { }

	[Address(RVA = "0x2B055E0", Offset = "0x2B049E0", Length = "0xDB")]
	[Token(Token = "0x6001B39")]
	public int3x4(double3x4 v) { }

	[Address(RVA = "0x2A7FFB0", Offset = "0x2A7F3B0", Length = "0x1FEE")]
	[Token(Token = "0x6001B75")]
	public override bool Equals(int3x4 rhs) { }

	[Address(RVA = "0x2B04920", Offset = "0x2B03D20", Length = "0xA2")]
	[Token(Token = "0x6001B76")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
	[Token(Token = "0x6001B74")]
	public int3 get_Item(int index) { }

	[Address(RVA = "0x2B049D0", Offset = "0x2B03DD0", Length = "0x2F")]
	[Token(Token = "0x6001B77")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A86E90", Offset = "0x2A86290", Length = "0x1F3")]
	[Token(Token = "0x6001B46")]
	public static int3x4 op_Addition(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A87090", Offset = "0x2A86490", Length = "0x11C")]
	[Token(Token = "0x6001B47")]
	public static int3x4 op_Addition(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2A871B0", Offset = "0x2A865B0", Length = "0x114")]
	[Token(Token = "0x6001B48")]
	public static int3x4 op_Addition(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A87510", Offset = "0x2A86910", Length = "0x1E0")]
	[Token(Token = "0x6001B6B")]
	public static int3x4 op_BitwiseAnd(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A872D0", Offset = "0x2A866D0", Length = "0x115")]
	[Token(Token = "0x6001B6C")]
	public static int3x4 op_BitwiseAnd(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2A873F0", Offset = "0x2A867F0", Length = "0x117")]
	[Token(Token = "0x6001B6D")]
	public static int3x4 op_BitwiseAnd(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A87810", Offset = "0x2A86C10", Length = "0x117")]
	[Token(Token = "0x6001B70")]
	public static int3x4 op_BitwiseOr(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A87930", Offset = "0x2A86D30", Length = "0x1E0")]
	[Token(Token = "0x6001B6E")]
	public static int3x4 op_BitwiseOr(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A876F0", Offset = "0x2A86AF0", Length = "0x115")]
	[Token(Token = "0x6001B6F")]
	public static int3x4 op_BitwiseOr(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2A87B10", Offset = "0x2A86F10", Length = "0x139")]
	[Token(Token = "0x6001B53")]
	public static int3x4 op_Decrement(int3x4 val) { }

	[Address(RVA = "0x2B05A10", Offset = "0x2B04E10", Length = "0x142")]
	[Token(Token = "0x6001B4E")]
	public static int3x4 op_Division(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2B058D0", Offset = "0x2B04CD0", Length = "0x13B")]
	[Token(Token = "0x6001B4D")]
	public static int3x4 op_Division(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2B056C0", Offset = "0x2B04AC0", Length = "0x203")]
	[Token(Token = "0x6001B4C")]
	public static int3x4 op_Division(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A88420", Offset = "0x2A87820", Length = "0x11C")]
	[Token(Token = "0x6001B66")]
	public static bool3x4 op_Equality(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A88220", Offset = "0x2A87620", Length = "0x1FE")]
	[Token(Token = "0x6001B64")]
	public static bool3x4 op_Equality(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A88100", Offset = "0x2A87500", Length = "0x120")]
	[Token(Token = "0x6001B65")]
	public static bool3x4 op_Equality(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2A88660", Offset = "0x2A87A60", Length = "0x117")]
	[Token(Token = "0x6001B73")]
	public static int3x4 op_ExclusiveOr(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A88780", Offset = "0x2A87B80", Length = "0x1E0")]
	[Token(Token = "0x6001B71")]
	public static int3x4 op_ExclusiveOr(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A88540", Offset = "0x2A87940", Length = "0x115")]
	[Token(Token = "0x6001B72")]
	public static int3x4 op_ExclusiveOr(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2A44740", Offset = "0x2A43B40", Length = "0xCB")]
	[Token(Token = "0x6001B3E")]
	public static int3x4 op_Explicit(uint3x4 v) { }

	[Address(RVA = "0x2A44620", Offset = "0x2A43A20", Length = "0x8B")]
	[Token(Token = "0x6001B3F")]
	public static int3x4 op_Explicit(float v) { }

	[Address(RVA = "0x2A444C0", Offset = "0x2A438C0", Length = "0xC7")]
	[Token(Token = "0x6001B40")]
	public static int3x4 op_Explicit(float3x4 v) { }

	[Address(RVA = "0x2A44590", Offset = "0x2A43990", Length = "0x8B")]
	[Token(Token = "0x6001B41")]
	public static int3x4 op_Explicit(double v) { }

	[Address(RVA = "0x2A44460", Offset = "0x2A43860", Length = "0x5B")]
	[Token(Token = "0x6001B3D")]
	public static int3x4 op_Explicit(uint v) { }

	[Address(RVA = "0x2A889D0", Offset = "0x2A87DD0", Length = "0x28")]
	[Token(Token = "0x6001B3B")]
	public static int3x4 op_Explicit(bool v) { }

	[Address(RVA = "0x2A88990", Offset = "0x2A87D90", Length = "0x3E")]
	[Token(Token = "0x6001B3C")]
	public static int3x4 op_Explicit(bool3x4 v) { }

	[Address(RVA = "0x2A44290", Offset = "0x2A43690", Length = "0xB0")]
	[Token(Token = "0x6001B42")]
	public static int3x4 op_Explicit(double3x4 v) { }

	[Address(RVA = "0x2B061E0", Offset = "0x2B055E0", Length = "0x1FE")]
	[Token(Token = "0x6001B5A")]
	public static bool3x4 op_GreaterThan(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2B05FA0", Offset = "0x2B053A0", Length = "0x120")]
	[Token(Token = "0x6001B5B")]
	public static bool3x4 op_GreaterThan(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2B060C0", Offset = "0x2B054C0", Length = "0x11C")]
	[Token(Token = "0x6001B5C")]
	public static bool3x4 op_GreaterThan(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2B05C80", Offset = "0x2B05080", Length = "0x1FE")]
	[Token(Token = "0x6001B5D")]
	public static bool3x4 op_GreaterThanOrEqual(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2B05B60", Offset = "0x2B04F60", Length = "0x120")]
	[Token(Token = "0x6001B5E")]
	public static bool3x4 op_GreaterThanOrEqual(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2B05E80", Offset = "0x2B05280", Length = "0x11C")]
	[Token(Token = "0x6001B5F")]
	public static bool3x4 op_GreaterThanOrEqual(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A44460", Offset = "0x2A43860", Length = "0x5B")]
	[Token(Token = "0x6001B3A")]
	public static int3x4 op_Implicit(int v) { }

	[Address(RVA = "0x2A892B0", Offset = "0x2A886B0", Length = "0x139")]
	[Token(Token = "0x6001B52")]
	public static int3x4 op_Increment(int3x4 val) { }

	[Address(RVA = "0x2A89710", Offset = "0x2A88B10", Length = "0x120")]
	[Token(Token = "0x6001B68")]
	public static bool3x4 op_Inequality(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2A893F0", Offset = "0x2A887F0", Length = "0x1FE")]
	[Token(Token = "0x6001B67")]
	public static bool3x4 op_Inequality(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A895F0", Offset = "0x2A889F0", Length = "0x11C")]
	[Token(Token = "0x6001B69")]
	public static bool3x4 op_Inequality(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A89830", Offset = "0x2A88C30", Length = "0x11F")]
	[Token(Token = "0x6001B62")]
	public static int3x4 op_LeftShift(int3x4 x, int n) { }

	[Address(RVA = "0x2B06940", Offset = "0x2B05D40", Length = "0x1FE")]
	[Token(Token = "0x6001B54")]
	public static bool3x4 op_LessThan(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2B06820", Offset = "0x2B05C20", Length = "0x11C")]
	[Token(Token = "0x6001B56")]
	public static bool3x4 op_LessThan(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2B06B40", Offset = "0x2B05F40", Length = "0x120")]
	[Token(Token = "0x6001B55")]
	public static bool3x4 op_LessThan(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2B063E0", Offset = "0x2B057E0", Length = "0x11C")]
	[Token(Token = "0x6001B59")]
	public static bool3x4 op_LessThanOrEqual(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2B06500", Offset = "0x2B05900", Length = "0x120")]
	[Token(Token = "0x6001B58")]
	public static bool3x4 op_LessThanOrEqual(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2B06620", Offset = "0x2B05A20", Length = "0x1FE")]
	[Token(Token = "0x6001B57")]
	public static bool3x4 op_LessThanOrEqual(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2B06FB0", Offset = "0x2B063B0", Length = "0x142")]
	[Token(Token = "0x6001B51")]
	public static int3x4 op_Modulus(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2B06DA0", Offset = "0x2B061A0", Length = "0x203")]
	[Token(Token = "0x6001B4F")]
	public static int3x4 op_Modulus(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2B06C60", Offset = "0x2B06060", Length = "0x13B")]
	[Token(Token = "0x6001B50")]
	public static int3x4 op_Modulus(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2A8A7C0", Offset = "0x2A89BC0", Length = "0x1F2")]
	[Token(Token = "0x6001B43")]
	public static int3x4 op_Multiply(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A8A680", Offset = "0x2A89A80", Length = "0x132")]
	[Token(Token = "0x6001B45")]
	public static int3x4 op_Multiply(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A8A9C0", Offset = "0x2A89DC0", Length = "0x130")]
	[Token(Token = "0x6001B44")]
	public static int3x4 op_Multiply(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2A8AAF0", Offset = "0x2A89EF0", Length = "0x102")]
	[Token(Token = "0x6001B6A")]
	public static int3x4 op_OnesComplement(int3x4 val) { }

	[Address(RVA = "0x2B07100", Offset = "0x2B06500", Length = "0x11F")]
	[Token(Token = "0x6001B63")]
	public static int3x4 op_RightShift(int3x4 x, int n) { }

	[Address(RVA = "0x2A8AE50", Offset = "0x2A8A250", Length = "0x125")]
	[Token(Token = "0x6001B4B")]
	public static int3x4 op_Subtraction(int lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A8AD30", Offset = "0x2A8A130", Length = "0x115")]
	[Token(Token = "0x6001B4A")]
	public static int3x4 op_Subtraction(int3x4 lhs, int rhs) { }

	[Address(RVA = "0x2A8AF80", Offset = "0x2A8A380", Length = "0x1DB")]
	[Token(Token = "0x6001B49")]
	public static int3x4 op_Subtraction(int3x4 lhs, int3x4 rhs) { }

	[Address(RVA = "0x2A8B160", Offset = "0x2A8A560", Length = "0x111")]
	[Token(Token = "0x6001B60")]
	public static int3x4 op_UnaryNegation(int3x4 val) { }

	[Address(RVA = "0x2A8B280", Offset = "0x2A8A680", Length = "0x100")]
	[Token(Token = "0x6001B61")]
	public static int3x4 op_UnaryPlus(int3x4 val) { }

	[Address(RVA = "0x2B04A00", Offset = "0x2B03E00", Length = "0x500")]
	[Token(Token = "0x6001B78")]
	public virtual string ToString() { }

	[Address(RVA = "0x2B04F10", Offset = "0x2B04310", Length = "0x4EE")]
	[Token(Token = "0x6001B79")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

