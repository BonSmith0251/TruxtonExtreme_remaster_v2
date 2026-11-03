namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000062")]
public struct uint4x4 : IEquatable<uint4x4>, IFormattable
{
	[Token(Token = "0x4000179")]
	public static readonly uint4x4 identity; //Field offset: 0x0
	[Token(Token = "0x400017A")]
	public static readonly uint4x4 zero; //Field offset: 0x40
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000175")]
	public uint4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000176")]
	public uint4 c1; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000177")]
	public uint4 c2; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000178")]
	public uint4 c3; //Field offset: 0x30

	[Token(Token = "0x17000B89")]
	public uint4 Item
	{
		[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
		[Token(Token = "0x60024A9")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2A99210", Offset = "0x2A98610", Length = "0x96")]
	[Token(Token = "0x60024AF")]
	private static uint4x4() { }

	[Address(RVA = "0x2A23170", Offset = "0x2A22570", Length = "0x1C5")]
	[Token(Token = "0x600246E")]
	public uint4x4(double4x4 v) { }

	[Address(RVA = "0x2A22ED0", Offset = "0x2A222D0", Length = "0x14A")]
	[Token(Token = "0x600246D")]
	public uint4x4(double v) { }

	[Address(RVA = "0x2A23340", Offset = "0x2A22740", Length = "0x1CD")]
	[Token(Token = "0x600246C")]
	public uint4x4(float4x4 v) { }

	[Address(RVA = "0x2A23020", Offset = "0x2A22420", Length = "0x149")]
	[Token(Token = "0x600246B")]
	public uint4x4(float v) { }

	[Address(RVA = "0x2A99340", Offset = "0x2A98740", Length = "0xD6")]
	[Token(Token = "0x600246A")]
	public uint4x4(int4x4 v) { }

	[Address(RVA = "0x2A99310", Offset = "0x2A98710", Length = "0x23")]
	[Token(Token = "0x6002464")]
	public uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3) { }

	[Address(RVA = "0x2A1B360", Offset = "0x2A1A760", Length = "0x137")]
	[Token(Token = "0x6002468")]
	public uint4x4(bool4x4 v) { }

	[Address(RVA = "0x2A22DC0", Offset = "0x2A221C0", Length = "0x101")]
	[Token(Token = "0x6002467")]
	public uint4x4(bool v) { }

	[Address(RVA = "0x2A992B0", Offset = "0x2A986B0", Length = "0x5B")]
	[Token(Token = "0x6002466")]
	public uint4x4(uint v) { }

	[Address(RVA = "0x2A99420", Offset = "0x2A98820", Length = "0xA9")]
	[Token(Token = "0x6002465")]
	public uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33) { }

	[Address(RVA = "0x2A992B0", Offset = "0x2A986B0", Length = "0x5B")]
	[Token(Token = "0x6002469")]
	public uint4x4(int v) { }

	[Address(RVA = "0x2A96040", Offset = "0x2A95440", Length = "0xDF6")]
	[Token(Token = "0x60024AA")]
	public override bool Equals(uint4x4 rhs) { }

	[Address(RVA = "0x2A98400", Offset = "0x2A97800", Length = "0xAB")]
	[Token(Token = "0x60024AB")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x60024A9")]
	public uint4 get_Item(int index) { }

	[Address(RVA = "0x2A984B0", Offset = "0x2A978B0", Length = "0x38")]
	[Token(Token = "0x60024AC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A994D0", Offset = "0x2A988D0", Length = "0x136")]
	[Token(Token = "0x600247D")]
	public static uint4x4 op_Addition(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A99610", Offset = "0x2A98A10", Length = "0x13E")]
	[Token(Token = "0x600247C")]
	public static uint4x4 op_Addition(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A99750", Offset = "0x2A98B50", Length = "0x1AA")]
	[Token(Token = "0x600247B")]
	public static uint4x4 op_Addition(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A99900", Offset = "0x2A98D00", Length = "0x1AA")]
	[Token(Token = "0x60024A0")]
	public static uint4x4 op_BitwiseAnd(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A99BE0", Offset = "0x2A98FE0", Length = "0x137")]
	[Token(Token = "0x60024A1")]
	public static uint4x4 op_BitwiseAnd(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A99AB0", Offset = "0x2A98EB0", Length = "0x12F")]
	[Token(Token = "0x60024A2")]
	public static uint4x4 op_BitwiseAnd(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A99ED0", Offset = "0x2A992D0", Length = "0x137")]
	[Token(Token = "0x60024A4")]
	public static uint4x4 op_BitwiseOr(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A9A010", Offset = "0x2A99410", Length = "0x12F")]
	[Token(Token = "0x60024A5")]
	public static uint4x4 op_BitwiseOr(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A99D20", Offset = "0x2A99120", Length = "0x1AA")]
	[Token(Token = "0x60024A3")]
	public static uint4x4 op_BitwiseOr(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9A140", Offset = "0x2A99540", Length = "0x13D")]
	[Token(Token = "0x6002488")]
	public static uint4x4 op_Decrement(uint4x4 val) { }

	[Address(RVA = "0x2A9A5D0", Offset = "0x2A999D0", Length = "0x179")]
	[Token(Token = "0x6002483")]
	public static uint4x4 op_Division(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9A280", Offset = "0x2A99680", Length = "0x1D5")]
	[Token(Token = "0x6002481")]
	public static uint4x4 op_Division(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9A460", Offset = "0x2A99860", Length = "0x162")]
	[Token(Token = "0x6002482")]
	public static uint4x4 op_Division(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A9A9A0", Offset = "0x2A99DA0", Length = "0xEB")]
	[Token(Token = "0x600249A")]
	public static bool4x4 op_Equality(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A9A750", Offset = "0x2A99B50", Length = "0x154")]
	[Token(Token = "0x6002499")]
	public static bool4x4 op_Equality(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9A8B0", Offset = "0x2A99CB0", Length = "0xE3")]
	[Token(Token = "0x600249B")]
	public static bool4x4 op_Equality(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9AA90", Offset = "0x2A99E90", Length = "0x137")]
	[Token(Token = "0x60024A7")]
	public static uint4x4 op_ExclusiveOr(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A9ABD0", Offset = "0x2A99FD0", Length = "0x12F")]
	[Token(Token = "0x60024A8")]
	public static uint4x4 op_ExclusiveOr(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9AD00", Offset = "0x2A9A100", Length = "0x1AA")]
	[Token(Token = "0x60024A6")]
	public static uint4x4 op_ExclusiveOr(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A70A30", Offset = "0x2A6FE30", Length = "0x54")]
	[Token(Token = "0x6002475")]
	public static uint4x4 op_Explicit(float4x4 v) { }

	[Address(RVA = "0x2A70A90", Offset = "0x2A6FE90", Length = "0x79")]
	[Token(Token = "0x6002477")]
	public static uint4x4 op_Explicit(double4x4 v) { }

	[Address(RVA = "0x2A70B10", Offset = "0x2A6FF10", Length = "0x2C")]
	[Token(Token = "0x6002474")]
	public static uint4x4 op_Explicit(float v) { }

	[Address(RVA = "0x2A455E0", Offset = "0x2A449E0", Length = "0xA0")]
	[Token(Token = "0x6002473")]
	public static uint4x4 op_Explicit(int4x4 v) { }

	[Address(RVA = "0x2A453E0", Offset = "0x2A447E0", Length = "0x5E")]
	[Token(Token = "0x6002472")]
	public static uint4x4 op_Explicit(int v) { }

	[Address(RVA = "0x2A9AEE0", Offset = "0x2A9A2E0", Length = "0x39")]
	[Token(Token = "0x6002471")]
	public static uint4x4 op_Explicit(bool4x4 v) { }

	[Address(RVA = "0x2A9AEB0", Offset = "0x2A9A2B0", Length = "0x2C")]
	[Token(Token = "0x6002470")]
	public static uint4x4 op_Explicit(bool v) { }

	[Address(RVA = "0x2A70B40", Offset = "0x2A6FF40", Length = "0x2C")]
	[Token(Token = "0x6002476")]
	public static uint4x4 op_Explicit(double v) { }

	[Address(RVA = "0x2A9B260", Offset = "0x2A9A660", Length = "0xE3")]
	[Token(Token = "0x6002491")]
	public static bool4x4 op_GreaterThan(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9B350", Offset = "0x2A9A750", Length = "0xEB")]
	[Token(Token = "0x6002490")]
	public static bool4x4 op_GreaterThan(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A9B440", Offset = "0x2A9A840", Length = "0x154")]
	[Token(Token = "0x600248F")]
	public static bool4x4 op_GreaterThan(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9B010", Offset = "0x2A9A410", Length = "0x154")]
	[Token(Token = "0x6002492")]
	public static bool4x4 op_GreaterThanOrEqual(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9AF20", Offset = "0x2A9A320", Length = "0xEB")]
	[Token(Token = "0x6002493")]
	public static bool4x4 op_GreaterThanOrEqual(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A9B170", Offset = "0x2A9A570", Length = "0xE3")]
	[Token(Token = "0x6002494")]
	public static bool4x4 op_GreaterThanOrEqual(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A453E0", Offset = "0x2A447E0", Length = "0x5E")]
	[Token(Token = "0x600246F")]
	public static uint4x4 op_Implicit(uint v) { }

	[Address(RVA = "0x2A9B5A0", Offset = "0x2A9A9A0", Length = "0x13D")]
	[Token(Token = "0x6002487")]
	public static uint4x4 op_Increment(uint4x4 val) { }

	[Address(RVA = "0x2A9B6E0", Offset = "0x2A9AAE0", Length = "0xE3")]
	[Token(Token = "0x600249E")]
	public static bool4x4 op_Inequality(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9B7D0", Offset = "0x2A9ABD0", Length = "0xEB")]
	[Token(Token = "0x600249D")]
	public static bool4x4 op_Inequality(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A9B8C0", Offset = "0x2A9ACC0", Length = "0x154")]
	[Token(Token = "0x600249C")]
	public static bool4x4 op_Inequality(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9BA20", Offset = "0x2A9AE20", Length = "0x135")]
	[Token(Token = "0x6002497")]
	public static uint4x4 op_LeftShift(uint4x4 x, int n) { }

	[Address(RVA = "0x2A9BF90", Offset = "0x2A9B390", Length = "0x154")]
	[Token(Token = "0x6002489")]
	public static bool4x4 op_LessThan(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9BEA0", Offset = "0x2A9B2A0", Length = "0xE3")]
	[Token(Token = "0x600248B")]
	public static bool4x4 op_LessThan(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9C0F0", Offset = "0x2A9B4F0", Length = "0xEB")]
	[Token(Token = "0x600248A")]
	public static bool4x4 op_LessThan(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A9BDB0", Offset = "0x2A9B1B0", Length = "0xEB")]
	[Token(Token = "0x600248D")]
	public static bool4x4 op_LessThanOrEqual(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A9BB60", Offset = "0x2A9AF60", Length = "0xE3")]
	[Token(Token = "0x600248E")]
	public static bool4x4 op_LessThanOrEqual(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9BC50", Offset = "0x2A9B050", Length = "0x154")]
	[Token(Token = "0x600248C")]
	public static bool4x4 op_LessThanOrEqual(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9C1E0", Offset = "0x2A9B5E0", Length = "0x1D5")]
	[Token(Token = "0x6002484")]
	public static uint4x4 op_Modulus(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9C3C0", Offset = "0x2A9B7C0", Length = "0x179")]
	[Token(Token = "0x6002486")]
	public static uint4x4 op_Modulus(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9C540", Offset = "0x2A9B940", Length = "0x162")]
	[Token(Token = "0x6002485")]
	public static uint4x4 op_Modulus(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A9C9C0", Offset = "0x2A9BDC0", Length = "0x13F")]
	[Token(Token = "0x600247A")]
	public static uint4x4 op_Multiply(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9C6B0", Offset = "0x2A9BAB0", Length = "0x147")]
	[Token(Token = "0x6002479")]
	public static uint4x4 op_Multiply(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A9C800", Offset = "0x2A9BC00", Length = "0x1BA")]
	[Token(Token = "0x6002478")]
	public static uint4x4 op_Multiply(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9CB00", Offset = "0x2A9BF00", Length = "0x127")]
	[Token(Token = "0x600249F")]
	public static uint4x4 op_OnesComplement(uint4x4 val) { }

	[Address(RVA = "0x2A9CC30", Offset = "0x2A9C030", Length = "0x139")]
	[Token(Token = "0x6002498")]
	public static uint4x4 op_RightShift(uint4x4 x, int n) { }

	[Address(RVA = "0x2A9D060", Offset = "0x2A9C460", Length = "0x155")]
	[Token(Token = "0x6002480")]
	public static uint4x4 op_Subtraction(uint lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9CD70", Offset = "0x2A9C170", Length = "0x137")]
	[Token(Token = "0x600247F")]
	public static uint4x4 op_Subtraction(uint4x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A9CEB0", Offset = "0x2A9C2B0", Length = "0x1AA")]
	[Token(Token = "0x600247E")]
	public static uint4x4 op_Subtraction(uint4x4 lhs, uint4x4 rhs) { }

	[Address(RVA = "0x2A9D1C0", Offset = "0x2A9C5C0", Length = "0x127")]
	[Token(Token = "0x6002495")]
	public static uint4x4 op_UnaryNegation(uint4x4 val) { }

	[Address(RVA = "0x2A9D2F0", Offset = "0x2A9C6F0", Length = "0x9AC")]
	[Token(Token = "0x6002496")]
	public static uint4x4 op_UnaryPlus(uint4x4 val) { }

	[Address(RVA = "0x2A984F0", Offset = "0x2A978F0", Length = "0x69B")]
	[Token(Token = "0x60024AD")]
	public virtual string ToString() { }

	[Address(RVA = "0x2A98B90", Offset = "0x2A97F90", Length = "0x676")]
	[Token(Token = "0x60024AE")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

