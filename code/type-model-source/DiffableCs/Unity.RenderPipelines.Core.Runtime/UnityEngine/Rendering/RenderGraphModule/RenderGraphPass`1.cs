namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
[Obsolete("RenderGraphPass is deprecated, use RasterRenderGraphPass/ComputeRenderGraphPass/UnsafeRenderGraphPass instead.")]
[Token(Token = "0x200027E")]
internal sealed class RenderGraphPass : BaseRenderGraphPass<PassData, RenderGraphContext>
{
	[Token(Token = "0x4000B4A")]
	internal static RenderGraphContext c; //Field offset: 0x0

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001206")]
	private static RenderGraphPass`1() { }

	[Address(RVA = "0xE9A8B0", Offset = "0xE99CB0", Length = "0x14")]
	[Token(Token = "0x6001205")]
	public RenderGraphPass`1() { }

	[Address(RVA = "0xF4F6B0", Offset = "0xF4EAB0", Length = "0xDE")]
	[Token(Token = "0x6001203")]
	public virtual void Execute(InternalRenderGraphContext renderGraphContext) { }

	[Address(RVA = "0xE9A810", Offset = "0xE99C10", Length = "0x9B")]
	[Token(Token = "0x6001204")]
	public virtual void Release(RenderGraphObjectPool pool) { }

}

