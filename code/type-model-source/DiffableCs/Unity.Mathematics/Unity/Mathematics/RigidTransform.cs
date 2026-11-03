namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000052")]
public struct RigidTransform
{
	[Token(Token = "0x400013A")]
	public static readonly RigidTransform identity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000138")]
	public quaternion rot; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000139")]
	public float3 pos; //Field offset: 0x10

	[Address(RVA = "0x2B2B5D0", Offset = "0x2B2A9D0", Length = "0x51")]
	[Token(Token = "0x6001EE3")]
	private static RigidTransform() { }

	[Address(RVA = "0x2B2B6C0", Offset = "0x2B2AAC0", Length = "0x7A")]
	[Token(Token = "0x6001ECA")]
	public RigidTransform(float4x4 transform) { }

	[Address(RVA = "0x2B2B630", Offset = "0x2B2AA30", Length = "0x18")]
	[Token(Token = "0x6001EC8")]
	public RigidTransform(quaternion rotation, float3 translation) { }

	[Address(RVA = "0x2B2B650", Offset = "0x2B2AA50", Length = "0x64")]
	[Token(Token = "0x6001EC9")]
	public RigidTransform(float3x3 rotation, float3 translation) { }

	[Address(RVA = "0x2B29D80", Offset = "0x2B29180", Length = "0x176")]
	[Token(Token = "0x6001ECB")]
	public static RigidTransform AxisAngle(float3 axis, float angle) { }

	[Address(RVA = "0x2B29F00", Offset = "0x2B29300", Length = "0x107")]
	[Token(Token = "0x6001EDF")]
	public virtual bool Equals(object x) { }

	[Address(RVA = "0x2B2A010", Offset = "0x2B29410", Length = "0x88")]
	[Token(Token = "0x6001EDE")]
	public bool Equals(RigidTransform x) { }

	[Address(RVA = "0x2B2AAB0", Offset = "0x2B29EB0", Length = "0x52")]
	[Token(Token = "0x6001ED9")]
	public static RigidTransform Euler(float x, float y, float z, RotationOrder order = 4) { }

	[Address(RVA = "0x2B2A7C0", Offset = "0x2B29BC0", Length = "0x2D4")]
	[Token(Token = "0x6001ED8")]
	public static RigidTransform Euler(float3 xyz, RotationOrder order = 4) { }

	[Address(RVA = "0x2B2A0A0", Offset = "0x2B294A0", Length = "0x80")]
	[Token(Token = "0x6001ECC")]
	public static RigidTransform EulerXYZ(float3 xyz) { }

	[Address(RVA = "0x2B2A120", Offset = "0x2B29520", Length = "0xA9")]
	[Token(Token = "0x6001ED2")]
	public static RigidTransform EulerXYZ(float x, float y, float z) { }

	[Address(RVA = "0x2B2A280", Offset = "0x2B29680", Length = "0x80")]
	[Token(Token = "0x6001ECD")]
	public static RigidTransform EulerXZY(float3 xyz) { }

	[Address(RVA = "0x2B2A1D0", Offset = "0x2B295D0", Length = "0xA9")]
	[Token(Token = "0x6001ED3")]
	public static RigidTransform EulerXZY(float x, float y, float z) { }

	[Address(RVA = "0x2B2A300", Offset = "0x2B29700", Length = "0x80")]
	[Token(Token = "0x6001ECE")]
	public static RigidTransform EulerYXZ(float3 xyz) { }

	[Address(RVA = "0x2B2A380", Offset = "0x2B29780", Length = "0xA9")]
	[Token(Token = "0x6001ED4")]
	public static RigidTransform EulerYXZ(float x, float y, float z) { }

	[Address(RVA = "0x2B2A430", Offset = "0x2B29830", Length = "0xA9")]
	[Token(Token = "0x6001ED5")]
	public static RigidTransform EulerYZX(float x, float y, float z) { }

	[Address(RVA = "0x2B2A4E0", Offset = "0x2B298E0", Length = "0x80")]
	[Token(Token = "0x6001ECF")]
	public static RigidTransform EulerYZX(float3 xyz) { }

	[Address(RVA = "0x2B2A560", Offset = "0x2B29960", Length = "0x80")]
	[Token(Token = "0x6001ED0")]
	public static RigidTransform EulerZXY(float3 xyz) { }

	[Address(RVA = "0x2B2A5E0", Offset = "0x2B299E0", Length = "0xA9")]
	[Token(Token = "0x6001ED6")]
	public static RigidTransform EulerZXY(float x, float y, float z) { }

	[Address(RVA = "0x2B2A740", Offset = "0x2B29B40", Length = "0x80")]
	[Token(Token = "0x6001ED1")]
	public static RigidTransform EulerZYX(float3 xyz) { }

	[Address(RVA = "0x2B2A690", Offset = "0x2B29A90", Length = "0xA9")]
	[Token(Token = "0x6001ED7")]
	public static RigidTransform EulerZYX(float x, float y, float z) { }

	[Address(RVA = "0x2B2AB10", Offset = "0x2B29F10", Length = "0x86")]
	[Token(Token = "0x6001EE0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2B2ABA0", Offset = "0x2B29FA0", Length = "0x113")]
	[Token(Token = "0x6001EDA")]
	public static RigidTransform RotateX(float angle) { }

	[Address(RVA = "0x2B2ACC0", Offset = "0x2B2A0C0", Length = "0x11E")]
	[Token(Token = "0x6001EDB")]
	public static RigidTransform RotateY(float angle) { }

	[Address(RVA = "0x2B2ADE0", Offset = "0x2B2A1E0", Length = "0x117")]
	[Token(Token = "0x6001EDC")]
	public static RigidTransform RotateZ(float angle) { }

	[Address(RVA = "0x2B2AF00", Offset = "0x2B2A300", Length = "0x322")]
	[Token(Token = "0x6001EE2")]
	public string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x2B2B230", Offset = "0x2B2A630", Length = "0x33E")]
	[Token(Token = "0x6001EE1")]
	public virtual string ToString() { }

	[Address(RVA = "0x2B2B570", Offset = "0x2B2A970", Length = "0x5E")]
	[Token(Token = "0x6001EDD")]
	public static RigidTransform Translate(float3 vector) { }

}

