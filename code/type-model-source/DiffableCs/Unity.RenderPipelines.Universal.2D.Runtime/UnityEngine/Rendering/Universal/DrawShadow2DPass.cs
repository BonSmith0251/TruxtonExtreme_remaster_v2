namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000059")]
internal class DrawShadow2DPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200005B")]
	private sealed class <>c
	{
		[Token(Token = "0x40001FB")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001FC")]
		public static BaseRenderFunc<PassData, UnsafeGraphContext> <>9__6_0; //Field offset: 0x8

		[Address(RVA = "0x2D456D0", Offset = "0x2D44AD0", Length = "0x67")]
		[Token(Token = "0x600023F")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000240")]
		public <>c() { }

		[Address(RVA = "0x2D45130", Offset = "0x2D44530", Length = "0x30E")]
		[Token(Token = "0x6000241")]
		internal void <Render>b__6_0(PassData data, UnsafeGraphContext context) { }

	}

	[Token(Token = "0x200005A")]
	public class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001F7")]
		internal LayerBatch layerBatch; //Field offset: 0x10
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40001F8")]
		internal Renderer2DData rendererData; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40001F9")]
		internal TextureHandle[] shadowTextures; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40001FA")]
		internal TextureHandle shadowDepth; //Field offset: 0x70

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600023E")]
		public PassData() { }

	}

	[Token(Token = "0x40001F3")]
	private static readonly string k_ShadowPass; //Field offset: 0x0
	[Token(Token = "0x40001F4")]
	private static readonly string k_ShadowVolumetricPass; //Field offset: 0x8
	[Token(Token = "0x40001F5")]
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x10
	[Token(Token = "0x40001F6")]
	private static readonly ProfilingSampler m_ProfilingSamplerVolume; //Field offset: 0x18

	[Address(RVA = "0x2D34630", Offset = "0x2D33A30", Length = "0x172")]
	[Token(Token = "0x600023D")]
	private static DrawShadow2DPass() { }

	[Address(RVA = "0x2D203D0", Offset = "0x2D1F7D0", Length = "0x7")]
	[Token(Token = "0x600023C")]
	public DrawShadow2DPass() { }

	[Address(RVA = "0x2D33E30", Offset = "0x2D33230", Length = "0x21B")]
	[Token(Token = "0x600023A")]
	private static void ExecuteShadowPass(UnsafeCommandBuffer cmd, PassData passData, Light2D light, int batchIndex) { }

	[Address(RVA = "0x2D34050", Offset = "0x2D33450", Length = "0x5DC")]
	[Token(Token = "0x600023B")]
	public void Render(RenderGraph graph, ContextContainer frameData, Renderer2DData rendererData, ref LayerBatch layerBatch, int batchIndex, bool isVolumetric = false) { }

}

