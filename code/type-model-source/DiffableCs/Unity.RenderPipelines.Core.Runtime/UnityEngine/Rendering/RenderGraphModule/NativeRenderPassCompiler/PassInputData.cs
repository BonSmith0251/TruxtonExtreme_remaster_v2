namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DebuggerDisplay("PassInputData: Res({resource.index})")]
[IsReadOnly]
[Token(Token = "0x20002B9")]
internal struct PassInputData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C6B")]
	public readonly ResourceHandle resource; //Field offset: 0x0

	[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
	[Token(Token = "0x600137C")]
	public PassInputData(in ResourceHandle resource) { }

}

