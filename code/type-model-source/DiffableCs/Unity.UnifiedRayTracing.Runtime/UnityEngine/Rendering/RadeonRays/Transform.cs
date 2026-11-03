namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x2000018")]
internal struct Transform
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000065")]
	public float4 row0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000066")]
	public float4 row1; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000067")]
	public float4 row2; //Field offset: 0x20

	[Address(RVA = "0x1311590", Offset = "0x1310990", Length = "0x17")]
	[Token(Token = "0x6000031")]
	public Transform(float4 row0, float4 row1, float4 row2) { }

	[Address(RVA = "0x2F613D0", Offset = "0x2F607D0", Length = "0x27")]
	[Token(Token = "0x6000032")]
	public static Transform Identity() { }

	[Address(RVA = "0x2F61400", Offset = "0x2F60800", Length = "0x368")]
	[Token(Token = "0x6000036")]
	public Transform Inverse() { }

	[Address(RVA = "0x2F61770", Offset = "0x2F60B70", Length = "0x7D")]
	[Token(Token = "0x6000034")]
	public static Transform Scale(float3 scale) { }

	[Address(RVA = "0x2F619C0", Offset = "0x2F60DC0", Length = "0x85")]
	[Token(Token = "0x6000033")]
	public static Transform Translation(float3 translation) { }

	[Address(RVA = "0x2F617F0", Offset = "0x2F60BF0", Length = "0x1C1")]
	[Token(Token = "0x6000035")]
	public static Transform TRS(float3 translation, float3 rotation, float3 scale) { }

}

