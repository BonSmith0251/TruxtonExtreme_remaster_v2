namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200015A")]
internal sealed class StencilCrossFadeRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200015C")]
	private sealed class <>c
	{
		[Token(Token = "0x40007FC")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40007FD")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__8_0; //Field offset: 0x8

		[Address(RVA = "0x2DE5300", Offset = "0x2DE4700", Length = "0x67")]
		[Token(Token = "0x60007C9")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007CA")]
		public <>c() { }

		[Address(RVA = "0x2DE4820", Offset = "0x2DE3C20", Length = "0x240")]
		[Token(Token = "0x60007CB")]
		internal void <Render>b__8_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x200015B")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007FA")]
		public TextureHandle depthTarget; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007FB")]
		public Material[] stencilDitherMaskSeedMaterials; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007C8")]
		public PassData() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007F5")]
	private Material[] m_StencilDitherMaskSeedMaterials; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007F6")]
	private readonly int _StencilDitherPattern; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40007F7")]
	private readonly int _StencilRefDitherMask; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007F8")]
	private readonly int _StencilWriteDitherMask; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007F9")]
	private readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x28

	[Address(RVA = "0x2DDE100", Offset = "0x2DDD500", Length = "0x2E6")]
	[Token(Token = "0x60007C4")]
	internal StencilCrossFadeRenderPass(Shader shader) { }

	[Address(RVA = "0x2DDDAC0", Offset = "0x2DDCEC0", Length = "0xBE")]
	[Token(Token = "0x60007C5")]
	public void Dispose() { }

	[Address(RVA = "0x2DDDB80", Offset = "0x2DDCF80", Length = "0x1D9")]
	[Token(Token = "0x60007C7")]
	private static void ExecutePass(RasterCommandBuffer cmd, RTHandle depthTarget, Material[] stencilDitherMaskSeedMaterials) { }

	[Address(RVA = "0x2DDDD60", Offset = "0x2DDD160", Length = "0x394")]
	[Token(Token = "0x60007C6")]
	public void Render(RenderGraph renderGraph, ScriptableRenderContext context, TextureHandle depthTarget) { }

}

