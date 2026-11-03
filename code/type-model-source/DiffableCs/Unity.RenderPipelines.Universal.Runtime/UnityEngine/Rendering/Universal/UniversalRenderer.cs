namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000CB")]
public sealed class UniversalRenderer : ScriptableRenderer
{
	[CompilerGenerated]
	[Token(Token = "0x20000D3")]
	private sealed class <>c
	{
		[Token(Token = "0x40004C5")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40004C6")]
		public static BaseRenderFunc<CopyToDebugTexturePassData, RasterGraphContext> <>9__126_0; //Field offset: 0x8
		[Token(Token = "0x40004C7")]
		public static Predicate<ScriptableRenderPass> <>9__188_0; //Field offset: 0x10

		[Address(RVA = "0x2D928F0", Offset = "0x2D91CF0", Length = "0x67")]
		[Token(Token = "0x6000593")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000594")]
		public <>c() { }

		[Address(RVA = "0x2D924A0", Offset = "0x2D918A0", Length = "0xCD")]
		[Token(Token = "0x6000595")]
		internal void <BlitEmptyTexture>b__126_0(CopyToDebugTexturePassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2D92570", Offset = "0x2D91970", Length = "0x2D")]
		[Token(Token = "0x6000596")]
		internal bool <OnAfterRendering>b__188_0(ScriptableRenderPass x) { }

	}

	[IsReadOnly]
	[Token(Token = "0x20000CE")]
	private struct ClearCameraParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B0")]
		internal readonly bool mustClearColor; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x40004B1")]
		internal readonly bool mustClearDepth; //Field offset: 0x1
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40004B2")]
		internal readonly Color clearValue; //Field offset: 0x4

		[Address(RVA = "0x2D8D6B0", Offset = "0x2D8CAB0", Length = "0xF")]
		[Token(Token = "0x6000592")]
		internal ClearCameraParams(bool clearColor, bool clearDepth, Color clearVal) { }

	}

	[Token(Token = "0x20000D1")]
	private enum ColorCopySchedule : int
	{
		AfterSkybox = 0,
		None = 1,
	}

	[Token(Token = "0x20000CD")]
	private class CopyToDebugTexturePassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40004AE")]
		internal TextureHandle src; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40004AF")]
		internal TextureHandle dest; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000591")]
		public CopyToDebugTexturePassData() { }

	}

	[Token(Token = "0x20000D0")]
	private enum DepthCopySchedule : int
	{
		DuringPrepass = 0,
		AfterPrepass = 1,
		AfterGBuffer = 2,
		AfterOpaques = 3,
		AfterSkybox = 4,
		AfterTransparents = 5,
		None = 6,
	}

	[Token(Token = "0x20000CF")]
	private enum OccluderPass : int
	{
		None = 0,
		DepthPrepass = 1,
		ForwardOpaque = 2,
		GBuffer = 3,
	}

	[Token(Token = "0x20000CC")]
	private struct RenderPassInputSummary
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004A7")]
		internal bool requiresDepthTexture; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x40004A8")]
		internal bool requiresDepthPrepass; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40004A9")]
		internal bool requiresNormalsTexture; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x40004AA")]
		internal bool requiresColorTexture; //Field offset: 0x3
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40004AB")]
		internal bool requiresMotionVectors; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40004AC")]
		internal RenderPassEvent requiresDepthNormalAtEvent; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40004AD")]
		internal RenderPassEvent requiresDepthTextureEarliestEvent; //Field offset: 0xC

	}

