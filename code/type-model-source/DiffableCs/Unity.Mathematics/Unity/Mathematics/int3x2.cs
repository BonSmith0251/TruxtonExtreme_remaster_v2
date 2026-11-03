namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000045")]
public struct int3x2 : IEquatable<int3x2>, IFormattable
{
	[Token(Token = "0x4000114")]
	public static readonly int3x2 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000112")]
	public int3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000113")]
	public int3 c1; //Field offset: 0xC

	[Token(Token = "0x17000846")]
	public int3 Item
	{
		[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
		[Token(Token = "0x6001ADD")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x665C80", Offset = "0x665080", Length = "0x20")]
	[Token(Token = "0x6001A98")]
	public int3x2(int3 c0, int3 c1) { }

	[Address(RVA = "0x2B00470", Offset = "0x2AFF870", Length = "0x3E")]
	[Token(Token = "0x6001A99")]
	public int3x2(int m00, int m01, int m10, int m11, int m20, int m21) { }

	[Address(RVA = "0x2B00580", Offset = "0x2AFF980", Length = "0x30")]
	[Token(Token = "0x6001A9A")]
	public int3x2(int v) { }

	[Address(RVA = "0x2A1AF90", Offset = "0x2A1A390", Length = "0x6A")]
	[Token(Token = "0x6001A9B")]
	public int3x2(bool v) { }

	[Address(RVA = "0x2B003D0", Offset = "0x2AFF7D0", Length = "0x91")]
	[Token(Token = "0x6001A9C")]
	public int3x2(bool3x2 v) { }

	[Address(RVA = "0x2B00580", Offset = "0x2AFF980", Length = "0x30")]
	[Token(Token = "0x6001A9D")]
	public int3x2(uint v) { }

	[Address(RVA = "0x2B00500", Offset = "0x2AFF900", Length = "0x74")]
	[Token(Token = "0x6001A9E")]
	public int3x2(uint3x2 v) { }

	[Address(RVA = "0x2B004B0", Offset = "0x2AFF8B0", Length = "0x48")]
	[Token(Token = "0x6001A9F")]
	public int3x2(float v) { }

	[Address(RVA = "0x2B005B0", Offset = "0x2AFF9B0", Length = "0x67")]
	[Token(Token = "0x6001AA0")]
	public int3x2(float3x2 v) { }

	[Address(RVA = "0x2B00620", Offset = "0x2AFFA20", Length = "0x48")]
	[Token(Token = "0x6001AA1")]
	public int3x2(double v) { }

	[Address(RVA = "0x2B00350", Offset = "0x2AFF750", Length = "0x71")]
	[Token(Token = "0x6001AA2")]
	public int3x2(double3x2 v) { }

	[Address(RVA = "0x2AFFBC0", Offset = "0x2AFEFC0", Length = "0x72")]
	[Token(Token = "0x6001ADE")]
	public override bool Equals(int3x2 rhs) { }

	[Address(RVA = "0x2AFFC40", Offset = "0x2AFF040", Length = "0xED")]
	[Token(Token = "0x6001ADF")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
	[Token(Token = "0x6001ADD")]
	public int3 get_Item(int index) { }

	[Address(RVA = "0x2AFFD30", Offset = "0x2AFF130", Length = "0x74")]
	[Token(Token = "0x6001AE0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2B00700", Offset = "0x2AFFB00", Length = "0xEA")]
	[Token(Token = "0x6001AAF")]
	public static int3x2 op_Addition(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B00670", Offset = "0x2AFFA70", Length = "0x8F")]
	[Token(Token = "0x6001AB0")]
	public static int3x2 op_Addition(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B007F0", Offset = "0x2AFFBF0", Length = "0x96")]
	[Token(Token = "0x6001AB1")]
	public static int3x2 op_Addition(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B00890", Offset = "0x2AFFC90", Length = "0xE7")]
	[Token(Token = "0x6001AD4")]
	public static int3x2 op_BitwiseAnd(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B00A20", Offset = "0x2AFFE20", Length = "0x91")]
	[Token(Token = "0x6001AD5")]
	public static int3x2 op_BitwiseAnd(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B00980", Offset = "0x2AFFD80", Length = "0x94")]
	[Token(Token = "0x6001AD6")]
	public static int3x2 op_BitwiseAnd(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B00C50", Offset = "0x2B00050", Length = "0x94")]
	[Token(Token = "0x6001AD9")]
	public static int3x2 op_BitwiseOr(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B00B60", Offset = "0x2AFFF60", Length = "0xE7")]
	[Token(Token = "0x6001AD7")]
	public static int3x2 op_BitwiseOr(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B00AC0", Offset = "0x2AFFEC0", Length = "0x91")]
	[Token(Token = "0x6001AD8")]
	public static int3x2 op_BitwiseOr(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B00CF0", Offset = "0x2B000F0", Length = "0x84")]
	[Token(Token = "0x6001ABC")]
	public static int3x2 op_Decrement(int3x2 val) { }

	[Address(RVA = "0x2B00F20", Offset = "0x2B00320", Length = "0xA9")]
	[Token(Token = "0x6001AB7")]
	public static int3x2 op_Division(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B00D80", Offset = "0x2B00180", Length = "0x9F")]
	[Token(Token = "0x6001AB6")]
	public static int3x2 op_Division(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B00E20", Offset = "0x2B00220", Length = "0xF2")]
	[Token(Token = "0x6001AB5")]
	public static int3x2 op_Division(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B01140", Offset = "0x2B00540", Length = "0x8E")]
	[Token(Token = "0x6001ACF")]
	public static bool3x2 op_Equality(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B00FD0", Offset = "0x2B003D0", Length = "0xDC")]
	[Token(Token = "0x6001ACD")]
	public static bool3x2 op_Equality(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B010B0", Offset = "0x2B004B0", Length = "0x8F")]
	[Token(Token = "0x6001ACE")]
	public static bool3x2 op_Equality(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B01360", Offset = "0x2B00760", Length = "0x94")]
	[Token(Token = "0x6001ADC")]
	public static int3x2 op_ExclusiveOr(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B01270", Offset = "0x2B00670", Length = "0xE7")]
	[Token(Token = "0x6001ADA")]
	public static int3x2 op_ExclusiveOr(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B011D0", Offset = "0x2B005D0", Length = "0x91")]
	[Token(Token = "0x6001ADB")]
	public static int3x2 op_ExclusiveOr(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2A43970", Offset = "0x2A42D70", Length = "0x7A")]
	[Token(Token = "0x6001AA7")]
	public static int3x2 op_Explicit(uint3x2 v) { }

	[Address(RVA = "0x2A43C10", Offset = "0x2A43010", Length = "0x4B")]
	[Token(Token = "0x6001AA8")]
	public static int3x2 op_Explicit(float v) { }

	[Address(RVA = "0x2A439F0", Offset = "0x2A42DF0", Length = "0x74")]
	[Token(Token = "0x6001AA9")]
	public static int3x2 op_Explicit(float3x2 v) { }

	[Address(RVA = "0x2A43C60", Offset = "0x2A43060", Length = "0x4B")]
	[Token(Token = "0x6001AAA")]
	public static int3x2 op_Explicit(double v) { }

	[Address(RVA = "0x2A43AC0", Offset = "0x2A42EC0", Length = "0x33")]
	[Token(Token = "0x6001AA6")]
	public static int3x2 op_Explicit(uint v) { }

	[Address(RVA = "0x2A43B00", Offset = "0x2A42F00", Length = "0x70")]
	[Token(Token = "0x6001AA4")]
	public static int3x2 op_Explicit(bool v) { }

	[Address(RVA = "0x2A43B70", Offset = "0x2A42F70", Length = "0x96")]
	[Token(Token = "0x6001AA5")]
	public static int3x2 op_Explicit(bool3x2 v) { }

	[Address(RVA = "0x2A43910", Offset = "0x2A42D10", Length = "0x5C")]
	[Token(Token = "0x6001AAB")]
	public static int3x2 op_Explicit(double3x2 v) { }

	[Address(RVA = "0x2B01600", Offset = "0x2B00A00", Length = "0xDC")]
	[Token(Token = "0x6001AC3")]
	public static bool3x2 op_GreaterThan(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B016E0", Offset = "0x2B00AE0", Length = "0x8F")]
	[Token(Token = "0x6001AC4")]
	public static bool3x2 op_GreaterThan(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B01770", Offset = "0x2B00B70", Length = "0x8E")]
	[Token(Token = "0x6001AC5")]
	public static bool3x2 op_GreaterThan(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B01490", Offset = "0x2B00890", Length = "0xDC")]
	[Token(Token = "0x6001AC6")]
	public static bool3x2 op_GreaterThanOrEqual(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B01570", Offset = "0x2B00970", Length = "0x8F")]
	[Token(Token = "0x6001AC7")]
	public static bool3x2 op_GreaterThanOrEqual(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B01400", Offset = "0x2B00800", Length = "0x8E")]
	[Token(Token = "0x6001AC8")]
	public static bool3x2 op_GreaterThanOrEqual(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2A43AC0", Offset = "0x2A42EC0", Length = "0x33")]
	[Token(Token = "0x6001AA3")]
	public static int3x2 op_Implicit(int v) { }

	[Address(RVA = "0x2B01800", Offset = "0x2B00C00", Length = "0x84")]
	[Token(Token = "0x6001ABB")]
	public static int3x2 op_Increment(int3x2 val) { }

	[Address(RVA = "0x2B01970", Offset = "0x2B00D70", Length = "0x8F")]
	[Token(Token = "0x6001AD1")]
	public static bool3x2 op_Inequality(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B01890", Offset = "0x2B00C90", Length = "0xDC")]
	[Token(Token = "0x6001AD0")]
	public static bool3x2 op_Inequality(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B01A00", Offset = "0x2B00E00", Length = "0x8E")]
	[Token(Token = "0x6001AD2")]
	public static bool3x2 op_Inequality(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B01A90", Offset = "0x2B00E90", Length = "0x99")]
	[Token(Token = "0x6001ACB")]
	public static int3x2 op_LeftShift(int3x2 x, int n) { }

	[Address(RVA = "0x2B01DC0", Offset = "0x2B011C0", Length = "0xDC")]
	[Token(Token = "0x6001ABD")]
	public static bool3x2 op_LessThan(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B01D30", Offset = "0x2B01130", Length = "0x8E")]
	[Token(Token = "0x6001ABF")]
	public static bool3x2 op_LessThan(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B01EA0", Offset = "0x2B012A0", Length = "0x8F")]
	[Token(Token = "0x6001ABE")]
	public static bool3x2 op_LessThan(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B01B30", Offset = "0x2B00F30", Length = "0x8E")]
	[Token(Token = "0x6001AC2")]
	public static bool3x2 op_LessThanOrEqual(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B01BC0", Offset = "0x2B00FC0", Length = "0x8F")]
	[Token(Token = "0x6001AC1")]
	public static bool3x2 op_LessThanOrEqual(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B01C50", Offset = "0x2B01050", Length = "0xDC")]
	[Token(Token = "0x6001AC0")]
	public static bool3x2 op_LessThanOrEqual(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B02030", Offset = "0x2B01430", Length = "0xA9")]
	[Token(Token = "0x6001ABA")]
	public static int3x2 op_Modulus(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B01F30", Offset = "0x2B01330", Length = "0xF2")]
	[Token(Token = "0x6001AB8")]
	public static int3x2 op_Modulus(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B020E0", Offset = "0x2B014E0", Length = "0xA1")]
	[Token(Token = "0x6001AB9")]
	public static int3x2 op_Modulus(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B02190", Offset = "0x2B01590", Length = "0xED")]
	[Token(Token = "0x6001AAC")]
	public static int3x2 op_Multiply(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B02280", Offset = "0x2B01680", Length = "0xA0")]
	[Token(Token = "0x6001AAE")]
	public static int3x2 op_Multiply(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B02320", Offset = "0x2B01720", Length = "0x9D")]
	[Token(Token = "0x6001AAD")]
	public static int3x2 op_Multiply(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B023C0", Offset = "0x2B017C0", Length = "0x89")]
	[Token(Token = "0x6001AD3")]
	public static int3x2 op_OnesComplement(int3x2 val) { }

	[Address(RVA = "0x2B02450", Offset = "0x2B01850", Length = "0x99")]
	[Token(Token = "0x6001ACC")]
	public static int3x2 op_RightShift(int3x2 x, int n) { }

	[Address(RVA = "0x2B024F0", Offset = "0x2B018F0", Length = "0x96")]
	[Token(Token = "0x6001AB4")]
	public static int3x2 op_Subtraction(int lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B02680", Offset = "0x2B01A80", Length = "0x91")]
	[Token(Token = "0x6001AB3")]
	public static int3x2 op_Subtraction(int3x2 lhs, int rhs) { }

	[Address(RVA = "0x2B02590", Offset = "0x2B01990", Length = "0xE3")]
	[Token(Token = "0x6001AB2")]
	public static int3x2 op_Subtraction(int3x2 lhs, int3x2 rhs) { }

	[Address(RVA = "0x2B02720", Offset = "0x2B01B20", Length = "0x8F")]
	[Token(Token = "0x6001AC9")]
	public static int3x2 op_UnaryNegation(int3x2 val) { }

	[Address(RVA = "0x2B027B0", Offset = "0x2B01BB0", Length = "0x82")]
	[Token(Token = "0x6001ACA")]
	public static int3x2 op_UnaryPlus(int3x2 val) { }

	[Address(RVA = "0x2B00080", Offset = "0x2AFF480", Length = "0x2C0")]
	[Token(Token = "0x6001AE1")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AFFDB0", Offset = "0x2AFF1B0", Length = "0x2C6")]
	[Token(Token = "0x6001AE2")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

