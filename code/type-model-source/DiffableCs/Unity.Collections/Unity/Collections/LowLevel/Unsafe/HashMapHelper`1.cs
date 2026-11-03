namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
[Token(Token = "0x2000109")]
internal struct HashMapHelper
{
	[Token(Token = "0x200010A")]
	public struct Enumerator
	{
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		[Token(Token = "0x40004B4")]
		internal HashMapHelper<TKey>* m_Data; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B5")]
		internal int m_Index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B6")]
		internal int m_BucketIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40004B7")]
		internal int m_NextIndex; //Field offset: 0x0

		[Address(RVA = "0x198A950", Offset = "0x1989D50", Length = "0x19")]
		[Token(Token = "0x6000B4D")]
		internal Enumerator(HashMapHelper<TKey>* data) { }

		[Address(RVA = "0x699CB0", Offset = "0x6990B0", Length = "0x17")]
		[Token(Token = "0x6000B50")]
		internal KVPair<TKey, TValue> GetCurrent() { }

		[Address(RVA = "0xAC9A20", Offset = "0xAC8E20", Length = "0x2E")]
		[Token(Token = "0x6000B51")]
		internal TKey GetCurrentKey() { }

		[Address(RVA = "0x1986E40", Offset = "0x1986240", Length = "0x54")]
		[Token(Token = "0x6000B4E")]
		internal bool MoveNext() { }

		[Address(RVA = "0x1987FE0", Offset = "0x19873E0", Length = "0x16")]
		[Token(Token = "0x6000B4F")]
		internal void Reset() { }

	}

	[Token(Token = "0x40004B3")]
	internal const int kMinimumCapacity = 256; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004A7")]
	internal Byte* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004A8")]
	internal TKey* Keys; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004A9")]
	internal Int32* Next; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x40004AA")]
	internal Int32* Buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004AB")]
	internal int Count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004AC")]
	internal int Capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004AD")]
	internal int Log2MinGrowth; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004AE")]
	internal int BucketCapacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004AF")]
	internal int AllocatedIndex; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004B0")]
	internal int FirstFreeIdx; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004B1")]
	internal int SizeOfTValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40004B2")]
	internal AllocatorHandle Allocator; //Field offset: 0x0

	[Token(Token = "0x17000141")]
	internal bool IsCreated
	{
		[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
		[IsReadOnly]
		[Token(Token = "0x6000B36")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000142")]
	internal bool IsEmpty
	{
		[Address(RVA = "0x1C453A0", Offset = "0x1C447A0", Length = "0x36")]
		[IsReadOnly]
		[Token(Token = "0x6000B37")]
		internal get { } //Length: 54
	}

	[Address(RVA = "0x1C42260", Offset = "0x1C41660", Length = "0xB9")]
	[Token(Token = "0x6000B3B")]
	internal static HashMapHelper<TKey>* Alloc(int capacity, int sizeOfValueT, int minGrowth, AllocatorHandle allocator) { }

	[Address(RVA = "0x1C42430", Offset = "0x1C41830", Length = "0x4A")]
	[Token(Token = "0x6000B34")]
	internal int CalcCapacityCeilPow2(int capacity) { }

	[Address(RVA = "0x1C42480", Offset = "0x1C41880", Length = "0x32")]
	[Token(Token = "0x6000B40")]
	internal static int CalculateDataSize(int capacity, int bucketCapacity, int sizeOfTValue, out int outKeyOffset, out int outNextOffset, out int outBucketOffset) { }

	[Address(RVA = "0x1C42560", Offset = "0x1C41960", Length = "0x8D")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000B4C")]
	private void CheckIndexOutOfBounds(int idx) { }

	[Address(RVA = "0x1C425F0", Offset = "0x1C419F0", Length = "0x4C")]
	[Token(Token = "0x6000B38")]
	internal void Clear() { }

	[Address(RVA = "0x1C42640", Offset = "0x1C41A40", Length = "0x54")]
	[Token(Token = "0x6000B3A")]
	internal void Dispose() { }

	[Address(RVA = "0x1C42A70", Offset = "0x1C41E70", Length = "0x129")]
	[Token(Token = "0x6000B44")]
	internal int Find(TKey key) { }

	[Address(RVA = "0x1C42ED0", Offset = "0x1C422D0", Length = "0xED")]
	[Token(Token = "0x6000B3C")]
	internal static void Free(HashMapHelper<TKey>* data) { }

	[Address(RVA = "0xAFBA00", Offset = "0xAFAE00", Length = "0x8")]
	[IsReadOnly]
	[Token(Token = "0x6000B36")]
	internal bool get_IsCreated() { }

	[Address(RVA = "0x1C453A0", Offset = "0x1C447A0", Length = "0x36")]
	[IsReadOnly]
	[Token(Token = "0x6000B37")]
	internal bool get_IsEmpty() { }

	[Address(RVA = "0x1C42FD0", Offset = "0x1C423D0", Length = "0x49")]
	[Token(Token = "0x6000B42")]
	private int GetBucket(in TKey key) { }

	[Address(RVA = "0x1C42FC0", Offset = "0x1C423C0", Length = "0x4")]
	[Token(Token = "0x6000B35")]
	internal static int GetBucketSize(int capacity) { }

	[Address(RVA = "0x1C43070", Offset = "0x1C42470", Length = "0x2D")]
	[IsReadOnly]
	[Token(Token = "0x6000B41")]
	internal int GetCount() { }

	[Address(RVA = "0x1C430A0", Offset = "0x1C424A0", Length = "0x130")]
	[Token(Token = "0x6000B49")]
	internal NativeArray<TKey> GetKeyArray(AllocatorHandle allocator) { }

	[Address(RVA = "0x69A500", Offset = "0x699900", Length = "0x13F")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000B4B")]
	internal NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(AllocatorHandle allocator) { }

	[Address(RVA = "0x69A810", Offset = "0x699C10", Length = "0xD2")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000B4A")]
	internal NativeArray<TValue> GetValueArray(AllocatorHandle allocator) { }

	[Address(RVA = "0x1C436F0", Offset = "0x1C42AF0", Length = "0x1CB")]
	[Token(Token = "0x6000B39")]
	internal void Init(int capacity, int sizeOfValueT, int minGrowth, AllocatorHandle allocator) { }

	[Address(RVA = "0x1C43960", Offset = "0x1C42D60", Length = "0x90")]
	[Token(Token = "0x6000B48")]
	internal bool MoveNext(ref int bucketIndex, ref int nextIndex, out int index) { }

	[Address(RVA = "0x1C438C0", Offset = "0x1C42CC0", Length = "0x94")]
	[Token(Token = "0x6000B47")]
	internal bool MoveNextSearch(ref int bucketIndex, ref int nextIndex, out int index) { }

	[Address(RVA = "0x1C442F0", Offset = "0x1C436F0", Length = "0xAB")]
	[Token(Token = "0x6000B3D")]
	internal void Resize(int newCapacity) { }

	[Address(RVA = "0x1C43D70", Offset = "0x1C43170", Length = "0x1E0")]
	[Token(Token = "0x6000B3E")]
	internal void ResizeExact(int newCapacity, int newBucketCapacity) { }

	[Address(RVA = "0x1C44590", Offset = "0x1C43990", Length = "0xBB")]
	[Token(Token = "0x6000B3F")]
	internal void TrimExcess() { }

	[Address(RVA = "0x1C44650", Offset = "0x1C43A50", Length = "0x1F1")]
	[Token(Token = "0x6000B43")]
	internal int TryAdd(in TKey key) { }

	[Address(RVA = "0x69AAC0", Offset = "0x699EC0", Length = "0x88")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000B45")]
	internal bool TryGetValue(TKey key, out TValue item) { }

	[Address(RVA = "0x1C44D40", Offset = "0x1C44140", Length = "0x17E")]
	[Token(Token = "0x6000B46")]
	internal int TryRemove(TKey key) { }

}

