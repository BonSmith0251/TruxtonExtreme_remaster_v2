namespace System;

[Token(Token = "0x200016D")]
public abstract class Array : ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable, ICloneable
{
	[Token(Token = "0x200016E")]
	private sealed class ArrayEnumerator : IEnumerator, ICloneable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400055A")]
		private Array _array; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400055B")]
		private int _index; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400055C")]
		private int _endIndex; //Field offset: 0x1C

		[Token(Token = "0x17000113")]
		public override object Current
		{
			[Address(RVA = "0x2059D20", Offset = "0x2059120", Length = "0x169")]
			[Token(Token = "0x6000D48")]
			 get { } //Length: 361
		}

		[Address(RVA = "0x2059CC0", Offset = "0x20590C0", Length = "0x50")]
		[Token(Token = "0x6000D44")]
		internal ArrayEnumerator(Array array) { }

		[Address(RVA = "0x1F8FF70", Offset = "0x1F8F370", Length = "0x7")]
		[Token(Token = "0x6000D47")]
		public override object Clone() { }

		[Address(RVA = "0x2059D20", Offset = "0x2059120", Length = "0x169")]
		[Token(Token = "0x6000D48")]
		public override object get_Current() { }

		[Address(RVA = "0x2059CA0", Offset = "0x20590A0", Length = "0x1A")]
		[Token(Token = "0x6000D45")]
		public override bool MoveNext() { }

