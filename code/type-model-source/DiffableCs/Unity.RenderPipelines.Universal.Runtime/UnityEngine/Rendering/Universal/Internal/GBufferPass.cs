namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x2000235")]
internal class GBufferPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000237")]
	private sealed class <>c
	{
		[Token(Token = "0x4000DC3")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000DC4")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__18_0; //Field offset: 0x8

		[Address(RVA = "0x2E36800", Offset = "0x2E35C00", Length = "0x67")]
		[Token(Token = "0x6000C1E")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C1F")]
		public <>c() { }

		[Address(RVA = "0x2E366D0", Offset = "0x2E35AD0", Length = "0x128")]
		[Token(Token = "0x6000C20")]
		internal void <Render>b__18_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000236")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000DBF")]
		internal DeferredLights deferredLights; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000DC0")]
		internal RendererListHandle rendererListHdl; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000DC1")]
		internal RendererListHandle objectsWithErrorRendererListHdl; //Field offset: 0x24
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000DC2")]
		internal TextureHandle screenSpaceIrradianceHdl; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C1D")]
		public PassData() { }

	}

	[Token(Token = "0x4000DB2")]
	private static readonly int s_CameraNormalsTextureID; //Field offset: 0x0
	[Token(Token = "0x4000DB3")]
	private static readonly int s_CameraRenderingLayersTextureID; //Field offset: 0x4
	[Token(Token = "0x4000DB4")]
	private static readonly ShaderTagId s_ShaderTagLit; //Field offset: 0x8
	[Token(Token = "0x4000DB5")]
	private static readonly ShaderTagId s_ShaderTagSimpleLit; //Field offset: 0xC
	[Token(Token = "0x4000DB6")]
	private static readonly ShaderTagId s_ShaderTagUnlit; //Field offset: 0x10
	[Token(Token = "0x4000DB7")]
	private static readonly ShaderTagId s_ShaderTagComplexLit; //Field offset: 0x14
	[Token(Token = "0x4000DB8")]
	private static readonly ShaderTagId s_ShaderTagUniversalGBuffer; //Field offset: 0x18
	[Token(Token = "0x4000DB9")]
	private static readonly ShaderTagId s_ShaderTagUniversalMaterialType; //Field offset: 0x1C
	[Token(Token = "0x4000DBB")]
	private static ShaderTagId[] s_ShaderTagValues; //Field offset: 0x20
	[Token(Token = "0x4000DBC")]
	private static RenderStateBlock[] s_RenderStateBlocks; //Field offset: 0x28
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000DBA")]
	private DeferredLights m_DeferredLights; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000DBD")]
	private FilteringSettings m_FilteringSettings; //Field offset: 0x68
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000DBE")]
	private RenderStateBlock m_RenderStateBlock; //Field offset: 0x88

	[Address(RVA = "0x2E2F1D0", Offset = "0x2E2E5D0", Length = "0x1D5")]
	[Token(Token = "0x6000C1C")]
	private static GBufferPass() { }

	[Address(RVA = "0x2E2F3B0", Offset = "0x2E2E7B0", Length = "0x919")]
	[Token(Token = "0x6000C17")]
	public GBufferPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference, DeferredLights deferredLights) { }

	[Address(RVA = "0x2E2E0D0", Offset = "0x2E2D4D0", Length = "0x11")]
	[Token(Token = "0x6000C18")]
	public void Dispose() { }

	[Address(RVA = "0x2E2E0F0", Offset = "0x2E2D4F0", Length = "0x1CB")]
	[Token(Token = "0x6000C19")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData data, RendererList rendererList, RendererList errorRendererList) { }

	[Address(RVA = "0x2E2E2C0", Offset = "0x2E2D6C0", Length = "0x512")]
	[Token(Token = "0x6000C1A")]
	private void InitRendererLists(ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, bool useRenderGraph, uint batchLayerMask = 4294967295) { }

	[Address(RVA = "0x2E2E7E0", Offset = "0x2E2DBE0", Length = "0x9EC")]
	[Token(Token = "0x6000C1B")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle cameraColor, TextureHandle cameraDepth, bool setGlobalTextures, uint batchLayerMask = 4294967295) { }

}

