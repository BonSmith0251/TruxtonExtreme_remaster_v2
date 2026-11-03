namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
[Token(Token = "0x2000201")]
public class SortedList : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>
{
	[Token(Token = "0x2000202")]
	private struct Enumerator : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000770")]
		private SortedList<TKey, TValue> _sortedList; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000771")]
		private TKey _key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000772")]
		private TValue _value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000773")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000774")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000775")]
		private int _getEnumeratorRetType; //Field offset: 0x0

		[Token(Token = "0x170002AE")]
		public override KeyValuePair<TKey, TValue> Current
		{
			[Address(RVA = "0x19BA300", Offset = "0x19B9700", Length = "0x6D")]
			[Token(Token = "0x6000D49")]
			 get { } //Length: 109
		}

		[Token(Token = "0x170002AD")]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			[Address(RVA = "0x19B5030", Offset = "0x19B4430", Length = "0x12A")]
			[Token(Token = "0x6000D48")]
			private get { } //Length: 298
		}

		[Token(Token = "0x170002AC")]
		private override object System.Collections.IDictionaryEnumerator.Key
		{
			[Address(RVA = "0x19B5C20", Offset = "0x19B5020", Length = "0xD2")]
			[Token(Token = "0x6000D46")]
			private get { } //Length: 210
		}

		[Token(Token = "0x170002B0")]
		private override object System.Collections.IDictionaryEnumerator.Value
		{
			[Address(RVA = "0x19B5E20", Offset = "0x19B5220", Length = "0xD4")]
			[Token(Token = "0x6000D4B")]
			private get { } //Length: 212
		}

		[Token(Token = "0x170002AF")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19B88D0", Offset = "0x19B7CD0", Length = "0x21C")]
			[Token(Token = "0x6000D4A")]
			private get { } //Length: 540
		}

		[Address(RVA = "0x19BA0E0", Offset = "0x19B94E0", Length = "0x4C")]
		[Token(Token = "0x6000D44")]
		internal Enumerator(SortedList<TKey, TValue> sortedList, int getEnumeratorRetType) { }

		[Address(RVA = "0x19B22A0", Offset = "0x19B16A0", Length = "0x14")]
		[Token(Token = "0x6000D45")]
		public override void Dispose() { }

		[Address(RVA = "0x19BA300", Offset = "0x19B9700", Length = "0x6D")]
		[Token(Token = "0x6000D49")]
		public override KeyValuePair<TKey, TValue> get_Current() { }

		[Address(RVA = "0x19B46A0", Offset = "0x19B3AA0", Length = "0x14D")]
		[Token(Token = "0x6000D47")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19B5030", Offset = "0x19B4430", Length = "0x12A")]
		[Token(Token = "0x6000D48")]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		[Address(RVA = "0x19B5C20", Offset = "0x19B5020", Length = "0xD2")]
		[Token(Token = "0x6000D46")]
		private override object System.Collections.IDictionaryEnumerator.get_Key() { }

		[Address(RVA = "0x19B5E20", Offset = "0x19B5220", Length = "0xD4")]
		[Token(Token = "0x6000D4B")]
		private override object System.Collections.IDictionaryEnumerator.get_Value() { }

		[Address(RVA = "0x19B88D0", Offset = "0x19B7CD0", Length = "0x21C")]
		[Token(Token = "0x6000D4A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x19B6890", Offset = "0x19B5C90", Length = "0x7E")]
		[Token(Token = "0x6000D4C")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView`2))]
	[DefaultMember("Item")]
	[Token(Token = "0x2000205")]
	private sealed class KeyList : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077E")]
		private SortedList<TKey, TValue> _dict; //Field offset: 0x0

		[Token(Token = "0x170002B5")]
		public override int Count
		{
			[Address(RVA = "0xAE7E00", Offset = "0xAE7200", Length = "0x1A")]
			[Token(Token = "0x6000D5A")]
			 get { } //Length: 26
		}

		[Token(Token = "0x170002B6")]
		public override bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6000D5B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170002B9")]
		public override TKey Item
		{
			[Address(RVA = "0xAE7E20", Offset = "0xAE7220", Length = "0x2A")]
			[Token(Token = "0x6000D64")]
			 get { } //Length: 42
			[Address(RVA = "0xAE7F20", Offset = "0xAE7320", Length = "0x49")]
			[Token(Token = "0x6000D65")]
			 set { } //Length: 73
		}

		[Token(Token = "0x170002B7")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000D5C")]
			private get { } //Length: 3
		}

		[Token(Token = "0x170002B8")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0xAE7D60", Offset = "0xAE7160", Length = "0x49")]
			[Token(Token = "0x6000D5D")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000D59")]
		internal KeyList(SortedList<TKey, TValue> dictionary) { }

		[Address(RVA = "0xAE74D0", Offset = "0xAE68D0", Length = "0x49")]
		[Token(Token = "0x6000D5E")]
		public override void Add(TKey key) { }

		[Address(RVA = "0xAE7520", Offset = "0xAE6920", Length = "0x49")]
		[Token(Token = "0x6000D5F")]
		public override void Clear() { }

		[Address(RVA = "0xAE7660", Offset = "0xAE6A60", Length = "0x2A")]
		[Token(Token = "0x6000D60")]
		public override bool Contains(TKey key) { }

		[Address(RVA = "0xAE7710", Offset = "0xAE6B10", Length = "0x39")]
		[Token(Token = "0x6000D61")]
		public override void CopyTo(TKey[] array, int arrayIndex) { }

		[Address(RVA = "0xAE7E00", Offset = "0xAE7200", Length = "0x1A")]
		[Token(Token = "0x6000D5A")]
		public override int get_Count() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000D5B")]
		public override bool get_IsReadOnly() { }

		[Address(RVA = "0xAE7E20", Offset = "0xAE7220", Length = "0x2A")]
		[Token(Token = "0x6000D64")]
		public override TKey get_Item(int index) { }

		[Address(RVA = "0xAE7750", Offset = "0xAE6B50", Length = "0x6E")]
		[Token(Token = "0x6000D66")]
		public override IEnumerator<TKey> GetEnumerator() { }

		[Address(RVA = "0xAE7A30", Offset = "0xAE6E30", Length = "0x50")]
		[Token(Token = "0x6000D68")]
		public override int IndexOf(TKey key) { }

		[Address(RVA = "0xAE7A90", Offset = "0xAE6E90", Length = "0x49")]
		[Token(Token = "0x6000D63")]
		public override void Insert(int index, TKey value) { }

		[Address(RVA = "0xAE74D0", Offset = "0xAE68D0", Length = "0x49")]
		[Token(Token = "0x6000D69")]
		public override bool Remove(TKey key) { }

		[Address(RVA = "0xAE74D0", Offset = "0xAE68D0", Length = "0x49")]
		[Token(Token = "0x6000D6A")]
		public override void RemoveAt(int index) { }

		[Address(RVA = "0xAE7F20", Offset = "0xAE7320", Length = "0x49")]
		[Token(Token = "0x6000D65")]
		public override void set_Item(int index, TKey value) { }

		[Address(RVA = "0xAE7C30", Offset = "0xAE7030", Length = "0x12C")]
		[Token(Token = "0x6000D62")]
		private override void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000D5C")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0xAE7D60", Offset = "0xAE7160", Length = "0x49")]
		[Token(Token = "0x6000D5D")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0xAE7750", Offset = "0xAE6B50", Length = "0x6E")]
		[Token(Token = "0x6000D67")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x2000203")]
	private sealed class SortedListKeyEnumerator : IEnumerator<TKey>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000776")]
		private SortedList<TKey, TValue> _sortedList; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000777")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000778")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000779")]
		private TKey _currentKey; //Field offset: 0x0

		[Token(Token = "0x170002B1")]
		public override TKey Current
		{
			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[Token(Token = "0x6000D50")]
			 get { } //Length: 4
		}

		[Token(Token = "0x170002B2")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xF6B2B0", Offset = "0xF6A6B0", Length = "0x93")]
			[Token(Token = "0x6000D51")]
			private get { } //Length: 147
		}

		[Address(RVA = "0xF6B350", Offset = "0xF6A750", Length = "0x42")]
		[Token(Token = "0x6000D4D")]
		internal SortedListKeyEnumerator(SortedList<TKey, TValue> sortedList) { }

		[Address(RVA = "0xF6AB30", Offset = "0xF69F30", Length = "0xD")]
		[Token(Token = "0x6000D4E")]
		public override void Dispose() { }

		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000D50")]
		public override TKey get_Current() { }

		[Address(RVA = "0xF6AE80", Offset = "0xF6A280", Length = "0xB5")]
		[Token(Token = "0x6000D4F")]
		public override bool MoveNext() { }

		[Address(RVA = "0xF6B2B0", Offset = "0xF6A6B0", Length = "0x93")]
		[Token(Token = "0x6000D51")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xF6B090", Offset = "0xF6A490", Length = "0x78")]
		[Token(Token = "0x6000D52")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[Token(Token = "0x2000204")]
	private sealed class SortedListValueEnumerator : IEnumerator<TValue>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077A")]
		private SortedList<TKey, TValue> _sortedList; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077B")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077C")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077D")]
		private TValue _currentValue; //Field offset: 0x0

		[Token(Token = "0x170002B3")]
		public override TValue Current
		{
			[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
			[Token(Token = "0x6000D56")]
			 get { } //Length: 11
		}

		[Token(Token = "0x170002B4")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0xF6B9C0", Offset = "0xF6ADC0", Length = "0x95")]
			[Token(Token = "0x6000D57")]
			private get { } //Length: 149
		}

		[Address(RVA = "0xF6B350", Offset = "0xF6A750", Length = "0x42")]
		[Token(Token = "0x6000D53")]
		internal SortedListValueEnumerator(SortedList<TKey, TValue> sortedList) { }

		[Address(RVA = "0xF6B520", Offset = "0xF6A920", Length = "0xF")]
		[Token(Token = "0x6000D54")]
		public override void Dispose() { }

		[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
		[Token(Token = "0x6000D56")]
		public override TValue get_Current() { }

		[Address(RVA = "0xF6B870", Offset = "0xF6AC70", Length = "0xCB")]
		[Token(Token = "0x6000D55")]
		public override bool MoveNext() { }

		[Address(RVA = "0xF6B9C0", Offset = "0xF6ADC0", Length = "0x95")]
		[Token(Token = "0x6000D57")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xF6B940", Offset = "0xF6AD40", Length = "0x7A")]
		[Token(Token = "0x6000D58")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView`2))]
	[DefaultMember("Item")]
	[Token(Token = "0x2000206")]
	private sealed class ValueList : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400077F")]
		private SortedList<TKey, TValue> _dict; //Field offset: 0x0

		[Token(Token = "0x170002BA")]
		public override int Count
		{
			[Address(RVA = "0xAE7E00", Offset = "0xAE7200", Length = "0x1A")]
			[Token(Token = "0x6000D6C")]
			 get { } //Length: 26
		}

		[Token(Token = "0x170002BB")]
		public override bool IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6000D6D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170002BE")]
		public override TValue Item
		{
			[Address(RVA = "0x120DAD0", Offset = "0x120CED0", Length = "0x41")]
			[Token(Token = "0x6000D76")]
			 get { } //Length: 65
			[Address(RVA = "0xAE7A90", Offset = "0xAE6E90", Length = "0x49")]
			[Token(Token = "0x6000D77")]
			 set { } //Length: 73
		}

		[Token(Token = "0x170002BC")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000D6E")]
			private get { } //Length: 3
		}

		[Token(Token = "0x170002BD")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x120DA30", Offset = "0x120CE30", Length = "0x49")]
			[Token(Token = "0x6000D6F")]
			private get { } //Length: 73
		}

		[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
		[Token(Token = "0x6000D6B")]
		internal ValueList(SortedList<TKey, TValue> dictionary) { }

		[Address(RVA = "0xAE74D0", Offset = "0xAE68D0", Length = "0x49")]
		[Token(Token = "0x6000D70")]
		public override void Add(TValue key) { }

		[Address(RVA = "0xAE7520", Offset = "0xAE6920", Length = "0x49")]
		[Token(Token = "0x6000D71")]
		public override void Clear() { }

		[Address(RVA = "0x120D510", Offset = "0x120C910", Length = "0x38")]
		[Token(Token = "0x6000D72")]
		public override bool Contains(TValue value) { }

		[Address(RVA = "0x120D5D0", Offset = "0x120C9D0", Length = "0x39")]
		[Token(Token = "0x6000D73")]
		public override void CopyTo(TValue[] array, int arrayIndex) { }

		[Address(RVA = "0xAE7E00", Offset = "0xAE7200", Length = "0x1A")]
		[Token(Token = "0x6000D6C")]
		public override int get_Count() { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000D6D")]
		public override bool get_IsReadOnly() { }

		[Address(RVA = "0x120DAD0", Offset = "0x120CED0", Length = "0x41")]
		[Token(Token = "0x6000D76")]
		public override TValue get_Item(int index) { }

		[Address(RVA = "0xAE7750", Offset = "0xAE6B50", Length = "0x6E")]
		[Token(Token = "0x6000D78")]
		public override IEnumerator<TValue> GetEnumerator() { }

		[Address(RVA = "0x120D760", Offset = "0x120CB60", Length = "0x48")]
		[Token(Token = "0x6000D7A")]
		public override int IndexOf(TValue value) { }

		[Address(RVA = "0xAE7A90", Offset = "0xAE6E90", Length = "0x49")]
		[Token(Token = "0x6000D75")]
		public override void Insert(int index, TValue value) { }

		[Address(RVA = "0xAE74D0", Offset = "0xAE68D0", Length = "0x49")]
		[Token(Token = "0x6000D7B")]
		public override bool Remove(TValue value) { }

		[Address(RVA = "0xAE74D0", Offset = "0xAE68D0", Length = "0x49")]
		[Token(Token = "0x6000D7C")]
		public override void RemoveAt(int index) { }

		[Address(RVA = "0xAE7A90", Offset = "0xAE6E90", Length = "0x49")]
		[Token(Token = "0x6000D77")]
		public override void set_Item(int index, TValue value) { }

		[Address(RVA = "0x120D900", Offset = "0x120CD00", Length = "0x12C")]
		[Token(Token = "0x6000D74")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000D6E")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0x120DA30", Offset = "0x120CE30", Length = "0x49")]
		[Token(Token = "0x6000D6F")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0xAE7750", Offset = "0xAE6B50", Length = "0x6E")]
		[Token(Token = "0x6000D79")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000768")]
	private TKey[] keys; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000769")]
	private TValue[] values; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400076A")]
	private int _size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400076B")]
	private int version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400076C")]
	private IComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400076D")]
	private KeyList<TKey, TValue> keyList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400076E")]
	private ValueList<TKey, TValue> valueList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400076F")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x1700029B")]
	public int Capacity
	{
		[Address(RVA = "0xF71B00", Offset = "0xF70F00", Length = "0x1CA")]
		[Token(Token = "0x6000D19")]
		 set { } //Length: 458
	}

	[Token(Token = "0x1700029C")]
	public override int Count
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000D1B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170002AA")]
	public override TValue Item
	{
		[Address(RVA = "0xF71800", Offset = "0xF70C00", Length = "0x115")]
		[Token(Token = "0x6000D38")]
		 get { } //Length: 277
		[Address(RVA = "0xF72080", Offset = "0xF71480", Length = "0xDB")]
		[Token(Token = "0x6000D39")]
		 set { } //Length: 219
	}

	[Token(Token = "0x1700029D")]
	public IList<TKey> Keys
	{
		[Address(RVA = "0xF6E880", Offset = "0xF6DC80", Length = "0x17")]
		[Token(Token = "0x6000D1C")]
		 get { } //Length: 23
	}

	[Token(Token = "0x170002A5")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000D26")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700029E")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0xF6E880", Offset = "0xF6DC80", Length = "0x17")]
		[Token(Token = "0x6000D1D")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170002A2")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0xF6E8C0", Offset = "0xF6DCC0", Length = "0x17")]
		[Token(Token = "0x6000D21")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170002A0")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0xF6E880", Offset = "0xF6DC80", Length = "0x17")]
		[Token(Token = "0x6000D1F")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170002A4")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0xF6E8C0", Offset = "0xF6DCC0", Length = "0x17")]
		[Token(Token = "0x6000D23")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170002A8")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000D29")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170002A9")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xF6F740", Offset = "0xF6EB40", Length = "0x6B")]
		[Token(Token = "0x6000D2A")]
		private get { } //Length: 107
	}

	[Token(Token = "0x170002A7")]
	private override bool System.Collections.IDictionary.IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000D28")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170002A6")]
	private override bool System.Collections.IDictionary.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000D27")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170002AB")]
	private override object System.Collections.IDictionary.Item
	{
		[Address(RVA = "0xF706D0", Offset = "0xF6FAD0", Length = "0x19B")]
		[Token(Token = "0x6000D3A")]
		private get { } //Length: 411
		[Address(RVA = "0xF70C00", Offset = "0xF70000", Length = "0x33D")]
		[Token(Token = "0x6000D3B")]
		private set { } //Length: 829
	}

	[Token(Token = "0x1700029F")]
	private override ICollection System.Collections.IDictionary.Keys
	{
		[Address(RVA = "0xF6E880", Offset = "0xF6DC80", Length = "0x17")]
		[Token(Token = "0x6000D1E")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170002A3")]
	private override ICollection System.Collections.IDictionary.Values
	{
		[Address(RVA = "0xF6E8C0", Offset = "0xF6DCC0", Length = "0x17")]
		[Token(Token = "0x6000D22")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170002A1")]
	public IList<TValue> Values
	{
		[Address(RVA = "0xF6E8C0", Offset = "0xF6DCC0", Length = "0x17")]
		[Token(Token = "0x6000D20")]
		 get { } //Length: 23
	}

	[Address(RVA = "0xF714E0", Offset = "0xF708E0", Length = "0x93")]
	[Token(Token = "0x6000D13")]
	public SortedList`2() { }

	[Address(RVA = "0xF711A0", Offset = "0xF705A0", Length = "0x146")]
	[Token(Token = "0x6000D14")]
	public SortedList`2(int capacity) { }

	[Address(RVA = "0xF6BA60", Offset = "0xF6AE60", Length = "0x119")]
	[Token(Token = "0x6000D15")]
	public override void Add(TKey key, TValue value) { }

	[Address(RVA = "0xF6BF40", Offset = "0xF6B340", Length = "0x2B")]
	[Token(Token = "0x6000D2B")]
	public override void Clear() { }

	[Address(RVA = "0xF6BFF0", Offset = "0xF6B3F0", Length = "0x5D")]
	[Token(Token = "0x6000D2D")]
	public override bool ContainsKey(TKey key) { }

	[Address(RVA = "0xF6C140", Offset = "0xF6B540", Length = "0x54")]
	[Token(Token = "0x6000D2E")]
	public bool ContainsValue(TValue value) { }

	[Address(RVA = "0xF6C2F0", Offset = "0xF6B6F0", Length = "0x54")]
	[Token(Token = "0x6000D31")]
	private void EnsureCapacity(int min) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000D1B")]
	public override int get_Count() { }

	[Address(RVA = "0xF71800", Offset = "0xF70C00", Length = "0x115")]
	[Token(Token = "0x6000D38")]
	public override TValue get_Item(TKey key) { }

	[Address(RVA = "0xF6E880", Offset = "0xF6DC80", Length = "0x17")]
	[Token(Token = "0x6000D1C")]
	public IList<TKey> get_Keys() { }

	[Address(RVA = "0xF6E8C0", Offset = "0xF6DCC0", Length = "0x17")]
	[Token(Token = "0x6000D20")]
	public IList<TValue> get_Values() { }

	[Address(RVA = "0xF6C490", Offset = "0xF6B890", Length = "0xDE")]
	[Token(Token = "0x6000D32")]
	private TValue GetByIndex(int index) { }

	[Address(RVA = "0xF6C630", Offset = "0xF6BA30", Length = "0x86")]
	[Token(Token = "0x6000D33")]
	public IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	[Address(RVA = "0xF6C940", Offset = "0xF6BD40", Length = "0xCD")]
	[Token(Token = "0x6000D37")]
	private TKey GetKey(int index) { }

	[Address(RVA = "0xF6C6C0", Offset = "0xF6BAC0", Length = "0x9A")]
	[Token(Token = "0x6000D24")]
	private KeyList<TKey, TValue> GetKeyListHelper() { }

	[Address(RVA = "0xF6CAB0", Offset = "0xF6BEB0", Length = "0x9A")]
	[Token(Token = "0x6000D25")]
	private ValueList<TKey, TValue> GetValueListHelper() { }

	[Address(RVA = "0xF6CD10", Offset = "0xF6C110", Length = "0x44")]
	[Token(Token = "0x6000D3C")]
	public int IndexOfKey(TKey key) { }

	[Address(RVA = "0xF6CE80", Offset = "0xF6C280", Length = "0x3D")]
	[Token(Token = "0x6000D3D")]
	public int IndexOfValue(TValue value) { }

	[Address(RVA = "0xF6D150", Offset = "0xF6C550", Length = "0x145")]
	[Token(Token = "0x6000D3E")]
	private void Insert(int index, TKey key, TValue value) { }

	[Address(RVA = "0xF6D2A0", Offset = "0xF6C6A0", Length = "0x9E")]
	[Token(Token = "0x6000D43")]
	private static bool IsCompatibleKey(object key) { }

	[Address(RVA = "0xF6D910", Offset = "0xF6CD10", Length = "0x98")]
	[Token(Token = "0x6000D41")]
	public override bool Remove(TKey key) { }

	[Address(RVA = "0xF6D6B0", Offset = "0xF6CAB0", Length = "0x14B")]
	[Token(Token = "0x6000D40")]
	public void RemoveAt(int index) { }

	[Address(RVA = "0xF71B00", Offset = "0xF70F00", Length = "0x1CA")]
	[Token(Token = "0x6000D19")]
	public void set_Capacity(int value) { }

	[Address(RVA = "0xF72080", Offset = "0xF71480", Length = "0xDB")]
	[Token(Token = "0x6000D39")]
	public override void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0xF6DB20", Offset = "0xF6CF20", Length = "0x30")]
	[Token(Token = "0x6000D16")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0xF6DD90", Offset = "0xF6D190", Length = "0xF7")]
	[Token(Token = "0x6000D17")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0xF6E2D0", Offset = "0xF6D6D0", Length = "0x23D")]
	[Token(Token = "0x6000D2F")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000D26")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	[Address(RVA = "0xF6E760", Offset = "0xF6DB60", Length = "0x11C")]
	[Token(Token = "0x6000D18")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0xF6E880", Offset = "0xF6DC80", Length = "0x17")]
	[Token(Token = "0x6000D1D")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0xF6E8C0", Offset = "0xF6DCC0", Length = "0x17")]
	[Token(Token = "0x6000D21")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0xF6C630", Offset = "0xF6BA30", Length = "0x86")]
	[Token(Token = "0x6000D34")]
	private override IEnumerator<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0xF6E880", Offset = "0xF6DC80", Length = "0x17")]
	[Token(Token = "0x6000D1F")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0xF6E8C0", Offset = "0xF6DCC0", Length = "0x17")]
	[Token(Token = "0x6000D23")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0xF6F150", Offset = "0xF6E550", Length = "0x575")]
	[Token(Token = "0x6000D30")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000D29")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0xF6F740", Offset = "0xF6EB40", Length = "0x6B")]
	[Token(Token = "0x6000D2A")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xF6FBB0", Offset = "0xF6EFB0", Length = "0x2FD")]
	[Token(Token = "0x6000D1A")]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[Address(RVA = "0xF6FFD0", Offset = "0xF6F3D0", Length = "0x16C")]
	[Token(Token = "0x6000D2C")]
	private override bool System.Collections.IDictionary.Contains(object key) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000D28")]
	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000D27")]
	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	[Address(RVA = "0xF706D0", Offset = "0xF6FAD0", Length = "0x19B")]
	[Token(Token = "0x6000D3A")]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[Address(RVA = "0xF6E880", Offset = "0xF6DC80", Length = "0x17")]
	[Token(Token = "0x6000D1E")]
	private override ICollection System.Collections.IDictionary.get_Keys() { }

	[Address(RVA = "0xF6E8C0", Offset = "0xF6DCC0", Length = "0x17")]
	[Token(Token = "0x6000D22")]
	private override ICollection System.Collections.IDictionary.get_Values() { }

	[Address(RVA = "0xF70200", Offset = "0xF6F600", Length = "0x86")]
	[Token(Token = "0x6000D35")]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[Address(RVA = "0xF70290", Offset = "0xF6F690", Length = "0x178")]
	[Token(Token = "0x6000D42")]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[Address(RVA = "0xF70C00", Offset = "0xF70000", Length = "0x33D")]
	[Token(Token = "0x6000D3B")]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[Address(RVA = "0xF6C630", Offset = "0xF6BA30", Length = "0x86")]
	[Token(Token = "0x6000D36")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xF710F0", Offset = "0xF704F0", Length = "0xA8")]
	[Token(Token = "0x6000D3F")]
	public override bool TryGetValue(TKey key, out TValue value) { }

}