	[Token(Token = "0x20000D2")]
	private struct TextureCopySchedules
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004C3")]
		internal DepthCopySchedule depth; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40004C4")]
		internal ColorCopySchedule color; //Field offset: 0x4

	}

	[Token(Token = "0x400045D")]
	private const int k_FinalBlitPassQueueOffset = 1; //Field offset: 0x0
	[Token(Token = "0x400045E")]
	private const int k_AfterFinalBlitPassQueueOffset = 2; //Field offset: 0x0
	[Token(Token = "0x40004A4")]
	private const string _CameraColorAfterPostProcessingName = "_CameraColorAfterPostProcessing"; //Field offset: 0x0
	[Token(Token = "0x40004A3")]
	private const string _CameraColorUpscaled = "_CameraColorUpscaled"; //Field offset: 0x0
	[Token(Token = "0x40004A2")]
	private const string _CameraDepthAttachmentName = "_CameraDepthAttachment"; //Field offset: 0x0
	[Token(Token = "0x40004A1")]
	private const string _SingleCameraTargetAttachmentName = "_CameraTargetAttachment"; //Field offset: 0x0
	[Token(Token = "0x40004A0")]
	private const string _CameraTargetAttachmentBName = "_CameraTargetAttachmentB"; //Field offset: 0x0
	[Token(Token = "0x400049F")]
	private const string _CameraTargetAttachmentAName = "_CameraTargetAttachmentA"; //Field offset: 0x0
	[Token(Token = "0x4000492")]
	private static RTHandle[] m_RenderGraphCameraColorHandles; //Field offset: 0x0
	[Token(Token = "0x4000493")]
	private static RTHandle m_RenderGraphCameraDepthHandle; //Field offset: 0x8
	[Token(Token = "0x4000494")]
	private static int m_CurrentColorHandle; //Field offset: 0x10
	[Token(Token = "0x4000495")]
	private static RTHandle m_RenderGraphDebugTextureHandle; //Field offset: 0x18
	[Token(Token = "0x4000496")]
	private static RTHandle m_OffscreenUIColorHandle; //Field offset: 0x20
	[Token(Token = "0x40004A6")]
	private static bool m_RequiresIntermediateAttachments; //Field offset: 0x28
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400045F")]
	private DepthOnlyPass m_DepthPrepass; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000460")]
	private DepthNormalOnlyPass m_DepthNormalPrepass; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000461")]
	private MotionVectorRenderPass m_MotionVectorPass; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000462")]
	private MainLightShadowCasterPass m_MainLightShadowCasterPass; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000463")]
	private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000464")]
	private GBufferPass m_GBufferPass; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000465")]
	private DeferredPass m_DeferredPass; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000466")]
	private DrawObjectsPass m_RenderOpaqueForwardOnlyPass; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000467")]
	private DrawObjectsPass m_RenderOpaqueForwardPass; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000468")]
	private DrawObjectsWithRenderingLayersPass m_RenderOpaqueForwardWithRenderingLayersPass; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000469")]
	private DrawSkyboxPass m_DrawSkyboxPass; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400046A")]
	private CopyDepthPass m_CopyDepthPass; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400046B")]
	private CopyColorPass m_CopyColorPass; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400046C")]
	private TransparentSettingsPass m_TransparentSettingsPass; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400046D")]
	private DrawObjectsPass m_RenderTransparentForwardPass; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400046E")]
	private InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400046F")]
	private FinalBlitPass m_FinalBlitPass; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000470")]
	private FinalBlitPass m_OffscreenUICoverPrepass; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000471")]
	private CapturePass m_CapturePass; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000472")]
	private XROcclusionMeshPass m_XROcclusionMeshPass; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000473")]
	private CopyDepthPass m_XRCopyDepthPass; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000474")]
	private XRDepthMotionPass m_XRDepthMotionPass; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000475")]
	private DrawScreenSpaceUIPass m_DrawOffscreenUIPass; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000476")]
	private DrawScreenSpaceUIPass m_DrawOverlayUIPass; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000477")]
	private CopyColorPass m_HistoryRawColorCopyPass; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000478")]
	private CopyDepthPass m_HistoryRawDepthCopyPass; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000479")]
	private StencilCrossFadeRenderPass m_StencilCrossFadeRenderPass; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x400047A")]
	private RTHandle m_TargetColorHandle; //Field offset: 0x158
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x400047B")]
	private RTHandle m_TargetDepthHandle; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x400047C")]
	private ForwardLights m_ForwardLights; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x400047D")]
	private DeferredLights m_DeferredLights; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[Token(Token = "0x400047E")]
	private RenderingMode m_RenderingMode; //Field offset: 0x178
	[FieldOffset(Offset = "0x17C")]
	[Token(Token = "0x400047F")]
	private DepthPrimingMode m_DepthPrimingMode; //Field offset: 0x17C
	[FieldOffset(Offset = "0x180")]
	[Token(Token = "0x4000480")]
	private CopyDepthMode m_CopyDepthMode; //Field offset: 0x180
	[FieldOffset(Offset = "0x184")]
	[Token(Token = "0x4000481")]
	private DepthFormat m_CameraDepthAttachmentFormat; //Field offset: 0x184
	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000482")]
	private DepthFormat m_CameraDepthTextureFormat; //Field offset: 0x188
	[FieldOffset(Offset = "0x18C")]
	[Token(Token = "0x4000483")]
	private StencilState m_DefaultStencilState; //Field offset: 0x18C
	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000484")]
	private LightCookieManager m_LightCookieManager; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000485")]
	private IntermediateTextureMode m_IntermediateTextureMode; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000486")]
	private Material m_BlitMaterial; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000487")]
	private Material m_BlitHDRMaterial; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000488")]
	private Material m_SamplingMaterial; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000489")]
	private Material m_BlitOffscreenUICoverMaterial; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x400048A")]
	private Material m_StencilDeferredMaterial; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x400048B")]
	private Material m_ClusterDeferredMaterial; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x400048C")]
	private Material m_CameraMotionVecMaterial; //Field offset: 0x1D8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x400048D")]
	private LayerMask <prepassLayerMask>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x400048E")]
	private LayerMask <opaqueLayerMask>k__BackingField; //Field offset: 0x1E4
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x400048F")]
	private LayerMask <transparentLayerMask>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4000490")]
	private bool <shadowTransparentReceive>k__BackingField; //Field offset: 0x1EC
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000491")]
	private Material m_DebugBlitMaterial; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000497")]
	private bool m_RequiresRenderingLayer; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x1FC")]
	[Token(Token = "0x4000498")]
	private Event m_RenderingLayersEvent; //Field offset: 0x1FC
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000499")]
	private MaskSize m_RenderingLayersMaskSize; //Field offset: 0x200
	[FieldOffset(Offset = "0x204")]
	[Token(Token = "0x400049A")]
	private bool m_RenderingLayerProvidesRenderObjectPass; //Field offset: 0x204
	[FieldOffset(Offset = "0x205")]
	[Token(Token = "0x400049B")]
	private bool m_RenderingLayerProvidesByDepthNormalPass; //Field offset: 0x205
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x400049C")]
	private string m_RenderingLayersTextureName; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400049D")]
	private ColorGradingLutPass m_ColorGradingLutPassRenderGraph; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400049E")]
	private PostProcessPassRenderGraph m_PostProcessPassRenderGraph; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x40004A5")]
	private bool m_IssuedGPUOcclusionUnsupportedMsg; //Field offset: 0x220

	[Token(Token = "0x17000175")]
	internal bool accurateGbufferNormals
	{
		[Address(RVA = "0x2DA3720", Offset = "0x2DA2B20", Length = "0x19")]
		[Token(Token = "0x6000535")]
		internal get { } //Length: 25
	}

	[Token(Token = "0x1700017F")]
	internal GraphicsFormat cameraDepthAttachmentFormat
	{
		[Address(RVA = "0x2DA3740", Offset = "0x2DA2B40", Length = "0x5A")]
		[Token(Token = "0x6000544")]
		internal get { } //Length: 90
	}

	[Token(Token = "0x1700017E")]
	internal GraphicsFormat cameraDepthTextureFormat
	{
		[Address(RVA = "0x2DA37A0", Offset = "0x2DA2BA0", Length = "0x5A")]
		[Token(Token = "0x6000543")]
		internal get { } //Length: 90
	}

	[Token(Token = "0x17000181")]
	private RTHandle currentRenderGraphCameraColorHandle
	{
		[Address(RVA = "0x2DA3800", Offset = "0x2DA2C00", Length = "0x92")]
		[Token(Token = "0x6000561")]
		private get { } //Length: 146
	}

	[Token(Token = "0x17000179")]
	internal DeferredLights deferredLights
	{
		[Address(RVA = "0x1D4E690", Offset = "0x1D4DA90", Length = "0x8")]
		[Token(Token = "0x600053A")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000171")]
	private bool deferredModeUnsupported
	{
		[Address(RVA = "0x2DA38A0", Offset = "0x2DA2CA0", Length = "0x52")]
		[Token(Token = "0x6000531")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000177")]
	public DepthPrimingMode depthPrimingMode
	{
		[Address(RVA = "0x2DA3900", Offset = "0x2DA2D00", Length = "0x7")]
		[Token(Token = "0x6000537")]
		 get { } //Length: 7
		[Address(RVA = "0x2DA3CF0", Offset = "0x2DA30F0", Length = "0x7")]
		[Token(Token = "0x6000538")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000178")]
	internal bool isPostProcessPassRenderGraphActive
	{
		[Address(RVA = "0x2DA3910", Offset = "0x2DA2D10", Length = "0xC")]
		[Token(Token = "0x6000539")]
		internal get { } //Length: 12
	}

	[Token(Token = "0x17000176")]
	internal bool needTransparencyPass
	{
		[Address(RVA = "0x2DA3920", Offset = "0x2DA2D20", Length = "0xBD")]
		[Token(Token = "0x6000536")]
		internal get { } //Length: 189
	}

	[Token(Token = "0x17000182")]
	private RTHandle nextRenderGraphCameraColorHandle
	{
		[Address(RVA = "0x2DA39E0", Offset = "0x2DA2DE0", Length = "0x10E")]
		[Token(Token = "0x6000562")]
		private get { } //Length: 270
	}

	[Token(Token = "0x1700017B")]
	internal LayerMask opaqueLayerMask
	{
		[Address(RVA = "0x2424FA0", Offset = "0x24243A0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600053D")]
		internal get { } //Length: 7
		[Address(RVA = "0x2DA3D00", Offset = "0x2DA3100", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600053E")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700017A")]
	internal LayerMask prepassLayerMask
	{
		[Address(RVA = "0x2DA3AF0", Offset = "0x2DA2EF0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600053B")]
		internal get { } //Length: 7
		[Address(RVA = "0x2DA3D10", Offset = "0x2DA3110", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600053C")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000172")]
	internal RenderingMode renderingModeActual
	{
		[Address(RVA = "0x2DA3B00", Offset = "0x2DA2F00", Length = "0xDE")]
		[Token(Token = "0x6000532")]
		internal get { } //Length: 222
	}

	[Token(Token = "0x17000170")]
	internal RenderingMode renderingModeRequested
	{
		[Address(RVA = "0x2424D40", Offset = "0x2424140", Length = "0x7")]
		[Token(Token = "0x6000530")]
		internal get { } //Length: 7
	}

	[Token(Token = "0x1700017D")]
	internal bool shadowTransparentReceive
	{
		[Address(RVA = "0x1D17CC0", Offset = "0x1D170C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000541")]
		internal get { } //Length: 8
		[Address(RVA = "0x2DA3D20", Offset = "0x2DA3120", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000542")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000183")]
	public virtual bool supportsGPUOcclusion
	{
		[Address(RVA = "0x2DA3BE0", Offset = "0x2DA2FE0", Length = "0x87")]
		[Token(Token = "0x6000574")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000180")]
	internal virtual bool supportsNativeRenderPassRendergraphCompiler
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000557")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x1700017C")]
	internal LayerMask transparentLayerMask
	{
		[Address(RVA = "0x1DB8F60", Offset = "0x1DB8360", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600053F")]
		internal get { } //Length: 7
		[Address(RVA = "0x1DBA4F0", Offset = "0x1DB98F0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000540")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000174")]
	internal bool usesClusterLightLoop
	{
		[Address(RVA = "0x2DA3C70", Offset = "0x2DA3070", Length = "0x33")]
		[Token(Token = "0x6000534")]
		internal get { } //Length: 51
	}

	[Token(Token = "0x17000173")]
	internal bool usesDeferredLighting
	{
		[Address(RVA = "0x2DA3CB0", Offset = "0x2DA30B0", Length = "0x31")]
		[Token(Token = "0x6000533")]
		internal get { } //Length: 49
	}

	[Address(RVA = "0x2DA1EE0", Offset = "0x2DA12E0", Length = "0x7E")]
	[Token(Token = "0x6000590")]
	private static UniversalRenderer() { }

	[Address(RVA = "0x2DA1F60", Offset = "0x2DA1360", Length = "0x17BE")]
	[Token(Token = "0x6000545")]
	public UniversalRenderer(UniversalRendererData data) { }

	[Address(RVA = "0x2D95990", Offset = "0x2D94D90", Length = "0x23")]
	[Token(Token = "0x600057A")]
	private static bool AllowPartialDepthNormalsPrepass(bool isDeferred, RenderPassEvent requiresDepthNormalEvent, bool useDepthPriming) { }

	[Address(RVA = "0x2D959C0", Offset = "0x2D94DC0", Length = "0x3B7")]
	[Token(Token = "0x6000560")]
	private void BlitEmptyTexture(RenderGraph renderGraph, TextureHandle destination, string passName = "Copy To Debug Texture") { }

	[Address(RVA = "0x2D95D80", Offset = "0x2D95180", Length = "0x2DA")]
	[Token(Token = "0x600055F")]
	private void BlitToDebugTexture(RenderGraph renderGraph, TextureHandle source, TextureHandle destination, bool isSourceTextureColor = false) { }

	[Address(RVA = "0x2D96060", Offset = "0x2D95460", Length = "0x5C")]
	[Token(Token = "0x600057B")]
	private DepthCopySchedule CalculateDepthCopySchedule(RenderPassEvent earliestDepthReadEvent, bool hasFullPrepass) { }

	[Address(RVA = "0x2D960C0", Offset = "0x2D954C0", Length = "0xC2")]
	[Token(Token = "0x600057C")]
	private TextureCopySchedules CalculateTextureCopySchedules(UniversalCameraData cameraData, in RenderPassInputSummary renderPassInputs, bool isDeferred, bool requiresDepthPrepass, bool hasFullPrepass, bool requireDepthTexture) { }

	[Address(RVA = "0x2D96190", Offset = "0x2D95590", Length = "0x62")]
	[Token(Token = "0x600055A")]
	private Rect CalculateUVRect(UniversalCameraData cameraData, float width, float height) { }

	[Address(RVA = "0x2D96200", Offset = "0x2D95600", Length = "0xAD")]
	[Token(Token = "0x600055B")]
	private Rect CalculateUVRect(UniversalCameraData cameraData, int textureHeightPercent) { }

	[Address(RVA = "0x2D962B0", Offset = "0x2D956B0", Length = "0xF8")]
	[Token(Token = "0x6000556")]
	private static bool CanCopyDepth(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2D963B0", Offset = "0x2D957B0", Length = "0x16B")]
	[Token(Token = "0x6000563")]
	private void CleanupRenderGraphResources() { }

	[Address(RVA = "0x2D96520", Offset = "0x2D95920", Length = "0xE6")]
	[Token(Token = "0x600057D")]
	private void CopyDepthToDepthTexture(RenderGraph renderGraph, UniversalResourceData resourceData) { }

	[Address(RVA = "0x2D96610", Offset = "0x2D95A10", Length = "0x3B")]
	[Token(Token = "0x600055C")]
	private void CorrectForTextureAspectRatio(ref float width, ref float height, float sourceWidth, float sourceHeight) { }

	[Address(RVA = "0x2D96650", Offset = "0x2D95A50", Length = "0x2A9")]
	[Token(Token = "0x600058D")]
	private void CreateAfterPostProcessTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor) { }

	[Address(RVA = "0x2D96900", Offset = "0x2D95D00", Length = "0x24F")]
	[Token(Token = "0x6000589")]
	private void CreateCameraDepthCopyTexture(RenderGraph renderGraph, TextureDesc descriptor, bool isDepthTexture, Color clearColor) { }

	[Address(RVA = "0x2D96B50", Offset = "0x2D95F50", Length = "0x31F")]
	[Token(Token = "0x600058B")]
	private void CreateCameraNormalsTexture(RenderGraph renderGraph, TextureDesc descriptor) { }

	[Address(RVA = "0x2D96E70", Offset = "0x2D96270", Length = "0x10C")]
	[Token(Token = "0x6000559")]
	private void CreateDebugTexture(RenderTextureDescriptor descriptor) { }

	[Address(RVA = "0x2D96F80", Offset = "0x2D96380", Length = "0x4E9")]
	[Token(Token = "0x6000587")]
	private void CreateIntermediateCameraColorAttachment(RenderGraph renderGraph, UniversalCameraData cameraData, in TextureDesc cameraDescriptor, bool clearColor, Color clearBackgroundColor) { }

	[Address(RVA = "0x2D97470", Offset = "0x2D96870", Length = "0x498")]
	[Token(Token = "0x6000588")]
	private void CreateIntermediateCameraDepthAttachment(RenderGraph renderGraph, UniversalCameraData cameraData, in TextureDesc cameraDescriptor, bool clearDepth, Color clearBackgroundDepth, bool depthTextureIsDepthFormat) { }

	[Address(RVA = "0x2D97910", Offset = "0x2D96D10", Length = "0x32A")]
	[Token(Token = "0x600058A")]
	private void CreateMotionVectorTextures(RenderGraph renderGraph, TextureDesc descriptor) { }

	[Address(RVA = "0x2D97C40", Offset = "0x2D97040", Length = "0x268")]
	[Token(Token = "0x600058E")]
	private void CreateOffscreenUITexture(RenderGraph renderGraph, TextureDesc descriptor) { }

	[Address(RVA = "0x2D97EB0", Offset = "0x2D972B0", Length = "0x8FC")]
	[Token(Token = "0x600056A")]
	private void CreateRenderGraphCameraRenderTargets(RenderGraph renderGraph, bool isCameraTargetOffscreenDepth, bool requireIntermediateAttachments, bool depthTextureIsDepthFormat) { }

	[Address(RVA = "0x2D987B0", Offset = "0x2D97BB0", Length = "0x110")]
	[Token(Token = "0x6000564")]
	public static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, RenderTextureDescriptor desc, string name, bool clear, FilterMode filterMode = 0, TextureWrapMode wrapMode = 1) { }

	[Address(RVA = "0x2D988D0", Offset = "0x2D97CD0", Length = "0xF1")]
	[Token(Token = "0x6000567")]
	internal static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, in TextureDesc desc, string name, bool clear, Color clearColor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 1, bool discardOnLastUse = false) { }

	[Address(RVA = "0x2D989D0", Offset = "0x2D97DD0", Length = "0x139")]
	[Token(Token = "0x6000565")]
	internal static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, in RenderTextureDescriptor desc, string name, bool clear, Color color, FilterMode filterMode = 0, TextureWrapMode wrapMode = 1, bool discardOnLastUse = false) { }

	[Address(RVA = "0x2D98B10", Offset = "0x2D97F10", Length = "0x343")]
	[Token(Token = "0x600058C")]
	private void CreateRenderingLayersTexture(RenderGraph renderGraph, TextureDesc descriptor) { }

	[Address(RVA = "0x2D98E60", Offset = "0x2D98260", Length = "0x65")]
	[Token(Token = "0x6000558")]
	private bool DebugHandlerRequireDepthPass(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2D98ED0", Offset = "0x2D982D0", Length = "0x1AC")]
	[Token(Token = "0x600058F")]
	private void DepthNormalPrepassRender(RenderGraph renderGraph, RenderPassInputSummary renderPassInputs, in TextureHandle depthTarget, uint batchLayerMask, bool setGlobalDepth, bool setGlobalTextures, bool partialPass) { }

	[Address(RVA = "0x2D99080", Offset = "0x2D98480", Length = "0x3A4")]
	[Token(Token = "0x6000546")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2D99430", Offset = "0x2D98830", Length = "0x53")]
	[Token(Token = "0x600057F")]
	private void ExecuteScheduledDepthCopyWithMotion(RenderGraph renderGraph, UniversalResourceData resourceData, bool renderMotionVectors) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000551")]
	public virtual void FinishRendering(CommandBuffer cmd) { }

	[Address(RVA = "0x2DA3720", Offset = "0x2DA2B20", Length = "0x19")]
	[Token(Token = "0x6000535")]
	internal bool get_accurateGbufferNormals() { }

	[Address(RVA = "0x2DA3740", Offset = "0x2DA2B40", Length = "0x5A")]
	[Token(Token = "0x6000544")]
	internal GraphicsFormat get_cameraDepthAttachmentFormat() { }

	[Address(RVA = "0x2DA37A0", Offset = "0x2DA2BA0", Length = "0x5A")]
	[Token(Token = "0x6000543")]
	internal GraphicsFormat get_cameraDepthTextureFormat() { }

	[Address(RVA = "0x2DA3800", Offset = "0x2DA2C00", Length = "0x92")]
	[Token(Token = "0x6000561")]
	private RTHandle get_currentRenderGraphCameraColorHandle() { }

	[Address(RVA = "0x1D4E690", Offset = "0x1D4DA90", Length = "0x8")]
	[Token(Token = "0x600053A")]
	internal DeferredLights get_deferredLights() { }

	[Address(RVA = "0x2DA38A0", Offset = "0x2DA2CA0", Length = "0x52")]
	[Token(Token = "0x6000531")]
	private bool get_deferredModeUnsupported() { }

	[Address(RVA = "0x2DA3900", Offset = "0x2DA2D00", Length = "0x7")]
	[Token(Token = "0x6000537")]
	public DepthPrimingMode get_depthPrimingMode() { }

	[Address(RVA = "0x2DA3910", Offset = "0x2DA2D10", Length = "0xC")]
	[Token(Token = "0x6000539")]
	internal bool get_isPostProcessPassRenderGraphActive() { }

	[Address(RVA = "0x2DA3920", Offset = "0x2DA2D20", Length = "0xBD")]
	[Token(Token = "0x6000536")]
	internal bool get_needTransparencyPass() { }

	[Address(RVA = "0x2DA39E0", Offset = "0x2DA2DE0", Length = "0x10E")]
	[Token(Token = "0x6000562")]
	private RTHandle get_nextRenderGraphCameraColorHandle() { }

	[Address(RVA = "0x2424FA0", Offset = "0x24243A0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600053D")]
	internal LayerMask get_opaqueLayerMask() { }

	[Address(RVA = "0x2DA3AF0", Offset = "0x2DA2EF0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600053B")]
	internal LayerMask get_prepassLayerMask() { }

	[Address(RVA = "0x2DA3B00", Offset = "0x2DA2F00", Length = "0xDE")]
	[Token(Token = "0x6000532")]
	internal RenderingMode get_renderingModeActual() { }

	[Address(RVA = "0x2424D40", Offset = "0x2424140", Length = "0x7")]
	[Token(Token = "0x6000530")]
	internal RenderingMode get_renderingModeRequested() { }

	[Address(RVA = "0x1D17CC0", Offset = "0x1D170C0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000541")]
	internal bool get_shadowTransparentReceive() { }

	[Address(RVA = "0x2DA3BE0", Offset = "0x2DA2FE0", Length = "0x87")]
	[Token(Token = "0x6000574")]
	public virtual bool get_supportsGPUOcclusion() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000557")]
	internal virtual bool get_supportsNativeRenderPassRendergraphCompiler() { }

	[Address(RVA = "0x1DB8F60", Offset = "0x1DB8360", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600053F")]
	internal LayerMask get_transparentLayerMask() { }

	[Address(RVA = "0x2DA3C70", Offset = "0x2DA3070", Length = "0x33")]
	[Token(Token = "0x6000534")]
	internal bool get_usesClusterLightLoop() { }

	[Address(RVA = "0x2DA3CB0", Offset = "0x2DA30B0", Length = "0x31")]
	[Token(Token = "0x6000533")]
	internal bool get_usesDeferredLighting() { }

	[Address(RVA = "0x2D99490", Offset = "0x2D98890", Length = "0x1F4")]
	[Token(Token = "0x600056B")]
	private ClearCameraParams GetClearCameraParams(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2D99690", Offset = "0x2D98A90", Length = "0x232")]
	[Token(Token = "0x6000552")]
	private static RenderPassInputSummary GetRenderPassInputs(bool isTemporalAAEnabled, bool postProcessingEnabled, bool isSceneViewCamera, bool renderingLayerProvidesByDepthNormalPass, List<ScriptableRenderPass> activeRenderPassQueue, MotionVectorRenderPass motionVectorPass) { }

	[Address(RVA = "0x2D998D0", Offset = "0x2D98CD0", Length = "0x20B")]
	[Token(Token = "0x6000566")]
	internal static void GetTextureDesc(in RenderTextureDescriptor desc, out TextureDesc rgDesc) { }

	[Address(RVA = "0x2D99AE0", Offset = "0x2D98EE0", Length = "0x134")]
	[Token(Token = "0x600054D")]
	private static bool HasActiveRenderFeatures(List<ScriptableRendererFeature> rendererFeatures) { }

	[Address(RVA = "0x2D99C20", Offset = "0x2D99020", Length = "0x134")]
	[Token(Token = "0x600054E")]
	private static bool HasPassesRequiringIntermediateTexture(List<ScriptableRenderPass> activeRenderPassQueue) { }

	[Address(RVA = "0x2D99D60", Offset = "0x2D99160", Length = "0x881")]
	[Token(Token = "0x6000586")]
	private void ImportBackBuffers(RenderGraph renderGraph, UniversalCameraData cameraData, Color clearBackgroundColor, bool isCameraTargetOffscreenDepth) { }

	[Address(RVA = "0x2D9A5F0", Offset = "0x2D999F0", Length = "0x1CA")]
	[Token(Token = "0x6000578")]
	private void InstanceOcclusionTest(RenderGraph renderGraph, UniversalCameraData cameraData, OcclusionTest occlusionTest) { }

	[Address(RVA = "0x2D9A7C0", Offset = "0x2D99BC0", Length = "0x183")]
	[Token(Token = "0x6000584")]
	private static bool IsDepthPrimingEnabledRenderGraph(UniversalCameraData cameraData, in RenderPassInputSummary renderPassInputs, DepthPrimingMode depthPrimingMode, bool requireDepthTexture, bool requirePrepassForTextures, bool usesDeferredLighting) { }

	[Address(RVA = "0x2D9A950", Offset = "0x2D99D50", Length = "0x5A")]
	[Token(Token = "0x600054C")]
	private static bool IsGLDevice() { }

	[Address(RVA = "0x2D391F0", Offset = "0x2D385F0", Length = "0x16")]
	[Token(Token = "0x600054B")]
	private static bool IsGLESDevice() { }

	[Address(RVA = "0x2D9AA40", Offset = "0x2D99E40", Length = "0xF3")]
	[Token(Token = "0x6000548")]
	public static bool IsOffscreenDepthTexture(ref CameraData cameraData) { }

	[Address(RVA = "0x2D9A9B0", Offset = "0x2D99DB0", Length = "0x8B")]
	[Token(Token = "0x6000549")]
	public static bool IsOffscreenDepthTexture(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2D9AB40", Offset = "0x2D99F40", Length = "0x87")]
	[Token(Token = "0x6000555")]
	private static bool IsScalableBufferManagerUsed(UniversalCameraData cameraData) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600054A")]
	private static bool IsWebGL() { }

	[Address(RVA = "0x2D9ABD0", Offset = "0x2D99FD0", Length = "0x13F9")]
	[Token(Token = "0x6000581")]
	private void OnAfterRendering(RenderGraph renderGraph, bool applyPostProcessing) { }

	[Address(RVA = "0x2D9BFD0", Offset = "0x2D9B3D0", Length = "0x476")]
	[Token(Token = "0x6000576")]
	private void OnBeforeRendering(RenderGraph renderGraph) { }

	[Address(RVA = "0x2D9C450", Offset = "0x2D9B850", Length = "0x4E")]
	[Token(Token = "0x6000570")]
	public virtual void OnBeginRenderGraphFrame() { }

	[Address(RVA = "0x2D9C4A0", Offset = "0x2D9B8A0", Length = "0x4E")]
	[Token(Token = "0x6000572")]
	public virtual void OnEndRenderGraphFrame() { }

	[Address(RVA = "0x2D9C4F0", Offset = "0x2D9B8F0", Length = "0xA1")]
	[Token(Token = "0x6000573")]
	internal virtual void OnFinishRenderGraphRendering(CommandBuffer cmd) { }

	[Address(RVA = "0x2D9C5A0", Offset = "0x2D9B9A0", Length = "0x1B52")]
	[Token(Token = "0x6000580")]
	private void OnMainRendering(RenderGraph renderGraph, ScriptableRenderContext context, in RenderPassInputSummary renderPassInputs, bool requiresPrepass, bool requireDepthTexture) { }

	[Address(RVA = "0x2D9E100", Offset = "0x2D9D500", Length = "0x699")]
	[Token(Token = "0x6000575")]
	private void OnOffscreenDepthTextureRendering(RenderGraph renderGraph, ScriptableRenderContext context, UniversalResourceData resourceData, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2D9E7A0", Offset = "0x2D9DBA0", Length = "0x993")]
	[Token(Token = "0x6000571")]
	internal virtual void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context) { }

	[Address(RVA = "0x2D9F140", Offset = "0x2D9E540", Length = "0x64")]
	[Token(Token = "0x6000553")]
	internal static bool PlatformRequiresExplicitMsaaResolve() { }

	[Address(RVA = "0x2D9F1B0", Offset = "0x2D9E5B0", Length = "0xBF")]
	[Token(Token = "0x6000579")]
	private void RecordCustomPassesWithDepthCopyAndMotion(RenderGraph renderGraph, UniversalResourceData resourceData, RenderPassEvent earliestDepthReadEvent, RenderPassEvent currentEvent, bool renderMotionVectors) { }

	[Address(RVA = "0x2D9F270", Offset = "0x2D9E670", Length = "0x63")]
	[Token(Token = "0x6000547")]
	internal virtual void ReleaseRenderTargets() { }

	[Address(RVA = "0x2D9F2E0", Offset = "0x2D9E6E0", Length = "0xF4")]
	[Token(Token = "0x600057E")]
	private void RenderMotionVectors(RenderGraph renderGraph, UniversalResourceData resourceData) { }

	[Address(RVA = "0x2D9F3E0", Offset = "0x2D9E7E0", Length = "0x478")]
	[Token(Token = "0x600056F")]
	private void RenderRawColorDepthHistory(RenderGraph renderGraph, UniversalCameraData cameraData, UniversalResourceData resourceData) { }

	[Address(RVA = "0x2D9F860", Offset = "0x2D9EC60", Length = "0x4D")]
	[Token(Token = "0x6000583")]
	private static bool RequireDepthTexture(UniversalCameraData cameraData, in RenderPassInputSummary renderPassInputs, bool applyPostProcessing) { }

	[Address(RVA = "0x2D9F8B0", Offset = "0x2D9ECB0", Length = "0x106")]
	[Token(Token = "0x6000582")]
	private bool RequirePrepassForTextures(UniversalCameraData cameraData, in RenderPassInputSummary renderPassInputs, bool requireDepthTexture) { }

	[Address(RVA = "0x2D9F9C0", Offset = "0x2D9EDC0", Length = "0x100")]
	[Token(Token = "0x6000568")]
	private bool RequiresIntermediateAttachments(UniversalCameraData cameraData, in RenderPassInputSummary renderPassInputs, bool requireCopyFromDepth, bool applyPostProcessing) { }

	[Address(RVA = "0x2D9FAC0", Offset = "0x2D9EEC0", Length = "0x2AC")]
	[Token(Token = "0x6000554")]
	private static bool RequiresIntermediateColorTexture(UniversalCameraData cameraData, in RenderPassInputSummary renderPassInputs, bool usesDeferredLighting, bool applyPostProcessing) { }

	[Address(RVA = "0x2DA3CF0", Offset = "0x2DA30F0", Length = "0x7")]
	[Token(Token = "0x6000538")]
	public void set_depthPrimingMode(DepthPrimingMode value) { }

	[Address(RVA = "0x2DA3D00", Offset = "0x2DA3100", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600053E")]
	internal void set_opaqueLayerMask(LayerMask value) { }

	[Address(RVA = "0x2DA3D10", Offset = "0x2DA3110", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600053C")]
	internal void set_prepassLayerMask(LayerMask value) { }

	[Address(RVA = "0x2DA3D20", Offset = "0x2DA3120", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000542")]
	internal void set_shadowTransparentReceive(bool value) { }

	[Address(RVA = "0x1DBA4F0", Offset = "0x1DB98F0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6000540")]
	internal void set_transparentLayerMask(LayerMask value) { }

	[Address(RVA = "0x2D9FD70", Offset = "0x2D9F170", Length = "0x18B")]
	[Token(Token = "0x6000585")]
	internal void SetRenderingLayersGlobalTextures(RenderGraph renderGraph) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x600052A")]
	public virtual void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2D9FF00", Offset = "0x2D9F300", Length = "0x347")]
	[Token(Token = "0x600055E")]
	private void SetupAfterPostRenderGraphFinalPassDebug(RenderGraph renderGraph, ContextContainer frameData) { }

	[Address(RVA = "0x2DA0250", Offset = "0x2D9F650", Length = "0x3EB")]
	[Token(Token = "0x6000550")]
	public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x600052B")]
	public virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2DA0640", Offset = "0x2D9FA40", Length = "0x9B8")]
	[Token(Token = "0x600055D")]
	private void SetupRenderGraphFinalPassDebug(RenderGraph renderGraph, ContextContainer frameData) { }

	[Address(RVA = "0x2DA1010", Offset = "0x2DA0410", Length = "0xB8")]
	[Token(Token = "0x600056E")]
	internal void SetupRenderGraphLights(RenderGraph renderGraph, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[Address(RVA = "0x2DA10D0", Offset = "0x2DA04D0", Length = "0xAB")]
	[Token(Token = "0x600056D")]
	private void SetupRenderingLayers(int msaaSamples) { }

	[Address(RVA = "0x2DA1180", Offset = "0x2DA0580", Length = "0x478")]
	[Token(Token = "0x600056C")]
	private void SetupTargetHandles(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2DA1600", Offset = "0x2DA0A00", Length = "0x2C0")]
	[Token(Token = "0x600054F")]
	private static void SetupVFXCameraBuffer(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2DA18D0", Offset = "0x2DA0CD0", Length = "0x28")]
	[Token(Token = "0x600052C")]
	public virtual int SupportedCameraStackingTypes() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600052F")]
	protected private virtual bool SupportsCameraNormals() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600052E")]
	protected private virtual bool SupportsCameraOpaque() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x600052D")]
	protected private virtual bool SupportsMotionVectors() { }

	[Address(RVA = "0x2DA1900", Offset = "0x2DA0D00", Length = "0xBA")]
	[Token(Token = "0x6000569")]
	private void UpdateCameraHistory(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2DA19C0", Offset = "0x2DA0DC0", Length = "0x51B")]
	[Token(Token = "0x6000577")]
	private void UpdateInstanceOccluders(RenderGraph renderGraph, UniversalCameraData cameraData, TextureHandle depthTexture) { }

}

