namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000101")]
public static class NativeReferenceUnsafeUtility
{

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000AD9")]
	public static T* GetUnsafePtr(NativeReference<T> reference) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000ADB")]
	public static T* GetUnsafePtrWithoutChecks(NativeReference<T> reference) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000ADA")]
	public static T* GetUnsafeReadOnlyPtr(NativeReference<T> reference) { }

}

