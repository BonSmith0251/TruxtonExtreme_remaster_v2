namespace UnityEngine;

[Token(Token = "0x2000010")]
[UsedByNativeCode]
public struct UIVertex
{
	[Token(Token = "0x4000054")]
	private static readonly Color32 s_DefaultColor; //Field offset: 0x0
	[Token(Token = "0x4000055")]
	private static readonly Vector4 s_DefaultTangent; //Field offset: 0x4
	[Token(Token = "0x4000056")]
	public static UIVertex simpleVert; //Field offset: 0x14
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400004C")]
	public Vector3 position; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400004D")]
	public Vector3 normal; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004E")]
	public Vector4 tangent; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400004F")]
	public Color32 color; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000050")]
	public Vector4 uv0; //Field offset: 0x2C
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000051")]
	public Vector4 uv1; //Field offset: 0x3C
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000052")]
	public Vector4 uv2; //Field offset: 0x4C
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000053")]
	public Vector4 uv3; //Field offset: 0x5C

	[Address(RVA = "0x31CF100", Offset = "0x31CE500", Length = "0x221")]
	[Token(Token = "0x600005A")]
	private static UIVertex() { }

}

