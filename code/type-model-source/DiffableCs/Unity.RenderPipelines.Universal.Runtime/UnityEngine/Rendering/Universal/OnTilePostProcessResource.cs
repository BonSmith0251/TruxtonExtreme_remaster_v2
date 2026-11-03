namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: On Tile Post Process Resources", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000178")]
internal class OnTilePostProcessResource : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000876")]
	private int m_Version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[ResourcePath("Runtime/RendererFeatures/OnTileUberPost.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x4000877")]
	private Shader m_UberPostShader; //Field offset: 0x18

	[Token(Token = "0x170001E0")]
	public Shader uberPostShader
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000814")]
		 get { } //Length: 5
		[Address(RVA = "0x2DCB3B0", Offset = "0x2DCA7B0", Length = "0x65")]
		[Token(Token = "0x6000815")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170001DF")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000813")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170001DE")]
	public override int version
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6000812")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000816")]
	public OnTilePostProcessResource() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000814")]
	public Shader get_uberPostShader() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6000812")]
	public override int get_version() { }

	[Address(RVA = "0x2DCB3B0", Offset = "0x2DCA7B0", Length = "0x65")]
	[Token(Token = "0x6000815")]
	public void set_uberPostShader(Shader value) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000813")]
	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

