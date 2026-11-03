namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200006C")]
internal class DebugRendererLists
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000219")]
	private readonly DebugHandler m_DebugHandler; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400021A")]
	private readonly FilteringSettings m_FilteringSettings; //Field offset: 0x18
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400021B")]
	private List<DebugRenderSetup> m_DebugRenderSetups; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400021C")]
	private List<RendererList> m_ActiveDebugRendererList; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400021D")]
	private List<RendererListHandle> m_ActiveDebugRendererListHdl; //Field offset: 0x48

	[Address(RVA = "0x2D73D30", Offset = "0x2D73130", Length = "0x14C")]
	[Token(Token = "0x600027D")]
	public DebugRendererLists(DebugHandler debugHandler, FilteringSettings filteringSettings) { }

	[Address(RVA = "0x2D72810", Offset = "0x2D71C10", Length = "0x180")]
	[Token(Token = "0x600027E")]
	private void CreateDebugRenderSetups(FilteringSettings filteringSettings) { }

	[Address(RVA = "0x2D72FB0", Offset = "0x2D723B0", Length = "0x5F2")]
	[Token(Token = "0x6000280")]
	internal void CreateRendererListsWithDebugRenderState(ScriptableRenderContext context, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock) { }

	[Address(RVA = "0x2D729A0", Offset = "0x2D71DA0", Length = "0x60B")]
	[Token(Token = "0x6000281")]
	internal void CreateRendererListsWithDebugRenderState(RenderGraph renderGraph, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock) { }

	[Address(RVA = "0x2D735B0", Offset = "0x2D729B0", Length = "0x190")]
	[Token(Token = "0x600027F")]
	private void DisposeDebugRenderLists() { }

	[Address(RVA = "0x2D73750", Offset = "0x2D72B50", Length = "0x3FB")]
	[Token(Token = "0x6000283")]
	internal void DrawWithRendererList(RasterCommandBuffer cmd) { }

	[Address(RVA = "0x2D73B50", Offset = "0x2D72F50", Length = "0x1D1")]
	[Token(Token = "0x6000282")]
	internal void PrepareRendererListForRasterPass(IRasterRenderGraphBuilder builder) { }

}

