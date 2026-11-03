namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000030")]
internal struct GeometryPoolEntryDesc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000115")]
	public Mesh mesh; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000116")]
	public GeometryPoolSubmeshData[] submeshData; //Field offset: 0x8

}

