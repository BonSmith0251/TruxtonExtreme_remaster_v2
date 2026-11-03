namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200009C")]
internal class DecalScreenSpaceRenderPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200009E")]
	private sealed class <>c
	{
		[Token(Token = "0x4000317")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000318")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__10_0; //Field offset: 0x8

		[Address(RVA = "0x2D89830", Offset = "0x2D88C30", Length = "0x67")]
		[Token(Token = "0x6000386")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000387")]
		public <>c() { }

		[Address(RVA = "0x2D88A70", Offset = "0x2D87E70", Length = "0x249")]
		[Token(Token = "0x6000388")]
		internal void <RecordRenderGraph>b__10_0(PassData data, RasterGraphContext rgContext) { }

	}

	[Token(Token = "0x200009D")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000310")]
		internal DecalDrawScreenSpaceSystem drawSystem; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000311")]
		internal DecalScreenSpaceSettings settings; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000312")]
		internal bool decalLayers; //Field offset: 0x20
		[FieldOffset(Offset = "0x21")]
		[Token(Token = "0x4000313")]
		internal bool isGLDevice; //Field offset: 0x21
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000314")]
		internal TextureHandle colorTarget; //Field offset: 0x24
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000315")]
		internal UniversalCameraData cameraData; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000316")]
		internal RendererListHandle rendererList; //Field offset: 0x40

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000385")]
		public PassData() { }

	}

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400030B")]
	private FilteringSettings m_FilteringSettings; //Field offset: 0x60
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400030C")]
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400030D")]
	private DecalDrawScreenSpaceSystem m_DrawSystem; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400030E")]
	private DecalScreenSpaceSettings m_Settings; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400030F")]
	private bool m_DecalLayers; //Field offset: 0x98

	[Address(RVA = "0x2D7F8A0", Offset = "0x2D7ECA0", Length = "0x334")]
	[Token(Token = "0x600037F")]
	public DecalScreenSpaceRenderPass(DecalScreenSpaceSettings settings, DecalDrawScreenSpaceSystem drawSystem, bool decalLayers) { }

	[Address(RVA = "0x2D7E750", Offset = "0x2D7DB50", Length = "0x253")]
	[Token(Token = "0x6000380")]
	private RendererListParams CreateRenderListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[Address(RVA = "0x2D7E9B0", Offset = "0x2D7DDB0", Length = "0x183")]
	[Token(Token = "0x6000382")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList) { }

	[Address(RVA = "0x2D7EB40", Offset = "0x2D7DF40", Length = "0xD5")]
	[Token(Token = "0x6000381")]
	private void InitPassData(UniversalCameraData cameraData, ref PassData passData) { }

	[Address(RVA = "0x2D7EC20", Offset = "0x2D7E020", Length = "0xFE")]
	[Token(Token = "0x6000384")]
	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	[Address(RVA = "0x2D7ED20", Offset = "0x2D7E120", Length = "0xB73")]
	[Token(Token = "0x6000383")]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

}

