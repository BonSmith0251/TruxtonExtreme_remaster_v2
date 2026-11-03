namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x2000200")]
internal class DeferredLights
{
	[CompilerGenerated]
	[Token(Token = "0x2000206")]
	private sealed class <>c
	{
		[Token(Token = "0x4000C81")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000C82")]
		public static BaseRenderFunc<SetupLightPassData, UnsafeGraphContext> <>9__140_0; //Field offset: 0x8

		[Address(RVA = "0x2E35790", Offset = "0x2E34B90", Length = "0x67")]
		[Token(Token = "0x6000B40")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B41")]
		public <>c() { }

		[Address(RVA = "0x2E35460", Offset = "0x2E34860", Length = "0xA2")]
		[Token(Token = "0x6000B42")]
		internal void <SetupRenderGraphLights>b__140_0(SetupLightPassData data, UnsafeGraphContext rgContext) { }

	}

	[Token(Token = "0x2000203")]
	public enum ClusterDeferredPasses : int
	{
		ClusteredLightsLit = 0,
		ClusteredLightsSimpleLit = 1,
		Fog = 2,
	}

	[Token(Token = "0x2000204")]
	public struct InitParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C79")]
		public Material stencilDeferredMaterial; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C7A")]
		public Material clusterDeferredMaterial; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C7B")]
		public LightCookieManager lightCookieManager; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C7C")]
		public bool deferredPlus; //Field offset: 0x18

	}

	[Token(Token = "0x2000205")]
	private class SetupLightPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C7D")]
		internal UniversalCameraData cameraData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C7E")]
		internal UniversalLightData lightData; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000C7F")]
		internal DeferredLights deferredLights; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000C80")]
		internal Vector2Int cameraTargetSizeCopy; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000B3F")]
		public SetupLightPassData() { }

	}

	[Token(Token = "0x2000201")]
	public static class ShaderConstants
	{
		[Token(Token = "0x4000C48")]
		public static readonly int _LitStencilRef; //Field offset: 0x0
		[Token(Token = "0x4000C49")]
		public static readonly int _LitStencilReadMask; //Field offset: 0x4
		[Token(Token = "0x4000C4A")]
		public static readonly int _LitStencilWriteMask; //Field offset: 0x8
		[Token(Token = "0x4000C4B")]
		public static readonly int _SimpleLitStencilRef; //Field offset: 0xC
		[Token(Token = "0x4000C4C")]
		public static readonly int _SimpleLitStencilReadMask; //Field offset: 0x10
		[Token(Token = "0x4000C4D")]
		public static readonly int _SimpleLitStencilWriteMask; //Field offset: 0x14
		[Token(Token = "0x4000C4E")]
		public static readonly int _StencilRef; //Field offset: 0x18
		[Token(Token = "0x4000C4F")]
		public static readonly int _StencilReadMask; //Field offset: 0x1C
		[Token(Token = "0x4000C50")]
		public static readonly int _StencilWriteMask; //Field offset: 0x20
		[Token(Token = "0x4000C51")]
		public static readonly int _LitPunctualStencilRef; //Field offset: 0x24
		[Token(Token = "0x4000C52")]
		public static readonly int _LitPunctualStencilReadMask; //Field offset: 0x28
		[Token(Token = "0x4000C53")]
		public static readonly int _LitPunctualStencilWriteMask; //Field offset: 0x2C
		[Token(Token = "0x4000C54")]
		public static readonly int _SimpleLitPunctualStencilRef; //Field offset: 0x30
		[Token(Token = "0x4000C55")]
		public static readonly int _SimpleLitPunctualStencilReadMask; //Field offset: 0x34
		[Token(Token = "0x4000C56")]
		public static readonly int _SimpleLitPunctualStencilWriteMask; //Field offset: 0x38
		[Token(Token = "0x4000C57")]
		public static readonly int _LitDirStencilRef; //Field offset: 0x3C
		[Token(Token = "0x4000C58")]
		public static readonly int _LitDirStencilReadMask; //Field offset: 0x40
		[Token(Token = "0x4000C59")]
		public static readonly int _LitDirStencilWriteMask; //Field offset: 0x44
		[Token(Token = "0x4000C5A")]
		public static readonly int _SimpleLitDirStencilRef; //Field offset: 0x48
		[Token(Token = "0x4000C5B")]
		public static readonly int _SimpleLitDirStencilReadMask; //Field offset: 0x4C
		[Token(Token = "0x4000C5C")]
		public static readonly int _SimpleLitDirStencilWriteMask; //Field offset: 0x50
		[Token(Token = "0x4000C5D")]
		public static readonly int _ScreenToWorld; //Field offset: 0x54
		[Token(Token = "0x4000C5E")]
		public static int _MainLightPosition; //Field offset: 0x58
		[Token(Token = "0x4000C5F")]
		public static int _MainLightColor; //Field offset: 0x5C
		[Token(Token = "0x4000C60")]
		public static int _MainLightLayerMask; //Field offset: 0x60
		[Token(Token = "0x4000C61")]
		public static int _SpotLightScale; //Field offset: 0x64
		[Token(Token = "0x4000C62")]
		public static int _SpotLightBias; //Field offset: 0x68
		[Token(Token = "0x4000C63")]
		public static int _SpotLightGuard; //Field offset: 0x6C
		[Token(Token = "0x4000C64")]
		public static int _LightPosWS; //Field offset: 0x70
		[Token(Token = "0x4000C65")]
		public static int _LightColor; //Field offset: 0x74
		[Token(Token = "0x4000C66")]
		public static int _LightAttenuation; //Field offset: 0x78
		[Token(Token = "0x4000C67")]
		public static int _LightOcclusionProbInfo; //Field offset: 0x7C
		[Token(Token = "0x4000C68")]
		public static int _LightDirection; //Field offset: 0x80
		[Token(Token = "0x4000C69")]
		public static int _LightFlags; //Field offset: 0x84
		[Token(Token = "0x4000C6A")]
		public static int _ShadowLightIndex; //Field offset: 0x88
		[Token(Token = "0x4000C6B")]
		public static int _LightLayerMask; //Field offset: 0x8C
		[Token(Token = "0x4000C6C")]
		public static int _CookieLightIndex; //Field offset: 0x90

