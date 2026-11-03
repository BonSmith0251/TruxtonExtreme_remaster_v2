namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DebuggerDisplay("PassOutputData: Res({resource.index})")]
[IsReadOnly]
[Token(Token = "0x20002BA")]
internal struct PassOutputData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C6C")]
	public readonly ResourceHandle resource; //Field offset: 0x0

	[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
	[Token(Token = "0x600137D")]
	public PassOutputData(in ResourceHandle resource) { }

}

