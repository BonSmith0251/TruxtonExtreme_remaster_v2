namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[Token(Token = "0x20002C9")]
internal struct ResourceVersionedData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000D00")]
	public bool written; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000D01")]
	public int writePassId; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000D02")]
	public int numReaders; //Field offset: 0x8

	[Address(RVA = "0x2CBE0C0", Offset = "0x2CBD4C0", Length = "0x133")]
	[Token(Token = "0x60013B6")]
	public void RegisterReadingPass(CompilerContextData ctx, in ResourceHandle h, int passId, int index) { }

	[Address(RVA = "0x2CBE200", Offset = "0x2CBD600", Length = "0x2D0")]
	[Token(Token = "0x60013B7")]
	public void RemoveReadingPass(CompilerContextData ctx, in ResourceHandle h, int passId) { }

	[Address(RVA = "0x2CBE4E0", Offset = "0x2CBD8E0", Length = "0x8")]
	[Token(Token = "0x60013B5")]
	public void SetWritingPass(CompilerContextData ctx, in ResourceHandle h, int passId) { }

}

