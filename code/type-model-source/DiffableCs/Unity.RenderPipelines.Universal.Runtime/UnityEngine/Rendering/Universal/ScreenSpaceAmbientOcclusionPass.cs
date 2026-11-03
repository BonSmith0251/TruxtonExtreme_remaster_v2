namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000150")]
internal class ScreenSpaceAmbientOcclusionPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000155")]
	private sealed class <>c
	{
		[Token(Token = "0x40007D6")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40007D7")]
		public static BaseRenderFunc<SSAOPassData, UnsafeGraphContext> <>9__37_0; //Field offset: 0x8

		[Address(RVA = "0x2DE5140", Offset = "0x2DE4540", Length = "0x67")]
		[Token(Token = "0x60007C0")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007C1")]
		public <>c() { }

		[Address(RVA = "0x2DDFFD0", Offset = "0x2DDF3D0", Length = "0x6C2")]
		[Token(Token = "0x60007C2")]
		internal void <RecordRenderGraph>b__37_0(SSAOPassData data, UnsafeGraphContext rgContext) { }

	}

	[Token(Token = "0x2000151")]
	private enum BlurTypes : int
	{
		Bilateral = 0,
		Gaussian = 1,
		Kawase = 2,
	}

	[Token(Token = "0x2000152")]
	private enum ShaderPasses : int
	{
		AmbientOcclusion = 0,
		BilateralBlurHorizontal = 1,
		BilateralBlurVertical = 2,
		BilateralBlurFinal = 3,
		BilateralAfterOpaque = 4,
		GaussianBlurHorizontal = 5,
		GaussianBlurVertical = 6,
		GaussianAfterOpaque = 7,
		KawaseBlur = 8,
		KawaseAfterOpaque = 9,
	}

	[Token(Token = "0x2000153")]
	private struct SSAOMaterialParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007C1")]
		internal bool orthographicCamera; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x40007C2")]
		internal bool aoBlueNoise; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40007C3")]
		internal bool aoInterleavedGradient; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x40007C4")]
		internal bool sampleCountHigh; //Field offset: 0x3
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40007C5")]
		internal bool sampleCountMedium; //Field offset: 0x4
		[FieldOffset(Offset = "0x5")]
		[Token(Token = "0x40007C6")]
		internal bool sampleCountLow; //Field offset: 0x5
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x40007C7")]
		internal bool sourceDepthNormals; //Field offset: 0x6
		[FieldOffset(Offset = "0x7")]
		[Token(Token = "0x40007C8")]
		internal bool sourceDepthHigh; //Field offset: 0x7
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007C9")]
		internal bool sourceDepthMedium; //Field offset: 0x8
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x40007CA")]
		internal bool sourceDepthLow; //Field offset: 0x9
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40007CB")]
		internal Vector4 ssaoParams; //Field offset: 0xC

		[Address(RVA = "0x2DD8310", Offset = "0x2DD7710", Length = "0x16D")]
		[Token(Token = "0x60007BD")]
		internal SSAOMaterialParams(ref ScreenSpaceAmbientOcclusionSettings settings, bool isOrthographic) { }

		[Address(RVA = "0x2DD8220", Offset = "0x2DD7620", Length = "0xE1")]
		[Token(Token = "0x60007BE")]
		internal bool Equals(ref SSAOMaterialParams other) { }

	}

	[Token(Token = "0x2000154")]
	private class SSAOPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007CC")]
		internal bool afterOpaque; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40007CD")]
		internal BlurQualityOptions BlurQuality; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007CE")]
		internal Material material; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007CF")]
		internal float directLightingStrength; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40007D0")]
		internal TextureHandle cameraColor; //Field offset: 0x24
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40007D1")]
		internal TextureHandle AOTexture; //Field offset: 0x34
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x40007D2")]
		internal TextureHandle finalTexture; //Field offset: 0x44
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x40007D3")]
		internal TextureHandle blurTexture; //Field offset: 0x54
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x40007D4")]
		internal TextureHandle cameraNormalsTexture; //Field offset: 0x64
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40007D5")]
		internal UniversalCameraData cameraData; //Field offset: 0x78

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007BF")]
		public SSAOPassData() { }

	}

	[Token(Token = "0x40007A3")]
	private const string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture"; //Field offset: 0x0
	[Token(Token = "0x40007A5")]
	internal static readonly int s_AmbientOcclusionParamID; //Field offset: 0x0
	[Token(Token = "0x40007A4")]
	private const string k_AmbientOcclusionParamName = "_AmbientOcclusionParam"; //Field offset: 0x0
	[Token(Token = "0x40007A6")]
	private static readonly int s_SSAOParamsID; //Field offset: 0x4
	[Token(Token = "0x40007A7")]
	private static readonly int s_SSAOBlueNoiseParamsID; //Field offset: 0x8
	[Token(Token = "0x40007A8")]
	private static readonly int s_BlueNoiseTextureID; //Field offset: 0xC
	[Token(Token = "0x40007A9")]
	private static readonly int s_SSAOFinalTextureID; //Field offset: 0x10
	[Token(Token = "0x40007AA")]
	private static readonly int s_CameraViewXExtentID; //Field offset: 0x14
	[Token(Token = "0x40007AB")]
	private static readonly int s_CameraViewYExtentID; //Field offset: 0x18
	[Token(Token = "0x40007AC")]
	private static readonly int s_CameraViewZExtentID; //Field offset: 0x1C
	[Token(Token = "0x40007AD")]
	private static readonly int s_ProjectionParams2ID; //Field offset: 0x20
	[Token(Token = "0x40007AE")]
	private static readonly int s_CameraViewProjectionsID; //Field offset: 0x24
	[Token(Token = "0x40007AF")]
	private static readonly int s_CameraViewTopLeftCornerID; //Field offset: 0x28
	[Token(Token = "0x40007B0")]
	private static readonly int s_CameraNormalsTextureID; //Field offset: 0x2C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000796")]
	private readonly bool m_SupportsR8RenderTextureFormat; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000797")]
	private int m_BlueNoiseTextureIndex; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000798")]
	private Material m_Material; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000799")]
	private Texture2D[] m_BlueNoiseTextures; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400079A")]
	private Vector4[] m_CameraTopLeftCorner; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400079B")]
	private Vector4[] m_CameraXExtent; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400079C")]
	private Vector4[] m_CameraYExtent; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400079D")]
	private Vector4[] m_CameraZExtent; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400079E")]
	private BlurTypes m_BlurType; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400079F")]
	private Matrix4x4[] m_CameraViewProjections; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40007A0")]
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40007A1")]
	private RenderTextureDescriptor m_AOPassDescriptor; //Field offset: 0xB0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x40007A2")]
	private ScreenSpaceAmbientOcclusionSettings m_CurrentSettings; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x40007B1")]
	private SSAOMaterialParams m_SSAOParamsPrev; //Field offset: 0xF0

	[Address(RVA = "0x2DDA730", Offset = "0x2DD9B30", Length = "0x22C")]
	[Token(Token = "0x60007BC")]
	private static ScreenSpaceAmbientOcclusionPass() { }

	[Address(RVA = "0x2DDA960", Offset = "0x2DD9D60", Length = "0x1BB")]
	[Token(Token = "0x60007B3")]
	internal ScreenSpaceAmbientOcclusionPass() { }

	[Address(RVA = "0x2DD84F0", Offset = "0x2DD78F0", Length = "0x176")]
	[Token(Token = "0x60007B7")]
	private static Vector4 ComputeScaleBias(in UnsafeGraphContext context, in TextureHandle source, in TextureHandle destination) { }

	[Address(RVA = "0x2DD8670", Offset = "0x2DD7A70", Length = "0x41B")]
	[Token(Token = "0x60007B9")]
	private void CreateRenderTextureHandles(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, out TextureHandle aoTexture, out TextureHandle blurTexture, out TextureHandle finalTexture) { }

	[Address(RVA = "0x2DD8A90", Offset = "0x2DD7E90", Length = "0x1A")]
	[Token(Token = "0x60007BB")]
	public void Dispose() { }

	[Address(RVA = "0x2DD8AB0", Offset = "0x2DD7EB0", Length = "0x88")]
	[Token(Token = "0x60007B6")]
	private void InitSSAOPassData(ref SSAOPassData data) { }

	[Address(RVA = "0x2DD8B40", Offset = "0x2DD7F40", Length = "0xBF")]
	[Token(Token = "0x60007BA")]
	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	[Address(RVA = "0x2DD8C00", Offset = "0x2DD8000", Length = "0xA31")]
	[Token(Token = "0x60007B8")]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	[Address(RVA = "0x2DDA4C0", Offset = "0x2DD98C0", Length = "0x265")]
	[Token(Token = "0x60007B4")]
	internal bool Setup(ref ScreenSpaceAmbientOcclusionSettings featureSettings, ref ScriptableRenderer renderer, ref Material material, ref Texture2D[] blueNoiseTextures) { }

	[Address(RVA = "0x2DD9640", Offset = "0x2DD8A40", Length = "0xE7A")]
	[Token(Token = "0x60007B5")]
	private void SetupKeywordsAndParameters(ref ScreenSpaceAmbientOcclusionSettings settings, ref UniversalCameraData cameraData) { }

}

