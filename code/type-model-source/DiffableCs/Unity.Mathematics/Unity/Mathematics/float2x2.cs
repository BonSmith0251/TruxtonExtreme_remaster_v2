namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200002A")]
public struct float2x2 : IEquatable<float2x2>, IFormattable
{
	[Token(Token = "0x40000AD")]
	public static readonly float2x2 identity; //Field offset: 0x0
	[Token(Token = "0x40000AE")]
	public static readonly float2x2 zero; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AB")]
	public float2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000AC")]
	public float2 c1; //Field offset: 0x8

	[Token(Token = "0x170003F8")]
	public float2 Item
	{
		[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
		[Token(Token = "0x6001104")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2ACC320", Offset = "0x2ACB720", Length = "0x3E")]
	[Token(Token = "0x600110E")]
	private static float2x2() { }

	[Address(RVA = "0x2ACC4E0", Offset = "0x2ACB8E0", Length = "0x3B")]
	[Token(Token = "0x60010D5")]
	public float2x2(double2x2 v) { }

	[Address(RVA = "0x2ACC400", Offset = "0x2ACB800", Length = "0x30")]
	[Token(Token = "0x60010D4")]
	public float2x2(double v) { }

	[Address(RVA = "0x2ACC3A0", Offset = "0x2ACB7A0", Length = "0x5D")]
	[Token(Token = "0x60010D3")]
	public float2x2(uint2x2 v) { }

	[Address(RVA = "0x2ACC560", Offset = "0x2ACB960", Length = "0x4C")]
	[Token(Token = "0x60010D2")]
	public float2x2(uint v) { }

	[Address(RVA = "0x2ACC520", Offset = "0x2ACB920", Length = "0x3F")]
	[Token(Token = "0x60010D1")]
	public float2x2(int2x2 v) { }

	[Address(RVA = "0xE1C7E0", Offset = "0xE1BBE0", Length = "0x8")]
	[Token(Token = "0x60010CB")]
	public float2x2(float2 c0, float2 c1) { }

	[Address(RVA = "0x2ACC430", Offset = "0x2ACB830", Length = "0x55")]
	[Token(Token = "0x60010CF")]
	public float2x2(bool2x2 v) { }

	[Address(RVA = "0x2ACC360", Offset = "0x2ACB760", Length = "0x3B")]
	[Token(Token = "0x60010CE")]
	public float2x2(bool v) { }

	[Address(RVA = "0x27F6A10", Offset = "0x27F5E10", Length = "0x8")]
	[Token(Token = "0x60010CD")]
	public float2x2(float v) { }

	[Address(RVA = "0x2ACC4C0", Offset = "0x2ACB8C0", Length = "0x1A")]
	[Token(Token = "0x60010CC")]
	public float2x2(float m00, float m01, float m10, float m11) { }

	[Address(RVA = "0x2ACC490", Offset = "0x2ACB890", Length = "0x30")]
	[Token(Token = "0x60010D0")]
	public float2x2(int v) { }

	[Address(RVA = "0x2ACBBA0", Offset = "0x2ACAFA0", Length = "0x43")]
	[Token(Token = "0x6001105")]
	public override bool Equals(float2x2 rhs) { }

	[Address(RVA = "0x2ACBBF0", Offset = "0x2ACAFF0", Length = "0xBE")]
	[Token(Token = "0x6001106")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
	[Token(Token = "0x6001104")]
	public float2 get_Item(int index) { }

	[Address(RVA = "0x2ACBCB0", Offset = "0x2ACB0B0", Length = "0xC8")]
	[Token(Token = "0x6001107")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2ACC640", Offset = "0x2ACBA40", Length = "0x35")]
	[Token(Token = "0x60010E3")]
	public static float2x2 op_Addition(float2x2 lhs, float rhs) { }

	[Address(RVA = "0x2ACC5B0", Offset = "0x2ACB9B0", Length = "0x4B")]
	[Token(Token = "0x60010E2")]
	public static float2x2 op_Addition(float2x2 lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACC600", Offset = "0x2ACBA00", Length = "0x39")]
	[Token(Token = "0x60010E4")]
	public static float2x2 op_Addition(float lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACC680", Offset = "0x2ACBA80", Length = "0x4B")]
	[Token(Token = "0x60010EF")]
	public static float2x2 op_Decrement(float2x2 val) { }

	[Address(RVA = "0x2ACC720", Offset = "0x2ACBB20", Length = "0x40")]
	[Token(Token = "0x60010EA")]
	public static float2x2 op_Division(float lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACC760", Offset = "0x2ACBB60", Length = "0x3A")]
	[Token(Token = "0x60010E9")]
	public static float2x2 op_Division(float2x2 lhs, float rhs) { }

	[Address(RVA = "0x2ACC6D0", Offset = "0x2ACBAD0", Length = "0x4A")]
	[Token(Token = "0x60010E8")]
	public static float2x2 op_Division(float2x2 lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACC7A0", Offset = "0x2ACBBA0", Length = "0xB9")]
	[Token(Token = "0x60010FE")]
	public static bool2x2 op_Equality(float2x2 lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACC860", Offset = "0x2ACBC60", Length = "0x9E")]
	[Token(Token = "0x60010FF")]
	public static bool2x2 op_Equality(float2x2 lhs, float rhs) { }

	[Address(RVA = "0x2ACC900", Offset = "0x2ACBD00", Length = "0x8D")]
	[Token(Token = "0x6001100")]
	public static bool2x2 op_Equality(float lhs, float2x2 rhs) { }

	[Address(RVA = "0x2A349B0", Offset = "0x2A33DB0", Length = "0x33")]
	[Token(Token = "0x60010DD")]
	public static float2x2 op_Explicit(double v) { }

	[Address(RVA = "0x2A34910", Offset = "0x2A33D10", Length = "0x4A")]
	[Token(Token = "0x60010DE")]
	public static float2x2 op_Explicit(double2x2 v) { }

	[Address(RVA = "0x2A34A50", Offset = "0x2A33E50", Length = "0x3E")]
	[Token(Token = "0x60010D7")]
	public static float2x2 op_Explicit(bool v) { }

	[Address(RVA = "0x2A34A90", Offset = "0x2A33E90", Length = "0x58")]
	[Token(Token = "0x60010D8")]
	public static float2x2 op_Explicit(bool2x2 v) { }

	[Address(RVA = "0x2ACCC10", Offset = "0x2ACC010", Length = "0x75")]
	[Token(Token = "0x60010F7")]
	public static bool2x2 op_GreaterThan(float2x2 lhs, float rhs) { }

	[Address(RVA = "0x2ACCB80", Offset = "0x2ACBF80", Length = "0x8A")]
	[Token(Token = "0x60010F6")]
	public static bool2x2 op_GreaterThan(float2x2 lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACCB10", Offset = "0x2ACBF10", Length = "0x6A")]
	[Token(Token = "0x60010F8")]
	public static bool2x2 op_GreaterThan(float lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACCA10", Offset = "0x2ACBE10", Length = "0x8A")]
	[Token(Token = "0x60010F9")]
	public static bool2x2 op_GreaterThanOrEqual(float2x2 lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACC990", Offset = "0x2ACBD90", Length = "0x75")]
	[Token(Token = "0x60010FA")]
	public static bool2x2 op_GreaterThanOrEqual(float2x2 lhs, float rhs) { }

	[Address(RVA = "0x2ACCAA0", Offset = "0x2ACBEA0", Length = "0x6A")]
	[Token(Token = "0x60010FB")]
	public static bool2x2 op_GreaterThanOrEqual(float lhs, float2x2 rhs) { }

	[Address(RVA = "0x2A34840", Offset = "0x2A33C40", Length = "0x78")]
	[Token(Token = "0x60010DC")]
	public static float2x2 op_Implicit(uint2x2 v) { }

	[Address(RVA = "0x2A34960", Offset = "0x2A33D60", Length = "0x4F")]
	[Token(Token = "0x60010DB")]
	public static float2x2 op_Implicit(uint v) { }

	[Address(RVA = "0x2A349F0", Offset = "0x2A33DF0", Length = "0x5A")]
	[Token(Token = "0x60010DA")]
	public static float2x2 op_Implicit(int2x2 v) { }

	[Address(RVA = "0x2A348D0", Offset = "0x2A33CD0", Length = "0x33")]
	[Token(Token = "0x60010D9")]
	public static float2x2 op_Implicit(int v) { }

	[Address(RVA = "0x27F4DE0", Offset = "0x27F41E0", Length = "0xB")]
	[Token(Token = "0x60010D6")]
	public static float2x2 op_Implicit(float v) { }

	[Address(RVA = "0x2ACCC90", Offset = "0x2ACC090", Length = "0x4B")]
	[Token(Token = "0x60010EE")]
	public static float2x2 op_Increment(float2x2 val) { }

	[Address(RVA = "0x2ACCDA0", Offset = "0x2ACC1A0", Length = "0x8D")]
	[Token(Token = "0x6001103")]
	public static bool2x2 op_Inequality(float lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACCCE0", Offset = "0x2ACC0E0", Length = "0xB9")]
	[Token(Token = "0x6001101")]
	public static bool2x2 op_Inequality(float2x2 lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACCE30", Offset = "0x2ACC230", Length = "0x9E")]
	[Token(Token = "0x6001102")]
	public static bool2x2 op_Inequality(float2x2 lhs, float rhs) { }

	[Address(RVA = "0x2ACD0D0", Offset = "0x2ACC4D0", Length = "0x8A")]
	[Token(Token = "0x60010F0")]
	public static bool2x2 op_LessThan(float2x2 lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACD050", Offset = "0x2ACC450", Length = "0x75")]
	[Token(Token = "0x60010F2")]
	public static bool2x2 op_LessThan(float lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACD160", Offset = "0x2ACC560", Length = "0x6D")]
	[Token(Token = "0x60010F1")]
	public static bool2x2 op_LessThan(float2x2 lhs, float rhs) { }

	[Address(RVA = "0x2ACCFE0", Offset = "0x2ACC3E0", Length = "0x6D")]
	[Token(Token = "0x60010F4")]
	public static bool2x2 op_LessThanOrEqual(float2x2 lhs, float rhs) { }

	[Address(RVA = "0x2ACCF50", Offset = "0x2ACC350", Length = "0x8A")]
	[Token(Token = "0x60010F3")]
	public static bool2x2 op_LessThanOrEqual(float2x2 lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACCED0", Offset = "0x2ACC2D0", Length = "0x75")]
	[Token(Token = "0x60010F5")]
	public static bool2x2 op_LessThanOrEqual(float lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACD2E0", Offset = "0x2ACC6E0", Length = "0x97")]
	[Token(Token = "0x60010EB")]
	public static float2x2 op_Modulus(float2x2 lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACD1D0", Offset = "0x2ACC5D0", Length = "0x80")]
	[Token(Token = "0x60010EC")]
	public static float2x2 op_Modulus(float2x2 lhs, float rhs) { }

	[Address(RVA = "0x2ACD250", Offset = "0x2ACC650", Length = "0x81")]
	[Token(Token = "0x60010ED")]
	public static float2x2 op_Modulus(float lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACD3D0", Offset = "0x2ACC7D0", Length = "0x39")]
	[Token(Token = "0x60010E1")]
	public static float2x2 op_Multiply(float lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACD410", Offset = "0x2ACC810", Length = "0x35")]
	[Token(Token = "0x60010E0")]
	public static float2x2 op_Multiply(float2x2 lhs, float rhs) { }

	[Address(RVA = "0x2ACD380", Offset = "0x2ACC780", Length = "0x4B")]
	[Token(Token = "0x60010DF")]
	public static float2x2 op_Multiply(float2x2 lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACD450", Offset = "0x2ACC850", Length = "0x40")]
	[Token(Token = "0x60010E7")]
	public static float2x2 op_Subtraction(float lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACD4D0", Offset = "0x2ACC8D0", Length = "0x4A")]
	[Token(Token = "0x60010E5")]
	public static float2x2 op_Subtraction(float2x2 lhs, float2x2 rhs) { }

	[Address(RVA = "0x2ACD490", Offset = "0x2ACC890", Length = "0x3A")]
	[Token(Token = "0x60010E6")]
	public static float2x2 op_Subtraction(float2x2 lhs, float rhs) { }

	[Address(RVA = "0x2ACD520", Offset = "0x2ACC920", Length = "0x3E")]
	[Token(Token = "0x60010FC")]
	public static float2x2 op_UnaryNegation(float2x2 val) { }

	[Address(RVA = "0x2ACD560", Offset = "0x2ACC960", Length = "0x24")]
	[Token(Token = "0x60010FD")]
	public static float2x2 op_UnaryPlus(float2x2 val) { }

	[Address(RVA = "0x2ACBD80", Offset = "0x2ACB180", Length = "0xDD")]
	[Token(Token = "0x600110A")]
	public static float2x2 Rotate(float angle) { }

	[Address(RVA = "0x2ACBEC0", Offset = "0x2ACB2C0", Length = "0x3D")]
	[Token(Token = "0x600110D")]
	public static float2x2 Scale(float2 v) { }

	[Address(RVA = "0x2ACBE90", Offset = "0x2ACB290", Length = "0x2C")]
	[Token(Token = "0x600110B")]
	public static float2x2 Scale(float s) { }

	[Address(RVA = "0x2ACBE60", Offset = "0x2ACB260", Length = "0x2C")]
	[Token(Token = "0x600110C")]
	public static float2x2 Scale(float x, float y) { }

	[Address(RVA = "0x2ACC110", Offset = "0x2ACB510", Length = "0x204")]
	[Token(Token = "0x6001108")]
	public virtual string ToString() { }

	[Address(RVA = "0x2ACBF00", Offset = "0x2ACB300", Length = "0x20A")]
	[Token(Token = "0x6001109")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

