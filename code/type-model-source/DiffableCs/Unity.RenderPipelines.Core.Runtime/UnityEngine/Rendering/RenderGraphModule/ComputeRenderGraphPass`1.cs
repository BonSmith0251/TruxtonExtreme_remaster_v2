namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
[Token(Token = "0x200027F")]
internal sealed class ComputeRenderGraphPass : BaseRenderGraphPass<PassData, ComputeGraphContext>
{
	[Token(Token = "0x4000B4B")]
	internal static ComputeGraphContext c; //Field offset: 0x0

	[Address(RVA = "0x17A5FF0", Offset = "0x17A53F0", Length = "0xC7")]
	[Token(Token = "0x600120A")]
	private static ComputeRenderGraphPass`1() { }

	[Address(RVA = "0xE9A8B0", Offset = "0xE99CB0", Length = "0x14")]
	[Token(Token = "0x6001209")]
	public ComputeRenderGraphPass`1() { }

	[Address(RVA = "0x17A5F00", Offset = "0x17A5300", Length = "0xE6")]
	[Token(Token = "0x6001207")]
	public virtual void Execute(InternalRenderGraphContext renderGraphContext) { }

	[Address(RVA = "0xE9A810", Offset = "0xE99C10", Length = "0x9B")]
	[Token(Token = "0x6001208")]
	public virtual void Release(RenderGraphObjectPool pool) { }

}

