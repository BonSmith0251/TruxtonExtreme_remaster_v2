namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200004D")]
public struct quaternion : IEquatable<quaternion>, IFormattable
{
	[Token(Token = "0x4000136")]
	public static readonly quaternion identity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000135")]
	public float4 value; //Field offset: 0x0

	[Address(RVA = "0x2B24E00", Offset = "0x2B24200", Length = "0x3E")]
	[Token(Token = "0x6001E5B")]
	private static quaternion() { }

	[Address(RVA = "0x27F69A0", Offset = "0x27F5DA0", Length = "0x1A")]
	[Token(Token = "0x6001E3D")]
	public quaternion(float x, float y, float z, float w) { }

	[Address(RVA = "0xEA4190", Offset = "0xEA3590", Length = "0x7")]
	[Token(Token = "0x6001E3E")]
	public quaternion(float4 value) { }

	[Address(RVA = "0x2B24E40", Offset = "0x2B24240", Length = "0x356")]
	[Token(Token = "0x6001E40")]
	public quaternion(float3x3 m) { }

	[Address(RVA = "0x2B251A0", Offset = "0x2B245A0", Length = "0x35C")]
	[Token(Token = "0x6001E41")]
	public quaternion(float4x4 m) { }

	[Address(RVA = "0x2B23B10", Offset = "0x2B22F10", Length = "0x13D")]
	[Token(Token = "0x6001E42")]
	public static quaternion AxisAngle(float3 axis, float angle) { }

	[Address(RVA = "0x2B23C50", Offset = "0x2B23050", Length = "0xBE")]
	[Token(Token = "0x6001E57")]
	public virtual bool Equals(object x) { }

	[Address(RVA = "0x23DE6F0", Offset = "0x23DDAF0", Length = "0x38")]
	[Token(Token = "0x6001E56")]
	public override bool Equals(quaternion x) { }

	[Address(RVA = "0x2B23E90", Offset = "0x2B23290", Length = "0x5C")]
	[Token(Token = "0x6001E50")]
	public static quaternion Euler(float x, float y, float z, RotationOrder order = 4) { }

	[Address(RVA = "0x2B24030", Offset = "0x2B23430", Length = "0x164")]
	[Token(Token = "0x6001E4F")]
	public static quaternion Euler(float3 xyz, RotationOrder order = 4) { }

	[Address(RVA = "0x2B099D0", Offset = "0x2B08DD0", Length = "0x183")]
	[Token(Token = "0x6001E43")]
	public static quaternion EulerXYZ(float3 xyz) { }

	[Address(RVA = "0x2B23D10", Offset = "0x2B23110", Length = "0x39")]
	[Token(Token = "0x6001E49")]
	public static quaternion EulerXYZ(float x, float y, float z) { }

	[Address(RVA = "0x2B09B60", Offset = "0x2B08F60", Length = "0x184")]
	[Token(Token = "0x6001E44")]
	public static quaternion EulerXZY(float3 xyz) { }

	[Address(RVA = "0x2B23D50", Offset = "0x2B23150", Length = "0x39")]
	[Token(Token = "0x6001E4A")]
	public static quaternion EulerXZY(float x, float y, float z) { }

	[Address(RVA = "0x2B23D90", Offset = "0x2B23190", Length = "0x39")]
	[Token(Token = "0x6001E4B")]
	public static quaternion EulerYXZ(float x, float y, float z) { }

	[Address(RVA = "0x2B09CF0", Offset = "0x2B090F0", Length = "0x184")]
	[Token(Token = "0x6001E45")]
	public static quaternion EulerYXZ(float3 xyz) { }

	[Address(RVA = "0x2B23DD0", Offset = "0x2B231D0", Length = "0x39")]
	[Token(Token = "0x6001E4C")]
	public static quaternion EulerYZX(float x, float y, float z) { }

	[Address(RVA = "0x2B09E80", Offset = "0x2B09280", Length = "0x174")]
	[Token(Token = "0x6001E46")]
	public static quaternion EulerYZX(float3 xyz) { }

	[Address(RVA = "0x2B0A000", Offset = "0x2B09400", Length = "0x183")]
	[Token(Token = "0x6001E47")]
	public static quaternion EulerZXY(float3 xyz) { }

	[Address(RVA = "0x2B23E10", Offset = "0x2B23210", Length = "0x39")]
	[Token(Token = "0x6001E4D")]
	public static quaternion EulerZXY(float x, float y, float z) { }

	[Address(RVA = "0x2B23E50", Offset = "0x2B23250", Length = "0x39")]
	[Token(Token = "0x6001E4E")]
	public static quaternion EulerZYX(float x, float y, float z) { }

	[Address(RVA = "0x2B0A190", Offset = "0x2B09590", Length = "0x5AA")]
	[Token(Token = "0x6001E48")]
	public static quaternion EulerZYX(float3 xyz) { }

	[Address(RVA = "0x2A3B720", Offset = "0x2A3AB20", Length = "0x4C")]
	[Token(Token = "0x6001E58")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2B24550", Offset = "0x2B23950", Length = "0x1D1")]
	[Token(Token = "0x6001E54")]
	public static quaternion LookRotation(float3 forward, float3 up) { }

	[Address(RVA = "0x2B241B0", Offset = "0x2B235B0", Length = "0x39C")]
	[Token(Token = "0x6001E55")]
	public static quaternion LookRotationSafe(float3 forward, float3 up) { }

	[Address(RVA = "0x2880350", Offset = "0x287F750", Length = "0x5CC")]
	[Token(Token = "0x6001E3C")]
	public static quaternion op_Implicit(Quaternion q) { }

	[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
	[Token(Token = "0x6001E3F")]
	public static quaternion op_Implicit(float4 v) { }

	[Address(RVA = "0x2880350", Offset = "0x287F750", Length = "0x5CC")]
	[Token(Token = "0x6001E3B")]
	public static Quaternion op_Implicit(quaternion q) { }

	[Address(RVA = "0x2B24730", Offset = "0x2B23B30", Length = "0xDA")]
	[Token(Token = "0x6001E51")]
	public static quaternion RotateX(float angle) { }

	[Address(RVA = "0x2B24810", Offset = "0x2B23C10", Length = "0xE5")]
	[Token(Token = "0x6001E52")]
	public static quaternion RotateY(float angle) { }

	[Address(RVA = "0x2B24900", Offset = "0x2B23D00", Length = "0xDE")]
	[Token(Token = "0x6001E53")]
	public static quaternion RotateZ(float angle) { }

	[Address(RVA = "0x2B24BF0", Offset = "0x2B23FF0", Length = "0x20A")]
	[Token(Token = "0x6001E5A")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x2B249E0", Offset = "0x2B23DE0", Length = "0x204")]
	[Token(Token = "0x6001E59")]
	public virtual string ToString() { }

}

