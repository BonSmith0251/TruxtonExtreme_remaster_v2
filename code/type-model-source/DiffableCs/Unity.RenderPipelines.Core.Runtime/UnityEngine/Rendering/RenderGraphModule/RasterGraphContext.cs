namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x200026E")]
public struct RasterGraphContext : IDerivedRendergraphContext
{
	[Token(Token = "0x4000AFB")]
	internal static RasterCommandBuffer rastercmd; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AF9")]
	private InternalRenderGraphContext wrappedContext; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000AFA")]
	public RasterCommandBuffer cmd; //Field offset: 0x8

	[Token(Token = "0x1700022B")]
	public RenderGraphDefaultResources defaultResources
	{
		[Address(RVA = "0x29C0A50", Offset = "0x29BFE50", Length = "0x1A")]
		[Token(Token = "0x600111A")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700022C")]
	public RenderGraphObjectPool renderGraphPool
	{
		[Address(RVA = "0x24DAB70", Offset = "0x24D9F70", Length = "0x1A")]
		[Token(Token = "0x600111B")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x2C71D50", Offset = "0x2C71150", Length = "0x82")]
	[Token(Token = "0x600111E")]
	private static RasterGraphContext() { }

	[Address(RVA = "0x2C71B80", Offset = "0x2C70F80", Length = "0xDA")]
	[Token(Token = "0x600111C")]
	public override void FromInternalContext(InternalRenderGraphContext context) { }

	[Address(RVA = "0x29C0A50", Offset = "0x29BFE50", Length = "0x1A")]
	[Token(Token = "0x600111A")]
	public RenderGraphDefaultResources get_defaultResources() { }

	[Address(RVA = "0x24DAB70", Offset = "0x24D9F70", Length = "0x1A")]
	[Token(Token = "0x600111B")]
	public RenderGraphObjectPool get_renderGraphPool() { }

	[Address(RVA = "0x2C71C60", Offset = "0x2C71060", Length = "0x55")]
	[IsReadOnly]
	[Token(Token = "0x600111D")]
	public TextureUVOrigin GetTextureUVOrigin(in TextureHandle textureHandle) { }

	[Address(RVA = "0x2C71CC0", Offset = "0x2C710C0", Length = "0x86")]
	[Token(Token = "0x600111F")]
	private override TextureUVOrigin UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext.GetTextureUVOrigin(in TextureHandle textureHandle) { }

}

