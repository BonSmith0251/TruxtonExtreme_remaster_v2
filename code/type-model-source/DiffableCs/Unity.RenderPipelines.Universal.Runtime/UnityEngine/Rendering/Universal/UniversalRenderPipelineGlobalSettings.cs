namespace UnityEngine.Rendering.Universal;

[DisplayInfo(name = "URP Global Settings Asset", order = 40002)]
[DisplayName("URP")]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x20000BB")]
internal class UniversalRenderPipelineGlobalSettings : RenderPipelineGlobalSettings<UniversalRenderPipelineGlobalSettings, UniversalRenderPipeline>
{
	[Token(Token = "0x40003D4")]
	internal const int k_LastVersion = 9; //Field offset: 0x0
	[Token(Token = "0x40003D6")]
	public const string defaultAssetName = "UniversalRenderPipelineGlobalSettings"; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Obsolete("Keep for migration. #from(2023.2)")]
	[SerializeField]
	[Token(Token = "0x40003C9")]
	internal ShaderStrippingSetting m_ShaderStrippingSetting; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Obsolete("Keep for migration. #from(2023.2)")]
	[SerializeField]
	[Token(Token = "0x40003CA")]
	internal URPShaderStrippingSetting m_URPShaderStrippingSetting; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Obsolete("Keep for migration. #from(2023.2)")]
	[SerializeField]
	[Token(Token = "0x40003CB")]
	internal ShaderVariantLogLevel m_ShaderVariantLogLevel; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Obsolete("Keep for migration. #from(2023.2)")]
	[SerializeField]
	[Token(Token = "0x40003CC")]
	internal bool m_ExportShaderVariants; //Field offset: 0x34
	[FieldOffset(Offset = "0x35")]
	[Obsolete("Keep for migration. #from(2023.2)")]
	[SerializeField]
	[Token(Token = "0x40003CD")]
	internal bool m_StripDebugVariants; //Field offset: 0x35
	[FieldOffset(Offset = "0x36")]
	[Obsolete("Keep for migration. #from(2023.2)")]
	[SerializeField]
	[Token(Token = "0x40003CE")]
	internal bool m_StripUnusedPostProcessingVariants; //Field offset: 0x36
	[FieldOffset(Offset = "0x37")]
	[Obsolete("Keep for migration. #from(2023.2)")]
	[SerializeField]
	[Token(Token = "0x40003CF")]
	internal bool m_StripUnusedVariants; //Field offset: 0x37
	[FieldOffset(Offset = "0x38")]
	[Obsolete("Keep for migration. #from(2023.2)")]
	[SerializeField]
	[Token(Token = "0x40003D0")]
	internal bool m_StripScreenCoordOverrideVariants; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Obsolete("Please use stripRuntimeDebugShaders instead. #from(2023.1)")]
	[Token(Token = "0x40003D1")]
	public bool supportRuntimeDebugDisplay; //Field offset: 0x39
	[FieldOffset(Offset = "0x3A")]
	[Obsolete("Keep for migration. #from(2023.2)")]
	[SerializeField]
	[Token(Token = "0x40003D2")]
	internal bool m_EnableRenderGraph; //Field offset: 0x3A
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40003D3")]
	private RenderPipelineGraphicsSettingsContainer m_Settings; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[FormerlySerializedAs("k_AssetVersion")]
	[SerializeField]
	[Token(Token = "0x40003D5")]
	internal int m_AssetVersion; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("m_DefaultVolumeProfile")]
	[Obsolete("Kept For Migration. #from(2023.3)")]
	[SerializeField]
	[Token(Token = "0x40003D7")]
	internal VolumeProfile m_ObsoleteDefaultVolumeProfile; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40003D8")]
	internal String[] m_RenderingLayerNames; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x40003D9")]
	private uint m_ValidRenderingLayers; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
	[Token(Token = "0x40003DA")]
	public string lightLayerName0; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
	[Token(Token = "0x40003DB")]
	public string lightLayerName1; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
	[Token(Token = "0x40003DC")]
	public string lightLayerName2; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
	[Token(Token = "0x40003DD")]
	public string lightLayerName3; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
	[Token(Token = "0x40003DE")]
	public string lightLayerName4; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
	[Token(Token = "0x40003DF")]
	public string lightLayerName5; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
	[Token(Token = "0x40003E0")]
	public string lightLayerName6; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Obsolete("This is obsolete, please use renderingLayerNames instead. #from(2022.2)")]
	[Token(Token = "0x40003E1")]
	public string lightLayerName7; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x40003E2")]
	internal ProbeVolumeSceneData apvScenesData; //Field offset: 0xA8

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead. #from(2022.2)")]
	[Token(Token = "0x1700011C")]
	public String[] lightLayerNames
	{
		[Address(RVA = "0x2D952B0", Offset = "0x2D946B0", Length = "0x32")]
		[Token(Token = "0x6000471")]
		 get { } //Length: 50
	}

	[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(2022.2) #breackingFrom(2023.1)", True)]
	[Token(Token = "0x1700011B")]
	public String[] prefixedLightLayerNames
	{
		[Address(RVA = "0x2D952F0", Offset = "0x2D946F0", Length = "0x32")]
		[Token(Token = "0x6000470")]
		 get { } //Length: 50
	}

	[Token(Token = "0x1700011A")]
	protected virtual List<IRenderPipelineGraphicsSettings> settingsList
	{
		[Address(RVA = "0x2D95330", Offset = "0x2D94730", Length = "0x1D")]
		[Token(Token = "0x600046C")]
		 get { } //Length: 29
	}

	[Obsolete("No longer used as Shader Prefiltering automatically strips out unused LOD Crossfade variants. Please use the LOD Crossfade setting in the URP Asset to disable the feature if not used. #from(2023.1)")]
	[Token(Token = "0x17000119")]
	public bool stripUnusedLODCrossFadeVariants
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600046A")]
		 get { } //Length: 3
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600046B")]
		 set { } //Length: 3
	}

	[Address(RVA = "0x2D95130", Offset = "0x2D94530", Length = "0x17B")]
	[Token(Token = "0x6000474")]
	public UniversalRenderPipelineGlobalSettings() { }

	[Address(RVA = "0x2D952B0", Offset = "0x2D946B0", Length = "0x32")]
	[Token(Token = "0x6000471")]
	public String[] get_lightLayerNames() { }

	[Address(RVA = "0x2D952F0", Offset = "0x2D946F0", Length = "0x32")]
	[Token(Token = "0x6000470")]
	public String[] get_prefixedLightLayerNames() { }

	[Address(RVA = "0x2D95330", Offset = "0x2D94730", Length = "0x1D")]
	[Token(Token = "0x600046C")]
	protected virtual List<IRenderPipelineGraphicsSettings> get_settingsList() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600046A")]
	public bool get_stripUnusedLODCrossFadeVariants() { }

	[Address(RVA = "0x2D94FB0", Offset = "0x2D943B0", Length = "0x9A")]
	[Token(Token = "0x6000473")]
	internal ProbeVolumeSceneData GetOrCreateAPVSceneData() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x600046F")]
	internal static VolumeProfile GetOrCreateDefaultVolumeProfile(VolumeProfile defaultVolumeProfile) { }

	[Address(RVA = "0x2D95050", Offset = "0x2D94450", Length = "0x8")]
	[Token(Token = "0x600046D")]
	internal bool IsAtLastVersion() { }

	[Address(RVA = "0x2D950F0", Offset = "0x2D944F0", Length = "0x40")]
	[Token(Token = "0x600046E")]
	public virtual void Reset() { }

	[Address(RVA = "0x2D95060", Offset = "0x2D94460", Length = "0x8D")]
	[Token(Token = "0x6000472")]
	internal void ResetRenderingLayerNames() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600046B")]
	public void set_stripUnusedLODCrossFadeVariants(bool value) { }

}

