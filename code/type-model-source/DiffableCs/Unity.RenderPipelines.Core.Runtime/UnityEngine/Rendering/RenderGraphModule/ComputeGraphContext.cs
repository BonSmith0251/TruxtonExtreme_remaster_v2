namespace UnityEngine.Rendering.RenderGraphModule;

[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x200026F")]
public class ComputeGraphContext : IDerivedRendergraphContext
{
	[Token(Token = "0x4000AFE")]
	internal static ComputeCommandBuffer computecmd; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AFC")]
	private InternalRenderGraphContext wrappedContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000AFD")]
	public ComputeCommandBuffer cmd; //Field offset: 0x18

	[Token(Token = "0x1700022D")]
	public RenderGraphDefaultResources defaultResources
	{
		[Address(RVA = "0x5C1240", Offset = "0x5C0640", Length = "0x1B")]
		[Token(Token = "0x6001120")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700022E")]
	public RenderGraphObjectPool renderGraphPool
	{
		[Address(RVA = "0x2C6F490", Offset = "0x2C6E890", Length = "0x1B")]
		[Token(Token = "0x6001121")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x2C6F400", Offset = "0x2C6E800", Length = "0x82")]
	[Token(Token = "0x6001125")]
	private static ComputeGraphContext() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001124")]
	public ComputeGraphContext() { }

	[Address(RVA = "0x2C6F2C0", Offset = "0x2C6E6C0", Length = "0xDD")]
	[Token(Token = "0x6001122")]
	public override void FromInternalContext(InternalRenderGraphContext context) { }

	[Address(RVA = "0x5C1240", Offset = "0x5C0640", Length = "0x1B")]
	[Token(Token = "0x6001120")]
	public RenderGraphDefaultResources get_defaultResources() { }

	[Address(RVA = "0x2C6F490", Offset = "0x2C6E890", Length = "0x1B")]
	[Token(Token = "0x6001121")]
	public RenderGraphObjectPool get_renderGraphPool() { }

	[Address(RVA = "0x2C6F3A0", Offset = "0x2C6E7A0", Length = "0x56")]
	[Token(Token = "0x6001123")]
	public TextureUVOrigin GetTextureUVOrigin(in TextureHandle textureHandle) { }

	[Address(RVA = "0x2C6F3A0", Offset = "0x2C6E7A0", Length = "0x56")]
	[Token(Token = "0x6001126")]
	private override TextureUVOrigin UnityEngine.Rendering.RenderGraphModule.IDerivedRendergraphContext.GetTextureUVOrigin(in TextureHandle textureHandle) { }

}

