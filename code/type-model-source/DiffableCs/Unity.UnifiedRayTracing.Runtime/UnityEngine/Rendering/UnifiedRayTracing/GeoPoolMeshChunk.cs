namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000039")]
internal struct GeoPoolMeshChunk
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400016E")]
	public int indexOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400016F")]
	public int indexCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000170")]
	public int vertexOffset; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000171")]
	public int vertexCount; //Field offset: 0xC

}

