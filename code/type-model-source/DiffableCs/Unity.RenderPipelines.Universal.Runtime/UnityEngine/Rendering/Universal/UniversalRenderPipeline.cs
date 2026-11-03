namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20001E0")]
public sealed class UniversalRenderPipeline : RenderPipeline
{
	[CompilerGenerated]
	[Token(Token = "0x20001EA")]
	private sealed class <>c
	{
		[Token(Token = "0x4000AA4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000AA5")]
		public static Comparison<Camera> <>9__52_0; //Field offset: 0x8

		[Address(RVA = "0x2E0B050", Offset = "0x2E0A450", Length = "0x67")]
		[Token(Token = "0x6000A88")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A89")]
		public <>c() { }

		[Address(RVA = "0x2E0ABF0", Offset = "0x2E09FF0", Length = "0x39B")]
		[Token(Token = "0x6000A8B")]
		internal void <.cctor>b__132_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }

		[Address(RVA = "0x2E0AF90", Offset = "0x2E0A390", Length = "0x4C")]
		[Token(Token = "0x6000A8A")]
		internal int <.ctor>b__52_0(Camera camera1, Camera camera2) { }

	}

	[Token(Token = "0x20001E1")]
	public static class CameraMetadataCache
	{
		[Token(Token = "0x20001E2")]
		internal class CameraMetadataCacheEntry
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000A87")]
			public ProfilingSampler sampler; //Field offset: 0x10

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000A7D")]
			public CameraMetadataCacheEntry() { }

		}

		[Token(Token = "0x4000A85")]
		private static Dictionary<Int32, CameraMetadataCacheEntry> s_MetadataCache; //Field offset: 0x0
		[Token(Token = "0x4000A86")]
		private static readonly CameraMetadataCacheEntry k_NoAllocEntry; //Field offset: 0x8

		[Address(RVA = "0x2DFDD30", Offset = "0x2DFD130", Length = "0x131")]
		[Token(Token = "0x6000A7C")]
		private static CameraMetadataCache() { }

