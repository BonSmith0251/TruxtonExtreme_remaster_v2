namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200002C")]
public struct float2x4 : IEquatable<float2x4>, IFormattable
{
	[Token(Token = "0x40000B7")]
	public static readonly float2x4 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B3")]
	public float2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000B4")]
	public float2 c1; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B5")]
	public float2 c2; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B6")]
	public float2 c3; //Field offset: 0x18

	[Token(Token = "0x170003FA")]
	public float2 Item
	{
		[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
		[Token(Token = "0x6001187")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2ACFBB0", Offset = "0x2ACEFB0", Length = "0x17")]
	[Token(Token = "0x600114E")]
	public float2x4(float2 c0, float2 c1, float2 c2, float2 c3) { }

	[Address(RVA = "0x2ACFD20", Offset = "0x2ACF120", Length = "0x63")]
	[Token(Token = "0x6001157")]
	public float2x4(double v) { }

	[Address(RVA = "0x2ACFC60", Offset = "0x2ACF060", Length = "0xB9")]
	[Token(Token = "0x6001156")]
	public float2x4(uint2x4 v) { }

	[Address(RVA = "0x2ACFDE0", Offset = "0x2ACF1E0", Length = "0x98")]
	[Token(Token = "0x6001155")]
	public float2x4(uint v) { }

	[Address(RVA = "0x2ACFBE0", Offset = "0x2ACEFE0", Length = "0x7F")]
	[Token(Token = "0x6001154")]
	public float2x4(int2x4 v) { }

	[Address(RVA = "0x2ACFB30", Offset = "0x2ACEF30", Length = "0x73")]
	[Token(Token = "0x6001158")]
	public float2x4(double2x4 v) { }

	[Address(RVA = "0x2A18E30", Offset = "0x2A18230", Length = "0xB0")]
	[Token(Token = "0x6001152")]
	public float2x4(bool2x4 v) { }

	[Address(RVA = "0x2ACFD90", Offset = "0x2ACF190", Length = "0x42")]
	[Token(Token = "0x6001151")]
	public float2x4(bool v) { }

	[Address(RVA = "0x2ACFBD0", Offset = "0x2ACEFD0", Length = "0xC")]
	[Token(Token = "0x6001150")]
	public float2x4(float v) { }

	[Address(RVA = "0x2ACFAE0", Offset = "0x2ACEEE0", Length = "0x46")]
	[Token(Token = "0x600114F")]
	public float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13) { }

	[Address(RVA = "0x2ACFE80", Offset = "0x2ACF280", Length = "0x60")]
	[Token(Token = "0x6001153")]
	public float2x4(int v) { }

	[Address(RVA = "0x2ACF2E0", Offset = "0x2ACE6E0", Length = "0x99")]
	[Token(Token = "0x6001189")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AC82D0", Offset = "0x2AC76D0", Length = "0xD88")]
	[Token(Token = "0x6001188")]
	public override bool Equals(float2x4 rhs) { }

	[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
	[Token(Token = "0x6001187")]
	public float2 get_Item(int index) { }

	[Address(RVA = "0x2ACF380", Offset = "0x2ACE780", Length = "0x26")]
	[Token(Token = "0x600118A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2ACFF70", Offset = "0x2ACF370", Length = "0x44")]
	[Token(Token = "0x6001166")]
	public static float2x4 op_Addition(float2x4 lhs, float rhs) { }

	[Address(RVA = "0x2ACFFC0", Offset = "0x2ACF3C0", Length = "0x4C")]
	[Token(Token = "0x6001167")]
	public static float2x4 op_Addition(float lhs, float2x4 rhs) { }

	[Address(RVA = "0x2ACFEE0", Offset = "0x2ACF2E0", Length = "0x8B")]
	[Token(Token = "0x6001165")]
	public static float2x4 op_Addition(float2x4 lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD0010", Offset = "0x2ACF410", Length = "0xC1")]
	[Token(Token = "0x6001172")]
	public static float2x4 op_Decrement(float2x4 val) { }

	[Address(RVA = "0x2AD01F0", Offset = "0x2ACF5F0", Length = "0x49")]
	[Token(Token = "0x600116C")]
	public static float2x4 op_Division(float2x4 lhs, float rhs) { }

	[Address(RVA = "0x2AD0160", Offset = "0x2ACF560", Length = "0x8A")]
	[Token(Token = "0x600116B")]
	public static float2x4 op_Division(float2x4 lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD00E0", Offset = "0x2ACF4E0", Length = "0x78")]
	[Token(Token = "0x600116D")]
	public static float2x4 op_Division(float lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD0390", Offset = "0x2ACF790", Length = "0x12F")]
	[Token(Token = "0x6001182")]
	public static bool2x4 op_Equality(float2x4 lhs, float rhs) { }

	[Address(RVA = "0x2AD0240", Offset = "0x2ACF640", Length = "0x14D")]
	[Token(Token = "0x6001181")]
	public static bool2x4 op_Equality(float2x4 lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD04C0", Offset = "0x2ACF8C0", Length = "0x10E")]
	[Token(Token = "0x6001183")]
	public static bool2x4 op_Equality(float lhs, float2x4 rhs) { }

	[Address(RVA = "0x2A352A0", Offset = "0x2A346A0", Length = "0x66")]
	[Token(Token = "0x6001160")]
	public static float2x4 op_Explicit(double v) { }

	[Address(RVA = "0x2A34F90", Offset = "0x2A34390", Length = "0x45")]
	[Token(Token = "0x600115A")]
	public static float2x4 op_Explicit(bool v) { }

	[Address(RVA = "0x2AD05D0", Offset = "0x2ACF9D0", Length = "0x24")]
	[Token(Token = "0x600115B")]
	public static float2x4 op_Explicit(bool2x4 v) { }

	[Address(RVA = "0x2A34FE0", Offset = "0x2A343E0", Length = "0x8A")]
	[Token(Token = "0x6001161")]
	public static float2x4 op_Explicit(double2x4 v) { }

	[Address(RVA = "0x2AD0AB0", Offset = "0x2ACFEB0", Length = "0xE8")]
	[Token(Token = "0x600117A")]
	public static bool2x4 op_GreaterThan(float2x4 lhs, float rhs) { }

	[Address(RVA = "0x2AD09E0", Offset = "0x2ACFDE0", Length = "0xCD")]
	[Token(Token = "0x600117B")]
	public static bool2x4 op_GreaterThan(float lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD08D0", Offset = "0x2ACFCD0", Length = "0x105")]
	[Token(Token = "0x6001179")]
	public static bool2x4 op_GreaterThan(float2x4 lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD0600", Offset = "0x2ACFA00", Length = "0xE8")]
	[Token(Token = "0x600117D")]
	public static bool2x4 op_GreaterThanOrEqual(float2x4 lhs, float rhs) { }

	[Address(RVA = "0x2AD07C0", Offset = "0x2ACFBC0", Length = "0x105")]
	[Token(Token = "0x600117C")]
	public static bool2x4 op_GreaterThanOrEqual(float2x4 lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD06F0", Offset = "0x2ACFAF0", Length = "0xCD")]
	[Token(Token = "0x600117E")]
	public static bool2x4 op_GreaterThanOrEqual(float lhs, float2x4 rhs) { }

	[Address(RVA = "0x2A35130", Offset = "0x2A34530", Length = "0x9B")]
	[Token(Token = "0x600115E")]
	public static float2x4 op_Implicit(uint v) { }

	[Address(RVA = "0x2A35410", Offset = "0x2A34810", Length = "0xC0")]
	[Token(Token = "0x600115D")]
	public static float2x4 op_Implicit(int2x4 v) { }

	[Address(RVA = "0x2A35290", Offset = "0x2A34690", Length = "0xF")]
	[Token(Token = "0x6001159")]
	public static float2x4 op_Implicit(float v) { }

	[Address(RVA = "0x2A35310", Offset = "0x2A34710", Length = "0xFA")]
	[Token(Token = "0x600115F")]
	public static float2x4 op_Implicit(uint2x4 v) { }

	[Address(RVA = "0x2A35220", Offset = "0x2A34620", Length = "0x63")]
	[Token(Token = "0x600115C")]
	public static float2x4 op_Implicit(int v) { }

	[Address(RVA = "0x2AD0BA0", Offset = "0x2ACFFA0", Length = "0xC1")]
	[Token(Token = "0x6001171")]
	public static float2x4 op_Increment(float2x4 val) { }

	[Address(RVA = "0x2AD0C70", Offset = "0x2AD0070", Length = "0x12F")]
	[Token(Token = "0x6001185")]
	public static bool2x4 op_Inequality(float2x4 lhs, float rhs) { }

	[Address(RVA = "0x2AD0DA0", Offset = "0x2AD01A0", Length = "0x14D")]
	[Token(Token = "0x6001184")]
	public static bool2x4 op_Inequality(float2x4 lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD0EF0", Offset = "0x2AD02F0", Length = "0x10E")]
	[Token(Token = "0x6001186")]
	public static bool2x4 op_Inequality(float lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD1490", Offset = "0x2AD0890", Length = "0x105")]
	[Token(Token = "0x6001173")]
	public static bool2x4 op_LessThan(float2x4 lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD12D0", Offset = "0x2AD06D0", Length = "0xE8")]
	[Token(Token = "0x6001175")]
	public static bool2x4 op_LessThan(float lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD13C0", Offset = "0x2AD07C0", Length = "0xD0")]
	[Token(Token = "0x6001174")]
	public static bool2x4 op_LessThan(float2x4 lhs, float rhs) { }

	[Address(RVA = "0x2AD11C0", Offset = "0x2AD05C0", Length = "0x105")]
	[Token(Token = "0x6001176")]
	public static bool2x4 op_LessThanOrEqual(float2x4 lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD1000", Offset = "0x2AD0400", Length = "0xD0")]
	[Token(Token = "0x6001177")]
	public static bool2x4 op_LessThanOrEqual(float2x4 lhs, float rhs) { }

	[Address(RVA = "0x2AD10D0", Offset = "0x2AD04D0", Length = "0xE8")]
	[Token(Token = "0x6001178")]
	public static bool2x4 op_LessThanOrEqual(float lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD15A0", Offset = "0x2AD09A0", Length = "0xC9")]
	[Token(Token = "0x6001170")]
	public static float2x4 op_Modulus(float lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD1760", Offset = "0x2AD0B60", Length = "0xC8")]
	[Token(Token = "0x600116F")]
	public static float2x4 op_Modulus(float2x4 lhs, float rhs) { }

	[Address(RVA = "0x2AD1670", Offset = "0x2AD0A70", Length = "0xE7")]
	[Token(Token = "0x600116E")]
	public static float2x4 op_Modulus(float2x4 lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD1830", Offset = "0x2AD0C30", Length = "0x4C")]
	[Token(Token = "0x6001164")]
	public static float2x4 op_Multiply(float lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD1910", Offset = "0x2AD0D10", Length = "0x44")]
	[Token(Token = "0x6001163")]
	public static float2x4 op_Multiply(float2x4 lhs, float rhs) { }

	[Address(RVA = "0x2AD1880", Offset = "0x2AD0C80", Length = "0x8B")]
	[Token(Token = "0x6001162")]
	public static float2x4 op_Multiply(float2x4 lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD1A40", Offset = "0x2AD0E40", Length = "0x78")]
	[Token(Token = "0x600116A")]
	public static float2x4 op_Subtraction(float lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD1960", Offset = "0x2AD0D60", Length = "0x49")]
	[Token(Token = "0x6001169")]
	public static float2x4 op_Subtraction(float2x4 lhs, float rhs) { }

	[Address(RVA = "0x2AD19B0", Offset = "0x2AD0DB0", Length = "0x8A")]
	[Token(Token = "0x6001168")]
	public static float2x4 op_Subtraction(float2x4 lhs, float2x4 rhs) { }

	[Address(RVA = "0x2AD1AC0", Offset = "0x2AD0EC0", Length = "0x48")]
	[Token(Token = "0x600117F")]
	public static float2x4 op_UnaryNegation(float2x4 val) { }

	[Address(RVA = "0x2AD1B10", Offset = "0x2AD0F10", Length = "0x3C")]
	[Token(Token = "0x6001180")]
	public static float2x4 op_UnaryPlus(float2x4 val) { }

	[Address(RVA = "0x2ACF730", Offset = "0x2ACEB30", Length = "0x3A4")]
	[Token(Token = "0x600118B")]
	public virtual string ToString() { }

	[Address(RVA = "0x2ACF3B0", Offset = "0x2ACE7B0", Length = "0x37E")]
	[Token(Token = "0x600118C")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

