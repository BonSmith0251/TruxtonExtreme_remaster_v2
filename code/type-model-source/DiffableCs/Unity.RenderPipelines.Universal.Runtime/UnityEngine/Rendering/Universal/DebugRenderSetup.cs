namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200006D")]
internal class DebugRenderSetup : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400021E")]
	private readonly DebugHandler m_DebugHandler; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400021F")]
	private readonly FilteringSettings m_FilteringSettings; //Field offset: 0x18
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000220")]
	private readonly int m_Index; //Field offset: 0x38

	[Token(Token = "0x170000B8")]
	private DebugDisplaySettingsLighting LightingSettings
	{
		[Address(RVA = "0x2D72780", Offset = "0x2D71B80", Length = "0x27")]
		[Token(Token = "0x6000286")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170000B6")]
	private DebugDisplaySettingsMaterial MaterialSettings
	{
		[Address(RVA = "0x2D727B0", Offset = "0x2D71BB0", Length = "0x27")]
		[Token(Token = "0x6000284")]
		private get { } //Length: 39
	}

	[Token(Token = "0x170000B7")]
	private DebugDisplaySettingsRendering RenderingSettings
	{
		[Address(RVA = "0x2D727E0", Offset = "0x2D71BE0", Length = "0x27")]
		[Token(Token = "0x6000285")]
		private get { } //Length: 39
	}

	[Address(RVA = "0x2D72720", Offset = "0x2D71B20", Length = "0x5E")]
	[Token(Token = "0x6000289")]
	internal DebugRenderSetup(DebugHandler debugHandler, int index, FilteringSettings filteringSettings) { }

	[Address(RVA = "0x2D719A0", Offset = "0x2D70DA0", Length = "0x62")]
	[Token(Token = "0x6000287")]
	internal void Begin(RasterCommandBuffer cmd) { }

	[Address(RVA = "0x2D71A10", Offset = "0x2D70E10", Length = "0x25C")]
	[Token(Token = "0x600028D")]
	internal DrawingSettings CreateDrawingSettings(DrawingSettings drawingSettings) { }

	[Address(RVA = "0x2D71C70", Offset = "0x2D71070", Length = "0x2CB")]
	[Token(Token = "0x600028A")]
	internal void CreateRendererList(ScriptableRenderContext context, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, ref RendererList rendererList) { }

	[Address(RVA = "0x2D71F40", Offset = "0x2D71340", Length = "0x2CB")]
	[Token(Token = "0x600028B")]
	internal void CreateRendererList(RenderGraph renderGraph, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, ref RendererListHandle rendererListHdl) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000290")]
	public override void Dispose() { }

	[Address(RVA = "0x2D72210", Offset = "0x2D71610", Length = "0x87")]
	[Token(Token = "0x600028C")]
	internal void DrawWithRendererList(RasterCommandBuffer cmd, ref RendererList rendererList) { }

	[Address(RVA = "0x2D722A0", Offset = "0x2D716A0", Length = "0x62")]
	[Token(Token = "0x6000288")]
	internal void End(RasterCommandBuffer cmd) { }

	[Address(RVA = "0x2D72780", Offset = "0x2D71B80", Length = "0x27")]
	[Token(Token = "0x6000286")]
	private DebugDisplaySettingsLighting get_LightingSettings() { }

	[Address(RVA = "0x2D727B0", Offset = "0x2D71BB0", Length = "0x27")]
	[Token(Token = "0x6000284")]
	private DebugDisplaySettingsMaterial get_MaterialSettings() { }

	[Address(RVA = "0x2D727E0", Offset = "0x2D71BE0", Length = "0x27")]
	[Token(Token = "0x6000285")]
	private DebugDisplaySettingsRendering get_RenderingSettings() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x600028F")]
	internal int GetIndex() { }

	[Address(RVA = "0x2D72310", Offset = "0x2D71710", Length = "0x409")]
	[Token(Token = "0x600028E")]
	internal RenderStateBlock GetRenderStateBlock(RenderStateBlock renderStateBlock) { }

}

