namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: SSAO Noise Textures", Order = 1000)]
[ElementInfo(Order = 0)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
[Token(Token = "0x2000186")]
internal class ScreenSpaceAmbientOcclusionDynamicResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[FieldOffset(Offset = "0x10")]
	[ResourceFormattedPaths("Textures/BlueNoise256/LDR_LLL1_{0}.png", 0, 7, SearchType::ProjectPath (0))]
	[SerializeField]
	[Token(Token = "0x40008B5")]
	private Texture2D[] m_BlueNoise256Textures; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40008B6")]
	private int m_Version; //Field offset: 0x18

	[Token(Token = "0x170001E4")]
	public Texture2D[] BlueNoise256Textures
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000823")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD8480", Offset = "0x2DD7880", Length = "0x65")]
		[Token(Token = "0x6000824")]
		 set { } //Length: 101
	}

	[Token(Token = "0x170001E5")]
	public override bool isAvailableInPlayerBuild
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000825")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170001E6")]
	public override int version
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000826")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000827")]
	public ScreenSpaceAmbientOcclusionDynamicResources() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000823")]
	public Texture2D[] get_BlueNoise256Textures() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000825")]
	public override bool get_isAvailableInPlayerBuild() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000826")]
	public override int get_version() { }

	[Address(RVA = "0x2DD8480", Offset = "0x2DD7880", Length = "0x65")]
	[Token(Token = "0x6000824")]
	public void set_BlueNoise256Textures(Texture2D[] value) { }

}

