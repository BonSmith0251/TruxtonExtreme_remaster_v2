namespace UnityEngine.Rendering;

[Token(Token = "0x20000B3")]
internal struct IndirectBufferContextHandles
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000354")]
	public BufferHandle instanceBuffer; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000355")]
	public BufferHandle instanceInfoBuffer; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000356")]
	public BufferHandle dispatchArgsBuffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000357")]
	public BufferHandle drawArgsBuffer; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000358")]
	public BufferHandle drawInfoBuffer; //Field offset: 0x30

	[Address(RVA = "0x2CF40D0", Offset = "0x2CF34D0", Length = "0x15D")]
	[Token(Token = "0x6000310")]
	public void UseForOcclusionTest(IBaseRenderGraphBuilder builder) { }

}

