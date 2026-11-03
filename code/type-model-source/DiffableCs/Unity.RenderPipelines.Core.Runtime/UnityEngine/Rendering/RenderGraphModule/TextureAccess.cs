namespace UnityEngine.Rendering.RenderGraphModule;

[IsReadOnly]
[Token(Token = "0x200029D")]
internal struct TextureAccess
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000BAB")]
	public readonly TextureHandle textureHandle; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BAC")]
	public readonly int mipLevel; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000BAD")]
	public readonly int depthSlice; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BAE")]
	public readonly AccessFlags flags; //Field offset: 0x18

	[Address(RVA = "0x2CAAA90", Offset = "0x2CA9E90", Length = "0x16")]
	[Token(Token = "0x60012DB")]
	public TextureAccess(in TextureHandle handle, AccessFlags flags, int mipLevel, int depthSlice) { }

	[Address(RVA = "0x2CAAAB0", Offset = "0x2CA9EB0", Length = "0x1A")]
	[Token(Token = "0x60012DC")]
	public TextureAccess(in TextureAccess access, in TextureHandle handle) { }

}

