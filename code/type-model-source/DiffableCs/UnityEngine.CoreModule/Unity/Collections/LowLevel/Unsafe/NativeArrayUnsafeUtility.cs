namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[Token(Token = "0x2000075")]
public static class NativeArrayUnsafeUtility
{

	[Address(RVA = "0x88F000", Offset = "0x88E400", Length = "0x21")]
	[Token(Token = "0x600014E")]
	public static NativeArray<T> ConvertExistingDataToNativeArray(Void* dataPointer, int length, Allocator allocator) { }

	[Address(RVA = "0x88F030", Offset = "0x88E430", Length = "0x88")]
	[Token(Token = "0x600014F")]
	public static NativeArray<T> ConvertExistingDataToNativeArray(Span<T> data, Allocator allocator) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Token(Token = "0x6000153")]
	public static Void* GetUnsafeBufferPointerWithoutChecks(NativeArray<T> nativeArray) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Extension]
	[Token(Token = "0x6000150")]
	public static Void* GetUnsafePtr(NativeArray<T> nativeArray) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Extension]
	[Token(Token = "0x6000151")]
	public static Void* GetUnsafeReadOnlyPtr(NativeArray<T> nativeArray) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Extension]
	[Token(Token = "0x6000152")]
	public static Void* GetUnsafeReadOnlyPtr(ReadOnly<T> nativeArray) { }

}

