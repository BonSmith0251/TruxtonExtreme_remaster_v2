namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000035")]
public struct float4x3 : IEquatable<float4x3>, IFormattable
{
	[Token(Token = "0x40000DB")]
	public static readonly float4x3 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D8")]
	public float4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000D9")]
	public float4 c1; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000DA")]
	public float4 c2; //Field offset: 0x20

	[Token(Token = "0x170005C6")]
	public float4 Item
	{
		[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
		[Token(Token = "0x6001580")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x1311590", Offset = "0x1310990", Length = "0x17")]
	[Token(Token = "0x6001547")]
	public float4x3(float4 c0, float4 c1, float4 c2) { }

	[Address(RVA = "0x2A19D40", Offset = "0x2A19140", Length = "0xBF")]
	[Token(Token = "0x6001550")]
	public float4x3(double v) { }

	[Address(RVA = "0x2A1A020", Offset = "0x2A19420", Length = "0x13E")]
	[Token(Token = "0x600154F")]
	public float4x3(uint4x3 v) { }

	[Address(RVA = "0x2A1A250", Offset = "0x2A19650", Length = "0x110")]
	[Token(Token = "0x600154E")]
	public float4x3(uint v) { }

	[Address(RVA = "0x2A19F30", Offset = "0x2A19330", Length = "0xF0")]
	[Token(Token = "0x600154D")]
	public float4x3(int4x3 v) { }

	[Address(RVA = "0x2A1A160", Offset = "0x2A19560", Length = "0xEB")]
	[Token(Token = "0x6001551")]
	public float4x3(double4x3 v) { }

	[Address(RVA = "0x2A19E00", Offset = "0x2A19200", Length = "0x130")]
	[Token(Token = "0x600154B")]
	public float4x3(bool4x3 v) { }

	[Address(RVA = "0x2AE4D00", Offset = "0x2AE4100", Length = "0x31")]
	[Token(Token = "0x600154A")]
	public float4x3(bool v) { }

	[Address(RVA = "0x2AE4CD0", Offset = "0x2AE40D0", Length = "0x27")]
	[Token(Token = "0x6001549")]
	public float4x3(float v) { }

	[Address(RVA = "0x2AE4D70", Offset = "0x2AE4170", Length = "0xB4")]
	[Token(Token = "0x6001548")]
	public float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32) { }

	[Address(RVA = "0x2AE4D40", Offset = "0x2AE4140", Length = "0x30")]
	[Token(Token = "0x600154C")]
	public float4x3(int v) { }

	[Address(RVA = "0x2AE41C0", Offset = "0x2AE35C0", Length = "0xA2")]
	[Token(Token = "0x6001582")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2ADDA90", Offset = "0x2ADCE90", Length = "0xB30")]
	[Token(Token = "0x6001581")]
	public override bool Equals(float4x3 rhs) { }

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x6001580")]
	public float4 get_Item(int index) { }

	[Address(RVA = "0x2AE4270", Offset = "0x2AE3670", Length = "0x2F")]
	[Token(Token = "0x6001583")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AE5140", Offset = "0x2AE4540", Length = "0x15A")]
	[Token(Token = "0x600155F")]
	public static float4x3 op_Addition(float4x3 lhs, float rhs) { }

	[Address(RVA = "0x2AE4E30", Offset = "0x2AE4230", Length = "0x15B")]
	[Token(Token = "0x6001560")]
	public static float4x3 op_Addition(float lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE4F90", Offset = "0x2AE4390", Length = "0x1AC")]
	[Token(Token = "0x600155E")]
	public static float4x3 op_Addition(float4x3 lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE52A0", Offset = "0x2AE46A0", Length = "0x168")]
	[Token(Token = "0x600156B")]
	public static float4x3 op_Decrement(float4x3 val) { }

	[Address(RVA = "0x2AE55C0", Offset = "0x2AE49C0", Length = "0x15A")]
	[Token(Token = "0x6001565")]
	public static float4x3 op_Division(float4x3 lhs, float rhs) { }

	[Address(RVA = "0x2AE5410", Offset = "0x2AE4810", Length = "0x1AF")]
	[Token(Token = "0x6001564")]
	public static float4x3 op_Division(float4x3 lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE5720", Offset = "0x2AE4B20", Length = "0x18B")]
	[Token(Token = "0x6001566")]
	public static float4x3 op_Division(float lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE5BA0", Offset = "0x2AE4FA0", Length = "0x142")]
	[Token(Token = "0x600157B")]
	public static bool4x3 op_Equality(float4x3 lhs, float rhs) { }

	[Address(RVA = "0x2AE5A00", Offset = "0x2AE4E00", Length = "0x192")]
	[Token(Token = "0x600157A")]
	public static bool4x3 op_Equality(float4x3 lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE58B0", Offset = "0x2AE4CB0", Length = "0x143")]
	[Token(Token = "0x600157C")]
	public static bool4x3 op_Equality(float lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE5CF0", Offset = "0x2AE50F0", Length = "0x28")]
	[Token(Token = "0x6001559")]
	public static float4x3 op_Explicit(double v) { }

	[Address(RVA = "0x2A38000", Offset = "0x2A37400", Length = "0x34")]
	[Token(Token = "0x6001553")]
	public static float4x3 op_Explicit(bool v) { }

	[Address(RVA = "0x2AE5D20", Offset = "0x2AE5120", Length = "0x3E")]
	[Token(Token = "0x6001554")]
	public static float4x3 op_Explicit(bool4x3 v) { }

	[Address(RVA = "0x2A37970", Offset = "0x2A36D70", Length = "0xF4")]
	[Token(Token = "0x600155A")]
	public static float4x3 op_Explicit(double4x3 v) { }

	[Address(RVA = "0x2AE5FE0", Offset = "0x2AE53E0", Length = "0xBC")]
	[Token(Token = "0x6001573")]
	public static bool4x3 op_GreaterThan(float4x3 lhs, float rhs) { }

	[Address(RVA = "0x2AE61A0", Offset = "0x2AE55A0", Length = "0xBF")]
	[Token(Token = "0x6001574")]
	public static bool4x3 op_GreaterThan(float lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE60A0", Offset = "0x2AE54A0", Length = "0xFD")]
	[Token(Token = "0x6001572")]
	public static bool4x3 op_GreaterThan(float4x3 lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE5F20", Offset = "0x2AE5320", Length = "0xBC")]
	[Token(Token = "0x6001576")]
	public static bool4x3 op_GreaterThanOrEqual(float4x3 lhs, float rhs) { }

	[Address(RVA = "0x2AE5D60", Offset = "0x2AE5160", Length = "0xFD")]
	[Token(Token = "0x6001575")]
	public static bool4x3 op_GreaterThanOrEqual(float4x3 lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE5E60", Offset = "0x2AE5260", Length = "0xBF")]
	[Token(Token = "0x6001577")]
	public static bool4x3 op_GreaterThanOrEqual(float lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE6260", Offset = "0x2AE5660", Length = "0x28")]
	[Token(Token = "0x6001557")]
	public static float4x3 op_Implicit(uint v) { }

	[Address(RVA = "0x2AE6290", Offset = "0x2AE5690", Length = "0x47")]
	[Token(Token = "0x6001556")]
	public static float4x3 op_Implicit(int4x3 v) { }

	[Address(RVA = "0x2A37FD0", Offset = "0x2A373D0", Length = "0x2A")]
	[Token(Token = "0x6001552")]
	public static float4x3 op_Implicit(float v) { }

	[Address(RVA = "0x2AE62E0", Offset = "0x2AE56E0", Length = "0x47")]
	[Token(Token = "0x6001558")]
	public static float4x3 op_Implicit(uint4x3 v) { }

	[Address(RVA = "0x2A38040", Offset = "0x2A37440", Length = "0x33")]
	[Token(Token = "0x6001555")]
	public static float4x3 op_Implicit(int v) { }

	[Address(RVA = "0x2AE6330", Offset = "0x2AE5730", Length = "0x168")]
	[Token(Token = "0x600156A")]
	public static float4x3 op_Increment(float4x3 val) { }

	[Address(RVA = "0x2AE64A0", Offset = "0x2AE58A0", Length = "0x142")]
	[Token(Token = "0x600157E")]
	public static bool4x3 op_Inequality(float4x3 lhs, float rhs) { }

	[Address(RVA = "0x2AE65F0", Offset = "0x2AE59F0", Length = "0x192")]
	[Token(Token = "0x600157D")]
	public static bool4x3 op_Inequality(float4x3 lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE6790", Offset = "0x2AE5B90", Length = "0x143")]
	[Token(Token = "0x600157F")]
	public static bool4x3 op_Inequality(float lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE6B60", Offset = "0x2AE5F60", Length = "0xFD")]
	[Token(Token = "0x600156C")]
	public static bool4x3 op_LessThan(float4x3 lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE6C60", Offset = "0x2AE6060", Length = "0xBF")]
	[Token(Token = "0x600156E")]
	public static bool4x3 op_LessThan(float lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE6D20", Offset = "0x2AE6120", Length = "0xBC")]
	[Token(Token = "0x600156D")]
	public static bool4x3 op_LessThan(float4x3 lhs, float rhs) { }

	[Address(RVA = "0x2AE68E0", Offset = "0x2AE5CE0", Length = "0xFD")]
	[Token(Token = "0x600156F")]
	public static bool4x3 op_LessThanOrEqual(float4x3 lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE69E0", Offset = "0x2AE5DE0", Length = "0xBC")]
	[Token(Token = "0x6001570")]
	public static bool4x3 op_LessThanOrEqual(float4x3 lhs, float rhs) { }

	[Address(RVA = "0x2AE6AA0", Offset = "0x2AE5EA0", Length = "0xBF")]
	[Token(Token = "0x6001571")]
	public static bool4x3 op_LessThanOrEqual(float lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE6DE0", Offset = "0x2AE61E0", Length = "0x205")]
	[Token(Token = "0x6001569")]
	public static float4x3 op_Modulus(float lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE6FF0", Offset = "0x2AE63F0", Length = "0x204")]
	[Token(Token = "0x6001568")]
	public static float4x3 op_Modulus(float4x3 lhs, float rhs) { }

	[Address(RVA = "0x2AE7200", Offset = "0x2AE6600", Length = "0x240")]
	[Token(Token = "0x6001567")]
	public static float4x3 op_Modulus(float4x3 lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE7440", Offset = "0x2AE6840", Length = "0x15B")]
	[Token(Token = "0x600155D")]
	public static float4x3 op_Multiply(float lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE7750", Offset = "0x2AE6B50", Length = "0x15A")]
	[Token(Token = "0x600155C")]
	public static float4x3 op_Multiply(float4x3 lhs, float rhs) { }

	[Address(RVA = "0x2AE75A0", Offset = "0x2AE69A0", Length = "0x1AC")]
	[Token(Token = "0x600155B")]
	public static float4x3 op_Multiply(float4x3 lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE7BC0", Offset = "0x2AE6FC0", Length = "0x18B")]
	[Token(Token = "0x6001563")]
	public static float4x3 op_Subtraction(float lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE7A60", Offset = "0x2AE6E60", Length = "0x15A")]
	[Token(Token = "0x6001562")]
	public static float4x3 op_Subtraction(float4x3 lhs, float rhs) { }

	[Address(RVA = "0x2AE78B0", Offset = "0x2AE6CB0", Length = "0x1AF")]
	[Token(Token = "0x6001561")]
	public static float4x3 op_Subtraction(float4x3 lhs, float4x3 rhs) { }

	[Address(RVA = "0x2AE7D50", Offset = "0x2AE7150", Length = "0x153")]
	[Token(Token = "0x6001578")]
	public static float4x3 op_UnaryNegation(float4x3 val) { }

	[Address(RVA = "0x2AE7EB0", Offset = "0x2AE72B0", Length = "0x112")]
	[Token(Token = "0x6001579")]
	public static float4x3 op_UnaryPlus(float4x3 val) { }

	[Address(RVA = "0x2AE4790", Offset = "0x2AE3B90", Length = "0x530")]
	[Token(Token = "0x6001584")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AE42A0", Offset = "0x2AE36A0", Length = "0x4EE")]
	[Token(Token = "0x6001585")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

