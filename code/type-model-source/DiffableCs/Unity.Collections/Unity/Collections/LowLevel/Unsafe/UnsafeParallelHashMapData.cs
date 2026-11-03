namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000123")]
internal struct UnsafeParallelHashMapData
{
	[Token(Token = "0x40004ED")]
	private const int kFirstFreeTLSOffset = 64; //Field offset: 0x0
	[Token(Token = "0x40004EE")]
	internal const int IntsPerCacheLine = 16; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004E6")]
	internal Byte* values; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40004E7")]
	internal Byte* keys; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004E8")]
	internal Byte* next; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004E9")]
	internal Byte* buckets; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004EA")]
	internal int keyCapacity; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40004EB")]
	internal int bucketCapacityMask; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004EC")]
	internal int allocatedIndexLength; //Field offset: 0x28

	[Token(Token = "0x1700016E")]
	internal Int32* firstFreeTLS
	{
		[Address(RVA = "0x1388FC0", Offset = "0x13883C0", Length = "0x5")]
		[Token(Token = "0x6000C2C")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x9D87A0", Offset = "0x9D7BA0", Length = "0x178")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000C2F")]
	internal static void AllocateHashMap(int length, int bucketLength, AllocatorHandle label, out UnsafeParallelHashMapData* outBuf) { }

	[Address(RVA = "0x9D9040", Offset = "0x9D8440", Length = "0xDD")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000C32")]
	internal static int CalculateDataSize(int length, int bucketLength, out int keyOffset, out int nextOffset, out int bucketOffset) { }

	[Address(RVA = "0x28D2D80", Offset = "0x28D2180", Length = "0x6A")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000C3B")]
	private static void CheckHashMapReallocateDoesNotShrink(UnsafeParallelHashMapData* data, int newCapacity) { }

	[Address(RVA = "0x28D2DF0", Offset = "0x28D21F0", Length = "0x6D")]
	[Token(Token = "0x6000C31")]
	internal static void DeallocateHashMap(UnsafeParallelHashMapData* data, AllocatorHandle allocator) { }

	[Address(RVA = "0x1388FC0", Offset = "0x13883C0", Length = "0x5")]
	[Token(Token = "0x6000C2C")]
	internal Int32* get_firstFreeTLS() { }

	[Address(RVA = "0x28D2E60", Offset = "0x28D2260", Length = "0x2F")]
	[Token(Token = "0x6000C3A")]
	internal UnsafeParallelHashMapBucketData GetBucketData() { }

	[Address(RVA = "0x1C42FC0", Offset = "0x1C423C0", Length = "0x4")]
	[Token(Token = "0x6000C2D")]
	internal static int GetBucketSize(int capacity) { }

	[Address(RVA = "0x28D2E90", Offset = "0x28D2290", Length = "0x7C")]
	[Token(Token = "0x6000C34")]
	internal static int GetCount(UnsafeParallelHashMapData* data) { }

	[Address(RVA = "0x9D95D0", Offset = "0x9D89D0", Length = "0xEC")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000C37")]
	internal static void GetKeyArray(UnsafeParallelHashMapData* data, NativeArray<TKey> result) { }

	[Address(RVA = "0x9D9A20", Offset = "0x9D8E20", Length = "0x12C")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000C39")]
	internal static void GetKeyValueArrays(UnsafeParallelHashMapData* data, NativeKeyValueArrays<TKey, TValue> result) { }

	[Address(RVA = "0x9DA2D0", Offset = "0x9D96D0", Length = "0xB5")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000C38")]
	internal static void GetValueArray(UnsafeParallelHashMapData* data, NativeArray<TValue> result) { }

	[Address(RVA = "0x28D2F10", Offset = "0x28D2310", Length = "0xE")]
	[Token(Token = "0x6000C2E")]
	internal static int GrowCapacity(int capacity) { }

	[Address(RVA = "0x28D2F20", Offset = "0x28D2320", Length = "0x42")]
	[Token(Token = "0x6000C33")]
	internal static bool IsEmpty(UnsafeParallelHashMapData* data) { }

	[Address(RVA = "0x28D3010", Offset = "0x28D2410", Length = "0xAD")]
	[Token(Token = "0x6000C36")]
	internal static bool MoveNext(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index) { }

	[Address(RVA = "0x28D2F70", Offset = "0x28D2370", Length = "0x90")]
	[Token(Token = "0x6000C35")]
	internal static bool MoveNextSearch(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index) { }

	[Address(RVA = "0x9DA630", Offset = "0x9D9A30", Length = "0x379")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x6000C30")]
	internal static void ReallocateHashMap(UnsafeParallelHashMapData* data, int newCapacity, int newBucketCapacity, AllocatorHandle label) { }

}

