namespace UnityEngine.Rendering.RenderGraphModule;

[DebuggerDisplay("Texture ({handle.index})")]
[IsReadOnly]
[MovedFrom(True, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
[Token(Token = "0x20002A0")]
public struct TextureHandle
{
	[Token(Token = "0x4000BB6")]
	private static TextureHandle s_NullHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BB7")]
	internal readonly ResourceHandle handle; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000BB8")]
	private readonly bool builtin; //Field offset: 0xC

	[Token(Token = "0x1700025C")]
	public static TextureHandle nullHandle
	{
		[Address(RVA = "0x2CAB570", Offset = "0x2CAA970", Length = "0x5A")]
		[Token(Token = "0x60012DD")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60012E7")]
	private static TextureHandle() { }

	[Address(RVA = "0x2CAB470", Offset = "0x2CAA870", Length = "0x13")]
	[Token(Token = "0x60012DE")]
	internal TextureHandle(in ResourceHandle h) { }

	[Address(RVA = "0x2CAB490", Offset = "0x2CAA890", Length = "0xD1")]
	[Token(Token = "0x60012DF")]
	internal TextureHandle(int handle, bool shared = false, bool builtin = false) { }

	[Address(RVA = "0x2CAB570", Offset = "0x2CAA970", Length = "0x5A")]
	[Token(Token = "0x60012DD")]
	public static TextureHandle get_nullHandle() { }

	[Address(RVA = "0x2CAB3A0", Offset = "0x2CAA7A0", Length = "0x76")]
	[Token(Token = "0x60012E6")]
	public TextureDesc GetDescriptor(RenderGraph renderGraph) { }

	[Address(RVA = "0x293B900", Offset = "0x293AD00", Length = "0x5")]
	[Token(Token = "0x60012E5")]
	internal bool IsBuiltin() { }

	[Address(RVA = "0x2CAB420", Offset = "0x2CAA820", Length = "0x49")]
	[Token(Token = "0x60012E4")]
	public bool IsValid() { }

	[Address(RVA = "0x2CAB910", Offset = "0x2CAAD10", Length = "0x15C")]
	[Token(Token = "0x60012E0")]
	public static RenderTargetIdentifier op_Implicit(TextureHandle texture) { }

	[Address(RVA = "0x2CAB7F0", Offset = "0x2CAABF0", Length = "0x110")]
	[Token(Token = "0x60012E1")]
	public static Texture op_Implicit(TextureHandle texture) { }

	[Address(RVA = "0x2CAB5D0", Offset = "0x2CAA9D0", Length = "0x110")]
	[Token(Token = "0x60012E2")]
	public static RenderTexture op_Implicit(TextureHandle texture) { }

	[Address(RVA = "0x2CAB6F0", Offset = "0x2CAAAF0", Length = "0xFF")]
	[Token(Token = "0x60012E3")]
	public static RTHandle op_Implicit(TextureHandle texture) { }

}

