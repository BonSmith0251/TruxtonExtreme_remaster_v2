namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x2000260")]
public interface IRenderAttachmentRenderGraphBuilder : IBaseRenderGraphBuilder, IDisposable
{

	[Token(Token = "0x6001102")]
	public TextureHandle SetRandomAccessAttachment(TextureHandle tex, int index, AccessFlags flags = 3) { }

	[Address(RVA = "0x2C71860", Offset = "0x2C70C60", Length = "0x101")]
	[Token(Token = "0x60010FE")]
	public void SetRenderAttachment(TextureHandle tex, int index, AccessFlags flags = 2) { }

	[Token(Token = "0x60010FF")]
	public void SetRenderAttachment(TextureHandle tex, int index, AccessFlags flags, int mipLevel, int depthSlice) { }

	[Address(RVA = "0x2C71770", Offset = "0x2C70B70", Length = "0xE2")]
	[Token(Token = "0x6001100")]
	public void SetRenderAttachmentDepth(TextureHandle tex, AccessFlags flags = 2) { }

	[Token(Token = "0x6001101")]
	public void SetRenderAttachmentDepth(TextureHandle tex, AccessFlags flags, int mipLevel, int depthSlice) { }

	[Token(Token = "0x6001103")]
	public BufferHandle UseBufferRandomAccess(BufferHandle tex, int index, AccessFlags flags = 1) { }

	[Token(Token = "0x6001104")]
	public BufferHandle UseBufferRandomAccess(BufferHandle tex, int index, bool preserveCounterValue, AccessFlags flags = 1) { }

}

