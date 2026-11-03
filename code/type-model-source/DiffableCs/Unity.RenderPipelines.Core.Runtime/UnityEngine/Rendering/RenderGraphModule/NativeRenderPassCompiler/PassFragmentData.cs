namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DebuggerDisplay("PassFragmentData: Res({resource.index}):{accessFlags}")]
[IsReadOnly]
[Token(Token = "0x20002BB")]
internal struct PassFragmentData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C6D")]
	public readonly ResourceHandle resource; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000C6E")]
	public readonly AccessFlags accessFlags; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C6F")]
	public readonly int mipLevel; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C70")]
	public readonly int depthSlice; //Field offset: 0x14

	[Address(RVA = "0x2CBDEB0", Offset = "0x2CBD2B0", Length = "0x1E")]
	[Token(Token = "0x600137E")]
	public PassFragmentData(in ResourceHandle handle, AccessFlags flags, int mipLevel, int depthSlice) { }

	[Address(RVA = "0x2CBDD70", Offset = "0x2CBD170", Length = "0xB1")]
	[Token(Token = "0x600137F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2CBDE30", Offset = "0x2CBD230", Length = "0x75")]
	[Token(Token = "0x6001380")]
	public static bool SameSubResource(in PassFragmentData x, in PassFragmentData y) { }

}

