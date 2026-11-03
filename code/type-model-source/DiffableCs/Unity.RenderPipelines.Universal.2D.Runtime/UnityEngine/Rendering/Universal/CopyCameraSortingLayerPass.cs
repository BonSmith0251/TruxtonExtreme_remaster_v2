namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200004C")]
internal class CopyCameraSortingLayerPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200004E")]
	private sealed class <>c
	{
		[Token(Token = "0x40001C1")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001C2")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__10_0; //Field offset: 0x8

		[Address(RVA = "0x2D2FEA0", Offset = "0x2D2F2A0", Length = "0x67")]
		[Token(Token = "0x6000218")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000219")]
		public <>c() { }

		[Address(RVA = "0x2D2FB80", Offset = "0x2D2EF80", Length = "0xA8")]
		[Token(Token = "0x600021A")]
		internal void <Render>b__10_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x200004D")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001C0")]
		internal TextureHandle source; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000217")]
		public PassData() { }

	}

	[Token(Token = "0x40001BA")]
	private static readonly string k_CopyCameraSortingLayerPass; //Field offset: 0x0
	[Token(Token = "0x40001BB")]
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x8
	[Token(Token = "0x40001BC")]
	private static readonly ProfilingSampler m_ExecuteProfilingSampler; //Field offset: 0x10
	[Token(Token = "0x40001BD")]
	internal static readonly string k_CameraSortingLayerTexture; //Field offset: 0x18
	[Token(Token = "0x40001BE")]
	internal static readonly int k_CameraSortingLayerTextureId; //Field offset: 0x20
	[Token(Token = "0x40001BF")]
	private static Material m_BlitMaterial; //Field offset: 0x28

	[Address(RVA = "0x2D1D950", Offset = "0x2D1CD50", Length = "0x19B")]
	[Token(Token = "0x6000216")]
	private static CopyCameraSortingLayerPass() { }

	[Address(RVA = "0x2D1DAF0", Offset = "0x2D1CEF0", Length = "0x84")]
	[Token(Token = "0x6000212")]
	public CopyCameraSortingLayerPass(Material blitMaterial) { }

	[Address(RVA = "0x2D1D210", Offset = "0x2D1C610", Length = "0x6A")]
	[Token(Token = "0x6000213")]
	public static void ConfigureDescriptor(Downsampling downsamplingMethod, ref RenderTextureDescriptor descriptor, out FilterMode filterMode) { }

	[Address(RVA = "0x2D1D280", Offset = "0x2D1C680", Length = "0x237")]
	[Token(Token = "0x6000214")]
	private static void Execute(RasterCommandBuffer cmd, RTHandle source) { }

	[Address(RVA = "0x2D1D4C0", Offset = "0x2D1C8C0", Length = "0x48E")]
	[Token(Token = "0x6000215")]
	public void Render(RenderGraph graph, ContextContainer frameData) { }

}

