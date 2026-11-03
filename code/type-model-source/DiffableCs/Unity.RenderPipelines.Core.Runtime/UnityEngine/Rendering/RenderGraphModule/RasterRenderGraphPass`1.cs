namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
[Token(Token = "0x2000280")]
internal sealed class RasterRenderGraphPass : BaseRenderGraphPass<PassData, RasterGraphContext>
{
	[Token(Token = "0x4000B4C")]
	internal static RasterGraphContext c; //Field offset: 0x0

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600120E")]
	private static RasterRenderGraphPass`1() { }

	[Address(RVA = "0xE9A8B0", Offset = "0xE99CB0", Length = "0x14")]
	[Token(Token = "0x600120D")]
	public RasterRenderGraphPass`1() { }

	[Address(RVA = "0xE9A6F0", Offset = "0xE99AF0", Length = "0x119")]
	[Token(Token = "0x600120B")]
	public virtual void Execute(InternalRenderGraphContext renderGraphContext) { }

	[Address(RVA = "0xE9A810", Offset = "0xE99C10", Length = "0x9B")]
	[Token(Token = "0x600120C")]
	public virtual void Release(RenderGraphObjectPool pool) { }

}

