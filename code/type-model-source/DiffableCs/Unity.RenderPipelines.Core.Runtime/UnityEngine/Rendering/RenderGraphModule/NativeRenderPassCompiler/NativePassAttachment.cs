namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DebuggerDisplay("Res({handle.index}) : {loadAction} : {storeAction} : {memoryless}")]
[IsReadOnly]
[Token(Token = "0x20002BF")]
internal struct NativePassAttachment
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CA3")]
	public readonly ResourceHandle handle; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000CA4")]
	public readonly RenderBufferLoadAction loadAction; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CA5")]
	public readonly RenderBufferStoreAction storeAction; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000CA6")]
	public readonly bool memoryless; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CA7")]
	public readonly int mipLevel; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000CA8")]
	public readonly int depthSlice; //Field offset: 0x1C

	[Address(RVA = "0x2CB9670", Offset = "0x2CB8A70", Length = "0x2D")]
	[Token(Token = "0x6001398")]
	public NativePassAttachment(in ResourceHandle handle, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, bool memoryless, int mipLevel, int depthSlice) { }

}

