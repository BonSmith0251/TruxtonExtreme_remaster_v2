namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000075")]
internal class ShadowMesh2D : ShadowShape2D
{
	[Token(Token = "0x2000076")]
	internal enum EdgeProcessing : int
	{
		None = 0,
		Clipping = 1,
	}

	[Token(Token = "0x400027F")]
	internal const int k_CapsuleCapSegments = 8; //Field offset: 0x0
	[Token(Token = "0x4000280")]
	internal const float k_TrimEdgeUninitialized = -1; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000281")]
	private Mesh m_Mesh; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000282")]
	private Bounds m_LocalBounds; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000283")]
	private EdgeProcessing m_EdgeProcessing; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000284")]
	private float m_TrimEdge; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000285")]
	private bool m_FlipX; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[SerializeField]
	[Token(Token = "0x4000286")]
	private bool m_FlipY; //Field offset: 0x39
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000287")]
	private float m_InitialTrim; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000288")]
	internal BoundingSphere m_BoundingSphere; //Field offset: 0x40

	[Token(Token = "0x17000092")]
	public BoundingSphere boundingSphere
	{
		[Address(RVA = "0x1116930", Offset = "0x1115D30", Length = "0xB")]
		[Token(Token = "0x60002D0")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000093")]
	public EdgeProcessing edgeProcessing
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60002D1")]
		 get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[Token(Token = "0x60002D2")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000091")]
	public Mesh mesh
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60002CF")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000094")]
	public float trimEdge
	{
		[Address(RVA = "0x1BBC130", Offset = "0x1BBB530", Length = "0x6")]
		[Token(Token = "0x60002D3")]
		 get { } //Length: 6
		[Address(RVA = "0x1BBC1D0", Offset = "0x1BBB5D0", Length = "0x6")]
		[Token(Token = "0x60002D4")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x2D3FC80", Offset = "0x2D3F080", Length = "0x15")]
	[Token(Token = "0x60002E3")]
	public ShadowMesh2D() { }

	[Address(RVA = "0x2D3E220", Offset = "0x2D3D620", Length = "0x233")]
	[Token(Token = "0x60002D9")]
	internal void AddCapsule(Vector3 pt0, Vector3 pt1, float r0, float r1, NativeArray<Vector3> generatedVertices, NativeArray<Int32> generatedIndices, bool reverseWindingOrder, ref int vertexWritePos, ref int indexWritePos) { }

	[Address(RVA = "0x2D3DEE0", Offset = "0x2D3D2E0", Length = "0x331")]
	[Token(Token = "0x60002D8")]
	internal void AddCapsuleCap(Vector3 center, float r, Vector3 otherCenter, NativeArray<Vector3> generatedVertices, NativeArray<Int32> generatedIndices, bool reverseWindingOrder, ref int vertexWritePos, ref int indexWritePos) { }

	[Address(RVA = "0x2D3E460", Offset = "0x2D3D860", Length = "0x1AD")]
	[Token(Token = "0x60002D7")]
	internal void AddCircle(Vector3 center, float r, NativeArray<Vector3> generatedVertices, NativeArray<Int32> generatedIndices, bool reverseWindingOrder, ref int vertexWritePos, ref int indexWritePos) { }

	[Address(RVA = "0x2D3E610", Offset = "0x2D3DA10", Length = "0x15F")]
	[Token(Token = "0x60002DA")]
	internal int AddShape(NativeArray<Vector3> vertices, NativeArray<Int32> indices, int indicesProcessed, NativeArray<Vector3> generatedVertices, NativeArray<Int32> generatedIndices, ref int vertexWritePos, ref int indexWritePos) { }

	[Address(RVA = "0x2D3E770", Offset = "0x2D3DB70", Length = "0x64")]
	[Token(Token = "0x60002DC")]
	private bool AreDegenerateVertices(NativeArray<Vector3> vertices) { }

	[Address(RVA = "0x2D3E7E0", Offset = "0x2D3DBE0", Length = "0x1AE")]
	[Token(Token = "0x60002D6")]
	internal void CopyFrom(ShadowMesh2D source) { }

	[Address(RVA = "0x2D3E990", Offset = "0x2D3DD90", Length = "0x15E")]
	[Token(Token = "0x60002D5")]
	internal static void DuplicateShadowMesh(Mesh source, out Mesh dest) { }

	[Address(RVA = "0x1116930", Offset = "0x1115D30", Length = "0xB")]
	[Token(Token = "0x60002D0")]
	public BoundingSphere get_boundingSphere() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60002D1")]
	public EdgeProcessing get_edgeProcessing() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60002CF")]
	public Mesh get_mesh() { }

	[Address(RVA = "0x1BBC130", Offset = "0x1BBB530", Length = "0x6")]
	[Token(Token = "0x60002D3")]
	public float get_trimEdge() { }

	[Address(RVA = "0x2D3EAF0", Offset = "0x2D3DEF0", Length = "0xE")]
	[Token(Token = "0x60002E0")]
	public virtual void GetFlip(out bool flipX, out bool flipY) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[Token(Token = "0x60002D2")]
	public void set_edgeProcessing(EdgeProcessing value) { }

	[Address(RVA = "0x1BBC1D0", Offset = "0x1BBB5D0", Length = "0x6")]
	[Token(Token = "0x60002D4")]
	public void set_trimEdge(float value) { }

	[Address(RVA = "0x29EA3D0", Offset = "0x29E97D0", Length = "0x6")]
	[Token(Token = "0x60002E1")]
	public virtual void SetDefaultTrim(float trim) { }

	[Address(RVA = "0x2D3EB00", Offset = "0x2D3DF00", Length = "0x8")]
	[Token(Token = "0x60002DF")]
	public virtual void SetFlip(bool flipX, bool flipY) { }

	[Address(RVA = "0x2D3EB70", Offset = "0x2D3DF70", Length = "0xA9F")]
	[Token(Token = "0x60002DB")]
	public virtual void SetShape(NativeArray<Vector3> vertices, NativeArray<Int32> indices, NativeArray<Single> radii, Matrix4x4 transform, WindingOrder windingOrder = 0, bool allowTriming = true, bool createInteriorGeometry = false) { }

	[Address(RVA = "0x2D3F610", Offset = "0x2D3EA10", Length = "0x4B5")]
	[Token(Token = "0x60002DD")]
	public virtual void SetShape(NativeArray<Vector3> vertices, NativeArray<Int32> indices, OutlineTopology outlineTopology, WindingOrder windingOrder = 0, bool allowTrimming = true, bool createInteriorGeometry = false) { }

	[Address(RVA = "0x2D3EB10", Offset = "0x2D3DF10", Length = "0x52")]
	[Token(Token = "0x60002DE")]
	public void SetShapeWithLines(NativeArray<Vector3> vertices, NativeArray<Int32> indices, bool allowTrimming) { }

	[Address(RVA = "0x2D3FAD0", Offset = "0x2D3EED0", Length = "0x1A2")]
	[Token(Token = "0x60002E2")]
	public void UpdateBoundingSphere(Transform transform) { }

}

