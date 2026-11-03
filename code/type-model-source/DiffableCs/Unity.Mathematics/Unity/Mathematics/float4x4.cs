namespace Unity.Mathematics;

[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000036")]
public struct float4x4 : IEquatable<float4x4>, IFormattable
{
	[Token(Token = "0x40000E0")]
	public static readonly float4x4 identity; //Field offset: 0x0
	[Token(Token = "0x40000E1")]
	public static readonly float4x4 zero; //Field offset: 0x40
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000DC")]
	public float4 c0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000DD")]
	public float4 c1; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000DE")]
	public float4 c2; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000DF")]
	public float4 c3; //Field offset: 0x30

	[Token(Token = "0x170005C7")]
	public float4 Item
	{
		[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
		[Token(Token = "0x60015BF")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2AEA690", Offset = "0x2AE9A90", Length = "0x62")]
	[Token(Token = "0x60015E6")]
	private static float4x4() { }

	[Address(RVA = "0x2AEA950", Offset = "0x2AE9D50", Length = "0x14E")]
	[Token(Token = "0x60015C9")]
	public float4x4(RigidTransform transform) { }

	[Address(RVA = "0x2AEA810", Offset = "0x2AE9C10", Length = "0x138")]
	[Token(Token = "0x60015C8")]
	public float4x4(quaternion rotation, float3 translation) { }

	[Address(RVA = "0x2AEA700", Offset = "0x2AE9B00", Length = "0x10E")]
	[Token(Token = "0x60015C7")]
	public float4x4(float3x3 rotation, float3 translation) { }

	[Address(RVA = "0x2A1A600", Offset = "0x2A19A00", Length = "0x137")]
	[Token(Token = "0x6001590")]
	public float4x4(double4x4 v) { }

	[Address(RVA = "0x2A1A500", Offset = "0x2A19900", Length = "0xFB")]
	[Token(Token = "0x600158F")]
	public float4x4(double v) { }

	[Address(RVA = "0x2A1A8B0", Offset = "0x2A19CB0", Length = "0x1A5")]
	[Token(Token = "0x600158E")]
	public float4x4(uint4x4 v) { }

	[Address(RVA = "0x2A99310", Offset = "0x2A98710", Length = "0x23")]
	[Token(Token = "0x6001586")]
	public float4x4(float4 c0, float4 c1, float4 c2, float4 c3) { }

	[Address(RVA = "0x2A1AA60", Offset = "0x2A19E60", Length = "0x13E")]
	[Token(Token = "0x600158C")]
	public float4x4(int4x4 v) { }

	[Address(RVA = "0x2AEABE0", Offset = "0x2AE9FE0", Length = "0x40")]
	[Token(Token = "0x6001589")]
	public float4x4(bool v) { }

	[Address(RVA = "0x2A1A740", Offset = "0x2A19B40", Length = "0x168")]
	[Token(Token = "0x600158D")]
	public float4x4(uint v) { }

	[Address(RVA = "0x2AEAAA0", Offset = "0x2AE9EA0", Length = "0xF8")]
	[Token(Token = "0x6001587")]
	public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33) { }

	[Address(RVA = "0x2AEAC20", Offset = "0x2AEA020", Length = "0x2F")]
	[Token(Token = "0x6001588")]
	public float4x4(float v) { }

	[Address(RVA = "0x2AEABA0", Offset = "0x2AE9FA0", Length = "0x40")]
	[Token(Token = "0x600158B")]
	public float4x4(int v) { }

	[Address(RVA = "0x2A1A360", Offset = "0x2A19760", Length = "0x191")]
	[Token(Token = "0x600158A")]
	public float4x4(bool4x4 v) { }

	[Address(RVA = "0x2AE7FD0", Offset = "0x2AE73D0", Length = "0x36B")]
	[Token(Token = "0x60015CA")]
	public static float4x4 AxisAngle(float3 axis, float angle) { }

	[Address(RVA = "0x2AE8340", Offset = "0x2AE7740", Length = "0xAB")]
	[Token(Token = "0x60015C1")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2ADE5D0", Offset = "0x2ADD9D0", Length = "0x170")]
	[Token(Token = "0x60015C0")]
	public override bool Equals(float4x4 rhs) { }

	[Address(RVA = "0x2AE8840", Offset = "0x2AE7C40", Length = "0x184")]
	[Token(Token = "0x60015D7")]
	public static float4x4 Euler(float3 xyz, RotationOrder order = 4) { }

	[Address(RVA = "0x2AE8630", Offset = "0x2AE7A30", Length = "0x1F0")]
	[Token(Token = "0x60015D8")]
	public static float4x4 Euler(float x, float y, float z, RotationOrder order = 4) { }

	[Address(RVA = "0x2AE83F0", Offset = "0x2AE77F0", Length = "0x51")]
	[Token(Token = "0x60015D1")]
	public static float4x4 EulerXYZ(float x, float y, float z) { }

	[Address(RVA = "0x2ADE740", Offset = "0x2ADDB40", Length = "0x20A")]
	[Token(Token = "0x60015CB")]
	public static float4x4 EulerXYZ(float3 xyz) { }

	[Address(RVA = "0x2AE8450", Offset = "0x2AE7850", Length = "0x51")]
	[Token(Token = "0x60015D2")]
	public static float4x4 EulerXZY(float x, float y, float z) { }

	[Address(RVA = "0x2ADE950", Offset = "0x2ADDD50", Length = "0x1FC")]
	[Token(Token = "0x60015CC")]
	public static float4x4 EulerXZY(float3 xyz) { }

	[Address(RVA = "0x2AE84B0", Offset = "0x2AE78B0", Length = "0x51")]
	[Token(Token = "0x60015D3")]
	public static float4x4 EulerYXZ(float x, float y, float z) { }

	[Address(RVA = "0x2ADEB50", Offset = "0x2ADDF50", Length = "0x1FC")]
	[Token(Token = "0x60015CD")]
	public static float4x4 EulerYXZ(float3 xyz) { }

	[Address(RVA = "0x2AE8510", Offset = "0x2AE7910", Length = "0x51")]
	[Token(Token = "0x60015D4")]
	public static float4x4 EulerYZX(float x, float y, float z) { }

	[Address(RVA = "0x2ADED50", Offset = "0x2ADE150", Length = "0x1F6")]
	[Token(Token = "0x60015CE")]
	public static float4x4 EulerYZX(float3 xyz) { }

	[Address(RVA = "0x2ADEF50", Offset = "0x2ADE350", Length = "0x1D7")]
	[Token(Token = "0x60015CF")]
	public static float4x4 EulerZXY(float3 xyz) { }

	[Address(RVA = "0x2AE8570", Offset = "0x2AE7970", Length = "0x51")]
	[Token(Token = "0x60015D5")]
	public static float4x4 EulerZXY(float x, float y, float z) { }

	[Address(RVA = "0x2ADF130", Offset = "0x2ADE530", Length = "0xF56")]
	[Token(Token = "0x60015D0")]
	public static float4x4 EulerZYX(float3 xyz) { }

	[Address(RVA = "0x2AE85D0", Offset = "0x2AE79D0", Length = "0x51")]
	[Token(Token = "0x60015D6")]
	public static float4x4 EulerZYX(float x, float y, float z) { }

	[Address(RVA = "0x9D7560", Offset = "0x9D6960", Length = "0xB")]
	[Token(Token = "0x60015BF")]
	public float4 get_Item(int index) { }

	[Address(RVA = "0x2AE89E0", Offset = "0x2AE7DE0", Length = "0x38")]
	[Token(Token = "0x60015C2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AE8A20", Offset = "0x2AE7E20", Length = "0x263")]
	[Token(Token = "0x60015E0")]
	public static float4x4 LookAt(float3 eye, float3 target, float3 up) { }

	[Address(RVA = "0x2AEAC50", Offset = "0x2AEA050", Length = "0x1E5")]
	[Token(Token = "0x600159F")]
	public static float4x4 op_Addition(float lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEAE40", Offset = "0x2AEA240", Length = "0x1E5")]
	[Token(Token = "0x600159E")]
	public static float4x4 op_Addition(float4x4 lhs, float rhs) { }

	[Address(RVA = "0x2AEB030", Offset = "0x2AEA430", Length = "0x239")]
	[Token(Token = "0x600159D")]
	public static float4x4 op_Addition(float4x4 lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEB270", Offset = "0x2AEA670", Length = "0x243")]
	[Token(Token = "0x60015AA")]
	public static float4x4 op_Decrement(float4x4 val) { }

	[Address(RVA = "0x2AEB6E0", Offset = "0x2AEAAE0", Length = "0x1E5")]
	[Token(Token = "0x60015A4")]
	public static float4x4 op_Division(float4x4 lhs, float rhs) { }

	[Address(RVA = "0x2AEB8D0", Offset = "0x2AEACD0", Length = "0x23C")]
	[Token(Token = "0x60015A3")]
	public static float4x4 op_Division(float4x4 lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEB4C0", Offset = "0x2AEA8C0", Length = "0x212")]
	[Token(Token = "0x60015A5")]
	public static float4x4 op_Division(float lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEBEF0", Offset = "0x2AEB2F0", Length = "0x1B2")]
	[Token(Token = "0x60015BB")]
	public static bool4x4 op_Equality(float lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEBCD0", Offset = "0x2AEB0D0", Length = "0x21B")]
	[Token(Token = "0x60015B9")]
	public static bool4x4 op_Equality(float4x4 lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEBB10", Offset = "0x2AEAF10", Length = "0x1B1")]
	[Token(Token = "0x60015BA")]
	public static bool4x4 op_Equality(float4x4 lhs, float rhs) { }

	[Address(RVA = "0x2A38A80", Offset = "0x2A37E80", Length = "0x43")]
	[Token(Token = "0x6001592")]
	public static float4x4 op_Explicit(bool v) { }

	[Address(RVA = "0x2A38B80", Offset = "0x2A37F80", Length = "0x39")]
	[Token(Token = "0x6001593")]
	public static float4x4 op_Explicit(bool4x4 v) { }

	[Address(RVA = "0x2AEC130", Offset = "0x2AEB530", Length = "0x2C")]
	[Token(Token = "0x6001598")]
	public static float4x4 op_Explicit(double v) { }

	[Address(RVA = "0x2AEC0B0", Offset = "0x2AEB4B0", Length = "0x79")]
	[Token(Token = "0x6001599")]
	public static float4x4 op_Explicit(double4x4 v) { }

	[Address(RVA = "0x2AEC630", Offset = "0x2AEBA30", Length = "0x103")]
	[Token(Token = "0x60015B3")]
	public static bool4x4 op_GreaterThan(float lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEC740", Offset = "0x2AEBB40", Length = "0xFF")]
	[Token(Token = "0x60015B2")]
	public static bool4x4 op_GreaterThan(float4x4 lhs, float rhs) { }

	[Address(RVA = "0x2AEC4D0", Offset = "0x2AEB8D0", Length = "0x157")]
	[Token(Token = "0x60015B1")]
	public static bool4x4 op_GreaterThan(float4x4 lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEC3C0", Offset = "0x2AEB7C0", Length = "0x103")]
	[Token(Token = "0x60015B6")]
	public static bool4x4 op_GreaterThanOrEqual(float lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEC260", Offset = "0x2AEB660", Length = "0x157")]
	[Token(Token = "0x60015B4")]
	public static bool4x4 op_GreaterThanOrEqual(float4x4 lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEC160", Offset = "0x2AEB560", Length = "0xFF")]
	[Token(Token = "0x60015B5")]
	public static bool4x4 op_GreaterThanOrEqual(float4x4 lhs, float rhs) { }

	[Address(RVA = "0x2AECAC0", Offset = "0x2AEBEC0", Length = "0x50")]
	[Token(Token = "0x60015C5")]
	public static float4x4 op_Implicit(Matrix4x4 m) { }

	[Address(RVA = "0x2AEC840", Offset = "0x2AEBC40", Length = "0x2C")]
	[Token(Token = "0x6001596")]
	public static float4x4 op_Implicit(uint v) { }

	[Address(RVA = "0x2A38640", Offset = "0x2A37A40", Length = "0x32")]
	[Token(Token = "0x6001591")]
	public static float4x4 op_Implicit(float v) { }

	[Address(RVA = "0x2A389B0", Offset = "0x2A37DB0", Length = "0x54")]
	[Token(Token = "0x6001597")]
	public static float4x4 op_Implicit(uint4x4 v) { }

	[Address(RVA = "0x2AEC8D0", Offset = "0x2AEBCD0", Length = "0x1EF")]
	[Token(Token = "0x60015C6")]
	public static Matrix4x4 op_Implicit(float4x4 m) { }

	[Address(RVA = "0x2AEC870", Offset = "0x2AEBC70", Length = "0x54")]
	[Token(Token = "0x6001595")]
	public static float4x4 op_Implicit(int4x4 v) { }

	[Address(RVA = "0x2A38AD0", Offset = "0x2A37ED0", Length = "0x43")]
	[Token(Token = "0x6001594")]
	public static float4x4 op_Implicit(int v) { }

	[Address(RVA = "0x2AECB10", Offset = "0x2AEBF10", Length = "0x243")]
	[Token(Token = "0x60015A9")]
	public static float4x4 op_Increment(float4x4 val) { }

	[Address(RVA = "0x2AECF20", Offset = "0x2AEC320", Length = "0x21B")]
	[Token(Token = "0x60015BC")]
	public static bool4x4 op_Inequality(float4x4 lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AED140", Offset = "0x2AEC540", Length = "0x1B1")]
	[Token(Token = "0x60015BD")]
	public static bool4x4 op_Inequality(float4x4 lhs, float rhs) { }

	[Address(RVA = "0x2AECD60", Offset = "0x2AEC160", Length = "0x1B2")]
	[Token(Token = "0x60015BE")]
	public static bool4x4 op_Inequality(float lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AED670", Offset = "0x2AECA70", Length = "0x103")]
	[Token(Token = "0x60015AD")]
	public static bool4x4 op_LessThan(float lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AED780", Offset = "0x2AECB80", Length = "0xFF")]
	[Token(Token = "0x60015AC")]
	public static bool4x4 op_LessThan(float4x4 lhs, float rhs) { }

	[Address(RVA = "0x2AED880", Offset = "0x2AECC80", Length = "0x157")]
	[Token(Token = "0x60015AB")]
	public static bool4x4 op_LessThan(float4x4 lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AED410", Offset = "0x2AEC810", Length = "0xFF")]
	[Token(Token = "0x60015AF")]
	public static bool4x4 op_LessThanOrEqual(float4x4 lhs, float rhs) { }

	[Address(RVA = "0x2AED510", Offset = "0x2AEC910", Length = "0x157")]
	[Token(Token = "0x60015AE")]
	public static bool4x4 op_LessThanOrEqual(float4x4 lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AED300", Offset = "0x2AEC700", Length = "0x103")]
	[Token(Token = "0x60015B0")]
	public static bool4x4 op_LessThanOrEqual(float lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEDFA0", Offset = "0x2AED3A0", Length = "0x2B0")]
	[Token(Token = "0x60015A7")]
	public static float4x4 op_Modulus(float4x4 lhs, float rhs) { }

	[Address(RVA = "0x2AED9E0", Offset = "0x2AECDE0", Length = "0x2B2")]
	[Token(Token = "0x60015A8")]
	public static float4x4 op_Modulus(float lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEDCA0", Offset = "0x2AED0A0", Length = "0x2F3")]
	[Token(Token = "0x60015A6")]
	public static float4x4 op_Modulus(float4x4 lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEE630", Offset = "0x2AEDA30", Length = "0x239")]
	[Token(Token = "0x600159A")]
	public static float4x4 op_Multiply(float4x4 lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEE440", Offset = "0x2AED840", Length = "0x1E5")]
	[Token(Token = "0x600159B")]
	public static float4x4 op_Multiply(float4x4 lhs, float rhs) { }

	[Address(RVA = "0x2AEE250", Offset = "0x2AED650", Length = "0x1E5")]
	[Token(Token = "0x600159C")]
	public static float4x4 op_Multiply(float lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEEA90", Offset = "0x2AEDE90", Length = "0x1E5")]
	[Token(Token = "0x60015A1")]
	public static float4x4 op_Subtraction(float4x4 lhs, float rhs) { }

	[Address(RVA = "0x2AEEC80", Offset = "0x2AEE080", Length = "0x23C")]
	[Token(Token = "0x60015A0")]
	public static float4x4 op_Subtraction(float4x4 lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEE870", Offset = "0x2AEDC70", Length = "0x212")]
	[Token(Token = "0x60015A2")]
	public static float4x4 op_Subtraction(float lhs, float4x4 rhs) { }

	[Address(RVA = "0x2AEEEC0", Offset = "0x2AEE2C0", Length = "0x1DA")]
	[Token(Token = "0x60015B7")]
	public static float4x4 op_UnaryNegation(float4x4 val) { }

	[Address(RVA = "0x2AEF0A0", Offset = "0x2AEE4A0", Length = "0x5BA")]
	[Token(Token = "0x60015B8")]
	public static float4x4 op_UnaryPlus(float4x4 val) { }

	[Address(RVA = "0x2AE8E10", Offset = "0x2AE8210", Length = "0xE1")]
	[Token(Token = "0x60015E1")]
	public static float4x4 Ortho(float width, float height, float near, float far) { }

	[Address(RVA = "0x2AE8C90", Offset = "0x2AE8090", Length = "0x17B")]
	[Token(Token = "0x60015E2")]
	public static float4x4 OrthoOffCenter(float left, float right, float bottom, float top, float near, float far) { }

	[Address(RVA = "0x2AE8F00", Offset = "0x2AE8300", Length = "0x14A")]
	[Token(Token = "0x60015E3")]
	public static float4x4 PerspectiveFov(float verticalFov, float aspect, float near, float far) { }

	[Address(RVA = "0x2AE9050", Offset = "0x2AE8450", Length = "0x170")]
	[Token(Token = "0x60015E4")]
	public static float4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far) { }

	[Address(RVA = "0x2AE91C0", Offset = "0x2AE85C0", Length = "0x130")]
	[Token(Token = "0x60015D9")]
	public static float4x4 RotateX(float angle) { }

	[Address(RVA = "0x2AE92F0", Offset = "0x2AE86F0", Length = "0x139")]
	[Token(Token = "0x60015DA")]
	public static float4x4 RotateY(float angle) { }

	[Address(RVA = "0x2AE9430", Offset = "0x2AE8830", Length = "0x132")]
	[Token(Token = "0x60015DB")]
	public static float4x4 RotateZ(float angle) { }

	[Address(RVA = "0x2AE95E0", Offset = "0x2AE89E0", Length = "0x66")]
	[Token(Token = "0x60015DC")]
	public static float4x4 Scale(float s) { }

	[Address(RVA = "0x2AE9650", Offset = "0x2AE8A50", Length = "0x71")]
	[Token(Token = "0x60015DE")]
	public static float4x4 Scale(float3 scales) { }

	[Address(RVA = "0x2AE9570", Offset = "0x2AE8970", Length = "0x66")]
	[Token(Token = "0x60015DD")]
	public static float4x4 Scale(float x, float y, float z) { }

	[Address(RVA = "0x2AE9FA0", Offset = "0x2AE93A0", Length = "0x676")]
	[Token(Token = "0x60015C4")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x2AE98C0", Offset = "0x2AE8CC0", Length = "0x6DB")]
	[Token(Token = "0x60015C3")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AEA620", Offset = "0x2AE9A20", Length = "0x70")]
	[Token(Token = "0x60015DF")]
	public static float4x4 Translate(float3 vector) { }

	[Address(RVA = "0x2AE96D0", Offset = "0x2AE8AD0", Length = "0x1E8")]
	[Token(Token = "0x60015E5")]
	public static float4x4 TRS(float3 translation, quaternion rotation, float3 scale) { }

}

