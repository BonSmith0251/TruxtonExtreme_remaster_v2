namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000060")]
public struct uint4x2 : IEquatable<uint4x2>, IFormattable
{
	[Token(Token = "0x4000170")]
	public static readonly uint4x2 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400016E")]
	public uint4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400016F")]
	public uint4 c1; //Field offset: 0x10

	[Token(Token = "0x17000B87")]
	public uint4 Item
	{
		[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
		[Token(Token = "0x6002413")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x648E10", Offset = "0x648210", Length = "0xF")]
	[Token(Token = "0x60023CE")]
	public uint4x2(uint4 c0, uint4 c1) { }

	[Address(RVA = "0x2A8FD90", Offset = "0x2A8F190", Length = "0x4C")]
	[Token(Token = "0x60023CF")]
	public uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31) { }

	[Address(RVA = "0x2A8FCE0", Offset = "0x2A8F0E0", Length = "0x36")]
	[Token(Token = "0x60023D0")]
	public uint4x2(uint v) { }

	[Address(RVA = "0x2A22520", Offset = "0x2A21920", Length = "0x89")]
	[Token(Token = "0x60023D1")]
	public uint4x2(bool v) { }

	[Address(RVA = "0x2A8FDE0", Offset = "0x2A8F1E0", Length = "0x9F")]
	[Token(Token = "0x60023D2")]
	public uint4x2(bool4x2 v) { }

	[Address(RVA = "0x2A8FCE0", Offset = "0x2A8F0E0", Length = "0x36")]
	[Token(Token = "0x60023D3")]
	public uint4x2(int v) { }

	[Address(RVA = "0x2A8FD20", Offset = "0x2A8F120", Length = "0x6E")]
	[Token(Token = "0x60023D4")]
	public uint4x2(int4x2 v) { }

	[Address(RVA = "0x2A22670", Offset = "0x2A21A70", Length = "0xB3")]
	[Token(Token = "0x60023D5")]
	public uint4x2(float v) { }

	[Address(RVA = "0x2A22730", Offset = "0x2A21B30", Length = "0xF3")]
	[Token(Token = "0x60023D6")]
	public uint4x2(float4x2 v) { }

	[Address(RVA = "0x2A225B0", Offset = "0x2A219B0", Length = "0xB4")]
	[Token(Token = "0x60023D7")]
	public uint4x2(double v) { }

	[Address(RVA = "0x2A22430", Offset = "0x2A21830", Length = "0xEF")]
	[Token(Token = "0x60023D8")]
	public uint4x2(double4x2 v) { }

	[Address(RVA = "0x2A8F4C0", Offset = "0x2A8E8C0", Length = "0x67")]
	[Token(Token = "0x6002414")]
	public override bool Equals(uint4x2 rhs) { }

	[Address(RVA = "0x2A8F3D0", Offset = "0x2A8E7D0", Length = "0xE0")]
	[Token(Token = "0x6002415")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x6002413")]
	public uint4 get_Item(int index) { }

	[Address(RVA = "0x2A8F530", Offset = "0x2A8E930", Length = "0x92")]
	[Token(Token = "0x6002416")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A8FE80", Offset = "0x2A8F280", Length = "0xB4")]
	[Token(Token = "0x60023E5")]
	public static uint4x2 op_Addition(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A8FFC0", Offset = "0x2A8F3C0", Length = "0x82")]
	[Token(Token = "0x60023E6")]
	public static uint4x2 op_Addition(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A8FF40", Offset = "0x2A8F340", Length = "0x7E")]
	[Token(Token = "0x60023E7")]
	public static uint4x2 op_Addition(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A90150", Offset = "0x2A8F550", Length = "0xB4")]
	[Token(Token = "0x600240A")]
	public static uint4x2 op_BitwiseAnd(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A90050", Offset = "0x2A8F450", Length = "0x7D")]
	[Token(Token = "0x600240B")]
	public static uint4x2 op_BitwiseAnd(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A900D0", Offset = "0x2A8F4D0", Length = "0x79")]
	[Token(Token = "0x600240C")]
	public static uint4x2 op_BitwiseAnd(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A90210", Offset = "0x2A8F610", Length = "0x79")]
	[Token(Token = "0x600240F")]
	public static uint4x2 op_BitwiseOr(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x27EFD90", Offset = "0x27EF190", Length = "0xB4")]
	[Token(Token = "0x600240D")]
	public static uint4x2 op_BitwiseOr(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A90290", Offset = "0x2A8F690", Length = "0x7D")]
	[Token(Token = "0x600240E")]
	public static uint4x2 op_BitwiseOr(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A90310", Offset = "0x2A8F710", Length = "0x77")]
	[Token(Token = "0x60023F2")]
	public static uint4x2 op_Decrement(uint4x2 val) { }

	[Address(RVA = "0x2A90430", Offset = "0x2A8F830", Length = "0xA1")]
	[Token(Token = "0x60023ED")]
	public static uint4x2 op_Division(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A90390", Offset = "0x2A8F790", Length = "0x94")]
	[Token(Token = "0x60023EC")]
	public static uint4x2 op_Division(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A904E0", Offset = "0x2A8F8E0", Length = "0xCB")]
	[Token(Token = "0x60023EB")]
	public static uint4x2 op_Division(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A905B0", Offset = "0x2A8F9B0", Length = "0xD6")]
	[Token(Token = "0x6002405")]
	public static bool4x2 op_Equality(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A90750", Offset = "0x2A8FB50", Length = "0x117")]
	[Token(Token = "0x6002403")]
	public static bool4x2 op_Equality(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A90690", Offset = "0x2A8FA90", Length = "0xBE")]
	[Token(Token = "0x6002404")]
	public static bool4x2 op_Equality(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A90870", Offset = "0x2A8FC70", Length = "0x79")]
	[Token(Token = "0x6002412")]
	public static uint4x2 op_ExclusiveOr(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x27F1440", Offset = "0x27F0840", Length = "0xB4")]
	[Token(Token = "0x6002410")]
	public static uint4x2 op_ExclusiveOr(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A908F0", Offset = "0x2A8FCF0", Length = "0x7D")]
	[Token(Token = "0x6002411")]
	public static uint4x2 op_ExclusiveOr(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A44B60", Offset = "0x2A43F60", Length = "0x5F")]
	[Token(Token = "0x60023DD")]
	public static uint4x2 op_Explicit(int4x2 v) { }

	[Address(RVA = "0x2A90A60", Offset = "0x2A8FE60", Length = "0x24")]
	[Token(Token = "0x60023DE")]
	public static uint4x2 op_Explicit(float v) { }

	[Address(RVA = "0x2A90970", Offset = "0x2A8FD70", Length = "0x3A")]
	[Token(Token = "0x60023DF")]
	public static uint4x2 op_Explicit(float4x2 v) { }

	[Address(RVA = "0x2A90A30", Offset = "0x2A8FE30", Length = "0x24")]
	[Token(Token = "0x60023E0")]
	public static uint4x2 op_Explicit(double v) { }

	[Address(RVA = "0x2A44B20", Offset = "0x2A43F20", Length = "0x39")]
	[Token(Token = "0x60023DC")]
	public static uint4x2 op_Explicit(int v) { }

	[Address(RVA = "0x2A909B0", Offset = "0x2A8FDB0", Length = "0x24")]
	[Token(Token = "0x60023DA")]
	public static uint4x2 op_Explicit(bool v) { }

	[Address(RVA = "0x2A44CB0", Offset = "0x2A440B0", Length = "0xA2")]
	[Token(Token = "0x60023DB")]
	public static uint4x2 op_Explicit(bool4x2 v) { }

	[Address(RVA = "0x2A909E0", Offset = "0x2A8FDE0", Length = "0x4C")]
	[Token(Token = "0x60023E1")]
	public static uint4x2 op_Explicit(double4x2 v) { }

	[Address(RVA = "0x2A90E30", Offset = "0x2A90230", Length = "0x117")]
	[Token(Token = "0x60023F9")]
	public static bool4x2 op_GreaterThan(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A90F50", Offset = "0x2A90350", Length = "0xBE")]
	[Token(Token = "0x60023FA")]
	public static bool4x2 op_GreaterThan(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A90D50", Offset = "0x2A90150", Length = "0xD6")]
	[Token(Token = "0x60023FB")]
	public static bool4x2 op_GreaterThan(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A90A90", Offset = "0x2A8FE90", Length = "0x117")]
	[Token(Token = "0x60023FC")]
	public static bool4x2 op_GreaterThanOrEqual(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A90BB0", Offset = "0x2A8FFB0", Length = "0xBE")]
	[Token(Token = "0x60023FD")]
	public static bool4x2 op_GreaterThanOrEqual(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A90C70", Offset = "0x2A90070", Length = "0xD6")]
	[Token(Token = "0x60023FE")]
	public static bool4x2 op_GreaterThanOrEqual(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A44B20", Offset = "0x2A43F20", Length = "0x39")]
	[Token(Token = "0x60023D9")]
	public static uint4x2 op_Implicit(uint v) { }

	[Address(RVA = "0x2A91010", Offset = "0x2A90410", Length = "0x77")]
	[Token(Token = "0x60023F1")]
	public static uint4x2 op_Increment(uint4x2 val) { }

	[Address(RVA = "0x2A91290", Offset = "0x2A90690", Length = "0xBE")]
	[Token(Token = "0x6002407")]
	public static bool4x2 op_Inequality(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A91170", Offset = "0x2A90570", Length = "0x117")]
	[Token(Token = "0x6002406")]
	public static bool4x2 op_Inequality(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A91090", Offset = "0x2A90490", Length = "0xD6")]
	[Token(Token = "0x6002408")]
	public static bool4x2 op_Inequality(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A91350", Offset = "0x2A90750", Length = "0x81")]
	[Token(Token = "0x6002401")]
	public static uint4x2 op_LeftShift(uint4x2 x, int n) { }

	[Address(RVA = "0x2A91780", Offset = "0x2A90B80", Length = "0x117")]
	[Token(Token = "0x60023F3")]
	public static bool4x2 op_LessThan(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A916A0", Offset = "0x2A90AA0", Length = "0xD6")]
	[Token(Token = "0x60023F5")]
	public static bool4x2 op_LessThan(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A918A0", Offset = "0x2A90CA0", Length = "0xBE")]
	[Token(Token = "0x60023F4")]
	public static bool4x2 op_LessThan(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A913E0", Offset = "0x2A907E0", Length = "0xD6")]
	[Token(Token = "0x60023F8")]
	public static bool4x2 op_LessThanOrEqual(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A914C0", Offset = "0x2A908C0", Length = "0xBE")]
	[Token(Token = "0x60023F7")]
	public static bool4x2 op_LessThanOrEqual(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A91580", Offset = "0x2A90980", Length = "0x117")]
	[Token(Token = "0x60023F6")]
	public static bool4x2 op_LessThanOrEqual(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A91AD0", Offset = "0x2A90ED0", Length = "0xA1")]
	[Token(Token = "0x60023F0")]
	public static uint4x2 op_Modulus(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A91A00", Offset = "0x2A90E00", Length = "0xCB")]
	[Token(Token = "0x60023EE")]
	public static uint4x2 op_Modulus(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A91960", Offset = "0x2A90D60", Length = "0x94")]
	[Token(Token = "0x60023EF")]
	public static uint4x2 op_Modulus(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A91CA0", Offset = "0x2A910A0", Length = "0xBC")]
	[Token(Token = "0x60023E2")]
	public static uint4x2 op_Multiply(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A91C10", Offset = "0x2A91010", Length = "0x81")]
	[Token(Token = "0x60023E4")]
	public static uint4x2 op_Multiply(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A91B80", Offset = "0x2A90F80", Length = "0x85")]
	[Token(Token = "0x60023E3")]
	public static uint4x2 op_Multiply(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A91D60", Offset = "0x2A91160", Length = "0x75")]
	[Token(Token = "0x6002409")]
	public static uint4x2 op_OnesComplement(uint4x2 val) { }

	[Address(RVA = "0x2A91DE0", Offset = "0x2A911E0", Length = "0x85")]
	[Token(Token = "0x6002402")]
	public static uint4x2 op_RightShift(uint4x2 x, int n) { }

	[Address(RVA = "0x2A91EF0", Offset = "0x2A912F0", Length = "0x8D")]
	[Token(Token = "0x60023EA")]
	public static uint4x2 op_Subtraction(uint lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A91E70", Offset = "0x2A91270", Length = "0x7D")]
	[Token(Token = "0x60023E9")]
	public static uint4x2 op_Subtraction(uint4x2 lhs, uint rhs) { }

	[Address(RVA = "0x2A91F80", Offset = "0x2A91380", Length = "0xB4")]
	[Token(Token = "0x60023E8")]
	public static uint4x2 op_Subtraction(uint4x2 lhs, uint4x2 rhs) { }

	[Address(RVA = "0x2A92040", Offset = "0x2A91440", Length = "0x75")]
	[Token(Token = "0x60023FF")]
	public static uint4x2 op_UnaryNegation(uint4x2 val) { }

	[Address(RVA = "0x2A920C0", Offset = "0x2A914C0", Length = "0x78")]
	[Token(Token = "0x6002400")]
	public static uint4x2 op_UnaryPlus(uint4x2 val) { }

	[Address(RVA = "0x2A8F5D0", Offset = "0x2A8E9D0", Length = "0x384")]
	[Token(Token = "0x6002417")]
	public virtual string ToString() { }

	[Address(RVA = "0x2A8F960", Offset = "0x2A8ED60", Length = "0x37E")]
	[Token(Token = "0x6002418")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

