namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000077")]
internal class DecalForwardEmissivePass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000079")]
	private sealed class <>c
	{
		[Token(Token = "0x4000240")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000241")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__8_0; //Field offset: 0x8

		[Address(RVA = "0x2D897C0", Offset = "0x2D88BC0", Length = "0x67")]
		[Token(Token = "0x60002CA")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002CB")]
		public <>c() { }

		[Address(RVA = "0x2D890C0", Offset = "0x2D884C0", Length = "0xA6")]
		[Token(Token = "0x60002CC")]
		internal void <RecordRenderGraph>b__8_0(PassData data, RasterGraphContext rgContext) { }

	}

	[Token(Token = "0x2000078")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400023E")]
		internal DecalDrawFowardEmissiveSystem drawSystem; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400023F")]
		internal RendererListHandle rendererList; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002C9")]
		public PassData() { }

	}

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400023B")]
	private FilteringSettings m_FilteringSettings; //Field offset: 0x60
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400023C")]
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400023D")]
	private DecalDrawFowardEmissiveSystem m_DrawSystem; //Field offset: 0x88

	[Address(RVA = "0x2D7B1F0", Offset = "0x2D7A5F0", Length = "0x321")]
	[Token(Token = "0x60002C4")]
	public DecalForwardEmissivePass(DecalDrawFowardEmissiveSystem drawSystem) { }

	[Address(RVA = "0x2D6FA40", Offset = "0x2D6EE40", Length = "0x61")]
	[Token(Token = "0x60002C7")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList) { }

	[Address(RVA = "0x2D7A730", Offset = "0x2D79B30", Length = "0x29")]
	[Token(Token = "0x60002C5")]
	private void InitPassData(ref PassData passData) { }

	[Address(RVA = "0x2D7A760", Offset = "0x2D79B60", Length = "0x262")]
	[Token(Token = "0x60002C6")]
	private RendererListParams InitRendererListParams(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData) { }

	[Address(RVA = "0x2D7A9D0", Offset = "0x2D79DD0", Length = "0x81F")]
	[Token(Token = "0x60002C8")]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

}

