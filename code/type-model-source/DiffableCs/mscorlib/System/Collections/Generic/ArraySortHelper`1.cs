namespace System.Collections.Generic;

[Token(Token = "0x2000615")]
internal class ArraySortHelper
{
	[Token(Token = "0x40018AC")]
	private static readonly ArraySortHelper<T> s_defaultArraySortHelper; //Field offset: 0x0

	[Token(Token = "0x1700073B")]
	public static ArraySortHelper<T> Default
	{
		[Address(RVA = "0xB5C600", Offset = "0xB5BA00", Length = "0x99")]
		[Token(Token = "0x6002D76")]
		 get { } //Length: 153
	}

	[Address(RVA = "0xB5C510", Offset = "0xB5B910", Length = "0xED")]
	[Token(Token = "0x6002D78")]
	private static ArraySortHelper`1() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002D77")]
	public ArraySortHelper`1() { }

	[Address(RVA = "0xB4C640", Offset = "0xB4BA40", Length = "0x144")]
	[Token(Token = "0x6002D6B")]
	public int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }

	[Address(RVA = "0xB4D970", Offset = "0xB4CD70", Length = "0x25B")]
	[Token(Token = "0x6002D74")]
	private static void DownHeap(T[] keys, int i, int n, int lo, Comparison<T> comparer) { }

	[Address(RVA = "0xB5C600", Offset = "0xB5BA00", Length = "0x99")]
	[Token(Token = "0x6002D76")]
	public static ArraySortHelper<T> get_Default() { }

	[Address(RVA = "0xB4E4C0", Offset = "0xB4D8C0", Length = "0x252")]
	[Token(Token = "0x6002D73")]
	private static void Heapsort(T[] keys, int lo, int hi, Comparison<T> comparer) { }

	[Address(RVA = "0xB4FA50", Offset = "0xB4EE50", Length = "0x1B9")]
	[Token(Token = "0x6002D75")]
	private static void InsertionSort(T[] keys, int lo, int hi, Comparison<T> comparer) { }

	[Address(RVA = "0xB51120", Offset = "0xB50520", Length = "0x190")]
	[Token(Token = "0x6002D6D")]
	internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }

	[Address(RVA = "0xB526F0", Offset = "0xB51AF0", Length = "0x3A0")]
	[Token(Token = "0x6002D71")]
	private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, Comparison<T> comparer) { }

	[Address(RVA = "0xB544B0", Offset = "0xB538B0", Length = "0xD6")]
	[Token(Token = "0x6002D70")]
	internal static void IntrospectiveSort(T[] keys, int left, int length, Comparison<T> comparer) { }

	[Address(RVA = "0xB561E0", Offset = "0xB555E0", Length = "0x3E0")]
	[Token(Token = "0x6002D72")]
	private static int PickPivotAndPartition(T[] keys, int lo, int hi, Comparison<T> comparer) { }

	[Address(RVA = "0xB57EC0", Offset = "0xB572C0", Length = "0x213")]
	[Token(Token = "0x6002D6A")]
	public void Sort(T[] keys, int index, int length, IComparer<T> comparer) { }

	[Address(RVA = "0xB59C60", Offset = "0xB59060", Length = "0x136")]
	[Token(Token = "0x6002D6C")]
	internal static void Sort(T[] keys, int index, int length, Comparison<T> comparer) { }

	[Address(RVA = "0xB5BF30", Offset = "0xB5B330", Length = "0xA1")]
	[Token(Token = "0x6002D6F")]
	private static void Swap(T[] a, int i, int j) { }

	[Address(RVA = "0xB5B9B0", Offset = "0xB5ADB0", Length = "0x13E")]
	[Token(Token = "0x6002D6E")]
	private static void SwapIfGreater(T[] keys, Comparison<T> comparer, int a, int b) { }

}

