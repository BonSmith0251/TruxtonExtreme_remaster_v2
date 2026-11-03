namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200014D")]
internal class ProbeVolumeDebugPass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x200014F")]
	private sealed class <>c
	{
		[Token(Token = "0x4000794")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000795")]
		public static BaseRenderFunc<WriteApvData, ComputeGraphContext> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x2DE5290", Offset = "0x2DE4690", Length = "0x67")]
		[Token(Token = "0x60007B0")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007B1")]
		public <>c() { }

		[Address(RVA = "0x2DE45E0", Offset = "0x2DE39E0", Length = "0x23B")]
		[Token(Token = "0x60007B2")]
		internal void <Render>b__3_0(WriteApvData data, ComputeGraphContext ctx) { }

	}

	[Token(Token = "0x200014E")]
	private class WriteApvData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400078F")]
		public ComputeShader computeShader; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000790")]
		public BufferHandle resultBuffer; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000791")]
		public Vector2 clickCoordinates; //Field offset: 0x24
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000792")]
		public TextureHandle depthBuffer; //Field offset: 0x2C
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000793")]
		public TextureHandle normalBuffer; //Field offset: 0x3C

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60007AF")]
		public WriteApvData() { }

	}

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400078E")]
	private ComputeShader m_ComputeShader; //Field offset: 0x60

	[Address(RVA = "0x2DCCAE0", Offset = "0x2DCBEE0", Length = "0xA4")]
	[Token(Token = "0x60007AD")]
	public ProbeVolumeDebugPass(RenderPassEvent evt, ComputeShader computeShader) { }

	[Address(RVA = "0x2DCC4F0", Offset = "0x2DCB8F0", Length = "0x5EC")]
	[Token(Token = "0x60007AE")]
	internal void Render(RenderGraph renderGraph, ContextContainer frameData, TextureHandle depthPyramidBuffer, TextureHandle normalBuffer) { }

}

