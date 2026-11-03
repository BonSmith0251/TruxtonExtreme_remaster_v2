namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000121")]
internal class CapturePass : ScriptableRenderPass
{
	[CompilerGenerated]
	[Token(Token = "0x2000123")]
	private sealed class <>c
	{
		[Token(Token = "0x4000651")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000652")]
		public static BaseRenderFunc<UnsafePassData, UnsafeGraphContext> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x2DC8C90", Offset = "0x2DC8090", Length = "0x67")]
		[Token(Token = "0x600070A")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600070B")]
		public <>c() { }

		[Address(RVA = "0x2DC7FA0", Offset = "0x2DC73A0", Length = "0x277")]
		[Token(Token = "0x600070C")]
		internal void <RecordRenderGraph>b__2_0(UnsafePassData data, UnsafeGraphContext unsafeContext) { }

	}

	[Token(Token = "0x2000122")]
	private class UnsafePassData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400064F")]
		internal TextureHandle source; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000650")]
		public IEnumerator<Action`2<RenderTargetIdentifier, CommandBuffer>> captureActions; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000709")]
		public UnsafePassData() { }

	}


	[Address(RVA = "0x2DA91D0", Offset = "0x2DA85D0", Length = "0x88")]
	[Token(Token = "0x6000707")]
	public CapturePass(RenderPassEvent evt) { }

	[Address(RVA = "0x2DA8D90", Offset = "0x2DA8190", Length = "0x43C")]
	[Token(Token = "0x6000708")]
	public virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData) { }

}

