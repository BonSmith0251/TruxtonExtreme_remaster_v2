namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000124")]
internal class DrawScreenSpaceUIPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000127")]
	private sealed class <>c
	{
		[Token(Token = "0x4000659")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400065A")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__13_0; //Field offset: 0x8
		[Token(Token = "0x400065B")]
		public static BaseRenderFunc<UnsafePassData, UnsafeGraphContext> <>9__13_1; //Field offset: 0x10
		[Token(Token = "0x400065C")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__14_0; //Field offset: 0x18
		[Token(Token = "0x400065D")]
		public static BaseRenderFunc<UnsafePassData, UnsafeGraphContext> <>9__14_1; //Field offset: 0x20

		[Address(RVA = "0x2DC8DE0", Offset = "0x2DC81E0", Length = "0x67")]
		[Token(Token = "0x6000719")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600071A")]
		public <>c() { }

		[Address(RVA = "0x2DC84B0", Offset = "0x2DC78B0", Length = "0xA5")]
		[Token(Token = "0x600071B")]
		internal void <RenderOffscreen>b__13_0(PassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DC8560", Offset = "0x2DC7960", Length = "0x131")]
		[Token(Token = "0x600071C")]
		internal void <RenderOffscreen>b__13_1(UnsafePassData data, UnsafeGraphContext context) { }

		[Address(RVA = "0x2D89050", Offset = "0x2D88450", Length = "0x66")]
		[Token(Token = "0x600071D")]
		internal void <RenderOverlay>b__14_0(PassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2DC86A0", Offset = "0x2DC7AA0", Length = "0x131")]
		[Token(Token = "0x600071E")]
		internal void <RenderOverlay>b__14_1(UnsafePassData data, UnsafeGraphContext context) { }

	}

	[Token(Token = "0x2000125")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000656")]
		internal RendererListHandle rendererList; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000717")]
		public PassData() { }

	}

	[Token(Token = "0x2000126")]
	private class UnsafePassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000657")]
		internal RendererListHandle rendererList; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000658")]
		internal TextureHandle colorTarget; //Field offset: 0x1C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000718")]
		public UnsafePassData() { }

	}

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000653")]
	private RTHandle m_ColorTarget; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000654")]
	private RTHandle m_DepthTarget; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000655")]
	private bool m_RenderOffscreen; //Field offset: 0x70

	[Address(RVA = "0x2DABD90", Offset = "0x2DAB190", Length = "0x74")]
	[Token(Token = "0x600070D")]
	public DrawScreenSpaceUIPass(RenderPassEvent evt, bool renderOffscreen) { }

	[Address(RVA = "0x2DAAA20", Offset = "0x2DA9E20", Length = "0x40")]
	[Token(Token = "0x600070E")]
	private static void ConfigureColorDescriptor(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight) { }

	[Address(RVA = "0x2DAAA60", Offset = "0x2DA9E60", Length = "0x46")]
	[Token(Token = "0x6000710")]
	private static void ConfigureDepthDescriptor(ref RenderTextureDescriptor descriptor, GraphicsFormat depthStencilFormat, int targetWidth, int targetHeight) { }

	[Address(RVA = "0x2DAAAB0", Offset = "0x2DA9EB0", Length = "0x34")]
	[Token(Token = "0x600070F")]
	internal static void ConfigureOffscreenUITextureDesc(ref TextureDesc textureDesc) { }

	[Address(RVA = "0x2DAAAF0", Offset = "0x2DA9EF0", Length = "0x34")]
	[Token(Token = "0x6000713")]
	public void Dispose() { }

	[Address(RVA = "0x2D7C8F0", Offset = "0x2D7BCF0", Length = "0x35")]
	[Token(Token = "0x6000711")]
	private static void ExecutePass(RasterCommandBuffer commandBuffer, PassData passData, RendererList rendererList) { }

	[Address(RVA = "0x2D7C8F0", Offset = "0x2D7BCF0", Length = "0x35")]
	[Token(Token = "0x6000712")]
	private static void ExecutePass(UnsafeCommandBuffer commandBuffer, UnsafePassData passData, RendererList rendererList) { }

	[Address(RVA = "0x2DAAB30", Offset = "0x2DA9F30", Length = "0x903")]
	[Token(Token = "0x6000715")]
	internal void RenderOffscreen(RenderGraph renderGraph, ContextContainer frameData, GraphicsFormat depthStencilFormat, TextureHandle overlayUITexture) { }

	[Address(RVA = "0x2DAB440", Offset = "0x2DAA840", Length = "0x745")]
	[Token(Token = "0x6000716")]
	internal void RenderOverlay(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle colorBuffer, in TextureHandle depthBuffer) { }

	[Address(RVA = "0x2DABB90", Offset = "0x2DAAF90", Length = "0x1FC")]
	[Token(Token = "0x6000714")]
	public void Setup(UniversalCameraData cameraData, GraphicsFormat depthStencilFormat) { }

}

