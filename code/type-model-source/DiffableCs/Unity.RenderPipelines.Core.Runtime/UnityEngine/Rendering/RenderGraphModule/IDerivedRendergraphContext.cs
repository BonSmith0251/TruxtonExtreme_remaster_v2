namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x200026C")]
internal interface IDerivedRendergraphContext
{

	[Token(Token = "0x6001111")]
	public void FromInternalContext(InternalRenderGraphContext context) { }

	[Token(Token = "0x6001112")]
	public TextureUVOrigin GetTextureUVOrigin(in TextureHandle textureHandle) { }

}

