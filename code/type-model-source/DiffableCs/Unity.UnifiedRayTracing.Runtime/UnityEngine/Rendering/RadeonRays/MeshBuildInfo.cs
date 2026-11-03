namespace UnityEngine.Rendering.RadeonRays;

[Token(Token = "0x2000011")]
internal struct MeshBuildInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000047")]
	public GraphicsBuffer vertices; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000048")]
	public int verticesStartOffset; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000049")]
	public uint vertexCount; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004A")]
	public uint vertexStride; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400004B")]
	public int baseVertex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004C")]
	public GraphicsBuffer triangleIndices; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004D")]
	public int indicesStartOffset; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400004E")]
	public int baseIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400004F")]
	public IndexFormat indexFormat; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000050")]
	public uint triangleCount; //Field offset: 0x2C

}

