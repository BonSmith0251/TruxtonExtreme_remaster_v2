namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200005F")]
internal sealed class Renderer2D : ScriptableRenderer
{
	[CompilerGenerated]
	[Token(Token = "0x2000062")]
	private sealed class <>c
	{
		[Token(Token = "0x400022A")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400022B")]
		public static Predicate<ScriptableRenderPass> <>9__61_0; //Field offset: 0x8

		[Address(RVA = "0x2D45740", Offset = "0x2D44B40", Length = "0x67")]
		[Token(Token = "0x6000269")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600026A")]
		public <>c() { }

		[Address(RVA = "0x2D44FF0", Offset = "0x2D443F0", Length = "0x1D")]
		[Token(Token = "0x600026B")]
		internal bool <OnAfterRendering>b__61_0(ScriptableRenderPass x) { }

	}

	[Token(Token = "0x2000061")]
	private struct ImportResourceSummary
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000224")]
		internal RenderTargetInfo importInfo; //Field offset: 0x0
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000225")]
		internal RenderTargetInfo importInfoDepth; //Field offset: 0x18
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000226")]
		internal ImportResourceParams cameraColorParams; //Field offset: 0x30
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000227")]
		internal ImportResourceParams cameraDepthParams; //Field offset: 0x4C
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000228")]
		internal ImportResourceParams backBufferColorParams; //Field offset: 0x68
		[FieldOffset(Offset = "0x84")]
		[Token(Token = "0x4000229")]
		internal ImportResourceParams backBufferDepthParams; //Field offset: 0x84

	}

	[Token(Token = "0x2000060")]
	private struct RenderPassInputSummary
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000222")]
		internal bool requiresDepthTexture; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x4000223")]
		internal bool requiresColorTexture; //Field offset: 0x1

	}

	[Token(Token = "0x4000202")]
	private const int k_FinalBlitPassQueueOffset = 1; //Field offset: 0x0
	[Token(Token = "0x4000203")]
	private const int k_AfterFinalBlitPassQueueOffset = 2; //Field offset: 0x0
	[Token(Token = "0x4000204")]
	private static int m_CurrentColorHandle; //Field offset: 0x0
	[Token(Token = "0x400020A")]
	private static RTHandle m_OffscreenUIColorHandle; //Field offset: 0x8
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000205")]
	internal RTHandle[] m_RenderGraphCameraColorHandles; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000206")]
	internal RTHandle m_RenderGraphCameraDepthHandle; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000207")]
	private RTHandle m_RenderGraphBackbufferColorHandle; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000208")]
	private RTHandle m_RenderGraphBackbufferDepthHandle; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000209")]
	private RTHandle m_CameraSortingLayerHandle; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400020B")]
	private Material m_BlitMaterial; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400020C")]
	private Material m_BlitHDRMaterial; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400020D")]
	private Material m_BlitOffscreenUICoverMaterial; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400020E")]
	private Material m_SamplingMaterial; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400020F")]
	private DrawNormal2DPass m_NormalPass; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000210")]
	private DrawLight2DPass m_LightPass; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000211")]
	private DrawShadow2DPass m_ShadowPass; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000212")]
	private DrawRenderer2DPass m_RendererPass; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000213")]
	private CopyDepthPass m_CopyDepthPass; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000214")]
	private UpscalePass m_UpscalePass; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000215")]
	private CopyCameraSortingLayerPass m_CopyCameraSortingLayerPass; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000216")]
	private FinalBlitPass m_FinalBlitPass; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000217")]
	private FinalBlitPass m_OffscreenUICoverPrepass; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000218")]
	private DrawScreenSpaceUIPass m_DrawOffscreenUIPass; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000219")]
	private DrawScreenSpaceUIPass m_DrawOverlayUIPass; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400021A")]
	private Renderer2DData m_Renderer2DData; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400021B")]
	private LayerBatch[] m_LayerBatches; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x400021C")]
	private int m_BatchCount; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[Token(Token = "0x400021D")]
	internal bool m_CreateColorTexture; //Field offset: 0x134
	[FieldOffset(Offset = "0x135")]
	[Token(Token = "0x400021E")]
	internal bool m_CreateDepthTexture; //Field offset: 0x135
	[FieldOffset(Offset = "0x136")]
	[Token(Token = "0x400021F")]
	private bool ppcUpscaleRT; //Field offset: 0x136
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000220")]
	private PostProcessPassRenderGraph m_PostProcessPassRenderGraph; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000221")]
	private ColorGradingLutPass m_ColorGradingLutPassRenderGraph; //Field offset: 0x140

