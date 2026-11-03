namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
[Token(Token = "0x200029C")]
internal abstract class RenderGraphResource : IRenderGraphResource
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BA7")]
	public DescType desc; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BA8")]
	public bool validDesc; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BA9")]
	public ResType graphicsResource; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BAA")]
	protected RenderGraphResourcePool<ResType> m_Pool; //Field offset: 0x0

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60012D5")]
	protected RenderGraphResource`2() { }

	[Address(RVA = "0xF519D0", Offset = "0xF50DD0", Length = "0x12C")]
	[Token(Token = "0x60012D9")]
	public virtual void CreatePooledGraphicsResource(bool forceResourceCreation) { }

	[Address(RVA = "0xF51B40", Offset = "0xF50F40", Length = "0x9")]
	[Token(Token = "0x60012D7")]
	public virtual bool IsCreated() { }

	[Address(RVA = "0xF51B70", Offset = "0xF50F70", Length = "0x7")]
	[Token(Token = "0x60012D8")]
	public virtual void ReleaseGraphicsResource() { }

	[Address(RVA = "0xF51F60", Offset = "0xF51360", Length = "0xE6")]
	[Token(Token = "0x60012DA")]
	public virtual void ReleasePooledGraphicsResource(int frameIndex) { }

	[Address(RVA = "0xF52440", Offset = "0xF51840", Length = "0x136")]
	[Token(Token = "0x60012D6")]
	public virtual void Reset(IRenderGraphResourcePool pool = null) { }

}

