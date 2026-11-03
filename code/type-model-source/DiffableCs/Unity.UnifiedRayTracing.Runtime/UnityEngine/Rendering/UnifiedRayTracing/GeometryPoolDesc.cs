namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x200002C")]
internal struct GeometryPoolDesc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400010C")]
	public int vertexPoolByteSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400010D")]
	public int indexPoolByteSize; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400010E")]
	public int meshChunkTablesByteSize; //Field offset: 0x8

	[Address(RVA = "0x2F57180", Offset = "0x2F56580", Length = "0x18")]
	[Token(Token = "0x6000088")]
	public static GeometryPoolDesc NewDefault() { }

}