	[Token(Token = "0x1700007D")]
	private RTHandle currentRenderGraphCameraColorHandle
	{
		[Address(RVA = "0x2D3BD10", Offset = "0x2D3B110", Length = "0x5D")]
		[Token(Token = "0x6000249")]
		private get { } //Length: 93
	}

	[Token(Token = "0x1700007E")]
	private RTHandle nextRenderGraphCameraColorHandle
	{
		[Address(RVA = "0x2D3BD70", Offset = "0x2D3B170", Length = "0x9C")]
		[Token(Token = "0x600024A")]
		private get { } //Length: 156
	}

	[Token(Token = "0x1700007F")]
	internal static bool supportsMRT
	{
		[Address(RVA = "0x2D3BE10", Offset = "0x2D3B210", Length = "0x16")]
		[Token(Token = "0x6000267")]
		internal get { } //Length: 22
	}

	[Token(Token = "0x17000080")]
	internal virtual bool supportsNativeRenderPassRendergraphCompiler
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000268")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x2D3B470", Offset = "0x2D3A870", Length = "0x890")]
	[Token(Token = "0x600024C")]
	public Renderer2D(Renderer2DData data) { }

	[Address(RVA = "0x2D358E0", Offset = "0x2D34CE0", Length = "0x263")]
	[Token(Token = "0x6000265")]
	private void CleanupRenderGraphResources() { }

	[Address(RVA = "0x2D35B50", Offset = "0x2D34F50", Length = "0x1B1")]
	[Token(Token = "0x6000259")]
	private void CreateCameraDepthCopyTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor) { }

	[Address(RVA = "0x2D35D10", Offset = "0x2D35110", Length = "0x425")]
	[Token(Token = "0x6000254")]
	private void CreateCameraNormalsTextures(RenderGraph renderGraph, RenderTextureDescriptor descriptor, int width, int height) { }

	[Address(RVA = "0x2D36140", Offset = "0x2D35540", Length = "0x17F")]
	[Token(Token = "0x6000257")]
	private void CreateCameraSortingLayerTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor) { }

	[Address(RVA = "0x2D362C0", Offset = "0x2D356C0", Length = "0x358")]
	[Token(Token = "0x6000255")]
	private void CreateLightTextures(RenderGraph renderGraph, int width, int height) { }

	[Address(RVA = "0x2D36620", Offset = "0x2D35A20", Length = "0x23B")]
	[Token(Token = "0x600025A")]
	private void CreateOffscreenUITexture(RenderGraph renderGraph, in RenderTextureDescriptor descriptor) { }

	[Address(RVA = "0x2D36860", Offset = "0x2D35C60", Length = "0x1543")]
	[Token(Token = "0x6000253")]
	private void CreateResources(RenderGraph renderGraph) { }

	[Address(RVA = "0x2D37DB0", Offset = "0x2D371B0", Length = "0x3AA")]
	[Token(Token = "0x6000256")]
	private void CreateShadowTextures(RenderGraph renderGraph, int width, int height) { }

	[Address(RVA = "0x2D38160", Offset = "0x2D37560", Length = "0x2F")]
	[Token(Token = "0x6000264")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2D3BD10", Offset = "0x2D3B110", Length = "0x5D")]
	[Token(Token = "0x6000249")]
	private RTHandle get_currentRenderGraphCameraColorHandle() { }

	[Address(RVA = "0x2D3BD70", Offset = "0x2D3B170", Length = "0x9C")]
	[Token(Token = "0x600024A")]
	private RTHandle get_nextRenderGraphCameraColorHandle() { }

	[Address(RVA = "0x2D3BE10", Offset = "0x2D3B210", Length = "0x16")]
	[Token(Token = "0x6000267")]
	internal static bool get_supportsMRT() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000268")]
	internal virtual bool get_supportsNativeRenderPassRendergraphCompiler() { }

	[Address(RVA = "0x2D38190", Offset = "0x2D37590", Length = "0x949")]
	[Token(Token = "0x6000250")]
	private ImportResourceSummary GetImportResourceSummary(RenderGraph renderGraph, UniversalCameraData cameraData) { }

	[Address(RVA = "0x1CF2E80", Offset = "0x1CF2280", Length = "0x8")]
	[Token(Token = "0x6000263")]
	public Renderer2DData GetRenderer2DData() { }

	[Address(RVA = "0x2D38AE0", Offset = "0x2D37EE0", Length = "0x24E")]
	[Token(Token = "0x600024F")]
	private RenderPassInputSummary GetRenderPassInputs(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2D38D30", Offset = "0x2D38130", Length = "0x3D3")]
	[Token(Token = "0x6000252")]
	private void InitializeLayerBatches() { }

	[Address(RVA = "0x2D39110", Offset = "0x2D38510", Length = "0xD5")]
	[Token(Token = "0x600024D")]
	internal static bool IsDepthUsageAllowed(ContextContainer frameData, Renderer2DData rendererData) { }

	[Address(RVA = "0x2D391F0", Offset = "0x2D385F0", Length = "0x16")]
	[Token(Token = "0x6000266")]
	internal static bool IsGLESDevice() { }

	[Address(RVA = "0x2D39210", Offset = "0x2D38610", Length = "0xCD")]
	[Token(Token = "0x600024E")]
	private bool IsPixelPerfectCameraEnabled(UniversalCameraData cameraData, out PixelPerfectCamera ppc) { }

	[Address(RVA = "0x2D392E0", Offset = "0x2D386E0", Length = "0xDA0")]
	[Token(Token = "0x6000262")]
	private void OnAfterRendering(RenderGraph renderGraph) { }

	[Address(RVA = "0x2D3A090", Offset = "0x2D39490", Length = "0x385")]
	[Token(Token = "0x6000260")]
	private void OnBeforeRendering(RenderGraph renderGraph) { }

	[Address(RVA = "0x2D3A420", Offset = "0x2D39820", Length = "0x93")]
	[Token(Token = "0x600025B")]
	public virtual void OnBeginRenderGraphFrame() { }

	[Address(RVA = "0x2D3A4C0", Offset = "0x2D398C0", Length = "0x93")]
	[Token(Token = "0x600025E")]
	public virtual void OnEndRenderGraphFrame() { }

	[Address(RVA = "0x2D3A560", Offset = "0x2D39960", Length = "0x21")]
	[Token(Token = "0x600025F")]
	internal virtual void OnFinishRenderGraphRendering(CommandBuffer cmd) { }

	[Address(RVA = "0x2D3A590", Offset = "0x2D39990", Length = "0xA51")]
	[Token(Token = "0x6000261")]
	private void OnMainRendering(RenderGraph renderGraph) { }

	[Address(RVA = "0x2D3AFF0", Offset = "0x2D3A3F0", Length = "0x14B")]
	[Token(Token = "0x600025D")]
	internal virtual void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context) { }

	[Address(RVA = "0x2D3B140", Offset = "0x2D3A540", Length = "0x173")]
	[Token(Token = "0x600025C")]
	internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, RenderPassEvent2D activeRPEvent) { }

	[Address(RVA = "0x2D3B2C0", Offset = "0x2D3A6C0", Length = "0x77")]
	[Token(Token = "0x6000258")]
	private bool RequiresDepthCopyPass(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2D3B340", Offset = "0x2D3A740", Length = "0x127")]
	[Token(Token = "0x6000251")]
	public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x600024B")]
	public virtual int SupportedCameraStackingTypes() { }

}

