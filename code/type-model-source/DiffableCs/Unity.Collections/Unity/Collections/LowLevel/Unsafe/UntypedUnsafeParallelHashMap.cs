namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200012F")]
public struct UntypedUnsafeParallelHashMap
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000504")]
	private UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000505")]
	private AllocatorHandle m_AllocatorLabel; //Field offset: 0x8

}

