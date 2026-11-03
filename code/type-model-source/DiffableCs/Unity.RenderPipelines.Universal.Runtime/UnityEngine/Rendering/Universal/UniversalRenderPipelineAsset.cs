namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
[Token(Token = "0x2000028")]
public class UniversalRenderPipelineAsset : RenderPipelineAsset<UniversalRenderPipeline>, ISerializationCallbackReceiver, IProbeVolumeEnabledRenderPipeline, IGPUResidentRenderPipeline, IRenderGraphEnabledRenderPipeline, ISTPEnabledRenderPipeline
{
	[Token(Token = "0x2000029")]
	private static class Strings
	{
		[Token(Token = "0x4000116")]
		public static readonly string notURPRenderer; //Field offset: 0x0
		[Token(Token = "0x4000117")]
		public static readonly string renderingModeIncompatible; //Field offset: 0x8

		[Address(RVA = "0x2D61230", Offset = "0x2D60630", Length = "0xA5")]
		[Token(Token = "0x60000F6")]
		private static Strings() { }

	}

	[Obsolete("Moved to UniversalRenderPipelineRuntimeTextures on GraphicsSettings. #from(2023.3)")]
	[ReloadGroup]
	[Token(Token = "0x200002A")]
	internal sealed class TextureResources
	{
		[FieldOffset(Offset = "0x10")]
		[Reload("Textures/BlueNoise64/L/LDR_LLL1_0.png", Package::Root (1))]
		[Token(Token = "0x4000118")]
		public Texture2D blueNoise64LTex; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Reload("Textures/BayerMatrix.png", Package::Root (1))]
		[Token(Token = "0x4000119")]
		public Texture2D bayerMatrixTex; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000F8")]
		public TextureResources() { }

