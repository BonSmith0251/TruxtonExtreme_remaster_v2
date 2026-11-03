namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x200008D")]
internal struct NativeHashMapDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40003B2")]
	internal UnsafeHashMap<Int32, Int32>* m_HashMapData; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40003B3")]
	internal AllocatorHandle m_Allocator; //Field offset: 0x8

	[Address(RVA = "0x28C8920", Offset = "0x28C7D20", Length = "0x39")]
	[Token(Token = "0x600071E")]
	internal void Dispose() { }

}

