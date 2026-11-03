namespace Unity.Collections;

[Extension]
[Token(Token = "0x2000082")]
public static class ListExtensions
{

	[Address(RVA = "0x8633C0", Offset = "0x8627C0", Length = "0x136")]
	[Extension]
	[Token(Token = "0x60006D1")]
	public static void RemoveAtSwapBack(List<T> list, int index) { }

	[Address(RVA = "0x863500", Offset = "0x862900", Length = "0x100")]
	[Extension]
	[Token(Token = "0x60006CF")]
	public static bool RemoveSwapBack(List<T> list, T value) { }

	[Address(RVA = "0x863610", Offset = "0x862A10", Length = "0x82")]
	[Extension]
	[Token(Token = "0x60006D0")]
	public static bool RemoveSwapBack(List<T> list, Predicate<T> matcher) { }

	[Address(RVA = "0x8636A0", Offset = "0x862AA0", Length = "0x163")]
	[Extension]
	[Token(Token = "0x60006D3")]
	public static NativeArray<T> ToNativeArray(List<T> list, AllocatorHandle allocator) { }

	[Address(RVA = "0x863810", Offset = "0x862C10", Length = "0x12C")]
	[Extension]
	[Token(Token = "0x60006D2")]
	public static NativeList<T> ToNativeList(List<T> list, AllocatorHandle allocator) { }

}

