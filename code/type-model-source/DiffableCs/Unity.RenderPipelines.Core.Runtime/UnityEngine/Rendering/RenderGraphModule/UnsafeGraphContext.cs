namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x2000270")]
public class UnsafeGraphContext : IDerivedRendergraphContext
{
	[Token(Token = "0x4000B01")]
	internal static UnsafeCommandBuffer unsCmd; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AFF")]
	private InternalRenderGraphContext wrappedContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B00")]
	public UnsafeCommandBuffer cmd; //Field offset: 0x18

	[Token(Token = "0x1700022F")]
	public RenderGraphDefaultResources defaultResources
	{
		[Address(RVA = "0x5C1240", Offset = "0x5C0640", Length = "0x1B")]
		[Token(Token = "0x6001127")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000230")]
	public RenderGraphObjectPool renderGraphPool
	{
		[Address(RVA = "0x2C6F490", Offset = "0x2C6E890", Length = "0x1B")]
		[Token(Token = "0x6001128")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x2C88BD0", Offset = "0x2C87FD0", Length = "0x82")]
	[Token(Token = "0x600112C")]
	private static UnsafeGraphContext() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600112B")]
	public UnsafeGraphContext() { }

	[Address(RVA = "0x2C88AF0", Offset = "0x2C87EF0", Length = "0xDD")]
	[Token(Token = "0x6001129")]
	public override void FromInternalContext(InternalRenderGraphContext context) { }

	[Address(RVA = "0x5C1240", Offset = "0x5C0640", Length = "0x1B")]
	[Token(Token = "0x6001127")]
	public RenderGraphDefaultResources get_defaultResources() { }

	[Address(RVA = "0x2C6F490", Offset = "0x2C6E890", Length = "0x1B")]
	[Token(Token = "0x6001128")]
	public RenderGraphObjectPool get_renderGraphPool() { }

	[Address(RVA = "0x2C6F3A0", Offset = "0x2C6E7A0", Length = "0x56")]
	[Token(Token = "0x600112A")]
	public TextureUVOrigin GetTextureUVOrigin(in TextureHandle textureHandle) { }

	[Address(RVA = "0x2C6F3A0", Offset = "0x2C6E7A0", Length = "0x56")]
	[Token(Token = "0x600112D")]
	private override TextureUVOrigin UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext.GetTextureUVOrigin(in TextureHandle textureHandle) { }

}

