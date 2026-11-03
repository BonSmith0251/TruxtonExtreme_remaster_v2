namespace UnityEngine.UIElements;

[Token(Token = "0x20002D9")]
internal struct UnsafeMeshGenerationNode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B97")]
	private GCHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x3406970", Offset = "0x3405D70", Length = "0x4")]
	[Token(Token = "0x60013CA")]
	internal static void Create(GCHandle handle, out UnsafeMeshGenerationNode node) { }

	[Address(RVA = "0x3410C50", Offset = "0x3410050", Length = "0x120")]
	[Token(Token = "0x60013CD")]
	internal void DrawGradientsInternal(NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, VectorImage gradientsOwner) { }

	[Address(RVA = "0x3410E80", Offset = "0x3410280", Length = "0xF5")]
	[Token(Token = "0x60013CB")]
	public void DrawMesh(NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture = null) { }

	[Address(RVA = "0x3410D80", Offset = "0x3410180", Length = "0xFE")]
	[Token(Token = "0x60013CC")]
	internal void DrawMeshInternal(NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, Texture texture = null, TextureOptions textureOptions = 0) { }

	[Address(RVA = "0x3410F80", Offset = "0x3410380", Length = "0x71")]
	[Token(Token = "0x60013C9")]
	private MeshGenerationNodeImpl GetManaged() { }

	[Address(RVA = "0x3406980", Offset = "0x3405D80", Length = "0x1E")]
	[Token(Token = "0x60013CE")]
	internal Entry GetParentEntry() { }

}

