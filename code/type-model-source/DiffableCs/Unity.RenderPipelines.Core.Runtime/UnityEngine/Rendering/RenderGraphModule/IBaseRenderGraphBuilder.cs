namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x200025F")]
public interface IBaseRenderGraphBuilder : IDisposable
{

	[Token(Token = "0x60010FB")]
	public void AllowGlobalStateModification(bool value) { }

	[Token(Token = "0x60010FA")]
	public void AllowPassCulling(bool value) { }

	[Token(Token = "0x60010F6")]
	public BufferHandle CreateTransientBuffer(in BufferDesc desc) { }

	[Token(Token = "0x60010F7")]
	public BufferHandle CreateTransientBuffer(in BufferHandle computebuffer) { }

	[Token(Token = "0x60010F4")]
	public TextureHandle CreateTransientTexture(in TextureDesc desc) { }

	[Token(Token = "0x60010F5")]
	public TextureHandle CreateTransientTexture(in TextureHandle texture) { }

	[Token(Token = "0x60010F9")]
	public void EnableAsyncCompute(bool value) { }

	[Token(Token = "0x60010FC")]
	public void EnableFoveatedRasterization(bool value) { }

	[Token(Token = "0x60010FD")]
	public void GenerateDebugData(bool value) { }

	[Token(Token = "0x60010F2")]
	public void SetGlobalTextureAfterPass(in TextureHandle input, int propertyId) { }

	[Token(Token = "0x60010F1")]
	public void UseAllGlobalTextures(bool enable) { }

	[Token(Token = "0x60010F3")]
	public BufferHandle UseBuffer(in BufferHandle input, AccessFlags flags = 1) { }

	[Token(Token = "0x60010F0")]
	public void UseGlobalTexture(int propertyId, AccessFlags flags = 1) { }

	[Token(Token = "0x60010F8")]
	public void UseRendererList(in RendererListHandle input) { }

	[Token(Token = "0x60010EF")]
	public void UseTexture(in TextureHandle input, AccessFlags flags = 1) { }

}

