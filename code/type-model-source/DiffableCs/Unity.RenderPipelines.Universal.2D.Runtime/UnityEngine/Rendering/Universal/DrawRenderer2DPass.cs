namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000055")]
internal class DrawRenderer2DPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000058")]
	private sealed class <>c
	{
		[Token(Token = "0x40001F0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001F1")]
		public static BaseRenderFunc<SetGlobalPassData, RasterGraphContext> <>9__12_0; //Field offset: 0x8
		[Token(Token = "0x40001F2")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__12_1; //Field offset: 0x10

		[Address(RVA = "0x2D45580", Offset = "0x2D44980", Length = "0x67")]
		[Token(Token = "0x6000236")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000237")]
		public <>c() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000238")]
		internal void <Render>b__12_0(SetGlobalPassData data, RasterGraphContext context) { }

		[Address(RVA = "0x2D450C0", Offset = "0x2D444C0", Length = "0x64")]
		[Token(Token = "0x6000239")]
		internal void <Render>b__12_1(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000057")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001E7")]
		internal Light2DBlendStyle[] lightBlendStyles; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001E8")]
		internal Int32[] blendStyleIndices; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001E9")]
		internal float hdrEmulationScale; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40001EA")]
		internal bool isSceneLit; //Field offset: 0x24
		[FieldOffset(Offset = "0x25")]
		[Token(Token = "0x40001EB")]
		internal bool layerUseLights; //Field offset: 0x25
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001EC")]
		internal TextureHandle[] lightTextures; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001ED")]
		internal RendererListHandle rendererList; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001EE")]
		internal DebugRendererLists debugRendererLists; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001EF")]
		internal bool activeDebugHandler; //Field offset: 0x48

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000235")]
		public PassData() { }

	}

	[Token(Token = "0x2000056")]
	private class SetGlobalPassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001E6")]
		internal TextureHandle[] lightTextures; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000234")]
		public SetGlobalPassData() { }

	}

	[Token(Token = "0x40001DD")]
	private static readonly string k_RenderPass; //Field offset: 0x0
	[Token(Token = "0x40001DE")]
	private static readonly string k_SetLightBlendTexture; //Field offset: 0x8
	[Token(Token = "0x40001DF")]
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x10
	[Token(Token = "0x40001E0")]
	private static readonly ProfilingSampler m_SetLightBlendTextureProfilingSampler; //Field offset: 0x18
	[Token(Token = "0x40001E1")]
	private static readonly ShaderTagId k_CombinedRenderingPassName; //Field offset: 0x20
	[Token(Token = "0x40001E2")]
	private static readonly ShaderTagId k_LegacyPassName; //Field offset: 0x24
	[Token(Token = "0x40001E3")]
	private static readonly List<ShaderTagId> k_ShaderTags; //Field offset: 0x28
	[Token(Token = "0x40001E4")]
	private static readonly int k_HDREmulationScaleID; //Field offset: 0x30
	[Token(Token = "0x40001E5")]
	private static readonly int k_RendererColorID; //Field offset: 0x34

	[Address(RVA = "0x2D33AA0", Offset = "0x2D32EA0", Length = "0x387")]
	[Token(Token = "0x6000233")]
	private static DrawRenderer2DPass() { }

	[Address(RVA = "0x2D203D0", Offset = "0x2D1F7D0", Length = "0x7")]
	[Token(Token = "0x6000232")]
	public DrawRenderer2DPass() { }

	[Address(RVA = "0x2D31F30", Offset = "0x2D31330", Length = "0x26C")]
	[Token(Token = "0x600022F")]
	private static void Execute(RasterGraphContext context, PassData passData) { }

	[Address(RVA = "0x2D321A0", Offset = "0x2D315A0", Length = "0x1589")]
	[Token(Token = "0x6000230")]
	public void Render(RenderGraph graph, ContextContainer frameData, Renderer2DData rendererData, ref LayerBatch[] layerBatches, int batchIndex, ref FilteringSettings filterSettings) { }

	[Address(RVA = "0x2D33730", Offset = "0x2D32B30", Length = "0x362")]
	[Token(Token = "0x6000231")]
	private void SetGlobalLightTextures(RenderGraph graph, IRasterRenderGraphBuilder builder, TextureHandle[] lightTextures, ref LayerBatch layerBatch, Renderer2DData rendererData, bool isLitView) { }

}

