namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x200028A")]
internal class BufferPool : RenderGraphResourcePool<GraphicsBuffer>
{

	[Address(RVA = "0x2C8D6E0", Offset = "0x2C8CAE0", Length = "0x5A")]
	[Token(Token = "0x6001230")]
	public BufferPool() { }

	[Address(RVA = "0x2C8D610", Offset = "0x2C8CA10", Length = "0x2C")]
	[Token(Token = "0x600122C")]
	protected virtual string GetResourceName(in GraphicsBuffer res) { }

	[Address(RVA = "0x2C8D640", Offset = "0x2C8CA40", Length = "0x42")]
	[Token(Token = "0x600122D")]
	protected virtual long GetResourceSize(in GraphicsBuffer res) { }

	[Address(RVA = "0x2C8D690", Offset = "0x2C8CA90", Length = "0x2C")]
	[Token(Token = "0x600122E")]
	protected virtual string GetResourceTypeName() { }

	[Address(RVA = "0x2696920", Offset = "0x2695D20", Length = "0x2C")]
	[Token(Token = "0x600122F")]
	protected virtual int GetSortIndex(GraphicsBuffer res) { }

	[Address(RVA = "0x2C8D6C0", Offset = "0x2C8CAC0", Length = "0x1F")]
	[Token(Token = "0x600122B")]
	protected virtual void ReleaseInternalResource(GraphicsBuffer res) { }

}