		[Address(RVA = "0x2E33770", Offset = "0x2E32B70", Length = "0x66E")]
		[Token(Token = "0x6000B3E")]
		private static ShaderConstants() { }

	}

	[Token(Token = "0x2000202")]
	public enum StencilDeferredPasses : int
	{
		StencilVolume = 0,
		PunctualLit = 1,
		PunctualSimpleLit = 2,
		DirectionalLit = 3,
		DirectionalSimpleLit = 4,
		Fog = 5,
		SSAOOnly = 6,
	}

	[Token(Token = "0x4000C14")]
	internal static readonly String[] k_GBufferNames; //Field offset: 0x0
	[Token(Token = "0x4000C15")]
	internal static readonly Int32[] k_GBufferShaderPropertyIDs; //Field offset: 0x8
	[Token(Token = "0x4000C16")]
	private static readonly String[] k_StencilDeferredPassNames; //Field offset: 0x10
	[Token(Token = "0x4000C17")]
	private static readonly String[] k_ClusterDeferredPassNames; //Field offset: 0x18
	[Token(Token = "0x4000C18")]
	private static readonly ushort k_InvalidLightOffset; //Field offset: 0x20
	[Token(Token = "0x4000C19")]
	private static readonly string k_SetupLights; //Field offset: 0x28
	[Token(Token = "0x4000C1A")]
	private static readonly string k_DeferredPass; //Field offset: 0x30
	[Token(Token = "0x4000C1B")]
	private static readonly string k_DeferredShadingPass; //Field offset: 0x38
	[Token(Token = "0x4000C1C")]
	private static readonly string k_DeferredStencilPass; //Field offset: 0x40
	[Token(Token = "0x4000C1D")]
	private static readonly string k_DeferredFogPass; //Field offset: 0x48
	[Token(Token = "0x4000C1E")]
	private static readonly string k_SetupLightConstants; //Field offset: 0x50
	[Token(Token = "0x4000C1F")]
	private static readonly float kStencilShapeGuard; //Field offset: 0x58
	[Token(Token = "0x4000C20")]
	private static readonly ProfilingSampler m_ProfilingSetupLights; //Field offset: 0x60
	[Token(Token = "0x4000C21")]
	private static readonly ProfilingSampler m_ProfilingDeferredPass; //Field offset: 0x68
	[Token(Token = "0x4000C22")]
	private static readonly ProfilingSampler m_ProfilingSetupLightConstants; //Field offset: 0x70
	[Token(Token = "0x4000C47")]
	private static ProfilingSampler s_SetupDeferredLights; //Field offset: 0x78
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C23")]
	private MaskSize <RenderingLayerMaskSize>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C24")]
	private bool <UseDecalLayers>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x15")]
	[Token(Token = "0x4000C25")]
	private bool <UseFramebufferFetch>k__BackingField; //Field offset: 0x15
	[CompilerGenerated]
	[FieldOffset(Offset = "0x16")]
	[Token(Token = "0x4000C26")]
	private bool <HasDepthPrepass>k__BackingField; //Field offset: 0x16
	[CompilerGenerated]
	[FieldOffset(Offset = "0x17")]
	[Token(Token = "0x4000C27")]
	private bool <HasNormalPrepass>k__BackingField; //Field offset: 0x17
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C28")]
	private bool <HasRenderingLayerPrepass>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x4000C29")]
	private bool <AccurateGbufferNormals>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000C2A")]
	private MixedLightingSetup <MixedLightingSetup>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C2B")]
	private bool <UseJobSystem>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000C2C")]
	private int <RenderWidth>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000C2D")]
	private int <RenderHeight>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000C2E")]
	private RTHandle[] <GbufferAttachments>k__BackingField; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000C2F")]
	private RTHandle[] GbufferRTHandles; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000C30")]
	private TextureHandle[] <GbufferTextureHandles>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000C31")]
	private RTHandle[] <DeferredInputAttachments>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000C32")]
	private Boolean[] <DeferredInputIsTransient>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000C33")]
	private RTHandle <DepthAttachment>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000C34")]
	private RTHandle <DepthCopyTexture>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000C35")]
	private GraphicsFormat[] <GbufferFormats>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000C36")]
	private RTHandle <DepthAttachmentHandle>k__BackingField; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000C37")]
	private NativeArray<UInt16> m_stencilVisLights; //Field offset: 0x78
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000C38")]
	private NativeArray<UInt16> m_stencilVisLightOffsets; //Field offset: 0x88
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000C39")]
	private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000C3A")]
	private Mesh m_SphereMesh; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000C3B")]
	private Mesh m_HemisphereMesh; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000C3C")]
	private Mesh m_FullscreenMesh; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000C3D")]
	private Material m_StencilDeferredMaterial; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000C3E")]
	private Material m_ClusterDeferredMaterial; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000C3F")]
	private Int32[] m_StencilDeferredPasses; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000C40")]
	private Int32[] m_ClusterDeferredPasses; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000C41")]
	private Matrix4x4[] m_ScreenToWorld; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000C42")]
	private ProfilingSampler m_ProfilingSamplerDeferredShadingPass; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000C43")]
	private ProfilingSampler m_ProfilingSamplerDeferredStencilPass; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000C44")]
	private ProfilingSampler m_ProfilingSamplerDeferredFogPass; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000C45")]
	private LightCookieManager m_LightCookieManager; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000C46")]
	private bool m_UseDeferredPlus; //Field offset: 0x100

