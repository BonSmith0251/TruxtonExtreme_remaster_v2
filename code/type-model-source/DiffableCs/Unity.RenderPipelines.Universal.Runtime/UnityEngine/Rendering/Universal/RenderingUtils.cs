namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000193")]
public static class RenderingUtils
{
	[Token(Token = "0x40008DE")]
	private static List<ShaderTagId> m_LegacyShaderPassNames; //Field offset: 0x0
	[Token(Token = "0x40008DF")]
	private static AttachmentDescriptor s_EmptyAttachment; //Field offset: 0x8
	[Token(Token = "0x40008E0")]
	private static Mesh s_FullscreenMesh; //Field offset: 0x80
	[Token(Token = "0x40008E1")]
	private static Material s_ErrorMaterial; //Field offset: 0x88
	[Token(Token = "0x40008E2")]
	private static ShaderTagId[] s_ShaderTagValues; //Field offset: 0x90
	[Token(Token = "0x40008E3")]
	private static RenderStateBlock[] s_RenderStateBlocks; //Field offset: 0x98
	[Token(Token = "0x40008E4")]
	private static Dictionary<RenderTextureFormat, Boolean> m_RenderTextureFormatSupport; //Field offset: 0xA0

	[Token(Token = "0x170001E8")]
	internal static AttachmentDescriptor emptyAttachment
	{
		[Address(RVA = "0x2DD7AA0", Offset = "0x2DD6EA0", Length = "0x95")]
		[Token(Token = "0x600084F")]
		internal get { } //Length: 149
	}

	[Token(Token = "0x170001EB")]
	private static Material errorMaterial
	{
		[Address(RVA = "0x2DD7B40", Offset = "0x2DD6F40", Length = "0x150")]
		[Token(Token = "0x6000853")]
		private get { } //Length: 336
	}

	[Obsolete("Use Blitter.BlitCameraTexture instead of CommandBuffer.DrawMesh(fullscreenMesh, ...). #from(2022.2)")]
	[Token(Token = "0x170001E9")]
	public static Mesh fullscreenMesh
	{
		[Address(RVA = "0x2DD7C90", Offset = "0x2DD7090", Length = "0x58C")]
		[Token(Token = "0x6000850")]
		 get { } //Length: 1420
	}

