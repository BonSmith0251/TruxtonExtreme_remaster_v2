namespace UnityEngine.Rendering;

[Token(Token = "0x20000AE")]
internal struct OccluderContext : IDisposable
{
	[Token(Token = "0x20000AF")]
	private static class ShaderIDs
	{
		[Token(Token = "0x4000346")]
		public static readonly int _SrcDepth; //Field offset: 0x0
		[Token(Token = "0x4000347")]
		public static readonly int _DstDepth; //Field offset: 0x4
		[Token(Token = "0x4000348")]
		public static readonly int OccluderDepthPyramidConstants; //Field offset: 0x8

		[Address(RVA = "0x2D02770", Offset = "0x2D01B70", Length = "0xA5")]
		[Token(Token = "0x600030E")]
		private static ShaderIDs() { }

	}

	[Token(Token = "0x4000335")]
	public const int k_FirstDepthMipIndex = 3; //Field offset: 0x0
	[Token(Token = "0x4000336")]
	public const int k_MaxOccluderMips = 8; //Field offset: 0x0
	[Token(Token = "0x4000337")]
	public const int k_MaxSilhouettePlanes = 6; //Field offset: 0x0
	[Token(Token = "0x4000338")]
	public const int k_MaxSubviewsPerView = 6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000339")]
	public int version; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400033A")]
	public Vector2Int depthBufferSize; //Field offset: 0x4
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400033B")]
	public NativeArray<OccluderDerivedData> subviewData; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400033C")]
	public int subviewValidMask; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400033D")]
	public NativeArray<OccluderMipBounds> occluderMipBounds; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400033E")]
	public Vector2Int occluderMipLayoutSize; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400033F")]
	public Vector2Int occluderDepthPyramidSize; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000340")]
	public RTHandle occluderDepthPyramid; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000341")]
	public int occlusionDebugOverlaySize; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000342")]
	public GraphicsBuffer occlusionDebugOverlay; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000343")]
	public bool debugNeedsClear; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000344")]
	public ComputeBuffer constantBuffer; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000345")]
	public NativeArray<OccluderDepthPyramidConstants> constantBufferData; //Field offset: 0x70

	[Token(Token = "0x17000051")]
	public Vector2 depthBufferSizeInOccluderPixels
	{
		[Address(RVA = "0x2CF92E0", Offset = "0x2CF86E0", Length = "0x29")]
		[Token(Token = "0x6000304")]
		 get { } //Length: 41
	}

	[Token(Token = "0x17000050")]
	public int subviewCount
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000302")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2CF7D40", Offset = "0x2CF7140", Length = "0x2F4")]
	[Token(Token = "0x6000307")]
	private void AllocateTexturesIfNecessary(bool debugOverlayEnabled) { }

	[Address(RVA = "0x2CF8040", Offset = "0x2CF7440", Length = "0x5D5")]
	[Token(Token = "0x600030A")]
	public void CreateFarDepthPyramid(ComputeCommandBuffer cmd, in OccluderParameters occluderParams, ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates, in OccluderHandles occluderHandles, NativeArray<Plane> silhouettePlanes, ComputeShader occluderDepthPyramidCS, int occluderDepthDownscaleKernel) { }

	[Address(RVA = "0x2CF8620", Offset = "0x2CF7A20", Length = "0x120")]
	[Token(Token = "0x6000305")]
	public override void Dispose() { }

	[Address(RVA = "0x2CF92E0", Offset = "0x2CF86E0", Length = "0x29")]
	[Token(Token = "0x6000304")]
	public Vector2 get_depthBufferSizeInOccluderPixels() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000302")]
	public int get_subviewCount() { }

	[Address(RVA = "0x2CF8740", Offset = "0x2CF7B40", Length = "0x180")]
	[Token(Token = "0x600030D")]
	internal OcclusionCullingDebugOutput GetDebugOutput() { }

	[Address(RVA = "0x2CF88C0", Offset = "0x2CF7CC0", Length = "0x166")]
	[Token(Token = "0x600030B")]
	public OccluderHandles Import(RenderGraph renderGraph) { }

	[Address(RVA = "0x2CF8A30", Offset = "0x2CF7E30", Length = "0x20")]
	[Token(Token = "0x6000303")]
	public bool IsSubviewValid(int subviewIndex) { }

	[Address(RVA = "0x2CF8A50", Offset = "0x2CF7E50", Length = "0xE3")]
	[Token(Token = "0x600030C")]
	public void PrepareOccluders(in OccluderParameters occluderParams) { }

	[Address(RVA = "0x2CF8B40", Offset = "0x2CF7F40", Length = "0x2B")]
	[Token(Token = "0x6000308")]
	internal static void SetKeyword(ComputeCommandBuffer cmd, ComputeShader cs, in LocalKeyword keyword, bool value) { }

	[Address(RVA = "0x2CF8B70", Offset = "0x2CF7F70", Length = "0x50E")]
	[Token(Token = "0x6000309")]
	private OccluderDepthPyramidConstants SetupFarDepthPyramidConstants(ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates, NativeArray<Plane> silhouettePlanes) { }

	[Address(RVA = "0x2CF9080", Offset = "0x2CF8480", Length = "0x257")]
	[Token(Token = "0x6000306")]
	private void UpdateMipBounds() { }

}

