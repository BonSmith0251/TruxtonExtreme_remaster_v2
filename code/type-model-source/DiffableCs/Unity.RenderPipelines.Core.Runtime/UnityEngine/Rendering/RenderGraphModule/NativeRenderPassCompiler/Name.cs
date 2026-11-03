namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[IsReadOnly]
[Token(Token = "0x20002B0")]
internal struct Name
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C2B")]
	public readonly string name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C2C")]
	public readonly int utf8ByteCount; //Field offset: 0x8

	[Address(RVA = "0x2C8F460", Offset = "0x2C8E860", Length = "0xD3")]
	[Token(Token = "0x6001326")]
	public Name(string name, bool computeUTF8ByteCount = false) { }

}

