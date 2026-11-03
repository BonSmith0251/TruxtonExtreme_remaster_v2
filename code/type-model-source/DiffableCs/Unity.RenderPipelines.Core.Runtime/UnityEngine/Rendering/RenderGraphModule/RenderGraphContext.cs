namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Obsolete("RenderGraphContext is deprecated, use RasterGraphContext/ComputeGraphContext/UnsafeGraphContext instead.")]
[Token(Token = "0x200026D")]
public struct RenderGraphContext : IDerivedRendergraphContext
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AF8")]
	private InternalRenderGraphContext wrappedContext; //Field offset: 0x0

	[Token(Token = "0x17000228")]
	public CommandBuffer cmd
	{
		[Address(RVA = "0x24DAB20", Offset = "0x24D9F20", Length = "0x1A")]
		[Token(Token = "0x6001116")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700022A")]
	public RenderGraphDefaultResources defaultResources
	{
		[Address(RVA = "0x29C0A50", Offset = "0x29BFE50", Length = "0x1A")]
		[Token(Token = "0x6001118")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000227")]
	public ScriptableRenderContext renderContext
	{
		[Address(RVA = "0x1E648C0", Offset = "0x1E63CC0", Length = "0x1A")]
		[Token(Token = "0x6001115")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000229")]
	public RenderGraphObjectPool renderGraphPool
	{
		[Address(RVA = "0x24DAB70", Offset = "0x24D9F70", Length = "0x1A")]
		[Token(Token = "0x6001117")]
		 get { } //Length: 26
	}

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x6001113")]
	public override void FromInternalContext(InternalRenderGraphContext context) { }

	[Address(RVA = "0x24DAB20", Offset = "0x24D9F20", Length = "0x1A")]
	[Token(Token = "0x6001116")]
	public CommandBuffer get_cmd() { }

	[Address(RVA = "0x29C0A50", Offset = "0x29BFE50", Length = "0x1A")]
	[Token(Token = "0x6001118")]
	public RenderGraphDefaultResources get_defaultResources() { }

	[Address(RVA = "0x1E648C0", Offset = "0x1E63CC0", Length = "0x1A")]
	[Token(Token = "0x6001115")]
	public ScriptableRenderContext get_renderContext() { }

	[Address(RVA = "0x24DAB70", Offset = "0x24D9F70", Length = "0x1A")]
	[Token(Token = "0x6001117")]
	public RenderGraphObjectPool get_renderGraphPool() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[IsReadOnly]
	[Token(Token = "0x6001114")]
	public TextureUVOrigin GetTextureUVOrigin(in TextureHandle textureHandle) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6001119")]
	private override TextureUVOrigin UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext.GetTextureUVOrigin(in TextureHandle textureHandle) { }

}

