namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x20000B4")]
public static class NativeParallelMultiHashMapExtensions
{

	[Address(RVA = "0x890400", Offset = "0x88F800", Length = "0xFA")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int), typeof(AllocatorHandle)})]
	[Token(Token = "0x60008B8")]
	internal static void Initialize(ref NativeParallelMultiHashMap<TKey, TValue>& container, int capacity, ref U allocator) { }

}

