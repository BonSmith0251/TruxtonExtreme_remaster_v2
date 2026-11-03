namespace UnityEngine.Rendering;

[CategoryInfo(Name = "VRS - Runtime Resources", Order = 1000)]
[SupportedOnRenderPipeline(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {})]
[Token(Token = "0x2000230")]
public sealed class VrsRenderPipelineRuntimeResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[ResourcePath("Runtime/Vrs/Shaders/VrsTexture.compute", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40009C8")]
	[Tooltip("Compute shader used for converting textures to shading rate values")]
	private ComputeShader m_TextureComputeShader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ResourcePath("Runtime/Vrs/Shaders/VrsVisualization.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40009C9")]
	[Tooltip("Shader used when visualizing shading rate values as a color image")]
	private Shader m_VisualizationShader; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40009CA")]
	[Tooltip("Colors to visualize the shading rates")]
	private VrsLut m_VisualizationLookupTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40009CB")]
	[Tooltip("Colors to convert between shading rates and textures")]
	private VrsLut m_ConversionLookupTable; //Field offset: 0x28

	[Token(Token = "0x17000204")]
	public VrsLut conversionLookupTable
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x6000FB5")]
		 get { } //Length: 5
		[Address(RVA = "0x2C89370", Offset = "0x2C88770", Length = "0x65")]
		[Token(Token = "0x6000FB6")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000201")]
	public ComputeShader textureComputeShader
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000FAF")]
		 get { } //Length: 5
		[Address(RVA = "0x2C893E0", Offset = "0x2C887E0", Length = "0x65")]
		[Token(Token = "0x6000FB0")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000200")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000FAE")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001FF")]
	public override int version
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000FAD")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000203")]
	public VrsLut visualizationLookupTable
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000FB3")]
		 get { } //Length: 5
		[Address(RVA = "0x2C89450", Offset = "0x2C88850", Length = "0x65")]
		[Token(Token = "0x6000FB4")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000202")]
	public Shader visualizationShader
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000FB1")]
		 get { } //Length: 5
		[Address(RVA = "0x2C894C0", Offset = "0x2C888C0", Length = "0x65")]
		[Token(Token = "0x6000FB2")]
		 set { } //Length: 101
	}

	[Address(RVA = "0x2C89320", Offset = "0x2C88720", Length = "0x46")]
	[Token(Token = "0x6000FB7")]
	public VrsRenderPipelineRuntimeResources() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x6000FB5")]
	public VrsLut get_conversionLookupTable() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000FAF")]
	public ComputeShader get_textureComputeShader() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000FAD")]
	public override int get_version() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000FB3")]
	public VrsLut get_visualizationLookupTable() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000FB1")]
	public Shader get_visualizationShader() { }

	[Address(RVA = "0x2C89370", Offset = "0x2C88770", Length = "0x65")]
	[Token(Token = "0x6000FB6")]
	public void set_conversionLookupTable(VrsLut value) { }

	[Address(RVA = "0x2C893E0", Offset = "0x2C887E0", Length = "0x65")]
	[Token(Token = "0x6000FB0")]
	public void set_textureComputeShader(ComputeShader value) { }

	[Address(RVA = "0x2C89450", Offset = "0x2C88850", Length = "0x65")]
	[Token(Token = "0x6000FB4")]
	public void set_visualizationLookupTable(VrsLut value) { }

	[Address(RVA = "0x2C894C0", Offset = "0x2C888C0", Length = "0x65")]
	[Token(Token = "0x6000FB2")]
	public void set_visualizationShader(Shader value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000FAE")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

