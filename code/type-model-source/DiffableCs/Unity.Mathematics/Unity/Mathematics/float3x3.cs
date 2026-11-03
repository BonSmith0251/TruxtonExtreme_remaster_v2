namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000030")]
public struct float3x3 : IEquatable<float3x3>, IFormattable
{
	[Token(Token = "0x40000C5")]
	public static readonly float3x3 identity; //Field offset: 0x0
	[Token(Token = "0x40000C6")]
	public static readonly float3x3 zero; //Field offset: 0x24
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000C2")]
	public float3 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40000C3")]
	public float3 c1; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C4")]
	public float3 c2; //Field offset: 0x18

	[Token(Token = "0x17000472")]
	public float3 Item
	{
		[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
		[Token(Token = "0x60012CF")]
		 get { } //Length: 12
	}

	[Address(RVA = "0x2AD6450", Offset = "0x2AD5850", Length = "0x4F")]
	[Token(Token = "0x60012EF")]
	private static float3x3() { }

	[Address(RVA = "0x2AD6880", Offset = "0x2AD5C80", Length = "0x2EA")]
	[Token(Token = "0x60012D6")]
	public float3x3(quaternion q) { }

	[Address(RVA = "0x2AD66D0", Offset = "0x2AD5AD0", Length = "0x53")]
	[Token(Token = "0x60012D5")]
	public float3x3(float4x4 f4x4) { }

	[Address(RVA = "0x2AD65E0", Offset = "0x2AD59E0", Length = "0x8B")]
	[Token(Token = "0x60012A0")]
	public float3x3(double3x3 v) { }

	[Address(RVA = "0x2AD6810", Offset = "0x2AD5C10", Length = "0x69")]
	[Token(Token = "0x600129F")]
	public float3x3(double v) { }

	[Address(RVA = "0x2A191B0", Offset = "0x2A185B0", Length = "0x109")]
	[Token(Token = "0x600129E")]
	public float3x3(uint3x3 v) { }

	[Address(RVA = "0x2AD6730", Offset = "0x2AD5B30", Length = "0xA5")]
	[Token(Token = "0x600129D")]
	public float3x3(uint v) { }

	[Address(RVA = "0x2A82CE0", Offset = "0x2A820E0", Length = "0x31")]
	[Token(Token = "0x6001296")]
	public float3x3(float3 c0, float3 c1, float3 c2) { }

	[Address(RVA = "0x2AD6570", Offset = "0x2AD5970", Length = "0x66")]
	[Token(Token = "0x600129B")]
	public float3x3(int v) { }

	[Address(RVA = "0x2AD6670", Offset = "0x2AD5A70", Length = "0x5E")]
	[Token(Token = "0x6001297")]
	public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22) { }

	[Address(RVA = "0x2AD67E0", Offset = "0x2AD5BE0", Length = "0x30")]
	[Token(Token = "0x6001298")]
	public float3x3(float v) { }

	[Address(RVA = "0x2AD64A0", Offset = "0x2AD58A0", Length = "0xC2")]
	[Token(Token = "0x600129C")]
	public float3x3(int3x3 v) { }

	[Address(RVA = "0x2A19130", Offset = "0x2A18530", Length = "0x73")]
	[Token(Token = "0x6001299")]
	public float3x3(bool v) { }

	[Address(RVA = "0x2A192C0", Offset = "0x2A186C0", Length = "0xCE")]
	[Token(Token = "0x600129A")]
	public float3x3(bool3x3 v) { }

	[Address(RVA = "0x2AD49F0", Offset = "0x2AD3DF0", Length = "0x2D9")]
	[Token(Token = "0x60012D7")]
	public static float3x3 AxisAngle(float3 axis, float angle) { }

