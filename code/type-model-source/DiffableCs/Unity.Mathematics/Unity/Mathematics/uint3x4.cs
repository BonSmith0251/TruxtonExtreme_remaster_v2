namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200005D")]
public struct uint3x4 : IEquatable<uint3x4>, IFormattable
{
	[Token(Token = "0x4000164")]
	public static readonly uint3x4 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000160")]
	public uint3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000161")]
	public uint3 c1; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000162")]
	public uint3 c2; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000163")]
	public uint3 c3; //Field offset: 0x24

	[Token(Token = "0x17000A35")]
	public uint3 Item
	{
		[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
		[Token(Token = "0x60021E9")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x2A86E40", Offset = "0x2A86240", Length = "0x45")]
	[Token(Token = "0x60021A4")]
	public uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3) { }

	[Address(RVA = "0x2A86CD0", Offset = "0x2A860D0", Length = "0x81")]
	[Token(Token = "0x60021A5")]
	public uint3x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23) { }

	[Address(RVA = "0x2A86C70", Offset = "0x2A86070", Length = "0x58")]
	[Token(Token = "0x60021A6")]
	public uint3x4(uint v) { }

	[Address(RVA = "0x2A1B0A0", Offset = "0x2A1A4A0", Length = "0xB5")]
	[Token(Token = "0x60021A7")]
	public uint3x4(bool v) { }

	[Address(RVA = "0x2A1B160", Offset = "0x2A1A560", Length = "0x110")]
	[Token(Token = "0x60021A8")]
	public uint3x4(bool3x4 v) { }

	[Address(RVA = "0x2A86C70", Offset = "0x2A86070", Length = "0x58")]
	[Token(Token = "0x60021A9")]
	public uint3x4(int v) { }

	[Address(RVA = "0x2A86D60", Offset = "0x2A86160", Length = "0xDC")]
	[Token(Token = "0x60021AA")]
	public uint3x4(int3x4 v) { }

	[Address(RVA = "0x2A22080", Offset = "0x2A21480", Length = "0x10A")]
	[Token(Token = "0x60021AB")]
	public uint3x4(float v) { }

	[Address(RVA = "0x2A222A0", Offset = "0x2A216A0", Length = "0x182")]
	[Token(Token = "0x60021AC")]
	public uint3x4(float3x4 v) { }

	[Address(RVA = "0x2A22190", Offset = "0x2A21590", Length = "0x10B")]
	[Token(Token = "0x60021AD")]
	public uint3x4(double v) { }

	[Address(RVA = "0x2A21EE0", Offset = "0x2A212E0", Length = "0x19A")]
	[Token(Token = "0x60021AE")]
	public uint3x4(double3x4 v) { }

	[Address(RVA = "0x2A7FFB0", Offset = "0x2A7F3B0", Length = "0x1FEE")]
	[Token(Token = "0x60021EA")]
	public override bool Equals(uint3x4 rhs) { }

	[Address(RVA = "0x2A86190", Offset = "0x2A85590", Length = "0xA2")]
	[Token(Token = "0x60021EB")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
	[Token(Token = "0x60021E9")]
	public uint3 get_Item(int index) { }

	[Address(RVA = "0x2A86240", Offset = "0x2A85640", Length = "0x2F")]
	[Token(Token = "0x60021EC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A86E90", Offset = "0x2A86290", Length = "0x1F3")]
	[Token(Token = "0x60021BB")]
	public static uint3x4 op_Addition(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A87090", Offset = "0x2A86490", Length = "0x11C")]
	[Token(Token = "0x60021BC")]
	public static uint3x4 op_Addition(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A871B0", Offset = "0x2A865B0", Length = "0x114")]
	[Token(Token = "0x60021BD")]
	public static uint3x4 op_Addition(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A87510", Offset = "0x2A86910", Length = "0x1E0")]
	[Token(Token = "0x60021E0")]
	public static uint3x4 op_BitwiseAnd(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A872D0", Offset = "0x2A866D0", Length = "0x115")]
	[Token(Token = "0x60021E1")]
	public static uint3x4 op_BitwiseAnd(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A873F0", Offset = "0x2A867F0", Length = "0x117")]
	[Token(Token = "0x60021E2")]
	public static uint3x4 op_BitwiseAnd(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A87810", Offset = "0x2A86C10", Length = "0x117")]
	[Token(Token = "0x60021E5")]
	public static uint3x4 op_BitwiseOr(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A87930", Offset = "0x2A86D30", Length = "0x1E0")]
	[Token(Token = "0x60021E3")]
	public static uint3x4 op_BitwiseOr(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A876F0", Offset = "0x2A86AF0", Length = "0x115")]
	[Token(Token = "0x60021E4")]
	public static uint3x4 op_BitwiseOr(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A87B10", Offset = "0x2A86F10", Length = "0x139")]
	[Token(Token = "0x60021C8")]
	public static uint3x4 op_Decrement(uint3x4 val) { }

	[Address(RVA = "0x2A87C50", Offset = "0x2A87050", Length = "0x14E")]
	[Token(Token = "0x60021C3")]
	public static uint3x4 op_Division(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A87DA0", Offset = "0x2A871A0", Length = "0x147")]
	[Token(Token = "0x60021C2")]
	public static uint3x4 op_Division(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A87EF0", Offset = "0x2A872F0", Length = "0x20F")]
	[Token(Token = "0x60021C1")]
	public static uint3x4 op_Division(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A88420", Offset = "0x2A87820", Length = "0x11C")]
	[Token(Token = "0x60021DB")]
	public static bool3x4 op_Equality(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A88220", Offset = "0x2A87620", Length = "0x1FE")]
	[Token(Token = "0x60021D9")]
	public static bool3x4 op_Equality(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A88100", Offset = "0x2A87500", Length = "0x120")]
	[Token(Token = "0x60021DA")]
	public static bool3x4 op_Equality(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A88660", Offset = "0x2A87A60", Length = "0x117")]
	[Token(Token = "0x60021E8")]
	public static uint3x4 op_ExclusiveOr(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A88780", Offset = "0x2A87B80", Length = "0x1E0")]
	[Token(Token = "0x60021E6")]
	public static uint3x4 op_ExclusiveOr(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A88540", Offset = "0x2A87940", Length = "0x115")]
	[Token(Token = "0x60021E7")]
	public static uint3x4 op_ExclusiveOr(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A44740", Offset = "0x2A43B40", Length = "0xCB")]
	[Token(Token = "0x60021B3")]
	public static uint3x4 op_Explicit(int3x4 v) { }

	[Address(RVA = "0x2A88A00", Offset = "0x2A87E00", Length = "0x28")]
	[Token(Token = "0x60021B4")]
	public static uint3x4 op_Explicit(float v) { }

	[Address(RVA = "0x2A6FE90", Offset = "0x2A6F290", Length = "0x47")]
	[Token(Token = "0x60021B5")]
	public static uint3x4 op_Explicit(float3x4 v) { }

	[Address(RVA = "0x2A88960", Offset = "0x2A87D60", Length = "0x28")]
	[Token(Token = "0x60021B6")]
	public static uint3x4 op_Explicit(double v) { }

	[Address(RVA = "0x2A44460", Offset = "0x2A43860", Length = "0x5B")]
	[Token(Token = "0x60021B2")]
	public static uint3x4 op_Explicit(int v) { }

	[Address(RVA = "0x2A889D0", Offset = "0x2A87DD0", Length = "0x28")]
	[Token(Token = "0x60021B0")]
	public static uint3x4 op_Explicit(bool v) { }

	[Address(RVA = "0x2A88990", Offset = "0x2A87D90", Length = "0x3E")]
	[Token(Token = "0x60021B1")]
	public static uint3x4 op_Explicit(bool3x4 v) { }

	[Address(RVA = "0x2A6FE20", Offset = "0x2A6F220", Length = "0x63")]
	[Token(Token = "0x60021B7")]
	public static uint3x4 op_Explicit(double3x4 v) { }

	[Address(RVA = "0x2A88E70", Offset = "0x2A88270", Length = "0x1FE")]
	[Token(Token = "0x60021CF")]
	public static bool3x4 op_GreaterThan(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A89070", Offset = "0x2A88470", Length = "0x120")]
	[Token(Token = "0x60021D0")]
	public static bool3x4 op_GreaterThan(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A89190", Offset = "0x2A88590", Length = "0x11C")]
	[Token(Token = "0x60021D1")]
	public static bool3x4 op_GreaterThan(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A88B50", Offset = "0x2A87F50", Length = "0x1FE")]
	[Token(Token = "0x60021D2")]
	public static bool3x4 op_GreaterThanOrEqual(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A88A30", Offset = "0x2A87E30", Length = "0x120")]
	[Token(Token = "0x60021D3")]
	public static bool3x4 op_GreaterThanOrEqual(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A88D50", Offset = "0x2A88150", Length = "0x11C")]
	[Token(Token = "0x60021D4")]
	public static bool3x4 op_GreaterThanOrEqual(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A44460", Offset = "0x2A43860", Length = "0x5B")]
	[Token(Token = "0x60021AF")]
	public static uint3x4 op_Implicit(uint v) { }

	[Address(RVA = "0x2A892B0", Offset = "0x2A886B0", Length = "0x139")]
	[Token(Token = "0x60021C7")]
	public static uint3x4 op_Increment(uint3x4 val) { }

	[Address(RVA = "0x2A89710", Offset = "0x2A88B10", Length = "0x120")]
	[Token(Token = "0x60021DD")]
	public static bool3x4 op_Inequality(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A893F0", Offset = "0x2A887F0", Length = "0x1FE")]
	[Token(Token = "0x60021DC")]
	public static bool3x4 op_Inequality(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A895F0", Offset = "0x2A889F0", Length = "0x11C")]
	[Token(Token = "0x60021DE")]
	public static bool3x4 op_Inequality(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A89830", Offset = "0x2A88C30", Length = "0x11F")]
	[Token(Token = "0x60021D7")]
	public static uint3x4 op_LeftShift(uint3x4 x, int n) { }

	[Address(RVA = "0x2A89FD0", Offset = "0x2A893D0", Length = "0x1FE")]
	[Token(Token = "0x60021C9")]
	public static bool3x4 op_LessThan(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A89EB0", Offset = "0x2A892B0", Length = "0x11C")]
	[Token(Token = "0x60021CB")]
	public static bool3x4 op_LessThan(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A89D90", Offset = "0x2A89190", Length = "0x120")]
	[Token(Token = "0x60021CA")]
	public static bool3x4 op_LessThan(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A89C70", Offset = "0x2A89070", Length = "0x11C")]
	[Token(Token = "0x60021CE")]
	public static bool3x4 op_LessThanOrEqual(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A89B50", Offset = "0x2A88F50", Length = "0x120")]
	[Token(Token = "0x60021CD")]
	public static bool3x4 op_LessThanOrEqual(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A89950", Offset = "0x2A88D50", Length = "0x1FE")]
	[Token(Token = "0x60021CC")]
	public static bool3x4 op_LessThanOrEqual(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A8A530", Offset = "0x2A89930", Length = "0x14E")]
	[Token(Token = "0x60021C6")]
	public static uint3x4 op_Modulus(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A8A1D0", Offset = "0x2A895D0", Length = "0x20F")]
	[Token(Token = "0x60021C4")]
	public static uint3x4 op_Modulus(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A8A3E0", Offset = "0x2A897E0", Length = "0x147")]
	[Token(Token = "0x60021C5")]
	public static uint3x4 op_Modulus(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A8A7C0", Offset = "0x2A89BC0", Length = "0x1F2")]
	[Token(Token = "0x60021B8")]
	public static uint3x4 op_Multiply(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A8A680", Offset = "0x2A89A80", Length = "0x132")]
	[Token(Token = "0x60021BA")]
	public static uint3x4 op_Multiply(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A8A9C0", Offset = "0x2A89DC0", Length = "0x130")]
	[Token(Token = "0x60021B9")]
	public static uint3x4 op_Multiply(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A8AAF0", Offset = "0x2A89EF0", Length = "0x102")]
	[Token(Token = "0x60021DF")]
	public static uint3x4 op_OnesComplement(uint3x4 val) { }

	[Address(RVA = "0x2A8AC00", Offset = "0x2A8A000", Length = "0x123")]
	[Token(Token = "0x60021D8")]
	public static uint3x4 op_RightShift(uint3x4 x, int n) { }

	[Address(RVA = "0x2A8AE50", Offset = "0x2A8A250", Length = "0x125")]
	[Token(Token = "0x60021C0")]
	public static uint3x4 op_Subtraction(uint lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A8AD30", Offset = "0x2A8A130", Length = "0x115")]
	[Token(Token = "0x60021BF")]
	public static uint3x4 op_Subtraction(uint3x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A8AF80", Offset = "0x2A8A380", Length = "0x1DB")]
	[Token(Token = "0x60021BE")]
	public static uint3x4 op_Subtraction(uint3x4 lhs, uint3x4 rhs) { }

	[Address(RVA = "0x2A8B160", Offset = "0x2A8A560", Length = "0x111")]
	[Token(Token = "0x60021D5")]
	public static uint3x4 op_UnaryNegation(uint3x4 val) { }

	[Address(RVA = "0x2A8B280", Offset = "0x2A8A680", Length = "0x100")]
	[Token(Token = "0x60021D6")]
	public static uint3x4 op_UnaryPlus(uint3x4 val) { }

	[Address(RVA = "0x2A86760", Offset = "0x2A85B60", Length = "0x500")]
	[Token(Token = "0x60021ED")]
	public virtual string ToString() { }

	[Address(RVA = "0x2A86270", Offset = "0x2A85670", Length = "0x4EE")]
	[Token(Token = "0x60021EE")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

