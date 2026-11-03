namespace Unity.Collections;

[NativeContainer]
[Token(Token = "0x20000BD")]
internal struct NativeReferenceDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003E7")]
	internal Void* m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003E8")]
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x8

	[Address(RVA = "0x28C89F0", Offset = "0x28C7DF0", Length = "0xE5")]
	[Token(Token = "0x60008EF")]
	public void Dispose() { }

}