	[Address(RVA = "0x2AD4CD0", Offset = "0x2AD40D0", Length = "0xA0")]
	[Token(Token = "0x60012D1")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2A735F0", Offset = "0x2A729F0", Length = "0xAA")]
	[Token(Token = "0x60012D0")]
	public override bool Equals(float3x3 rhs) { }

	[Address(RVA = "0x2AD4F60", Offset = "0x2AD4360", Length = "0x1C4")]
	[Token(Token = "0x60012E5")]
	public static float3x3 Euler(float x, float y, float z, RotationOrder order = 4) { }

	[Address(RVA = "0x2AD5140", Offset = "0x2AD4540", Length = "0x164")]
	[Token(Token = "0x60012E4")]
	public static float3x3 Euler(float3 xyz, RotationOrder order = 4) { }

	[Address(RVA = "0x2AC9060", Offset = "0x2AC8460", Length = "0x1B0")]
	[Token(Token = "0x60012D8")]
	public static float3x3 EulerXYZ(float3 xyz) { }

	[Address(RVA = "0x2AD4D80", Offset = "0x2AD4180", Length = "0x47")]
	[Token(Token = "0x60012DE")]
	public static float3x3 EulerXYZ(float x, float y, float z) { }

	[Address(RVA = "0x2AD4DD0", Offset = "0x2AD41D0", Length = "0x47")]
	[Token(Token = "0x60012DF")]
	public static float3x3 EulerXZY(float x, float y, float z) { }

	[Address(RVA = "0x2AC9210", Offset = "0x2AC8610", Length = "0x1B0")]
	[Token(Token = "0x60012D9")]
	public static float3x3 EulerXZY(float3 xyz) { }

	[Address(RVA = "0x2AD4E20", Offset = "0x2AD4220", Length = "0x47")]
	[Token(Token = "0x60012E0")]
	public static float3x3 EulerYXZ(float x, float y, float z) { }

	[Address(RVA = "0x2AC93C0", Offset = "0x2AC87C0", Length = "0x1A5")]
	[Token(Token = "0x60012DA")]
	public static float3x3 EulerYXZ(float3 xyz) { }

	[Address(RVA = "0x2AD4E70", Offset = "0x2AD4270", Length = "0x47")]
	[Token(Token = "0x60012E1")]
	public static float3x3 EulerYZX(float x, float y, float z) { }

	[Address(RVA = "0x2AC9570", Offset = "0x2AC8970", Length = "0x1AF")]
	[Token(Token = "0x60012DB")]
	public static float3x3 EulerYZX(float3 xyz) { }

	[Address(RVA = "0x2AC9720", Offset = "0x2AC8B20", Length = "0x18E")]
	[Token(Token = "0x60012DC")]
	public static float3x3 EulerZXY(float3 xyz) { }

	[Address(RVA = "0x2AD4EC0", Offset = "0x2AD42C0", Length = "0x47")]
	[Token(Token = "0x60012E2")]
	public static float3x3 EulerZXY(float x, float y, float z) { }

	[Address(RVA = "0x2AC98B0", Offset = "0x2AC8CB0", Length = "0x324")]
	[Token(Token = "0x60012DD")]
	public static float3x3 EulerZYX(float3 xyz) { }

	[Address(RVA = "0x2AD4F10", Offset = "0x2AD4310", Length = "0x47")]
	[Token(Token = "0x60012E3")]
	public static float3x3 EulerZYX(float x, float y, float z) { }

	[Address(RVA = "0x9D7640", Offset = "0x9D6A40", Length = "0xC")]
	[Token(Token = "0x60012CF")]
	public float3 get_Item(int index) { }

	[Address(RVA = "0x2AD52C0", Offset = "0x2AD46C0", Length = "0xB7")]
	[Token(Token = "0x60012D2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AD56C0", Offset = "0x2AD4AC0", Length = "0x178")]
	[Token(Token = "0x60012EC")]
	public static float3x3 LookRotation(float3 forward, float3 up) { }

	[Address(RVA = "0x2AD5380", Offset = "0x2AD4780", Length = "0x33C")]
	[Token(Token = "0x60012ED")]
	public static float3x3 LookRotationSafe(float3 forward, float3 up) { }

	[Address(RVA = "0x2AD6D50", Offset = "0x2AD6150", Length = "0xD1")]
	[Token(Token = "0x60012AF")]
	public static float3x3 op_Addition(float lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD6B70", Offset = "0x2AD5F70", Length = "0xD5")]
	[Token(Token = "0x60012AE")]
	public static float3x3 op_Addition(float3x3 lhs, float rhs) { }

	[Address(RVA = "0x2AD6C50", Offset = "0x2AD6050", Length = "0xF9")]
	[Token(Token = "0x60012AD")]
	public static float3x3 op_Addition(float3x3 lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD6E30", Offset = "0x2AD6230", Length = "0xE0")]
	[Token(Token = "0x60012BA")]
	public static float3x3 op_Decrement(float3x3 val) { }

	[Address(RVA = "0x2AD7100", Offset = "0x2AD6500", Length = "0xD5")]
	[Token(Token = "0x60012B4")]
	public static float3x3 op_Division(float3x3 lhs, float rhs) { }

	[Address(RVA = "0x2AD7010", Offset = "0x2AD6410", Length = "0xEC")]
	[Token(Token = "0x60012B5")]
	public static float3x3 op_Division(float lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD6F10", Offset = "0x2AD6310", Length = "0xF9")]
	[Token(Token = "0x60012B3")]
	public static float3x3 op_Division(float3x3 lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD71E0", Offset = "0x2AD65E0", Length = "0x103")]
	[Token(Token = "0x60012CB")]
	public static bool3x3 op_Equality(float lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD72F0", Offset = "0x2AD66F0", Length = "0x11F")]
	[Token(Token = "0x60012CA")]
	public static bool3x3 op_Equality(float3x3 lhs, float rhs) { }

	[Address(RVA = "0x2AD7410", Offset = "0x2AD6810", Length = "0x14E")]
	[Token(Token = "0x60012C9")]
	public static bool3x3 op_Equality(float3x3 lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD75D0", Offset = "0x2AD69D0", Length = "0x40")]
	[Token(Token = "0x60012A3")]
	public static float3x3 op_Explicit(bool3x3 v) { }

	[Address(RVA = "0x2A36400", Offset = "0x2A35800", Length = "0x6C")]
	[Token(Token = "0x60012A8")]
	public static float3x3 op_Explicit(double v) { }

	[Address(RVA = "0x2AD7610", Offset = "0x2AD6A10", Length = "0x29")]
	[Token(Token = "0x60012A2")]
	public static float3x3 op_Explicit(bool v) { }

	[Address(RVA = "0x2A35F40", Offset = "0x2A35340", Length = "0x90")]
	[Token(Token = "0x60012A9")]
	public static float3x3 op_Explicit(double3x3 v) { }

	[Address(RVA = "0x2AD7560", Offset = "0x2AD6960", Length = "0x70")]
	[Token(Token = "0x60012EE")]
	public static float3x3 op_Explicit(float4x4 f4x4) { }

	[Address(RVA = "0x2AD7880", Offset = "0x2AD6C80", Length = "0xAF")]
	[Token(Token = "0x60012C2")]
	public static bool3x3 op_GreaterThan(float3x3 lhs, float rhs) { }

	[Address(RVA = "0x2AD7A10", Offset = "0x2AD6E10", Length = "0xA6")]
	[Token(Token = "0x60012C3")]
	public static bool3x3 op_GreaterThan(float lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD7930", Offset = "0x2AD6D30", Length = "0xDA")]
	[Token(Token = "0x60012C1")]
	public static bool3x3 op_GreaterThan(float3x3 lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD77D0", Offset = "0x2AD6BD0", Length = "0xA6")]
	[Token(Token = "0x60012C6")]
	public static bool3x3 op_GreaterThanOrEqual(float lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD7640", Offset = "0x2AD6A40", Length = "0xAF")]
	[Token(Token = "0x60012C5")]
	public static bool3x3 op_GreaterThanOrEqual(float3x3 lhs, float rhs) { }

	[Address(RVA = "0x2AD76F0", Offset = "0x2AD6AF0", Length = "0xDA")]
	[Token(Token = "0x60012C4")]
	public static bool3x3 op_GreaterThanOrEqual(float3x3 lhs, float3x3 rhs) { }

	[Address(RVA = "0x2A35FD0", Offset = "0x2A353D0", Length = "0xC0")]
	[Token(Token = "0x60012A5")]
	public static float3x3 op_Implicit(int3x3 v) { }

	[Address(RVA = "0x2A36160", Offset = "0x2A35560", Length = "0x69")]
	[Token(Token = "0x60012A4")]
	public static float3x3 op_Implicit(int v) { }

	[Address(RVA = "0x2A35F00", Offset = "0x2A35300", Length = "0x33")]
	[Token(Token = "0x60012A1")]
	public static float3x3 op_Implicit(float v) { }

	[Address(RVA = "0x2A36310", Offset = "0x2A35710", Length = "0xA8")]
	[Token(Token = "0x60012A6")]
	public static float3x3 op_Implicit(uint v) { }

	[Address(RVA = "0x2AD7AC0", Offset = "0x2AD6EC0", Length = "0x46")]
	[Token(Token = "0x60012A7")]
	public static float3x3 op_Implicit(uint3x3 v) { }

	[Address(RVA = "0x2AD7B10", Offset = "0x2AD6F10", Length = "0xE0")]
	[Token(Token = "0x60012B9")]
	public static float3x3 op_Increment(float3x3 val) { }

	[Address(RVA = "0x2AD7BF0", Offset = "0x2AD6FF0", Length = "0x103")]
	[Token(Token = "0x60012CE")]
	public static bool3x3 op_Inequality(float lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD7D00", Offset = "0x2AD7100", Length = "0x11F")]
	[Token(Token = "0x60012CD")]
	public static bool3x3 op_Inequality(float3x3 lhs, float rhs) { }

	[Address(RVA = "0x2AD7E20", Offset = "0x2AD7220", Length = "0x14E")]
	[Token(Token = "0x60012CC")]
	public static bool3x3 op_Inequality(float3x3 lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD8270", Offset = "0x2AD7670", Length = "0xB2")]
	[Token(Token = "0x60012BD")]
	public static bool3x3 op_LessThan(float lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD81C0", Offset = "0x2AD75C0", Length = "0xA3")]
	[Token(Token = "0x60012BC")]
	public static bool3x3 op_LessThan(float3x3 lhs, float rhs) { }

	[Address(RVA = "0x2AD8330", Offset = "0x2AD7730", Length = "0xDD")]
	[Token(Token = "0x60012BB")]
	public static bool3x3 op_LessThan(float3x3 lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD8030", Offset = "0x2AD7430", Length = "0xDD")]
	[Token(Token = "0x60012BE")]
	public static bool3x3 op_LessThanOrEqual(float3x3 lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD7F70", Offset = "0x2AD7370", Length = "0xB2")]
	[Token(Token = "0x60012C0")]
	public static bool3x3 op_LessThanOrEqual(float lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD8110", Offset = "0x2AD7510", Length = "0xA3")]
	[Token(Token = "0x60012BF")]
	public static bool3x3 op_LessThanOrEqual(float3x3 lhs, float rhs) { }

	[Address(RVA = "0x2AD8580", Offset = "0x2AD7980", Length = "0x175")]
	[Token(Token = "0x60012B6")]
	public static float3x3 op_Modulus(float3x3 lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD8700", Offset = "0x2AD7B00", Length = "0x15F")]
	[Token(Token = "0x60012B7")]
	public static float3x3 op_Modulus(float3x3 lhs, float rhs) { }

	[Address(RVA = "0x2AD8410", Offset = "0x2AD7810", Length = "0x161")]
	[Token(Token = "0x60012B8")]
	public static float3x3 op_Modulus(float lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD8960", Offset = "0x2AD7D60", Length = "0xD1")]
	[Token(Token = "0x60012AC")]
	public static float3x3 op_Multiply(float lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD8A40", Offset = "0x2AD7E40", Length = "0xD5")]
	[Token(Token = "0x60012AB")]
	public static float3x3 op_Multiply(float3x3 lhs, float rhs) { }

	[Address(RVA = "0x2AD8860", Offset = "0x2AD7C60", Length = "0xF9")]
	[Token(Token = "0x60012AA")]
	public static float3x3 op_Multiply(float3x3 lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD8C20", Offset = "0x2AD8020", Length = "0xD5")]
	[Token(Token = "0x60012B1")]
	public static float3x3 op_Subtraction(float3x3 lhs, float rhs) { }

	[Address(RVA = "0x2AD8B20", Offset = "0x2AD7F20", Length = "0xF9")]
	[Token(Token = "0x60012B0")]
	public static float3x3 op_Subtraction(float3x3 lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD8D00", Offset = "0x2AD8100", Length = "0xEC")]
	[Token(Token = "0x60012B2")]
	public static float3x3 op_Subtraction(float lhs, float3x3 rhs) { }

	[Address(RVA = "0x2AD8DF0", Offset = "0x2AD81F0", Length = "0xD1")]
	[Token(Token = "0x60012C7")]
	public static float3x3 op_UnaryNegation(float3x3 val) { }

	[Address(RVA = "0x2AD8ED0", Offset = "0x2AD82D0", Length = "0x8D")]
	[Token(Token = "0x60012C8")]
	public static float3x3 op_UnaryPlus(float3x3 val) { }

	[Address(RVA = "0x2AD5840", Offset = "0x2AD4C40", Length = "0xF4")]
	[Token(Token = "0x60012E6")]
	public static float3x3 RotateX(float angle) { }

	[Address(RVA = "0x2AD5940", Offset = "0x2AD4D40", Length = "0x10E")]
	[Token(Token = "0x60012E7")]
	public static float3x3 RotateY(float angle) { }

	[Address(RVA = "0x2AD5A50", Offset = "0x2AD4E50", Length = "0x107")]
	[Token(Token = "0x60012E8")]
	public static float3x3 RotateZ(float angle) { }

	[Address(RVA = "0x2AD5C10", Offset = "0x2AD5010", Length = "0x4E")]
	[Token(Token = "0x60012E9")]
	public static float3x3 Scale(float s) { }

	[Address(RVA = "0x2AD5B60", Offset = "0x2AD4F60", Length = "0x4B")]
	[Token(Token = "0x60012EA")]
	public static float3x3 Scale(float x, float y, float z) { }

	[Address(RVA = "0x2AD5BB0", Offset = "0x2AD4FB0", Length = "0x59")]
	[Token(Token = "0x60012EB")]
	public static float3x3 Scale(float3 v) { }

	[Address(RVA = "0x2AD6070", Offset = "0x2AD5470", Length = "0x3DA")]
	[Token(Token = "0x60012D4")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x2AD5C60", Offset = "0x2AD5060", Length = "0x40A")]
	[Token(Token = "0x60012D3")]
	public virtual string ToString() { }

}

