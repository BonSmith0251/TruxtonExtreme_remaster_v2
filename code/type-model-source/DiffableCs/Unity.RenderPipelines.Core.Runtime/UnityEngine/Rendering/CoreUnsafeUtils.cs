namespace UnityEngine.Rendering;

[Extension]
[Token(Token = "0x2000038")]
public static class CoreUnsafeUtils
{
	[Token(Token = "0x200003B")]
	public struct DefaultKeyGetter : IKeyGetter<T, T>
	{

		[Address(RVA = "0xF59F40", Offset = "0xF59340", Length = "0xB")]
		[Token(Token = "0x60004AA")]
		public override T Get(ref T v) { }

	}

	[Token(Token = "0x2000039")]
	internal struct FixedBufferStringQueue
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CD")]
		private Byte* m_ReadCursor; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000CE")]
		private Byte* m_WriteCursor; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CF")]
		private readonly Byte* m_BufferEnd; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000D0")]
		private readonly Byte* m_BufferStart; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000D1")]
		private readonly int m_BufferLength; //Field offset: 0x20
		[CompilerGenerated]
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40000D2")]
		private int <Count>k__BackingField; //Field offset: 0x24

		[Token(Token = "0x1700002F")]
		public private int Count
		{
			[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60004A3")]
			 get { } //Length: 4
			[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60004A4")]
			private set { } //Length: 4
		}

		[Address(RVA = "0x2BC0F50", Offset = "0x2BC0350", Length = "0x31")]
		[Token(Token = "0x60004A5")]
		public FixedBufferStringQueue(Byte* ptr, int length) { }

		[Address(RVA = "0x2BC0DB0", Offset = "0x2BC01B0", Length = "0x21")]
		[Token(Token = "0x60004A8")]
		public void Clear() { }

		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60004A3")]
		public int get_Count() { }

		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60004A4")]
		private void set_Count(int value) { }

		[Address(RVA = "0x2BC0DE0", Offset = "0x2BC01E0", Length = "0xB2")]
		[Token(Token = "0x60004A7")]
		public bool TryPop(out string v) { }

		[Address(RVA = "0x2BC0EA0", Offset = "0x2BC02A0", Length = "0xAA")]
		[Token(Token = "0x60004A6")]
		public bool TryPush(string v) { }

	}

	[Token(Token = "0x200003A")]
	internal interface IKeyGetter
	{

		[Token(Token = "0x60004A9")]
		public TKey Get(ref TValue v) { }

	}

	[Token(Token = "0x200003C")]
	public struct UintKeyGetter : IKeyGetter<UInt32, UInt32>
	{

		[Address(RVA = "0x17D3A70", Offset = "0x17D2E70", Length = "0x3")]
		[Token(Token = "0x60004AB")]
		public override uint Get(ref uint v) { }

	}

	[Token(Token = "0x200003D")]
	public struct UlongKeyGetter : IKeyGetter<UInt64, UInt64>
	{

		[Address(RVA = "0x2BC5B40", Offset = "0x2BC4F40", Length = "0x4")]
		[Token(Token = "0x60004AC")]
		public override ulong Get(ref ulong v) { }

	}


	[Address(RVA = "0x2BBE000", Offset = "0x2BBD400", Length = "0xA")]
	[Token(Token = "0x600048B")]
	private static void CalculateRadixParams(int radixBits, out int bitStates) { }

	[Address(RVA = "0x2BBE010", Offset = "0x2BBD410", Length = "0x35")]
	[Token(Token = "0x600048D")]
	private static void CalculateRadixSortSupportArrays(int bitStates, int arrayLength, UInt32* supportArray, out UInt32* bucketIndices, out UInt32* bucketSizes, out UInt32* bucketPrefix, out UInt32* arrayOutput) { }

	[Address(RVA = "0x2BBE050", Offset = "0x2BBD450", Length = "0x6")]
	[Token(Token = "0x600048C")]
	private static int CalculateRadixSupportSize(int bitStates, int arrayLength) { }

	[Address(RVA = "0x2BBE060", Offset = "0x2BBD460", Length = "0x56")]
	[Token(Token = "0x60004A0")]
	public static void CombineHashes(int count, Hash128* hashes, Hash128* outHash) { }

	[Address(RVA = "0x7B60F0", Offset = "0x7B54F0", Length = "0xBE")]
	[Token(Token = "0x600049F")]
	public static void CombineHashes(int count, Void* hashes, Hash128* outHash) { }

	[Address(RVA = "0x2BBE0C0", Offset = "0x2BBD4C0", Length = "0x6E")]
	[Token(Token = "0x600049E")]
	public static int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, Int32* addIndices, Int32* removeIndices, out int addCount, out int remCount) { }

