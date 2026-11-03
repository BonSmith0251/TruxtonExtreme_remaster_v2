namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000063")]
internal class UpscalePass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000065")]
	private sealed class <>c
	{
		[Token(Token = "0x4000233")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000234")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__11_0; //Field offset: 0x8

		[Address(RVA = "0x2D45660", Offset = "0x2D44A60", Length = "0x67")]
		[Token(Token = "0x6000273")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000274")]
		public <>c() { }

		[Address(RVA = "0x2D45010", Offset = "0x2D44410", Length = "0xA8")]
		[Token(Token = "0x6000275")]
		internal void <Render>b__11_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000064")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000232")]
		internal TextureHandle source; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000272")]
		public PassData() { }

	}

	[Token(Token = "0x400022C")]
	private static readonly string k_UpscalePass; //Field offset: 0x0
	[Token(Token = "0x400022D")]
	private static readonly ProfilingSampler m_ProfilingSampler; //Field offset: 0x8
	[Token(Token = "0x400022E")]
	private static readonly ProfilingSampler m_ExecuteProfilingSampler; //Field offset: 0x10
	[Token(Token = "0x400022F")]
	private static Material m_BlitMaterial; //Field offset: 0x18
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000230")]
	private RTHandle source; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000231")]
	private RTHandle destination; //Field offset: 0x68

	[Address(RVA = "0x2D45FF0", Offset = "0x2D453F0", Length = "0x12D")]
	[Token(Token = "0x6000271")]
	private static UpscalePass() { }

	[Address(RVA = "0x2D46120", Offset = "0x2D45520", Length = "0x1D6B")]
	[Token(Token = "0x600026C")]
	public UpscalePass(RenderPassEvent evt, Material blitMaterial) { }

	[Address(RVA = "0x2D457B0", Offset = "0x2D44BB0", Length = "0x11")]
	[Token(Token = "0x600026E")]
	public void Dispose() { }

	[Address(RVA = "0x2D457D0", Offset = "0x2D44BD0", Length = "0x237")]
	[Token(Token = "0x600026F")]
	private static void ExecutePass(RasterCommandBuffer cmd, RTHandle source) { }

	[Address(RVA = "0x2D45A10", Offset = "0x2D44E10", Length = "0x4A0")]
	[Token(Token = "0x6000270")]
	public void Render(RenderGraph graph, Camera camera, in TextureHandle cameraColorAttachment, in TextureHandle upscaleHandle) { }

	[Address(RVA = "0x2D45EC0", Offset = "0x2D452C0", Length = "0x129")]
	[Token(Token = "0x600026D")]
	public void Setup(RTHandle colorTargetHandle, int width, int height, FilterMode mode, RenderTextureDescriptor cameraTargetDescriptor, out RTHandle upscaleHandle) { }

}

