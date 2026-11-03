namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x200008B")]
internal struct NativeBitArrayDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003AF")]
	public UnsafeBitArray* m_BitArrayData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003B0")]
	public AllocatorHandle m_Allocator; //Field offset: 0x8

	[Address(RVA = "0x28C80C0", Offset = "0x28C74C0", Length = "0x9E")]
	[Token(Token = "0x600071C")]
	public void Dispose() { }

}

