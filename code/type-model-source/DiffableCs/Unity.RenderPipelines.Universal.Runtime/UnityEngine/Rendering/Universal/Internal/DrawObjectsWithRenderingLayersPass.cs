namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x2000232")]
internal class DrawObjectsWithRenderingLayersPass : DrawObjectsPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000234")]
	private sealed class <>c
	{
		[Token(Token = "0x4000DB0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000DB1")]
		public static BaseRenderFunc<RenderingLayersPassData, RasterGraphContext> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x2E35870", Offset = "0x2E34C70", Length = "0x67")]
		[Token(Token = "0x6000C14")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C15")]
		public <>c() { }

		[Address(RVA = "0x2E34EF0", Offset = "0x2E342F0", Length = "0x293")]
		[Token(Token = "0x6000C16")]
		internal void <Render>b__2_0(RenderingLayersPassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000233")]
	private class RenderingLayersPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000DAE")]
		internal PassData basePassData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000DAF")]
		internal MaskSize maskSize; //Field offset: 0x18

		[Address(RVA = "0x2E33700", Offset = "0x2E32B00", Length = "0x66")]
		[Token(Token = "0x6000C13")]
		public RenderingLayersPassData() { }

	}


	[Address(RVA = "0x2E27FF0", Offset = "0x2E273F0", Length = "0x15E")]
	[Token(Token = "0x6000C11")]
	public DrawObjectsWithRenderingLayersPass(URPProfileId profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference) { }

	[Address(RVA = "0x2E27430", Offset = "0x2E26830", Length = "0xBBC")]
	[Token(Token = "0x6000C12")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle colorTarget, TextureHandle renderingLayersTexture, TextureHandle depthTarget, TextureHandle mainShadowsTexture, TextureHandle additionalShadowsTexture, MaskSize maskSize, uint batchLayerMask = 4294967295) { }

}

