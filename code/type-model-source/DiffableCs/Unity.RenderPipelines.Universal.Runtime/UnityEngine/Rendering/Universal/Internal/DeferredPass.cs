namespace UnityEngine.Rendering.Universal.Internal;

[Token(Token = "0x200022F")]
internal class DeferredPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000231")]
	private sealed class <>c
	{
		[Token(Token = "0x4000DAC")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000DAD")]
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x2E359C0", Offset = "0x2E34DC0", Length = "0x67")]
		[Token(Token = "0x6000C0E")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C0F")]
		public <>c() { }

		[Address(RVA = "0x2E35330", Offset = "0x2E34730", Length = "0x42")]
		[Token(Token = "0x6000C10")]
		internal void <Render>b__3_0(PassData data, RasterGraphContext context) { }

	}

	[Token(Token = "0x2000230")]
	private class PassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000DA7")]
		internal UniversalCameraData cameraData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000DA8")]
		internal UniversalLightData lightData; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000DA9")]
		internal UniversalShadowData shadowData; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000DAA")]
		internal TextureHandle[] gbuffer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000DAB")]
		internal DeferredLights deferredLights; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000C0D")]
		public PassData() { }

	}

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000DA6")]
	private DeferredLights m_DeferredLights; //Field offset: 0x60

	[Address(RVA = "0x2E22E50", Offset = "0x2E22250", Length = "0xA4")]
	[Token(Token = "0x6000C0A")]
	public DeferredPass(RenderPassEvent evt, DeferredLights deferredLights) { }

	[Address(RVA = "0x2E227A0", Offset = "0x2E21BA0", Length = "0x1E")]
	[Token(Token = "0x6000C0C")]
	public virtual void OnCameraCleanup(CommandBuffer cmd) { }

	[Address(RVA = "0x2E227C0", Offset = "0x2E21BC0", Length = "0x689")]
	[Token(Token = "0x6000C0B")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle color, TextureHandle depth, TextureHandle[] gbuffer) { }

}

