namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000058")]
public struct uint2x4 : IEquatable<uint2x4>, IFormattable
{
	[Token(Token = "0x4000150")]
	public static readonly uint2x4 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400014C")]
	public uint2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400014D")]
	public uint2 c1; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400014E")]
	public uint2 c2; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400014F")]
	public uint2 c3; //Field offset: 0x18

	[Token(Token = "0x170009BC")]
	public uint2 Item
	{
		[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
		[Token(Token = "0x6002037")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x27F6BF0", Offset = "0x27F5FF0", Length = "0x15")]
	[Token(Token = "0x6001FF2")]
	public uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3) { }

	[Address(RVA = "0x2AFCAC0", Offset = "0x2AFBEC0", Length = "0x5A")]
	[Token(Token = "0x6001FF3")]
	public uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13) { }

	[Address(RVA = "0x2AFCBA0", Offset = "0x2AFBFA0", Length = "0x44")]
	[Token(Token = "0x6001FF4")]
	public uint2x4(uint v) { }

	[Address(RVA = "0x2A1AEF0", Offset = "0x2A1A2F0", Length = "0x97")]
	[Token(Token = "0x6001FF5")]
	public uint2x4(bool v) { }

	[Address(RVA = "0x2A1ADB0", Offset = "0x2A1A1B0", Length = "0x13B")]
	[Token(Token = "0x6001FF6")]
	public uint2x4(bool2x4 v) { }

	[Address(RVA = "0x2AFCBA0", Offset = "0x2AFBFA0", Length = "0x44")]
	[Token(Token = "0x6001FF7")]
	public uint2x4(int v) { }

	[Address(RVA = "0x2AFCA50", Offset = "0x2AFBE50", Length = "0x63")]
	[Token(Token = "0x6001FF8")]
	public uint2x4(int2x4 v) { }

	[Address(RVA = "0x2A21610", Offset = "0x2A20A10", Length = "0xBE")]
	[Token(Token = "0x6001FF9")]
	public uint2x4(float v) { }

	[Address(RVA = "0x2A216D0", Offset = "0x2A20AD0", Length = "0x101")]
	[Token(Token = "0x6001FFA")]
	public uint2x4(float2x4 v) { }

	[Address(RVA = "0x2A21550", Offset = "0x2A20950", Length = "0xBF")]
	[Token(Token = "0x6001FFB")]
	public uint2x4(double v) { }

	[Address(RVA = "0x2A21450", Offset = "0x2A20850", Length = "0x100")]
	[Token(Token = "0x6001FFC")]
	public uint2x4(double2x4 v) { }

	[Address(RVA = "0x2AFC210", Offset = "0x2AFB610", Length = "0x74")]
	[Token(Token = "0x6002038")]
	public override bool Equals(uint2x4 rhs) { }

	[Address(RVA = "0x2B2F2D0", Offset = "0x2B2E6D0", Length = "0xF5")]
	[Token(Token = "0x6002039")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
	[Token(Token = "0x6002037")]
	public uint2 get_Item(int index) { }

	[Address(RVA = "0x2B2F3D0", Offset = "0x2B2E7D0", Length = "0x26")]
	[Token(Token = "0x600203A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AFCDF0", Offset = "0x2AFC1F0", Length = "0xAC")]
	[Token(Token = "0x6002009")]
	public static uint2x4 op_Addition(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFCD60", Offset = "0x2AFC160", Length = "0x8D")]
	[Token(Token = "0x600200A")]
	public static uint2x4 op_Addition(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2AFCCD0", Offset = "0x2AFC0D0", Length = "0x87")]
	[Token(Token = "0x600200B")]
	public static uint2x4 op_Addition(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFCFD0", Offset = "0x2AFC3D0", Length = "0xB1")]
	[Token(Token = "0x600202E")]
	public static uint2x4 op_BitwiseAnd(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFCEA0", Offset = "0x2AFC2A0", Length = "0x93")]
	[Token(Token = "0x600202F")]
	public static uint2x4 op_BitwiseAnd(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2AFCF40", Offset = "0x2AFC340", Length = "0x8D")]
	[Token(Token = "0x6002030")]
	public static uint2x4 op_BitwiseAnd(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFD130", Offset = "0x2AFC530", Length = "0x8D")]
	[Token(Token = "0x6002033")]
	public static uint2x4 op_BitwiseOr(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFD1C0", Offset = "0x2AFC5C0", Length = "0xB1")]
	[Token(Token = "0x6002031")]
	public static uint2x4 op_BitwiseOr(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFD090", Offset = "0x2AFC490", Length = "0x93")]
	[Token(Token = "0x6002032")]
	public static uint2x4 op_BitwiseOr(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2AFD280", Offset = "0x2AFC680", Length = "0x8F")]
	[Token(Token = "0x6002016")]
	public static uint2x4 op_Decrement(uint2x4 val) { }

	[Address(RVA = "0x2B2FBF0", Offset = "0x2B2EFF0", Length = "0xB4")]
	[Token(Token = "0x6002011")]
	public static uint2x4 op_Division(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2B2FCB0", Offset = "0x2B2F0B0", Length = "0xB4")]
	[Token(Token = "0x6002010")]
	public static uint2x4 op_Division(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2B2FB10", Offset = "0x2B2EF10", Length = "0xDA")]
	[Token(Token = "0x600200F")]
	public static uint2x4 op_Division(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFD730", Offset = "0x2AFCB30", Length = "0xD8")]
	[Token(Token = "0x6002029")]
	public static bool2x4 op_Equality(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFD550", Offset = "0x2AFC950", Length = "0xF4")]
	[Token(Token = "0x6002027")]
	public static bool2x4 op_Equality(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFD650", Offset = "0x2AFCA50", Length = "0xD5")]
	[Token(Token = "0x6002028")]
	public static bool2x4 op_Equality(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2AFD970", Offset = "0x2AFCD70", Length = "0x8D")]
	[Token(Token = "0x6002036")]
	public static uint2x4 op_ExclusiveOr(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFD8B0", Offset = "0x2AFCCB0", Length = "0xB1")]
	[Token(Token = "0x6002034")]
	public static uint2x4 op_ExclusiveOr(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFD810", Offset = "0x2AFCC10", Length = "0x93")]
	[Token(Token = "0x6002035")]
	public static uint2x4 op_ExclusiveOr(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2A433D0", Offset = "0x2A427D0", Length = "0x95")]
	[Token(Token = "0x6002001")]
	public static uint2x4 op_Explicit(int2x4 v) { }

	[Address(RVA = "0x2B2FDC0", Offset = "0x2B2F1C0", Length = "0x24")]
	[Token(Token = "0x6002002")]
	public static uint2x4 op_Explicit(float v) { }

	[Address(RVA = "0x2B2FE20", Offset = "0x2B2F220", Length = "0x3A")]
	[Token(Token = "0x6002003")]
	public static uint2x4 op_Explicit(float2x4 v) { }

	[Address(RVA = "0x2B2FDF0", Offset = "0x2B2F1F0", Length = "0x24")]
	[Token(Token = "0x6002004")]
	public static uint2x4 op_Explicit(double v) { }

	[Address(RVA = "0x2A43380", Offset = "0x2A42780", Length = "0x47")]
	[Token(Token = "0x6002000")]
	public static uint2x4 op_Explicit(int v) { }

	[Address(RVA = "0x2AFDA00", Offset = "0x2AFCE00", Length = "0x24")]
	[Token(Token = "0x6001FFE")]
	public static uint2x4 op_Explicit(bool v) { }

	[Address(RVA = "0x2A43350", Offset = "0x2A42750", Length = "0x24")]
	[Token(Token = "0x6001FFF")]
	public static uint2x4 op_Explicit(bool2x4 v) { }

	[Address(RVA = "0x2B2FD70", Offset = "0x2B2F170", Length = "0x4C")]
	[Token(Token = "0x6002005")]
	public static uint2x4 op_Explicit(double2x4 v) { }

	[Address(RVA = "0x2B30120", Offset = "0x2B2F520", Length = "0xF4")]
	[Token(Token = "0x600201D")]
	public static bool2x4 op_GreaterThan(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2B30220", Offset = "0x2B2F620", Length = "0xD5")]
	[Token(Token = "0x600201E")]
	public static bool2x4 op_GreaterThan(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2B30300", Offset = "0x2B2F700", Length = "0xD8")]
	[Token(Token = "0x600201F")]
	public static bool2x4 op_GreaterThan(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2B2FF40", Offset = "0x2B2F340", Length = "0xF4")]
	[Token(Token = "0x6002020")]
	public static bool2x4 op_GreaterThanOrEqual(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2B2FE60", Offset = "0x2B2F260", Length = "0xD5")]
	[Token(Token = "0x6002021")]
	public static bool2x4 op_GreaterThanOrEqual(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2B30040", Offset = "0x2B2F440", Length = "0xD8")]
	[Token(Token = "0x6002022")]
	public static bool2x4 op_GreaterThanOrEqual(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2A43380", Offset = "0x2A42780", Length = "0x47")]
	[Token(Token = "0x6001FFD")]
	public static uint2x4 op_Implicit(uint v) { }

	[Address(RVA = "0x2AFDFB0", Offset = "0x2AFD3B0", Length = "0x8F")]
	[Token(Token = "0x6002015")]
	public static uint2x4 op_Increment(uint2x4 val) { }

	[Address(RVA = "0x2AFE120", Offset = "0x2AFD520", Length = "0xD5")]
	[Token(Token = "0x600202B")]
	public static bool2x4 op_Inequality(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2AFE200", Offset = "0x2AFD600", Length = "0xF4")]
	[Token(Token = "0x600202A")]
	public static bool2x4 op_Inequality(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFE040", Offset = "0x2AFD440", Length = "0xD8")]
	[Token(Token = "0x600202C")]
	public static bool2x4 op_Inequality(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFE300", Offset = "0x2AFD700", Length = "0x94")]
	[Token(Token = "0x6002025")]
	public static uint2x4 op_LeftShift(uint2x4 x, int n) { }

	[Address(RVA = "0x2B30860", Offset = "0x2B2FC60", Length = "0xF4")]
	[Token(Token = "0x6002017")]
	public static bool2x4 op_LessThan(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2B30780", Offset = "0x2B2FB80", Length = "0xD8")]
	[Token(Token = "0x6002019")]
	public static bool2x4 op_LessThan(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2B306A0", Offset = "0x2B2FAA0", Length = "0xD5")]
	[Token(Token = "0x6002018")]
	public static bool2x4 op_LessThan(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2B305C0", Offset = "0x2B2F9C0", Length = "0xD8")]
	[Token(Token = "0x600201C")]
	public static bool2x4 op_LessThanOrEqual(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2B303E0", Offset = "0x2B2F7E0", Length = "0xD5")]
	[Token(Token = "0x600201B")]
	public static bool2x4 op_LessThanOrEqual(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2B304C0", Offset = "0x2B2F8C0", Length = "0xF4")]
	[Token(Token = "0x600201A")]
	public static bool2x4 op_LessThanOrEqual(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2B30A20", Offset = "0x2B2FE20", Length = "0xB4")]
	[Token(Token = "0x6002014")]
	public static uint2x4 op_Modulus(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2B30AE0", Offset = "0x2B2FEE0", Length = "0xDA")]
	[Token(Token = "0x6002012")]
	public static uint2x4 op_Modulus(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2B30960", Offset = "0x2B2FD60", Length = "0xB4")]
	[Token(Token = "0x6002013")]
	public static uint2x4 op_Modulus(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2AFEC00", Offset = "0x2AFE000", Length = "0xB9")]
	[Token(Token = "0x6002006")]
	public static uint2x4 op_Multiply(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFEB60", Offset = "0x2AFDF60", Length = "0x95")]
	[Token(Token = "0x6002008")]
	public static uint2x4 op_Multiply(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFECC0", Offset = "0x2AFE0C0", Length = "0x9B")]
	[Token(Token = "0x6002007")]
	public static uint2x4 op_Multiply(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2AFED60", Offset = "0x2AFE160", Length = "0x8D")]
	[Token(Token = "0x600202D")]
	public static uint2x4 op_OnesComplement(uint2x4 val) { }

	[Address(RVA = "0x2B30BC0", Offset = "0x2B2FFC0", Length = "0x98")]
	[Token(Token = "0x6002026")]
	public static uint2x4 op_RightShift(uint2x4 x, int n) { }

	[Address(RVA = "0x2AFEF50", Offset = "0x2AFE350", Length = "0x96")]
	[Token(Token = "0x600200E")]
	public static uint2x4 op_Subtraction(uint lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFEFF0", Offset = "0x2AFE3F0", Length = "0x93")]
	[Token(Token = "0x600200D")]
	public static uint2x4 op_Subtraction(uint2x4 lhs, uint rhs) { }

	[Address(RVA = "0x2AFEE90", Offset = "0x2AFE290", Length = "0xB1")]
	[Token(Token = "0x600200C")]
	public static uint2x4 op_Subtraction(uint2x4 lhs, uint2x4 rhs) { }

	[Address(RVA = "0x2AFF090", Offset = "0x2AFE490", Length = "0x8D")]
	[Token(Token = "0x6002023")]
	public static uint2x4 op_UnaryNegation(uint2x4 val) { }

	[Address(RVA = "0x2AFF120", Offset = "0x2AFE520", Length = "0x6C")]
	[Token(Token = "0x6002024")]
	public static uint2x4 op_UnaryPlus(uint2x4 val) { }

	[Address(RVA = "0x2B2F400", Offset = "0x2B2E800", Length = "0x384")]
	[Token(Token = "0x600203B")]
	public virtual string ToString() { }

	[Address(RVA = "0x2B2F790", Offset = "0x2B2EB90", Length = "0x37E")]
	[Token(Token = "0x600203C")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

