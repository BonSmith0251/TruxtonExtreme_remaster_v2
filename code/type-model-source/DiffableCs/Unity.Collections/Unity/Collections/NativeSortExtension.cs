namespace Unity.Collections;

[Extension]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x20000C3")]
public static class NativeSortExtension
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x20000C4")]
	internal struct DefaultComparer : IComparer<T>
	{

		[Address(RVA = "0x17D2DE0", Offset = "0x17D21E0", Length = "0x3E")]
		[Token(Token = "0x6000936")]
		public override int Compare(T x, T y) { }

	}

	[Token(Token = "0x40003EE")]
	private const int k_IntrosortSizeThreshold = 16; //Field offset: 0x0

	[Address(RVA = "0x890C80", Offset = "0x890080", Length = "0x7E")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x600090F")]
	public static int BinarySearch(ReadOnly<T> array, T value, U comp) { }

	[Address(RVA = "0x891650", Offset = "0x890A50", Length = "0xC1")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000922")]
	public static int BinarySearch(NativeSlice<T> slice, T value) { }

	[Address(RVA = "0x891420", Offset = "0x890820", Length = "0x15F")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000917")]
	public static int BinarySearch(NativeList<T> list, T value, U comp) { }

	[Address(RVA = "0x8917F0", Offset = "0x890BF0", Length = "0xE4")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000916")]
	public static int BinarySearch(NativeList<T> list, T value) { }

	[Address(RVA = "0x890EC0", Offset = "0x8902C0", Length = "0x174")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000923")]
	public static int BinarySearch(NativeSlice<T> slice, T value, U comp) { }

	[Address(RVA = "0x891720", Offset = "0x890B20", Length = "0xCA")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x600091C")]
	public static int BinarySearch(UnsafeList<T> list, T value) { }

	[Address(RVA = "0x890DA0", Offset = "0x8901A0", Length = "0x86")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x600090E")]
	public static int BinarySearch(ReadOnly<T> array, T value) { }

	[Address(RVA = "0x890C80", Offset = "0x890080", Length = "0x7E")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x600090D")]
	public static int BinarySearch(NativeArray<T> array, T value, U comp) { }

	[Address(RVA = "0x890E30", Offset = "0x890230", Length = "0x85")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x600090C")]
	public static int BinarySearch(NativeArray<T> array, T value) { }

	[Address(RVA = "0x8912A0", Offset = "0x8906A0", Length = "0x176")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x600091D")]
	public static int BinarySearch(UnsafeList<T> list, T value, U comp) { }

	[Address(RVA = "0x890D00", Offset = "0x890100", Length = "0x9E")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000907")]
	public static int BinarySearch(T* ptr, int length, T value, U comp) { }

	[Address(RVA = "0x891580", Offset = "0x890980", Length = "0xCA")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000906")]
	public static int BinarySearch(T* ptr, int length, T value) { }

	[Address(RVA = "0x891DC0", Offset = "0x8911C0", Length = "0x8DD")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000935")]
	private static void CheckComparer(T* array, int length, U comp) { }

	[Address(RVA = "0x8926A0", Offset = "0x891AA0", Length = "0x78")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Token(Token = "0x6000934")]
	private static void CheckStrideMatchesSize(int stride) { }

	[Address(RVA = "0x893ED0", Offset = "0x8932D0", Length = "0x129")]
	[Token(Token = "0x6000929")]
	private static void Heapify(Void* array, int i, int n, int lo, U comp) { }

	[Address(RVA = "0x893A00", Offset = "0x892E00", Length = "0x4CD")]
	[Token(Token = "0x6000931")]
	private static void HeapifyStruct(Void* array, int i, int n, in int lo, U comp) { }

	[Address(RVA = "0x892940", Offset = "0x891D40", Length = "0x342")]
	[Token(Token = "0x6000928")]
	private static void HeapSort(Void* array, int lo, int hi, U comp) { }

	[Address(RVA = "0x892720", Offset = "0x891B20", Length = "0x21B")]
	[Token(Token = "0x6000930")]
	private static void HeapSortStruct(Void* array, in int lo, in int hi, U comp) { }

	[Address(RVA = "0x894C70", Offset = "0x894070", Length = "0xB6")]
	[Token(Token = "0x6000926")]
	private static void InsertionSort(Void* array, int lo, int hi, U comp) { }

	[Address(RVA = "0x894910", Offset = "0x893D10", Length = "0x35D")]
	[Token(Token = "0x600092E")]
	private static void InsertionSortStruct(Void* array, in int lo, in int hi, U comp) { }

	[Address(RVA = "0x8961E0", Offset = "0x8955E0", Length = "0x70")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000924")]
	internal static void IntroSort(Void* array, int length, U comp) { }

	[Address(RVA = "0x8956A0", Offset = "0x894AA0", Length = "0x177")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000925")]
	internal static void IntroSort_R(Void* array, int lo, int hi, int depth, U comp) { }

	[Address(RVA = "0x895580", Offset = "0x894980", Length = "0x117")]
	[Token(Token = "0x600092C")]
	private static void IntroSortStruct(Void* array, int length, U comp) { }

	[Address(RVA = "0x895050", Offset = "0x894450", Length = "0x524")]
	[Token(Token = "0x600092D")]
	private static void IntroSortStruct_R(Void* array, in int lo, in int _hi, int depth, U comp) { }

	[Address(RVA = "0x896B20", Offset = "0x895F20", Length = "0x1C8")]
	[Token(Token = "0x6000927")]
	private static int Partition(Void* array, int lo, int hi, U comp) { }

	[Address(RVA = "0x8964D0", Offset = "0x8958D0", Length = "0x650")]
	[Token(Token = "0x600092F")]
	private static int PartitionStruct(Void* array, in int lo, in int hi, U comp) { }

	[Address(RVA = "0x8986B0", Offset = "0x897AB0", Length = "0x122")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x600091F")]
	public static void Sort(NativeSlice<T> slice, U comp) { }

	[Address(RVA = "0x898CD0", Offset = "0x8980D0", Length = "0x6E")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x600091E")]
	public static void Sort(NativeSlice<T> slice) { }

	[Address(RVA = "0x898B90", Offset = "0x897F90", Length = "0x83")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000902")]
	public static void Sort(T* array, int length) { }

	[Address(RVA = "0x8989F0", Offset = "0x897DF0", Length = "0x111")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000919")]
	public static void Sort(UnsafeList<T> list, U comp) { }

	[Address(RVA = "0x898620", Offset = "0x897A20", Length = "0x87")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000903")]
	public static void Sort(T* array, int length, U comp) { }

	[Address(RVA = "0x898D40", Offset = "0x898140", Length = "0x7C")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000918")]
	public static void Sort(UnsafeList<T> list) { }

	[Address(RVA = "0x898C20", Offset = "0x898020", Length = "0xAD")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000908")]
	public static void Sort(NativeArray<T> array) { }

	[Address(RVA = "0x8986B0", Offset = "0x897AB0", Length = "0x122")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000909")]
	public static void Sort(NativeArray<T> array, U comp) { }

	[Address(RVA = "0x8987E0", Offset = "0x897BE0", Length = "0x11D")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000911")]
	public static void Sort(NativeList<T> list, U comp) { }

	[Address(RVA = "0x898B10", Offset = "0x897F10", Length = "0x73")]
	[Extension]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000910")]
	public static void Sort(NativeList<T> list) { }

	[Address(RVA = "0x898600", Offset = "0x897A00", Length = "0x11")]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000904")]
	public static SortJob<T, DefaultComparer`1<T>> SortJob(T* array, int length) { }

	[Address(RVA = "0x897BC0", Offset = "0x896FC0", Length = "0x15")]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000905")]
	public static SortJob<T, U> SortJob(T* array, int length, U comp) { }

	[Address(RVA = "0x897BE0", Offset = "0x896FE0", Length = "0x75")]
	[Extension]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x600090A")]
	public static SortJob<T, DefaultComparer`1<T>> SortJob(NativeArray<T> array) { }

	[Address(RVA = "0x898540", Offset = "0x897940", Length = "0xB5")]
	[Extension]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x600091A")]
	public static SortJob<T, DefaultComparer`1<T>> SortJob(UnsafeList<T> list) { }

	[Address(RVA = "0x897FA0", Offset = "0x8973A0", Length = "0x15F")]
	[Extension]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x600091B")]
	public static SortJob<T, U> SortJob(UnsafeList<T> list, U comp) { }

	[Address(RVA = "0x897B30", Offset = "0x896F30", Length = "0x8B")]
	[Extension]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000912")]
	public static SortJob<T, DefaultComparer`1<T>> SortJob(NativeList<T> list) { }

	[Address(RVA = "0x898100", Offset = "0x897500", Length = "0x16E")]
	[Extension]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000913")]
	public static SortJob<T, U> SortJob(NativeList<T> list, U comp) { }

	[Address(RVA = "0x897C60", Offset = "0x897060", Length = "0x16D")]
	[Extension]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000921")]
	public static SortJob<T, U> SortJob(NativeSlice<T> slice, U comp) { }

	[Address(RVA = "0x898470", Offset = "0x897870", Length = "0xC5")]
	[Extension]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000920")]
	public static SortJob<T, DefaultComparer`1<T>> SortJob(NativeSlice<T> slice) { }

	[Address(RVA = "0x898270", Offset = "0x897670", Length = "0x1F1")]
	[Extension]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x600090B")]
	public static SortJob<T, U> SortJob(NativeArray<T> array, U comp) { }

	[Address(RVA = "0x897B30", Offset = "0x896F30", Length = "0x8B")]
	[Extension]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int)})]
	[Token(Token = "0x6000914")]
	public static SortJobDefer<T, DefaultComparer`1<T>> SortJobDefer(NativeList<T> list) { }

	[Address(RVA = "0x8979A0", Offset = "0x896DA0", Length = "0x181")]
	[Extension]
	[GenerateTestsForBurstCompatibility(RequiredUnityDefine = "UNITY_2020_2_OR_NEWER", GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(Unity.Collections.NativeSortExtension+DefaultComparer`1<System.Int32>)})]
	[Token(Token = "0x6000915")]
	public static SortJobDefer<T, U> SortJobDefer(NativeList<T> list, U comp) { }

	[Address(RVA = "0x8995D0", Offset = "0x8989D0", Length = "0x45")]
	[Token(Token = "0x600092A")]
	private static void Swap(Void* array, int lhs, int rhs) { }

	[Address(RVA = "0x899160", Offset = "0x898560", Length = "0x8C")]
	[Token(Token = "0x600092B")]
	private static void SwapIfGreaterWithItems(Void* array, int lhs, int rhs, U comp) { }

	[Address(RVA = "0x898F70", Offset = "0x898370", Length = "0x1E3")]
	[Token(Token = "0x6000933")]
	private static void SwapIfGreaterWithItemsStruct(Void* array, int lhs, int rhs, U comp) { }

	[Address(RVA = "0x8993E0", Offset = "0x8987E0", Length = "0x1E8")]
	[Token(Token = "0x6000932")]
	private static void SwapStruct(Void* array, int lhs, int rhs) { }

}

