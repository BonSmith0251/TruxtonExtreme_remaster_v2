namespace TMPro;

[Token(Token = "0x200007C")]
public struct TMP_MeshInfo
{
	[Token(Token = "0x400033F")]
	private static readonly Color32 s_DefaultColor; //Field offset: 0x0
	[Token(Token = "0x4000340")]
	private static readonly Vector3 s_DefaultNormal; //Field offset: 0x4
	[Token(Token = "0x4000341")]
	private static readonly Vector4 s_DefaultTangent; //Field offset: 0x10
	[Token(Token = "0x4000342")]
	private static readonly Bounds s_DefaultBounds; //Field offset: 0x20
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000343")]
	public Mesh mesh; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000344")]
	public int vertexCount; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000345")]
	public Vector3[] vertices; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000346")]
	public Vector3[] normals; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000347")]
	public Vector4[] tangents; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000348")]
	public Vector4[] uvs0; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000349")]
	public Vector2[] uvs2; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400034A")]
	public Color32[] colors32; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400034B")]
	public Int32[] triangles; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400034C")]
	public Material material; //Field offset: 0x48

	[Address(RVA = "0x2F0C6A0", Offset = "0x2F0BAA0", Length = "0x9F")]
	[Token(Token = "0x6000438")]
	private static TMP_MeshInfo() { }

	[Address(RVA = "0x2F0C740", Offset = "0x2F0BB40", Length = "0x64D")]
	[Token(Token = "0x600042C")]
	public TMP_MeshInfo(Mesh mesh, int size) { }

	[Address(RVA = "0x2F0CD90", Offset = "0x2F0C190", Length = "0xAF3")]
	[Token(Token = "0x600042D")]
	public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric) { }

	[Address(RVA = "0x2F0AA30", Offset = "0x2F09E30", Length = "0xA0")]
	[Token(Token = "0x6000430")]
	public void Clear() { }

	[Address(RVA = "0x2F0AAE0", Offset = "0x2F09EE0", Length = "0x131")]
	[Token(Token = "0x6000431")]
	public void Clear(bool uploadChanges) { }

	[Address(RVA = "0x2F0A9F0", Offset = "0x2F09DF0", Length = "0x37")]
	[Token(Token = "0x6000432")]
	public void ClearUnusedVertices() { }

	[Address(RVA = "0x2F0A900", Offset = "0x2F09D00", Length = "0x33")]
	[Token(Token = "0x6000433")]
	public void ClearUnusedVertices(int startIndex) { }

	[Address(RVA = "0x2F0A940", Offset = "0x2F09D40", Length = "0xAE")]
	[Token(Token = "0x6000434")]
	public void ClearUnusedVertices(int startIndex, bool updateMesh) { }

	[Address(RVA = "0x2F0AC20", Offset = "0x2F0A020", Length = "0x50A")]
	[Token(Token = "0x600042E")]
	public void ResizeMeshInfo(int size) { }

	[Address(RVA = "0x2F0B130", Offset = "0x2F0A530", Length = "0xB63")]
	[Token(Token = "0x600042F")]
	public void ResizeMeshInfo(int size, bool isVolumetric) { }

	[Address(RVA = "0x2F0BCA0", Offset = "0x2F0B0A0", Length = "0xAA")]
	[Token(Token = "0x6000435")]
	public void SortGeometry(VertexSortingOrder order) { }

	[Address(RVA = "0x2F0BD50", Offset = "0x2F0B150", Length = "0x190")]
	[Token(Token = "0x6000436")]
	public void SortGeometry(IList<Int32> sortingOrder) { }

	[Address(RVA = "0x2F0BEF0", Offset = "0x2F0B2F0", Length = "0x7A9")]
	[Token(Token = "0x6000437")]
	public void SwapVertexData(int src, int dst) { }

}

