namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: SSAO Shader", Order = 1000)]
[ElementInfo(Order = 0)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000185")]
internal class ScreenSpaceAmbientOcclusionPersistentResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[ResourcePath("Shaders/Utils/ScreenSpaceAmbientOcclusion.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008B3")]
	private Shader m_Shader; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008B4")]
	private int m_Version; //Field offset: 0x18

	[Token(Token = "0x170001E2")]
	public override bool isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000820")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001E1")]
	public Shader Shader
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600081E")]
		 get { } //Length: 5
		[Address(RVA = "0x2DDAB20", Offset = "0x2DD9F20", Length = "0x65")]
		[Token(Token = "0x600081F")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170001E3")]
	public override int version
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000821")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000822")]
	public ScreenSpaceAmbientOcclusionPersistentResources() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000820")]
	public override bool get_isAvailableInPlayerBuild() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600081E")]
	public Shader get_Shader() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000821")]
	public override int get_version() { }

	[Address(RVA = "0x2DDAB20", Offset = "0x2DD9F20", Length = "0x65")]
	[Token(Token = "0x600081F")]
	public void set_Shader(Shader value) { }

}

