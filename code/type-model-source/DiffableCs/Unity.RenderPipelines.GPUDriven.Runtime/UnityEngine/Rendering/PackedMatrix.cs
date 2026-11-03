namespace UnityEngine.Rendering;

[Token(Token = "0x2000085")]
internal struct PackedMatrix
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400025F")]
	public float4 packed0; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000260")]
	public float4 packed1; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000261")]
	public float4 packed2; //Field offset: 0x20

	[Address(RVA = "0x2CECF30", Offset = "0x2CEC330", Length = "0xA6")]
	[Token(Token = "0x6000296")]
	public static PackedMatrix FromFloat4x4(in float4x4 m) { }

	[Address(RVA = "0x2CECF30", Offset = "0x2CEC330", Length = "0xA6")]
	[Token(Token = "0x6000295")]
	public static PackedMatrix FromMatrix4x4(in Matrix4x4 m) { }

}

