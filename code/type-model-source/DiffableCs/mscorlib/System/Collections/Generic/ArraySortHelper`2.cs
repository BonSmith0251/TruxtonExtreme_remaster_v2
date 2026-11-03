namespace System.Collections.Generic;

[Token(Token = "0x2000616")]
internal class ArraySortHelper
{
	[Token(Token = "0x40018AD")]
	private static readonly ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; //Field offset: 0x0

	[Token(Token = "0x1700073C")]
	public static ArraySortHelper<TKey, TValue> Default
	{
		[Address(RVA = "0x1008390", Offset = "0x1007790", Length = "0x99")]
		[Token(Token = "0x6002D82")]
		 get { } //Length: 153
	}

	[Address(RVA = "0x10082A0", Offset = "0x10076A0", Length = "0xED")]
	[Token(Token = "0x6002D84")]
	private static ArraySortHelper`2() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002D83")]
	public ArraySortHelper`2() { }

	[Address(RVA = "0x10016C0", Offset = "0x1000AC0", Length = "0x2C2")]
	[Token(Token = "0x6002D80")]
	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }

	[Address(RVA = "0x1008390", Offset = "0x1007790", Length = "0x99")]
	[Token(Token = "0x6002D82")]
	public static ArraySortHelper<TKey, TValue> get_Default() { }

	[Address(RVA = "0x1002C80", Offset = "0x1002080", Length = "0x271")]
	[Token(Token = "0x6002D7F")]
	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }

	[Address(RVA = "0x1003850", Offset = "0x1002C50", Length = "0x242")]
	[Token(Token = "0x6002D81")]
	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }

	[Address(RVA = "0x1004BE0", Offset = "0x1003FE0", Length = "0x3D1")]
	[Token(Token = "0x6002D7D")]
	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }

	[Address(RVA = "0x1004FC0", Offset = "0x10043C0", Length = "0xEA")]
	[Token(Token = "0x6002D7C")]
	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }

	[Address(RVA = "0x10053B0", Offset = "0x10047B0", Length = "0x4BD")]
	[Token(Token = "0x6002D7E")]
	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }

	[Address(RVA = "0x1006AA0", Offset = "0x1005EA0", Length = "0x1F6")]
	[Token(Token = "0x6002D79")]
	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }

	[Address(RVA = "0x1008010", Offset = "0x1007410", Length = "0x87")]
	[Token(Token = "0x6002D7B")]
	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }

	[Address(RVA = "0x1007020", Offset = "0x1006420", Length = "0x11C")]
	[Token(Token = "0x6002D7A")]
	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }

}

