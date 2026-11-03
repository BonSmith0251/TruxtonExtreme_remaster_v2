namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000073")]
internal class DBufferRenderPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000075")]
	private sealed class <>c
	{
		[Token(Token = "0x4000239")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400023A")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__15_0; //Field offset: 0x8

		[Address(RVA = "0x2D89AD0", Offset = "0x2D88ED0", Length = "0x67")]
		[Token(Token = "0x60002BF")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002C0")]
		public <>c() { }

		[Address(RVA = "0x2D88E80", Offset = "0x2D88280", Length = "0x1C4")]
		[Token(Token = "0x60002C1")]
		internal void <RecordRenderGraph>b__15_0(PassData data, RasterGraphContext rgContext) { }

	}

	[Token(Token = "0x2000074")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000233")]
		internal DecalDrawDBufferSystem drawSystem; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000234")]
		internal DBufferSettings settings; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000235")]
		internal bool decalLayers; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000236")]
		internal RTHandle dBufferDepth; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000237")]
		internal RTHandle[] dBufferColorHandles; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000238")]
		internal RendererListHandle rendererList; //Field offset: 0x38

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002BE")]
		public PassData() { }

	}

	[Token(Token = "0x400022A")]
	internal static String[] s_DBufferNames; //Field offset: 0x0
	[Token(Token = "0x400022B")]
	internal static string s_DBufferDepthName; //Field offset: 0x8
	[Token(Token = "0x400022C")]
	private static readonly int s_SSAOTextureID; //Field offset: 0x10
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400022D")]
	private DecalDrawDBufferSystem m_DrawSystem; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400022E")]
	private DBufferSettings m_Settings; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400022F")]
	private FilteringSettings m_FilteringSettings; //Field offset: 0x70
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000230")]
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000231")]
	private bool m_DecalLayers; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000232")]
	private TextureHandle[] dbufferHandles; //Field offset: 0xA0

	[Address(RVA = "0x2D714B0", Offset = "0x2D708B0", Length = "0x199")]
	[Token(Token = "0x60002BD")]
	private static DBufferRenderPass() { }

	[Address(RVA = "0x2D71650", Offset = "0x2D70A50", Length = "0x34C")]
	[Token(Token = "0x60002B6")]
	public DBufferRenderPass(Material dBufferClear, DBufferSettings settings, DecalDrawDBufferSystem drawSystem, bool decalLayers) { }

	[Address(RVA = "0x2D6FA40", Offset = "0x2D6EE40", Length = "0x61")]
	[Token(Token = "0x60002B7")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList, bool renderGraph) { }

	[Address(RVA = "0x2D6FAB0", Offset = "0x2D6EEB0", Length = "0x64")]
	[Token(Token = "0x60002B9")]
	private void InitPassData(ref PassData passData) { }

	[Address(RVA = "0x2D6FB20", Offset = "0x2D6EF20", Length = "0x265")]
	[Token(Token = "0x60002BA")]
	private RendererListParams InitRendererListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[Address(RVA = "0x2D6FD90", Offset = "0x2D6F190", Length = "0xFE")]
	[Token(Token = "0x60002BC")]
	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	[Address(RVA = "0x2D6FE90", Offset = "0x2D6F290", Length = "0x1501")]
	[Token(Token = "0x60002BB")]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	[Address(RVA = "0x2D713A0", Offset = "0x2D707A0", Length = "0x104")]
	[Token(Token = "0x60002B8")]
	private static void SetKeywords(RasterCommandBuffer cmd, PassData passData) { }

}

