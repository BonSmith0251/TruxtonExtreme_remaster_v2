namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200004A")]
public struct int4x2 : IEquatable<int4x2>, IFormattable
{
	[Token(Token = "0x400012A")]
	public static readonly int4x2 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000128")]
	public int4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000129")]
	public int4 c1; //Field offset: 0x10

	[Token(Token = "0x1700099A")]
	public int4 Item
	{
		[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
		[Token(Token = "0x6001D9E")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x648E10", Offset = "0x648210", Length = "0xF")]
	[Token(Token = "0x6001D59")]
	public int4x2(int4 c0, int4 c1) { }

	[Address(RVA = "0x2A8FD90", Offset = "0x2A8F190", Length = "0x4C")]
	[Token(Token = "0x6001D5A")]
	public int4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31) { }

	[Address(RVA = "0x2A8FCE0", Offset = "0x2A8F0E0", Length = "0x36")]
	[Token(Token = "0x6001D5B")]
	public int4x2(int v) { }

	[Address(RVA = "0x2B0AFF0", Offset = "0x2B0A3F0", Length = "0x22")]
	[Token(Token = "0x6001D5C")]
	public int4x2(bool v) { }

	[Address(RVA = "0x2A8FDE0", Offset = "0x2A8F1E0", Length = "0x9F")]
	[Token(Token = "0x6001D5D")]
	public int4x2(bool4x2 v) { }

	[Address(RVA = "0x2A8FCE0", Offset = "0x2A8F0E0", Length = "0x36")]
	[Token(Token = "0x6001D5E")]
	public int4x2(uint v) { }

	[Address(RVA = "0x2A8FD20", Offset = "0x2A8F120", Length = "0x6E")]
	[Token(Token = "0x6001D5F")]
	public int4x2(uint4x2 v) { }

	[Address(RVA = "0x2B0AFD0", Offset = "0x2B0A3D0", Length = "0x1E")]
	[Token(Token = "0x6001D60")]
	public int4x2(float v) { }

	[Address(RVA = "0x2B0B100", Offset = "0x2B0A500", Length = "0x81")]
	[Token(Token = "0x6001D61")]
	public int4x2(float4x2 v) { }

	[Address(RVA = "0x2B0B0A0", Offset = "0x2B0A4A0", Length = "0x56")]
	[Token(Token = "0x6001D62")]
	public int4x2(double v) { }

	[Address(RVA = "0x2B0B020", Offset = "0x2B0A420", Length = "0x75")]
	[Token(Token = "0x6001D63")]
	public int4x2(double4x2 v) { }

	[Address(RVA = "0x2A8F4C0", Offset = "0x2A8E8C0", Length = "0x67")]
	[Token(Token = "0x6001D9F")]
	public override bool Equals(int4x2 rhs) { }

	[Address(RVA = "0x2B0A740", Offset = "0x2B09B40", Length = "0xE0")]
	[Token(Token = "0x6001DA0")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x6001D9E")]
	public int4 get_Item(int index) { }

	[Address(RVA = "0x2B0A830", Offset = "0x2B09C30", Length = "0x85")]
	[Token(Token = "0x6001DA1")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A8FE80", Offset = "0x2A8F280", Length = "0xB4")]
	[Token(Token = "0x6001D70")]
	public static int4x2 op_Addition(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A8FFC0", Offset = "0x2A8F3C0", Length = "0x82")]
	[Token(Token = "0x6001D71")]
	public static int4x2 op_Addition(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2A8FF40", Offset = "0x2A8F340", Length = "0x7E")]
	[Token(Token = "0x6001D72")]
	public static int4x2 op_Addition(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A90150", Offset = "0x2A8F550", Length = "0xB4")]
	[Token(Token = "0x6001D95")]
	public static int4x2 op_BitwiseAnd(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A90050", Offset = "0x2A8F450", Length = "0x7D")]
	[Token(Token = "0x6001D96")]
	public static int4x2 op_BitwiseAnd(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2A900D0", Offset = "0x2A8F4D0", Length = "0x79")]
	[Token(Token = "0x6001D97")]
	public static int4x2 op_BitwiseAnd(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A90210", Offset = "0x2A8F610", Length = "0x79")]
	[Token(Token = "0x6001D9A")]
	public static int4x2 op_BitwiseOr(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x27EFD90", Offset = "0x27EF190", Length = "0xB4")]
	[Token(Token = "0x6001D98")]
	public static int4x2 op_BitwiseOr(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A90290", Offset = "0x2A8F690", Length = "0x7D")]
	[Token(Token = "0x6001D99")]
	public static int4x2 op_BitwiseOr(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2A90310", Offset = "0x2A8F710", Length = "0x77")]
	[Token(Token = "0x6001D7D")]
	public static int4x2 op_Decrement(int4x2 val) { }

	[Address(RVA = "0x2B0B220", Offset = "0x2B0A620", Length = "0x98")]
	[Token(Token = "0x6001D78")]
	public static int4x2 op_Division(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x2B0B190", Offset = "0x2B0A590", Length = "0x8B")]
	[Token(Token = "0x6001D77")]
	public static int4x2 op_Division(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2B0B2C0", Offset = "0x2B0A6C0", Length = "0xC2")]
	[Token(Token = "0x6001D76")]
	public static int4x2 op_Division(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A905B0", Offset = "0x2A8F9B0", Length = "0xD6")]
	[Token(Token = "0x6001D90")]
	public static bool4x2 op_Equality(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A90750", Offset = "0x2A8FB50", Length = "0x117")]
	[Token(Token = "0x6001D8E")]
	public static bool4x2 op_Equality(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A90690", Offset = "0x2A8FA90", Length = "0xBE")]
	[Token(Token = "0x6001D8F")]
	public static bool4x2 op_Equality(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2A90870", Offset = "0x2A8FC70", Length = "0x79")]
	[Token(Token = "0x6001D9D")]
	public static int4x2 op_ExclusiveOr(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x27F1440", Offset = "0x27F0840", Length = "0xB4")]
	[Token(Token = "0x6001D9B")]
	public static int4x2 op_ExclusiveOr(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A908F0", Offset = "0x2A8FCF0", Length = "0x7D")]
	[Token(Token = "0x6001D9C")]
	public static int4x2 op_ExclusiveOr(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2A44B60", Offset = "0x2A43F60", Length = "0x5F")]
	[Token(Token = "0x6001D68")]
	public static int4x2 op_Explicit(uint4x2 v) { }

	[Address(RVA = "0x2A44BC0", Offset = "0x2A43FC0", Length = "0x21")]
	[Token(Token = "0x6001D69")]
	public static int4x2 op_Explicit(float v) { }

	[Address(RVA = "0x2A44C20", Offset = "0x2A44020", Length = "0x8B")]
	[Token(Token = "0x6001D6A")]
	public static int4x2 op_Explicit(float4x2 v) { }

	[Address(RVA = "0x2A44A40", Offset = "0x2A43E40", Length = "0x59")]
	[Token(Token = "0x6001D6B")]
	public static int4x2 op_Explicit(double v) { }

	[Address(RVA = "0x2A44B20", Offset = "0x2A43F20", Length = "0x39")]
	[Token(Token = "0x6001D67")]
	public static int4x2 op_Explicit(uint v) { }

	[Address(RVA = "0x2A44BF0", Offset = "0x2A43FF0", Length = "0x25")]
	[Token(Token = "0x6001D65")]
	public static int4x2 op_Explicit(bool v) { }

	[Address(RVA = "0x2A44CB0", Offset = "0x2A440B0", Length = "0xA2")]
	[Token(Token = "0x6001D66")]
	public static int4x2 op_Explicit(bool4x2 v) { }

	[Address(RVA = "0x2A44AA0", Offset = "0x2A43EA0", Length = "0x78")]
	[Token(Token = "0x6001D6C")]
	public static int4x2 op_Explicit(double4x2 v) { }

	[Address(RVA = "0x2B0B730", Offset = "0x2B0AB30", Length = "0x117")]
	[Token(Token = "0x6001D84")]
	public static bool4x2 op_GreaterThan(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2B0B850", Offset = "0x2B0AC50", Length = "0xBE")]
	[Token(Token = "0x6001D85")]
	public static bool4x2 op_GreaterThan(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2B0B650", Offset = "0x2B0AA50", Length = "0xD6")]
	[Token(Token = "0x6001D86")]
	public static bool4x2 op_GreaterThan(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x2B0B450", Offset = "0x2B0A850", Length = "0x117")]
	[Token(Token = "0x6001D87")]
	public static bool4x2 op_GreaterThanOrEqual(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2B0B390", Offset = "0x2B0A790", Length = "0xBE")]
	[Token(Token = "0x6001D88")]
	public static bool4x2 op_GreaterThanOrEqual(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2B0B570", Offset = "0x2B0A970", Length = "0xD6")]
	[Token(Token = "0x6001D89")]
	public static bool4x2 op_GreaterThanOrEqual(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A44B20", Offset = "0x2A43F20", Length = "0x39")]
	[Token(Token = "0x6001D64")]
	public static int4x2 op_Implicit(int v) { }

	[Address(RVA = "0x2A91010", Offset = "0x2A90410", Length = "0x77")]
	[Token(Token = "0x6001D7C")]
	public static int4x2 op_Increment(int4x2 val) { }

	[Address(RVA = "0x2A91290", Offset = "0x2A90690", Length = "0xBE")]
	[Token(Token = "0x6001D92")]
	public static bool4x2 op_Inequality(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2A91170", Offset = "0x2A90570", Length = "0x117")]
	[Token(Token = "0x6001D91")]
	public static bool4x2 op_Inequality(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A91090", Offset = "0x2A90490", Length = "0xD6")]
	[Token(Token = "0x6001D93")]
	public static bool4x2 op_Inequality(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A91350", Offset = "0x2A90750", Length = "0x81")]
	[Token(Token = "0x6001D8C")]
	public static int4x2 op_LeftShift(int4x2 x, int n) { }

	[Address(RVA = "0x2B0BCB0", Offset = "0x2B0B0B0", Length = "0x117")]
	[Token(Token = "0x6001D7E")]
	public static bool4x2 op_LessThan(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2B0BBD0", Offset = "0x2B0AFD0", Length = "0xD6")]
	[Token(Token = "0x6001D80")]
	public static bool4x2 op_LessThan(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x2B0BDD0", Offset = "0x2B0B1D0", Length = "0xBE")]
	[Token(Token = "0x6001D7F")]
	public static bool4x2 op_LessThan(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2B0BAF0", Offset = "0x2B0AEF0", Length = "0xD6")]
	[Token(Token = "0x6001D83")]
	public static bool4x2 op_LessThanOrEqual(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x2B0B910", Offset = "0x2B0AD10", Length = "0xBE")]
	[Token(Token = "0x6001D82")]
	public static bool4x2 op_LessThanOrEqual(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2B0B9D0", Offset = "0x2B0ADD0", Length = "0x117")]
	[Token(Token = "0x6001D81")]
	public static bool4x2 op_LessThanOrEqual(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2B0BF20", Offset = "0x2B0B320", Length = "0x98")]
	[Token(Token = "0x6001D7B")]
	public static int4x2 op_Modulus(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x2B0BFC0", Offset = "0x2B0B3C0", Length = "0xC2")]
	[Token(Token = "0x6001D79")]
	public static int4x2 op_Modulus(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2B0BE90", Offset = "0x2B0B290", Length = "0x8B")]
	[Token(Token = "0x6001D7A")]
	public static int4x2 op_Modulus(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2A91CA0", Offset = "0x2A910A0", Length = "0xBC")]
	[Token(Token = "0x6001D6D")]
	public static int4x2 op_Multiply(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A91C10", Offset = "0x2A91010", Length = "0x81")]
	[Token(Token = "0x6001D6F")]
	public static int4x2 op_Multiply(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A91B80", Offset = "0x2A90F80", Length = "0x85")]
	[Token(Token = "0x6001D6E")]
	public static int4x2 op_Multiply(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2A91D60", Offset = "0x2A91160", Length = "0x75")]
	[Token(Token = "0x6001D94")]
	public static int4x2 op_OnesComplement(int4x2 val) { }

	[Address(RVA = "0x2B0C090", Offset = "0x2B0B490", Length = "0x81")]
	[Token(Token = "0x6001D8D")]
	public static int4x2 op_RightShift(int4x2 x, int n) { }

	[Address(RVA = "0x2A91EF0", Offset = "0x2A912F0", Length = "0x8D")]
	[Token(Token = "0x6001D75")]
	public static int4x2 op_Subtraction(int lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A91E70", Offset = "0x2A91270", Length = "0x7D")]
	[Token(Token = "0x6001D74")]
	public static int4x2 op_Subtraction(int4x2 lhs, int rhs) { }

	[Address(RVA = "0x2A91F80", Offset = "0x2A91380", Length = "0xB4")]
	[Token(Token = "0x6001D73")]
	public static int4x2 op_Subtraction(int4x2 lhs, int4x2 rhs) { }

	[Address(RVA = "0x2A92040", Offset = "0x2A91440", Length = "0x75")]
	[Token(Token = "0x6001D8A")]
	public static int4x2 op_UnaryNegation(int4x2 val) { }

	[Address(RVA = "0x2A920C0", Offset = "0x2A914C0", Length = "0x78")]
	[Token(Token = "0x6001D8B")]
	public static int4x2 op_UnaryPlus(int4x2 val) { }

	[Address(RVA = "0x2B0A8C0", Offset = "0x2B09CC0", Length = "0x384")]
	[Token(Token = "0x6001DA2")]
	public virtual string ToString() { }

	[Address(RVA = "0x2B0AC50", Offset = "0x2B0A050", Length = "0x37E")]
	[Token(Token = "0x6001DA3")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

