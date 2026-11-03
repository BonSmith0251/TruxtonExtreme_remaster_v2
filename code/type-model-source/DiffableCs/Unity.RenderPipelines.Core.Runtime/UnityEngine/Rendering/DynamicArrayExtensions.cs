namespace UnityEngine.Rendering;

[Extension]
[Token(Token = "0x2000043")]
public static class DynamicArrayExtensions
{

	[Address(RVA = "0x7D2150", Offset = "0x7D1550", Length = "0x29C")]
	[Token(Token = "0x60004D8")]
	private static int Partition(Span<T> data, int left, int right) { }

	[Address(RVA = "0x7D1690", Offset = "0x7D0A90", Length = "0x1D1")]
	[Token(Token = "0x60004DA")]
	private static int Partition(Span<T> data, int left, int right, SortComparer<T> comparer) { }

	[Address(RVA = "0x7D2C10", Offset = "0x7D2010", Length = "0xC2")]
	[Token(Token = "0x60004D9")]
	private static void QuickSort(Span<T> data, int left, int right) { }

	[Address(RVA = "0x7D25F0", Offset = "0x7D19F0", Length = "0x28A")]
	[Token(Token = "0x60004DB")]
	private static void QuickSort(Span<T> data, int left, int right, SortComparer<T> comparer) { }

	[Address(RVA = "0x7D2B90", Offset = "0x7D1F90", Length = "0x7E")]
	[Extension]
	[Token(Token = "0x60004DC")]
	public static void QuickSort(DynamicArray<T> array) { }

	[Address(RVA = "0x7D2550", Offset = "0x7D1950", Length = "0x93")]
	[Extension]
	[Token(Token = "0x60004DD")]
	public static void QuickSort(DynamicArray<T> array, SortComparer<T> comparer) { }

}

