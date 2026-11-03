namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000045")]
internal struct VertexBufferChunk
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000193")]
	public GraphicsBuffer vertices; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000194")]
	public int verticesStartOffset; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000195")]
	public uint vertexCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000196")]
	public uint vertexStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000197")]
	public int baseVertex; //Field offset: 0x14

}

