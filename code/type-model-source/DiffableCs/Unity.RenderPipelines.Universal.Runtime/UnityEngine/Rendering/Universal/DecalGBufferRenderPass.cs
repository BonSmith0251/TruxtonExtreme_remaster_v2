namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000098")]
internal class DecalGBufferRenderPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200009A")]
	private sealed class <>c
	{
		[Token(Token = "0x4000309")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400030A")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__11_0; //Field offset: 0x8

		[Address(RVA = "0x2D898A0", Offset = "0x2D88CA0", Length = "0x67")]
		[Token(Token = "0x600037A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600037B")]
		public <>c() { }

		[Address(RVA = "0x2D88CC0", Offset = "0x2D880C0", Length = "0x1B1")]
		[Token(Token = "0x600037C")]
		internal void <RecordRenderGraph>b__11_0(PassData data, RasterGraphContext rgContext) { }

	}

	[Token(Token = "0x2000099")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000304")]
		internal DecalDrawGBufferSystem drawSystem; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000305")]
		internal DecalScreenSpaceSettings settings; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000306")]
		internal bool decalLayers; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000307")]
		internal UniversalCameraData cameraData; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000308")]
		internal RendererListHandle rendererList; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000379")]
		public PassData() { }

	}

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002FE")]
	private FilteringSettings m_FilteringSettings; //Field offset: 0x60
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40002FF")]
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000300")]
	private DecalDrawGBufferSystem m_DrawSystem; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000301")]
	private DecalScreenSpaceSettings m_Settings; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000302")]
	private DeferredLights m_DeferredLights; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000303")]
	private bool m_DecalLayers; //Field offset: 0xA0

	[Address(RVA = "0x2D7C5C0", Offset = "0x2D7B9C0", Length = "0x32E")]
	[Token(Token = "0x6000373")]
	public DecalGBufferRenderPass(DecalScreenSpaceSettings settings, DecalDrawGBufferSystem drawSystem, bool decalLayers) { }

	[Address(RVA = "0x2D7B520", Offset = "0x2D7A920", Length = "0x17D")]
	[Token(Token = "0x6000376")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList) { }

	[Address(RVA = "0x2D7B6A0", Offset = "0x2D7AAA0", Length = "0x8E")]
	[Token(Token = "0x6000375")]
	private void InitPassData(UniversalCameraData cameraData, ref PassData passData) { }

	[Address(RVA = "0x2D7B730", Offset = "0x2D7AB30", Length = "0xFE")]
	[Token(Token = "0x6000378")]
	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	[Address(RVA = "0x2D7B830", Offset = "0x2D7AC30", Length = "0xD88")]
	[Token(Token = "0x6000377")]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

	[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
	[Token(Token = "0x6000374")]
	internal void Setup(DeferredLights deferredLights) { }

}

