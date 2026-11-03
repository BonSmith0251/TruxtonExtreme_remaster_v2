namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DebuggerDisplay("PassRandomWriteData: Res({resource.index}):{index}:{preserveCounterValue}")]
[IsReadOnly]
[Token(Token = "0x20002BC")]
internal struct PassRandomWriteData
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C71")]
	public readonly ResourceHandle resource; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000C72")]
	public readonly int index; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C73")]
	public readonly bool preserveCounterValue; //Field offset: 0x10

	[Address(RVA = "0x2CBDF50", Offset = "0x2CBD350", Length = "0x17")]
	[Token(Token = "0x6001381")]
	public PassRandomWriteData(in ResourceHandle resource, int index, bool preserveCounterValue) { }

	[Address(RVA = "0x2CBDED0", Offset = "0x2CBD2D0", Length = "0x78")]
	[Token(Token = "0x6001382")]
	public virtual int GetHashCode() { }

}

