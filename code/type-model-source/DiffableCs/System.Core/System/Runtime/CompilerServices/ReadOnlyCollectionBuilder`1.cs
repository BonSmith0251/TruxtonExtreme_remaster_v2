namespace System.Runtime.CompilerServices;

[DefaultMember("Item")]
[Token(Token = "0x2000251")]
public sealed class ReadOnlyCollectionBuilder : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection
{
	[Token(Token = "0x2000252")]
	private class Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400042A")]
		private readonly ReadOnlyCollectionBuilder<T> _builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400042B")]
		private readonly int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400042C")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400042D")]
		private T _current; //Field offset: 0x0

		[Token(Token = "0x17000256")]
		public override T Current
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x6000B72")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000257")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x198F700", Offset = "0x198EB00", Length = "0x42")]
			[Token(Token = "0x6000B74")]
			private get { } //Length: 66
		}

		[Address(RVA = "0x1991320", Offset = "0x1990720", Length = "0x4F")]
		[Token(Token = "0x6000B71")]
		internal Enumerator(ReadOnlyCollectionBuilder<T> builder) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000B73")]
		public override void Dispose() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000B72")]
		public override T get_Current() { }

		[Address(RVA = "0x198DD70", Offset = "0x198D170", Length = "0x94")]
		[Token(Token = "0x6000B75")]
		public override bool MoveNext() { }

		[Address(RVA = "0x198F700", Offset = "0x198EB00", Length = "0x42")]
		[Token(Token = "0x6000B74")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x198F460", Offset = "0x198E860", Length = "0x45")]
		[Token(Token = "0x6000B76")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000427")]
	private T[] _items; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000428")]
	private int _size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000429")]
	private int _version; //Field offset: 0x0

	[Token(Token = "0x1700024D")]
	public int Capacity
	{
		[Address(RVA = "0xEAA3B0", Offset = "0xEA97B0", Length = "0x108")]
		[Token(Token = "0x6000B51")]
		 set { } //Length: 264
	}

	[Token(Token = "0x1700024E")]
	public override int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000B52")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700024F")]
	public override T Item
	{
		[Address(RVA = "0xEAA230", Offset = "0xEA9630", Length = "0x7B")]
		[Token(Token = "0x6000B56")]
		 get { } //Length: 123
		[Address(RVA = "0xEAA740", Offset = "0xEA9B40", Length = "0x95")]
		[Token(Token = "0x6000B57")]
		 set { } //Length: 149
	}

	[Token(Token = "0x17000250")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000B5C")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000254")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000B6A")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000255")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6000B6B")]
		private get { } //Length: 4
	}

	[Token(Token = "0x17000252")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000B65")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000251")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000B60")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000253")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0xEA98E0", Offset = "0xEA8CE0", Length = "0x8A")]
		[Token(Token = "0x6000B67")]
		private get { } //Length: 138
		[Address(RVA = "0xEA9C00", Offset = "0xEA9000", Length = "0x187")]
		[Token(Token = "0x6000B68")]
		private set { } //Length: 391
	}

	[Address(RVA = "0xE82230", Offset = "0xE81630", Length = "0x44")]
	[Token(Token = "0x6000B4F")]
	public ReadOnlyCollectionBuilder`1() { }

	[Address(RVA = "0xEAA180", Offset = "0xEA9580", Length = "0xA7")]
	[Token(Token = "0x6000B50")]
	public ReadOnlyCollectionBuilder`1(int capacity) { }

	[Address(RVA = "0xEA7730", Offset = "0xEA6B30", Length = "0x80")]
	[Token(Token = "0x6000B58")]
	public override void Add(T item) { }

	[Address(RVA = "0xCF5010", Offset = "0xCF4410", Length = "0x31")]
	[Token(Token = "0x6000B59")]
	public override void Clear() { }

	[Address(RVA = "0xEA77C0", Offset = "0xEA6BC0", Length = "0x1FA")]
	[Token(Token = "0x6000B5A")]
	public override bool Contains(T item) { }

	[Address(RVA = "0xB106F0", Offset = "0xB0FAF0", Length = "0x2A")]
	[Token(Token = "0x6000B5B")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0xEA7BF0", Offset = "0xEA6FF0", Length = "0x135")]
	[Token(Token = "0x6000B6E")]
	private void EnsureCapacity(int min) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000B52")]
	public override int get_Count() { }

	[Address(RVA = "0xEAA230", Offset = "0xEA9630", Length = "0x7B")]
	[Token(Token = "0x6000B56")]
	public override T get_Item(int index) { }

	[Address(RVA = "0xEA7D90", Offset = "0xEA7190", Length = "0x6D")]
	[Token(Token = "0x6000B5E")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0xEA7F80", Offset = "0xEA7380", Length = "0x2D")]
	[Token(Token = "0x6000B53")]
	public override int IndexOf(T item) { }

	[Address(RVA = "0xEA7FB0", Offset = "0xEA73B0", Length = "0x106")]
	[Token(Token = "0x6000B54")]
	public override void Insert(int index, T item) { }

	[Address(RVA = "0xEA83E0", Offset = "0xEA77E0", Length = "0x5E")]
	[Token(Token = "0x6000B6F")]
	private static bool IsCompatibleObject(object value) { }

	[Address(RVA = "0xEA86D0", Offset = "0xEA7AD0", Length = "0x115")]
	[Token(Token = "0x6000B5D")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xEA8440", Offset = "0xEA7840", Length = "0xBF")]
	[Token(Token = "0x6000B55")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0xEAA3B0", Offset = "0xEA97B0", Length = "0x108")]
	[Token(Token = "0x6000B51")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xEAA740", Offset = "0xEA9B40", Length = "0x95")]
	[Token(Token = "0x6000B57")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000B5C")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xEA8900", Offset = "0xEA7D00", Length = "0xE3")]
	[Token(Token = "0x6000B69")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000B6A")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6000B6B")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xEA89F0", Offset = "0xEA7DF0", Length = "0x7C")]
	[Token(Token = "0x6000B5F")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xEA8C40", Offset = "0xEA8040", Length = "0x18A")]
	[Token(Token = "0x6000B61")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0xEA8DD0", Offset = "0xEA81D0", Length = "0xF5")]
	[Token(Token = "0x6000B62")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000B65")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000B60")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0xEA98E0", Offset = "0xEA8CE0", Length = "0x8A")]
	[Token(Token = "0x6000B67")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0xEA9110", Offset = "0xEA8510", Length = "0x111")]
	[Token(Token = "0x6000B63")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0xEA93F0", Offset = "0xEA87F0", Length = "0x1F3")]
	[Token(Token = "0x6000B64")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0xEA9700", Offset = "0xEA8B00", Length = "0x1DB")]
	[Token(Token = "0x6000B66")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0xEA9C00", Offset = "0xEA9000", Length = "0x187")]
	[Token(Token = "0x6000B68")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

	[Address(RVA = "0xEA9D90", Offset = "0xEA9190", Length = "0x6C")]
	[Token(Token = "0x6000B6C")]
	public T[] ToArray() { }

	[Address(RVA = "0xEA9EF0", Offset = "0xEA92F0", Length = "0x123")]
	[Token(Token = "0x6000B6D")]
	public ReadOnlyCollection<T> ToReadOnlyCollection() { }

	[Address(RVA = "0x945130", Offset = "0x944530", Length = "0x3")]
	[Token(Token = "0x6000B70")]
	private static void ValidateNullValue(object value, string argument) { }

}

