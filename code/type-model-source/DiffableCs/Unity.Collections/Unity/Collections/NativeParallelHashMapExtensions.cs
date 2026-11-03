namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x20000A6")]
public static class NativeParallelHashMapExtensions
{

	[Address(RVA = "0x88FF00", Offset = "0x88F300", Length = "0xD1")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x600080B")]
	public static ValueTuple<NativeArray`1<TKey>, Int32> GetUniqueKeyArray(UnsafeParallelMultiHashMap<TKey, TValue> container, AllocatorHandle allocator) { }

	[Address(RVA = "0x88FF00", Offset = "0x88F300", Length = "0xD1")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x600080C")]
	public static ValueTuple<NativeArray`1<TKey>, Int32> GetUniqueKeyArray(NativeParallelMultiHashMap<TKey, TValue> container, AllocatorHandle allocator) { }

	[Address(RVA = "0x88FFE0", Offset = "0x88F3E0", Length = "0x3A")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x600080D")]
	public static UnsafeParallelHashMapBucketData GetUnsafeBucketData(NativeParallelHashMap<TKey, TValue> container) { }

	[Address(RVA = "0x88FFE0", Offset = "0x88F3E0", Length = "0x3A")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x600080E")]
	public static UnsafeParallelHashMapBucketData GetUnsafeBucketData(NativeParallelMultiHashMap<TKey, TValue> container) { }

	[Address(RVA = "0x890020", Offset = "0x88F420", Length = "0xF3")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
	[Token(Token = "0x600080F")]
	public static void Remove(NativeParallelMultiHashMap<TKey, TValue> container, TKey key, TValue value) { }

	[Address(RVA = "0x890120", Offset = "0x88F520", Length = "0x2D9")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x600080A")]
	public static int Unique(NativeArray<T> array) { }

}

