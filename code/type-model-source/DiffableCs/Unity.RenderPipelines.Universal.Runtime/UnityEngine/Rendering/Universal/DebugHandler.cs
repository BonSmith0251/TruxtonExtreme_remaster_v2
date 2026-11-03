namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000068")]
internal class DebugHandler : IDebugDisplaySettingsQuery
{
	[CompilerGenerated]
	[Token(Token = "0x200006B")]
	private sealed class <>c
	{
		[Token(Token = "0x4000216")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000217")]
		public static BaseRenderFunc<DebugFinalValidationPassData, RasterGraphContext> <>9__103_0; //Field offset: 0x8
		[Token(Token = "0x4000218")]
		public static BaseRenderFunc<DebugSetupPassData, RasterGraphContext> <>9__108_0; //Field offset: 0x10

		[Address(RVA = "0x2D89910", Offset = "0x2D88D10", Length = "0x67")]
		[Token(Token = "0x6000279")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600027A")]
		public <>c() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600027C")]
		internal void <Setup>b__108_0(DebugSetupPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2D89630", Offset = "0x2D88A30", Length = "0x5A")]
		[Token(Token = "0x600027B")]
		internal void <UpdateShaderGlobalPropertiesForFinalValidationPass>b__103_0(DebugFinalValidationPassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000069")]
	private class DebugFinalValidationPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000207")]
		public bool isFinalPass; //Field offset: 0x10
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x4000208")]
		public bool resolveFinalTarget; //Field offset: 0x11
		[FieldOffset(Offset = "0x12")]
		[Token(Token = "0x4000209")]
		public bool isActiveForCamera; //Field offset: 0x12
		[FieldOffset(Offset = "0x13")]
		[Token(Token = "0x400020A")]
		public bool hasDebugRenderTarget; //Field offset: 0x13
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400020B")]
		public TextureHandle debugRenderTargetHandle; //Field offset: 0x14
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400020C")]
		public int debugTexturePropertyId; //Field offset: 0x24
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400020D")]
		public Vector4 debugRenderTargetPixelRect; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400020E")]
		public int debugRenderTargetSupportsStereo; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400020F")]
		public Vector4 debugRenderTargetRangeRemap; //Field offset: 0x3C
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4000210")]
		public TextureHandle debugFontTextureHandle; //Field offset: 0x4C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000211")]
		public DebugDisplaySettingsRendering renderingSettings; //Field offset: 0x60

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000277")]
		public DebugFinalValidationPassData() { }

	}

	[Token(Token = "0x200006A")]
	private class DebugSetupPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000212")]
		public bool isActiveForCamera; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000213")]
		public DebugDisplaySettingsMaterial materialSettings; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000214")]
		public DebugDisplaySettingsRendering renderingSettings; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000215")]
		public DebugDisplaySettingsLighting lightingSettings; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000278")]
		public DebugSetupPassData() { }

	}

	[Token(Token = "0x40001D1")]
	private static readonly int k_DebugColorInvalidModePropertyId; //Field offset: 0x0
	[Token(Token = "0x40001D2")]
	private static readonly int k_DebugCurrentRealTimeId; //Field offset: 0x4
	[Token(Token = "0x40001D3")]
	private static readonly int k_DebugColorPropertyId; //Field offset: 0x8
	[Token(Token = "0x40001D4")]
	private static readonly int k_DebugTexturePropertyId; //Field offset: 0xC
	[Token(Token = "0x40001D5")]
	private static readonly int k_DebugFontId; //Field offset: 0x10
	[Token(Token = "0x40001D6")]
	private static readonly int k_DebugTextureNoStereoPropertyId; //Field offset: 0x14
	[Token(Token = "0x40001D7")]
	private static readonly int k_DebugTextureDisplayRect; //Field offset: 0x18
	[Token(Token = "0x40001D8")]
	private static readonly int k_DebugRenderTargetSupportsStereo; //Field offset: 0x1C
	[Token(Token = "0x40001D9")]
	private static readonly int k_DebugRenderTargetRangeRemap; //Field offset: 0x20
	[Token(Token = "0x40001DA")]
	private static readonly int k_DebugMaterialModeId; //Field offset: 0x24
	[Token(Token = "0x40001DB")]
	private static readonly int k_DebugVertexAttributeModeId; //Field offset: 0x28
	[Token(Token = "0x40001DC")]
	private static readonly int k_DebugMaterialValidationModeId; //Field offset: 0x2C
	[Token(Token = "0x40001DD")]
	private static readonly int k_DebugMipInfoModeId; //Field offset: 0x30
	[Token(Token = "0x40001DE")]
	private static readonly int k_DebugMipMapStatusModeId; //Field offset: 0x34
	[Token(Token = "0x40001DF")]
	private static readonly int k_DebugMipMapShowStatusCodeId; //Field offset: 0x38
	[Token(Token = "0x40001E0")]
	private static readonly int k_DebugMipMapOpacityId; //Field offset: 0x3C
	[Token(Token = "0x40001E1")]
	private static readonly int k_DebugMipMapRecentlyUpdatedCooldownId; //Field offset: 0x40
	[Token(Token = "0x40001E2")]
	private static readonly int k_DebugMipMapTerrainTextureModeId; //Field offset: 0x44
	[Token(Token = "0x40001E3")]
	private static readonly int k_DebugSceneOverrideModeId; //Field offset: 0x48
	[Token(Token = "0x40001E4")]
	private static readonly int k_DebugFullScreenModeId; //Field offset: 0x4C
	[Token(Token = "0x40001E5")]
	private static readonly int k_DebugValidationModeId; //Field offset: 0x50
	[Token(Token = "0x40001E6")]
	private static readonly int k_DebugValidateBelowMinThresholdColorPropertyId; //Field offset: 0x54
	[Token(Token = "0x40001E7")]
	private static readonly int k_DebugValidateAboveMaxThresholdColorPropertyId; //Field offset: 0x58
	[Token(Token = "0x40001E8")]
	private static readonly int k_DebugMaxPixelCost; //Field offset: 0x5C
	[Token(Token = "0x40001E9")]
	private static readonly int k_DebugLightingModeId; //Field offset: 0x60
	[Token(Token = "0x40001EA")]
	private static readonly int k_DebugLightingFeatureFlagsId; //Field offset: 0x64
	[Token(Token = "0x40001EB")]
	private static readonly int k_DebugValidateAlbedoMinLuminanceId; //Field offset: 0x68
	[Token(Token = "0x40001EC")]
	private static readonly int k_DebugValidateAlbedoMaxLuminanceId; //Field offset: 0x6C
	[Token(Token = "0x40001ED")]
	private static readonly int k_DebugValidateAlbedoSaturationToleranceId; //Field offset: 0x70
	[Token(Token = "0x40001EE")]
	private static readonly int k_DebugValidateAlbedoHueToleranceId; //Field offset: 0x74
	[Token(Token = "0x40001EF")]
	private static readonly int k_DebugValidateAlbedoCompareColorId; //Field offset: 0x78
	[Token(Token = "0x40001F0")]
	private static readonly int k_DebugValidateMetallicMinValueId; //Field offset: 0x7C
	[Token(Token = "0x40001F1")]
	private static readonly int k_DebugValidateMetallicMaxValueId; //Field offset: 0x80
	[Token(Token = "0x40001F2")]
	private static readonly int k_ValidationChannelsId; //Field offset: 0x84
	[Token(Token = "0x40001F3")]
	private static readonly int k_RangeMinimumId; //Field offset: 0x88
	[Token(Token = "0x40001F4")]
	private static readonly int k_RangeMaximumId; //Field offset: 0x8C
	[Token(Token = "0x40001F5")]
	private static readonly ProfilingSampler s_DebugSetupSampler; //Field offset: 0x90
	[Token(Token = "0x40001F6")]
	private static readonly ProfilingSampler s_DebugFinalValidationSampler; //Field offset: 0x98
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001F7")]
	private DebugSetupPassData s_DebugSetupPassData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001F8")]
	private DebugFinalValidationPassData s_DebugFinalValidationPassData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001F9")]
	private readonly Material m_ReplacementMaterial; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001FA")]
	private readonly Material m_HDRDebugViewMaterial; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001FB")]
	private HDRDebugViewPass m_HDRDebugViewPass; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001FC")]
	private RTHandle m_DebugScreenColorHandle; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001FD")]
	private RTHandle m_DebugScreenDepthHandle; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001FE")]
	private readonly UniversalRenderPipelineRuntimeTextures m_RuntimeTextures; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001FF")]
	private bool m_HasDebugRenderTarget; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x4000200")]
	private bool m_DebugRenderTargetSupportsStereo; //Field offset: 0x51
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000201")]
	private Vector4 m_DebugRenderTargetPixelRect; //Field offset: 0x54
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000202")]
	private Vector4 m_DebugRenderTargetRangeRemap; //Field offset: 0x64
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000203")]
	private RTHandle m_DebugRenderTarget; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000204")]
	private RTHandle m_DebugFontTexture; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000205")]
	private GraphicsBuffer m_debugDisplayConstant; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000206")]
	private readonly UniversalRenderPipelineDebugDisplaySettings m_DebugDisplaySettings; //Field offset: 0x90

	[Token(Token = "0x170000A9")]
	public override bool AreAnySettingsActive
	{
		[Address(RVA = "0x2D5B030", Offset = "0x2D5A430", Length = "0x2D")]
		[Token(Token = "0x6000251")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170000AE")]
	internal UniversalRenderPipelineDebugDisplaySettings DebugDisplaySettings
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x6000257")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000AF")]
	internal RTHandle DebugScreenColorHandle
	{
		[Address(RVA = "0x2A009A0", Offset = "0x29FFDA0", Length = "0x5")]
		[Token(Token = "0x6000258")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000B0")]
	internal RTHandle DebugScreenDepthHandle
	{
		[Address(RVA = "0x1388FC0", Offset = "0x13883C0", Length = "0x5")]
		[Token(Token = "0x6000259")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000B1")]
	internal HDRDebugViewPass hdrDebugViewPass
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x600025A")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000AC")]
	internal bool IsActiveModeUnsupportedForDeferred
	{
		[Address(RVA = "0x2D5B060", Offset = "0x2D5A460", Length = "0x76")]
		[Token(Token = "0x6000254")]
		internal get { } //Length: 118
	}

	[Token(Token = "0x170000B4")]
	internal bool IsDepthPrimingCompatible
	{
		[Address(RVA = "0x2D5B0E0", Offset = "0x2D5A4E0", Length = "0x2A")]
		[Token(Token = "0x600025F")]
		internal get { } //Length: 42
	}

	[Token(Token = "0x170000AB")]
	public override bool IsLightingActive
	{
		[Address(RVA = "0x2D5B110", Offset = "0x2D5A510", Length = "0x2D")]
		[Token(Token = "0x6000253")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170000AA")]
	public override bool IsPostProcessingAllowed
	{
		[Address(RVA = "0x2D5B140", Offset = "0x2D5A540", Length = "0x2D")]
		[Token(Token = "0x6000252")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170000B3")]
	internal bool IsRenderPassSupported
	{
		[Address(RVA = "0x2D5B170", Offset = "0x2D5A570", Length = "0x42")]
		[Token(Token = "0x600025E")]
		internal get { } //Length: 66
	}

	[Token(Token = "0x170000B2")]
	internal bool IsScreenClearNeeded
	{
		[Address(RVA = "0x2D5B1C0", Offset = "0x2D5A5C0", Length = "0x3F")]
		[Token(Token = "0x600025D")]
		internal get { } //Length: 63
	}

	[Token(Token = "0x170000A6")]
	private DebugDisplaySettingsLighting LightingSettings
	{
		[Address(RVA = "0x2D5B200", Offset = "0x2D5A600", Length = "0x1E")]
		[Token(Token = "0x600024E")]
		private get { } //Length: 30
	}

	[Token(Token = "0x170000A7")]
	private DebugDisplaySettingsMaterial MaterialSettings
	{
		[Address(RVA = "0x2D5B220", Offset = "0x2D5A620", Length = "0x1E")]
		[Token(Token = "0x600024F")]
		private get { } //Length: 30
	}

	[Token(Token = "0x170000A8")]
	private DebugDisplaySettingsRendering RenderingSettings
	{
		[Address(RVA = "0x2D5B240", Offset = "0x2D5A640", Length = "0x1E")]
		[Token(Token = "0x6000250")]
		private get { } //Length: 30
	}

	[Token(Token = "0x170000AD")]
	internal Material ReplacementMaterial
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000256")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000B5")]
	internal int stpDebugViewIndex
	{
		[Address(RVA = "0x2D5B260", Offset = "0x2D5A660", Length = "0x26")]
		[Token(Token = "0x6000260")]
		internal get { } //Length: 38
	}

	[Address(RVA = "0x2D5A540", Offset = "0x2D59940", Length = "0x70C")]
	[Token(Token = "0x6000276")]
	private static DebugHandler() { }

	[Address(RVA = "0x2D5AC50", Offset = "0x2D5A050", Length = "0x3DB")]
	[Token(Token = "0x6000261")]
	internal DebugHandler() { }

	[Address(RVA = "0x2D581A0", Offset = "0x2D575A0", Length = "0x40")]
	[Token(Token = "0x6000266")]
	internal static void ConfigureColorDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight) { }

	[Address(RVA = "0x2D581E0", Offset = "0x2D575E0", Length = "0x54")]
	[Token(Token = "0x6000267")]
	internal static void ConfigureDepthDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, GraphicsFormat depthStencilFormat, int cameraWidth, int cameraHeight) { }

	[Address(RVA = "0x2D58330", Offset = "0x2D57730", Length = "0xE4")]
	[Token(Token = "0x6000274")]
	internal DebugRendererLists CreateRendererListsWithDebugRenderState(ScriptableRenderContext context, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock) { }

	[Address(RVA = "0x2D58240", Offset = "0x2D57640", Length = "0xE4")]
	[Token(Token = "0x6000275")]
	internal DebugRendererLists CreateRendererListsWithDebugRenderState(RenderGraph renderGraph, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock) { }

	[Address(RVA = "0x2D58420", Offset = "0x2D57820", Length = "0xC1")]
	[Token(Token = "0x6000262")]
	public void Dispose() { }

	[Address(RVA = "0x2D5B030", Offset = "0x2D5A430", Length = "0x2D")]
	[Token(Token = "0x6000251")]
	public override bool get_AreAnySettingsActive() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x6000257")]
	internal UniversalRenderPipelineDebugDisplaySettings get_DebugDisplaySettings() { }

	[Address(RVA = "0x2A009A0", Offset = "0x29FFDA0", Length = "0x5")]
	[Token(Token = "0x6000258")]
	internal RTHandle get_DebugScreenColorHandle() { }

	[Address(RVA = "0x1388FC0", Offset = "0x13883C0", Length = "0x5")]
	[Token(Token = "0x6000259")]
	internal RTHandle get_DebugScreenDepthHandle() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x600025A")]
	internal HDRDebugViewPass get_hdrDebugViewPass() { }

	[Address(RVA = "0x2D5B060", Offset = "0x2D5A460", Length = "0x76")]
	[Token(Token = "0x6000254")]
	internal bool get_IsActiveModeUnsupportedForDeferred() { }

	[Address(RVA = "0x2D5B0E0", Offset = "0x2D5A4E0", Length = "0x2A")]
	[Token(Token = "0x600025F")]
	internal bool get_IsDepthPrimingCompatible() { }

	[Address(RVA = "0x2D5B110", Offset = "0x2D5A510", Length = "0x2D")]
	[Token(Token = "0x6000253")]
	public override bool get_IsLightingActive() { }

	[Address(RVA = "0x2D5B140", Offset = "0x2D5A540", Length = "0x2D")]
	[Token(Token = "0x6000252")]
	public override bool get_IsPostProcessingAllowed() { }

	[Address(RVA = "0x2D5B170", Offset = "0x2D5A570", Length = "0x42")]
	[Token(Token = "0x600025E")]
	internal bool get_IsRenderPassSupported() { }

	[Address(RVA = "0x2D5B1C0", Offset = "0x2D5A5C0", Length = "0x3F")]
	[Token(Token = "0x600025D")]
	internal bool get_IsScreenClearNeeded() { }

	[Address(RVA = "0x2D5B200", Offset = "0x2D5A600", Length = "0x1E")]
	[Token(Token = "0x600024E")]
	private DebugDisplaySettingsLighting get_LightingSettings() { }

	[Address(RVA = "0x2D5B220", Offset = "0x2D5A620", Length = "0x1E")]
	[Token(Token = "0x600024F")]
	private DebugDisplaySettingsMaterial get_MaterialSettings() { }

	[Address(RVA = "0x2D5B240", Offset = "0x2D5A640", Length = "0x1E")]
	[Token(Token = "0x6000250")]
	private DebugDisplaySettingsRendering get_RenderingSettings() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000256")]
	internal Material get_ReplacementMaterial() { }

	[Address(RVA = "0x2D5B260", Offset = "0x2D5A660", Length = "0x26")]
	[Token(Token = "0x6000260")]
	internal int get_stpDebugViewIndex() { }

	[Address(RVA = "0x2D584F0", Offset = "0x2D578F0", Length = "0x2F")]
	[Token(Token = "0x600025B")]
	internal bool HDRDebugViewIsActive(bool resolveFinalTarget) { }

	[Address(RVA = "0x2D58520", Offset = "0x2D57920", Length = "0x209")]
	[Token(Token = "0x600026B")]
	private DebugFinalValidationPassData InitDebugFinalValidationPassData(DebugFinalValidationPassData passData, UniversalCameraData cameraData, bool isFinalPass) { }

	[Address(RVA = "0x2D58730", Offset = "0x2D57B30", Length = "0xAE")]
	[Token(Token = "0x600026F")]
	private DebugSetupPassData InitDebugSetupPassData(DebugSetupPassData passData, bool isPreviewCamera) { }

	[Address(RVA = "0x2D587E0", Offset = "0x2D57BE0", Length = "0x38")]
	[Token(Token = "0x6000263")]
	internal bool IsActiveForCamera(bool isPreviewCamera) { }

	[Address(RVA = "0x2D58820", Offset = "0x2D57C20", Length = "0x11D")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6000273")]
	internal void Render(RenderGraph renderGraph, UniversalCameraData cameraData, TextureHandle srcColor, TextureHandle overlayTexture, TextureHandle dstColor) { }

	[Address(RVA = "0x2D58940", Offset = "0x2D57D40", Length = "0x5")]
	[Token(Token = "0x600026A")]
	internal void ResetDebugRenderTarget() { }

	[Address(RVA = "0x2D58950", Offset = "0x2D57D50", Length = "0x97")]
	[Token(Token = "0x6000269")]
	internal void SetDebugRenderTarget(RTHandle renderTarget, Rect displayRect, bool supportsStereo, Vector4 dataRangeRemap) { }

	[Address(RVA = "0x2D59400", Offset = "0x2D58800", Length = "0x434")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6000270")]
	private static void Setup(RasterCommandBuffer cmd, DebugSetupPassData passData) { }

	[Address(RVA = "0x2D59060", Offset = "0x2D58460", Length = "0x39F")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6000272")]
	internal void Setup(RenderGraph renderGraph, bool isPreviewCamera) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6000271")]
	internal void Setup(CommandBuffer cmd, bool isPreviewCamera) { }

	[Address(RVA = "0x2D589F0", Offset = "0x2D57DF0", Length = "0x667")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x6000268")]
	internal void SetupShaderProperties(RasterCommandBuffer cmd, int passIndex = 0) { }

	[Address(RVA = "0x2D59890", Offset = "0x2D58C90", Length = "0x49")]
	[Token(Token = "0x6000265")]
	internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode, out int textureHeightPercent) { }

	[Address(RVA = "0x2D59840", Offset = "0x2D58C40", Length = "0x43")]
	[Token(Token = "0x6000264")]
	internal bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode) { }

	[Address(RVA = "0x2D598E0", Offset = "0x2D58CE0", Length = "0x2D")]
	[Token(Token = "0x6000255")]
	public override bool TryGetScreenClearColor(ref Color color) { }

	[Address(RVA = "0x2D5A2E0", Offset = "0x2D596E0", Length = "0x253")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600026D")]
	internal void UpdateShaderGlobalPropertiesForFinalValidationPass(CommandBuffer cmd, UniversalCameraData cameraData, bool isFinalPass) { }

	[Address(RVA = "0x2D5A030", Offset = "0x2D59430", Length = "0x2A1")]
	[Token(Token = "0x600026C")]
	private static void UpdateShaderGlobalPropertiesForFinalValidationPass(RasterCommandBuffer cmd, DebugFinalValidationPassData data) { }

	[Address(RVA = "0x2D59910", Offset = "0x2D58D10", Length = "0x71C")]
	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600026E")]
	internal void UpdateShaderGlobalPropertiesForFinalValidationPass(RenderGraph renderGraph, UniversalCameraData cameraData, bool isFinalPass) { }

	[Address(RVA = "0x2D584F0", Offset = "0x2D578F0", Length = "0x2F")]
	[Token(Token = "0x600025C")]
	internal bool WriteToDebugScreenTexture(bool resolveFinalTarget) { }

}

