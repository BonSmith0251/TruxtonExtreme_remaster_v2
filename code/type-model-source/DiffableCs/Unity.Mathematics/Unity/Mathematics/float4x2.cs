namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000034")]
public struct float4x2 : IEquatable<float4x2>, IFormattable
{
	[Token(Token = "0x40000D7")]
	public static readonly float4x2 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D5")]
	public float4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D6")]
	public float4 c1; //Field offset: 0x10

	[Token(Token = "0x170005C5")]
	public float4 Item
	{
		[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
		[Token(Token = "0x6001541")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x648E10", Offset = "0x648210", Length = "0xF")]
	[Token(Token = "0x6001508")]
	public float4x2(float4 c0, float4 c1) { }

	[Address(RVA = "0x2AE1DC0", Offset = "0x2AE11C0", Length = "0x83")]
	[Token(Token = "0x6001511")]
	public float4x2(double v) { }

	[Address(RVA = "0x2AE1CC0", Offset = "0x2AE10C0", Length = "0xD7")]
	[Token(Token = "0x6001510")]
	public float4x2(uint4x2 v) { }

	[Address(RVA = "0x2A19C80", Offset = "0x2A19080", Length = "0xB8")]
	[Token(Token = "0x600150F")]
	public float4x2(uint v) { }

	[Address(RVA = "0x2AE1E50", Offset = "0x2AE1250", Length = "0xA2")]
	[Token(Token = "0x600150E")]
	public float4x2(int4x2 v) { }

	[Address(RVA = "0x2AE1F20", Offset = "0x2AE1320", Length = "0x9F")]
	[Token(Token = "0x6001512")]
	public float4x2(double4x2 v) { }

	[Address(RVA = "0x2A19BB0", Offset = "0x2A18FB0", Length = "0xCB")]
	[Token(Token = "0x600150C")]
	public float4x2(bool4x2 v) { }

	[Address(RVA = "0x2AE2030", Offset = "0x2AE1430", Length = "0x22")]
	[Token(Token = "0x600150B")]
	public float4x2(bool v) { }

	[Address(RVA = "0x2AE1F00", Offset = "0x2AE1300", Length = "0x1F")]
	[Token(Token = "0x600150A")]
	public float4x2(float v) { }

	[Address(RVA = "0x2AE1FC0", Offset = "0x2AE13C0", Length = "0x69")]
	[Token(Token = "0x6001509")]
	public float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31) { }

	[Address(RVA = "0x2AE1DA0", Offset = "0x2AE11A0", Length = "0x20")]
	[Token(Token = "0x600150D")]
	public float4x2(int v) { }

	[Address(RVA = "0x2AE13D0", Offset = "0x2AE07D0", Length = "0x118")]
	[Token(Token = "0x6001543")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AE1320", Offset = "0x2AE0720", Length = "0xA4")]
	[Token(Token = "0x6001542")]
	public override bool Equals(float4x2 rhs) { }

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x6001541")]
	public float4 get_Item(int index) { }

	[Address(RVA = "0x2AE14F0", Offset = "0x2AE08F0", Length = "0x99")]
	[Token(Token = "0x6001544")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AE2060", Offset = "0x2AE1460", Length = "0xC9")]
	[Token(Token = "0x6001520")]
	public static float4x2 op_Addition(float4x2 lhs, float rhs) { }

	[Address(RVA = "0x2AE2130", Offset = "0x2AE1530", Length = "0xCB")]
	[Token(Token = "0x6001521")]
	public static float4x2 op_Addition(float lhs, float4x2 rhs) { }

	[Address(RVA = "0x648E20", Offset = "0x648220", Length = "0x105")]
	[Token(Token = "0x600151F")]
	public static float4x2 op_Addition(float4x2 lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE2200", Offset = "0x2AE1600", Length = "0xA7")]
	[Token(Token = "0x600152C")]
	public static float4x2 op_Decrement(float4x2 val) { }

	[Address(RVA = "0x2AE24D0", Offset = "0x2AE18D0", Length = "0xC9")]
	[Token(Token = "0x6001526")]
	public static float4x2 op_Division(float4x2 lhs, float rhs) { }

	[Address(RVA = "0x2AE23C0", Offset = "0x2AE17C0", Length = "0x106")]
	[Token(Token = "0x6001525")]
	public static float4x2 op_Division(float4x2 lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE22B0", Offset = "0x2AE16B0", Length = "0x101")]
	[Token(Token = "0x6001527")]
	public static float4x2 op_Division(float lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE26C0", Offset = "0x2AE1AC0", Length = "0x119")]
	[Token(Token = "0x600153C")]
	public static bool4x2 op_Equality(float4x2 lhs, float rhs) { }

	[Address(RVA = "0x2AE27E0", Offset = "0x2AE1BE0", Length = "0x14E")]
	[Token(Token = "0x600153B")]
	public static bool4x2 op_Equality(float4x2 lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE25A0", Offset = "0x2AE19A0", Length = "0x11C")]
	[Token(Token = "0x600153D")]
	public static bool4x2 op_Equality(float lhs, float4x2 rhs) { }

	[Address(RVA = "0x2A37410", Offset = "0x2A36810", Length = "0x86")]
	[Token(Token = "0x600151A")]
	public static float4x2 op_Explicit(double v) { }

	[Address(RVA = "0x2A37870", Offset = "0x2A36C70", Length = "0x25")]
	[Token(Token = "0x6001514")]
	public static float4x2 op_Explicit(bool v) { }

	[Address(RVA = "0x2AE2930", Offset = "0x2AE1D30", Length = "0x24")]
	[Token(Token = "0x6001515")]
	public static float4x2 op_Explicit(bool4x2 v) { }

	[Address(RVA = "0x2A375B0", Offset = "0x2A369B0", Length = "0xA2")]
	[Token(Token = "0x600151B")]
	public static float4x2 op_Explicit(double4x2 v) { }

	[Address(RVA = "0x2AE2DB0", Offset = "0x2AE21B0", Length = "0xC4")]
	[Token(Token = "0x6001534")]
	public static bool4x2 op_GreaterThan(float4x2 lhs, float rhs) { }

	[Address(RVA = "0x2AE2BF0", Offset = "0x2AE1FF0", Length = "0xC4")]
	[Token(Token = "0x6001535")]
	public static bool4x2 op_GreaterThan(float lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE2CC0", Offset = "0x2AE20C0", Length = "0xEF")]
	[Token(Token = "0x6001533")]
	public static bool4x2 op_GreaterThan(float4x2 lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE2A30", Offset = "0x2AE1E30", Length = "0xC4")]
	[Token(Token = "0x6001537")]
	public static bool4x2 op_GreaterThanOrEqual(float4x2 lhs, float rhs) { }

	[Address(RVA = "0x2AE2B00", Offset = "0x2AE1F00", Length = "0xEF")]
	[Token(Token = "0x6001536")]
	public static bool4x2 op_GreaterThanOrEqual(float4x2 lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE2960", Offset = "0x2AE1D60", Length = "0xC4")]
	[Token(Token = "0x6001538")]
	public static bool4x2 op_GreaterThanOrEqual(float lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE2E80", Offset = "0x2AE2280", Length = "0x24")]
	[Token(Token = "0x6001518")]
	public static float4x2 op_Implicit(uint v) { }

	[Address(RVA = "0x2A37660", Offset = "0x2A36A60", Length = "0xA2")]
	[Token(Token = "0x6001517")]
	public static float4x2 op_Implicit(int4x2 v) { }

	[Address(RVA = "0x2A37580", Offset = "0x2A36980", Length = "0x22")]
	[Token(Token = "0x6001513")]
	public static float4x2 op_Implicit(float v) { }

	[Address(RVA = "0x2A374A0", Offset = "0x2A368A0", Length = "0xD8")]
	[Token(Token = "0x6001519")]
	public static float4x2 op_Implicit(uint4x2 v) { }

	[Address(RVA = "0x2A37780", Offset = "0x2A36B80", Length = "0x23")]
	[Token(Token = "0x6001516")]
	public static float4x2 op_Implicit(int v) { }

	[Address(RVA = "0x2AE2EB0", Offset = "0x2AE22B0", Length = "0xA7")]
	[Token(Token = "0x600152B")]
	public static float4x2 op_Increment(float4x2 val) { }

	[Address(RVA = "0x2AE2F60", Offset = "0x2AE2360", Length = "0x119")]
	[Token(Token = "0x600153F")]
	public static bool4x2 op_Inequality(float4x2 lhs, float rhs) { }

	[Address(RVA = "0x2AE31A0", Offset = "0x2AE25A0", Length = "0x14E")]
	[Token(Token = "0x600153E")]
	public static bool4x2 op_Inequality(float4x2 lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE3080", Offset = "0x2AE2480", Length = "0x11C")]
	[Token(Token = "0x6001540")]
	public static bool4x2 op_Inequality(float lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE3580", Offset = "0x2AE2980", Length = "0xEF")]
	[Token(Token = "0x600152D")]
	public static bool4x2 op_LessThan(float4x2 lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE3740", Offset = "0x2AE2B40", Length = "0xC4")]
	[Token(Token = "0x600152F")]
	public static bool4x2 op_LessThan(float lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE3670", Offset = "0x2AE2A70", Length = "0xC4")]
	[Token(Token = "0x600152E")]
	public static bool4x2 op_LessThan(float4x2 lhs, float rhs) { }

	[Address(RVA = "0x2AE33C0", Offset = "0x2AE27C0", Length = "0xEF")]
	[Token(Token = "0x6001530")]
	public static bool4x2 op_LessThanOrEqual(float4x2 lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE34B0", Offset = "0x2AE28B0", Length = "0xC4")]
	[Token(Token = "0x6001531")]
	public static bool4x2 op_LessThanOrEqual(float4x2 lhs, float rhs) { }

	[Address(RVA = "0x2AE32F0", Offset = "0x2AE26F0", Length = "0xC4")]
	[Token(Token = "0x6001532")]
	public static bool4x2 op_LessThanOrEqual(float lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE3B20", Offset = "0x2AE2F20", Length = "0x172")]
	[Token(Token = "0x600152A")]
	public static float4x2 op_Modulus(float lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE3810", Offset = "0x2AE2C10", Length = "0x170")]
	[Token(Token = "0x6001529")]
	public static float4x2 op_Modulus(float4x2 lhs, float rhs) { }

	[Address(RVA = "0x2AE3980", Offset = "0x2AE2D80", Length = "0x191")]
	[Token(Token = "0x6001528")]
	public static float4x2 op_Modulus(float4x2 lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE3DB0", Offset = "0x2AE31B0", Length = "0xCB")]
	[Token(Token = "0x600151E")]
	public static float4x2 op_Multiply(float lhs, float4x2 rhs) { }

	[Address(RVA = "0x648F30", Offset = "0x648330", Length = "0xC9")]
	[Token(Token = "0x600151D")]
	public static float4x2 op_Multiply(float4x2 lhs, float rhs) { }

	[Address(RVA = "0x2AE3CA0", Offset = "0x2AE30A0", Length = "0x105")]
	[Token(Token = "0x600151C")]
	public static float4x2 op_Multiply(float4x2 lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE3E80", Offset = "0x2AE3280", Length = "0x101")]
	[Token(Token = "0x6001524")]
	public static float4x2 op_Subtraction(float lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE3F90", Offset = "0x2AE3390", Length = "0xC9")]
	[Token(Token = "0x6001523")]
	public static float4x2 op_Subtraction(float4x2 lhs, float rhs) { }

	[Address(RVA = "0x649000", Offset = "0x648400", Length = "0x106")]
	[Token(Token = "0x6001522")]
	public static float4x2 op_Subtraction(float4x2 lhs, float4x2 rhs) { }

	[Address(RVA = "0x2AE4060", Offset = "0x2AE3460", Length = "0xC6")]
	[Token(Token = "0x6001539")]
	public static float4x2 op_UnaryNegation(float4x2 val) { }

	[Address(RVA = "0x2AE4130", Offset = "0x2AE3530", Length = "0x90")]
	[Token(Token = "0x600153A")]
	public static float4x2 op_UnaryPlus(float4x2 val) { }

	[Address(RVA = "0x2AE1910", Offset = "0x2AE0D10", Length = "0x3A4")]
	[Token(Token = "0x6001545")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AE1590", Offset = "0x2AE0990", Length = "0x37E")]
	[Token(Token = "0x6001546")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

