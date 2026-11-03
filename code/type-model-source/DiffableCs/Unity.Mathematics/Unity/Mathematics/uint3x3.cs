namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200005C")]
public struct uint3x3 : IEquatable<uint3x3>, IFormattable
{
	[Token(Token = "0x400015E")]
	public static readonly uint3x3 identity; //Field offset: 0x0
	[Token(Token = "0x400015F")]
	public static readonly uint3x3 zero; //Field offset: 0x24
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400015B")]
	public uint3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400015C")]
	public uint3 c1; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400015D")]
	public uint3 c2; //Field offset: 0x18

	[Token(Token = "0x17000A34")]
	public uint3 Item
	{
		[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
		[Token(Token = "0x600219D")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x2A82A40", Offset = "0x2A81E40", Length = "0x69")]
	[Token(Token = "0x60021A3")]
	private static uint3x3() { }

	[Address(RVA = "0x2A21C70", Offset = "0x2A21070", Length = "0x13A")]
	[Token(Token = "0x6002162")]
	public uint3x3(double3x3 v) { }

	[Address(RVA = "0x2A21AD0", Offset = "0x2A20ED0", Length = "0xD0")]
	[Token(Token = "0x6002161")]
	public uint3x3(double v) { }

	[Address(RVA = "0x2A21DB0", Offset = "0x2A211B0", Length = "0x128")]
	[Token(Token = "0x6002160")]
	public uint3x3(float3x3 v) { }

	[Address(RVA = "0x2A21BA0", Offset = "0x2A20FA0", Length = "0xCF")]
	[Token(Token = "0x600215F")]
	public uint3x3(float v) { }

	[Address(RVA = "0x2A82B10", Offset = "0x2A81F10", Length = "0xA7")]
	[Token(Token = "0x600215E")]
	public uint3x3(int3x3 v) { }

	[Address(RVA = "0x2A82CE0", Offset = "0x2A820E0", Length = "0x31")]
	[Token(Token = "0x6002158")]
	public uint3x3(uint3 c0, uint3 c1, uint3 c2) { }

	[Address(RVA = "0x2A82C10", Offset = "0x2A82010", Length = "0xD0")]
	[Token(Token = "0x600215C")]
	public uint3x3(bool3x3 v) { }

	[Address(RVA = "0x2A1B000", Offset = "0x2A1A400", Length = "0x92")]
	[Token(Token = "0x600215B")]
	public uint3x3(bool v) { }

	[Address(RVA = "0x2A82BC0", Offset = "0x2A81FC0", Length = "0x44")]
	[Token(Token = "0x600215A")]
	public uint3x3(uint v) { }

	[Address(RVA = "0x2A82AB0", Offset = "0x2A81EB0", Length = "0x5E")]
	[Token(Token = "0x6002159")]
	public uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22) { }

	[Address(RVA = "0x2A82BC0", Offset = "0x2A81FC0", Length = "0x44")]
	[Token(Token = "0x600215D")]
	public uint3x3(int v) { }

	[Address(RVA = "0x2A82100", Offset = "0x2A81500", Length = "0xA3")]
	[Token(Token = "0x600219E")]
	public override bool Equals(uint3x3 rhs) { }

	[Address(RVA = "0x2A81FE0", Offset = "0x2A813E0", Length = "0x11E")]
	[Token(Token = "0x600219F")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
	[Token(Token = "0x600219D")]
	public uint3 get_Item(int index) { }

	[Address(RVA = "0x2A821B0", Offset = "0x2A815B0", Length = "0xB9")]
	[Token(Token = "0x60021A0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2A82D20", Offset = "0x2A82120", Length = "0xCA")]
	[Token(Token = "0x6002171")]
	public static uint3x3 op_Addition(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A82DF0", Offset = "0x2A821F0", Length = "0xD3")]
	[Token(Token = "0x6002170")]
	public static uint3x3 op_Addition(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A82ED0", Offset = "0x2A822D0", Length = "0x173")]
	[Token(Token = "0x600216F")]
	public static uint3x3 op_Addition(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A83120", Offset = "0x2A82520", Length = "0x168")]
	[Token(Token = "0x6002194")]
	public static uint3x3 op_BitwiseAnd(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A83290", Offset = "0x2A82690", Length = "0xCD")]
	[Token(Token = "0x6002195")]
	public static uint3x3 op_BitwiseAnd(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A83050", Offset = "0x2A82450", Length = "0xCB")]
	[Token(Token = "0x6002196")]
	public static uint3x3 op_BitwiseAnd(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A835A0", Offset = "0x2A829A0", Length = "0xCD")]
	[Token(Token = "0x6002198")]
	public static uint3x3 op_BitwiseOr(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A834D0", Offset = "0x2A828D0", Length = "0xCB")]
	[Token(Token = "0x6002199")]
	public static uint3x3 op_BitwiseOr(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A83360", Offset = "0x2A82760", Length = "0x168")]
	[Token(Token = "0x6002197")]
	public static uint3x3 op_BitwiseOr(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A83670", Offset = "0x2A82A70", Length = "0xE4")]
	[Token(Token = "0x600217C")]
	public static uint3x3 op_Decrement(uint3x3 val) { }

	[Address(RVA = "0x2A839E0", Offset = "0x2A82DE0", Length = "0xFD")]
	[Token(Token = "0x6002177")]
	public static uint3x3 op_Division(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A83850", Offset = "0x2A82C50", Length = "0x188")]
	[Token(Token = "0x6002175")]
	public static uint3x3 op_Division(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A83760", Offset = "0x2A82B60", Length = "0xF0")]
	[Token(Token = "0x6002176")]
	public static uint3x3 op_Division(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A83AE0", Offset = "0x2A82EE0", Length = "0xD2")]
	[Token(Token = "0x600218E")]
	public static bool3x3 op_Equality(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A83CA0", Offset = "0x2A830A0", Length = "0x178")]
	[Token(Token = "0x600218D")]
	public static bool3x3 op_Equality(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A83BC0", Offset = "0x2A82FC0", Length = "0xD1")]
	[Token(Token = "0x600218F")]
	public static bool3x3 op_Equality(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A83EF0", Offset = "0x2A832F0", Length = "0xCD")]
	[Token(Token = "0x600219B")]
	public static uint3x3 op_ExclusiveOr(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A83E20", Offset = "0x2A83220", Length = "0xCB")]
	[Token(Token = "0x600219C")]
	public static uint3x3 op_ExclusiveOr(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A83FC0", Offset = "0x2A833C0", Length = "0x168")]
	[Token(Token = "0x600219A")]
	public static uint3x3 op_ExclusiveOr(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A841C0", Offset = "0x2A835C0", Length = "0x46")]
	[Token(Token = "0x6002169")]
	public static uint3x3 op_Explicit(float3x3 v) { }

	[Address(RVA = "0x2A84130", Offset = "0x2A83530", Length = "0x5C")]
	[Token(Token = "0x600216B")]
	public static uint3x3 op_Explicit(double3x3 v) { }

	[Address(RVA = "0x2A84210", Offset = "0x2A83610", Length = "0x29")]
	[Token(Token = "0x6002168")]
	public static uint3x3 op_Explicit(float v) { }

	[Address(RVA = "0x2A43D70", Offset = "0x2A43170", Length = "0xA4")]
	[Token(Token = "0x6002167")]
	public static uint3x3 op_Explicit(int3x3 v) { }

	[Address(RVA = "0x2A43CB0", Offset = "0x2A430B0", Length = "0x47")]
	[Token(Token = "0x6002166")]
	public static uint3x3 op_Explicit(int v) { }

	[Address(RVA = "0x2A44050", Offset = "0x2A43450", Length = "0xD3")]
	[Token(Token = "0x6002165")]
	public static uint3x3 op_Explicit(bool3x3 v) { }

	[Address(RVA = "0x2A84190", Offset = "0x2A83590", Length = "0x29")]
	[Token(Token = "0x6002164")]
	public static uint3x3 op_Explicit(bool v) { }

	[Address(RVA = "0x2A84240", Offset = "0x2A83640", Length = "0x29")]
	[Token(Token = "0x600216A")]
	public static uint3x3 op_Explicit(double v) { }

	[Address(RVA = "0x2A84810", Offset = "0x2A83C10", Length = "0xD1")]
	[Token(Token = "0x6002185")]
	public static bool3x3 op_GreaterThan(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A845B0", Offset = "0x2A839B0", Length = "0xD2")]
	[Token(Token = "0x6002184")]
	public static bool3x3 op_GreaterThan(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A84690", Offset = "0x2A83A90", Length = "0x178")]
	[Token(Token = "0x6002183")]
	public static bool3x3 op_GreaterThan(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A84270", Offset = "0x2A83670", Length = "0x178")]
	[Token(Token = "0x6002186")]
	public static bool3x3 op_GreaterThanOrEqual(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A843F0", Offset = "0x2A837F0", Length = "0xD2")]
	[Token(Token = "0x6002187")]
	public static bool3x3 op_GreaterThanOrEqual(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A844D0", Offset = "0x2A838D0", Length = "0xD1")]
	[Token(Token = "0x6002188")]
	public static bool3x3 op_GreaterThanOrEqual(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A43CB0", Offset = "0x2A430B0", Length = "0x47")]
	[Token(Token = "0x6002163")]
	public static uint3x3 op_Implicit(uint v) { }

	[Address(RVA = "0x2A848F0", Offset = "0x2A83CF0", Length = "0xE4")]
	[Token(Token = "0x600217B")]
	public static uint3x3 op_Increment(uint3x3 val) { }

	[Address(RVA = "0x2A84C40", Offset = "0x2A84040", Length = "0xD1")]
	[Token(Token = "0x6002192")]
	public static bool3x3 op_Inequality(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A84B60", Offset = "0x2A83F60", Length = "0xD2")]
	[Token(Token = "0x6002191")]
	public static bool3x3 op_Inequality(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A849E0", Offset = "0x2A83DE0", Length = "0x178")]
	[Token(Token = "0x6002190")]
	public static bool3x3 op_Inequality(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A84D20", Offset = "0x2A84120", Length = "0xD3")]
	[Token(Token = "0x600218B")]
	public static uint3x3 op_LeftShift(uint3x3 x, int n) { }

	[Address(RVA = "0x2A85140", Offset = "0x2A84540", Length = "0x178")]
	[Token(Token = "0x600217D")]
	public static bool3x3 op_LessThan(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A852C0", Offset = "0x2A846C0", Length = "0xD1")]
	[Token(Token = "0x600217F")]
	public static bool3x3 op_LessThan(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A853A0", Offset = "0x2A847A0", Length = "0xD2")]
	[Token(Token = "0x600217E")]
	public static bool3x3 op_LessThan(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A84E00", Offset = "0x2A84200", Length = "0xD2")]
	[Token(Token = "0x6002181")]
	public static bool3x3 op_LessThanOrEqual(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A84EE0", Offset = "0x2A842E0", Length = "0xD1")]
	[Token(Token = "0x6002182")]
	public static bool3x3 op_LessThanOrEqual(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A84FC0", Offset = "0x2A843C0", Length = "0x178")]
	[Token(Token = "0x6002180")]
	public static bool3x3 op_LessThanOrEqual(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A85580", Offset = "0x2A84980", Length = "0x188")]
	[Token(Token = "0x6002178")]
	public static uint3x3 op_Modulus(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A85480", Offset = "0x2A84880", Length = "0xFD")]
	[Token(Token = "0x600217A")]
	public static uint3x3 op_Modulus(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A85710", Offset = "0x2A84B10", Length = "0xF0")]
	[Token(Token = "0x6002179")]
	public static uint3x3 op_Modulus(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A85800", Offset = "0x2A84C00", Length = "0xDE")]
	[Token(Token = "0x600216E")]
	public static uint3x3 op_Multiply(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A85A60", Offset = "0x2A84E60", Length = "0xE0")]
	[Token(Token = "0x600216D")]
	public static uint3x3 op_Multiply(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A858E0", Offset = "0x2A84CE0", Length = "0x174")]
	[Token(Token = "0x600216C")]
	public static uint3x3 op_Multiply(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A85B40", Offset = "0x2A84F40", Length = "0xC2")]
	[Token(Token = "0x6002193")]
	public static uint3x3 op_OnesComplement(uint3x3 val) { }

	[Address(RVA = "0x2A85C10", Offset = "0x2A85010", Length = "0xD7")]
	[Token(Token = "0x600218C")]
	public static uint3x3 op_RightShift(uint3x3 x, int n) { }

	[Address(RVA = "0x2A85F20", Offset = "0x2A85320", Length = "0xD3")]
	[Token(Token = "0x6002174")]
	public static uint3x3 op_Subtraction(uint lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A85E50", Offset = "0x2A85250", Length = "0xCD")]
	[Token(Token = "0x6002173")]
	public static uint3x3 op_Subtraction(uint3x3 lhs, uint rhs) { }

	[Address(RVA = "0x2A85CF0", Offset = "0x2A850F0", Length = "0x15F")]
	[Token(Token = "0x6002172")]
	public static uint3x3 op_Subtraction(uint3x3 lhs, uint3x3 rhs) { }

	[Address(RVA = "0x2A86000", Offset = "0x2A85400", Length = "0xCC")]
	[Token(Token = "0x6002189")]
	public static uint3x3 op_UnaryNegation(uint3x3 val) { }

	[Address(RVA = "0x2A860D0", Offset = "0x2A854D0", Length = "0xB6")]
	[Token(Token = "0x600218A")]
	public static uint3x3 op_UnaryPlus(uint3x3 val) { }

	[Address(RVA = "0x2A82270", Offset = "0x2A81670", Length = "0x3E6")]
	[Token(Token = "0x60021A1")]
	public virtual string ToString() { }

	[Address(RVA = "0x2A82660", Offset = "0x2A81A60", Length = "0x3DA")]
	[Token(Token = "0x60021A2")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

