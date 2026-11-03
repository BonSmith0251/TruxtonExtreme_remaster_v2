namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[DefaultMember("Item")]
[Token(Token = "0x20005FF")]
public class List : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Token(Token = "0x2000600")]
	internal struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400187C")]
		private List<T> _list; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400187D")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400187E")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400187F")]
		private T _current; //Field offset: 0x0

		[Token(Token = "0x17000724")]
		public override T Current
		{
			[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
			[Token(Token = "0x6002CED")]
			 get { } //Length: 11
		}

		[Token(Token = "0x17000725")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x195A870", Offset = "0x1959C70", Length = "0x84")]
			[Token(Token = "0x6002CEE")]
			private get { } //Length: 132
		}

		[Address(RVA = "0x195B540", Offset = "0x195A940", Length = "0x41")]
		[Token(Token = "0x6002CE9")]
		internal Enumerator(List<T> list) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002CEA")]
		public override void Dispose() { }

		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x6002CED")]
		public override T get_Current() { }

		[Address(RVA = "0x1958120", Offset = "0x1957520", Length = "0xAF")]
		[Token(Token = "0x6002CEB")]
		public override bool MoveNext() { }

		[Address(RVA = "0x1957EE0", Offset = "0x19572E0", Length = "0x44")]
		[Token(Token = "0x6002CEC")]
		private bool MoveNextRare() { }

		[Address(RVA = "0x195A870", Offset = "0x1959C70", Length = "0x84")]
		[Token(Token = "0x6002CEE")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x195A390", Offset = "0x1959790", Length = "0x39")]
		[Token(Token = "0x6002CEF")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[Token(Token = "0x400187B")]
	private static readonly T[] s_emptyArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001877")]
	private T[] _items; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001878")]
	private int _size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001879")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400187A")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x1700071B")]
	public int Capacity
	{
		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x6002CAC")]
		 get { } //Length: 26
		[Address(RVA = "0xB16910", Offset = "0xB15D10", Length = "0x117")]
		[Token(Token = "0x6002CAD")]
		 set { } //Length: 279
	}

	[Token(Token = "0x1700071C")]
	public override int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6002CAE")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000722")]
	public override T Item
	{
		[Address(RVA = "0xB168B0", Offset = "0xB15CB0", Length = "0x5E")]
		[Token(Token = "0x6002CB4")]
		 get { } //Length: 94
		[Address(RVA = "0xB16B10", Offset = "0xB15F10", Length = "0x72")]
		[Token(Token = "0x6002CB5")]
		 set { } //Length: 114
	}

	[Token(Token = "0x1700071E")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002CB0")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000720")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002CB2")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000721")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xB14350", Offset = "0xB13750", Length = "0x68")]
		[Token(Token = "0x6002CB3")]
		private get { } //Length: 104
	}

	[Token(Token = "0x1700071D")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002CAF")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700071F")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002CB1")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000723")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0xB159A0", Offset = "0xB14DA0", Length = "0x76")]
		[Token(Token = "0x6002CB7")]
		private get { } //Length: 118
		[Address(RVA = "0xB15AA0", Offset = "0xB14EA0", Length = "0x134")]
		[Token(Token = "0x6002CB8")]
		private set { } //Length: 308
	}

	[Address(RVA = "0xB15F80", Offset = "0xB15380", Length = "0xD0")]
	[Token(Token = "0x6002CE8")]
	private static List`1() { }

	[Address(RVA = "0xB16400", Offset = "0xB15800", Length = "0x22E")]
	[Token(Token = "0x6002CAB")]
	public List`1(IEnumerable<T> collection) { }

	[Address(RVA = "0xB16050", Offset = "0xB15450", Length = "0x89")]
	[Token(Token = "0x6002CA9")]
	public List`1() { }

	[Address(RVA = "0xB160E0", Offset = "0xB154E0", Length = "0xE3")]
	[Token(Token = "0x6002CAA")]
	public List`1(int capacity) { }

	[Address(RVA = "0xB0FE10", Offset = "0xB0F210", Length = "0x7D")]
	[Token(Token = "0x6002CB9")]
	public override void Add(T item) { }

	[Address(RVA = "0xB0F5B0", Offset = "0xB0E9B0", Length = "0x271")]
	[Token(Token = "0x6002CE7")]
	private void AddEnumerable(IEnumerable<T> enumerable) { }

	[Address(RVA = "0xB0FAB0", Offset = "0xB0EEB0", Length = "0x1D")]
	[Token(Token = "0x6002CBC")]
	public void AddRange(IEnumerable<T> collection) { }

	[Address(RVA = "0xB0FB80", Offset = "0xB0EF80", Length = "0xC7")]
	[Token(Token = "0x6002CBA")]
	private void AddWithResize(T item) { }

	[Address(RVA = "0xB0FE90", Offset = "0xB0F290", Length = "0x73")]
	[Token(Token = "0x6002CBD")]
	public ReadOnlyCollection<T> AsReadOnly() { }

	[Address(RVA = "0xB10110", Offset = "0xB0F510", Length = "0xB2")]
	[Token(Token = "0x6002CC0")]
	public int BinarySearch(T item, IComparer<T> comparer) { }

	[Address(RVA = "0xB10060", Offset = "0xB0F460", Length = "0xA6")]
	[Token(Token = "0x6002CBF")]
	public int BinarySearch(T item) { }

	[Address(RVA = "0xB0FF10", Offset = "0xB0F310", Length = "0xAC")]
	[Token(Token = "0x6002CBE")]
	public int BinarySearch(int index, int count, T item, IComparer<T> comparer) { }

	[Address(RVA = "0xB10540", Offset = "0xB0F940", Length = "0x22")]
	[Token(Token = "0x6002CC1")]
	public override void Clear() { }

	[Address(RVA = "0xB105F0", Offset = "0xB0F9F0", Length = "0x65")]
	[Token(Token = "0x6002CC2")]
	public override bool Contains(T item) { }

	[Address(RVA = "0x69C1D0", Offset = "0x69B5D0", Length = "0x12C")]
	[Token(Token = "0x6002CC4")]
	public List<TOutput> ConvertAll(Converter<T, TOutput> converter) { }

	[Address(RVA = "0xB106F0", Offset = "0xB0FAF0", Length = "0x2A")]
	[Token(Token = "0x6002CC7")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0xB106C0", Offset = "0xB0FAC0", Length = "0x2A")]
	[Token(Token = "0x6002CC5")]
	public void CopyTo(T[] array) { }

	[Address(RVA = "0xB10720", Offset = "0xB0FB20", Length = "0x5E")]
	[Token(Token = "0x6002CC8")]
	private void EnsureCapacity(int min) { }

	[Address(RVA = "0xB10780", Offset = "0xB0FB80", Length = "0xBF")]
	[Token(Token = "0x6002CC9")]
	public bool Exists(Predicate<T> match) { }

	[Address(RVA = "0xB11460", Offset = "0xB10860", Length = "0xCC")]
	[Token(Token = "0x6002CCA")]
	public T Find(Predicate<T> match) { }

	[Address(RVA = "0xB10900", Offset = "0xB0FD00", Length = "0x193")]
	[Token(Token = "0x6002CCB")]
	public List<T> FindAll(Predicate<T> match) { }

	[Address(RVA = "0xB10DC0", Offset = "0xB101C0", Length = "0xDD")]
	[Token(Token = "0x6002CCE")]
	public int FindIndex(int startIndex, int count, Predicate<T> match) { }

	[Address(RVA = "0xB10F60", Offset = "0xB10360", Length = "0xDC")]
	[Token(Token = "0x6002CCD")]
	public int FindIndex(int startIndex, Predicate<T> match) { }

	[Address(RVA = "0xB11040", Offset = "0xB10440", Length = "0xBB")]
	[Token(Token = "0x6002CCC")]
	public int FindIndex(Predicate<T> match) { }

	[Address(RVA = "0xB112C0", Offset = "0xB106C0", Length = "0xD1")]
	[Token(Token = "0x6002CCF")]
	public T FindLast(Predicate<T> match) { }

	[Address(RVA = "0xB115E0", Offset = "0xB109E0", Length = "0xB1")]
	[Token(Token = "0x6002CD0")]
	public void ForEach(Action<T> action) { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x6002CAC")]
	public int get_Capacity() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6002CAE")]
	public override int get_Count() { }

	[Address(RVA = "0xB168B0", Offset = "0xB15CB0", Length = "0x5E")]
	[Token(Token = "0x6002CB4")]
	public override T get_Item(int index) { }

	[Address(RVA = "0xB11750", Offset = "0xB10B50", Length = "0x33")]
	[Token(Token = "0x6002CD1")]
	public Enumerator<T> GetEnumerator() { }

	[Address(RVA = "0xB117D0", Offset = "0xB10BD0", Length = "0x1A2")]
	[Token(Token = "0x6002CD4")]
	public List<T> GetRange(int index, int count) { }

	[Address(RVA = "0xB119F0", Offset = "0xB10DF0", Length = "0x3D")]
	[Token(Token = "0x6002CD5")]
	public override int IndexOf(T item) { }

	[Address(RVA = "0xB12950", Offset = "0xB11D50", Length = "0x123")]
	[Token(Token = "0x6002CD7")]
	public override void Insert(int index, T item) { }

	[Address(RVA = "0xB12370", Offset = "0xB11770", Length = "0x4AD")]
	[Token(Token = "0x6002CD9")]
	public void InsertRange(int index, IEnumerable<T> collection) { }

	[Address(RVA = "0xB12B90", Offset = "0xB11F90", Length = "0x58")]
	[Token(Token = "0x6002CB6")]
	private static bool IsCompatibleObject(object value) { }

	[Address(RVA = "0xB135C0", Offset = "0xB129C0", Length = "0xEC")]
	[Token(Token = "0x6002CDA")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xB12F50", Offset = "0xB12350", Length = "0x1D4")]
	[Token(Token = "0x6002CDC")]
	public int RemoveAll(Predicate<T> match) { }

	[Address(RVA = "0xB13130", Offset = "0xB12530", Length = "0x93")]
	[Token(Token = "0x6002CDD")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0xB132D0", Offset = "0xB126D0", Length = "0xA3")]
	[Token(Token = "0x6002CDE")]
	public void RemoveRange(int index, int count) { }

	[Address(RVA = "0xB13880", Offset = "0xB12C80", Length = "0x86")]
	[Token(Token = "0x6002CDF")]
	public void Reverse() { }

	[Address(RVA = "0xB13740", Offset = "0xB12B40", Length = "0x92")]
	[Token(Token = "0x6002CE0")]
	public void Reverse(int index, int count) { }

	[Address(RVA = "0xB16910", Offset = "0xB15D10", Length = "0x117")]
	[Token(Token = "0x6002CAD")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xB16B10", Offset = "0xB15F10", Length = "0x72")]
	[Token(Token = "0x6002CB5")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0xB13C30", Offset = "0xB13030", Length = "0x8E")]
	[Token(Token = "0x6002CE1")]
	public void Sort() { }

	[Address(RVA = "0xB13E90", Offset = "0xB13290", Length = "0x9B")]
	[Token(Token = "0x6002CE2")]
	public void Sort(IComparer<T> comparer) { }

	[Address(RVA = "0xB13D50", Offset = "0xB13150", Length = "0x9F")]
	[Token(Token = "0x6002CE3")]
	public void Sort(int index, int count, IComparer<T> comparer) { }

	[Address(RVA = "0xB13F30", Offset = "0xB13330", Length = "0xB7")]
	[Token(Token = "0x6002CE4")]
	public void Sort(Comparison<T> comparison) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002CB0")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0xB141F0", Offset = "0xB135F0", Length = "0x6B")]
	[Token(Token = "0x6002CD2")]
	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	[Address(RVA = "0xB142D0", Offset = "0xB136D0", Length = "0x74")]
	[Token(Token = "0x6002CC6")]
	private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002CB2")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0xB14350", Offset = "0xB13750", Length = "0x68")]
	[Token(Token = "0x6002CB3")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xB141F0", Offset = "0xB135F0", Length = "0x6B")]
	[Token(Token = "0x6002CD3")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xB14760", Offset = "0xB13B60", Length = "0x169")]
	[Token(Token = "0x6002CBB")]
	private override int System.Collections.IList.Add(object item) { }

	[Address(RVA = "0xB148D0", Offset = "0xB13CD0", Length = "0x16F")]
	[Token(Token = "0x6002CC3")]
	private override bool System.Collections.IList.Contains(object item) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002CAF")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002CB1")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0xB159A0", Offset = "0xB14DA0", Length = "0x76")]
	[Token(Token = "0x6002CB7")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0xB14FC0", Offset = "0xB143C0", Length = "0x14E")]
	[Token(Token = "0x6002CD6")]
	private override int System.Collections.IList.IndexOf(object item) { }

	[Address(RVA = "0xB15330", Offset = "0xB14730", Length = "0x10E")]
	[Token(Token = "0x6002CD8")]
	private override void System.Collections.IList.Insert(int index, object item) { }

	[Address(RVA = "0xB15620", Offset = "0xB14A20", Length = "0x1D7")]
	[Token(Token = "0x6002CDB")]
	private override void System.Collections.IList.Remove(object item) { }

	[Address(RVA = "0xB15AA0", Offset = "0xB14EA0", Length = "0x134")]
	[Token(Token = "0x6002CB8")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

	[Address(RVA = "0xB15E40", Offset = "0xB15240", Length = "0xE1")]
	[Token(Token = "0x6002CE5")]
	public T[] ToArray() { }

	[Address(RVA = "0xB15F30", Offset = "0xB15330", Length = "0x4F")]
	[Token(Token = "0x6002CE6")]
	public void TrimExcess() { }

}