		[Address(RVA = "0x195A120", Offset = "0x1959520", Length = "0x8")]
		[Token(Token = "0x6000D46")]
		public override void Reset() { }

	}

	[Token(Token = "0x2000171")]
	public class EmptyInternalEnumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[Token(Token = "0x4000562")]
		public static readonly EmptyInternalEnumerator<T> Value; //Field offset: 0x0

		[Token(Token = "0x17000116")]
		public override T Current
		{
			[Address(RVA = "0x1951780", Offset = "0x1950B80", Length = "0x49")]
			[Token(Token = "0x6000D51")]
			 get { } //Length: 73
		}

		[Token(Token = "0x17000117")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1951250", Offset = "0x1950650", Length = "0x2E")]
			[Token(Token = "0x6000D52")]
			private get { } //Length: 46
		}

		[Address(RVA = "0x1951690", Offset = "0x1950A90", Length = "0xEA")]
		[Token(Token = "0x6000D55")]
		private static EmptyInternalEnumerator`1() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D54")]
		public EmptyInternalEnumerator`1() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000D4F")]
		public override void Dispose() { }

		[Address(RVA = "0x1951780", Offset = "0x1950B80", Length = "0x49")]
		[Token(Token = "0x6000D51")]
		public override T get_Current() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000D50")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1951250", Offset = "0x1950650", Length = "0x2E")]
		[Token(Token = "0x6000D52")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000D53")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[Token(Token = "0x2000170")]
	public struct InternalEnumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000560")]
		private readonly Array array; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000561")]
		private int idx; //Field offset: 0x0

		[Token(Token = "0x17000114")]
		public override T Current
		{
			[Address(RVA = "0xA92820", Offset = "0xA91C20", Length = "0x129")]
			[Token(Token = "0x6000D4C")]
			 get { } //Length: 297
		}

		[Token(Token = "0x17000115")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xA90210", Offset = "0xA8F610", Length = "0x7A")]
			[Token(Token = "0x6000D4E")]
			private get { } //Length: 122
		}

		[Address(RVA = "0xA91C80", Offset = "0xA91080", Length = "0x1E")]
		[Token(Token = "0x6000D49")]
		internal InternalEnumerator`1(Array array) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000D4A")]
		public override void Dispose() { }

		[Address(RVA = "0xA92820", Offset = "0xA91C20", Length = "0x129")]
		[Token(Token = "0x6000D4C")]
		public override T get_Current() { }

		[Address(RVA = "0xA8FF50", Offset = "0xA8F350", Length = "0x48")]
		[Token(Token = "0x6000D4B")]
		public override bool MoveNext() { }

		[Address(RVA = "0xA90210", Offset = "0xA8F610", Length = "0x7A")]
		[Token(Token = "0x6000D4E")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA8FFA0", Offset = "0xA8F3A0", Length = "0x8")]
		[Token(Token = "0x6000D4D")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[Token(Token = "0x200016F")]
	private class RawData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400055D")]
		public IntPtr Bounds; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400055E")]
		public IntPtr Count; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400055F")]
		public byte Data; //Field offset: 0x20

	}

	[Token(Token = "0x2000173")]
	private struct SorterGenericArray
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000566")]
		private Array keys; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000567")]
		private Array items; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000568")]
		private IComparer comparer; //Field offset: 0x10

		[Address(RVA = "0x20785F0", Offset = "0x20779F0", Length = "0xAB")]
		[Token(Token = "0x6000D60")]
		internal SorterGenericArray(Array keys, Array items, IComparer comparer) { }

		[Address(RVA = "0x2077B70", Offset = "0x2076F70", Length = "0x234")]
		[Token(Token = "0x6000D68")]
		private void DownHeap(int i, int n, int lo) { }

		[Address(RVA = "0x2077DB0", Offset = "0x20771B0", Length = "0xBC")]
		[Token(Token = "0x6000D67")]
		private void Heapsort(int lo, int hi) { }

		[Address(RVA = "0x2077E70", Offset = "0x2077270", Length = "0x1A0")]
		[Token(Token = "0x6000D69")]
		private void InsertionSort(int lo, int hi) { }

		[Address(RVA = "0x2078020", Offset = "0x2077420", Length = "0xDC")]
		[Token(Token = "0x6000D65")]
		private void IntroSort(int lo, int hi, int depthLimit) { }

		[Address(RVA = "0x2078100", Offset = "0x2077500", Length = "0xEA")]
		[Token(Token = "0x6000D64")]
		private void IntrospectiveSort(int left, int length) { }

		[Address(RVA = "0x20781F0", Offset = "0x20775F0", Length = "0x175")]
		[Token(Token = "0x6000D66")]
		private int PickPivotAndPartition(int lo, int hi) { }

		[Address(RVA = "0x2078370", Offset = "0x2077770", Length = "0x8")]
		[Token(Token = "0x6000D63")]
		internal void Sort(int left, int length) { }

		[Address(RVA = "0x2078500", Offset = "0x2077900", Length = "0xEF")]
		[Token(Token = "0x6000D62")]
		private void Swap(int i, int j) { }

		[Address(RVA = "0x2078380", Offset = "0x2077780", Length = "0x170")]
		[Token(Token = "0x6000D61")]
		internal void SwapIfGreaterWithItems(int a, int b) { }

	}

	[Token(Token = "0x2000172")]
	private struct SorterObjectArray
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000563")]
		private Object[] keys; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000564")]
		private Object[] items; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000565")]
		private IComparer comparer; //Field offset: 0x10

		[Address(RVA = "0x2079610", Offset = "0x2078A10", Length = "0xAB")]
		[Token(Token = "0x6000D56")]
		internal SorterObjectArray(Object[] keys, Object[] items, IComparer comparer) { }

		[Address(RVA = "0x20786A0", Offset = "0x2077AA0", Length = "0x3D0")]
		[Token(Token = "0x6000D5E")]
		private void DownHeap(int i, int n, int lo) { }

		[Address(RVA = "0x2078A80", Offset = "0x2077E80", Length = "0xBC")]
		[Token(Token = "0x6000D5D")]
		private void Heapsort(int lo, int hi) { }

		[Address(RVA = "0x2078B40", Offset = "0x2077F40", Length = "0x304")]
		[Token(Token = "0x6000D5F")]
		private void InsertionSort(int lo, int hi) { }

		[Address(RVA = "0x2078E50", Offset = "0x2078250", Length = "0xDC")]
		[Token(Token = "0x6000D5B")]
		private void IntroSort(int lo, int hi, int depthLimit) { }

		[Address(RVA = "0x2078F30", Offset = "0x2078330", Length = "0xE0")]
		[Token(Token = "0x6000D5A")]
		private void IntrospectiveSort(int left, int length) { }

		[Address(RVA = "0x2079020", Offset = "0x2078420", Length = "0x19F")]
		[Token(Token = "0x6000D5C")]
		private int PickPivotAndPartition(int lo, int hi) { }

		[Address(RVA = "0x20791C0", Offset = "0x20785C0", Length = "0x8")]
		[Token(Token = "0x6000D59")]
		internal void Sort(int left, int length) { }

		[Address(RVA = "0x2079430", Offset = "0x2078830", Length = "0x1DC")]
		[Token(Token = "0x6000D58")]
		private void Swap(int i, int j) { }

		[Address(RVA = "0x20791D0", Offset = "0x20785D0", Length = "0x250")]
		[Token(Token = "0x6000D57")]
		internal void SwapIfGreaterWithItems(int a, int b) { }

	}


	[Token(Token = "0x1700010D")]
	public override bool IsFixedSize
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000CC9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700010E")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000CCA")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700010F")]
	public override bool IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000CCB")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000111")]
	public int Length
	{
		[Address(RVA = "0x203FD00", Offset = "0x203F100", Length = "0x5D")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6000D1B")]
		 get { } //Length: 93
	}

	[Token(Token = "0x1700010C")]
	public long LongLength
	{
		[Address(RVA = "0x2042260", Offset = "0x2041660", Length = "0x62")]
		[Token(Token = "0x6000CC3")]
		 get { } //Length: 98
	}

	[Token(Token = "0x17000112")]
	public int Rank
	{
		[Address(RVA = "0x203EE80", Offset = "0x203E280", Length = "0x5")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x6000D1C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000110")]
	public override object SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6000CCC")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000109")]
	private override int System.Collections.ICollection.Count
	{
		[Address(RVA = "0x203FD00", Offset = "0x203F100", Length = "0x5D")]
		[Token(Token = "0x6000CAC")]
		private get { } //Length: 93
	}

	[Token(Token = "0x1700010A")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000CAD")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700010B")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x2041C00", Offset = "0x2041000", Length = "0x8")]
		[Token(Token = "0x6000CAE")]
		private get { } //Length: 8
		[Address(RVA = "0x2041C10", Offset = "0x2041010", Length = "0x11")]
		[Token(Token = "0x6000CAF")]
		private set { } //Length: 17
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000D08")]
	private Array() { }

	[Address(RVA = "0x768D50", Offset = "0x768150", Length = "0xAF")]
	[Token(Token = "0x6000CAA")]
	public static ReadOnlyCollection<T> AsReadOnly(T[] array) { }

	[Address(RVA = "0x203CDA0", Offset = "0x203C1A0", Length = "0xEA")]
	[Token(Token = "0x6000CCE")]
	public static int BinarySearch(Array array, object value, IComparer comparer) { }

	[Address(RVA = "0x774F80", Offset = "0x774380", Length = "0x78")]
	[Token(Token = "0x6000CD3")]
	public static int BinarySearch(T[] array, int index, int length, T value) { }

	[Address(RVA = "0x774ED0", Offset = "0x7742D0", Length = "0xA8")]
	[Token(Token = "0x6000CD2")]
	public static int BinarySearch(T[] array, T value, IComparer<T> comparer) { }

	[Address(RVA = "0x76F780", Offset = "0x76EB80", Length = "0x9E")]
	[Token(Token = "0x6000CD1")]
	public static int BinarySearch(T[] array, T value) { }

	[Address(RVA = "0x203CE90", Offset = "0x203C290", Length = "0x3BE")]
	[Token(Token = "0x6000CCF")]
	public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer) { }

	[Address(RVA = "0x203D250", Offset = "0x203C650", Length = "0x1A")]
	[Token(Token = "0x6000CCD")]
	public static int BinarySearch(Array array, int index, int length, object value) { }

	[Address(RVA = "0x203CCB0", Offset = "0x203C0B0", Length = "0xEA")]
	[Token(Token = "0x6000CBD")]
	public static int BinarySearch(Array array, object value) { }

	[Address(RVA = "0x769100", Offset = "0x768500", Length = "0x248")]
	[Token(Token = "0x6000CD4")]
	public static int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }

	[Address(RVA = "0x203D270", Offset = "0x203C670", Length = "0xF0")]
	[Token(Token = "0x6000D3A")]
	private static bool CanAssignArrayElement(Type source, Type target) { }

	[Address(RVA = "0x203D380", Offset = "0x203C780", Length = "0x185")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000D35")]
	public static void Clear(Array array, int index, int length) { }

	[Address(RVA = "0x203D370", Offset = "0x203C770", Length = "0x5")]
	[Token(Token = "0x6000D36")]
	private static void ClearInternal(Array a, int index, int count) { }

	[Address(RVA = "0x1F8FF70", Offset = "0x1F8F370", Length = "0x7")]
	[Token(Token = "0x6000CB8")]
	public override object Clone() { }

	[Address(RVA = "0xD0D290", Offset = "0xD0C690", Length = "0x6")]
	[Token(Token = "0x6000CBB")]
	internal static int CombineHashCodes(int h1, int h2) { }

	[Address(RVA = "0x203D510", Offset = "0x203C910", Length = "0xE")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000D3B")]
	public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) { }

	[Address(RVA = "0x87FD60", Offset = "0x87F160", Length = "0x169")]
	[Token(Token = "0x6000CBE")]
	public static TOutput[] ConvertAll(TInput[] array, Converter<TInput, TOutput> converter) { }

	[Address(RVA = "0x203D790", Offset = "0x203CB90", Length = "0x178")]
	[Token(Token = "0x6000CBF")]
	public static void Copy(Array sourceArray, Array destinationArray, long length) { }

	[Address(RVA = "0x203DA20", Offset = "0x203CE20", Length = "0x16B")]
	[Token(Token = "0x6000CC0")]
	public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length) { }

	[Address(RVA = "0x203D910", Offset = "0x203CD10", Length = "0x101")]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000D37")]
	public static void Copy(Array sourceArray, Array destinationArray, int length) { }

	[Address(RVA = "0x203DB90", Offset = "0x203CF90", Length = "0x608")]
	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	[Token(Token = "0x6000D38")]
	public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) { }

	[Address(RVA = "0x203D690", Offset = "0x203CA90", Length = "0xF9")]
	[Token(Token = "0x6000CB7")]
	public override void CopyTo(Array array, int index) { }

	[Address(RVA = "0x203D520", Offset = "0x203C920", Length = "0x16A")]
	[Token(Token = "0x6000CC1")]
	public void CopyTo(Array array, long index) { }

	[Address(RVA = "0x203E1A0", Offset = "0x203D5A0", Length = "0x44")]
	[Token(Token = "0x6000D39")]
	private static ArrayTypeMismatchException CreateArrayTypeMismatchException() { }

	[Address(RVA = "0x203E200", Offset = "0x203D600", Length = "0x6D")]
	[Token(Token = "0x6000D30")]
	public static Array CreateInstance(Type elementType, int length) { }

	[Address(RVA = "0x203EC00", Offset = "0x203E000", Length = "0x1C1")]
	[Token(Token = "0x6000CA9")]
	public static Array CreateInstance(Type elementType, Int64[] lengths) { }

	[Address(RVA = "0x203EB60", Offset = "0x203DF60", Length = "0x99")]
	[Token(Token = "0x6000D32")]
	public static Array CreateInstance(Type elementType, int length1, int length2, int length3) { }

	[Address(RVA = "0x203E620", Offset = "0x203DA20", Length = "0x538")]
	[Token(Token = "0x6000D34")]
	public static Array CreateInstance(Type elementType, Int32[] lengths, Int32[] lowerBounds) { }

	[Address(RVA = "0x203E300", Offset = "0x203D700", Length = "0x312")]
	[Token(Token = "0x6000D33")]
	public static Array CreateInstance(Type elementType, Int32[] lengths) { }

	[Address(RVA = "0x203E270", Offset = "0x203D670", Length = "0x83")]
	[Token(Token = "0x6000D31")]
	public static Array CreateInstance(Type elementType, int length1, int length2) { }

	[Address(RVA = "0x203E1F0", Offset = "0x203D5F0", Length = "0x5")]
	[Token(Token = "0x6000D25")]
	internal static Array CreateInstanceImpl(Type elementType, Int32[] lengths, Int32[] bounds) { }

	[Address(RVA = "0x5D49B0", Offset = "0x5D3DB0", Length = "0x75")]
	[Token(Token = "0x6000D3C")]
	public static T[] Empty() { }

	[Address(RVA = "0x880B50", Offset = "0x87FF50", Length = "0xBD")]
	[Token(Token = "0x6000CFA")]
	public static bool Exists(T[] array, Predicate<T> match) { }

	[Address(RVA = "0x203EDD0", Offset = "0x203E1D0", Length = "0x5")]
	[Token(Token = "0x6000D24")]
	internal static bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length) { }

	[Address(RVA = "0x8811E0", Offset = "0x8805E0", Length = "0x15D")]
	[Token(Token = "0x6000CFC")]
	public static void Fill(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0x8810B0", Offset = "0x8804B0", Length = "0xAF")]
	[Token(Token = "0x6000CFB")]
	public static void Fill(T[] array, T value) { }

	[Address(RVA = "0x8827D0", Offset = "0x881BD0", Length = "0x20C")]
	[Token(Token = "0x6000CFD")]
	public static T Find(T[] array, Predicate<T> match) { }

	[Address(RVA = "0x881340", Offset = "0x880740", Length = "0x30C")]
	[Token(Token = "0x6000CFE")]
	public static T[] FindAll(T[] array, Predicate<T> match) { }

	[Address(RVA = "0x881A10", Offset = "0x880E10", Length = "0x96")]
	[Token(Token = "0x6000CFF")]
	public static int FindIndex(T[] array, Predicate<T> match) { }

	[Address(RVA = "0x881960", Offset = "0x880D60", Length = "0xA6")]
	[Token(Token = "0x6000D00")]
	public static int FindIndex(T[] array, int startIndex, Predicate<T> match) { }

	[Address(RVA = "0x881AB0", Offset = "0x880EB0", Length = "0x1F1")]
	[Token(Token = "0x6000D01")]
	public static int FindIndex(T[] array, int startIndex, int count, Predicate<T> match) { }

	[Address(RVA = "0x882400", Offset = "0x881800", Length = "0x200")]
	[Token(Token = "0x6000D02")]
	public static T FindLast(T[] array, Predicate<T> match) { }

	[Address(RVA = "0x881FD0", Offset = "0x8813D0", Length = "0x9A")]
	[Token(Token = "0x6000D03")]
	public static int FindLastIndex(T[] array, Predicate<T> match) { }

	[Address(RVA = "0x882350", Offset = "0x881750", Length = "0xA3")]
	[Token(Token = "0x6000D04")]
	public static int FindLastIndex(T[] array, int startIndex, Predicate<T> match) { }

	[Address(RVA = "0x882070", Offset = "0x881470", Length = "0x2D3")]
	[Token(Token = "0x6000D05")]
	public static int FindLastIndex(T[] array, int startIndex, int count, Predicate<T> match) { }

	[Address(RVA = "0x8829E0", Offset = "0x881DE0", Length = "0x17C")]
	[Token(Token = "0x6000CC2")]
	public static void ForEach(T[] array, Action<T> action) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000CC9")]
	public override bool get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000CCA")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000CCB")]
	public override bool get_IsSynchronized() { }

	[Address(RVA = "0x203FD00", Offset = "0x203F100", Length = "0x5D")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000D1B")]
	public int get_Length() { }

	[Address(RVA = "0x2042260", Offset = "0x2041660", Length = "0x62")]
	[Token(Token = "0x6000CC3")]
	public long get_LongLength() { }

	[Address(RVA = "0x203EE80", Offset = "0x203E280", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000D1C")]
	public int get_Rank() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000CCC")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x203EDE0", Offset = "0x203E1E0", Length = "0x54")]
	[Token(Token = "0x6000D07")]
	public override IEnumerator GetEnumerator() { }

	[Token(Token = "0x6000D19")]
	internal void GetGenericValueImpl(int pos, out T value) { }

	[Address(RVA = "0x203EE40", Offset = "0x203E240", Length = "0x5")]
	[Token(Token = "0x6000D1E")]
	public int GetLength(int dimension) { }

	[Address(RVA = "0x203EE50", Offset = "0x203E250", Length = "0x10")]
	[Token(Token = "0x6000CC4")]
	public long GetLongLength(int dimension) { }

	[Address(RVA = "0x203EE60", Offset = "0x203E260", Length = "0x5")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000D1F")]
	public int GetLowerBound(int dimension) { }

	[Address(RVA = "0x203EE70", Offset = "0x203E270", Length = "0x8")]
	[Token(Token = "0x6000CD0")]
	private static int GetMedian(int low, int hi) { }

	[Address(RVA = "0x203EE80", Offset = "0x203E280", Length = "0x5")]
	[Token(Token = "0x6000D1D")]
	private int GetRank() { }

	[Address(RVA = "0x203EE90", Offset = "0x203E290", Length = "0x17")]
	[Token(Token = "0x6000D0B")]
	internal byte GetRawSzArrayData() { }

	[Address(RVA = "0x203EEB0", Offset = "0x203E2B0", Length = "0x39")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6000D26")]
	public int GetUpperBound(int dimension) { }

	[Address(RVA = "0x203F220", Offset = "0x203E620", Length = "0x91")]
	[Token(Token = "0x6000CC5")]
	public object GetValue(long index) { }

	[Address(RVA = "0x203F0B0", Offset = "0x203E4B0", Length = "0x15F")]
	[Token(Token = "0x6000CC6")]
	public object GetValue(long index1, long index2) { }

	[Address(RVA = "0x203F5C0", Offset = "0x203E9C0", Length = "0x1E5")]
	[Token(Token = "0x6000CC7")]
	public object GetValue(long index1, long index2, long index3) { }

	[Address(RVA = "0x203F2C0", Offset = "0x203E6C0", Length = "0x1C2")]
	[Token(Token = "0x6000CC8")]
	public object GetValue(Int64[] indices) { }

	[Address(RVA = "0x203F210", Offset = "0x203E610", Length = "0x5")]
	[Token(Token = "0x6000D20")]
	public object GetValue(Int32[] indices) { }

	[Address(RVA = "0x203EF00", Offset = "0x203E300", Length = "0x1AC")]
	[Token(Token = "0x6000D27")]
	public object GetValue(int index) { }

	[Address(RVA = "0x203F490", Offset = "0x203E890", Length = "0x80")]
	[Token(Token = "0x6000D28")]
	public object GetValue(int index1, int index2) { }

	[Address(RVA = "0x203F520", Offset = "0x203E920", Length = "0x96")]
	[Token(Token = "0x6000D29")]
	public object GetValue(int index1, int index2, int index3) { }

	[Address(RVA = "0x203EEF0", Offset = "0x203E2F0", Length = "0x5")]
	[Token(Token = "0x6000D22")]
	internal object GetValueImpl(int pos) { }

	[Address(RVA = "0x203F8A0", Offset = "0x203ECA0", Length = "0xE7")]
	[Token(Token = "0x6000CD5")]
	public static int IndexOf(Array array, object value) { }

	[Address(RVA = "0x9267B0", Offset = "0x925BB0", Length = "0x98")]
	[Token(Token = "0x6000CD8")]
	public static int IndexOf(T[] array, T value) { }

	[Address(RVA = "0x203F990", Offset = "0x203ED90", Length = "0x312")]
	[Token(Token = "0x6000CD7")]
	public static int IndexOf(Array array, object value, int startIndex, int count) { }

	[Address(RVA = "0x9248F0", Offset = "0x923CF0", Length = "0x183")]
	[Token(Token = "0x6000CDA")]
	public static int IndexOf(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0x926DA0", Offset = "0x9261A0", Length = "0x18D")]
	[Token(Token = "0x6000CD9")]
	public static int IndexOf(T[] array, T value, int startIndex) { }

	[Address(RVA = "0x203F7B0", Offset = "0x203EBB0", Length = "0xE8")]
	[Token(Token = "0x6000CD6")]
	public static int IndexOf(Array array, object value, int startIndex) { }

	[Address(RVA = "0x91F1C0", Offset = "0x91E5C0", Length = "0x18A")]
	[Token(Token = "0x6000D3E")]
	private static int IndexOfImpl(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000D3D")]
	public void Initialize() { }

	[Address(RVA = "0x6AE970", Offset = "0x6ADD70", Length = "0xA8")]
	[Token(Token = "0x6000D17")]
	internal T InternalArray__get_Item(int index) { }

	[Address(RVA = "0x6AE850", Offset = "0x6ADC50", Length = "0x49")]
	[Token(Token = "0x6000D0E")]
	internal void InternalArray__ICollection_Add(T item) { }

	[Address(RVA = "0x203FCB0", Offset = "0x203F0B0", Length = "0x4E")]
	[Token(Token = "0x6000D0D")]
	internal void InternalArray__ICollection_Clear() { }

	[Address(RVA = "0xA14D70", Offset = "0xA14170", Length = "0x13F")]
	[Token(Token = "0x6000D10")]
	internal bool InternalArray__ICollection_Contains(T item) { }

	[Address(RVA = "0x6AE7E0", Offset = "0x6ADBE0", Length = "0x65")]
	[Token(Token = "0x6000D11")]
	internal void InternalArray__ICollection_CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0x203FD00", Offset = "0x203F100", Length = "0x5D")]
	[Token(Token = "0x6000D09")]
	internal int InternalArray__ICollection_get_Count() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000D0A")]
	internal bool InternalArray__ICollection_get_IsReadOnly() { }

	[Address(RVA = "0x6AE850", Offset = "0x6ADC50", Length = "0x49")]
	[Token(Token = "0x6000D0F")]
	internal bool InternalArray__ICollection_Remove(T item) { }

	[Address(RVA = "0x6AE8A0", Offset = "0x6ADCA0", Length = "0xC6")]
	[Token(Token = "0x6000D0C")]
	internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator() { }

	[Address(RVA = "0x6B2700", Offset = "0x6B1B00", Length = "0x157")]
	[Token(Token = "0x6000D16")]
	internal int InternalArray__IndexOf(T item) { }

	[Address(RVA = "0x6EB3E0", Offset = "0x6EA7E0", Length = "0x49")]
	[Token(Token = "0x6000D14")]
	internal void InternalArray__Insert(int index, T item) { }

	[Address(RVA = "0x203FD00", Offset = "0x203F100", Length = "0x5D")]
	[Token(Token = "0x6000D13")]
	internal int InternalArray__IReadOnlyCollection_get_Count() { }

	[Address(RVA = "0x6AE970", Offset = "0x6ADD70", Length = "0xA8")]
	[Token(Token = "0x6000D12")]
	internal T InternalArray__IReadOnlyList_get_Item(int index) { }

	[Address(RVA = "0x203FD60", Offset = "0x203F160", Length = "0x4E")]
	[Token(Token = "0x6000D15")]
	internal void InternalArray__RemoveAt(int index) { }

	[Address(RVA = "0x6EB430", Offset = "0x6EA830", Length = "0x13D")]
	[Token(Token = "0x6000D18")]
	internal void InternalArray__set_Item(int index, T item) { }

	[Address(RVA = "0x203FF50", Offset = "0x203F350", Length = "0x39F")]
	[Token(Token = "0x6000CDD")]
	public static int LastIndexOf(Array array, object value, int startIndex, int count) { }

	[Address(RVA = "0x203FED0", Offset = "0x203F2D0", Length = "0x72")]
	[Token(Token = "0x6000CDC")]
	public static int LastIndexOf(Array array, object value, int startIndex) { }

	[Address(RVA = "0x6F9010", Offset = "0x6F8410", Length = "0x9B")]
	[Token(Token = "0x6000CDE")]
	public static int LastIndexOf(T[] array, T value) { }

	[Address(RVA = "0x6F80C0", Offset = "0x6F74C0", Length = "0xB9")]
	[Token(Token = "0x6000CDF")]
	public static int LastIndexOf(T[] array, T value, int startIndex) { }

	[Address(RVA = "0x6F8180", Offset = "0x6F7580", Length = "0x247")]
	[Token(Token = "0x6000CE0")]
	public static int LastIndexOf(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0x203FDB0", Offset = "0x203F1B0", Length = "0x119")]
	[Token(Token = "0x6000CDB")]
	public static int LastIndexOf(Array array, object value) { }

	[Address(RVA = "0x6F4F20", Offset = "0x6F4320", Length = "0x18A")]
	[Token(Token = "0x6000D3F")]
	private static int LastIndexOfImpl(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0x6F9A50", Offset = "0x6F8E50", Length = "0x129")]
	[Token(Token = "0x6000CAB")]
	public static void Resize(ref T[] array, int newSize) { }

	[Address(RVA = "0x20402F0", Offset = "0x203F6F0", Length = "0xC9")]
	[Token(Token = "0x6000CE1")]
	public static void Reverse(Array array) { }

	[Address(RVA = "0x6FA760", Offset = "0x6F9B60", Length = "0x102")]
	[Token(Token = "0x6000CE3")]
	public static void Reverse(T[] array) { }

	[Address(RVA = "0x6F9CE0", Offset = "0x6F90E0", Length = "0x17C")]
	[Token(Token = "0x6000CE4")]
	public static void Reverse(T[] array, int index, int length) { }

	[Address(RVA = "0x20403C0", Offset = "0x203F7C0", Length = "0x264")]
	[Token(Token = "0x6000CE2")]
	public static void Reverse(Array array, int index, int length) { }

	[Token(Token = "0x6000D1A")]
	internal void SetGenericValueImpl(int pos, ref T value) { }

	[Address(RVA = "0x2040A10", Offset = "0x203FE10", Length = "0x1FD")]
	[Token(Token = "0x6000CE7")]
	public void SetValue(object value, long index1, long index2, long index3) { }

	[Address(RVA = "0x20406E0", Offset = "0x203FAE0", Length = "0x1DA")]
	[Token(Token = "0x6000CE8")]
	public void SetValue(object value, Int64[] indices) { }

	[Address(RVA = "0x2040640", Offset = "0x203FA40", Length = "0x9F")]
	[Token(Token = "0x6000D2C")]
	public void SetValue(object value, int index1, int index2, int index3) { }

	[Address(RVA = "0x20408C0", Offset = "0x203FCC0", Length = "0x91")]
	[Token(Token = "0x6000D2B")]
	public void SetValue(object value, int index1, int index2) { }

	[Address(RVA = "0x2040C10", Offset = "0x2040010", Length = "0x1C0")]
	[Token(Token = "0x6000D2A")]
	public void SetValue(object value, int index) { }

	[Address(RVA = "0x2040960", Offset = "0x203FD60", Length = "0x5")]
	[Token(Token = "0x6000D21")]
	public void SetValue(object value, Int32[] indices) { }

	[Address(RVA = "0x2040DE0", Offset = "0x20401E0", Length = "0x173")]
	[Token(Token = "0x6000CE6")]
	public void SetValue(object value, long index1, long index2) { }

	[Address(RVA = "0x2040970", Offset = "0x203FD70", Length = "0x91")]
	[Token(Token = "0x6000CE5")]
	public void SetValue(object value, long index) { }

	[Address(RVA = "0x2040630", Offset = "0x203FA30", Length = "0x5")]
	[Token(Token = "0x6000D23")]
	internal void SetValueImpl(object value, int pos) { }

	[Address(RVA = "0x708DD0", Offset = "0x7081D0", Length = "0xA0")]
	[Token(Token = "0x6000CF6")]
	public static void Sort(TKey[] keys, TValue[] items) { }

	[Address(RVA = "0x72D040", Offset = "0x72C440", Length = "0x27C")]
	[Token(Token = "0x6000CF9")]
	public static void Sort(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer) { }

	[Address(RVA = "0x2041500", Offset = "0x2040900", Length = "0xD6")]
	[Token(Token = "0x6000CE9")]
	public static void Sort(Array array) { }

	[Address(RVA = "0x20415E0", Offset = "0x20409E0", Length = "0xEB")]
	[Token(Token = "0x6000CEB")]
	public static void Sort(Array array, IComparer comparer) { }

	[Address(RVA = "0x20416D0", Offset = "0x2040AD0", Length = "0x24")]
	[Token(Token = "0x6000CEC")]
	public static void Sort(Array array, int index, int length, IComparer comparer) { }

	[Address(RVA = "0x2041700", Offset = "0x2040B00", Length = "0xEA")]
	[Token(Token = "0x6000CED")]
	public static void Sort(Array keys, Array items) { }

	[Address(RVA = "0x20413E0", Offset = "0x20407E0", Length = "0xEA")]
	[Token(Token = "0x6000CEE")]
	public static void Sort(Array keys, Array items, IComparer comparer) { }

	[Address(RVA = "0x20413C0", Offset = "0x20407C0", Length = "0x1A")]
	[Token(Token = "0x6000CEF")]
	public static void Sort(Array keys, Array items, int index, int length) { }

	[Address(RVA = "0x2041080", Offset = "0x2040480", Length = "0x33E")]
	[Token(Token = "0x6000CF0")]
	public static void Sort(Array keys, Array items, int index, int length, IComparer comparer) { }

	[Address(RVA = "0x20414D0", Offset = "0x20408D0", Length = "0x22")]
	[Token(Token = "0x6000CEA")]
	public static void Sort(Array array, int index, int length) { }

	[Address(RVA = "0x712F80", Offset = "0x712380", Length = "0x60")]
	[Token(Token = "0x6000CF2")]
	public static void Sort(T[] array, int index, int length) { }

	[Address(RVA = "0x708E80", Offset = "0x708280", Length = "0x96")]
	[Token(Token = "0x6000CF3")]
	public static void Sort(T[] array, IComparer<T> comparer) { }

	[Address(RVA = "0x702140", Offset = "0x701540", Length = "0x22C")]
	[Token(Token = "0x6000CF4")]
	public static void Sort(T[] array, int index, int length, IComparer<T> comparer) { }

	[Address(RVA = "0x7132B0", Offset = "0x7126B0", Length = "0x106")]
	[Token(Token = "0x6000CF5")]
	public static void Sort(T[] array, Comparison<T> comparison) { }

	[Address(RVA = "0x72C950", Offset = "0x72BD50", Length = "0x7C")]
	[Token(Token = "0x6000CF7")]
	public static void Sort(TKey[] keys, TValue[] items, int index, int length) { }

	[Address(RVA = "0x7141F0", Offset = "0x7135F0", Length = "0x89")]
	[Token(Token = "0x6000CF1")]
	public static void Sort(T[] array) { }

	[Address(RVA = "0x712ED0", Offset = "0x7122D0", Length = "0xA9")]
	[Token(Token = "0x6000CF8")]
	public static void Sort(TKey[] keys, TValue[] items, IComparer<TKey> comparer) { }

	[Address(RVA = "0x2040F60", Offset = "0x2040360", Length = "0x111")]
	[Token(Token = "0x6000D40")]
	private static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer) { }

	[Address(RVA = "0x203FD00", Offset = "0x203F100", Length = "0x5D")]
	[Token(Token = "0x6000CAC")]
	private override int System.Collections.ICollection.get_Count() { }

	[Address(RVA = "0x20417F0", Offset = "0x2040BF0", Length = "0x4E")]
	[Token(Token = "0x6000CB0")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x2041840", Offset = "0x2040C40", Length = "0x1D0")]
	[Token(Token = "0x6000CB2")]
	private override void System.Collections.IList.Clear() { }

	[Address(RVA = "0x2041A20", Offset = "0x2040E20", Length = "0xEC")]
	[Token(Token = "0x6000CB1")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000CAD")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0x2041C00", Offset = "0x2041000", Length = "0x8")]
	[Token(Token = "0x6000CAE")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x203F8A0", Offset = "0x203ECA0", Length = "0xE7")]
	[Token(Token = "0x6000CB3")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x2041B10", Offset = "0x2040F10", Length = "0x4E")]
	[Token(Token = "0x6000CB4")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x2041BB0", Offset = "0x2040FB0", Length = "0x4E")]
	[Token(Token = "0x6000CB5")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x2041B60", Offset = "0x2040F60", Length = "0x4E")]
	[Token(Token = "0x6000CB6")]
	private override void System.Collections.IList.RemoveAt(int index) { }

	[Address(RVA = "0x2041C10", Offset = "0x2041010", Length = "0x11")]
	[Token(Token = "0x6000CAF")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

	[Address(RVA = "0x2041C30", Offset = "0x2041030", Length = "0x240")]
	[Token(Token = "0x6000CB9")]
	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	[Address(RVA = "0x2041E80", Offset = "0x2041280", Length = "0x1CE")]
	[Token(Token = "0x6000CBA")]
	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	[Address(RVA = "0x2042050", Offset = "0x2041450", Length = "0x1EF")]
	[Token(Token = "0x6000CBC")]
	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	[Address(RVA = "0x732AE0", Offset = "0x731EE0", Length = "0x194")]
	[Token(Token = "0x6000D06")]
	public static bool TrueForAll(T[] array, Predicate<T> match) { }

	[Address(RVA = "0x2042250", Offset = "0x2041650", Length = "0x8")]
	[Token(Token = "0x6000D2F")]
	internal static Array UnsafeCreateInstance(Type elementType, Int32[] lengths) { }

	[Address(RVA = "0x203E270", Offset = "0x203D670", Length = "0x83")]
	[Token(Token = "0x6000D2E")]
	internal static Array UnsafeCreateInstance(Type elementType, int length1, int length2) { }

	[Address(RVA = "0x2042240", Offset = "0x2041640", Length = "0x8")]
	[Token(Token = "0x6000D2D")]
	internal static Array UnsafeCreateInstance(Type elementType, Int32[] lengths, Int32[] lowerBounds) { }

	[Address(RVA = "0x732D50", Offset = "0x732150", Length = "0x26")]
	[Token(Token = "0x6000D41")]
	internal static T UnsafeLoad(T[] array, int index) { }

	[Address(RVA = "0x732D80", Offset = "0x732180", Length = "0x4")]
	[Token(Token = "0x6000D43")]
	internal static R UnsafeMov(S instance) { }

	[Address(RVA = "0x732E40", Offset = "0x732240", Length = "0x110")]
	[Token(Token = "0x6000D42")]
	internal static void UnsafeStore(T[] array, int index, T value) { }

}

