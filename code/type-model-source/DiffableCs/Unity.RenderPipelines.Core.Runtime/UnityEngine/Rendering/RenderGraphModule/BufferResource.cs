namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("BufferResource ({desc.name})")]
[Token(Token = "0x2000289")]
internal class BufferResource : RenderGraphResource<BufferDesc, GraphicsBuffer>
{

	[Address(RVA = "0x2C8DA30", Offset = "0x2C8CE30", Length = "0x39")]
	[Token(Token = "0x600122A")]
	public BufferResource() { }

	[Address(RVA = "0x2C8D740", Offset = "0x2C8CB40", Length = "0xB2")]
	[Token(Token = "0x6001225")]
	public virtual void CreateGraphicsResource() { }

	[Address(RVA = "0x2C8D800", Offset = "0x2C8CC00", Length = "0x3A")]
	[Token(Token = "0x6001224")]
	public virtual int GetDescHashCode() { }

	[Address(RVA = "0x2C8D840", Offset = "0x2C8CC40", Length = "0x42")]
	[Token(Token = "0x6001223")]
	public virtual string GetName() { }

	[Address(RVA = "0x2C8D890", Offset = "0x2C8CC90", Length = "0x7F")]
	[Token(Token = "0x6001228")]
	public virtual void LogCreation(RenderGraphLogger logger) { }

	[Address(RVA = "0x2C8D910", Offset = "0x2C8CD10", Length = "0x7F")]
	[Token(Token = "0x6001229")]
	public virtual void LogRelease(RenderGraphLogger logger) { }

	[Address(RVA = "0x2C8D990", Offset = "0x2C8CD90", Length = "0x43")]
	[Token(Token = "0x6001227")]
	public virtual void ReleaseGraphicsResource() { }

	[Address(RVA = "0x2C8D9E0", Offset = "0x2C8CDE0", Length = "0x48")]
	[Token(Token = "0x6001226")]
	public virtual void UpdateGraphicsResource() { }

}

