namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001F2")]
public struct PreTile
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000ABA")]
	public float4 planeLeft; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000ABB")]
	public float4 planeRight; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000ABC")]
	public float4 planeBottom; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000ABD")]
	public float4 planeTop; //Field offset: 0x30

}

