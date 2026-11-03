namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: Runtime Shaders", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000197")]
public class UniversalRenderPipelineRuntimeShaders : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008F7")]
	private int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ResourcePath("Shaders/Utils/FallbackError.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008F8")]
	private Shader m_FallbackErrorShader; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[ResourcePath("Shaders/Utils/BlitHDROverlay.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008F9")]
	internal Shader m_BlitHDROverlay; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[ResourcePath("Shaders/Utils/CoreBlit.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008FA")]
	internal Shader m_CoreBlitPS; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[ResourcePath("Shaders/Utils/CoreBlitColorAndDepth.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008FB")]
	internal Shader m_CoreBlitColorAndDepthPS; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[ResourcePath("Shaders/Utils/Sampling.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008FC")]
	private Shader m_SamplingPS; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Header("Terrain")]
	[ResourcePath("Shaders/Terrain/TerrainDetailLit.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008FD")]
	private Shader m_TerrainDetailLit; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[ResourcePath("Shaders/Terrain/WavingGrassBillboard.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008FE")]
	private Shader m_TerrainDetailGrassBillboard; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[ResourcePath("Shaders/Terrain/WavingGrass.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008FF")]
	private Shader m_TerrainDetailGrass; //Field offset: 0x50

	[Token(Token = "0x17000205")]
	public Shader blitHDROverlay
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60008B0")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFCCF0", Offset = "0x2DFC0F0", Length = "0x65")]
		[Token(Token = "0x60008B1")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000207")]
	public Shader coreBlitColorAndDepthPS
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60008B4")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFCD60", Offset = "0x2DFC160", Length = "0x65")]
		[Token(Token = "0x60008B5")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000206")]
	public Shader coreBlitPS
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60008B2")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFCDD0", Offset = "0x2DFC1D0", Length = "0x65")]
		[Token(Token = "0x60008B3")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000204")]
	public Shader fallbackErrorShader
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60008AE")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFCE40", Offset = "0x2DFC240", Length = "0x65")]
		[Token(Token = "0x60008AF")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000208")]
	public Shader samplingPS
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x60008B6")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFCEB0", Offset = "0x2DFC2B0", Length = "0x65")]
		[Token(Token = "0x60008B7")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700020A")]
	public Shader terrainDetailGrassBillboardShader
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60008BA")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFCF20", Offset = "0x2DFC320", Length = "0x65")]
		[Token(Token = "0x60008BB")]
		 set { } //Length: 101
	}

	[Token(Token = "0x1700020B")]
	public Shader terrainDetailGrassShader
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60008BC")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFCF90", Offset = "0x2DFC390", Length = "0x65")]
		[Token(Token = "0x60008BD")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000209")]
	public Shader terrainDetailLitShader
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60008B8")]
		 get { } //Length: 5
		[Address(RVA = "0x2DFD000", Offset = "0x2DFC400", Length = "0x65")]
		[Token(Token = "0x60008B9")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000203")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60008AD")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000202")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x60008AC")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60008BE")]
	public UniversalRenderPipelineRuntimeShaders() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60008B0")]
	public Shader get_blitHDROverlay() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60008B4")]
	public Shader get_coreBlitColorAndDepthPS() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60008B2")]
	public Shader get_coreBlitPS() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60008AE")]
	public Shader get_fallbackErrorShader() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x60008B6")]
	public Shader get_samplingPS() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60008BA")]
	public Shader get_terrainDetailGrassBillboardShader() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60008BC")]
	public Shader get_terrainDetailGrassShader() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60008B8")]
	public Shader get_terrainDetailLitShader() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x60008AC")]
	public override int get_version() { }

	[Address(RVA = "0x2DFCCF0", Offset = "0x2DFC0F0", Length = "0x65")]
	[Token(Token = "0x60008B1")]
	public void set_blitHDROverlay(Shader value) { }

	[Address(RVA = "0x2DFCD60", Offset = "0x2DFC160", Length = "0x65")]
	[Token(Token = "0x60008B5")]
	public void set_coreBlitColorAndDepthPS(Shader value) { }

	[Address(RVA = "0x2DFCDD0", Offset = "0x2DFC1D0", Length = "0x65")]
	[Token(Token = "0x60008B3")]
	public void set_coreBlitPS(Shader value) { }

	[Address(RVA = "0x2DFCE40", Offset = "0x2DFC240", Length = "0x65")]
	[Token(Token = "0x60008AF")]
	public void set_fallbackErrorShader(Shader value) { }

	[Address(RVA = "0x2DFCEB0", Offset = "0x2DFC2B0", Length = "0x65")]
	[Token(Token = "0x60008B7")]
	public void set_samplingPS(Shader value) { }

	[Address(RVA = "0x2DFCF20", Offset = "0x2DFC320", Length = "0x65")]
	[Token(Token = "0x60008BB")]
	public void set_terrainDetailGrassBillboardShader(Shader value) { }

	[Address(RVA = "0x2DFCF90", Offset = "0x2DFC390", Length = "0x65")]
	[Token(Token = "0x60008BD")]
	public void set_terrainDetailGrassShader(Shader value) { }

	[Address(RVA = "0x2DFD000", Offset = "0x2DFC400", Length = "0x65")]
	[Token(Token = "0x60008B9")]
	public void set_terrainDetailLitShader(Shader value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60008AD")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

