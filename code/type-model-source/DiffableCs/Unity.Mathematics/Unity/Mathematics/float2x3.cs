namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200002B")]
public struct float2x3 : IEquatable<float2x3>, IFormattable
{
	[Token(Token = "0x40000B2")]
	public static readonly float2x3 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000AF")]
	public float2 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000B0")]
	public float2 c1; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000B1")]
	public float2 c2; //Field offset: 0x10

	[Token(Token = "0x170003F9")]
	public float2 Item
	{
		[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
		[Token(Token = "0x6001148")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1F73700", Offset = "0x1F72B00", Length = "0xC")]
	[Token(Token = "0x600110F")]
	public float2x3(float2 c0, float2 c1, float2 c2) { }

	[Address(RVA = "0x2ACDE90", Offset = "0x2ACD290", Length = "0x48")]
	[Token(Token = "0x6001118")]
	public float2x3(double v) { }

	[Address(RVA = "0x2ACDD70", Offset = "0x2ACD170", Length = "0x8B")]
	[Token(Token = "0x6001117")]
	public float2x3(uint2x3 v) { }

	[Address(RVA = "0x2ACDFD0", Offset = "0x2ACD3D0", Length = "0x72")]
	[Token(Token = "0x6001116")]
	public float2x3(uint v) { }

	[Address(RVA = "0x2ACDE00", Offset = "0x2ACD200", Length = "0x5F")]
	[Token(Token = "0x6001115")]
	public float2x3(int2x3 v) { }

	[Address(RVA = "0x2ACDD10", Offset = "0x2ACD110", Length = "0x57")]
	[Token(Token = "0x6001119")]
	public float2x3(double2x3 v) { }

	[Address(RVA = "0x2ACDF50", Offset = "0x2ACD350", Length = "0x80")]
	[Token(Token = "0x6001113")]
	public float2x3(bool2x3 v) { }

	[Address(RVA = "0x2ACDF00", Offset = "0x2ACD300", Length = "0x4F")]
	[Token(Token = "0x6001112")]
	public float2x3(bool v) { }

	[Address(RVA = "0x2ACDEE0", Offset = "0x2ACD2E0", Length = "0x12")]
	[Token(Token = "0x6001111")]
	public float2x3(float v) { }

	[Address(RVA = "0x2ACDE60", Offset = "0x2ACD260", Length = "0x30")]
	[Token(Token = "0x6001110")]
	public float2x3(float m00, float m01, float m02, float m10, float m11, float m12) { }

	[Address(RVA = "0x2ACE050", Offset = "0x2ACD450", Length = "0x48")]
	[Token(Token = "0x6001114")]
	public float2x3(int v) { }

	[Address(RVA = "0x2ACD590", Offset = "0x2ACC990", Length = "0x105")]
	[Token(Token = "0x600114A")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2ACD6A0", Offset = "0x2ACCAA0", Length = "0x8B")]
	[Token(Token = "0x6001149")]
	public override bool Equals(float2x3 rhs) { }

	[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
	[Token(Token = "0x6001148")]
	public float2 get_Item(int index) { }

	[Address(RVA = "0x2ACD730", Offset = "0x2ACCB30", Length = "0x28")]
	[Token(Token = "0x600114B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2ACE170", Offset = "0x2ACD570", Length = "0x2D")]
	[Token(Token = "0x6001127")]
	public static float2x3 op_Addition(float2x3 lhs, float rhs) { }

	[Address(RVA = "0x2ACE0A0", Offset = "0x2ACD4A0", Length = "0x55")]
	[Token(Token = "0x6001128")]
	public static float2x3 op_Addition(float lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACE100", Offset = "0x2ACD500", Length = "0x6B")]
	[Token(Token = "0x6001126")]
	public static float2x3 op_Addition(float2x3 lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACE1A0", Offset = "0x2ACD5A0", Length = "0x81")]
	[Token(Token = "0x6001133")]
	public static float2x3 op_Decrement(float2x3 val) { }

	[Address(RVA = "0x2ACE230", Offset = "0x2ACD630", Length = "0x2D")]
	[Token(Token = "0x600112D")]
	public static float2x3 op_Division(float2x3 lhs, float rhs) { }

	[Address(RVA = "0x2ACE2C0", Offset = "0x2ACD6C0", Length = "0x6A")]
	[Token(Token = "0x600112C")]
	public static float2x3 op_Division(float2x3 lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACE260", Offset = "0x2ACD660", Length = "0x5C")]
	[Token(Token = "0x600112E")]
	public static float2x3 op_Division(float lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACE330", Offset = "0x2ACD730", Length = "0xB8")]
	[Token(Token = "0x6001143")]
	public static bool2x3 op_Equality(float2x3 lhs, float rhs) { }

	[Address(RVA = "0x2ACE4A0", Offset = "0x2ACD8A0", Length = "0xD1")]
	[Token(Token = "0x6001142")]
	public static bool2x3 op_Equality(float2x3 lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACE3F0", Offset = "0x2ACD7F0", Length = "0xA6")]
	[Token(Token = "0x6001144")]
	public static bool2x3 op_Equality(float lhs, float2x3 rhs) { }

	[Address(RVA = "0x2A34B10", Offset = "0x2A33F10", Length = "0x4B")]
	[Token(Token = "0x6001121")]
	public static float2x3 op_Explicit(double v) { }

	[Address(RVA = "0x2A34BE0", Offset = "0x2A33FE0", Length = "0x52")]
	[Token(Token = "0x600111B")]
	public static float2x3 op_Explicit(bool v) { }

	[Address(RVA = "0x2A34CF0", Offset = "0x2A340F0", Length = "0xB1")]
	[Token(Token = "0x600111C")]
	public static float2x3 op_Explicit(bool2x3 v) { }

	[Address(RVA = "0x2A34C40", Offset = "0x2A34040", Length = "0x6A")]
	[Token(Token = "0x6001122")]
	public static float2x3 op_Explicit(double2x3 v) { }

	[Address(RVA = "0x2ACE800", Offset = "0x2ACDC00", Length = "0x73")]
	[Token(Token = "0x600113B")]
	public static bool2x3 op_GreaterThan(float2x3 lhs, float rhs) { }

	[Address(RVA = "0x2ACE700", Offset = "0x2ACDB00", Length = "0x68")]
	[Token(Token = "0x600113C")]
	public static bool2x3 op_GreaterThan(float lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACE770", Offset = "0x2ACDB70", Length = "0x8D")]
	[Token(Token = "0x600113A")]
	public static bool2x3 op_GreaterThan(float2x3 lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACE580", Offset = "0x2ACD980", Length = "0x73")]
	[Token(Token = "0x600113E")]
	public static bool2x3 op_GreaterThanOrEqual(float2x3 lhs, float rhs) { }

	[Address(RVA = "0x2ACE670", Offset = "0x2ACDA70", Length = "0x8D")]
	[Token(Token = "0x600113D")]
	public static bool2x3 op_GreaterThanOrEqual(float2x3 lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACE600", Offset = "0x2ACDA00", Length = "0x68")]
	[Token(Token = "0x600113F")]
	public static bool2x3 op_GreaterThanOrEqual(float lhs, float2x3 rhs) { }

	[Address(RVA = "0x2A34B60", Offset = "0x2A33F60", Length = "0x75")]
	[Token(Token = "0x600111F")]
	public static float2x3 op_Implicit(uint v) { }

	[Address(RVA = "0x2A34ED0", Offset = "0x2A342D0", Length = "0xA0")]
	[Token(Token = "0x600111E")]
	public static float2x3 op_Implicit(int2x3 v) { }

	[Address(RVA = "0x2A34AF0", Offset = "0x2A33EF0", Length = "0x15")]
	[Token(Token = "0x600111A")]
	public static float2x3 op_Implicit(float v) { }

	[Address(RVA = "0x2A34DB0", Offset = "0x2A341B0", Length = "0xCD")]
	[Token(Token = "0x6001120")]
	public static float2x3 op_Implicit(uint2x3 v) { }

	[Address(RVA = "0x2A34E80", Offset = "0x2A34280", Length = "0x4B")]
	[Token(Token = "0x600111D")]
	public static float2x3 op_Implicit(int v) { }

	[Address(RVA = "0x2ACE880", Offset = "0x2ACDC80", Length = "0x81")]
	[Token(Token = "0x6001132")]
	public static float2x3 op_Increment(float2x3 val) { }

	[Address(RVA = "0x2ACE910", Offset = "0x2ACDD10", Length = "0xB8")]
	[Token(Token = "0x6001146")]
	public static bool2x3 op_Inequality(float2x3 lhs, float rhs) { }

	[Address(RVA = "0x2ACE9D0", Offset = "0x2ACDDD0", Length = "0xD1")]
	[Token(Token = "0x6001145")]
	public static bool2x3 op_Inequality(float2x3 lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACEAB0", Offset = "0x2ACDEB0", Length = "0xA6")]
	[Token(Token = "0x6001147")]
	public static bool2x3 op_Inequality(float lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACED50", Offset = "0x2ACE150", Length = "0x8D")]
	[Token(Token = "0x6001134")]
	public static bool2x3 op_LessThan(float2x3 lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACEDE0", Offset = "0x2ACE1E0", Length = "0x7B")]
	[Token(Token = "0x6001136")]
	public static bool2x3 op_LessThan(float lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACECE0", Offset = "0x2ACE0E0", Length = "0x63")]
	[Token(Token = "0x6001135")]
	public static bool2x3 op_LessThan(float2x3 lhs, float rhs) { }

	[Address(RVA = "0x2ACEBD0", Offset = "0x2ACDFD0", Length = "0x8D")]
	[Token(Token = "0x6001137")]
	public static bool2x3 op_LessThanOrEqual(float2x3 lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACEB60", Offset = "0x2ACDF60", Length = "0x63")]
	[Token(Token = "0x6001138")]
	public static bool2x3 op_LessThanOrEqual(float2x3 lhs, float rhs) { }

	[Address(RVA = "0x2ACEC60", Offset = "0x2ACE060", Length = "0x7B")]
	[Token(Token = "0x6001139")]
	public static bool2x3 op_LessThanOrEqual(float lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACEF20", Offset = "0x2ACE320", Length = "0xA5")]
	[Token(Token = "0x6001131")]
	public static float2x3 op_Modulus(float lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACEFD0", Offset = "0x2ACE3D0", Length = "0xA4")]
	[Token(Token = "0x6001130")]
	public static float2x3 op_Modulus(float2x3 lhs, float rhs) { }

	[Address(RVA = "0x2ACEE60", Offset = "0x2ACE260", Length = "0xBF")]
	[Token(Token = "0x600112F")]
	public static float2x3 op_Modulus(float2x3 lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACF120", Offset = "0x2ACE520", Length = "0x55")]
	[Token(Token = "0x6001125")]
	public static float2x3 op_Multiply(float lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACF080", Offset = "0x2ACE480", Length = "0x2D")]
	[Token(Token = "0x6001124")]
	public static float2x3 op_Multiply(float2x3 lhs, float rhs) { }

	[Address(RVA = "0x2ACF0B0", Offset = "0x2ACE4B0", Length = "0x6B")]
	[Token(Token = "0x6001123")]
	public static float2x3 op_Multiply(float2x3 lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACF220", Offset = "0x2ACE620", Length = "0x5C")]
	[Token(Token = "0x600112B")]
	public static float2x3 op_Subtraction(float lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACF1F0", Offset = "0x2ACE5F0", Length = "0x2D")]
	[Token(Token = "0x600112A")]
	public static float2x3 op_Subtraction(float2x3 lhs, float rhs) { }

	[Address(RVA = "0x2ACF180", Offset = "0x2ACE580", Length = "0x6A")]
	[Token(Token = "0x6001129")]
	public static float2x3 op_Subtraction(float2x3 lhs, float2x3 rhs) { }

	[Address(RVA = "0x2ACF280", Offset = "0x2ACE680", Length = "0x2E")]
	[Token(Token = "0x6001140")]
	public static float2x3 op_UnaryNegation(float2x3 val) { }

	[Address(RVA = "0x2ACF2B0", Offset = "0x2ACE6B0", Length = "0x30")]
	[Token(Token = "0x6001141")]
	public static float2x3 op_UnaryPlus(float2x3 val) { }

	[Address(RVA = "0x2ACD760", Offset = "0x2ACCB60", Length = "0x2D8")]
	[Token(Token = "0x600114C")]
	public virtual string ToString() { }

	[Address(RVA = "0x2ACDA40", Offset = "0x2ACCE40", Length = "0x2C6")]
	[Token(Token = "0x600114D")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

