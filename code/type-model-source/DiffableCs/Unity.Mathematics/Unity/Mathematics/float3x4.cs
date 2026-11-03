namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000031")]
public struct float3x4 : IEquatable<float3x4>, IFormattable
{
	[Token(Token = "0x40000CB")]
	public static readonly float3x4 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C7")]
	public float3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000C8")]
	public float3 c1; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C9")]
	public float3 c2; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40000CA")]
	public float3 c3; //Field offset: 0x24

	[Token(Token = "0x17000473")]
	public float3 Item
	{
		[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
		[Token(Token = "0x6001329")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x2A86E40", Offset = "0x2A86240", Length = "0x45")]
	[Token(Token = "0x60012F0")]
	public float3x4(float3 c0, float3 c1, float3 c2, float3 c3) { }

	[Address(RVA = "0x2AD9B70", Offset = "0x2AD8F70", Length = "0x8B")]
	[Token(Token = "0x60012F9")]
	public float3x4(double v) { }

	[Address(RVA = "0x2A19540", Offset = "0x2A18940", Length = "0x167")]
	[Token(Token = "0x60012F8")]
	public float3x4(uint3x4 v) { }

	[Address(RVA = "0x2A196B0", Offset = "0x2A18AB0", Length = "0xDC")]
	[Token(Token = "0x60012F7")]
	public float3x4(uint v) { }

	[Address(RVA = "0x2A19390", Offset = "0x2A18790", Length = "0x108")]
	[Token(Token = "0x60012F6")]
	public float3x4(int3x4 v) { }

	[Address(RVA = "0x2AD9AB0", Offset = "0x2AD8EB0", Length = "0xB7")]
	[Token(Token = "0x60012FA")]
	public float3x4(double3x4 v) { }

	[Address(RVA = "0x2A19790", Offset = "0x2A18B90", Length = "0x114")]
	[Token(Token = "0x60012F4")]
	public float3x4(bool3x4 v) { }

	[Address(RVA = "0x2A194A0", Offset = "0x2A188A0", Length = "0x93")]
	[Token(Token = "0x60012F3")]
	public float3x4(bool v) { }

	[Address(RVA = "0x2AD9A70", Offset = "0x2AD8E70", Length = "0x40")]
	[Token(Token = "0x60012F2")]
	public float3x4(float v) { }

	[Address(RVA = "0x2AD9C90", Offset = "0x2AD9090", Length = "0x80")]
	[Token(Token = "0x60012F1")]
	public float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23) { }

	[Address(RVA = "0x2AD9C00", Offset = "0x2AD9000", Length = "0x88")]
	[Token(Token = "0x60012F5")]
	public float3x4(int v) { }

	[Address(RVA = "0x2AD8F60", Offset = "0x2AD8360", Length = "0xA2")]
	[Token(Token = "0x600132B")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2ACA3E0", Offset = "0x2AC97E0", Length = "0xB30")]
	[Token(Token = "0x600132A")]
	public override bool Equals(float3x4 rhs) { }

	[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
	[Token(Token = "0x6001329")]
	public float3 get_Item(int index) { }

	[Address(RVA = "0x2AD9010", Offset = "0x2AD8410", Length = "0x2F")]
	[Token(Token = "0x600132C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AD9E80", Offset = "0x2AD9280", Length = "0x12C")]
	[Token(Token = "0x6001308")]
	public static float3x4 op_Addition(float3x4 lhs, float rhs) { }

	[Address(RVA = "0x2AD9FB0", Offset = "0x2AD93B0", Length = "0x128")]
	[Token(Token = "0x6001309")]
	public static float3x4 op_Addition(float lhs, float3x4 rhs) { }

	[Address(RVA = "0x2AD9D10", Offset = "0x2AD9110", Length = "0x16A")]
	[Token(Token = "0x6001307")]
	public static float3x4 op_Addition(float3x4 lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADA0E0", Offset = "0x2AD94E0", Length = "0x14A")]
	[Token(Token = "0x6001314")]
	public static float3x4 op_Decrement(float3x4 val) { }

	[Address(RVA = "0x2ADA4F0", Offset = "0x2AD98F0", Length = "0x12C")]
	[Token(Token = "0x600130E")]
	public static float3x4 op_Division(float3x4 lhs, float rhs) { }

	[Address(RVA = "0x2ADA380", Offset = "0x2AD9780", Length = "0x169")]
	[Token(Token = "0x600130D")]
	public static float3x4 op_Division(float3x4 lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADA230", Offset = "0x2AD9630", Length = "0x14B")]
	[Token(Token = "0x600130F")]
	public static float3x4 op_Division(float lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADA940", Offset = "0x2AD9D40", Length = "0x187")]
	[Token(Token = "0x6001324")]
	public static bool3x4 op_Equality(float3x4 lhs, float rhs) { }

	[Address(RVA = "0x2ADA620", Offset = "0x2AD9A20", Length = "0x1BE")]
	[Token(Token = "0x6001323")]
	public static bool3x4 op_Equality(float3x4 lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADA7E0", Offset = "0x2AD9BE0", Length = "0x15B")]
	[Token(Token = "0x6001325")]
	public static bool3x4 op_Equality(float lhs, float3x4 rhs) { }

	[Address(RVA = "0x2A36550", Offset = "0x2A35950", Length = "0x8E")]
	[Token(Token = "0x6001302")]
	public static float3x4 op_Explicit(double v) { }

	[Address(RVA = "0x2ADAB10", Offset = "0x2AD9F10", Length = "0x28")]
	[Token(Token = "0x60012FC")]
	public static float3x4 op_Explicit(bool v) { }

	[Address(RVA = "0x2ADAAD0", Offset = "0x2AD9ED0", Length = "0x3E")]
	[Token(Token = "0x60012FD")]
	public static float3x4 op_Explicit(bool3x4 v) { }

	[Address(RVA = "0x2A36A00", Offset = "0x2A35E00", Length = "0xBB")]
	[Token(Token = "0x6001303")]
	public static float3x4 op_Explicit(double3x4 v) { }

	[Address(RVA = "0x2ADAF70", Offset = "0x2ADA370", Length = "0xE6")]
	[Token(Token = "0x600131C")]
	public static bool3x4 op_GreaterThan(float3x4 lhs, float rhs) { }

	[Address(RVA = "0x2ADB060", Offset = "0x2ADA460", Length = "0xD7")]
	[Token(Token = "0x600131D")]
	public static bool3x4 op_GreaterThan(float lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADAE40", Offset = "0x2ADA240", Length = "0x128")]
	[Token(Token = "0x600131B")]
	public static bool3x4 op_GreaterThan(float3x4 lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADAB40", Offset = "0x2AD9F40", Length = "0xE6")]
	[Token(Token = "0x600131F")]
	public static bool3x4 op_GreaterThanOrEqual(float3x4 lhs, float rhs) { }

	[Address(RVA = "0x2ADAD10", Offset = "0x2ADA110", Length = "0x128")]
	[Token(Token = "0x600131E")]
	public static bool3x4 op_GreaterThanOrEqual(float3x4 lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADAC30", Offset = "0x2ADA030", Length = "0xD7")]
	[Token(Token = "0x6001320")]
	public static bool3x4 op_GreaterThanOrEqual(float lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADB190", Offset = "0x2ADA590", Length = "0x28")]
	[Token(Token = "0x6001300")]
	public static float3x4 op_Implicit(uint v) { }

	[Address(RVA = "0x2ADB1C0", Offset = "0x2ADA5C0", Length = "0x47")]
	[Token(Token = "0x60012FF")]
	public static float3x4 op_Implicit(int3x4 v) { }

	[Address(RVA = "0x2A369B0", Offset = "0x2A35DB0", Length = "0x43")]
	[Token(Token = "0x60012FB")]
	public static float3x4 op_Implicit(float v) { }

	[Address(RVA = "0x2ADB140", Offset = "0x2ADA540", Length = "0x47")]
	[Token(Token = "0x6001301")]
	public static float3x4 op_Implicit(uint3x4 v) { }

	[Address(RVA = "0x2A36820", Offset = "0x2A35C20", Length = "0x8B")]
	[Token(Token = "0x60012FE")]
	public static float3x4 op_Implicit(int v) { }

	[Address(RVA = "0x2ADB210", Offset = "0x2ADA610", Length = "0x14A")]
	[Token(Token = "0x6001313")]
	public static float3x4 op_Increment(float3x4 val) { }

	[Address(RVA = "0x2ADB360", Offset = "0x2ADA760", Length = "0x187")]
	[Token(Token = "0x6001327")]
	public static bool3x4 op_Inequality(float3x4 lhs, float rhs) { }

	[Address(RVA = "0x2ADB650", Offset = "0x2ADAA50", Length = "0x1BE")]
	[Token(Token = "0x6001326")]
	public static bool3x4 op_Inequality(float3x4 lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADB4F0", Offset = "0x2ADA8F0", Length = "0x15B")]
	[Token(Token = "0x6001328")]
	public static bool3x4 op_Inequality(float lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADBCE0", Offset = "0x2ADB0E0", Length = "0x12C")]
	[Token(Token = "0x6001315")]
	public static bool3x4 op_LessThan(float3x4 lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADBBF0", Offset = "0x2ADAFF0", Length = "0xE7")]
	[Token(Token = "0x6001317")]
	public static bool3x4 op_LessThan(float lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADBB10", Offset = "0x2ADAF10", Length = "0xDA")]
	[Token(Token = "0x6001316")]
	public static bool3x4 op_LessThan(float3x4 lhs, float rhs) { }

	[Address(RVA = "0x2ADB8F0", Offset = "0x2ADACF0", Length = "0x12C")]
	[Token(Token = "0x6001318")]
	public static bool3x4 op_LessThanOrEqual(float3x4 lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADB810", Offset = "0x2ADAC10", Length = "0xDA")]
	[Token(Token = "0x6001319")]
	public static bool3x4 op_LessThanOrEqual(float3x4 lhs, float rhs) { }

	[Address(RVA = "0x2ADBA20", Offset = "0x2ADAE20", Length = "0xE7")]
	[Token(Token = "0x600131A")]
	public static bool3x4 op_LessThanOrEqual(float lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADC1C0", Offset = "0x2ADB5C0", Length = "0x1D2")]
	[Token(Token = "0x6001312")]
	public static float3x4 op_Modulus(float lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADBFF0", Offset = "0x2ADB3F0", Length = "0x1CA")]
	[Token(Token = "0x6001311")]
	public static float3x4 op_Modulus(float3x4 lhs, float rhs) { }

	[Address(RVA = "0x2ADBE10", Offset = "0x2ADB210", Length = "0x1DA")]
	[Token(Token = "0x6001310")]
	public static float3x4 op_Modulus(float3x4 lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADC640", Offset = "0x2ADBA40", Length = "0x128")]
	[Token(Token = "0x6001306")]
	public static float3x4 op_Multiply(float lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADC3A0", Offset = "0x2ADB7A0", Length = "0x12C")]
	[Token(Token = "0x6001305")]
	public static float3x4 op_Multiply(float3x4 lhs, float rhs) { }

	[Address(RVA = "0x2ADC4D0", Offset = "0x2ADB8D0", Length = "0x16A")]
	[Token(Token = "0x6001304")]
	public static float3x4 op_Multiply(float3x4 lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADC770", Offset = "0x2ADBB70", Length = "0x14B")]
	[Token(Token = "0x600130C")]
	public static float3x4 op_Subtraction(float lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADC8C0", Offset = "0x2ADBCC0", Length = "0x12C")]
	[Token(Token = "0x600130B")]
	public static float3x4 op_Subtraction(float3x4 lhs, float rhs) { }

	[Address(RVA = "0x2ADC9F0", Offset = "0x2ADBDF0", Length = "0x169")]
	[Token(Token = "0x600130A")]
	public static float3x4 op_Subtraction(float3x4 lhs, float3x4 rhs) { }

	[Address(RVA = "0x2ADCB60", Offset = "0x2ADBF60", Length = "0x125")]
	[Token(Token = "0x6001321")]
	public static float3x4 op_UnaryNegation(float3x4 val) { }

	[Address(RVA = "0x2ADCC90", Offset = "0x2ADC090", Length = "0xDF4")]
	[Token(Token = "0x6001322")]
	public static float3x4 op_UnaryPlus(float3x4 val) { }

	[Address(RVA = "0x2AD9530", Offset = "0x2AD8930", Length = "0x530")]
	[Token(Token = "0x600132D")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AD9040", Offset = "0x2AD8440", Length = "0x4EE")]
	[Token(Token = "0x600132E")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

