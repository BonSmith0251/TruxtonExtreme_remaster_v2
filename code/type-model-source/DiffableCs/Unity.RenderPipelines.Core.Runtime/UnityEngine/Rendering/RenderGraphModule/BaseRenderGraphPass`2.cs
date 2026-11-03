namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("RenderPass: {name} (Index:{index} Async:{enableAsyncCompute})")]
[Token(Token = "0x200027D")]
internal abstract class BaseRenderGraphPass : RenderGraphPass
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B48")]
	internal PassData data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B49")]
	internal BaseRenderFunc<PassData, TRenderGraphContext> renderFunc; //Field offset: 0x0

	[Address(RVA = "0x169FB40", Offset = "0x169EF40", Length = "0x7")]
	[Token(Token = "0x6001202")]
	protected BaseRenderGraphPass`2() { }

	[Address(RVA = "0x169F960", Offset = "0x169ED60", Length = "0x62")]
	[Token(Token = "0x6001201")]
	public virtual int GetRenderFuncHash() { }

	[Address(RVA = "0x169FA40", Offset = "0x169EE40", Length = "0xC")]
	[Token(Token = "0x6001200")]
	public virtual bool HasRenderFunc() { }

	[Address(RVA = "0x169FA50", Offset = "0x169EE50", Length = "0x86")]
	[Token(Token = "0x60011FE")]
	public void Initialize(int passIndex, PassData passData, string passName, RenderGraphPassType passType, ProfilingSampler sampler) { }

	[Address(RVA = "0x169FAE0", Offset = "0x169EEE0", Length = "0x57")]
	[Token(Token = "0x60011FF")]
	public virtual void Release(RenderGraphObjectPool pool) { }

}

