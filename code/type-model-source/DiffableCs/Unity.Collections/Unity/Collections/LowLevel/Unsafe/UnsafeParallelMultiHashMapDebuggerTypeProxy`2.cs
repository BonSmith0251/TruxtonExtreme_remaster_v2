namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200013B")]
internal sealed class UnsafeParallelMultiHashMapDebuggerTypeProxy
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000516")]
	private UnsafeParallelMultiHashMap<TKey, TValue> m_Target; //Field offset: 0x0

	[Token(Token = "0x17000194")]
	public List<ListPair`2<TKey, List`1<TValue>>> Items
	{
		[Address(RVA = "0x11D9720", Offset = "0x11D8B20", Length = "0x595")]
		[Token(Token = "0x6000D67")]
		 get { } //Length: 1429
	}

	[Address(RVA = "0xB49C20", Offset = "0xB49020", Length = "0x29")]
	[Token(Token = "0x6000D65")]
	public UnsafeParallelMultiHashMapDebuggerTypeProxy`2(UnsafeParallelMultiHashMap<TKey, TValue> target) { }

	[Address(RVA = "0x11D9720", Offset = "0x11D8B20", Length = "0x595")]
	[Token(Token = "0x6000D67")]
	public List<ListPair`2<TKey, List`1<TValue>>> get_Items() { }

	[Address(RVA = "0x11D9590", Offset = "0x11D8990", Length = "0x181")]
	[Token(Token = "0x6000D66")]
	public static ValueTuple<NativeArray`1<TKey>, Int32> GetUniqueKeyArray(ref UnsafeParallelMultiHashMap<TKey, TValue>& hashMap, AllocatorHandle allocator) { }

}

