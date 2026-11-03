namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000BE")]
public class XROcclusionMeshPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x20000C0")]
	private sealed class <>c__DisplayClass5_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000425")]
		public PassData passData; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600049C")]
		public <>c__DisplayClass5_0() { }

		[Address(RVA = "0x2D92780", Offset = "0x2D91B80", Length = "0xF3")]
		[Token(Token = "0x600049D")]
		internal void <Render>b__0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x20000BF")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000421")]
		internal XRPass xr; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000422")]
		internal bool isActiveTargetBackBuffer; //Field offset: 0x18
		[FieldOffset(Offset = "0x19")]
		[Token(Token = "0x4000423")]
		internal bool shouldYFlip; //Field offset: 0x19
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000424")]
		internal TextureHandle cameraColorAttachment; //Field offset: 0x1C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600049B")]
		public PassData() { }

	}

	[FieldOffset(Offset = "0x60")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x4000420")]
	public bool m_IsActiveTargetBackBuffer; //Field offset: 0x60

	[Address(RVA = "0x2DA6100", Offset = "0x2DA5500", Length = "0x934")]
	[Token(Token = "0x6000498")]
	public XROcclusionMeshPass(RenderPassEvent evt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Obsolete("This rendering path is for Compatibility Mode only which has been deprecated and hidden behind URP_COMPATIBILITY_MODE define. This will do nothing.")]
	[Token(Token = "0x6000497")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[Address(RVA = "0x2DA5A70", Offset = "0x2DA4E70", Length = "0x8E")]
	[Token(Token = "0x6000499")]
	private static void ExecutePass(RasterCommandBuffer cmd, PassData data) { }

	[Address(RVA = "0x2DA5B00", Offset = "0x2DA4F00", Length = "0x5F3")]
	[Token(Token = "0x600049A")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle cameraColorAttachment, in TextureHandle cameraDepthAttachment) { }

}

