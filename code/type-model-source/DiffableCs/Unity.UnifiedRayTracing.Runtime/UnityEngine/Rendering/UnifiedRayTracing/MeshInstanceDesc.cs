namespace UnityEngine.Rendering.UnifiedRayTracing;

[Token(Token = "0x2000050")]
public struct MeshInstanceDesc
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001CC")]
	public Mesh mesh; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001CD")]
	public int subMeshIndex; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40001CE")]
	public Matrix4x4 localToWorldMatrix; //Field offset: 0xC
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40001CF")]
	public uint mask; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001D0")]
	public uint instanceID; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40001D1")]
	public bool enableTriangleCulling; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x40001D2")]
	public bool frontTriangleCounterClockwise; //Field offset: 0x55
	[FieldOffset(Offset = "0x56")]
	[Token(Token = "0x40001D3")]
	public bool opaqueGeometry; //Field offset: 0x56

	[Address(RVA = "0x2F63640", Offset = "0x2F62A40", Length = "0x82")]
	[Token(Token = "0x600015C")]
	public MeshInstanceDesc(Mesh mesh, int subMeshIndex = 0) { }

}

