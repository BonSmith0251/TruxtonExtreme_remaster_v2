namespace UnityEngine;

[Token(Token = "0x2000154")]
public struct FrustumPlanes
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000588")]
	public float left; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000589")]
	public float right; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400058A")]
	public float bottom; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400058B")]
	public float top; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400058C")]
	public float zNear; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400058D")]
	public float zFar; //Field offset: 0x14

}

