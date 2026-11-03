namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200004F")]
internal class DrawLight2DPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000051")]
	private sealed class <>c
	{
		[Token(Token = "0x40001D4")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001D5")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__16_0; //Field offset: 0x8
		[Token(Token = "0x40001D6")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__16_1; //Field offset: 0x10

		[Address(RVA = "0x2D2FF10", Offset = "0x2D2F310", Length = "0x67")]
		[Token(Token = "0x6000223")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000224")]
		public <>c() { }

		[Address(RVA = "0x2D2FC30", Offset = "0x2D2F030", Length = "0x82")]
		[Token(Token = "0x6000225")]
		internal void <Render>b__16_0(PassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2D2FCC0", Offset = "0x2D2F0C0", Length = "0x9B")]
		[Token(Token = "0x6000226")]
		internal void <Render>b__16_1(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000050")]
	public class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001CE")]
		internal LayerBatch layerBatch; //Field offset: 0x10
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40001CF")]
		internal Renderer2DData rendererData; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001D0")]
		internal bool isVolumetric; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x40001D1")]
		internal TextureHandle normalMap; //Field offset: 0x6C
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40001D2")]
		internal TextureHandle[] shadowTextures; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40001D3")]
		internal int lightTextureIndex; //Field offset: 0x88

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000222")]
		public PassData() { }

	}

	[Token(Token = "0x40001C3")]
	private static readonly string k_LightPass; //Field offset: 0x0
	[Token(Token = "0x40001C4")]
	private static readonly string k_LightSRTPass; //Field offset: 0x8
	[Token(Token = "0x40001C5")]
	private static readonly string k_LightVolumetricPass; //Field offset: 0x10
	[Token(Token = "0x40001C6")]
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x18
	[Token(Token = "0x40001C7")]
	private static readonly ProfilingSampler m_ProfilingSampleSRT; //Field offset: 0x20
	[Token(Token = "0x40001C8")]
	private static readonly ProfilingSampler m_ProfilingSamplerVolume; //Field offset: 0x28
	[Token(Token = "0x40001C9")]
	internal static readonly int k_InverseHDREmulationScaleID; //Field offset: 0x30
	[Token(Token = "0x40001CA")]
	internal static readonly string k_NormalMapID; //Field offset: 0x38
	[Token(Token = "0x40001CB")]
	internal static readonly string k_ShadowMapID; //Field offset: 0x40
	[Token(Token = "0x40001CD")]
	internal static MaterialPropertyBlock s_PropertyBlock; //Field offset: 0x48
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001CC")]
	private TextureHandle[] intermediateTexture; //Field offset: 0x60

	[Address(RVA = "0x2D1F240", Offset = "0x2D1E640", Length = "0x312")]
	[Token(Token = "0x6000221")]
	private static DrawLight2DPass() { }

	[Address(RVA = "0x2D1F560", Offset = "0x2D1E960", Length = "0x55")]
	[Token(Token = "0x6000220")]
	public DrawLight2DPass() { }

	[Address(RVA = "0x2D1DB80", Offset = "0x2D1CF80", Length = "0x72B")]
	[Token(Token = "0x600021D")]
	private static void Execute(RasterCommandBuffer cmd, PassData passData, ref LayerBatch layerBatch, int lightTextureIndex) { }

	[Address(RVA = "0x2D1E2B0", Offset = "0x2D1D6B0", Length = "0x556")]
	[Token(Token = "0x600021E")]
	private void InitializeRenderPass(IRasterRenderGraphBuilder builder, ContextContainer frameData, PassData passData, Renderer2DData rendererData, ref LayerBatch layerBatch, int batchIndex, bool isVolumetric = false) { }

	[Address(RVA = "0x2D1E810", Offset = "0x2D1DC10", Length = "0x7DF")]
	[Token(Token = "0x600021F")]
	internal void Render(RenderGraph graph, ContextContainer frameData, Renderer2DData rendererData, ref LayerBatch layerBatch, int batchIndex, bool isVolumetric = false) { }

	[Address(RVA = "0x2D1EFF0", Offset = "0x2D1E3F0", Length = "0x198")]
	[Token(Token = "0x600021B")]
	internal void Setup(RenderGraph renderGraph, ref Renderer2DData rendererData) { }

	[Address(RVA = "0x2D1F190", Offset = "0x2D1E590", Length = "0xA4")]
	[Token(Token = "0x600021C")]
	private static bool TryGetShadowIndex(ref LayerBatch layerBatch, int lightIndex, out int shadowIndex) { }

}

