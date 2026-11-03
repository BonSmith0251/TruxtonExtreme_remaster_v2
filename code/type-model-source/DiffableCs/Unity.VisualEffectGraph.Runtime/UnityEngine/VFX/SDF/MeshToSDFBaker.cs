namespace UnityEngine.VFX.SDF;

[Token(Token = "0x200003B")]
public class MeshToSDFBaker : IDisposable
{
	[Token(Token = "0x200003D")]
	public class Kernels
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000133")]
		internal int inBucketSum; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000134")]
		internal int blockSums; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000135")]
		internal int finalSum; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000136")]
		internal int toTextureNormalized; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000137")]
		internal int copyTextures; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000138")]
		internal int jfa; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000139")]
		internal int distanceTransform; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400013A")]
		internal int copyBuffers; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400013B")]
		internal int generateRayMapLocal; //Field offset: 0x30
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x400013C")]
		internal int rayMapScanX; //Field offset: 0x34
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400013D")]
		internal int rayMapScanY; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400013E")]
		internal int rayMapScanZ; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400013F")]
		internal int signPass6Rays; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000140")]
		internal int signPassNeighbors; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000141")]
		internal int toBlockSumBuffer; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000142")]
		internal int clearTexturesAndBuffers; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000143")]
		internal int copyToBuffer; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000144")]
		internal int generateTrianglesUV; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000145")]
		internal int conservativeRasterization; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4000146")]
		internal int chooseDirectionTriangleOnly; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000147")]
		internal int surfaceClosing; //Field offset: 0x60