	[Token(Token = "0x170001EA")]
	internal static bool useStructuredBuffer
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000851")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x2DD7540", Offset = "0x2DD6940", Length = "0x555")]
	[Token(Token = "0x6000882")]
	private static RenderingUtils() { }

	[Address(RVA = "0x2DD06D0", Offset = "0x2DCFAD0", Length = "0xC5")]
	[Token(Token = "0x6000879")]
	internal static void AddStaleResourceToPoolOrRelease(TextureDesc desc, RTHandle handle) { }

	[Address(RVA = "0x2DD07A0", Offset = "0x2DCFBA0", Length = "0x214")]
	[Token(Token = "0x6000858")]
	internal static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0) { }

	[Address(RVA = "0x2DD09C0", Offset = "0x2DCFDC0", Length = "0x23A")]
	[Token(Token = "0x6000859")]
	internal static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destinationColor, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle destinationDepthStencil, RenderBufferLoadAction depthStencilLoadAction, RenderBufferStoreAction depthStencilStoreAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0) { }

	[Address(RVA = "0x2DD0C00", Offset = "0x2DD0000", Length = "0x73")]
	[Token(Token = "0x6000861")]
	internal static void ClearSystemInfoCache() { }

	[Address(RVA = "0x2DD0C80", Offset = "0x2DD0080", Length = "0x12D")]
	[Token(Token = "0x6000867")]
	internal static bool Contains(RenderTargetIdentifier[] source, RenderTargetIdentifier value) { }

	[Address(RVA = "0x1F1C710", Offset = "0x1F1BB10", Length = "0x8")]
	[Token(Token = "0x600086C")]
	internal static bool Contains(ClearFlag a, ClearFlag b) { }

	[Address(RVA = "0x2DD0DB0", Offset = "0x2DD01B0", Length = "0x22E")]
	[Token(Token = "0x600086A")]
	internal static uint CountDistinct(RTHandle[] source, RTHandle value) { }

	[Address(RVA = "0x2DD15C0", Offset = "0x2DD09C0", Length = "0x4CA")]
	[Token(Token = "0x600087C")]
	public static DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	[Address(RVA = "0x2DD0FE0", Offset = "0x2DD03E0", Length = "0x245")]
	[Token(Token = "0x600087B")]
	public static DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria) { }

	[Address(RVA = "0x2DD1230", Offset = "0x2DD0630", Length = "0x390")]
	[Token(Token = "0x600087D")]
	public static DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, SortingCriteria sortingCriteria) { }

	[Address(RVA = "0x2DD1A90", Offset = "0x2DD0E90", Length = "0x19A")]
	[Token(Token = "0x600087A")]
	public static DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	[Address(RVA = "0x2DD1E00", Offset = "0x2DD1200", Length = "0x12E")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600085C")]
	internal static void CreateRendererListObjectsWithError(ScriptableRenderContext context, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags, ref RendererList rl) { }

	[Address(RVA = "0x2DD1CF0", Offset = "0x2DD10F0", Length = "0x108")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600085D")]
	internal static void CreateRendererListObjectsWithError(RenderGraph renderGraph, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags, ref RendererListHandle rl) { }

	[Address(RVA = "0x2DD2370", Offset = "0x2DD1770", Length = "0x35A")]
	[Token(Token = "0x600085F")]
	internal static void CreateRendererListWithRenderStateBlock(ScriptableRenderContext context, ref CullingResults cullResults, DrawingSettings ds, FilteringSettings fs, RenderStateBlock rsb, ref RendererList rl) { }

	[Address(RVA = "0x2DD1F30", Offset = "0x2DD1330", Length = "0x437")]
	[Token(Token = "0x6000860")]
	internal static void CreateRendererListWithRenderStateBlock(RenderGraph renderGraph, ref CullingResults cullResults, DrawingSettings ds, FilteringSettings fs, RenderStateBlock rsb, ref RendererListHandle rl) { }

	[Address(RVA = "0x2DD26D0", Offset = "0x2DD1AD0", Length = "0x47B")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600085B")]
	internal static void CreateRendererParamsObjectsWithError(ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags, ref RendererListParams param) { }

	[Address(RVA = "0x2DD1C30", Offset = "0x2DD1030", Length = "0xC0")]
	[Token(Token = "0x6000881")]
	internal static RTHandleAllocInfo CreateRTHandleAllocInfo(in TextureDesc descriptor, string name) { }

	[Address(RVA = "0x2DC9460", Offset = "0x2DC8860", Length = "0x280")]
	[Token(Token = "0x6000880")]
	internal static RTHandleAllocInfo CreateRTHandleAllocInfo(in RenderTextureDescriptor descriptor, FilterMode filterMode, TextureWrapMode wrapMode, int anisoLevel, float mipMapBias, string name) { }

	[Address(RVA = "0x2DD2B50", Offset = "0x2DD1F50", Length = "0x33")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600085E")]
	internal static void DrawRendererListObjectsWithError(RasterCommandBuffer cmd, ref RendererList rl) { }

	[Address(RVA = "0x2DD2B90", Offset = "0x2DD1F90", Length = "0x650")]
	[Token(Token = "0x600085A")]
	internal static void FinalBlit(CommandBuffer cmd, UniversalCameraData cameraData, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int passIndex) { }

	[Address(RVA = "0x2DD7AA0", Offset = "0x2DD6EA0", Length = "0x95")]
	[Token(Token = "0x600084F")]
	internal static AttachmentDescriptor get_emptyAttachment() { }

	[Address(RVA = "0x2DD7B40", Offset = "0x2DD6F40", Length = "0x150")]
	[Token(Token = "0x6000853")]
	private static Material get_errorMaterial() { }

	[Address(RVA = "0x2DD7C90", Offset = "0x2DD7090", Length = "0x58C")]
	[Token(Token = "0x6000850")]
	public static Mesh get_fullscreenMesh() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000851")]
	internal static bool get_useStructuredBuffer() { }

	[Address(RVA = "0x2DD31F0", Offset = "0x2DD25F0", Length = "0x242")]
	[Token(Token = "0x6000870")]
	internal static RenderTargetIdentifier GetCameraTargetIdentifier(ref RenderingData renderingData) { }

	[Address(RVA = "0x2DD3440", Offset = "0x2DD2840", Length = "0x1B1")]
	[Token(Token = "0x600087F")]
	internal static Vector4 GetFinalBlitScaleBias(in RasterGraphContext renderGraphContext, in TextureHandle source, in TextureHandle destination) { }

	[Address(RVA = "0x2DD3600", Offset = "0x2DD2A00", Length = "0x149")]
	[Token(Token = "0x6000864")]
	internal static int GetLastValidColorBufferIndex(RenderTargetIdentifier[] colorBuffers) { }

	[Address(RVA = "0x2DD3750", Offset = "0x2DD2B50", Length = "0x144")]
	[Token(Token = "0x6000865")]
	internal static uint GetValidColorBufferCount(RTHandle[] colorBuffers) { }

	[Address(RVA = "0x2DD3A40", Offset = "0x2DD2E40", Length = "0x140")]
	[Token(Token = "0x6000868")]
	internal static int IndexOf(RTHandle[] source, RenderTargetIdentifier value) { }

	[Address(RVA = "0x2DD38A0", Offset = "0x2DD2CA0", Length = "0x19B")]
	[Token(Token = "0x6000869")]
	internal static int IndexOf(RTHandle[] source, RTHandle value) { }

	[Address(RVA = "0x2DD3B90", Offset = "0x2DD2F90", Length = "0x5F")]
	[Token(Token = "0x600087E")]
	internal static bool IsHandleYFlipped(in RasterGraphContext renderGraphContext, in TextureHandle textureHandle) { }

	[Address(RVA = "0x2DD3BF0", Offset = "0x2DD2FF0", Length = "0x178")]
	[Token(Token = "0x6000866")]
	internal static bool IsMRT(RTHandle[] colorBuffers) { }

	[Address(RVA = "0x2DD3D70", Offset = "0x2DD3170", Length = "0x15A")]
	[Token(Token = "0x600086B")]
	internal static int LastValid(RTHandle[] source) { }

	[Address(RVA = "0x2DD3ED0", Offset = "0x2DD32D0", Length = "0x7E")]
	[Token(Token = "0x600086E")]
	internal static bool MultisampleDepthResolveSupported() { }

	[Address(RVA = "0x2DD5330", Offset = "0x2DD4730", Length = "0x5B8")]
	[Token(Token = "0x6000877")]
	public static bool ReAllocateHandleIfNeeded(ref RTHandle handle, ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[Address(RVA = "0x2DD4300", Offset = "0x2DD3700", Length = "0x59F")]
	[Token(Token = "0x6000876")]
	public static bool ReAllocateHandleIfNeeded(ref RTHandle handle, Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[Address(RVA = "0x2DD4E10", Offset = "0x2DD4210", Length = "0x51E")]
	[Token(Token = "0x6000874")]
	public static bool ReAllocateHandleIfNeeded(ref RTHandle handle, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[Address(RVA = "0x2DD48A0", Offset = "0x2DD3CA0", Length = "0x564")]
	[Token(Token = "0x6000875")]
	public static bool ReAllocateHandleIfNeeded(ref RTHandle handle, TextureDesc descriptor, string name) { }

	[Address(RVA = "0x2DD58F0", Offset = "0x2DD4CF0", Length = "0x564")]
	[Obsolete("This method will be removed in a future release. Please use ReAllocateHandleIfNeeded instead. #from(2023.3)")]
	[Token(Token = "0x6000873")]
	public static bool ReAllocateIfNeeded(ref RTHandle handle, ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[Address(RVA = "0x2DD6320", Offset = "0x2DD5720", Length = "0x54E")]
	[Obsolete("This method will be removed in a future release. Please use ReAllocateHandleIfNeeded instead. #from(2023.3)")]
	[Token(Token = "0x6000872")]
	public static bool ReAllocateIfNeeded(ref RTHandle handle, Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[Address(RVA = "0x2DD5E60", Offset = "0x2DD5260", Length = "0x4BF")]
	[Obsolete("This method will be removed in a future release. Please use ReAllocateHandleIfNeeded instead. #from(2023.3)")]
	[Token(Token = "0x6000871")]
	public static bool ReAllocateIfNeeded(ref RTHandle handle, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[Address(RVA = "0x2DD3F50", Offset = "0x2DD3350", Length = "0x3A0")]
	[Token(Token = "0x600086F")]
	internal static bool RTHandleNeedsReAlloc(RTHandle handle, in TextureDesc descriptor, bool scaled) { }

	[Address(RVA = "0x2DD6870", Offset = "0x2DD5C70", Length = "0x283")]
	[Token(Token = "0x600086D")]
	internal static bool SequenceEqual(RTHandle[] left, RTHandle[] right) { }

	[Address(RVA = "0x2DD6B00", Offset = "0x2DD5F00", Length = "0x92")]
	[Token(Token = "0x6000878")]
	public static bool SetMaxRTHandlePoolCapacity(int capacity) { }

	[Address(RVA = "0x2DD6BA0", Offset = "0x2DD5FA0", Length = "0x1F4")]
	[Token(Token = "0x6000856")]
	internal static void SetScaleBiasRt(RasterCommandBuffer cmd, in UniversalCameraData cameraData, RTHandle rTHandle) { }

	[Address(RVA = "0x2DD72A0", Offset = "0x2DD66A0", Length = "0x174")]
	[Token(Token = "0x6000857")]
	internal static void SetupOffscreenUIViewportParams(Material material, ref Rect pixelRect, bool isRenderToBackBufferTarget) { }

	[Address(RVA = "0x2DD6DA0", Offset = "0x2DD61A0", Length = "0x3EA")]
	[Token(Token = "0x6000855")]
	public static void SetViewAndProjectionMatrices(RasterCommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices) { }

	[Address(RVA = "0x2DD7190", Offset = "0x2DD6590", Length = "0x10A")]
	[Token(Token = "0x6000854")]
	public static void SetViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices) { }

	[Address(RVA = "0x2DD7420", Offset = "0x2DD6820", Length = "0x1D")]
	[Obsolete("Use SystemInfo.IsFormatSupported instead. #from(2023.2)")]
	[Token(Token = "0x6000863")]
	public static bool SupportsGraphicsFormat(GraphicsFormat format, FormatUsage usage) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000852")]
	internal static bool SupportsLightLayers(GraphicsDeviceType type) { }

	[Address(RVA = "0x2DD7440", Offset = "0x2DD6840", Length = "0xF1")]
	[Token(Token = "0x6000862")]
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

}

