namespace UnityEngine.Rendering.Universal;

[DisallowMultipleRendererFeature("Screen Space Ambient Occlusion")]
[SupportedOnRenderer(typeof(UniversalRendererData))]
[Token(Token = "0x2000187")]
[Tooltip("The Ambient Occlusion effect darkens creases, holes, intersections and surfaces that are close to each other.")]
public class ScreenSpaceAmbientOcclusion : ScriptableRendererFeature
{
	[Token(Token = "0x40008BC")]
	internal const string k_AOInterleavedGradientKeyword = "_INTERLEAVED_GRADIENT"; //Field offset: 0x0
	[Token(Token = "0x40008BD")]
	internal const string k_AOBlueNoiseKeyword = "_BLUE_NOISE"; //Field offset: 0x0
	[Token(Token = "0x40008BE")]
	internal const string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC"; //Field offset: 0x0
	[Token(Token = "0x40008BF")]
	internal const string k_SourceDepthLowKeyword = "_SOURCE_DEPTH_LOW"; //Field offset: 0x0
	[Token(Token = "0x40008C0")]
	internal const string k_SourceDepthMediumKeyword = "_SOURCE_DEPTH_MEDIUM"; //Field offset: 0x0
	[Token(Token = "0x40008C1")]
	internal const string k_SourceDepthHighKeyword = "_SOURCE_DEPTH_HIGH"; //Field offset: 0x0
	[Token(Token = "0x40008C2")]
	internal const string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS"; //Field offset: 0x0
	[Token(Token = "0x40008C3")]
	internal const string k_SampleCountLowKeyword = "_SAMPLE_COUNT_LOW"; //Field offset: 0x0
	[Token(Token = "0x40008C4")]
	internal const string k_SampleCountMediumKeyword = "_SAMPLE_COUNT_MEDIUM"; //Field offset: 0x0
	[Token(Token = "0x40008C5")]
	internal const string k_SampleCountHighKeyword = "_SAMPLE_COUNT_HIGH"; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40008B7")]
	private ScreenSpaceAmbientOcclusionSettings m_Settings; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008B8")]
	private Material m_Material; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008B9")]
	private ScreenSpaceAmbientOcclusionPass m_SSAOPass; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008BA")]
	private Shader m_Shader; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008BB")]
	private Texture2D[] m_BlueNoise256Textures; //Field offset: 0x40

	[Token(Token = "0x170001E7")]
	internal ScreenSpaceAmbientOcclusionSettings settings
	{
		[Address(RVA = "0x2815D60", Offset = "0x2815160", Length = "0x5")]
		[Token(Token = "0x6000828")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2DDB300", Offset = "0x2DDA700", Length = "0x9E")]
	[Token(Token = "0x600082D")]
	public ScreenSpaceAmbientOcclusion() { }

	[Address(RVA = "0x2DDABD0", Offset = "0x2DD9FD0", Length = "0xBA")]
	[Token(Token = "0x600082A")]
	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[Address(RVA = "0x2DDAC90", Offset = "0x2DDA090", Length = "0x255")]
	[Token(Token = "0x6000829")]
	public virtual void Create() { }

	[Address(RVA = "0x2DDAEF0", Offset = "0x2DDA2F0", Length = "0x82")]
	[Token(Token = "0x600082B")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x2815D60", Offset = "0x2815160", Length = "0x5")]
	[Token(Token = "0x6000828")]
	internal ScreenSpaceAmbientOcclusionSettings get_settings() { }

	[Address(RVA = "0x2DDAF80", Offset = "0x2DDA380", Length = "0x371")]
	[Token(Token = "0x600082C")]
	private bool TryPrepareResources() { }

}

