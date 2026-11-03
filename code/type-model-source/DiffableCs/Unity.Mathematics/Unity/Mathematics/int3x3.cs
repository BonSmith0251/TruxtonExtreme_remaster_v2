namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000046")]
public struct int3x3 : IEquatable<int3x3>, IFormattable
{
	[Token(Token = "0x4000118")]
	public static readonly int3x3 identity; //Field offset: 0x0
	[Token(Token = "0x4000119")]
	public static readonly int3x3 zero; //Field offset: 0x24
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000115")]
	public int3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000116")]
	public int3 c1; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000117")]
	public int3 c2; //Field offset: 0x18

	[Token(Token = "0x17000847")]
	public int3 Item
	{
		[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
		[Token(Token = "0x6001B28")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x2B031E0", Offset = "0x2B025E0", Length = "0x49")]
	[Token(Token = "0x6001B2E")]
	private static int3x3() { }

	[Address(RVA = "0x2B03340", Offset = "0x2B02740", Length = "0xA6")]
	[Token(Token = "0x6001AED")]
	public int3x3(double3x3 v) { }

	[Address(RVA = "0x2B032D0", Offset = "0x2B026D0", Length = "0x68")]
	[Token(Token = "0x6001AEC")]
	public int3x3(double v) { }

	[Address(RVA = "0x2B03230", Offset = "0x2B02630", Length = "0x97")]
	[Token(Token = "0x6001AEB")]
	public int3x3(float3x3 v) { }

	[Address(RVA = "0x2B033F0", Offset = "0x2B027F0", Length = "0x68")]
	[Token(Token = "0x6001AEA")]
	public int3x3(float v) { }

	[Address(RVA = "0x2A82B10", Offset = "0x2A81F10", Length = "0xA7")]
	[Token(Token = "0x6001AE9")]
	public int3x3(uint3x3 v) { }

	[Address(RVA = "0x2A82CE0", Offset = "0x2A820E0", Length = "0x31")]
	[Token(Token = "0x6001AE3")]
	public int3x3(int3 c0, int3 c1, int3 c2) { }

	[Address(RVA = "0x2A82C10", Offset = "0x2A82010", Length = "0xD0")]
	[Token(Token = "0x6001AE7")]
	public int3x3(bool3x3 v) { }

	[Address(RVA = "0x2A1B000", Offset = "0x2A1A400", Length = "0x92")]
	[Token(Token = "0x6001AE6")]
	public int3x3(bool v) { }

	[Address(RVA = "0x2A82BC0", Offset = "0x2A81FC0", Length = "0x44")]
	[Token(Token = "0x6001AE5")]
	public int3x3(int v) { }

	[Address(RVA = "0x2A82AB0", Offset = "0x2A81EB0", Length = "0x5E")]
	[Token(Token = "0x6001AE4")]
	public int3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22) { }

	[Address(RVA = "0x2A82BC0", Offset = "0x2A81FC0", Length = "0x44")]
	[Token(Token = "0x6001AE8")]
	public int3x3(uint v) { }

	[Address(RVA = "0x2A82100", Offset = "0x2A81500", Length = "0xA3")]
	[Token(Token = "0x6001B29")]
	public override bool Equals(int3x3 rhs) { }

	[Address(RVA = "0x2B02840", Offset = "0x2B01C40", Length = "0x11E")]
	[Token(Token = "0x6001B2A")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
	[Token(Token = "0x6001B28")]
	public int3 get_Item(int index) { }

	[Address(RVA = "0x2B02960", Offset = "0x2B01D60", Length = "0xA9")]
	[Token(Token = "0x6001B2B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A82D20", Offset = "0x2A82120", Length = "0xCA")]
	[Token(Token = "0x6001AFC")]
	public static int3x3 op_Addition(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A82DF0", Offset = "0x2A821F0", Length = "0xD3")]
	[Token(Token = "0x6001AFB")]
	public static int3x3 op_Addition(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2A82ED0", Offset = "0x2A822D0", Length = "0x173")]
	[Token(Token = "0x6001AFA")]
	public static int3x3 op_Addition(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A83120", Offset = "0x2A82520", Length = "0x168")]
	[Token(Token = "0x6001B1F")]
	public static int3x3 op_BitwiseAnd(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A83290", Offset = "0x2A82690", Length = "0xCD")]
	[Token(Token = "0x6001B20")]
	public static int3x3 op_BitwiseAnd(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2A83050", Offset = "0x2A82450", Length = "0xCB")]
	[Token(Token = "0x6001B21")]
	public static int3x3 op_BitwiseAnd(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A835A0", Offset = "0x2A829A0", Length = "0xCD")]
	[Token(Token = "0x6001B23")]
	public static int3x3 op_BitwiseOr(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2A834D0", Offset = "0x2A828D0", Length = "0xCB")]
	[Token(Token = "0x6001B24")]
	public static int3x3 op_BitwiseOr(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A83360", Offset = "0x2A82760", Length = "0x168")]
	[Token(Token = "0x6001B22")]
	public static int3x3 op_BitwiseOr(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A83670", Offset = "0x2A82A70", Length = "0xE4")]
	[Token(Token = "0x6001B07")]
	public static int3x3 op_Decrement(int3x3 val) { }

	[Address(RVA = "0x2B035E0", Offset = "0x2B029E0", Length = "0xF3")]
	[Token(Token = "0x6001B02")]
	public static int3x3 op_Division(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2B03460", Offset = "0x2B02860", Length = "0x17F")]
	[Token(Token = "0x6001B00")]
	public static int3x3 op_Division(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2B036E0", Offset = "0x2B02AE0", Length = "0xE7")]
	[Token(Token = "0x6001B01")]
	public static int3x3 op_Division(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2A83AE0", Offset = "0x2A82EE0", Length = "0xD2")]
	[Token(Token = "0x6001B19")]
	public static bool3x3 op_Equality(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2A83CA0", Offset = "0x2A830A0", Length = "0x178")]
	[Token(Token = "0x6001B18")]
	public static bool3x3 op_Equality(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A83BC0", Offset = "0x2A82FC0", Length = "0xD1")]
	[Token(Token = "0x6001B1A")]
	public static bool3x3 op_Equality(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A83EF0", Offset = "0x2A832F0", Length = "0xCD")]
	[Token(Token = "0x6001B26")]
	public static int3x3 op_ExclusiveOr(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2A83E20", Offset = "0x2A83220", Length = "0xCB")]
	[Token(Token = "0x6001B27")]
	public static int3x3 op_ExclusiveOr(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A83FC0", Offset = "0x2A833C0", Length = "0x168")]
	[Token(Token = "0x6001B25")]
	public static int3x3 op_ExclusiveOr(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A43ED0", Offset = "0x2A432D0", Length = "0x92")]
	[Token(Token = "0x6001AF4")]
	public static int3x3 op_Explicit(float3x3 v) { }

	[Address(RVA = "0x2A43E20", Offset = "0x2A43220", Length = "0xA7")]
	[Token(Token = "0x6001AF6")]
	public static int3x3 op_Explicit(double3x3 v) { }

	[Address(RVA = "0x2A43D00", Offset = "0x2A43100", Length = "0x6B")]
	[Token(Token = "0x6001AF3")]
	public static int3x3 op_Explicit(float v) { }

	[Address(RVA = "0x2A43D70", Offset = "0x2A43170", Length = "0xA4")]
	[Token(Token = "0x6001AF2")]
	public static int3x3 op_Explicit(uint3x3 v) { }

	[Address(RVA = "0x2A43CB0", Offset = "0x2A430B0", Length = "0x47")]
	[Token(Token = "0x6001AF1")]
	public static int3x3 op_Explicit(uint v) { }

	[Address(RVA = "0x2A44050", Offset = "0x2A43450", Length = "0xD3")]
	[Token(Token = "0x6001AF0")]
	public static int3x3 op_Explicit(bool3x3 v) { }

	[Address(RVA = "0x2A84190", Offset = "0x2A83590", Length = "0x29")]
	[Token(Token = "0x6001AEF")]
	public static int3x3 op_Explicit(bool v) { }

	[Address(RVA = "0x2A43FE0", Offset = "0x2A433E0", Length = "0x6B")]
	[Token(Token = "0x6001AF5")]
	public static int3x3 op_Explicit(double v) { }

	[Address(RVA = "0x2B03B10", Offset = "0x2B02F10", Length = "0xD1")]
	[Token(Token = "0x6001B10")]
	public static bool3x3 op_GreaterThan(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2B03BF0", Offset = "0x2B02FF0", Length = "0xD2")]
	[Token(Token = "0x6001B0F")]
	public static bool3x3 op_GreaterThan(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2B03CD0", Offset = "0x2B030D0", Length = "0x178")]
	[Token(Token = "0x6001B0E")]
	public static bool3x3 op_GreaterThan(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2B038B0", Offset = "0x2B02CB0", Length = "0x178")]
	[Token(Token = "0x6001B11")]
	public static bool3x3 op_GreaterThanOrEqual(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2B037D0", Offset = "0x2B02BD0", Length = "0xD2")]
	[Token(Token = "0x6001B12")]
	public static bool3x3 op_GreaterThanOrEqual(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2B03A30", Offset = "0x2B02E30", Length = "0xD1")]
	[Token(Token = "0x6001B13")]
	public static bool3x3 op_GreaterThanOrEqual(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A43CB0", Offset = "0x2A430B0", Length = "0x47")]
	[Token(Token = "0x6001AEE")]
	public static int3x3 op_Implicit(int v) { }

	[Address(RVA = "0x2A848F0", Offset = "0x2A83CF0", Length = "0xE4")]
	[Token(Token = "0x6001B06")]
	public static int3x3 op_Increment(int3x3 val) { }

	[Address(RVA = "0x2A84C40", Offset = "0x2A84040", Length = "0xD1")]
	[Token(Token = "0x6001B1D")]
	public static bool3x3 op_Inequality(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A84B60", Offset = "0x2A83F60", Length = "0xD2")]
	[Token(Token = "0x6001B1C")]
	public static bool3x3 op_Inequality(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2A849E0", Offset = "0x2A83DE0", Length = "0x178")]
	[Token(Token = "0x6001B1B")]
	public static bool3x3 op_Inequality(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A84D20", Offset = "0x2A84120", Length = "0xD3")]
	[Token(Token = "0x6001B16")]
	public static int3x3 op_LeftShift(int3x3 x, int n) { }

	[Address(RVA = "0x2B04190", Offset = "0x2B03590", Length = "0x178")]
	[Token(Token = "0x6001B08")]
	public static bool3x3 op_LessThan(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2B04310", Offset = "0x2B03710", Length = "0xD1")]
	[Token(Token = "0x6001B0A")]
	public static bool3x3 op_LessThan(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2B043F0", Offset = "0x2B037F0", Length = "0xD2")]
	[Token(Token = "0x6001B09")]
	public static bool3x3 op_LessThan(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2B03FD0", Offset = "0x2B033D0", Length = "0xD2")]
	[Token(Token = "0x6001B0C")]
	public static bool3x3 op_LessThanOrEqual(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2B040B0", Offset = "0x2B034B0", Length = "0xD1")]
	[Token(Token = "0x6001B0D")]
	public static bool3x3 op_LessThanOrEqual(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2B03E50", Offset = "0x2B03250", Length = "0x178")]
	[Token(Token = "0x6001B0B")]
	public static bool3x3 op_LessThanOrEqual(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2B044D0", Offset = "0x2B038D0", Length = "0x17F")]
	[Token(Token = "0x6001B03")]
	public static int3x3 op_Modulus(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2B04650", Offset = "0x2B03A50", Length = "0xF3")]
	[Token(Token = "0x6001B05")]
	public static int3x3 op_Modulus(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2B04750", Offset = "0x2B03B50", Length = "0xE7")]
	[Token(Token = "0x6001B04")]
	public static int3x3 op_Modulus(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2A85800", Offset = "0x2A84C00", Length = "0xDE")]
	[Token(Token = "0x6001AF9")]
	public static int3x3 op_Multiply(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A85A60", Offset = "0x2A84E60", Length = "0xE0")]
	[Token(Token = "0x6001AF8")]
	public static int3x3 op_Multiply(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2A858E0", Offset = "0x2A84CE0", Length = "0x174")]
	[Token(Token = "0x6001AF7")]
	public static int3x3 op_Multiply(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A85B40", Offset = "0x2A84F40", Length = "0xC2")]
	[Token(Token = "0x6001B1E")]
	public static int3x3 op_OnesComplement(int3x3 val) { }

	[Address(RVA = "0x2B04840", Offset = "0x2B03C40", Length = "0xD3")]
	[Token(Token = "0x6001B17")]
	public static int3x3 op_RightShift(int3x3 x, int n) { }

	[Address(RVA = "0x2A85F20", Offset = "0x2A85320", Length = "0xD3")]
	[Token(Token = "0x6001AFF")]
	public static int3x3 op_Subtraction(int lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A85E50", Offset = "0x2A85250", Length = "0xCD")]
	[Token(Token = "0x6001AFE")]
	public static int3x3 op_Subtraction(int3x3 lhs, int rhs) { }

	[Address(RVA = "0x2A85CF0", Offset = "0x2A850F0", Length = "0x15F")]
	[Token(Token = "0x6001AFD")]
	public static int3x3 op_Subtraction(int3x3 lhs, int3x3 rhs) { }

	[Address(RVA = "0x2A86000", Offset = "0x2A85400", Length = "0xCC")]
	[Token(Token = "0x6001B14")]
	public static int3x3 op_UnaryNegation(int3x3 val) { }

	[Address(RVA = "0x2A860D0", Offset = "0x2A854D0", Length = "0xB6")]
	[Token(Token = "0x6001B15")]
	public static int3x3 op_UnaryPlus(int3x3 val) { }

	[Address(RVA = "0x2B02DF0", Offset = "0x2B021F0", Length = "0x3E6")]
	[Token(Token = "0x6001B2C")]
	public virtual string ToString() { }

	[Address(RVA = "0x2B02A10", Offset = "0x2B01E10", Length = "0x3DA")]
	[Token(Token = "0x6001B2D")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

