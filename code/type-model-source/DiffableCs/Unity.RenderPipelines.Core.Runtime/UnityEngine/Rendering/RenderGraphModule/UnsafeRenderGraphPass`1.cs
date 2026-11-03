namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
[Token(Token = "0x2000281")]
internal sealed class UnsafeRenderGraphPass : BaseRenderGraphPass<PassData, UnsafeGraphContext>
{
	[Token(Token = "0x4000B4D")]
	internal static UnsafeGraphContext c; //Field offset: 0x0

	[Address(RVA = "0x11DF6B0", Offset = "0x11DEAB0", Length = "0xC7")]
	[Token(Token = "0x6001212")]
	private static UnsafeRenderGraphPass`1() { }

	[Address(RVA = "0xE9A8B0", Offset = "0xE99CB0", Length = "0x14")]
	[Token(Token = "0x6001211")]
	public UnsafeRenderGraphPass`1() { }

	[Address(RVA = "0x11DF5C0", Offset = "0x11DE9C0", Length = "0xE6")]
	[Token(Token = "0x600120F")]
	public virtual void Execute(InternalRenderGraphContext renderGraphContext) { }

	[Address(RVA = "0xE9A810", Offset = "0xE99C10", Length = "0x9B")]
	[Token(Token = "0x6001210")]
	public virtual void Release(RenderGraphObjectPool pool) { }

}

