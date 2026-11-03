namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
[Token(Token = "0x2000124")]
internal struct UnsafeParallelHashMapDataDispose
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004EF")]
	internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004F0")]
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x8

	[Address(RVA = "0x28D2CE0", Offset = "0x28D20E0", Length = "0x6E")]
	[Token(Token = "0x6000C3C")]
	public void Dispose() { }

}

