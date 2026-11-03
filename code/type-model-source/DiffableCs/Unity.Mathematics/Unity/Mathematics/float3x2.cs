namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200002F")]
public struct float3x2 : IEquatable<float3x2>, IFormattable
{
	[Token(Token = "0x40000C1")]
	public static readonly float3x2 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000BF")]
	public float3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000C0")]
	public float3 c1; //Field offset: 0xC

	[Token(Token = "0x17000471")]
	public float3 Item
	{
		[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
		[Token(Token = "0x6001290")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x665C80", Offset = "0x665080", Length = "0x20")]
	[Token(Token = "0x6001257")]
	public float3x2(float3 c0, float3 c1) { }

	[Address(RVA = "0x2AD31D0", Offset = "0x2AD25D0", Length = "0x47")]
	[Token(Token = "0x6001260")]
	public float3x2(double v) { }

	[Address(RVA = "0x2AD32B0", Offset = "0x2AD26B0", Length = "0xB1")]
	[Token(Token = "0x600125F")]
	public float3x2(uint3x2 v) { }

	[Address(RVA = "0x2AD3100", Offset = "0x2AD2500", Length = "0x6E")]
	[Token(Token = "0x600125E")]
	public float3x2(uint v) { }

	[Address(RVA = "0x2AD3370", Offset = "0x2AD2770", Length = "0x82")]
	[Token(Token = "0x600125D")]
	public float3x2(int3x2 v) { }

	[Address(RVA = "0x2AD3070", Offset = "0x2AD2470", Length = "0x5F")]
	[Token(Token = "0x6001261")]
	public float3x2(double3x2 v) { }

	[Address(RVA = "0x2AD3220", Offset = "0x2AD2620", Length = "0x88")]
	[Token(Token = "0x600125B")]
	public float3x2(bool3x2 v) { }

	[Address(RVA = "0x2AD3170", Offset = "0x2AD2570", Length = "0x53")]
	[Token(Token = "0x600125A")]
	public float3x2(bool v) { }

	[Address(RVA = "0x2AD3050", Offset = "0x2AD2450", Length = "0x20")]
	[Token(Token = "0x6001259")]
	public float3x2(float v) { }

	[Address(RVA = "0x2AD30D0", Offset = "0x2AD24D0", Length = "0x2F")]
	[Token(Token = "0x6001258")]
	public float3x2(float m00, float m01, float m10, float m11, float m20, float m21) { }

	[Address(RVA = "0x2AD3000", Offset = "0x2AD2400", Length = "0x44")]
	[Token(Token = "0x600125C")]
	public float3x2(int v) { }

	[Address(RVA = "0x2AD28D0", Offset = "0x2AD1CD0", Length = "0xF6")]
	[Token(Token = "0x6001292")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2A97A20", Offset = "0x2A96E20", Length = "0x75")]
	[Token(Token = "0x6001291")]
	public override bool Equals(float3x2 rhs) { }

	[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
	[Token(Token = "0x6001290")]
	public float3 get_Item(int index) { }

	[Address(RVA = "0x2AD29D0", Offset = "0x2AD1DD0", Length = "0x7E")]
	[Token(Token = "0x6001293")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AD3510", Offset = "0x2AD2910", Length = "0x71")]
	[Token(Token = "0x600126F")]
	public static float3x2 op_Addition(float3x2 lhs, float rhs) { }

	[Address(RVA = "0x2AD3400", Offset = "0x2AD2800", Length = "0x74")]
	[Token(Token = "0x6001270")]
	public static float3x2 op_Addition(float lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD3480", Offset = "0x2AD2880", Length = "0x8D")]
	[Token(Token = "0x600126E")]
	public static float3x2 op_Addition(float3x2 lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD3590", Offset = "0x2AD2990", Length = "0x6B")]
	[Token(Token = "0x600127B")]
	public static float3x2 op_Decrement(float3x2 val) { }

	[Address(RVA = "0x2AD3600", Offset = "0x2AD2A00", Length = "0x71")]
	[Token(Token = "0x6001275")]
	public static float3x2 op_Division(float3x2 lhs, float rhs) { }

	[Address(RVA = "0x2AD3680", Offset = "0x2AD2A80", Length = "0x8B")]
	[Token(Token = "0x6001274")]
	public static float3x2 op_Division(float3x2 lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD3710", Offset = "0x2AD2B10", Length = "0x80")]
	[Token(Token = "0x6001276")]
	public static float3x2 op_Division(float lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD3790", Offset = "0x2AD2B90", Length = "0xBD")]
	[Token(Token = "0x600128B")]
	public static bool3x2 op_Equality(float3x2 lhs, float rhs) { }

	[Address(RVA = "0x2AD3900", Offset = "0x2AD2D00", Length = "0xE3")]
	[Token(Token = "0x600128A")]
	public static bool3x2 op_Equality(float3x2 lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD3850", Offset = "0x2AD2C50", Length = "0xAA")]
	[Token(Token = "0x600128C")]
	public static bool3x2 op_Equality(float lhs, float3x2 rhs) { }

	[Address(RVA = "0x2A35BE0", Offset = "0x2A34FE0", Length = "0x4A")]
	[Token(Token = "0x6001269")]
	public static float3x2 op_Explicit(double v) { }

	[Address(RVA = "0x2A35B30", Offset = "0x2A34F30", Length = "0x59")]
	[Token(Token = "0x6001263")]
	public static float3x2 op_Explicit(bool v) { }

	[Address(RVA = "0x2A35DC0", Offset = "0x2A351C0", Length = "0x90")]
	[Token(Token = "0x6001264")]
	public static float3x2 op_Explicit(bool3x2 v) { }

	[Address(RVA = "0x2A35A10", Offset = "0x2A34E10", Length = "0x5E")]
	[Token(Token = "0x600126A")]
	public static float3x2 op_Explicit(double3x2 v) { }

	[Address(RVA = "0x2AD3B90", Offset = "0x2AD2F90", Length = "0x78")]
	[Token(Token = "0x6001283")]
	public static bool3x2 op_GreaterThan(float3x2 lhs, float rhs) { }

	[Address(RVA = "0x2AD3CB0", Offset = "0x2AD30B0", Length = "0x76")]
	[Token(Token = "0x6001284")]
	public static bool3x2 op_GreaterThan(float lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD3C10", Offset = "0x2AD3010", Length = "0x97")]
	[Token(Token = "0x6001282")]
	public static bool3x2 op_GreaterThan(float3x2 lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD39F0", Offset = "0x2AD2DF0", Length = "0x78")]
	[Token(Token = "0x6001286")]
	public static bool3x2 op_GreaterThanOrEqual(float3x2 lhs, float rhs) { }

	[Address(RVA = "0x2AD3AF0", Offset = "0x2AD2EF0", Length = "0x97")]
	[Token(Token = "0x6001285")]
	public static bool3x2 op_GreaterThanOrEqual(float3x2 lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD3A70", Offset = "0x2AD2E70", Length = "0x76")]
	[Token(Token = "0x6001287")]
	public static bool3x2 op_GreaterThanOrEqual(float lhs, float3x2 rhs) { }

	[Address(RVA = "0x2A35D40", Offset = "0x2A35140", Length = "0x71")]
	[Token(Token = "0x6001267")]
	public static float3x2 op_Implicit(uint v) { }

	[Address(RVA = "0x2A35C30", Offset = "0x2A35030", Length = "0x91")]
	[Token(Token = "0x6001266")]
	public static float3x2 op_Implicit(int3x2 v) { }

	[Address(RVA = "0x2A35E50", Offset = "0x2A35250", Length = "0x23")]
	[Token(Token = "0x6001262")]
	public static float3x2 op_Implicit(float v) { }

	[Address(RVA = "0x2A35A70", Offset = "0x2A34E70", Length = "0xBB")]
	[Token(Token = "0x6001268")]
	public static float3x2 op_Implicit(uint3x2 v) { }

	[Address(RVA = "0x2A35B90", Offset = "0x2A34F90", Length = "0x47")]
	[Token(Token = "0x6001265")]
	public static float3x2 op_Implicit(int v) { }

	[Address(RVA = "0x2AD3D30", Offset = "0x2AD3130", Length = "0x6B")]
	[Token(Token = "0x600127A")]
	public static float3x2 op_Increment(float3x2 val) { }

	[Address(RVA = "0x2AD3DA0", Offset = "0x2AD31A0", Length = "0xBD")]
	[Token(Token = "0x600128E")]
	public static bool3x2 op_Inequality(float3x2 lhs, float rhs) { }

	[Address(RVA = "0x2AD3F10", Offset = "0x2AD3310", Length = "0xE3")]
	[Token(Token = "0x600128D")]
	public static bool3x2 op_Inequality(float3x2 lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD3E60", Offset = "0x2AD3260", Length = "0xAA")]
	[Token(Token = "0x600128F")]
	public static bool3x2 op_Inequality(float lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD4210", Offset = "0x2AD3610", Length = "0x97")]
	[Token(Token = "0x600127C")]
	public static bool3x2 op_LessThan(float3x2 lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD4190", Offset = "0x2AD3590", Length = "0x7E")]
	[Token(Token = "0x600127E")]
	public static bool3x2 op_LessThan(float lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD42B0", Offset = "0x2AD36B0", Length = "0x70")]
	[Token(Token = "0x600127D")]
	public static bool3x2 op_LessThan(float3x2 lhs, float rhs) { }

	[Address(RVA = "0x2AD40F0", Offset = "0x2AD34F0", Length = "0x97")]
	[Token(Token = "0x600127F")]
	public static bool3x2 op_LessThanOrEqual(float3x2 lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD4080", Offset = "0x2AD3480", Length = "0x70")]
	[Token(Token = "0x6001280")]
	public static bool3x2 op_LessThanOrEqual(float3x2 lhs, float rhs) { }

	[Address(RVA = "0x2AD4000", Offset = "0x2AD3400", Length = "0x7E")]
	[Token(Token = "0x6001281")]
	public static bool3x2 op_LessThanOrEqual(float lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD4430", Offset = "0x2AD3830", Length = "0xEE")]
	[Token(Token = "0x6001279")]
	public static float3x2 op_Modulus(float lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD4520", Offset = "0x2AD3920", Length = "0xEC")]
	[Token(Token = "0x6001278")]
	public static float3x2 op_Modulus(float3x2 lhs, float rhs) { }

	[Address(RVA = "0x2AD4320", Offset = "0x2AD3720", Length = "0x102")]
	[Token(Token = "0x6001277")]
	public static float3x2 op_Modulus(float3x2 lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD46A0", Offset = "0x2AD3AA0", Length = "0x74")]
	[Token(Token = "0x600126D")]
	public static float3x2 op_Multiply(float lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD4720", Offset = "0x2AD3B20", Length = "0x71")]
	[Token(Token = "0x600126C")]
	public static float3x2 op_Multiply(float3x2 lhs, float rhs) { }

	[Address(RVA = "0x2AD4610", Offset = "0x2AD3A10", Length = "0x8D")]
	[Token(Token = "0x600126B")]
	public static float3x2 op_Multiply(float3x2 lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD48B0", Offset = "0x2AD3CB0", Length = "0x80")]
	[Token(Token = "0x6001273")]
	public static float3x2 op_Subtraction(float lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD4830", Offset = "0x2AD3C30", Length = "0x71")]
	[Token(Token = "0x6001272")]
	public static float3x2 op_Subtraction(float3x2 lhs, float rhs) { }

	[Address(RVA = "0x2AD47A0", Offset = "0x2AD3BA0", Length = "0x8B")]
	[Token(Token = "0x6001271")]
	public static float3x2 op_Subtraction(float3x2 lhs, float3x2 rhs) { }

	[Address(RVA = "0x2AD4930", Offset = "0x2AD3D30", Length = "0x70")]
	[Token(Token = "0x6001288")]
	public static float3x2 op_UnaryNegation(float3x2 val) { }

	[Address(RVA = "0x2AD49A0", Offset = "0x2AD3DA0", Length = "0x49")]
	[Token(Token = "0x6001289")]
	public static float3x2 op_UnaryPlus(float3x2 val) { }

	[Address(RVA = "0x2AD2D20", Offset = "0x2AD2120", Length = "0x2D8")]
	[Token(Token = "0x6001294")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AD2A50", Offset = "0x2AD1E50", Length = "0x2C6")]
	[Token(Token = "0x6001295")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

