namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200007B")]
internal class DecalPreviewPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200007D")]
	private sealed class <>c
	{
		[Token(Token = "0x4000247")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000248")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__6_0; //Field offset: 0x8

		[Address(RVA = "0x2D899F0", Offset = "0x2D88DF0", Length = "0x67")]
		[Token(Token = "0x60002D4")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002D5")]
		public <>c() { }

		[Address(RVA = "0x2D89050", Offset = "0x2D88450", Length = "0x66")]
		[Token(Token = "0x60002D6")]
		internal void <RecordRenderGraph>b__6_0(PassData data, RasterGraphContext rgContext) { }

	}

	[Token(Token = "0x200007C")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000246")]
		internal RendererListHandle rendererList; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60002D3")]
		public PassData() { }

	}

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000243")]
	private FilteringSettings m_FilteringSettings; //Field offset: 0x60
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000244")]
	private List<ShaderTagId> m_ShaderTagIdList; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000245")]
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0x88

	[Address(RVA = "0x2D7D0D0", Offset = "0x2D7C4D0", Length = "0x23D")]
	[Token(Token = "0x60002D0")]
	public DecalPreviewPass() { }

	[Address(RVA = "0x2D7C8F0", Offset = "0x2D7BCF0", Length = "0x35")]
	[Token(Token = "0x60002D1")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RendererList rendererList) { }

	[Address(RVA = "0x2D7C930", Offset = "0x2D7BD30", Length = "0x794")]
	[Token(Token = "0x60002D2")]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

}

