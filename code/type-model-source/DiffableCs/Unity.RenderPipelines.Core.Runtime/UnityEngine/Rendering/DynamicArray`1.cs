namespace UnityEngine.Rendering;

[DebuggerDisplay("Size = {size} Capacity = {capacity}")]
[DefaultMember("Item")]
[Token(Token = "0x200003E")]
public class DynamicArray
{
	[Token(Token = "0x200003F")]
	internal struct Iterator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D5")]
		private readonly DynamicArray<T> owner; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D6")]
		private int index; //Field offset: 0x0

		[Token(Token = "0x17000033")]
		public T Current
		{
			[Address(RVA = "0xABF020", Offset = "0xABE420", Length = "0x4E")]
			[Token(Token = "0x60004CC")]
			 get { } //Length: 78
		}

		[Address(RVA = "0xABED90", Offset = "0xABE190", Length = "0x1E")]
		[Token(Token = "0x60004CB")]
		public Iterator(DynamicArray<T> setOwner) { }

		[Address(RVA = "0xABF020", Offset = "0xABE420", Length = "0x4E")]
		[Token(Token = "0x60004CC")]
		public T get_Current() { }

		[Address(RVA = "0xABECA0", Offset = "0xABE0A0", Length = "0x42")]
		[Token(Token = "0x60004CD")]
		public bool MoveNext() { }

		[Address(RVA = "0xABED80", Offset = "0xABE180", Length = "0x8")]
		[Token(Token = "0x60004CE")]
		public void Reset() { }

	}

	[Token(Token = "0x2000040")]
	internal struct RangeEnumerable
	{
		[Token(Token = "0x2000041")]
		internal struct RangeIterator
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000D8")]
			private readonly DynamicArray<T> owner; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000D9")]
			private int index; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000DA")]
			private int first; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40000DB")]
			private int last; //Field offset: 0x0

			[Token(Token = "0x17000034")]
			public T Current
			{
				[Address(RVA = "0xABF020", Offset = "0xABE420", Length = "0x4E")]
				[Token(Token = "0x60004D1")]
				 get { } //Length: 78
			}

			[Address(RVA = "0xE9A5D0", Offset = "0xE999D0", Length = "0x3F")]
			[Token(Token = "0x60004D0")]
			public RangeIterator(DynamicArray<T> setOwner, int first, int numItems) { }

			[Address(RVA = "0xABF020", Offset = "0xABE420", Length = "0x4E")]
			[Token(Token = "0x60004D1")]
			public T get_Current() { }

			[Address(RVA = "0xE9A5B0", Offset = "0xE999B0", Length = "0xF")]
			[Token(Token = "0x60004D2")]
			public bool MoveNext() { }

			[Address(RVA = "0xE9A5C0", Offset = "0xE999C0", Length = "0x9")]
			[Token(Token = "0x60004D3")]
			public void Reset() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000D7")]
		public RangeIterator<T> iterator; //Field offset: 0x0

		[Address(RVA = "0xAEF030", Offset = "0xAEE430", Length = "0x14")]
		[Token(Token = "0x60004CF")]
		public RangeIterator<T> GetEnumerator() { }

	}

	[Token(Token = "0x2000042")]
	internal sealed class SortComparer : MulticastDelegate
	{

		[Address(RVA = "0xF647A0", Offset = "0xF63BA0", Length = "0xA6")]
		[Token(Token = "0x60004D4")]
		public SortComparer(object object, IntPtr method) { }

		[Address(RVA = "0xF64560", Offset = "0xF63960", Length = "0x9D")]
		[Token(Token = "0x60004D6")]
		public override IAsyncResult BeginInvoke(T x, T y, AsyncCallback callback, object object) { }

		[Address(RVA = "0xF64600", Offset = "0xF63A00", Length = "0x27")]
		[Token(Token = "0x60004D7")]
		public override int EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0xF64630", Offset = "0xF63A30", Length = "0x32")]
		[Token(Token = "0x60004D5")]
		public override int Invoke(T x, T y) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D3")]
	protected T[] m_Array; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D4")]
	private int <size>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000031")]
	public int capacity
	{
		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x60004AF")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000032")]
	public T Item
	{
		[Address(RVA = "0x1944830", Offset = "0x1943C30", Length = "0x31")]
		[Token(Token = "0x60004C4")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000030")]
	public int size
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60004AD")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60004AE")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1944270", Offset = "0x1943670", Length = "0x66")]
	[Token(Token = "0x60004B0")]
	public DynamicArray`1() { }

	[Address(RVA = "0x1944420", Offset = "0x1943820", Length = "0x6B")]
	[Token(Token = "0x60004B1")]
	public DynamicArray`1(int size) { }

	[Address(RVA = "0x1944490", Offset = "0x1943890", Length = "0x81")]
	[Token(Token = "0x60004B2")]
	public DynamicArray`1(int capacity, bool resize) { }

	[Address(RVA = "0x19442E0", Offset = "0x19436E0", Length = "0x97")]
	[Token(Token = "0x60004B3")]
	public DynamicArray`1(DynamicArray<T> deepCopy) { }

	[Address(RVA = "0x193F020", Offset = "0x193E420", Length = "0x13B")]
	[Token(Token = "0x60004B6")]
	public int Add(in T value) { }

	[Address(RVA = "0x193DB40", Offset = "0x193CF40", Length = "0x140")]
	[Token(Token = "0x60004B7")]
	public void AddRange(DynamicArray<T> array) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60004CA")]
	protected private void BumpVersion() { }

	[Address(RVA = "0x5C4B80", Offset = "0x5C3F80", Length = "0x8")]
	[Token(Token = "0x60004B4")]
	public void Clear() { }

	[Address(RVA = "0x193F390", Offset = "0x193E790", Length = "0x30")]
	[Token(Token = "0x60004B5")]
	public bool Contains(T item) { }

	[Address(RVA = "0x193F870", Offset = "0x193EC70", Length = "0xA1")]
	[Token(Token = "0x60004BD")]
	public int FindIndex(Predicate<T> match) { }

	[Address(RVA = "0x193FDE0", Offset = "0x193F1E0", Length = "0xA6")]
	[Token(Token = "0x60004BC")]
	public int FindIndex(int startIndex, int count, Predicate<T> match) { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x60004AF")]
	public int get_capacity() { }

	[Address(RVA = "0x1944830", Offset = "0x1943C30", Length = "0x31")]
	[Token(Token = "0x60004C4")]
	public T get_Item(int index) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60004AD")]
	public int get_size() { }

	[Address(RVA = "0x1940310", Offset = "0x193F710", Length = "0x2F")]
	[Token(Token = "0x60004C8")]
	public Iterator<T> GetEnumerator() { }

	[Address(RVA = "0x1940D10", Offset = "0x1940110", Length = "0x114")]
	[Token(Token = "0x60004BE")]
	public int IndexOf(T item, int index, int count) { }

	[Address(RVA = "0x1940900", Offset = "0x193FD00", Length = "0x109")]
	[Token(Token = "0x60004BF")]
	public int IndexOf(T item, int index) { }

	[Address(RVA = "0x19405B0", Offset = "0x193F9B0", Length = "0x117")]
	[Token(Token = "0x60004C0")]
	public int IndexOf(T item) { }

	[Address(RVA = "0x1943550", Offset = "0x1942950", Length = "0x246")]
	[Token(Token = "0x60004B8")]
	public void Insert(int index, T item) { }

	[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
	[Obsolete("This is deprecated because it returns an incorrect value. It may returns an array with elements beyond the size. Please use Span/ReadOnly if you want safe raw access to the DynamicArray memory. #from(2023.2)")]
	[Token(Token = "0x60004C5")]
	public static T[] op_Implicit(DynamicArray<T> array) { }

	[Address(RVA = "0x1944A50", Offset = "0x1943E50", Length = "0x9E")]
	[Token(Token = "0x60004C6")]
	public static ReadOnlySpan<T> op_Implicit(DynamicArray<T> array) { }

	[Address(RVA = "0x1944A50", Offset = "0x1943E50", Length = "0x9E")]
	[Token(Token = "0x60004C7")]
	public static Span<T> op_Implicit(DynamicArray<T> array) { }

	[Address(RVA = "0x1943AF0", Offset = "0x1942EF0", Length = "0x74")]
	[Token(Token = "0x60004B9")]
	public bool Remove(T item) { }

	[Address(RVA = "0x19437A0", Offset = "0x1942BA0", Length = "0x40")]
	[Token(Token = "0x60004BA")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0x19438D0", Offset = "0x1942CD0", Length = "0x49")]
	[Token(Token = "0x60004BB")]
	public void RemoveRange(int index, int count) { }

	[Address(RVA = "0x1943F30", Offset = "0x1943330", Length = "0xC4")]
	[Token(Token = "0x60004C3")]
	public void Reserve(int newCapacity, bool keepContent = false) { }

	[Address(RVA = "0x1944140", Offset = "0x1943540", Length = "0x31")]
	[Token(Token = "0x60004C1")]
	public void Resize(int newSize, bool keepContent = false) { }

	[Address(RVA = "0x1944000", Offset = "0x1943400", Length = "0x94")]
	[Token(Token = "0x60004C2")]
	public void ResizeAndClear(int newSize) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60004AE")]
	protected void set_size(int value) { }

	[Address(RVA = "0x19441F0", Offset = "0x19435F0", Length = "0x74")]
	[Token(Token = "0x60004C9")]
	public RangeEnumerable<T> SubRange(int first, int numItems) { }

}

