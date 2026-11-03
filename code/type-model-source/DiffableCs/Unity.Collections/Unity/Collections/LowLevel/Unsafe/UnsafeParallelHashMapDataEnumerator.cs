namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000128")]
internal struct UnsafeParallelHashMapDataEnumerator
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004F7")]
	internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004F8")]
	internal int m_Index; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40004F9")]
	internal int m_BucketIndex; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004FA")]
	internal int m_NextIndex; //Field offset: 0x10

	[Address(RVA = "0x198A950", Offset = "0x1989D50", Length = "0x19")]
	[Token(Token = "0x6000C52")]
	internal UnsafeParallelHashMapDataEnumerator(UnsafeParallelHashMapData* data) { }

	[Address(RVA = "0x699CB0", Offset = "0x6990B0", Length = "0x17")]
	[Token(Token = "0x6000C55")]
	internal KeyValue<TKey, TValue> GetCurrent() { }

	[Address(RVA = "0x9D8670", Offset = "0x9D7A70", Length = "0x124")]
	[Token(Token = "0x6000C56")]
	internal TKey GetCurrentKey() { }

	[Address(RVA = "0x28D2D50", Offset = "0x28D2150", Length = "0x26")]
	[Token(Token = "0x6000C53")]
	internal bool MoveNext() { }

	[Address(RVA = "0x1987FE0", Offset = "0x19873E0", Length = "0x16")]
	[Token(Token = "0x6000C54")]
	internal void Reset() { }

}