		[Address(RVA = "0x2DFDB70", Offset = "0x2DFCF70", Length = "0x1B9")]
		[Token(Token = "0x6000A7B")]
		public static CameraMetadataCacheEntry GetCached(Camera camera) { }

	}

	[IsReadOnly]
	[Token(Token = "0x20001E7")]
	private struct CameraRenderingScope : IDisposable
	{
		[Token(Token = "0x4000A98")]
		private static readonly ProfilingSampler beginCameraRenderingSampler; //Field offset: 0x0
		[Token(Token = "0x4000A99")]
		private static readonly ProfilingSampler endCameraRenderingSampler; //Field offset: 0x8
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A9A")]
		private readonly ScriptableRenderContext m_Context; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A9B")]
		private readonly Camera m_Camera; //Field offset: 0x8

		[Address(RVA = "0x2DFDF30", Offset = "0x2DFD330", Length = "0xE0")]
		[Token(Token = "0x6000A83")]
		private static CameraRenderingScope() { }

		[Address(RVA = "0x2DFE010", Offset = "0x2DFD410", Length = "0xDD")]
		[Token(Token = "0x6000A81")]
		public CameraRenderingScope(ScriptableRenderContext context, Camera camera) { }

		[Address(RVA = "0x2DFDE70", Offset = "0x2DFD270", Length = "0xB3")]
		[Token(Token = "0x6000A82")]
		public override void Dispose() { }

	}

	[IsReadOnly]
	[Token(Token = "0x20001E8")]
	private struct ContextRenderingScope : IDisposable
	{
		[Token(Token = "0x4000A9C")]
		private static readonly ProfilingSampler beginContextRenderingSampler; //Field offset: 0x0
		[Token(Token = "0x4000A9D")]
		private static readonly ProfilingSampler endContextRenderingSampler; //Field offset: 0x8
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A9E")]
		private readonly ScriptableRenderContext m_Context; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A9F")]
		private readonly List<Camera> m_Cameras; //Field offset: 0x8

		[Address(RVA = "0x2DFE880", Offset = "0x2DFDC80", Length = "0xE0")]
		[Token(Token = "0x6000A86")]
		private static ContextRenderingScope() { }

		[Address(RVA = "0x2DFE960", Offset = "0x2DFDD60", Length = "0xDE")]
		[Token(Token = "0x6000A84")]
		public ContextRenderingScope(ScriptableRenderContext context, List<Camera> cameras) { }

		[Address(RVA = "0x2DFE7C0", Offset = "0x2DFDBC0", Length = "0xB3")]
		[Token(Token = "0x6000A85")]
		public override void Dispose() { }

	}

	[Token(Token = "0x20001E3")]
	public static class Profiling
	{
		[Token(Token = "0x20001E4")]
		internal static class Pipeline
		{
			[Token(Token = "0x20001E6")]
			internal static class Context
			{
				[Token(Token = "0x4000A96")]
				private const string k_Name = "ScriptableRenderContext"; //Field offset: 0x0
				[Token(Token = "0x4000A97")]
				public static readonly ProfilingSampler submit; //Field offset: 0x0

				[Address(RVA = "0x2DFEA40", Offset = "0x2DFDE40", Length = "0x87")]
				[Token(Token = "0x6000A80")]
				private static Context() { }

			}

			[Token(Token = "0x20001E5")]
			internal static class Renderer
			{
				[Token(Token = "0x4000A94")]
				private const string k_Name = "ScriptableRenderer"; //Field offset: 0x0
				[Token(Token = "0x4000A95")]
				public static readonly ProfilingSampler setupCullingParameters; //Field offset: 0x0

				[Address(RVA = "0x2E08810", Offset = "0x2E07C10", Length = "0x87")]
				[Token(Token = "0x6000A7F")]
				private static Renderer() { }

			}

			[Token(Token = "0x4000A88")]
			private const string k_Name = "UniversalRenderPipeline"; //Field offset: 0x0
			[Token(Token = "0x4000A89")]
			public static readonly ProfilingSampler initializeCameraData; //Field offset: 0x0
			[Token(Token = "0x4000A8A")]
			public static readonly ProfilingSampler initializeStackedCameraData; //Field offset: 0x8
			[Token(Token = "0x4000A8B")]
			public static readonly ProfilingSampler initializeAdditionalCameraData; //Field offset: 0x10
			[Token(Token = "0x4000A8C")]
			public static readonly ProfilingSampler initializeRenderingData; //Field offset: 0x18
			[Token(Token = "0x4000A8D")]
			public static readonly ProfilingSampler initializeShadowData; //Field offset: 0x20
			[Token(Token = "0x4000A8E")]
			public static readonly ProfilingSampler initializeLightData; //Field offset: 0x28
			[Token(Token = "0x4000A8F")]
			public static readonly ProfilingSampler buildAdditionalLightsShadowAtlasLayout; //Field offset: 0x30
			[Token(Token = "0x4000A90")]
			public static readonly ProfilingSampler getPerObjectLightFlags; //Field offset: 0x38
			[Token(Token = "0x4000A91")]
			public static readonly ProfilingSampler getMainLightIndex; //Field offset: 0x40
			[Token(Token = "0x4000A92")]
			public static readonly ProfilingSampler setupPerFrameShaderConstants; //Field offset: 0x48
			[Token(Token = "0x4000A93")]
			public static readonly ProfilingSampler setupPerCameraShaderConstants; //Field offset: 0x50

			[Address(RVA = "0x2E07580", Offset = "0x2E06980", Length = "0x405")]
			[Token(Token = "0x6000A7E")]
			private static Pipeline() { }

		}


	}

	[Token(Token = "0x20001E9")]
	internal class SingleCameraRequest
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AA0")]
		public RenderTexture destination; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AA1")]
		public int mipLevel; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000AA2")]
		public CubemapFace face; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AA3")]
		public int slice; //Field offset: 0x20

		[Address(RVA = "0x2E0AB40", Offset = "0x2E09F40", Length = "0xE")]
		[Token(Token = "0x6000A87")]
		public SingleCameraRequest() { }

	}

	[Token(Token = "0x4000A6B")]
	public const string k_ShaderTagName = "UniversalPipeline"; //Field offset: 0x0
	[Token(Token = "0x4000A6C")]
	internal const int k_DefaultRenderingLayerMask = 1; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x4000A70")]
	private static RenderTextureUVOriginStrategy <renderTextureUVOriginStrategy>k__BackingField; //Field offset: 0x0
	[Token(Token = "0x4000A71")]
	internal static bool stackedOverlayCamerasRequireDepthForPostProcessing; //Field offset: 0x4
	[Token(Token = "0x4000A72")]
	internal static RenderGraph s_RenderGraph; //Field offset: 0x8
	[Token(Token = "0x4000A73")]
	internal static RTHandleResourcePool s_RTHandlePool; //Field offset: 0x10
	[Token(Token = "0x4000A75")]
	internal static bool requireOffscreenUICoverPrepass; //Field offset: 0x18
	[Token(Token = "0x4000A76")]
	internal static bool offscreenUIRenderedInCurrentFrame; //Field offset: 0x19
	[CompilerGenerated]
	[Token(Token = "0x4000A77")]
	private static bool <canOptimizeScreenMSAASamples>k__BackingField; //Field offset: 0x1A
	[CompilerGenerated]
	[Token(Token = "0x4000A78")]
	private static int <startFrameScreenMSAASamples>k__BackingField; //Field offset: 0x1C
	[Token(Token = "0x4000A7C")]
	private static Vector4 k_DefaultLightPosition; //Field offset: 0x20
	[Token(Token = "0x4000A7D")]
	private static Vector4 k_DefaultLightColor; //Field offset: 0x30
	[Token(Token = "0x4000A7E")]
	private static Vector4 k_DefaultLightAttenuation; //Field offset: 0x40
	[Token(Token = "0x4000A7F")]
	private static Vector4 k_DefaultLightSpotDirection; //Field offset: 0x50
	[Token(Token = "0x4000A80")]
	private static Vector4 k_DefaultLightsProbeChannel; //Field offset: 0x60
	[Token(Token = "0x4000A81")]
	private static List<Vector4> m_ShadowBiasData; //Field offset: 0x70
	[Token(Token = "0x4000A82")]
	private static List<Int32> m_ShadowResolutionData; //Field offset: 0x78
	[Token(Token = "0x4000A84")]
	private static RequestLightsDelegate lightsDelegate; //Field offset: 0x80
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A6D")]
	private readonly DebugDisplaySettingsUI m_DebugDisplaySettingsUI; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A6E")]
	private UniversalRenderPipelineGlobalSettings m_GlobalSettings; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A6F")]
	private UniversalRenderPipelineRuntimeTextures <runtimeTextures>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A74")]
	internal bool apvIsEnabled; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A79")]
	private readonly UniversalRenderPipelineAsset pipelineAsset; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A7A")]
	internal bool enableHDROutputOnce; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000A7B")]
	internal bool warnedRuntimeSwitchHDROutputToSDROutput; //Field offset: 0x41
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A83")]
	private Comparison<Camera> cameraComparison; //Field offset: 0x48

	[Token(Token = "0x1700026D")]
	public static UniversalRenderPipelineAsset asset
	{
		[Address(RVA = "0x2E17B90", Offset = "0x2E16F90", Length = "0x93")]
		[Token(Token = "0x6000A6E")]
		 get { } //Length: 147
	}

	[Token(Token = "0x1700026B")]
	internal static bool canOptimizeScreenMSAASamples
	{
		[Address(RVA = "0x2E17C30", Offset = "0x2E17030", Length = "0x4F")]
		[CompilerGenerated]
		[Token(Token = "0x6000A34")]
		internal get { } //Length: 79
		[Address(RVA = "0x2E17F70", Offset = "0x2E17370", Length = "0x54")]
		[CompilerGenerated]
		[Token(Token = "0x6000A35")]
		private set { } //Length: 84
	}

	[Token(Token = "0x1700026A")]
	public virtual RenderPipelineGlobalSettings defaultSettings
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000A33")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000264")]
	internal static int lightsPerTile
	{
		[Address(RVA = "0x2E17C80", Offset = "0x2E17080", Length = "0x4D")]
		[Token(Token = "0x6000A2B")]
		internal get { } //Length: 77
	}

	[Token(Token = "0x17000261")]
	public static int maxNumIterationsEnclosingSphere
	{
		[Address(RVA = "0x2E17CD0", Offset = "0x2E170D0", Length = "0x6")]
		[Token(Token = "0x6000A28")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000262")]
	public static int maxPerObjectLights
	{
		[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
		[Token(Token = "0x6000A29")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000260")]
	public static float maxRenderScale
	{
		[Address(RVA = "0x2E17CE0", Offset = "0x2E170E0", Length = "0x9")]
		[Token(Token = "0x6000A27")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700025E")]
	public static float maxShadowBias
	{
		[Address(RVA = "0x2C1DA20", Offset = "0x2C1CE20", Length = "0x9")]
		[Token(Token = "0x6000A25")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000266")]
	internal static int maxTileWords
	{
		[Address(RVA = "0x2E17CF0", Offset = "0x2E170F0", Length = "0x53")]
		[Token(Token = "0x6000A2D")]
		internal get { } //Length: 83
	}

	[Token(Token = "0x17000263")]
	public static int maxVisibleAdditionalLights
	{
		[Address(RVA = "0x2E17D50", Offset = "0x2E17150", Length = "0xFD")]
		[Token(Token = "0x6000A2A")]
		 get { } //Length: 253
	}

	[Token(Token = "0x17000267")]
	internal static int maxVisibleReflectionProbes
	{
		[Address(RVA = "0x2E17E50", Offset = "0x2E17250", Length = "0x75")]
		[Token(Token = "0x6000A2E")]
		internal get { } //Length: 117
	}

	[Token(Token = "0x17000265")]
	internal static int maxZBinWords
	{
		[Address(RVA = "0x9E1930", Offset = "0x9E0D30", Length = "0x6")]
		[Token(Token = "0x6000A2C")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700025F")]
	public static float minRenderScale
	{
		[Address(RVA = "0x2C1DA40", Offset = "0x2C1CE40", Length = "0x9")]
		[Token(Token = "0x6000A26")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000269")]
	internal static RenderTextureUVOriginStrategy renderTextureUVOriginStrategy
	{
		[Address(RVA = "0x2E17ED0", Offset = "0x2E172D0", Length = "0x4D")]
		[CompilerGenerated]
		[Token(Token = "0x6000A31")]
		private get { } //Length: 77
		[Address(RVA = "0x2E17FD0", Offset = "0x2E173D0", Length = "0x52")]
		[CompilerGenerated]
		[Token(Token = "0x6000A32")]
		internal set { } //Length: 82
	}

	[Token(Token = "0x17000268")]
	internal UniversalRenderPipelineRuntimeTextures runtimeTextures
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A2F")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000A30")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700026C")]
	internal static int startFrameScreenMSAASamples
	{
		[Address(RVA = "0x2E17F20", Offset = "0x2E17320", Length = "0x4E")]
		[CompilerGenerated]
		[Token(Token = "0x6000A36")]
		internal get { } //Length: 78
		[Address(RVA = "0x2E18030", Offset = "0x2E17430", Length = "0x53")]
		[CompilerGenerated]
		[Token(Token = "0x6000A37")]
		private set { } //Length: 83
	}

	[Address(RVA = "0x2E170F0", Offset = "0x2E164F0", Length = "0x21B")]
	[Token(Token = "0x6000A7A")]
	private static UniversalRenderPipeline() { }

	[Address(RVA = "0x2E17310", Offset = "0x2E16710", Length = "0x87A")]
	[Token(Token = "0x6000A39")]
	public UniversalRenderPipeline(UniversalRenderPipelineAsset asset) { }

	[Address(RVA = "0x2E0BC30", Offset = "0x2E0B030", Length = "0xAF")]
	[Token(Token = "0x6000A6B")]
	private static void AdjustUIOverlayOwnership(int cameraCount) { }

	[Address(RVA = "0x2E0BCE0", Offset = "0x2E0B0E0", Length = "0x2A6")]
	[Token(Token = "0x6000A69")]
	private static void ApplyAdaptivePerformance(ContextContainer frameData) { }

	[Address(RVA = "0x2E0BF90", Offset = "0x2E0B390", Length = "0x20E")]
	[Token(Token = "0x6000A68")]
	private static void ApplyAdaptivePerformance(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2E0C1A0", Offset = "0x2E0B5A0", Length = "0xAB")]
	[Token(Token = "0x6000A58")]
	private static void ApplyTaaRenderingDebugOverrides(ref Settings taaSettings) { }

	[Address(RVA = "0x2E0C250", Offset = "0x2E0B650", Length = "0x14A")]
	[Token(Token = "0x6000A6A")]
	private static AdditionalLightsShadowAtlasLayout BuildAdditionalLightsShadowAtlasLayout(UniversalLightData lightData, UniversalShadowData shadowData, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2E0C3A0", Offset = "0x2E0B7A0", Length = "0x23C")]
	[Token(Token = "0x6000A61")]
	private static void CheckAndApplyDebugSettings(ref RenderingData renderingData) { }

	[Address(RVA = "0x2E0C670", Offset = "0x2E0BA70", Length = "0xC6")]
	[Token(Token = "0x6000A49")]
	private static bool CheckPostProcessForDepth() { }

	[Address(RVA = "0x2E0C5E0", Offset = "0x2E0B9E0", Length = "0x80")]
	[Token(Token = "0x6000A48")]
	private static bool CheckPostProcessForDepth(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2E0C740", Offset = "0x2E0BB40", Length = "0x664")]
	[Token(Token = "0x6000A4D")]
	private static UniversalCameraData CreateCameraData(ContextContainer frameData, Camera camera, UniversalAdditionalCameraData additionalCameraData) { }

	[Address(RVA = "0x2E0CDB0", Offset = "0x2E0C1B0", Length = "0x63")]
	[Token(Token = "0x6000A52")]
	private static CullContextData CreateCullContextData(ContextContainer frameData, ScriptableRenderContext context) { }

	[Address(RVA = "0x2E0CE20", Offset = "0x2E0C220", Length = "0x2CF")]
	[Token(Token = "0x6000A57")]
	private static UniversalLightData CreateLightData(ContextContainer frameData, UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, Nullable<RenderingMode> renderingMode) { }

	[Address(RVA = "0x2E0D0F0", Offset = "0x2E0C4F0", Length = "0xE5")]
	[Token(Token = "0x6000A55")]
	private static UniversalPostProcessingData CreatePostProcessingData(ContextContainer frameData, UniversalRenderPipelineAsset settings) { }

	[Address(RVA = "0x2E0D4C0", Offset = "0x2E0C8C0", Length = "0x144")]
	[Token(Token = "0x6000A50")]
	private static UniversalRenderingData CreateRenderingData(ContextContainer frameData, UniversalRenderPipelineAsset settings, CommandBuffer cmd, Nullable<RenderingMode> renderingMode, ScriptableRenderer renderer) { }

	[Address(RVA = "0x2E0D1E0", Offset = "0x2E0C5E0", Length = "0x2D2")]
	[Token(Token = "0x6000A73")]
	internal static RenderTextureDescriptor CreateRenderTextureDescriptor(Camera camera, UniversalCameraData cameraData, bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture) { }

	[Address(RVA = "0x2E0D610", Offset = "0x2E0CA10", Length = "0x1C5")]
	[Token(Token = "0x6000A44")]
	private static void CreateShadowAtlasAndCullShadowCasters(UniversalLightData lightData, UniversalShadowData shadowData, UniversalCameraData cameraData, ref CullingResults cullResults, ref ScriptableRenderContext context) { }

	[Address(RVA = "0x2E0D7E0", Offset = "0x2E0CBE0", Length = "0xF70")]
	[Token(Token = "0x6000A51")]
	private static UniversalShadowData CreateShadowData(ContextContainer frameData, UniversalRenderPipelineAsset urpAsset, Nullable<RenderingMode> renderingMode) { }

	[Address(RVA = "0x2E0E760", Offset = "0x2E0DB60", Length = "0x43")]
	[Token(Token = "0x6000A56")]
	private static UniversalResourceData CreateUniversalResourceData(ContextContainer frameData) { }

	[Address(RVA = "0x2E0E870", Offset = "0x2E0DC70", Length = "0x3EA")]
	[Token(Token = "0x6000A3A")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2E0E7B0", Offset = "0x2E0DBB0", Length = "0xB0")]
	[Token(Token = "0x6000A3B")]
	private void DisposeAdditionalCameraData() { }

	[Address(RVA = "0x2E17B90", Offset = "0x2E16F90", Length = "0x93")]
	[Token(Token = "0x6000A6E")]
	public static UniversalRenderPipelineAsset get_asset() { }

	[Address(RVA = "0x2E17C30", Offset = "0x2E17030", Length = "0x4F")]
	[CompilerGenerated]
	[Token(Token = "0x6000A34")]
	internal static bool get_canOptimizeScreenMSAASamples() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000A33")]
	public virtual RenderPipelineGlobalSettings get_defaultSettings() { }

	[Address(RVA = "0x2E17C80", Offset = "0x2E17080", Length = "0x4D")]
	[Token(Token = "0x6000A2B")]
	internal static int get_lightsPerTile() { }

	[Address(RVA = "0x2E17CD0", Offset = "0x2E170D0", Length = "0x6")]
	[Token(Token = "0x6000A28")]
	public static int get_maxNumIterationsEnclosingSphere() { }

	[Address(RVA = "0x9DCBA0", Offset = "0x9DBFA0", Length = "0x6")]
	[Token(Token = "0x6000A29")]
	public static int get_maxPerObjectLights() { }

	[Address(RVA = "0x2E17CE0", Offset = "0x2E170E0", Length = "0x9")]
	[Token(Token = "0x6000A27")]
	public static float get_maxRenderScale() { }

	[Address(RVA = "0x2C1DA20", Offset = "0x2C1CE20", Length = "0x9")]
	[Token(Token = "0x6000A25")]
	public static float get_maxShadowBias() { }

	[Address(RVA = "0x2E17CF0", Offset = "0x2E170F0", Length = "0x53")]
	[Token(Token = "0x6000A2D")]
	internal static int get_maxTileWords() { }

	[Address(RVA = "0x2E17D50", Offset = "0x2E17150", Length = "0xFD")]
	[Token(Token = "0x6000A2A")]
	public static int get_maxVisibleAdditionalLights() { }

	[Address(RVA = "0x2E17E50", Offset = "0x2E17250", Length = "0x75")]
	[Token(Token = "0x6000A2E")]
	internal static int get_maxVisibleReflectionProbes() { }

	[Address(RVA = "0x9E1930", Offset = "0x9E0D30", Length = "0x6")]
	[Token(Token = "0x6000A2C")]
	internal static int get_maxZBinWords() { }

	[Address(RVA = "0x2C1DA40", Offset = "0x2C1CE40", Length = "0x9")]
	[Token(Token = "0x6000A26")]
	public static float get_minRenderScale() { }

	[Address(RVA = "0x2E17ED0", Offset = "0x2E172D0", Length = "0x4D")]
	[CompilerGenerated]
	[Token(Token = "0x6000A31")]
	private static RenderTextureUVOriginStrategy get_renderTextureUVOriginStrategy() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A2F")]
	internal UniversalRenderPipelineRuntimeTextures get_runtimeTextures() { }

	[Address(RVA = "0x2E17F20", Offset = "0x2E17320", Length = "0x4E")]
	[CompilerGenerated]
	[Token(Token = "0x6000A36")]
	internal static int get_startFrameScreenMSAASamples() { }

	[Address(RVA = "0x2E0EC60", Offset = "0x2E0E060", Length = "0x157")]
	[Token(Token = "0x6000A5D")]
	private static int GetBrightestDirectionalLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights) { }

	[Address(RVA = "0x2E0EDC0", Offset = "0x2E0E1C0", Length = "0xF6")]
	[Token(Token = "0x6000A67")]
	internal static void GetHDROutputGradingParameters(Tonemapping tonemapping, out Vector4 hdrOutputParameters) { }

	[Address(RVA = "0x2E0EEC0", Offset = "0x2E0E2C0", Length = "0x136")]
	[Token(Token = "0x6000A66")]
	internal static void GetHDROutputLuminanceParameters(HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Tonemapping tonemapping, out Vector4 hdrOutputParameters) { }

	[Address(RVA = "0x2E0F000", Offset = "0x2E0E400", Length = "0xFE")]
	[Token(Token = "0x6000A70")]
	private int GetLastBaseCameraIndex(List<Camera> cameras) { }

	[Address(RVA = "0x2E0F100", Offset = "0x2E0E500", Length = "0x19B")]
	[Token(Token = "0x6000A74")]
	public static void GetLightAttenuationAndSpotDirection(LightType lightType, float lightRange, Matrix4x4 lightLocalToWorldMatrix, float spotAngle, Nullable<Single> innerSpotAngle, out Vector4 lightAttenuation, out Vector4 lightSpotDir) { }

	[Address(RVA = "0x2E0F2A0", Offset = "0x2E0E6A0", Length = "0x9C")]
	[Token(Token = "0x6000A53")]
	private static Vector3 GetMainLightCascadeSplit(int mainLightShadowCascadesCount, UniversalRenderPipelineAsset urpAsset) { }

	[Address(RVA = "0x2E0F340", Offset = "0x2E0E740", Length = "0x279")]
	[Token(Token = "0x6000A5E")]
	private static int GetMainLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights) { }

	[Address(RVA = "0x2E0F5C0", Offset = "0x2E0E9C0", Length = "0x17A")]
	[Token(Token = "0x6000A5C")]
	private static PerObjectData GetPerObjectLightFlags(UniversalLightData universalLightData, UniversalRenderPipelineAsset settings, Nullable<RenderingMode> renderingMode) { }

	[Address(RVA = "0x2E0F740", Offset = "0x2E0EB40", Length = "0x46")]
	[Token(Token = "0x6000A75")]
	internal static void GetPunctualLightDistanceAttenuation(float lightRange, ref Vector4 lightAttenuation) { }

	[Address(RVA = "0x2E0F790", Offset = "0x2E0EB90", Length = "0xCA")]
	[Token(Token = "0x6000A4B")]
	private static ScriptableRenderer GetRenderer(Camera camera, UniversalAdditionalCameraData additionalCameraData) { }

	[Address(RVA = "0x2E0F860", Offset = "0x2E0EC60", Length = "0x168")]
	[Token(Token = "0x6000A76")]
	internal static void GetSpotAngleAttenuation(float spotAngle, Nullable<Single> innerSpotAngle, ref Vector4 lightAttenuation) { }

	[Address(RVA = "0x2E0F9D0", Offset = "0x2E0EDD0", Length = "0x50")]
	[Token(Token = "0x6000A77")]
	internal static void GetSpotDirection(ref Matrix4x4 lightLocalToWorldMatrix, out Vector4 lightSpotDir) { }

	[Address(RVA = "0x2E0FA20", Offset = "0x2E0EE20", Length = "0x9A")]
	[Token(Token = "0x6000A64")]
	internal static bool HDROutputForAnyDisplayIsActive() { }

	[Address(RVA = "0x2E0FAC0", Offset = "0x2E0EEC0", Length = "0xDC")]
	[Token(Token = "0x6000A63")]
	internal static bool HDROutputForMainDisplayIsActive() { }

	[Address(RVA = "0x2E0FBA0", Offset = "0x2E0EFA0", Length = "0xC21")]
	[Token(Token = "0x6000A4F")]
	private static void InitializeAdditionalCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, bool isLastBaseCamera, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2E107D0", Offset = "0x2E0FBD0", Length = "0x50C")]
	[Token(Token = "0x6000A78")]
	public static void InitializeLightConstants_Common(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel) { }

	[Address(RVA = "0x2E10CE0", Offset = "0x2E100E0", Length = "0x97")]
	[Token(Token = "0x6000A54")]
	private static void InitializeMainLightShadowResolution(UniversalShadowData shadowData) { }

	[Address(RVA = "0x2E10D80", Offset = "0x2E10180", Length = "0x86")]
	[Token(Token = "0x6000A4C")]
	internal static void InitializeScaledDimensions(Camera camera, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2E10E10", Offset = "0x2E10210", Length = "0x76C")]
	[Token(Token = "0x6000A4E")]
	private static void InitializeStackedCameraData(Camera baseCamera, UniversalAdditionalCameraData baseAdditionalCameraData, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2E11580", Offset = "0x2E10980", Length = "0xC9")]
	[Token(Token = "0x6000A6D")]
	public static bool IsGameCamera(Camera camera) { }

	[Address(RVA = "0x9D5C90", Offset = "0x9D5090", Length = "0x99")]
	[Token(Token = "0x6000A3D")]
	protected virtual bool IsRenderRequestSupported(Camera camera, RequestData data) { }

	[Address(RVA = "0x2E11650", Offset = "0x2E10A50", Length = "0x6F")]
	[Token(Token = "0x6000A71")]
	internal static GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha) { }

	[Address(RVA = "0x2E116C0", Offset = "0x2E10AC0", Length = "0x2C")]
	[Token(Token = "0x6000A72")]
	internal static GraphicsFormat MakeUnormRenderTextureGraphicsFormat() { }

	[Address(RVA = "0x9D68C0", Offset = "0x9D5CC0", Length = "0xB30")]
	[Token(Token = "0x6000A3E")]
	protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	[Address(RVA = "0x2E116F0", Offset = "0x2E10AF0", Length = "0x174")]
	[Token(Token = "0x6000A79")]
	private static void RecordAndExecuteRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ScriptableRenderer renderer, CommandBuffer cmd, Camera camera, RenderTextureUVOriginStrategy uvOriginStrategy) { }

	[Address(RVA = "0x2E14CC0", Offset = "0x2E140C0", Length = "0x8F6")]
	[Token(Token = "0x6000A3C")]
	protected virtual void Render(ScriptableRenderContext renderContext, List<Camera> cameras) { }

	[Address(RVA = "0x2E11870", Offset = "0x2E10C70", Length = "0x1685")]
	[Token(Token = "0x6000A45")]
	private static void RenderCameraStack(ScriptableRenderContext context, Camera baseCamera, bool isLastBaseCamera) { }

	[Address(RVA = "0x2E134C0", Offset = "0x2E128C0", Length = "0x1798")]
	[Token(Token = "0x6000A43")]
	private static void RenderSingleCamera(ScriptableRenderContext context, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2E14C60", Offset = "0x2E14060", Length = "0x5C")]
	[Obsolete("RenderSingleCamera is obsolete, please use RenderPipeline.SubmitRenderRequest with UniversalRenderer.SingleCameraRequest as RequestData type. #from(2023.1)")]
	[Token(Token = "0x6000A3F")]
	public static void RenderSingleCamera(ScriptableRenderContext context, Camera camera) { }

	[Address(RVA = "0x2E12F00", Offset = "0x2E12300", Length = "0xDC")]
	[Token(Token = "0x6000A40")]
	internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, bool isLastBaseCamera = true) { }

	[Address(RVA = "0x2E12FE0", Offset = "0x2E123E0", Length = "0x4D3")]
	[Token(Token = "0x6000A41")]
	internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, ref UniversalAdditionalCameraData additionalCameraData, bool isLastBaseCamera = true) { }

	[Address(RVA = "0x2E155C0", Offset = "0x2E149C0", Length = "0x1D2")]
	[Token(Token = "0x6000A62")]
	private static ImageUpscalingFilter ResolveUpscalingFilterSelection(Vector2 imageSize, float renderScale, UpscalingFilterSelection selection, bool enableRenderGraph) { }

	[Address(RVA = "0x2E17F70", Offset = "0x2E17370", Length = "0x54")]
	[CompilerGenerated]
	[Token(Token = "0x6000A35")]
	private static void set_canOptimizeScreenMSAASamples(bool value) { }

	[Address(RVA = "0x2E17FD0", Offset = "0x2E173D0", Length = "0x52")]
	[CompilerGenerated]
	[Token(Token = "0x6000A32")]
	internal static void set_renderTextureUVOriginStrategy(RenderTextureUVOriginStrategy value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000A30")]
	private void set_runtimeTextures(UniversalRenderPipelineRuntimeTextures value) { }

	[Address(RVA = "0x2E18030", Offset = "0x2E17430", Length = "0x53")]
	[CompilerGenerated]
	[Token(Token = "0x6000A37")]
	private static void set_startFrameScreenMSAASamples(int value) { }

	[Address(RVA = "0x2E157A0", Offset = "0x2E14BA0", Length = "0x26D")]
	[Token(Token = "0x6000A65")]
	private void SetHDRState(List<Camera> cameras) { }

	[Address(RVA = "0x2E15A10", Offset = "0x2E14E10", Length = "0x6D")]
	[Token(Token = "0x6000A4A")]
	private static void SetSupportedRenderingFeatures(UniversalRenderPipelineAsset pipelineAsset) { }

	[Address(RVA = "0x2E15A80", Offset = "0x2E14E80", Length = "0x5C7")]
	[Token(Token = "0x6000A60")]
	private static void SetupPerCameraShaderConstants(CommandBuffer cmd) { }

	[Address(RVA = "0x2E16050", Offset = "0x2E15450", Length = "0x2F4")]
	[Token(Token = "0x6000A5F")]
	private void SetupPerFrameShaderConstants() { }

	[Address(RVA = "0x2E16350", Offset = "0x2E15750", Length = "0xE2")]
	[Token(Token = "0x6000A6C")]
	private static void SetupScreenMSAASamplesState(int cameraCount) { }

	[Address(RVA = "0x2E16440", Offset = "0x2E15840", Length = "0x66")]
	[Token(Token = "0x6000A6F")]
	private void SortCameras(List<Camera> cameras) { }

	[Address(RVA = "0x2E164B0", Offset = "0x2E158B0", Length = "0x20")]
	[Token(Token = "0x6000A38")]
	public virtual string ToString() { }

	[Address(RVA = "0x2E164D0", Offset = "0x2E158D0", Length = "0x1B9")]
	[Token(Token = "0x6000A42")]
	private static bool TryGetCullingParameters(UniversalCameraData cameraData, out ScriptableCullingParameters cullingParams) { }

	[Address(RVA = "0x2E16690", Offset = "0x2E15A90", Length = "0x322")]
	[Token(Token = "0x6000A46")]
	private static void UpdateCameraData(UniversalCameraData baseCameraData, in XRPass xr) { }

	[Address(RVA = "0x2E169C0", Offset = "0x2E15DC0", Length = "0x1BA")]
	[Token(Token = "0x6000A5B")]
	private static void UpdateCameraStereoMatrices(Camera camera, XRPass xr) { }

	[Address(RVA = "0x2E16B80", Offset = "0x2E15F80", Length = "0x13E")]
	[Token(Token = "0x6000A59")]
	private static void UpdateTemporalAAData(UniversalCameraData cameraData, UniversalAdditionalCameraData additionalCameraData) { }

	[Address(RVA = "0x2E16CC0", Offset = "0x2E160C0", Length = "0x144")]
	[Token(Token = "0x6000A5A")]
	private static void UpdateTemporalAATargets(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2E16E10", Offset = "0x2E16210", Length = "0x2D1")]
	[Token(Token = "0x6000A47")]
	private static void UpdateVolumeFramework(Camera camera, UniversalAdditionalCameraData additionalCameraData) { }

}