	[Address(RVA = "0x7B6420", Offset = "0x7B5820", Length = "0x427")]
	[Token(Token = "0x600049D")]
	public static int CompareHashes(int oldHashCount, Void* oldHashes, int newHashCount, Void* newHashes, Int32* addIndices, Int32* removeIndices, out int addCount, out int remCount) { }

	[Address(RVA = "0x7B7070", Offset = "0x7B6470", Length = "0x12C")]
	[Extension]
	[Token(Token = "0x6000489")]
	public static void CopyTo(List<T> list, Void* dest, int count) { }

	[Address(RVA = "0x7B72C0", Offset = "0x7B66C0", Length = "0x7A")]
	[Extension]
	[Token(Token = "0x600048A")]
	public static void CopyTo(T[] list, Void* dest, int count) { }

	[Address(RVA = "0x2BBE130", Offset = "0x2BBD530", Length = "0x118")]
	[Token(Token = "0x60004A2")]
	public static bool HaveDuplicates(Int32[] arr) { }

	[Address(RVA = "0x7B7340", Offset = "0x7B6740", Length = "0x1F4")]
	[Token(Token = "0x600049C")]
	public static int IndexOf(Void* data, int count, T v) { }

	[Address(RVA = "0x2BBE250", Offset = "0x2BBD650", Length = "0xE4")]
	[Token(Token = "0x6000493")]
	public static void InsertionSort(NativeArray<UInt32> arr, int sortSize) { }

	[Address(RVA = "0x2BBE340", Offset = "0x2BBD740", Length = "0x48")]
	[Token(Token = "0x6000491")]
	private static void InsertionSort(UInt32* arr, int length) { }

	[Address(RVA = "0x2BBE390", Offset = "0x2BBD790", Length = "0xCF")]
	[Token(Token = "0x6000492")]
	public static void InsertionSort(UInt32[] arr, int sortSize) { }

	[Address(RVA = "0x2BBE460", Offset = "0x2BBD860", Length = "0xF8")]
	[Token(Token = "0x6000490")]
	public static void MergeSort(NativeArray<UInt32> arr, int sortSize, ref NativeArray<UInt32>& supportArray) { }

	[Address(RVA = "0x2BBE710", Offset = "0x2BBDB10", Length = "0xE5")]
	[Token(Token = "0x600048F")]
	public static void MergeSort(UInt32[] arr, int sortSize, ref UInt32[] supportArray) { }

	[Address(RVA = "0x2BBE560", Offset = "0x2BBD960", Length = "0x1A2")]
	[Token(Token = "0x600048E")]
	private static void MergeSort(UInt32* array, UInt32* support, int length) { }

	[Address(RVA = "0x7B7D90", Offset = "0x7B7190", Length = "0x13D")]
	[Token(Token = "0x60004A1")]
	private static int Partition(Void* data, int left, int right) { }

	[Address(RVA = "0x2BBE870", Offset = "0x2BBDC70", Length = "0x6D")]
	[Token(Token = "0x6000497")]
	public static void QuickSort(UInt32[] arr, int left, int right) { }

	[Address(RVA = "0x2BBE800", Offset = "0x2BBDC00", Length = "0x6D")]
	[Token(Token = "0x6000498")]
	public static void QuickSort(UInt64[] arr, int left, int right) { }

	[Address(RVA = "0x7B8430", Offset = "0x7B7830", Length = "0x4A")]
	[Token(Token = "0x6000499")]
	public static void QuickSort(int count, Void* data) { }

	[Address(RVA = "0x7B8170", Offset = "0x7B7570", Length = "0x4B")]
	[Token(Token = "0x600049A")]
	public static void QuickSort(int count, Void* data) { }

	[Address(RVA = "0x7B8270", Offset = "0x7B7670", Length = "0x1B9")]
	[Token(Token = "0x600049B")]
	public static void QuickSort(Void* data, int left, int right) { }

	[Address(RVA = "0x2BBE8E0", Offset = "0x2BBDCE0", Length = "0x1BD")]
	[Token(Token = "0x6000494")]
	private static void RadixSort(UInt32* array, UInt32* support, int radixBits, int bitStates, int length) { }

	[Address(RVA = "0x2BBEBC0", Offset = "0x2BBDFC0", Length = "0x12B")]
	[Token(Token = "0x6000496")]
	public static void RadixSort(NativeArray<UInt32> array, int sortSize, ref NativeArray<UInt32>& supportArray, int radixBits = 8) { }

	[Address(RVA = "0x2BBEAA0", Offset = "0x2BBDEA0", Length = "0x11A")]
	[Token(Token = "0x6000495")]
	public static void RadixSort(UInt32[] arr, int sortSize, ref UInt32[] supportArray, int radixBits = 8) { }

}

