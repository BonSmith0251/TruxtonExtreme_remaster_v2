namespace Unity.Collections.LowLevel.Unsafe;

[Extension]
[Token(Token = "0x2000076")]
public static class NativeSliceUnsafeUtility
{

	[Address(RVA = "0x890B40", Offset = "0x88FF40", Length = "0x132")]
	[Token(Token = "0x6000154")]
	public static NativeSlice<T> ConvertExistingDataToNativeSlice(Void* dataPointer, int stride, int length) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Extension]
	[Token(Token = "0x6000155")]
	public static Void* GetUnsafePtr(NativeSlice<T> nativeSlice) { }

	[Address(RVA = "0x88F140", Offset = "0x88E540", Length = "0x6")]
	[Extension]
	[Token(Token = "0x6000156")]
	public static Void* GetUnsafeReadOnlyPtr(NativeSlice<T> nativeSlice) { }

}

