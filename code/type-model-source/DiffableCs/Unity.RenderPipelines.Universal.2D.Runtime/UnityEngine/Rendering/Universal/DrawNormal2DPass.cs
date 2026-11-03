namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000052")]
internal class DrawNormal2DPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000054")]
	private sealed class <>c
	{
		[Token(Token = "0x40001DB")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001DC")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__5_0; //Field offset: 0x8

		[Address(RVA = "0x2D2FF80", Offset = "0x2D2F380", Length = "0x58B")]
		[Token(Token = "0x600022C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600022D")]
		public <>c() { }

		[Address(RVA = "0x2D2FD60", Offset = "0x2D2F160", Length = "0xA6")]
		[Token(Token = "0x600022E")]
		internal void <Render>b__5_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000053")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001DA")]
		internal RendererListHandle rendererList; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600022B")]
		public PassData() { }

	}

	[Token(Token = "0x40001D7")]
	private static readonly string k_NormalPass; //Field offset: 0x0
	[Token(Token = "0x40001D8")]
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x8
	[Token(Token = "0x40001D9")]
	private static readonly ShaderTagId k_NormalsRenderingPassName; //Field offset: 0x10

	[Address(RVA = "0x2D202B0", Offset = "0x2D1F6B0", Length = "0x112")]
	[Token(Token = "0x600022A")]
	private static DrawNormal2DPass() { }

	[Address(RVA = "0x2D203D0", Offset = "0x2D1F7D0", Length = "0x7")]
	[Token(Token = "0x6000229")]
	public DrawNormal2DPass() { }

	[Address(RVA = "0x2D1F5C0", Offset = "0x2D1E9C0", Length = "0x65")]
	[Token(Token = "0x6000227")]
	private static void Execute(RasterCommandBuffer cmd, PassData passData) { }

	[Address(RVA = "0x2D1F630", Offset = "0x2D1EA30", Length = "0xC77")]
	[Token(Token = "0x6000228")]
	public void Render(RenderGraph graph, ContextContainer frameData, Renderer2DData rendererData, ref LayerBatch layerBatch, int batchIndex) { }

}

