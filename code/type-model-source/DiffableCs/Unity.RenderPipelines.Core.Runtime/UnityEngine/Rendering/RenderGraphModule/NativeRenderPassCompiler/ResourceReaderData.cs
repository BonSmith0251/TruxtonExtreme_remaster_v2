namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[IsReadOnly]
[Token(Token = "0x20002C7")]
internal struct ResourceReaderData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CED")]
	public readonly int passId; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000CEE")]
	public readonly int inputSlot; //Field offset: 0x4

	[Address(RVA = "0xAEE4E0", Offset = "0xAED8E0", Length = "0x7")]
	[Token(Token = "0x60013AF")]
	public ResourceReaderData(int _passId, int _inputSlot) { }

}

