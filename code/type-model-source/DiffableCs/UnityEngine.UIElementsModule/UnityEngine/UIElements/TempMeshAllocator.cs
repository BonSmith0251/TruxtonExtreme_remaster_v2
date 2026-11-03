namespace UnityEngine.UIElements;

[NativeContainer]
[NativeContainerIsReadOnly]
[Token(Token = "0x20002E1")]
public struct TempMeshAllocator
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BC0")]
	private GCHandle m_Handle; //Field offset: 0x0

	[Address(RVA = "0x340BBE0", Offset = "0x340AFE0", Length = "0xF2")]
	[Token(Token = "0x6001414")]
	public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex>& vertices, out NativeSlice<UInt16>& indices) { }

	[Address(RVA = "0x3406970", Offset = "0x3405D70", Length = "0x4")]
	[Token(Token = "0x6001413")]
	internal static void Create(GCHandle handle, out TempMeshAllocator allocator) { }

}