		[Address(RVA = "0x2F65E20", Offset = "0x2F65220", Length = "0x353")]
		[Token(Token = "0x60000EC")]
		internal Kernels(ComputeShader computeShader) { }

	}

	[Token(Token = "0x200003C")]
	private static class ShaderProperties
	{
		[Token(Token = "0x4000101")]
		internal static int indicesBuffer; //Field offset: 0x0
		[Token(Token = "0x4000102")]
		internal static int verticesBuffer; //Field offset: 0x4
		[Token(Token = "0x4000103")]
		internal static int vertexPositionOffset; //Field offset: 0x8
		[Token(Token = "0x4000104")]
		internal static int vertexStride; //Field offset: 0xC
		[Token(Token = "0x4000105")]
		internal static int indexStride; //Field offset: 0x10
		[Token(Token = "0x4000106")]
		internal static int coordFlipBuffer; //Field offset: 0x14
		[Token(Token = "0x4000107")]
		internal static int verticesOutBuffer; //Field offset: 0x18
		[Token(Token = "0x4000108")]
		internal static int aabbBuffer; //Field offset: 0x1C
		[Token(Token = "0x4000109")]
		internal static int worldToClip; //Field offset: 0x20
		[Token(Token = "0x400010A")]
		internal static int currentAxis; //Field offset: 0x24
		[Token(Token = "0x400010B")]
		internal static int voxelsBuffer; //Field offset: 0x28
		[Token(Token = "0x400010C")]
		internal static int rw_trianglesUV; //Field offset: 0x2C
		[Token(Token = "0x400010D")]
		internal static int trianglesUV; //Field offset: 0x30
		[Token(Token = "0x400010E")]
		internal static int voxelsTexture; //Field offset: 0x34
		[Token(Token = "0x400010F")]
		internal static int voxelsTmpTexture; //Field offset: 0x38
		[Token(Token = "0x4000110")]
		internal static int rayMap; //Field offset: 0x3C
		[Token(Token = "0x4000111")]
		internal static int rayMapTmp; //Field offset: 0x40
		[Token(Token = "0x4000112")]
		internal static int rw_rayMapTmp; //Field offset: 0x44
		[Token(Token = "0x4000113")]
		internal static int nTriangles; //Field offset: 0x48
		[Token(Token = "0x4000114")]
		internal static int minBoundsExtended; //Field offset: 0x4C
		[Token(Token = "0x4000115")]
		internal static int maxBoundsExtended; //Field offset: 0x50
		[Token(Token = "0x4000116")]
		internal static int maxExtent; //Field offset: 0x54
		[Token(Token = "0x4000117")]
		internal static int upperBoundCount; //Field offset: 0x58
		[Token(Token = "0x4000118")]
		internal static int counter; //Field offset: 0x5C
		[Token(Token = "0x4000119")]
		internal static int dimX; //Field offset: 0x60
		[Token(Token = "0x400011A")]
		internal static int dimY; //Field offset: 0x64
		[Token(Token = "0x400011B")]
		internal static int dimZ; //Field offset: 0x68
		[Token(Token = "0x400011C")]
		internal static int size; //Field offset: 0x6C
		[Token(Token = "0x400011D")]
		internal static int inputBuffer; //Field offset: 0x70
		[Token(Token = "0x400011E")]
		internal static int inputCounter; //Field offset: 0x74
		[Token(Token = "0x400011F")]
		internal static int auxBuffer; //Field offset: 0x78
		[Token(Token = "0x4000120")]
		internal static int resultBuffer; //Field offset: 0x7C
		[Token(Token = "0x4000121")]
		internal static int numElem; //Field offset: 0x80
		[Token(Token = "0x4000122")]
		internal static int exclusive; //Field offset: 0x84
		[Token(Token = "0x4000123")]
		internal static int dispatchWidth; //Field offset: 0x88
		[Token(Token = "0x4000124")]
		internal static int src; //Field offset: 0x8C
		[Token(Token = "0x4000125")]
		internal static int dest; //Field offset: 0x90
		[Token(Token = "0x4000126")]
		internal static int signMap; //Field offset: 0x94
		[Token(Token = "0x4000127")]
		internal static int threshold; //Field offset: 0x98
		[Token(Token = "0x4000128")]
		internal static int signMapTmp; //Field offset: 0x9C
		[Token(Token = "0x4000129")]
		internal static int normalizeFactor; //Field offset: 0xA0
		[Token(Token = "0x400012A")]
		internal static int numNeighbours; //Field offset: 0xA4
		[Token(Token = "0x400012B")]
		internal static int passId; //Field offset: 0xA8
		[Token(Token = "0x400012C")]
		internal static int needNormalize; //Field offset: 0xAC
		[Token(Token = "0x400012D")]
		internal static int offset; //Field offset: 0xB0
		[Token(Token = "0x400012E")]
		internal static int offsetRayMap; //Field offset: 0xB4
		[Token(Token = "0x400012F")]
		internal static int triangleIDs; //Field offset: 0xB8
		[Token(Token = "0x4000130")]
		internal static int accumCounter; //Field offset: 0xBC
		[Token(Token = "0x4000131")]
		internal static int distanceTexture; //Field offset: 0xC0
		[Token(Token = "0x4000132")]
		internal static int sdfOffset; //Field offset: 0xC4

		[Address(RVA = "0x2F701C0", Offset = "0x2F6F5C0", Length = "0x8C4")]
		[Token(Token = "0x60000EB")]
		private static ShaderProperties() { }

	}

	[Token(Token = "0x40000FD")]
	internal static uint kMaxRecommandedGridSize; //Field offset: 0x0
	[Token(Token = "0x40000FE")]
	internal static uint kMaxAbsoluteGridSize; //Field offset: 0x4
	[Token(Token = "0x40000FF")]
	private static int kNbActualRT; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000CD")]
	private RenderTexture[] m_RayMaps; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000CE")]
	private RenderTexture[] m_SignMaps; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000CF")]
	private RenderTexture[] m_RenderTextureViews; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000D0")]
	private GraphicsBuffer m_CounterBuffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000D1")]
	private GraphicsBuffer m_AccumCounterBuffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000D2")]
	private GraphicsBuffer m_TrianglesInVoxels; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000D3")]
	private GraphicsBuffer m_TrianglesUV; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40000D4")]
	private GraphicsBuffer m_TmpBuffer; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40000D5")]
	private GraphicsBuffer m_AccumSumBlocks; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40000D6")]
	private GraphicsBuffer m_SumBlocksBuffer; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40000D7")]
	private GraphicsBuffer m_InSumBlocksBuffer; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000D8")]
	private GraphicsBuffer m_SumBlocksAdditional; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000D9")]
	private GraphicsBuffer m_IndicesBuffer; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000DA")]
	private GraphicsBuffer m_VerticesBuffer; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40000DB")]
	private GraphicsBuffer m_VerticesOutBuffer; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40000DC")]
	private GraphicsBuffer m_CoordFlipBuffer; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000DD")]
	private GraphicsBuffer m_AabbBuffer; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000DE")]
	private int m_VertexBufferOffset; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40000DF")]
	private int m_ThreadGroupSize; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000E0")]
	private int m_SignPassesCount; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40000E1")]
	private float m_InOutThreshold; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000E2")]
	private Material[] m_Material; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40000E3")]
	private Matrix4x4[] m_WorldToClip; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40000E4")]
	private Matrix4x4[] m_ProjMat; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40000E5")]
	private Matrix4x4[] m_ViewMat; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40000E6")]
	private int m_nStepsJFA; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40000E7")]
	private Kernels m_Kernels; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40000E8")]
	private Mesh m_Mesh; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40000E9")]
	private bool m_OwnsMesh; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40000EA")]
	private RenderTexture m_textureVoxel; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40000EB")]
	private RenderTexture m_textureVoxelBis; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x40000EC")]
	private RenderTexture m_DistanceTexture; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40000ED")]
	private GraphicsBuffer m_bufferVoxel; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40000EE")]
	private ComputeShader m_computeShader; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x40000EF")]
	private int m_maxResolution; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x40000F0")]
	private float m_MaxExtent; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40000F1")]
	private float m_SdfOffset; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x40000F2")]
	private int nTriangles; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40000F3")]
	private Vector3 m_SizeBox; //Field offset: 0x120
	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x40000F4")]
	private Vector3 m_Center; //Field offset: 0x12C
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40000F5")]
	private CommandBuffer m_Cmd; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40000F6")]
	private bool m_OwnsCommandBuffer; //Field offset: 0x140
	[FieldOffset(Offset = "0x141")]
	[Token(Token = "0x40000F7")]
	private bool m_IsDisposed; //Field offset: 0x141
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40000F8")]
	private Int32[] m_Dimensions; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40000F9")]
	private Int32[] m_OffsetRayMap; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40000FA")]
	private Single[] m_MinBoundsExtended; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40000FB")]
	private Single[] m_MaxBoundsExtended; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40000FC")]
	private int m_RayMapUseCounter; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x4000100")]
	internal VFXRuntimeResources m_RuntimeResources; //Field offset: 0x170

	[Token(Token = "0x1700001C")]
	public RenderTexture SdfTexture
	{
		[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
		[Token(Token = "0x60000B9")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x2F6FAB0", Offset = "0x2F6EEB0", Length = "0x63")]
	[Token(Token = "0x60000EA")]
	private static MeshToSDFBaker() { }

	[Address(RVA = "0x2F6FD20", Offset = "0x2F6F120", Length = "0x394")]
	[Token(Token = "0x60000C0")]
	private MeshToSDFBaker(Vector3 sizeBox, Vector3 center, int maxRes, Mesh mesh, bool ownsMesh, int signPassesCount, float threshold, float sdfOffset, CommandBuffer cmd) { }

	[Address(RVA = "0x2F6FB20", Offset = "0x2F6EF20", Length = "0x93")]
	[Token(Token = "0x60000C1")]
	public MeshToSDFBaker(Vector3 sizeBox, Vector3 center, int maxRes, Mesh mesh, int signPassesCount = 1, float threshold = 0.5, float sdfOffset = 0, CommandBuffer cmd = null) { }

	[Address(RVA = "0x2F6FBC0", Offset = "0x2F6EFC0", Length = "0x159")]
	[Token(Token = "0x60000C2")]
	public MeshToSDFBaker(Vector3 sizeBox, Vector3 center, int maxRes, List<Mesh> meshes, List<Matrix4x4> transforms, int signPassesCount = 1, float threshold = 0.5, float sdfOffset = 0, CommandBuffer cmd = null) { }

	[Address(RVA = "0x2F66470", Offset = "0x2F65870", Length = "0x3E0")]
	[Token(Token = "0x60000DA")]
	public void BakeSDF() { }

	[Address(RVA = "0x2F66860", Offset = "0x2F65C60", Length = "0xADB")]
	[Token(Token = "0x60000DE")]
	private void BuildGeometry() { }

	[Address(RVA = "0x2F67340", Offset = "0x2F66740", Length = "0x75B")]
	[Token(Token = "0x60000E1")]
	private void ClearRenderTexturesAndBuffers() { }

	[Address(RVA = "0x2F67AA0", Offset = "0x2F66EA0", Length = "0x24C")]
	[Token(Token = "0x60000CC")]
	private Matrix4x4 ComputeOrthographicWorldToClip(Vector3 pos, Quaternion rot, float width, float height, float near, float far, out Matrix4x4 proj, out Matrix4x4 view) { }

	[Address(RVA = "0x2F67CF0", Offset = "0x2F670F0", Length = "0xEF")]
	[Token(Token = "0x60000E6")]
	private void CreateGraphicsBufferIfNeeded(ref GraphicsBuffer gb, int length, int stride) { }

	[Address(RVA = "0x2F67DE0", Offset = "0x2F671E0", Length = "0x1C1")]
	[Token(Token = "0x60000E8")]
	private void CreateRenderTextureIfNeeded(ref RenderTexture rt, RenderTextureDescriptor rtDesc) { }

	[Address(RVA = "0x2F67FB0", Offset = "0x2F673B0", Length = "0x65")]
	[Token(Token = "0x60000E5")]
	public override void Dispose() { }

	[Address(RVA = "0x2F68020", Offset = "0x2F67420", Length = "0xA3")]
	[Token(Token = "0x60000C3")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2F680D0", Offset = "0x2F674D0", Length = "0x677")]
	[Token(Token = "0x60000DC")]
	private void FirstDraw() { }

	[Address(RVA = "0x2F68750", Offset = "0x2F67B50", Length = "0xE96")]
	[Token(Token = "0x60000D4")]
	private void GenerateRayMap() { }

	[Address(RVA = "0xE7D7F0", Offset = "0xE7CBF0", Length = "0x8")]
	[Token(Token = "0x60000B9")]
	public RenderTexture get_SdfTexture() { }

	[Address(RVA = "0x2F695F0", Offset = "0x2F689F0", Length = "0x19")]
	[Token(Token = "0x60000BF")]
	public Vector3 GetActualBoxSize() { }

	[Address(RVA = "0x2F69610", Offset = "0x2F68A10", Length = "0x4F")]
	[Token(Token = "0x60000BE")]
	public Vector3Int GetGridSize() { }

	[Address(RVA = "0x2F69660", Offset = "0x2F68A60", Length = "0x3B")]
	[Token(Token = "0x60000D6")]
	private RenderTexture GetRayMapBis(int step) { }

	[Address(RVA = "0x2F696A0", Offset = "0x2F68AA0", Length = "0x3A")]
	[Token(Token = "0x60000D5")]
	private RenderTexture GetRayMapPrincipal(int step) { }

	[Address(RVA = "0x2F696E0", Offset = "0x2F68AE0", Length = "0x3B")]
	[Token(Token = "0x60000D8")]
	private RenderTexture GetSignMapBis(int step) { }

	[Address(RVA = "0x2F69720", Offset = "0x2F68B20", Length = "0x3A")]
	[Token(Token = "0x60000D7")]
	private RenderTexture GetSignMapPrincipal(int step) { }

	[Address(RVA = "0x2F69760", Offset = "0x2F68B60", Length = "0x15")]
	[Token(Token = "0x60000D2")]
	private RenderTexture GetTextureVoxelBis(int step) { }

	[Address(RVA = "0x2F69780", Offset = "0x2F68B80", Length = "0x15")]
	[Token(Token = "0x60000D1")]
	private RenderTexture GetTextureVoxelPrincipal(int step) { }

	[Address(RVA = "0x2F697A0", Offset = "0x2F68BA0", Length = "0x70")]
	[Token(Token = "0x60000CE")]
	private Vector2Int GetThreadGroupsCount(int nbThreads, int threadCountPerGroup) { }

	[Address(RVA = "0x2F69810", Offset = "0x2F68C10", Length = "0x4B")]
	[Token(Token = "0x60000BC")]
	private int GetTotalVoxelCount() { }

	[Address(RVA = "0x2F700C0", Offset = "0x2F6F4C0", Length = "0xF")]
	[Token(Token = "0x60000CD")]
	private int iDivUp(int a, int b) { }

	[Address(RVA = "0x2F6AEB0", Offset = "0x2F6A2B0", Length = "0x7E1")]
	[Token(Token = "0x60000CA")]
	private void Init() { }

	[Address(RVA = "0x2F69860", Offset = "0x2F68C60", Length = "0x96")]
	[Token(Token = "0x60000BB")]
	private void InitCommandBuffer() { }

	[Address(RVA = "0x2F69900", Offset = "0x2F68D00", Length = "0xC1")]
	[Token(Token = "0x60000DF")]
	private void InitGeometryBuffers(int upperBoundCount) { }

	[Address(RVA = "0x2F699D0", Offset = "0x2F68DD0", Length = "0x1D4")]
	[Token(Token = "0x60000DB")]
	private void InitMeshBuffers() { }

	[Address(RVA = "0x2F69BB0", Offset = "0x2F68FB0", Length = "0x344")]
	[Token(Token = "0x60000BA")]
	private static Mesh InitMeshFromList(List<Mesh> meshes, List<Matrix4x4> transforms) { }

	[Address(RVA = "0x2F69F00", Offset = "0x2F69300", Length = "0x41D")]
	[Token(Token = "0x60000E0")]
	private void InitPrefixSumBuffers() { }

	[Address(RVA = "0x2F6A320", Offset = "0x2F69720", Length = "0x690")]
	[Token(Token = "0x60000BD")]
	private void InitSizeBox() { }

	[Address(RVA = "0x2F6A9C0", Offset = "0x2F69DC0", Length = "0x4EE")]
	[Token(Token = "0x60000C9")]
	private void InitTextures() { }

	[Address(RVA = "0x2F6B6A0", Offset = "0x2F6AAA0", Length = "0xDBD")]
	[Token(Token = "0x60000D3")]
	private void JFA() { }

	[Address(RVA = "0x2F6C460", Offset = "0x2F6B860", Length = "0x181")]
	[Token(Token = "0x60000C8")]
	private void LoadRuntimeResources() { }

	[Address(RVA = "0x2F6C5F0", Offset = "0x2F6B9F0", Length = "0x626")]
	[Token(Token = "0x60000E2")]
	private void PerformDistanceTransformWinding() { }

	[Address(RVA = "0x2F6CC20", Offset = "0x2F6C020", Length = "0xD46")]
	[Token(Token = "0x60000CF")]
	private void PrefixSumCount() { }

	[Address(RVA = "0x2F6D970", Offset = "0x2F6CD70", Length = "0x10B")]
	[Token(Token = "0x60000C5")]
	public void Reinit(Vector3 sizeBox, Vector3 center, int maxRes, Mesh mesh, int signPassesCount = 1, float threshold = 0.5, float sdfOffset = 0) { }

	[Address(RVA = "0x2F6DB90", Offset = "0x2F6CF90", Length = "0x1B7")]
	[Token(Token = "0x60000C6")]
	public void Reinit(Vector3 sizeBox, Vector3 center, int maxRes, List<Mesh> meshes, List<Matrix4x4> transforms, int signPassesCount = 1, float threshold = 0.5, float sdfOffset = 0) { }

	[Address(RVA = "0x2F6DA80", Offset = "0x2F6CE80", Length = "0x10F")]
	[Token(Token = "0x60000C4")]
	private void Reinit(Vector3 sizeBox, Vector3 center, int maxRes, Mesh mesh, bool ownsMesh, int signPassesCount = 1, float threshold = 0.5, float sdfOffset = 0) { }

	[Address(RVA = "0x2F6DD50", Offset = "0x2F6D150", Length = "0x3F3")]
	[Token(Token = "0x60000E4")]
	private void ReleaseBuffersAndTextures() { }

	[Address(RVA = "0x2F6E150", Offset = "0x2F6D550", Length = "0x2F")]
	[Token(Token = "0x60000E7")]
	private void ReleaseGraphicsBuffer(ref GraphicsBuffer gb) { }

	[Address(RVA = "0x2F6E180", Offset = "0x2F6D580", Length = "0xFB")]
	[Token(Token = "0x60000E3")]
	private void ReleaseMeshIfOwned() { }

	[Address(RVA = "0x2F6E280", Offset = "0x2F6D680", Length = "0xE9")]
	[Token(Token = "0x60000E9")]
	private void ReleaseRenderTexture(ref RenderTexture rt) { }

	[Address(RVA = "0x2F6E370", Offset = "0x2F6D770", Length = "0x448")]
	[Token(Token = "0x60000DD")]
	private void SecondDraw() { }

	[Address(RVA = "0x2F6E7C0", Offset = "0x2F6DBC0", Length = "0xBD")]
	[Token(Token = "0x60000C7")]
	private void SetParameters(Vector3 sizeBox, Vector3 center, int maxRes, int signPassesCount, float threshold, float sdfOffset) { }

	[Address(RVA = "0x2F6E880", Offset = "0x2F6DC80", Length = "0x8D6")]
	[Token(Token = "0x60000D9")]
	private void SignPass() { }

	[Address(RVA = "0x2F6F160", Offset = "0x2F6E560", Length = "0x3AF")]
	[Token(Token = "0x60000D0")]
	private void SurfaceClosing() { }

	[Address(RVA = "0x2F6F510", Offset = "0x2F6E910", Length = "0x598")]
	[Token(Token = "0x60000CB")]
	private void UpdateCameras() { }

}

