namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000C5")]
public class DrawSkyboxPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x20000C7")]
	private sealed class <>c
	{
		[Token(Token = "0x4000448")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000449")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__6_0; //Field offset: 0x8

		[Address(RVA = "0x2D92880", Offset = "0x2D91C80", Length = "0x67")]
		[Token(Token = "0x6000510")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000511")]
		public <>c() { }

		[Address(RVA = "0x2D92680", Offset = "0x2D91A80", Length = "0xFE")]
		[Token(Token = "0x6000512")]
		internal void <Render>b__6_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x20000C6")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000445")]
		internal XRPass xr; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000446")]
		internal RendererListHandle skyRendererListHandle; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000447")]
		internal Material material; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600050F")]
		public PassData() { }

	}


	[Address(RVA = "0x2D8FBB0", Offset = "0x2D8EFB0", Length = "0x62")]
	[Token(Token = "0x600050A")]
	public DrawSkyboxPass(RenderPassEvent evt) { }

	[Address(RVA = "0x2D8EFC0", Offset = "0x2D8E3C0", Length = "0x3D7")]
	[Token(Token = "0x600050B")]
	private RendererListHandle CreateSkyBoxRendererList(RenderGraph renderGraph, UniversalCameraData cameraData) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000509")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2D8F3A0", Offset = "0x2D8E7A0", Length = "0xC0")]
	[Token(Token = "0x600050C")]
	private static void ExecutePass(RasterCommandBuffer cmd, XRPass xr, RendererList rendererList) { }

	[Address(RVA = "0x2D8F470", Offset = "0x2D8E870", Length = "0x4F")]
	[Token(Token = "0x600050D")]
	private void InitPassData(ref PassData passData, in XRPass xr, in RendererListHandle handle) { }

	[Address(RVA = "0x2D8F4C0", Offset = "0x2D8E8C0", Length = "0x6E4")]
	[Token(Token = "0x600050E")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, ScriptableRenderContext context, TextureHandle colorTarget, TextureHandle depthTarget, Material skyboxMaterial) { }

}

