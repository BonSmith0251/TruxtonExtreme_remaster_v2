namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[Token(Token = "0x2000126")]
internal struct UnsafeParallelHashMapBase
{
	[Token(Token = "0x40004F2")]
	private const int SentinelRefilling = -2; //Field offset: 0x0
	[Token(Token = "0x40004F3")]
	private const int SentinelSwapInProgress = -3; //Field offset: 0x0

	[Address(RVA = "0x11CBEB0", Offset = "0x11CB2B0", Length = "0x183")]
	[Token(Token = "0x6000C42")]
	internal static void AddAtomicMulti(UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex) { }

	[Address(RVA = "0x11CC040", Offset = "0x11CB440", Length = "0x2EE")]
	[Token(Token = "0x6000C3F")]
	internal static int AllocEntry(UnsafeParallelHashMapData* data, int threadIndex) { }

	[Address(RVA = "0x11CC330", Offset = "0x11CB730", Length = "0x63")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000C4B")]
	private static void CheckIndexOutOfBounds(UnsafeParallelHashMapData* data, int idx) { }

	[Address(RVA = "0x11CC3A0", Offset = "0x11CB7A0", Length = "0xA2")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000C4A")]
	private static void CheckOutOfCapacity(int idx, int keyCapacity) { }

	[Address(RVA = "0x11CC450", Offset = "0x11CB850", Length = "0x98")]
	[Token(Token = "0x6000C3E")]
	internal static void Clear(UnsafeParallelHashMapData* data) { }

	[Address(RVA = "0x11CC4F0", Offset = "0x11CB8F0", Length = "0x9C")]
	[Token(Token = "0x6000C40")]
	internal static void FreeEntry(UnsafeParallelHashMapData* data, int idx, int threadIndex) { }

	[Address(RVA = "0x11CC8F0", Offset = "0x11CBCF0", Length = "0x21A")]
	[Token(Token = "0x6000C44")]
	internal static int Remove(UnsafeParallelHashMapData* data, TKey key, bool isMultiHashMap) { }

	[Address(RVA = "0x11CC590", Offset = "0x11CB990", Length = "0xDD")]
	[Token(Token = "0x6000C45")]
	internal static void Remove(UnsafeParallelHashMapData* data, NativeParallelMultiHashMapIterator<TKey> it) { }

	[Address(RVA = "0x6E8090", Offset = "0x6E7490", Length = "0x579")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000C46")]
	internal static void RemoveKeyValue(UnsafeParallelHashMapData* data, TKey key, TValueEQ value) { }

	[Address(RVA = "0x11CCB70", Offset = "0x11CBF70", Length = "0x5C")]
	[Token(Token = "0x6000C49")]
	internal static bool SetValue(UnsafeParallelHashMapData* data, ref NativeParallelMultiHashMapIterator<TKey>& it, ref TValue item) { }

	[Address(RVA = "0x11CCBD0", Offset = "0x11CBFD0", Length = "0x49")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000C4C")]
	private static void ThrowFull() { }

	[Address(RVA = "0x11CCC20", Offset = "0x11CC020", Length = "0x49")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000C4D")]
	private static void ThrowInvalidIterator() { }

	[Address(RVA = "0x11CD2A0", Offset = "0x11CC6A0", Length = "0x369")]
	[Token(Token = "0x6000C43")]
	internal static bool TryAdd(UnsafeParallelHashMapData* data, TKey key, TValue item, bool isMultiHashMap, AllocatorHandle allocation) { }

	[Address(RVA = "0x11CCEE0", Offset = "0x11CC2E0", Length = "0x3B6")]
	[Token(Token = "0x6000C41")]
	internal static bool TryAddAtomic(UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex) { }

	[Address(RVA = "0x11CDA50", Offset = "0x11CCE50", Length = "0x259")]
	[Token(Token = "0x6000C47")]
	internal static bool TryGetFirstValueAtomic(UnsafeParallelHashMapData* data, TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey>& it) { }

	[Address(RVA = "0x11CDDB0", Offset = "0x11CD1B0", Length = "0x1A0")]
	[Token(Token = "0x6000C48")]
	internal static bool TryGetNextValueAtomic(UnsafeParallelHashMapData* data, out TValue item, ref NativeParallelMultiHashMapIterator<TKey>& it) { }

}

