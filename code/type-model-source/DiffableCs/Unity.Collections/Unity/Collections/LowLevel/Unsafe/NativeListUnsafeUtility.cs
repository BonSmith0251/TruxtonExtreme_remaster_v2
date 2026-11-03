namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000100")]
public static class NativeListUnsafeUtility
{

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000AD8")]
	public static Void* GetInternalListDataPtrUnchecked(ref NativeList<T>& list) { }

	[Address(RVA = "0x88FEE0", Offset = "0x88F2E0", Length = "0x16")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000AD6")]
	public static T* GetUnsafePtr(NativeList<T> list) { }

	[Address(RVA = "0x88FEE0", Offset = "0x88F2E0", Length = "0x16")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000AD7")]
	public static T* GetUnsafeReadOnlyPtr(NativeList<T> list) { }

}

