namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000F6")]
internal struct Sorting
{
	[CompilerGenerated]
	[Token(Token = "0x20000F7")]
	private struct <>c__DisplayClass4_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005A5")]
		public T[] data; //Field offset: 0x0

	}

	[Token(Token = "0x40005A3")]
	public static ProfilingSampler s_QuickSortSampler; //Field offset: 0x0
	[Token(Token = "0x40005A4")]
	public static ProfilingSampler s_InsertionSortSampler; //Field offset: 0x8

	[Address(RVA = "0x2DC6CE0", Offset = "0x2DC60E0", Length = "0xE0")]
	[Token(Token = "0x60006B3")]
	private static Sorting() { }

	[Address(RVA = "0x8F4800", Offset = "0x8F3C00", Length = "0x6D")]
	[CompilerGenerated]
	[Token(Token = "0x60006B4")]
	internal static void <Median3Pivot>g__Swap|4_0(int a, int b, ref <>c__DisplayClass4_0<T>& unnamed_param_2) { }

	[Address(RVA = "0x8F1990", Offset = "0x8F0D90", Length = "0x105")]
	[Token(Token = "0x60006B1")]
	public static void InsertionSort(T[] data, Func<T, T, Int32> compare) { }

	[Address(RVA = "0x8F1E70", Offset = "0x8F1270", Length = "0x1AA")]
	[Token(Token = "0x60006B2")]
	public static void InsertionSort(T[] data, int start, int end, Func<T, T, Int32> compare) { }

	[Address(RVA = "0x8F2AB0", Offset = "0x8F1EB0", Length = "0x305")]
	[Token(Token = "0x60006AF")]
	private static T Median3Pivot(T[] data, int start, int pivot, int end, Func<T, T, Int32> compare) { }

	[Address(RVA = "0x8F3760", Offset = "0x8F2B60", Length = "0x1ED")]
	[Token(Token = "0x60006B0")]
	private static int Partition(T[] data, int start, int end, Func<T, T, Int32> compare) { }

	[Address(RVA = "0x8F3950", Offset = "0x8F2D50", Length = "0x104")]
	[Token(Token = "0x60006AD")]
	public static void QuickSort(T[] data, Func<T, T, Int32> compare) { }

	[Address(RVA = "0x8F4180", Offset = "0x8F3580", Length = "0x2A6")]
	[Token(Token = "0x60006AE")]
	public static void QuickSort(T[] data, int start, int end, Func<T, T, Int32> compare) { }

}