		[Address(RVA = "0x2D61970", Offset = "0x2D60D70", Length = "0x90")]
		[Token(Token = "0x60000F7")]
		public bool NeedsReload() { }

	}

	[Token(Token = "0x4000107")]
	public const int k_MinLutSize = 16; //Field offset: 0x0
	[Token(Token = "0x40000B7")]
	private const int k_LastVersion = 13; //Field offset: 0x0
	[Token(Token = "0x4000109")]
	internal const int k_ShadowCascadeMinCount = 1; //Field offset: 0x0
	[Token(Token = "0x400010A")]
	internal const int k_ShadowCascadeMaxCount = 4; //Field offset: 0x0
	[Token(Token = "0x400010B")]
	public static readonly int AdditionalLightsDefaultShadowResolutionTierLow; //Field offset: 0x0
	[Token(Token = "0x4000108")]
	public const int k_MaxLutSize = 65; //Field offset: 0x0
	[Token(Token = "0x400010C")]
	public static readonly int AdditionalLightsDefaultShadowResolutionTierMedium; //Field offset: 0x4
	[Token(Token = "0x400010D")]
	public static readonly int AdditionalLightsDefaultShadowResolutionTierHigh; //Field offset: 0x8
	[Token(Token = "0x400010E")]
	private static String[] s_Names; //Field offset: 0x10
	[Token(Token = "0x400010F")]
	private static Int32[] s_Values; //Field offset: 0x18
	[Token(Token = "0x4000110")]
	private static GraphicsFormat[][] s_LightCookieFormatList; //Field offset: 0x20
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000B6")]
	private ScriptableRenderer[] m_Renderers; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000B8")]
	private int k_AssetVersion; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x40000B9")]
	private int k_AssetPreviousVersion; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40000BA")]
	private RendererType m_RendererType; //Field offset: 0x30
	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[FieldOffset(Offset = "0x38")]
	[Obsolete("Use m_RendererDataList instead. #from(2023.1)")]
	[SerializeField]
	[Token(Token = "0x40000BB")]
	internal ScriptableRendererData m_RendererData; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000BC")]
	internal ScriptableRendererData[] m_RendererDataList; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40000BD")]
	internal int m_DefaultRendererIndex; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x40000BE")]
	private bool m_RequireDepthTexture; //Field offset: 0x4C
	[FieldOffset(Offset = "0x4D")]
	[SerializeField]
	[Token(Token = "0x40000BF")]
	private bool m_RequireOpaqueTexture; //Field offset: 0x4D
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40000C0")]
	private Downsampling m_OpaqueDownsampling; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x40000C1")]
	private bool m_SupportsTerrainHoles; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[SerializeField]
	[Token(Token = "0x40000C2")]
	private bool m_SupportsHDR; //Field offset: 0x55
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40000C3")]
	private HDRColorBufferPrecision m_HDRColorBufferPrecision; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x40000C4")]
	private MsaaQuality m_MSAA; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40000C5")]
	private float m_RenderScale; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x40000C6")]
	private UpscalingFilterSelection m_UpscalingFilter; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x40000C7")]
	private bool m_FsrOverrideSharpness; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x40000C8")]
	private float m_FsrSharpness; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40000C9")]
	private bool m_EnableLODCrossFade; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	[Token(Token = "0x40000CA")]
	private LODCrossFadeDitheringType m_LODCrossFadeDitheringType; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x40000CB")]
	private ShEvalMode m_ShEvalMode; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	[Token(Token = "0x40000CC")]
	private LightProbeSystem m_LightProbeSystem; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x40000CD")]
	private ProbeVolumeTextureMemoryBudget m_ProbeVolumeMemoryBudget; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	[Token(Token = "0x40000CE")]
	private ProbeVolumeBlendingTextureMemoryBudget m_ProbeVolumeBlendingMemoryBudget; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("m_SupportProbeVolumeStreaming")]
	[SerializeField]
	[Token(Token = "0x40000CF")]
	private bool m_SupportProbeVolumeGPUStreaming; //Field offset: 0x88
	[FieldOffset(Offset = "0x89")]
	[SerializeField]
	[Token(Token = "0x40000D0")]
	private bool m_SupportProbeVolumeDiskStreaming; //Field offset: 0x89
	[FieldOffset(Offset = "0x8A")]
	[SerializeField]
	[Token(Token = "0x40000D1")]
	private bool m_SupportProbeVolumeScenarios; //Field offset: 0x8A
	[FieldOffset(Offset = "0x8B")]
	[SerializeField]
	[Token(Token = "0x40000D2")]
	private bool m_SupportProbeVolumeScenarioBlending; //Field offset: 0x8B
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	[Token(Token = "0x40000D3")]
	private ProbeVolumeSHBands m_ProbeVolumeSHBands; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x40000D4")]
	private LightRenderingMode m_MainLightRenderingMode; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	[Token(Token = "0x40000D5")]
	private bool m_MainLightShadowsSupported; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x40000D6")]
	private ShadowResolution m_MainLightShadowmapResolution; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	[Token(Token = "0x40000D7")]
	private LightRenderingMode m_AdditionalLightsRenderingMode; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x40000D8")]
	private int m_AdditionalLightsPerObjectLimit; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	[Token(Token = "0x40000D9")]
	private bool m_AdditionalLightShadowsSupported; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x40000DA")]
	private ShadowResolution m_AdditionalLightsShadowmapResolution; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	[Token(Token = "0x40000DB")]
	private int m_AdditionalLightsShadowResolutionTierLow; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x40000DC")]
	private int m_AdditionalLightsShadowResolutionTierMedium; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	[Token(Token = "0x40000DD")]
	private int m_AdditionalLightsShadowResolutionTierHigh; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x40000DE")]
	private bool m_ReflectionProbeBlending; //Field offset: 0xB8
	[FieldOffset(Offset = "0xB9")]
	[SerializeField]
	[Token(Token = "0x40000DF")]
	private bool m_ReflectionProbeBoxProjection; //Field offset: 0xB9
	[FieldOffset(Offset = "0xBA")]
	[SerializeField]
	[Token(Token = "0x40000E0")]
	private bool m_ReflectionProbeAtlas; //Field offset: 0xBA
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	[Token(Token = "0x40000E1")]
	private float m_ShadowDistance; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x40000E2")]
	private int m_ShadowCascadeCount; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[SerializeField]
	[Token(Token = "0x40000E3")]
	private float m_Cascade2Split; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x40000E4")]
	private Vector2 m_Cascade3Split; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x40000E5")]
	private Vector3 m_Cascade4Split; //Field offset: 0xD0
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	[Token(Token = "0x40000E6")]
	private float m_CascadeBorder; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x40000E7")]
	private float m_ShadowDepthBias; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	[Token(Token = "0x40000E8")]
	private float m_ShadowNormalBias; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x40000E9")]
	private bool m_SoftShadowsSupported; //Field offset: 0xE8
	[FieldOffset(Offset = "0xE9")]
	[SerializeField]
	[Token(Token = "0x40000EA")]
	private bool m_ConservativeEnclosingSphere; //Field offset: 0xE9
	[FieldOffset(Offset = "0xEC")]
	[SerializeField]
	[Token(Token = "0x40000EB")]
	private int m_NumIterationsEnclosingSphere; //Field offset: 0xEC
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x40000EC")]
	private SoftShadowQuality m_SoftShadowQuality; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	[Token(Token = "0x40000ED")]
	private LightCookieResolution m_AdditionalLightsCookieResolution; //Field offset: 0xF4
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x40000EE")]
	private LightCookieFormat m_AdditionalLightsCookieFormat; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[SerializeField]
	[Token(Token = "0x40000EF")]
	private bool m_UseSRPBatcher; //Field offset: 0xFC
	[FieldOffset(Offset = "0xFD")]
	[SerializeField]
	[Token(Token = "0x40000F0")]
	private bool m_SupportsDynamicBatching; //Field offset: 0xFD
	[FieldOffset(Offset = "0xFE")]
	[SerializeField]
	[Token(Token = "0x40000F1")]
	private bool m_MixedLightingSupported; //Field offset: 0xFE
	[FieldOffset(Offset = "0xFF")]
	[SerializeField]
	[Token(Token = "0x40000F2")]
	private bool m_SupportsLightCookies; //Field offset: 0xFF
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x40000F3")]
	private bool m_SupportsLightLayers; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[Obsolete("#from(2022.1) #breakingFrom(2023.1)", True)]
	[SerializeField]
	[Token(Token = "0x40000F4")]
	private PipelineDebugLevel m_DebugLevel; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x40000F5")]
	private StoreActionsOptimization m_StoreActionsOptimization; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[SerializeField]
	[Token(Token = "0x40000F6")]
	private bool m_UseAdaptivePerformance; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40000F7")]
	private ColorGradingMode m_ColorGradingMode; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[Token(Token = "0x40000F8")]
	private int m_ColorGradingLutSize; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Token(Token = "0x40000F9")]
	private bool m_AllowPostProcessAlphaOutput; //Field offset: 0x118
	[FieldOffset(Offset = "0x119")]
	[SerializeField]
	[Token(Token = "0x40000FA")]
	private bool m_UseFastSRGBLinearConversion; //Field offset: 0x119
	[FieldOffset(Offset = "0x11A")]
	[SerializeField]
	[Token(Token = "0x40000FB")]
	private bool m_SupportDataDrivenLensFlare; //Field offset: 0x11A
	[FieldOffset(Offset = "0x11B")]
	[SerializeField]
	[Token(Token = "0x40000FC")]
	private bool m_SupportScreenSpaceLensFlare; //Field offset: 0x11B
	[FieldOffset(Offset = "0x11C")]
	[FormerlySerializedAs("m_MacroBatcherMode")]
	[SerializeField]
	[Token(Token = "0x40000FD")]
	private GPUResidentDrawerMode m_GPUResidentDrawerMode; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x40000FE")]
	private float m_SmallMeshScreenPercentage; //Field offset: 0x120
	[FieldOffset(Offset = "0x124")]
	[SerializeField]
	[Token(Token = "0x40000FF")]
	private bool m_GPUResidentDrawerEnableOcclusionCullingInCameras; //Field offset: 0x124
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x4000100")]
	private ShadowQuality m_ShadowType; //Field offset: 0x128
	[FieldOffset(Offset = "0x12C")]
	[SerializeField]
	[Token(Token = "0x4000101")]
	private bool m_LocalShadowsSupported; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x4000102")]
	private ShadowResolution m_LocalShadowsAtlasResolution; //Field offset: 0x130
	[FieldOffset(Offset = "0x134")]
	[SerializeField]
	[Token(Token = "0x4000103")]
	private int m_MaxPixelLights; //Field offset: 0x134
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	[Token(Token = "0x4000104")]
	private ShadowResolution m_ShadowAtlasResolution; //Field offset: 0x138
	[FieldOffset(Offset = "0x13C")]
	[SerializeField]
	[Token(Token = "0x4000105")]
	private VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateMode; //Field offset: 0x13C
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4000106")]
	private VolumeProfile m_VolumeProfile; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Obsolete("Kept for migration. #from(2023.3")]
	[SerializeField]
	[Token(Token = "0x4000111")]
	internal ProbeVolumeSceneData apvScenesData; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000112")]
	private Shader m_DefaultShader; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x4000113")]
	private int m_ShaderVariantLogLevel; //Field offset: 0x158
	[FieldOffset(Offset = "0x15C")]
	[Obsolete("This is obsolete, please use shadowCascadeCount instead. #from(2021.1)")]
	[SerializeField]
	[Token(Token = "0x4000114")]
	private ShadowCascadesOption m_ShadowCascades; //Field offset: 0x15C
	[FieldOffset(Offset = "0x160")]
	[Obsolete("Moved to UniversalRenderPipelineRuntimeTextures on GraphicsSettings. #from(2023.3)")]
	[SerializeField]
	[Token(Token = "0x4000115")]
	private TextureResources m_Textures; //Field offset: 0x160

	[Token(Token = "0x17000010")]
	internal GraphicsFormat additionalLightsCookieFormat
	{
		[Address(RVA = "0x2D67980", Offset = "0x2D66D80", Length = "0x20C")]
		[Token(Token = "0x600004D")]
		internal get { } //Length: 524
	}

	[Token(Token = "0x17000011")]
	internal Vector2Int additionalLightsCookieResolution
	{
		[Address(RVA = "0x2D67B90", Offset = "0x2D66F90", Length = "0x14")]
		[Token(Token = "0x600004E")]
		internal get { } //Length: 20
	}

	[Token(Token = "0x1700002F")]
	public internal LightRenderingMode additionalLightsRenderingMode
	{
		[Address(RVA = "0x25E2B40", Offset = "0x25E1F40", Length = "0x7")]
		[Token(Token = "0x6000083")]
		 get { } //Length: 7
		[Address(RVA = "0x2A057F0", Offset = "0x2A04BF0", Length = "0x7")]
		[Token(Token = "0x6000084")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000032")]
	public int additionalLightsShadowmapResolution
	{
		[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
		[Token(Token = "0x6000089")]
		 get { } //Length: 7
		[Address(RVA = "0x2C9FC60", Offset = "0x2C9F060", Length = "0x7")]
		[Token(Token = "0x600008A")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000035")]
	public internal int additionalLightsShadowResolutionTierHigh
	{
		[Address(RVA = "0x1F7B3D0", Offset = "0x1F7A7D0", Length = "0x7")]
		[Token(Token = "0x600008F")]
		 get { } //Length: 7
		[Address(RVA = "0x2D68640", Offset = "0x2D67A40", Length = "0x7")]
		[Token(Token = "0x6000090")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000033")]
	public internal int additionalLightsShadowResolutionTierLow
	{
		[Address(RVA = "0x1F7B610", Offset = "0x1F7AA10", Length = "0x7")]
		[Token(Token = "0x600008B")]
		 get { } //Length: 7
		[Address(RVA = "0x21AD620", Offset = "0x21ACA20", Length = "0x7")]
		[Token(Token = "0x600008C")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000034")]
	public internal int additionalLightsShadowResolutionTierMedium
	{
		[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
		[Token(Token = "0x600008D")]
		 get { } //Length: 7
		[Address(RVA = "0x1D58B00", Offset = "0x1D57F00", Length = "0x7")]
		[Token(Token = "0x600008E")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700004F")]
	public bool allowPostProcessAlphaOutput
	{
		[Address(RVA = "0x2D67BB0", Offset = "0x2D66FB0", Length = "0x8")]
		[Token(Token = "0x60000C0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700003B")]
	public float cascade2Split
	{
		[Address(RVA = "0x2D67BC0", Offset = "0x2D66FC0", Length = "0x9")]
		[Token(Token = "0x600009E")]
		 get { } //Length: 9
		[Address(RVA = "0x2D68650", Offset = "0x2D67A50", Length = "0x9")]
		[Token(Token = "0x600009F")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700003C")]
	public Vector2 cascade3Split
	{
		[Address(RVA = "0x2D67BD0", Offset = "0x2D66FD0", Length = "0x19")]
		[Token(Token = "0x60000A0")]
		 get { } //Length: 25
		[Address(RVA = "0x2D68660", Offset = "0x2D67A60", Length = "0x8")]
		[Token(Token = "0x60000A1")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700003D")]
	public Vector3 cascade4Split
	{
		[Address(RVA = "0x2D67BF0", Offset = "0x2D66FF0", Length = "0x19")]
		[Token(Token = "0x60000A2")]
		 get { } //Length: 25
		[Address(RVA = "0x1D5E140", Offset = "0x1D5D540", Length = "0x16")]
		[Token(Token = "0x60000A3")]
		 set { } //Length: 22
	}

	[Token(Token = "0x1700003E")]
	public float cascadeBorder
	{
		[Address(RVA = "0x2D67C10", Offset = "0x2D67010", Length = "0x9")]
		[Token(Token = "0x60000A4")]
		 get { } //Length: 9
		[Address(RVA = "0x2D68670", Offset = "0x2D67A70", Length = "0x9")]
		[Token(Token = "0x60000A5")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700004E")]
	public int colorGradingLutSize
	{
		[Address(RVA = "0x1E2A1B0", Offset = "0x1E295B0", Length = "0x7")]
		[Token(Token = "0x60000BE")]
		 get { } //Length: 7
		[Address(RVA = "0x2D68680", Offset = "0x2D67A80", Length = "0x27")]
		[Token(Token = "0x60000BF")]
		 set { } //Length: 39
	}

	[Token(Token = "0x1700004D")]
	public ColorGradingMode colorGradingMode
	{
		[Address(RVA = "0x1E2A1A0", Offset = "0x1E295A0", Length = "0x7")]
		[Token(Token = "0x60000BC")]
		 get { } //Length: 7
		[Address(RVA = "0x2D686B0", Offset = "0x2D67AB0", Length = "0x7")]
		[Token(Token = "0x60000BD")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000054")]
	public bool conservativeEnclosingSphere
	{
		[Address(RVA = "0x22E91E0", Offset = "0x22E85E0", Length = "0x8")]
		[Token(Token = "0x60000C6")]
		 get { } //Length: 8
		[Address(RVA = "0x2D686C0", Offset = "0x2D67AC0", Length = "0x7")]
		[Token(Token = "0x60000C7")]
		 set { } //Length: 7
	}

	[Obsolete("PipelineDebugLevel is deprecated and replaced to use the profiler. Calling debugLevel is not necessary. #from(2022.2) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x1700004A")]
	public PipelineDebugLevel debugLevel
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60000B7")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000068")]
	public Material decalMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60000E8")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000067")]
	public virtual Material default2DMaskMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60000E7")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000066")]
	public virtual Material default2DMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000064")]
	public virtual Material defaultLineMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60000E4")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000062")]
	public virtual Material defaultMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60000E2")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000063")]
	public virtual Material defaultParticleMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60000E3")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000069")]
	public virtual Shader defaultShader
	{
		[Address(RVA = "0x2D67C20", Offset = "0x2D67020", Length = "0xB2")]
		[Token(Token = "0x60000E9")]
		 get { } //Length: 178
	}

	[Token(Token = "0x17000065")]
	public virtual Material defaultTerrainMaterial
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60000E5")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700001C")]
	public bool enableLODCrossFade
	{
		[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
		[Token(Token = "0x6000060")]
		 get { } //Length: 5
	}

	[Obsolete("This has been deprecated, please use GraphicsSettings.GetRenderPipelineSettings<RenderGraphSettings>().enableRenderCompatibilityMode instead. #from(2023.3)")]
	[Token(Token = "0x1700004C")]
	public bool enableRenderGraph
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60000BA")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000020")]
	public bool fsrOverrideSharpness
	{
		[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
		[Token(Token = "0x6000065")]
		 get { } //Length: 5
		[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
		[Token(Token = "0x6000066")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000021")]
	public float fsrSharpness
	{
		[Address(RVA = "0x16D0800", Offset = "0x16CFC00", Length = "0x6")]
		[Token(Token = "0x6000067")]
		 get { } //Length: 6
		[Address(RVA = "0x16D0A90", Offset = "0x16CFE90", Length = "0x6")]
		[Token(Token = "0x6000068")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700005C")]
	public bool gpuResidentDrawerEnableOcclusionCullingInCameras
	{
		[Address(RVA = "0x26CB3C0", Offset = "0x26CA7C0", Length = "0x8")]
		[Token(Token = "0x60000D1")]
		 get { } //Length: 8
		[Address(RVA = "0x2D686D0", Offset = "0x2D67AD0", Length = "0x23")]
		[Token(Token = "0x60000D2")]
		 set { } //Length: 35
	}

	[Token(Token = "0x1700005B")]
	public override GPUResidentDrawerMode gpuResidentDrawerMode
	{
		[Address(RVA = "0x2D67CE0", Offset = "0x2D670E0", Length = "0x8")]
		[Token(Token = "0x60000CF")]
		 get { } //Length: 8
		[Address(RVA = "0x2D68700", Offset = "0x2D67B00", Length = "0x23")]
		[Token(Token = "0x60000D0")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000019")]
	public HDRColorBufferPrecision hdrColorBufferPrecision
	{
		[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
		[Token(Token = "0x600005A")]
		 get { } //Length: 4
		[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
		[Token(Token = "0x600005B")]
		 set { } //Length: 4
	}

	[Obsolete("This property is not used. #from(6000.3)", False)]
	[Token(Token = "0x17000070")]
	public IntermediateTextureMode intermediateTextureMode
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60000F2")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x60000F3")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700000D")]
	public override bool isImmediateModeSupported
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000042")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000061")]
	public override bool isStpUsed
	{
		[Address(RVA = "0x2D67CF0", Offset = "0x2D670F0", Length = "0x8")]
		[Token(Token = "0x60000E0")]
		 get { } //Length: 8
	}

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2023.1) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x1700005A")]
	public String[] lightLayerMaskNames
	{
		[Address(RVA = "0x2D67D00", Offset = "0x2D67100", Length = "0x32")]
		[Token(Token = "0x60000CE")]
		 get { } //Length: 50
	}

	[Token(Token = "0x17000023")]
	public internal LightProbeSystem lightProbeSystem
	{
		[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
		[Token(Token = "0x600006B")]
		 get { } //Length: 4
		[Address(RVA = "0x1D16670", Offset = "0x1D15A70", Length = "0x4")]
		[Token(Token = "0x600006C")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700001D")]
	public LODCrossFadeDitheringType lodCrossFadeDitheringType
	{
		[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
		[Token(Token = "0x6000061")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700002C")]
	public internal LightRenderingMode mainLightRenderingMode
	{
		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[Token(Token = "0x600007D")]
		 get { } //Length: 7
		[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
		[Token(Token = "0x600007E")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700002E")]
	public int mainLightShadowmapResolution
	{
		[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
		[Token(Token = "0x6000081")]
		 get { } //Length: 7
		[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
		[Token(Token = "0x6000082")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000030")]
	public int maxAdditionalLightsCount
	{
		[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
		[Token(Token = "0x6000085")]
		 get { } //Length: 7
		[Address(RVA = "0x2D68730", Offset = "0x2D67B30", Length = "0x9D")]
		[Token(Token = "0x6000086")]
		 set { } //Length: 157
	}

	[Token(Token = "0x1700005F")]
	public override ProbeVolumeSHBands maxSHBands
	{
		[Address(RVA = "0x2D67D40", Offset = "0x2D67140", Length = "0x12")]
		[Token(Token = "0x60000DE")]
		 get { } //Length: 18
	}

	[Token(Token = "0x1700001A")]
	public int msaaSampleCount
	{
		[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
		[Token(Token = "0x600005C")]
		 get { } //Length: 4
		[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
		[Token(Token = "0x600005D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000055")]
	public int numIterationsEnclosingSphere
	{
		[Address(RVA = "0x2D67D60", Offset = "0x2D67160", Length = "0x7")]
		[Token(Token = "0x60000C8")]
		 get { } //Length: 7
		[Address(RVA = "0x2D687D0", Offset = "0x2D67BD0", Length = "0x7")]
		[Token(Token = "0x60000C9")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000015")]
	public Downsampling opaqueDownsampling
	{
		[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
		[Token(Token = "0x6000054")]
		 get { } //Length: 4
	}

	[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(2023.3)")]
	[Token(Token = "0x17000059")]
	public virtual String[] prefixedRenderingLayerMaskNames
	{
		[Address(RVA = "0x2D67D70", Offset = "0x2D67170", Length = "0x30")]
		[Token(Token = "0x60000CD")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000025")]
	public internal ProbeVolumeBlendingTextureMemoryBudget probeVolumeBlendingMemoryBudget
	{
		[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
		[Token(Token = "0x600006F")]
		 get { } //Length: 7
		[Address(RVA = "0xD11B10", Offset = "0xD10F10", Length = "0x7")]
		[Token(Token = "0x6000070")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000024")]
	public internal ProbeVolumeTextureMemoryBudget probeVolumeMemoryBudget
	{
		[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
		[Token(Token = "0x600006D")]
		 get { } //Length: 7
		[Address(RVA = "0xE26DE0", Offset = "0xE261E0", Length = "0x7")]
		[Token(Token = "0x600006E")]
		internal set { } //Length: 7
	}

	[Obsolete("This property is no longer necessary. #from(2023.3)")]
	[Token(Token = "0x17000060")]
	public override ProbeVolumeSceneData probeVolumeSceneData
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x60000DF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700002B")]
	public internal ProbeVolumeSHBands probeVolumeSHBands
	{
		[Address(RVA = "0xD11AE0", Offset = "0xD10EE0", Length = "0x7")]
		[Token(Token = "0x600007B")]
		 get { } //Length: 7
		[Address(RVA = "0xD11C60", Offset = "0xD11060", Length = "0x7")]
		[Token(Token = "0x600007C")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000038")]
	public internal bool reflectionProbeAtlas
	{
		[Address(RVA = "0x2D67DA0", Offset = "0x2D671A0", Length = "0x8")]
		[Token(Token = "0x6000097")]
		 get { } //Length: 8
		[Address(RVA = "0x2D687E0", Offset = "0x2D67BE0", Length = "0x7")]
		[Token(Token = "0x6000098")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000036")]
	public internal bool reflectionProbeBlending
	{
		[Address(RVA = "0x2D67DB0", Offset = "0x2D671B0", Length = "0x8")]
		[Token(Token = "0x6000092")]
		 get { } //Length: 8
		[Address(RVA = "0x2D687F0", Offset = "0x2D67BF0", Length = "0x7")]
		[Token(Token = "0x6000093")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000037")]
	public internal bool reflectionProbeBoxProjection
	{
		[Address(RVA = "0x29FAD00", Offset = "0x29FA100", Length = "0x8")]
		[Token(Token = "0x6000095")]
		 get { } //Length: 8
		[Address(RVA = "0x2D68800", Offset = "0x2D67C00", Length = "0x7")]
		[Token(Token = "0x6000096")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700000B")]
	public ReadOnlySpan<ScriptableRendererData> rendererDataList
	{
		[Address(RVA = "0x2D67DF0", Offset = "0x2D671F0", Length = "0x57")]
		[Token(Token = "0x6000040")]
		 get { } //Length: 87
	}

	[Token(Token = "0x17000012")]
	internal Int32[] rendererIndexList
	{
		[Address(RVA = "0x2D67E50", Offset = "0x2D67250", Length = "0x7E")]
		[Token(Token = "0x600004F")]
		internal get { } //Length: 126
	}

	[Token(Token = "0x1700000C")]
	public ReadOnlySpan<ScriptableRenderer> renderers
	{
		[Address(RVA = "0x2D67ED0", Offset = "0x2D672D0", Length = "0x57")]
		[Token(Token = "0x6000041")]
		 get { } //Length: 87
	}

	[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(2023.3)")]
	[Token(Token = "0x17000058")]
	public virtual String[] renderingLayerMaskNames
	{
		[Address(RVA = "0x2D67F30", Offset = "0x2D67330", Length = "0x40")]
		[Token(Token = "0x60000CC")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000056")]
	public virtual string renderPipelineShaderTag
	{
		[Address(RVA = "0x2D67DC0", Offset = "0x2D671C0", Length = "0x2C")]
		[Token(Token = "0x60000CA")]
		 get { } //Length: 44
	}

	[Token(Token = "0x1700001B")]
	public float renderScale
	{
		[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
		[Token(Token = "0x600005E")]
		 get { } //Length: 6
		[Address(RVA = "0x2D68810", Offset = "0x2D67C10", Length = "0x75")]
		[Token(Token = "0x600005F")]
		 set { } //Length: 117
	}

	[Token(Token = "0x17000057")]
	protected virtual bool requiresCompatibleRenderPipelineGlobalSettings
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60000CB")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700000E")]
	public ScriptableRenderer scriptableRenderer
	{
		[Address(RVA = "0x2D68020", Offset = "0x2D67420", Length = "0x25D")]
		[Token(Token = "0x600004A")]
		 get { } //Length: 605
	}

	[Token(Token = "0x1700000F")]
	internal ScriptableRendererData scriptableRendererData
	{
		[Address(RVA = "0x2D67F70", Offset = "0x2D67370", Length = "0xAA")]
		[Token(Token = "0x600004C")]
		internal get { } //Length: 170
	}

	[Obsolete("Use GraphicsSettings.GetRenderPipelineSettings<ShaderStrippingSetting>().shaderVariantLogLevel instead. #from(2022.2)")]
	[Token(Token = "0x1700006D")]
	public ShaderVariantLogLevel shaderVariantLogLevel
	{
		[Address(RVA = "0x2D68280", Offset = "0x2D67680", Length = "0x5F")]
		[Token(Token = "0x60000ED")]
		 get { } //Length: 95
		[Address(RVA = "0x2D68890", Offset = "0x2D67C90", Length = "0x6D")]
		[Token(Token = "0x60000EE")]
		 set { } //Length: 109
	}

	[Token(Token = "0x1700003A")]
	public int shadowCascadeCount
	{
		[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
		[Token(Token = "0x600009C")]
		 get { } //Length: 7
		[Address(RVA = "0x2D68900", Offset = "0x2D67D00", Length = "0xEA")]
		[Token(Token = "0x600009D")]
		 set { } //Length: 234
	}

	[Obsolete("This is obsolete, please use shadowCascadeCount instead. #from(2021.1) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x1700006E")]
	public ShadowCascadesOption shadowCascadeOption
	{
		[Address(RVA = "0x2D682E0", Offset = "0x2D676E0", Length = "0x8B")]
		[Token(Token = "0x60000EF")]
		 get { } //Length: 139
		[Address(RVA = "0x2D689F0", Offset = "0x2D67DF0", Length = "0x97")]
		[Token(Token = "0x60000F0")]
		 set { } //Length: 151
	}

	[Token(Token = "0x1700003F")]
	public float shadowDepthBias
	{
		[Address(RVA = "0x2D68370", Offset = "0x2D67770", Length = "0x9")]
		[Token(Token = "0x60000A6")]
		 get { } //Length: 9
		[Address(RVA = "0x2D68A90", Offset = "0x2D67E90", Length = "0x67")]
		[Token(Token = "0x60000A7")]
		 set { } //Length: 103
	}

	[Token(Token = "0x17000039")]
	public float shadowDistance
	{
		[Address(RVA = "0x2D68380", Offset = "0x2D67780", Length = "0x9")]
		[Token(Token = "0x600009A")]
		 get { } //Length: 9
		[Address(RVA = "0x2D68B00", Offset = "0x2D67F00", Length = "0x12")]
		[Token(Token = "0x600009B")]
		 set { } //Length: 18
	}

	[Token(Token = "0x17000040")]
	public float shadowNormalBias
	{
		[Address(RVA = "0x2D68390", Offset = "0x2D67790", Length = "0x9")]
		[Token(Token = "0x60000A8")]
		 get { } //Length: 9
		[Address(RVA = "0x2D68B20", Offset = "0x2D67F20", Length = "0x67")]
		[Token(Token = "0x60000A9")]
		 set { } //Length: 103
	}

	[Token(Token = "0x17000022")]
	public internal ShEvalMode shEvalMode
	{
		[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
		[Token(Token = "0x6000069")]
		 get { } //Length: 4
		[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
		[Token(Token = "0x600006A")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700005D")]
	public float smallMeshScreenPercentage
	{
		[Address(RVA = "0x2D25F90", Offset = "0x2D25390", Length = "0x9")]
		[Token(Token = "0x60000D4")]
		 get { } //Length: 9
		[Address(RVA = "0x2D68B90", Offset = "0x2D67F90", Length = "0xB5")]
		[Token(Token = "0x60000D5")]
		 set { } //Length: 181
	}

	[Token(Token = "0x17000042")]
	internal SoftShadowQuality softShadowQuality
	{
		[Address(RVA = "0x26CB680", Offset = "0x26CAA80", Length = "0x7")]
		[Token(Token = "0x60000AC")]
		internal get { } //Length: 7
		[Address(RVA = "0x2D68C50", Offset = "0x2D68050", Length = "0x7")]
		[Token(Token = "0x60000AD")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000017")]
	public StoreActionsOptimization storeActionsOptimization
	{
		[Address(RVA = "0x1E17330", Offset = "0x1E16730", Length = "0x7")]
		[Token(Token = "0x6000056")]
		 get { } //Length: 7
		[Address(RVA = "0x1D0F9B0", Offset = "0x1D0EDB0", Length = "0x7")]
		[Token(Token = "0x6000057")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000052")]
	public bool supportDataDrivenLensFlare
	{
		[Address(RVA = "0x2D683A0", Offset = "0x2D677A0", Length = "0x8")]
		[Token(Token = "0x60000C3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700005E")]
	public override bool supportProbeVolume
	{
		[Address(RVA = "0x2D683D0", Offset = "0x2D677D0", Length = "0x8")]
		[Token(Token = "0x60000DD")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000028")]
	public internal bool supportProbeVolumeDiskStreaming
	{
		[Address(RVA = "0x119FB50", Offset = "0x119EF50", Length = "0x8")]
		[Token(Token = "0x6000075")]
		 get { } //Length: 8
		[Address(RVA = "0x119FC40", Offset = "0x119F040", Length = "0x7")]
		[Token(Token = "0x6000076")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000027")]
	public internal bool supportProbeVolumeGPUStreaming
	{
		[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
		[Token(Token = "0x6000073")]
		 get { } //Length: 8
		[Address(RVA = "0x2141040", Offset = "0x2140440", Length = "0x7")]
		[Token(Token = "0x6000074")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700002A")]
	public internal bool supportProbeVolumeScenarioBlending
	{
		[Address(RVA = "0x2D683B0", Offset = "0x2D677B0", Length = "0x8")]
		[Token(Token = "0x6000079")]
		 get { } //Length: 8
		[Address(RVA = "0x2D68C60", Offset = "0x2D68060", Length = "0x7")]
		[Token(Token = "0x600007A")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000029")]
	public internal bool supportProbeVolumeScenarios
	{
		[Address(RVA = "0x2D683C0", Offset = "0x2D677C0", Length = "0x8")]
		[Token(Token = "0x6000077")]
		 get { } //Length: 8
		[Address(RVA = "0x2D68C70", Offset = "0x2D68070", Length = "0x7")]
		[Token(Token = "0x6000078")]
		internal set { } //Length: 7
	}

	[Obsolete("This is obsolete, use supportProbeVolumeGPUStreaming instead. #from(2023.3)")]
	[Token(Token = "0x17000026")]
	public internal bool supportProbeVolumeStreaming
	{
		[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
		[Token(Token = "0x6000071")]
		 get { } //Length: 8
		[Address(RVA = "0x2141040", Offset = "0x2140440", Length = "0x7")]
		[Token(Token = "0x6000072")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000031")]
	public internal bool supportsAdditionalLightShadows
	{
		[Address(RVA = "0x2C0C620", Offset = "0x2C0BA20", Length = "0x8")]
		[Token(Token = "0x6000087")]
		 get { } //Length: 8
		[Address(RVA = "0x2C0C670", Offset = "0x2C0BA70", Length = "0x7")]
		[Token(Token = "0x6000088")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000013")]
	public bool supportsCameraDepthTexture
	{
		[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
		[Token(Token = "0x6000050")]
		 get { } //Length: 5
		[Address(RVA = "0x29E48A0", Offset = "0x29E3CA0", Length = "0x4")]
		[Token(Token = "0x6000051")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000014")]
	public bool supportsCameraOpaqueTexture
	{
		[Address(RVA = "0x2522A90", Offset = "0x2521E90", Length = "0x5")]
		[Token(Token = "0x6000052")]
		 get { } //Length: 5
		[Address(RVA = "0x2D68C80", Offset = "0x2D68080", Length = "0x4")]
		[Token(Token = "0x6000053")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000051")]
	public bool supportScreenSpaceLensFlare
	{
		[Address(RVA = "0x2D683E0", Offset = "0x2D677E0", Length = "0x8")]
		[Token(Token = "0x60000C2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000043")]
	public bool supportsDynamicBatching
	{
		[Address(RVA = "0x2D683F0", Offset = "0x2D677F0", Length = "0x8")]
		[Token(Token = "0x60000AE")]
		 get { } //Length: 8
		[Address(RVA = "0x2D68C90", Offset = "0x2D68090", Length = "0x7")]
		[Token(Token = "0x60000AF")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000018")]
	public bool supportsHDR
	{
		[Address(RVA = "0x1CF2BF0", Offset = "0x1CF1FF0", Length = "0x5")]
		[Token(Token = "0x6000058")]
		 get { } //Length: 5
		[Address(RVA = "0x2D58080", Offset = "0x2D57480", Length = "0x4")]
		[Token(Token = "0x6000059")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000045")]
	public bool supportsLightCookies
	{
		[Address(RVA = "0x2D68400", Offset = "0x2D67800", Length = "0x8")]
		[Token(Token = "0x60000B1")]
		 get { } //Length: 8
	}

	[Obsolete("This is obsolete, use useRenderingLayers instead. #from(2023.1) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x17000046")]
	public bool supportsLightLayers
	{
		[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
		[Token(Token = "0x60000B2")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700002D")]
	public internal bool supportsMainLightShadows
	{
		[Address(RVA = "0x1D39570", Offset = "0x1D38970", Length = "0x8")]
		[Token(Token = "0x600007F")]
		 get { } //Length: 8
		[Address(RVA = "0x2D68CA0", Offset = "0x2D680A0", Length = "0x7")]
		[Token(Token = "0x6000080")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000044")]
	public bool supportsMixedLighting
	{
		[Address(RVA = "0x2D68410", Offset = "0x2D67810", Length = "0x8")]
		[Token(Token = "0x60000B0")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000041")]
	public internal bool supportsSoftShadows
	{
		[Address(RVA = "0x661660", Offset = "0x660A60", Length = "0x8")]
		[Token(Token = "0x60000AA")]
		 get { } //Length: 8
		[Address(RVA = "0x661760", Offset = "0x660B60", Length = "0x7")]
		[Token(Token = "0x60000AB")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000016")]
	public bool supportsTerrainHoles
	{
		[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
		[Token(Token = "0x6000055")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006C")]
	public virtual Shader terrainDetailGrassBillboardShader
	{
		[Address(RVA = "0x2D68420", Offset = "0x2D67820", Length = "0x7E")]
		[Token(Token = "0x60000EC")]
		 get { } //Length: 126
	}

	[Token(Token = "0x1700006B")]
	public virtual Shader terrainDetailGrassShader
	{
		[Address(RVA = "0x2D684A0", Offset = "0x2D678A0", Length = "0x7E")]
		[Token(Token = "0x60000EB")]
		 get { } //Length: 126
	}

	[Token(Token = "0x1700006A")]
	public virtual Shader terrainDetailLitShader
	{
		[Address(RVA = "0x2D68520", Offset = "0x2D67920", Length = "0x7E")]
		[Token(Token = "0x60000EA")]
		 get { } //Length: 126
	}

	[Obsolete("Moved to UniversalRenderPipelineRuntimeTextures on GraphicsSettings. #from(2023.3)")]
	[Token(Token = "0x1700006F")]
	public TextureResources textures
	{
		[Address(RVA = "0x2D685A0", Offset = "0x2D679A0", Length = "0x75")]
		[Token(Token = "0x60000F1")]
		 get { } //Length: 117
	}

	[Token(Token = "0x1700000A")]
	private override GPUResidentDrawerSettings UnityEngine.Rendering.IGPUResidentRenderPipeline.gpuResidentDrawerSettings
	{
		[Address(RVA = "0x2D670E0", Offset = "0x2D664E0", Length = "0xB5")]
		[Token(Token = "0x600003F")]
		private get { } //Length: 181
	}

	[Token(Token = "0x1700001F")]
	public string upscalerName
	{
		[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
		[Token(Token = "0x6000064")]
		 get { } //Length: 18
	}

	[Token(Token = "0x1700001E")]
	public UpscalingFilterSelection upscalingFilter
	{
		[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
		[Token(Token = "0x6000062")]
		 get { } //Length: 4
		[Address(RVA = "0x121E600", Offset = "0x121DA00", Length = "0x4")]
		[Token(Token = "0x6000063")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000053")]
	public bool useAdaptivePerformance
	{
		[Address(RVA = "0x2D68620", Offset = "0x2D67A20", Length = "0x8")]
		[Token(Token = "0x60000C4")]
		 get { } //Length: 8
		[Address(RVA = "0x2D68CB0", Offset = "0x2D680B0", Length = "0x7")]
		[Token(Token = "0x60000C5")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000050")]
	public bool useFastSRGBLinearConversion
	{
		[Address(RVA = "0x2D68630", Offset = "0x2D67A30", Length = "0x8")]
		[Token(Token = "0x60000C1")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000047")]
	public bool useRenderingLayers
	{
		[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
		[Token(Token = "0x60000B3")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700004B")]
	public bool useSRPBatcher
	{
		[Address(RVA = "0xE26A30", Offset = "0xE25E30", Length = "0x8")]
		[Token(Token = "0x60000B8")]
		 get { } //Length: 8
		[Address(RVA = "0xE26E70", Offset = "0xE26270", Length = "0x7")]
		[Token(Token = "0x60000B9")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000048")]
	public VolumeFrameworkUpdateMode volumeFrameworkUpdateMode
	{
		[Address(RVA = "0x26CB610", Offset = "0x26CAA10", Length = "0x7")]
		[Token(Token = "0x60000B4")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000049")]
	public VolumeProfile volumeProfile
	{
		[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
		[Token(Token = "0x60000B5")]
		 get { } //Length: 8
		[Address(RVA = "0x29B4B40", Offset = "0x29B3F40", Length = "0x13")]
		[Token(Token = "0x60000B6")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x2D674B0", Offset = "0x2D668B0", Length = "0x236")]
	[Token(Token = "0x60000F5")]
	private static UniversalRenderPipelineAsset() { }

	[Address(RVA = "0x2D676F0", Offset = "0x2D66AF0", Length = "0x286")]
	[Token(Token = "0x60000F4")]
	public UniversalRenderPipelineAsset() { }

	[Address(RVA = "0x2D662E0", Offset = "0x2D656E0", Length = "0x1A0")]
	[Token(Token = "0x6000045")]
	protected virtual RenderPipeline CreatePipeline() { }

	[Address(RVA = "0x2D66490", Offset = "0x2D65890", Length = "0x25A")]
	[Token(Token = "0x6000049")]
	private void CreateRenderers() { }

	[Address(RVA = "0x2D666F0", Offset = "0x2D65AF0", Length = "0x35")]
	[Token(Token = "0x6000047")]
	private void DestroyRenderer(ref ScriptableRenderer renderer) { }

	[Address(RVA = "0x2D66730", Offset = "0x2D65B30", Length = "0xAC")]
	[Token(Token = "0x6000046")]
	internal void DestroyRenderers() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000044")]
	protected virtual void EnsureGlobalSettings() { }

	[Address(RVA = "0x2D67980", Offset = "0x2D66D80", Length = "0x20C")]
	[Token(Token = "0x600004D")]
	internal GraphicsFormat get_additionalLightsCookieFormat() { }

	[Address(RVA = "0x2D67B90", Offset = "0x2D66F90", Length = "0x14")]
	[Token(Token = "0x600004E")]
	internal Vector2Int get_additionalLightsCookieResolution() { }

	[Address(RVA = "0x25E2B40", Offset = "0x25E1F40", Length = "0x7")]
	[Token(Token = "0x6000083")]
	public LightRenderingMode get_additionalLightsRenderingMode() { }

	[Address(RVA = "0x1D62670", Offset = "0x1D61A70", Length = "0x7")]
	[Token(Token = "0x6000089")]
	public int get_additionalLightsShadowmapResolution() { }

	[Address(RVA = "0x1F7B3D0", Offset = "0x1F7A7D0", Length = "0x7")]
	[Token(Token = "0x600008F")]
	public int get_additionalLightsShadowResolutionTierHigh() { }

	[Address(RVA = "0x1F7B610", Offset = "0x1F7AA10", Length = "0x7")]
	[Token(Token = "0x600008B")]
	public int get_additionalLightsShadowResolutionTierLow() { }

	[Address(RVA = "0x1D59140", Offset = "0x1D58540", Length = "0x7")]
	[Token(Token = "0x600008D")]
	public int get_additionalLightsShadowResolutionTierMedium() { }

	[Address(RVA = "0x2D67BB0", Offset = "0x2D66FB0", Length = "0x8")]
	[Token(Token = "0x60000C0")]
	public bool get_allowPostProcessAlphaOutput() { }

	[Address(RVA = "0x2D67BC0", Offset = "0x2D66FC0", Length = "0x9")]
	[Token(Token = "0x600009E")]
	public float get_cascade2Split() { }

	[Address(RVA = "0x2D67BD0", Offset = "0x2D66FD0", Length = "0x19")]
	[Token(Token = "0x60000A0")]
	public Vector2 get_cascade3Split() { }

	[Address(RVA = "0x2D67BF0", Offset = "0x2D66FF0", Length = "0x19")]
	[Token(Token = "0x60000A2")]
	public Vector3 get_cascade4Split() { }

	[Address(RVA = "0x2D67C10", Offset = "0x2D67010", Length = "0x9")]
	[Token(Token = "0x60000A4")]
	public float get_cascadeBorder() { }

	[Address(RVA = "0x1E2A1B0", Offset = "0x1E295B0", Length = "0x7")]
	[Token(Token = "0x60000BE")]
	public int get_colorGradingLutSize() { }

	[Address(RVA = "0x1E2A1A0", Offset = "0x1E295A0", Length = "0x7")]
	[Token(Token = "0x60000BC")]
	public ColorGradingMode get_colorGradingMode() { }

	[Address(RVA = "0x22E91E0", Offset = "0x22E85E0", Length = "0x8")]
	[Token(Token = "0x60000C6")]
	public bool get_conservativeEnclosingSphere() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60000B7")]
	public PipelineDebugLevel get_debugLevel() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60000E8")]
	public Material get_decalMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60000E7")]
	public virtual Material get_default2DMaskMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60000E6")]
	public virtual Material get_default2DMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60000E4")]
	public virtual Material get_defaultLineMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60000E2")]
	public virtual Material get_defaultMaterial() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60000E3")]
	public virtual Material get_defaultParticleMaterial() { }

	[Address(RVA = "0x2D67C20", Offset = "0x2D67020", Length = "0xB2")]
	[Token(Token = "0x60000E9")]
	public virtual Shader get_defaultShader() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60000E5")]
	public virtual Material get_defaultTerrainMaterial() { }

	[Address(RVA = "0xD89250", Offset = "0xD88650", Length = "0x5")]
	[Token(Token = "0x6000060")]
	public bool get_enableLODCrossFade() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60000BA")]
	public bool get_enableRenderGraph() { }

	[Address(RVA = "0x115EBA0", Offset = "0x115DFA0", Length = "0x5")]
	[Token(Token = "0x6000065")]
	public bool get_fsrOverrideSharpness() { }

	[Address(RVA = "0x16D0800", Offset = "0x16CFC00", Length = "0x6")]
	[Token(Token = "0x6000067")]
	public float get_fsrSharpness() { }

	[Address(RVA = "0x26CB3C0", Offset = "0x26CA7C0", Length = "0x8")]
	[Token(Token = "0x60000D1")]
	public bool get_gpuResidentDrawerEnableOcclusionCullingInCameras() { }

	[Address(RVA = "0x2D67CE0", Offset = "0x2D670E0", Length = "0x8")]
	[Token(Token = "0x60000CF")]
	public override GPUResidentDrawerMode get_gpuResidentDrawerMode() { }

	[Address(RVA = "0x1CD8B40", Offset = "0x1CD7F40", Length = "0x4")]
	[Token(Token = "0x600005A")]
	public HDRColorBufferPrecision get_hdrColorBufferPrecision() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60000F2")]
	public IntermediateTextureMode get_intermediateTextureMode() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000042")]
	public override bool get_isImmediateModeSupported() { }

	[Address(RVA = "0x2D67CF0", Offset = "0x2D670F0", Length = "0x8")]
	[Token(Token = "0x60000E0")]
	public override bool get_isStpUsed() { }

	[Address(RVA = "0x2D67D00", Offset = "0x2D67100", Length = "0x32")]
	[Token(Token = "0x60000CE")]
	public String[] get_lightLayerMaskNames() { }

	[Address(RVA = "0x20F1B70", Offset = "0x20F0F70", Length = "0x4")]
	[Token(Token = "0x600006B")]
	public LightProbeSystem get_lightProbeSystem() { }

	[Address(RVA = "0x2424CF0", Offset = "0x24240F0", Length = "0x4")]
	[Token(Token = "0x6000061")]
	public LODCrossFadeDitheringType get_lodCrossFadeDitheringType() { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[Token(Token = "0x600007D")]
	public LightRenderingMode get_mainLightRenderingMode() { }

	[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
	[Token(Token = "0x6000081")]
	public int get_mainLightShadowmapResolution() { }

	[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
	[Token(Token = "0x6000085")]
	public int get_maxAdditionalLightsCount() { }

	[Address(RVA = "0x2D67D40", Offset = "0x2D67140", Length = "0x12")]
	[Token(Token = "0x60000DE")]
	public override ProbeVolumeSHBands get_maxSHBands() { }

	[Address(RVA = "0x1D530E0", Offset = "0x1D524E0", Length = "0x4")]
	[Token(Token = "0x600005C")]
	public int get_msaaSampleCount() { }

	[Address(RVA = "0x2D67D60", Offset = "0x2D67160", Length = "0x7")]
	[Token(Token = "0x60000C8")]
	public int get_numIterationsEnclosingSphere() { }

	[Address(RVA = "0xFE28F0", Offset = "0xFE1CF0", Length = "0x4")]
	[Token(Token = "0x6000054")]
	public Downsampling get_opaqueDownsampling() { }

	[Address(RVA = "0x2D67D70", Offset = "0x2D67170", Length = "0x30")]
	[Token(Token = "0x60000CD")]
	public virtual String[] get_prefixedRenderingLayerMaskNames() { }

	[Address(RVA = "0xD11A50", Offset = "0xD10E50", Length = "0x7")]
	[Token(Token = "0x600006F")]
	public ProbeVolumeBlendingTextureMemoryBudget get_probeVolumeBlendingMemoryBudget() { }

	[Address(RVA = "0xE269A0", Offset = "0xE25DA0", Length = "0x7")]
	[Token(Token = "0x600006D")]
	public ProbeVolumeTextureMemoryBudget get_probeVolumeMemoryBudget() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60000DF")]
	public override ProbeVolumeSceneData get_probeVolumeSceneData() { }

	[Address(RVA = "0xD11AE0", Offset = "0xD10EE0", Length = "0x7")]
	[Token(Token = "0x600007B")]
	public ProbeVolumeSHBands get_probeVolumeSHBands() { }

	[Address(RVA = "0x2D67DA0", Offset = "0x2D671A0", Length = "0x8")]
	[Token(Token = "0x6000097")]
	public bool get_reflectionProbeAtlas() { }

	[Address(RVA = "0x2D67DB0", Offset = "0x2D671B0", Length = "0x8")]
	[Token(Token = "0x6000092")]
	public bool get_reflectionProbeBlending() { }

	[Address(RVA = "0x29FAD00", Offset = "0x29FA100", Length = "0x8")]
	[Token(Token = "0x6000095")]
	public bool get_reflectionProbeBoxProjection() { }

	[Address(RVA = "0x2D67DF0", Offset = "0x2D671F0", Length = "0x57")]
	[Token(Token = "0x6000040")]
	public ReadOnlySpan<ScriptableRendererData> get_rendererDataList() { }

	[Address(RVA = "0x2D67E50", Offset = "0x2D67250", Length = "0x7E")]
	[Token(Token = "0x600004F")]
	internal Int32[] get_rendererIndexList() { }

	[Address(RVA = "0x2D67ED0", Offset = "0x2D672D0", Length = "0x57")]
	[Token(Token = "0x6000041")]
	public ReadOnlySpan<ScriptableRenderer> get_renderers() { }

	[Address(RVA = "0x2D67F30", Offset = "0x2D67330", Length = "0x40")]
	[Token(Token = "0x60000CC")]
	public virtual String[] get_renderingLayerMaskNames() { }

	[Address(RVA = "0x2D67DC0", Offset = "0x2D671C0", Length = "0x2C")]
	[Token(Token = "0x60000CA")]
	public virtual string get_renderPipelineShaderTag() { }

	[Address(RVA = "0x1CE4450", Offset = "0x1CE3850", Length = "0x6")]
	[Token(Token = "0x600005E")]
	public float get_renderScale() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60000CB")]
	protected virtual bool get_requiresCompatibleRenderPipelineGlobalSettings() { }

	[Address(RVA = "0x2D68020", Offset = "0x2D67420", Length = "0x25D")]
	[Token(Token = "0x600004A")]
	public ScriptableRenderer get_scriptableRenderer() { }

	[Address(RVA = "0x2D67F70", Offset = "0x2D67370", Length = "0xAA")]
	[Token(Token = "0x600004C")]
	internal ScriptableRendererData get_scriptableRendererData() { }

	[Address(RVA = "0x2D68280", Offset = "0x2D67680", Length = "0x5F")]
	[Token(Token = "0x60000ED")]
	public ShaderVariantLogLevel get_shaderVariantLogLevel() { }

	[Address(RVA = "0x1BC5710", Offset = "0x1BC4B10", Length = "0x7")]
	[Token(Token = "0x600009C")]
	public int get_shadowCascadeCount() { }

	[Address(RVA = "0x2D682E0", Offset = "0x2D676E0", Length = "0x8B")]
	[Token(Token = "0x60000EF")]
	public ShadowCascadesOption get_shadowCascadeOption() { }

	[Address(RVA = "0x2D68370", Offset = "0x2D67770", Length = "0x9")]
	[Token(Token = "0x60000A6")]
	public float get_shadowDepthBias() { }

	[Address(RVA = "0x2D68380", Offset = "0x2D67780", Length = "0x9")]
	[Token(Token = "0x600009A")]
	public float get_shadowDistance() { }

	[Address(RVA = "0x2D68390", Offset = "0x2D67790", Length = "0x9")]
	[Token(Token = "0x60000A8")]
	public float get_shadowNormalBias() { }

	[Address(RVA = "0x1D16D20", Offset = "0x1D16120", Length = "0x4")]
	[Token(Token = "0x6000069")]
	public ShEvalMode get_shEvalMode() { }

	[Address(RVA = "0x2D25F90", Offset = "0x2D25390", Length = "0x9")]
	[Token(Token = "0x60000D4")]
	public float get_smallMeshScreenPercentage() { }

	[Address(RVA = "0x26CB680", Offset = "0x26CAA80", Length = "0x7")]
	[Token(Token = "0x60000AC")]
	internal SoftShadowQuality get_softShadowQuality() { }

	[Address(RVA = "0x1E17330", Offset = "0x1E16730", Length = "0x7")]
	[Token(Token = "0x6000056")]
	public StoreActionsOptimization get_storeActionsOptimization() { }

	[Address(RVA = "0x2D683A0", Offset = "0x2D677A0", Length = "0x8")]
	[Token(Token = "0x60000C3")]
	public bool get_supportDataDrivenLensFlare() { }

	[Address(RVA = "0x2D683D0", Offset = "0x2D677D0", Length = "0x8")]
	[Token(Token = "0x60000DD")]
	public override bool get_supportProbeVolume() { }

	[Address(RVA = "0x119FB50", Offset = "0x119EF50", Length = "0x8")]
	[Token(Token = "0x6000075")]
	public bool get_supportProbeVolumeDiskStreaming() { }

	[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
	[Token(Token = "0x6000073")]
	public bool get_supportProbeVolumeGPUStreaming() { }

	[Address(RVA = "0x2D683B0", Offset = "0x2D677B0", Length = "0x8")]
	[Token(Token = "0x6000079")]
	public bool get_supportProbeVolumeScenarioBlending() { }

	[Address(RVA = "0x2D683C0", Offset = "0x2D677C0", Length = "0x8")]
	[Token(Token = "0x6000077")]
	public bool get_supportProbeVolumeScenarios() { }

	[Address(RVA = "0x1D4E570", Offset = "0x1D4D970", Length = "0x8")]
	[Token(Token = "0x6000071")]
	public bool get_supportProbeVolumeStreaming() { }

	[Address(RVA = "0x2C0C620", Offset = "0x2C0BA20", Length = "0x8")]
	[Token(Token = "0x6000087")]
	public bool get_supportsAdditionalLightShadows() { }

	[Address(RVA = "0x1CF2CC0", Offset = "0x1CF20C0", Length = "0x5")]
	[Token(Token = "0x6000050")]
	public bool get_supportsCameraDepthTexture() { }

	[Address(RVA = "0x2522A90", Offset = "0x2521E90", Length = "0x5")]
	[Token(Token = "0x6000052")]
	public bool get_supportsCameraOpaqueTexture() { }

	[Address(RVA = "0x2D683E0", Offset = "0x2D677E0", Length = "0x8")]
	[Token(Token = "0x60000C2")]
	public bool get_supportScreenSpaceLensFlare() { }

	[Address(RVA = "0x2D683F0", Offset = "0x2D677F0", Length = "0x8")]
	[Token(Token = "0x60000AE")]
	public bool get_supportsDynamicBatching() { }

	[Address(RVA = "0x1CF2BF0", Offset = "0x1CF1FF0", Length = "0x5")]
	[Token(Token = "0x6000058")]
	public bool get_supportsHDR() { }

	[Address(RVA = "0x2D68400", Offset = "0x2D67800", Length = "0x8")]
	[Token(Token = "0x60000B1")]
	public bool get_supportsLightCookies() { }

	[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
	[Token(Token = "0x60000B2")]
	public bool get_supportsLightLayers() { }

	[Address(RVA = "0x1D39570", Offset = "0x1D38970", Length = "0x8")]
	[Token(Token = "0x600007F")]
	public bool get_supportsMainLightShadows() { }

	[Address(RVA = "0x2D68410", Offset = "0x2D67810", Length = "0x8")]
	[Token(Token = "0x60000B0")]
	public bool get_supportsMixedLighting() { }

	[Address(RVA = "0x661660", Offset = "0x660A60", Length = "0x8")]
	[Token(Token = "0x60000AA")]
	public bool get_supportsSoftShadows() { }

	[Address(RVA = "0x1CF2DD0", Offset = "0x1CF21D0", Length = "0x5")]
	[Token(Token = "0x6000055")]
	public bool get_supportsTerrainHoles() { }

	[Address(RVA = "0x2D68420", Offset = "0x2D67820", Length = "0x7E")]
	[Token(Token = "0x60000EC")]
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	[Address(RVA = "0x2D684A0", Offset = "0x2D678A0", Length = "0x7E")]
	[Token(Token = "0x60000EB")]
	public virtual Shader get_terrainDetailGrassShader() { }

	[Address(RVA = "0x2D68520", Offset = "0x2D67920", Length = "0x7E")]
	[Token(Token = "0x60000EA")]
	public virtual Shader get_terrainDetailLitShader() { }

	[Address(RVA = "0x2D685A0", Offset = "0x2D679A0", Length = "0x75")]
	[Token(Token = "0x60000F1")]
	public TextureResources get_textures() { }

	[Address(RVA = "0x11EDDE0", Offset = "0x11ED1E0", Length = "0x12")]
	[Token(Token = "0x6000064")]
	public string get_upscalerName() { }

	[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
	[Token(Token = "0x6000062")]
	public UpscalingFilterSelection get_upscalingFilter() { }

	[Address(RVA = "0x2D68620", Offset = "0x2D67A20", Length = "0x8")]
	[Token(Token = "0x60000C4")]
	public bool get_useAdaptivePerformance() { }

	[Address(RVA = "0x2D68630", Offset = "0x2D67A30", Length = "0x8")]
	[Token(Token = "0x60000C1")]
	public bool get_useFastSRGBLinearConversion() { }

	[Address(RVA = "0x2142440", Offset = "0x2141840", Length = "0x8")]
	[Token(Token = "0x60000B3")]
	public bool get_useRenderingLayers() { }

	[Address(RVA = "0xE26A30", Offset = "0xE25E30", Length = "0x8")]
	[Token(Token = "0x60000B8")]
	public bool get_useSRPBatcher() { }

	[Address(RVA = "0x26CB610", Offset = "0x26CAA10", Length = "0x7")]
	[Token(Token = "0x60000B4")]
	public VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode() { }

	[Address(RVA = "0x1CF2820", Offset = "0x1CF1C20", Length = "0x8")]
	[Token(Token = "0x60000B5")]
	public VolumeProfile get_volumeProfile() { }

	[Address(RVA = "0x2D667E0", Offset = "0x2D65BE0", Length = "0xC8")]
	[Token(Token = "0x6000091")]
	internal int GetAdditionalLightsShadowResolution(int additionalLightsShadowResolutionTier) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x60000E1")]
	private Material GetMaterial(DefaultMaterialType materialType) { }

	[Address(RVA = "0x2D668B0", Offset = "0x2D65CB0", Length = "0x2E1")]
	[Token(Token = "0x600004B")]
	public ScriptableRenderer GetRenderer(int index) { }

	[Address(RVA = "0x2D66BA0", Offset = "0x2D65FA0", Length = "0x8")]
	[Token(Token = "0x600003E")]
	internal bool IsAtLastVersion() { }

	[Address(RVA = "0x2D66BB0", Offset = "0x2D65FB0", Length = "0x166")]
	[Token(Token = "0x60000D3")]
	public override bool IsGPUResidentDrawerSupportedBySRP(out string message, out LogType severity) { }

	[Address(RVA = "0x2D66D20", Offset = "0x2D66120", Length = "0x4F")]
	[Token(Token = "0x6000043")]
	public ScriptableRendererData LoadBuiltinRendererData(RendererType type = 1) { }

	[Address(RVA = "0x2D66D70", Offset = "0x2D66170", Length = "0x2D2")]
	[Token(Token = "0x60000D7")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000D6")]
	public override void OnBeforeSerialize() { }

	[Address(RVA = "0x2D67050", Offset = "0x2D66450", Length = "0x1F")]
	[Token(Token = "0x6000048")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x2D67070", Offset = "0x2D66470", Length = "0x14")]
	[Token(Token = "0x60000BB")]
	internal void OnEnableRenderGraphChanged() { }

	[Address(RVA = "0x2A057F0", Offset = "0x2A04BF0", Length = "0x7")]
	[Token(Token = "0x6000084")]
	internal void set_additionalLightsRenderingMode(LightRenderingMode value) { }

	[Address(RVA = "0x2C9FC60", Offset = "0x2C9F060", Length = "0x7")]
	[Token(Token = "0x600008A")]
	public void set_additionalLightsShadowmapResolution(int value) { }

	[Address(RVA = "0x2D68640", Offset = "0x2D67A40", Length = "0x7")]
	[Token(Token = "0x6000090")]
	internal void set_additionalLightsShadowResolutionTierHigh(int value) { }

	[Address(RVA = "0x21AD620", Offset = "0x21ACA20", Length = "0x7")]
	[Token(Token = "0x600008C")]
	internal void set_additionalLightsShadowResolutionTierLow(int value) { }

	[Address(RVA = "0x1D58B00", Offset = "0x1D57F00", Length = "0x7")]
	[Token(Token = "0x600008E")]
	internal void set_additionalLightsShadowResolutionTierMedium(int value) { }

	[Address(RVA = "0x2D68650", Offset = "0x2D67A50", Length = "0x9")]
	[Token(Token = "0x600009F")]
	public void set_cascade2Split(float value) { }

	[Address(RVA = "0x2D68660", Offset = "0x2D67A60", Length = "0x8")]
	[Token(Token = "0x60000A1")]
	public void set_cascade3Split(Vector2 value) { }

	[Address(RVA = "0x1D5E140", Offset = "0x1D5D540", Length = "0x16")]
	[Token(Token = "0x60000A3")]
	public void set_cascade4Split(Vector3 value) { }

	[Address(RVA = "0x2D68670", Offset = "0x2D67A70", Length = "0x9")]
	[Token(Token = "0x60000A5")]
	public void set_cascadeBorder(float value) { }

	[Address(RVA = "0x2D68680", Offset = "0x2D67A80", Length = "0x27")]
	[Token(Token = "0x60000BF")]
	public void set_colorGradingLutSize(int value) { }

	[Address(RVA = "0x2D686B0", Offset = "0x2D67AB0", Length = "0x7")]
	[Token(Token = "0x60000BD")]
	public void set_colorGradingMode(ColorGradingMode value) { }

	[Address(RVA = "0x2D686C0", Offset = "0x2D67AC0", Length = "0x7")]
	[Token(Token = "0x60000C7")]
	public void set_conservativeEnclosingSphere(bool value) { }

	[Address(RVA = "0x115FC10", Offset = "0x115F010", Length = "0x4")]
	[Token(Token = "0x6000066")]
	public void set_fsrOverrideSharpness(bool value) { }

	[Address(RVA = "0x16D0A90", Offset = "0x16CFE90", Length = "0x6")]
	[Token(Token = "0x6000068")]
	public void set_fsrSharpness(float value) { }

	[Address(RVA = "0x2D686D0", Offset = "0x2D67AD0", Length = "0x23")]
	[Token(Token = "0x60000D2")]
	public void set_gpuResidentDrawerEnableOcclusionCullingInCameras(bool value) { }

	[Address(RVA = "0x2D68700", Offset = "0x2D67B00", Length = "0x23")]
	[Token(Token = "0x60000D0")]
	public override void set_gpuResidentDrawerMode(GPUResidentDrawerMode value) { }

	[Address(RVA = "0x1FE3A20", Offset = "0x1FE2E20", Length = "0x4")]
	[Token(Token = "0x600005B")]
	public void set_hdrColorBufferPrecision(HDRColorBufferPrecision value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60000F3")]
	public void set_intermediateTextureMode(IntermediateTextureMode value) { }

	[Address(RVA = "0x1D16670", Offset = "0x1D15A70", Length = "0x4")]
	[Token(Token = "0x600006C")]
	internal void set_lightProbeSystem(LightProbeSystem value) { }

	[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
	[Token(Token = "0x600007E")]
	internal void set_mainLightRenderingMode(LightRenderingMode value) { }

	[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
	[Token(Token = "0x6000082")]
	public void set_mainLightShadowmapResolution(int value) { }

	[Address(RVA = "0x2D68730", Offset = "0x2D67B30", Length = "0x9D")]
	[Token(Token = "0x6000086")]
	public void set_maxAdditionalLightsCount(int value) { }

	[Address(RVA = "0x2471CE0", Offset = "0x24710E0", Length = "0x4")]
	[Token(Token = "0x600005D")]
	public void set_msaaSampleCount(int value) { }

	[Address(RVA = "0x2D687D0", Offset = "0x2D67BD0", Length = "0x7")]
	[Token(Token = "0x60000C9")]
	public void set_numIterationsEnclosingSphere(int value) { }

	[Address(RVA = "0xD11B10", Offset = "0xD10F10", Length = "0x7")]
	[Token(Token = "0x6000070")]
	internal void set_probeVolumeBlendingMemoryBudget(ProbeVolumeBlendingTextureMemoryBudget value) { }

	[Address(RVA = "0xE26DE0", Offset = "0xE261E0", Length = "0x7")]
	[Token(Token = "0x600006E")]
	internal void set_probeVolumeMemoryBudget(ProbeVolumeTextureMemoryBudget value) { }

	[Address(RVA = "0xD11C60", Offset = "0xD11060", Length = "0x7")]
	[Token(Token = "0x600007C")]
	internal void set_probeVolumeSHBands(ProbeVolumeSHBands value) { }

	[Address(RVA = "0x2D687E0", Offset = "0x2D67BE0", Length = "0x7")]
	[Token(Token = "0x6000098")]
	internal void set_reflectionProbeAtlas(bool value) { }

	[Address(RVA = "0x2D687F0", Offset = "0x2D67BF0", Length = "0x7")]
	[Token(Token = "0x6000093")]
	internal void set_reflectionProbeBlending(bool value) { }

	[Address(RVA = "0x2D68800", Offset = "0x2D67C00", Length = "0x7")]
	[Token(Token = "0x6000096")]
	internal void set_reflectionProbeBoxProjection(bool value) { }

	[Address(RVA = "0x2D68810", Offset = "0x2D67C10", Length = "0x75")]
	[Token(Token = "0x600005F")]
	public void set_renderScale(float value) { }

	[Address(RVA = "0x2D68890", Offset = "0x2D67C90", Length = "0x6D")]
	[Token(Token = "0x60000EE")]
	public void set_shaderVariantLogLevel(ShaderVariantLogLevel value) { }

	[Address(RVA = "0x2D68900", Offset = "0x2D67D00", Length = "0xEA")]
	[Token(Token = "0x600009D")]
	public void set_shadowCascadeCount(int value) { }

	[Address(RVA = "0x2D689F0", Offset = "0x2D67DF0", Length = "0x97")]
	[Token(Token = "0x60000F0")]
	public void set_shadowCascadeOption(ShadowCascadesOption value) { }

	[Address(RVA = "0x2D68A90", Offset = "0x2D67E90", Length = "0x67")]
	[Token(Token = "0x60000A7")]
	public void set_shadowDepthBias(float value) { }

	[Address(RVA = "0x2D68B00", Offset = "0x2D67F00", Length = "0x12")]
	[Token(Token = "0x600009B")]
	public void set_shadowDistance(float value) { }

	[Address(RVA = "0x2D68B20", Offset = "0x2D67F20", Length = "0x67")]
	[Token(Token = "0x60000A9")]
	public void set_shadowNormalBias(float value) { }

	[Address(RVA = "0x1D16090", Offset = "0x1D15490", Length = "0x4")]
	[Token(Token = "0x600006A")]
	internal void set_shEvalMode(ShEvalMode value) { }

	[Address(RVA = "0x2D68B90", Offset = "0x2D67F90", Length = "0xB5")]
	[Token(Token = "0x60000D5")]
	public void set_smallMeshScreenPercentage(float value) { }

	[Address(RVA = "0x2D68C50", Offset = "0x2D68050", Length = "0x7")]
	[Token(Token = "0x60000AD")]
	internal void set_softShadowQuality(SoftShadowQuality value) { }

	[Address(RVA = "0x1D0F9B0", Offset = "0x1D0EDB0", Length = "0x7")]
	[Token(Token = "0x6000057")]
	public void set_storeActionsOptimization(StoreActionsOptimization value) { }

	[Address(RVA = "0x119FC40", Offset = "0x119F040", Length = "0x7")]
	[Token(Token = "0x6000076")]
	internal void set_supportProbeVolumeDiskStreaming(bool value) { }

	[Address(RVA = "0x2141040", Offset = "0x2140440", Length = "0x7")]
	[Token(Token = "0x6000074")]
	internal void set_supportProbeVolumeGPUStreaming(bool value) { }

	[Address(RVA = "0x2D68C60", Offset = "0x2D68060", Length = "0x7")]
	[Token(Token = "0x600007A")]
	internal void set_supportProbeVolumeScenarioBlending(bool value) { }

	[Address(RVA = "0x2D68C70", Offset = "0x2D68070", Length = "0x7")]
	[Token(Token = "0x6000078")]
	internal void set_supportProbeVolumeScenarios(bool value) { }

	[Address(RVA = "0x2141040", Offset = "0x2140440", Length = "0x7")]
	[Token(Token = "0x6000072")]
	internal void set_supportProbeVolumeStreaming(bool value) { }

	[Address(RVA = "0x2C0C670", Offset = "0x2C0BA70", Length = "0x7")]
	[Token(Token = "0x6000088")]
	internal void set_supportsAdditionalLightShadows(bool value) { }

	[Address(RVA = "0x29E48A0", Offset = "0x29E3CA0", Length = "0x4")]
	[Token(Token = "0x6000051")]
	public void set_supportsCameraDepthTexture(bool value) { }

	[Address(RVA = "0x2D68C80", Offset = "0x2D68080", Length = "0x4")]
	[Token(Token = "0x6000053")]
	public void set_supportsCameraOpaqueTexture(bool value) { }

	[Address(RVA = "0x2D68C90", Offset = "0x2D68090", Length = "0x7")]
	[Token(Token = "0x60000AF")]
	public void set_supportsDynamicBatching(bool value) { }

	[Address(RVA = "0x2D58080", Offset = "0x2D57480", Length = "0x4")]
	[Token(Token = "0x6000059")]
	public void set_supportsHDR(bool value) { }

	[Address(RVA = "0x2D68CA0", Offset = "0x2D680A0", Length = "0x7")]
	[Token(Token = "0x6000080")]
	internal void set_supportsMainLightShadows(bool value) { }

	[Address(RVA = "0x661760", Offset = "0x660B60", Length = "0x7")]
	[Token(Token = "0x60000AB")]
	internal void set_supportsSoftShadows(bool value) { }

	[Address(RVA = "0x121E600", Offset = "0x121DA00", Length = "0x4")]
	[Token(Token = "0x6000063")]
	public void set_upscalingFilter(UpscalingFilterSelection value) { }

	[Address(RVA = "0x2D68CB0", Offset = "0x2D680B0", Length = "0x7")]
	[Token(Token = "0x60000C5")]
	public void set_useAdaptivePerformance(bool value) { }

	[Address(RVA = "0xE26E70", Offset = "0xE26270", Length = "0x7")]
	[Token(Token = "0x60000B9")]
	public void set_useSRPBatcher(bool value) { }

	[Address(RVA = "0x29B4B40", Offset = "0x29B3F40", Length = "0x13")]
	[Token(Token = "0x60000B6")]
	public void set_volumeProfile(VolumeProfile value) { }

	[Address(RVA = "0x2D67090", Offset = "0x2D66490", Length = "0x28")]
	[Token(Token = "0x6000099")]
	internal bool ShouldUseReflectionProbeAtlasBlending(RenderingMode renderingMode) { }

	[Address(RVA = "0x2D670C0", Offset = "0x2D664C0", Length = "0x14")]
	[Token(Token = "0x6000094")]
	internal bool ShouldUseReflectionProbeBlending() { }

	[Address(RVA = "0x2D670E0", Offset = "0x2D664E0", Length = "0xB5")]
	[Token(Token = "0x600003F")]
	private override GPUResidentDrawerSettings UnityEngine.Rendering.IGPUResidentRenderPipeline.get_gpuResidentDrawerSettings() { }

	[Address(RVA = "0x2D671A0", Offset = "0x2D665A0", Length = "0x89")]
	[Token(Token = "0x60000D9")]
	private int ValidatePerObjectLights(int value) { }

	[Address(RVA = "0x2D673B0", Offset = "0x2D667B0", Length = "0x92")]
	[Token(Token = "0x60000DC")]
	internal bool ValidateRendererData(int index) { }

	[Address(RVA = "0x2D672A0", Offset = "0x2D666A0", Length = "0x107")]
	[Token(Token = "0x60000DB")]
	internal bool ValidateRendererDataList(bool partial = false) { }

	[Address(RVA = "0x2D67230", Offset = "0x2D66630", Length = "0x6D")]
	[Token(Token = "0x60000DA")]
	private float ValidateRenderScale(float value) { }

	[Address(RVA = "0x2D67450", Offset = "0x2D66850", Length = "0x59")]
	[Token(Token = "0x60000D8")]
	private float ValidateShadowBias(float value) { }

}

