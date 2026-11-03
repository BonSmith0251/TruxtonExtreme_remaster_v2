namespace Unity.Collections;

[NativeContainer]
[Token(Token = "0x200005C")]
internal struct NativeArrayDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000108")]
	internal Void* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000109")]
	internal Allocator m_AllocatorLabel; //Field offset: 0x8

	[Address(RVA = "0x2FE3BC0", Offset = "0x2FE2FC0", Length = "0x41")]
	[Token(Token = "0x6000123")]
	public void Dispose() { }

}