	[Token(Token = "0x170002B8")]
	internal bool AccurateGbufferNormals
	{
		[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AFC")]
		internal get { } //Length: 5
		[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000AFD")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002BF")]
	internal RTHandle[] DeferredInputAttachments
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B0A")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000B0B")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002C0")]
	internal Boolean[] DeferredInputIsTransient
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B0C")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000B0D")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002C1")]
	internal RTHandle DepthAttachment
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B0E")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000B0F")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002C4")]
	internal RTHandle DepthAttachmentHandle
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B14")]
		internal get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000B15")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002C2")]
	internal RTHandle DepthCopyTexture
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B10")]
		internal get { } //Length: 5
		[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
		[CompilerGenerated]
		[Token(Token = "0x6000B11")]
		internal set { } //Length: 995
	}

	[Token(Token = "0x170002A6")]
	internal int GBufferAlbedoIndex
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000AE3")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170002BD")]
	internal RTHandle[] GbufferAttachments
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B06")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000B07")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002AA")]
	internal int GbufferDepthIndex
	{
		[Address(RVA = "0x2E06FF0", Offset = "0x2E063F0", Length = "0x12")]
		[Token(Token = "0x6000AE7")]
		internal get { } //Length: 18
	}

	[Token(Token = "0x170002C3")]
	internal GraphicsFormat[] GbufferFormats
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B12")]
		internal get { } //Length: 5
		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000B13")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002AE")]
	internal int GBufferInputAttachmentCount
	{
		[Address(RVA = "0x2E06E20", Offset = "0x2E06220", Length = "0xE")]
		[Token(Token = "0x6000AEB")]
		internal get { } //Length: 14
	}

	[Token(Token = "0x170002A9")]
	internal int GBufferLightingIndex
	{
		[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
		[Token(Token = "0x6000AE6")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x170002A8")]
	internal int GBufferNormalSmoothnessIndex
	{
		[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
		[Token(Token = "0x6000AE5")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x170002AB")]
	internal int GBufferRenderingLayers
	{
		[Address(RVA = "0x2E06E30", Offset = "0x2E06230", Length = "0x76")]
		[Token(Token = "0x6000AE8")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x170002AC")]
	internal int GBufferShadowMask
	{
		[Address(RVA = "0x2E06EB0", Offset = "0x2E062B0", Length = "0x95")]
		[Token(Token = "0x6000AE9")]
		internal get { } //Length: 149
	}

	[Token(Token = "0x170002AD")]
	internal int GBufferSliceCount
	{
		[Address(RVA = "0x2E06F50", Offset = "0x2E06350", Length = "0x9B")]
		[Token(Token = "0x6000AEA")]
		internal get { } //Length: 155
	}

	[Token(Token = "0x170002A7")]
	internal int GBufferSpecularMetallicIndex
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6000AE4")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x170002BE")]
	internal TextureHandle[] GbufferTextureHandles
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B08")]
		internal get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000B09")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x170002B5")]
	internal bool HasDepthPrepass
	{
		[Address(RVA = "0x27BCBD0", Offset = "0x27BBFD0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AF6")]
		internal get { } //Length: 5
		[Address(RVA = "0x2B7BDC0", Offset = "0x2B7B1C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000AF7")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002B6")]
	internal bool HasNormalPrepass
	{
		[Address(RVA = "0x2B7BDB0", Offset = "0x2B7B1B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AF8")]
		internal get { } //Length: 5
		[Address(RVA = "0x2B7BDD0", Offset = "0x2B7B1D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000AF9")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002B7")]
	internal bool HasRenderingLayerPrepass
	{
		[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AFA")]
		internal get { } //Length: 5
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000AFB")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002B9")]
	internal MixedLightingSetup MixedLightingSetup
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000AFE")]
		internal get { } //Length: 4
		[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000AFF")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002BC")]
	internal int RenderHeight
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B04")]
		internal get { } //Length: 4
		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B05")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002B1")]
	internal MaskSize RenderingLayerMaskSize
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x6000AEF")]
		internal get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000AF0")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002BB")]
	internal int RenderWidth
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B02")]
		internal get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B03")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002B2")]
	internal bool UseDecalLayers
	{
		[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AF1")]
		internal get { } //Length: 5
		[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000AF2")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002B4")]
	internal bool UseFramebufferFetch
	{
		[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000AF4")]
		internal get { } //Length: 5
		[Address(RVA = "0x1F8C9F0", Offset = "0x1F8BDF0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000AF5")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002BA")]
	internal bool UseJobSystem
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000B00")]
		internal get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000B01")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x170002B3")]
	internal bool UseLightLayers
	{
		[Address(RVA = "0x2E07010", Offset = "0x2E06410", Length = "0x52")]
		[Token(Token = "0x6000AF3")]
		internal get { } //Length: 82
	}

	[Token(Token = "0x170002B0")]
	internal bool UseRenderingLayers
	{
		[Address(RVA = "0x2E07070", Offset = "0x2E06470", Length = "0x66")]
		[Token(Token = "0x6000AEE")]
		internal get { } //Length: 102
	}

	[Token(Token = "0x170002AF")]
	internal bool UseShadowMask
	{
		[Address(RVA = "0x2E070E0", Offset = "0x2E064E0", Length = "0x8")]
		[Token(Token = "0x6000AED")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x2E061C0", Offset = "0x2E055C0", Length = "0x90A")]
	[Token(Token = "0x6000B3D")]
	private static DeferredLights() { }

	[Address(RVA = "0x2E06AD0", Offset = "0x2E05ED0", Length = "0x34C")]
	[Token(Token = "0x6000B16")]
	internal DeferredLights(InitParams initParams, bool useNativeRenderPass = false) { }

	[Address(RVA = "0x2DFEBD0", Offset = "0x2DFDFD0", Length = "0x167")]
	[Token(Token = "0x6000B38")]
	private static Mesh CreateFullscreenMesh() { }

	[Address(RVA = "0x2DFF180", Offset = "0x2DFE580", Length = "0x438")]
	[Token(Token = "0x6000B1D")]
	internal void CreateGbufferResources() { }

	[Address(RVA = "0x2DFED40", Offset = "0x2DFE140", Length = "0x43E")]
	[Token(Token = "0x6000B1E")]
	internal void CreateGbufferResourcesRenderGraph(RenderGraph renderGraph, UniversalResourceData resourceData) { }

	[Address(RVA = "0x2DFF5C0", Offset = "0x2DFE9C0", Length = "0x6F5")]
	[Token(Token = "0x6000B37")]
	private static Mesh CreateHemisphereMesh() { }

	[Address(RVA = "0x2DFFCC0", Offset = "0x2DFF0C0", Length = "0x7DE")]
	[Token(Token = "0x6000B36")]
	private static Mesh CreateSphereMesh() { }

	[Address(RVA = "0x2E004A0", Offset = "0x2DFF8A0", Length = "0xB")]
	[Token(Token = "0x6000B1A")]
	internal void DisableFramebufferFetchInput() { }

	[Address(RVA = "0x2E004B0", Offset = "0x2DFF8B0", Length = "0x605")]
	[Token(Token = "0x6000B26")]
	internal void ExecuteDeferredPass(RasterCommandBuffer cmd, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	[Address(RVA = "0x1D88C10", Offset = "0x1D88010", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AFC")]
	internal bool get_AccurateGbufferNormals() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B0A")]
	internal RTHandle[] get_DeferredInputAttachments() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B0C")]
	internal Boolean[] get_DeferredInputIsTransient() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B0E")]
	internal RTHandle get_DepthAttachment() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B14")]
	internal RTHandle get_DepthAttachmentHandle() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B10")]
	internal RTHandle get_DepthCopyTexture() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000AE3")]
	internal int get_GBufferAlbedoIndex() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B06")]
	internal RTHandle[] get_GbufferAttachments() { }

	[Address(RVA = "0x2E06FF0", Offset = "0x2E063F0", Length = "0x12")]
	[Token(Token = "0x6000AE7")]
	internal int get_GbufferDepthIndex() { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B12")]
	internal GraphicsFormat[] get_GbufferFormats() { }

	[Address(RVA = "0x2E06E20", Offset = "0x2E06220", Length = "0xE")]
	[Token(Token = "0x6000AEB")]
	internal int get_GBufferInputAttachmentCount() { }

	[Address(RVA = "0x666DD0", Offset = "0x6661D0", Length = "0x6")]
	[Token(Token = "0x6000AE6")]
	internal int get_GBufferLightingIndex() { }

	[Address(RVA = "0x9DCBD0", Offset = "0x9DBFD0", Length = "0x6")]
	[Token(Token = "0x6000AE5")]
	internal int get_GBufferNormalSmoothnessIndex() { }

	[Address(RVA = "0x2E06E30", Offset = "0x2E06230", Length = "0x76")]
	[Token(Token = "0x6000AE8")]
	internal int get_GBufferRenderingLayers() { }

	[Address(RVA = "0x2E06EB0", Offset = "0x2E062B0", Length = "0x95")]
	[Token(Token = "0x6000AE9")]
	internal int get_GBufferShadowMask() { }

	[Address(RVA = "0x2E06F50", Offset = "0x2E06350", Length = "0x9B")]
	[Token(Token = "0x6000AEA")]
	internal int get_GBufferSliceCount() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6000AE4")]
	internal int get_GBufferSpecularMetallicIndex() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B08")]
	internal TextureHandle[] get_GbufferTextureHandles() { }

	[Address(RVA = "0x27BCBD0", Offset = "0x27BBFD0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AF6")]
	internal bool get_HasDepthPrepass() { }

	[Address(RVA = "0x2B7BDB0", Offset = "0x2B7B1B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AF8")]
	internal bool get_HasNormalPrepass() { }

	[Address(RVA = "0x1410A70", Offset = "0x140FE70", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AFA")]
	internal bool get_HasRenderingLayerPrepass() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000AFE")]
	internal MixedLightingSetup get_MixedLightingSetup() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B04")]
	internal int get_RenderHeight() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x6000AEF")]
	internal MaskSize get_RenderingLayerMaskSize() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B02")]
	internal int get_RenderWidth() { }

	[Address(RVA = "0x1964370", Offset = "0x1963770", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AF1")]
	internal bool get_UseDecalLayers() { }

	[Address(RVA = "0x1F8C9E0", Offset = "0x1F8BDE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000AF4")]
	internal bool get_UseFramebufferFetch() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000B00")]
	internal bool get_UseJobSystem() { }

	[Address(RVA = "0x2E07010", Offset = "0x2E06410", Length = "0x52")]
	[Token(Token = "0x6000AF3")]
	internal bool get_UseLightLayers() { }

	[Address(RVA = "0x2E07070", Offset = "0x2E06470", Length = "0x66")]
	[Token(Token = "0x6000AEE")]
	internal bool get_UseRenderingLayers() { }

	[Address(RVA = "0x2E070E0", Offset = "0x2E064E0", Length = "0x8")]
	[Token(Token = "0x6000AED")]
	internal bool get_UseShadowMask() { }

	[Address(RVA = "0x2E00AC0", Offset = "0x2DFFEC0", Length = "0x118")]
	[Token(Token = "0x6000AEC")]
	internal GraphicsFormat GetGBufferFormat(int index) { }

	[Address(RVA = "0x2E00BE0", Offset = "0x2DFFFE0", Length = "0x3E2")]
	[Token(Token = "0x6000B29")]
	internal Matrix4x4[] GetScreenToWorldMatrix(UniversalCameraData cameraData) { }

	[Address(RVA = "0x2E00FD0", Offset = "0x2E003D0", Length = "0x6F")]
	[Token(Token = "0x6000B2C")]
	private bool HasStencilLightsOfType(LightType type) { }

	[Address(RVA = "0x2E01040", Offset = "0x2E00440", Length = "0x295")]
	[Token(Token = "0x6000B35")]
	private void InitClusterDeferredMaterial() { }

	[Address(RVA = "0x2E012E0", Offset = "0x2E006E0", Length = "0x44B")]
	[Token(Token = "0x6000B34")]
	private void InitStencilDeferredMaterial() { }

	[Address(RVA = "0x2E01730", Offset = "0x2E00B30", Length = "0x88")]
	[Token(Token = "0x6000B20")]
	internal bool IsRuntimeSupportedThisFrame() { }

	[Address(RVA = "0x2E017C0", Offset = "0x2E00BC0", Length = "0xB0")]
	[Token(Token = "0x6000B23")]
	public void OnCameraCleanup(CommandBuffer cmd) { }

	[Address(RVA = "0x2E01B70", Offset = "0x2E00F70", Length = "0x1F3")]
	[Token(Token = "0x6000B24")]
	internal static StencilState OverwriteStencil(StencilState s, int stencilWriteMask) { }

	[Address(RVA = "0x2E01880", Offset = "0x2E00C80", Length = "0x2E8")]
	[Token(Token = "0x6000B25")]
	internal static RenderStateBlock OverwriteStencil(RenderStateBlock block, int stencilWriteMask, int stencilRef) { }

	[Address(RVA = "0x2E01D70", Offset = "0x2E01170", Length = "0x39D")]
	[Token(Token = "0x6000B2B")]
	private void PrecomputeLights(out NativeArray<UInt16>& stencilVisLights, out NativeArray<UInt16>& stencilVisLightOffsets, ref NativeArray<VisibleLight>& visibleLights, bool hasAdditionalLights) { }

	[Address(RVA = "0x2E02110", Offset = "0x2E01510", Length = "0x1F5")]
	[Token(Token = "0x6000B1C")]
	internal void ReAllocateGBufferIfNeeded(RenderTextureDescriptor gbufferSlice, int gbufferIndex) { }

	[Address(RVA = "0x2E02310", Offset = "0x2E01710", Length = "0x9B")]
	[Token(Token = "0x6000B1B")]
	internal void ReleaseGbufferResources() { }

	[Address(RVA = "0x2E023B0", Offset = "0x2E017B0", Length = "0x428")]
	[Token(Token = "0x6000B2D")]
	private void RenderClusterLights(RasterCommandBuffer cmd, UniversalShadowData shadowData) { }

	[Address(RVA = "0x2E027E0", Offset = "0x2E01BE0", Length = "0x23A")]
	[Token(Token = "0x6000B33")]
	private void RenderFog(RasterCommandBuffer cmd, bool isOrthographic) { }

	[Address(RVA = "0x2E02A20", Offset = "0x2E01E20", Length = "0x154")]
	[Token(Token = "0x6000B32")]
	private void RenderSSAOBeforeShading(RasterCommandBuffer cmd) { }

	[Address(RVA = "0x2E02B80", Offset = "0x2E01F80", Length = "0x7D6")]
	[Token(Token = "0x6000B2F")]
	private void RenderStencilDirectionalLights(RasterCommandBuffer cmd, bool stripShadowsOffVariants, UniversalLightData lightData, UniversalShadowData shadowData, NativeArray<VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager, int mainLightIndex) { }

	[Address(RVA = "0x2E03360", Offset = "0x2E02760", Length = "0x381")]
	[Token(Token = "0x6000B2E")]
	private void RenderStencilLights(RasterCommandBuffer cmd, UniversalLightData lightData, UniversalShadowData shadowData, bool stripShadowsOffVariants) { }

	[Address(RVA = "0x2E036F0", Offset = "0x2E02AF0", Length = "0x8EE")]
	[Token(Token = "0x6000B30")]
	private void RenderStencilPointLights(RasterCommandBuffer cmd, bool stripShadowsOffVariants, UniversalLightData lightData, UniversalShadowData shadowData, NativeArray<VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager) { }

	[Address(RVA = "0x2E03FE0", Offset = "0x2E033E0", Length = "0xA1D")]
	[Token(Token = "0x6000B31")]
	private void RenderStencilSpotLights(RasterCommandBuffer cmd, bool stripShadowsOffVariants, UniversalLightData lightData, UniversalShadowData shadowData, NativeArray<VisibleLight> visibleLights, bool hasAdditionalLightPass, bool hasLightCookieManager) { }

	[Address(RVA = "0x2E04A00", Offset = "0x2E03E00", Length = "0x174")]
	[Token(Token = "0x6000B19")]
	internal void ResolveMixedLightingMode(UniversalLightData lightData) { }

	[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000AFD")]
	internal void set_AccurateGbufferNormals(bool value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000B0B")]
	internal void set_DeferredInputAttachments(RTHandle[] value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000B0D")]
	internal void set_DeferredInputIsTransient(Boolean[] value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000B0F")]
	internal void set_DepthAttachment(RTHandle value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000B15")]
	internal void set_DepthAttachmentHandle(RTHandle value) { }

	[Address(RVA = "0x1964460", Offset = "0x1963860", Length = "0x3E3")]
	[CompilerGenerated]
	[Token(Token = "0x6000B11")]
	internal void set_DepthCopyTexture(RTHandle value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000B07")]
	internal void set_GbufferAttachments(RTHandle[] value) { }

	[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000B13")]
	internal void set_GbufferFormats(GraphicsFormat[] value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000B09")]
	internal void set_GbufferTextureHandles(TextureHandle[] value) { }

	[Address(RVA = "0x2B7BDC0", Offset = "0x2B7B1C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000AF7")]
	internal void set_HasDepthPrepass(bool value) { }

	[Address(RVA = "0x2B7BDD0", Offset = "0x2B7B1D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000AF9")]
	internal void set_HasNormalPrepass(bool value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000AFB")]
	internal void set_HasRenderingLayerPrepass(bool value) { }

	[Address(RVA = "0xFE2A80", Offset = "0xFE1E80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000AFF")]
	internal void set_MixedLightingSetup(MixedLightingSetup value) { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B05")]
	internal void set_RenderHeight(int value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000AF0")]
	internal void set_RenderingLayerMaskSize(MaskSize value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B03")]
	internal void set_RenderWidth(int value) { }

	[Address(RVA = "0x1E02780", Offset = "0x1E01B80", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000AF2")]
	internal void set_UseDecalLayers(bool value) { }

	[Address(RVA = "0x1F8C9F0", Offset = "0x1F8BDF0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000AF5")]
	internal void set_UseFramebufferFetch(bool value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000B01")]
	internal void set_UseJobSystem(bool value) { }

	[Address(RVA = "0x2E04B80", Offset = "0x2E03F80", Length = "0x8A")]
	[Token(Token = "0x6000B3A")]
	private void SetAdditionalLightsShadowsKeyword(ref RasterCommandBuffer cmd, bool stripShadowsOffVariants, bool additionalLightShadowsEnabled, bool hasDeferredShadows, bool shouldOverride, ref bool lastShadowsKeyword) { }

	[Address(RVA = "0x2E04C10", Offset = "0x2E04010", Length = "0x11B")]
	[Token(Token = "0x6000B3C")]
	private void SetLightCookiesKeyword(RasterCommandBuffer cmd, int visLightIndex, bool hasLightCookieManager, bool shouldOverride, ref bool lastLightCookieState, ref int lastCookieLightIndex) { }

	[Address(RVA = "0x2E04D30", Offset = "0x2E04130", Length = "0x115")]
	[Token(Token = "0x6000B39")]
	private void SetRenderingLayersMask(RasterCommandBuffer cmd, Light light, int shaderPropertyID) { }

	[Address(RVA = "0x2E04E50", Offset = "0x2E04250", Length = "0xA9")]
	[Token(Token = "0x6000B3B")]
	private void SetSoftShadowsKeyword(RasterCommandBuffer cmd, UniversalShadowData shadowData, Light light, bool hasDeferredShadows, bool shouldOverride, ref bool lastHasSoftShadow) { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[Token(Token = "0x6000B22")]
	internal void Setup(AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass) { }

	[Address(RVA = "0x2E05AA0", Offset = "0x2E04EA0", Length = "0x2F1")]
	[Token(Token = "0x6000B21")]
	public void Setup(AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, RTHandle depthCopyTexture, RTHandle depthAttachment, RTHandle colorAttachment) { }

	[Address(RVA = "0x2E04F00", Offset = "0x2E04300", Length = "0x44B")]
	[Token(Token = "0x6000B18")]
	internal void SetupLights(CommandBuffer cmd, UniversalCameraData cameraData, Vector2Int cameraTargetSizeCopy, UniversalLightData lightData, bool isRenderGraph = false) { }

	[Address(RVA = "0x2E05350", Offset = "0x2E04750", Length = "0x2E8")]
	[Token(Token = "0x6000B28")]
	private void SetupMainLightConstants(CommandBuffer cmd, UniversalLightData lightData) { }

	[Address(RVA = "0x2E05640", Offset = "0x2E04A40", Length = "0x9E")]
	[Token(Token = "0x6000B2A")]
	private void SetupMatrixConstants(RasterCommandBuffer cmd, UniversalCameraData cameraData) { }

	[Address(RVA = "0x2E056E0", Offset = "0x2E04AE0", Length = "0x3A4")]
	[Token(Token = "0x6000B17")]
	internal void SetupRenderGraphLights(RenderGraph renderGraph, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[Address(RVA = "0x2E05A90", Offset = "0x2E04E90", Length = "0x8")]
	[Token(Token = "0x6000B27")]
	private void SetupShaderLightConstants(CommandBuffer cmd, UniversalLightData lightData) { }

	[Address(RVA = "0x2E05DA0", Offset = "0x2E051A0", Length = "0x41C")]
	[Token(Token = "0x6000B1F")]
	internal void UpdateDeferredInputAttachments() { }

}

