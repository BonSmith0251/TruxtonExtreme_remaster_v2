namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
[Token(Token = "0x20005E7")]
public class Dictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>, ISerializable, IDeserializationCallback
{
	[Token(Token = "0x20005E8")]
	private struct Entry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001862")]
		public int hashCode; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001863")]
		public int next; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001864")]
		public TKey key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001865")]
		public TValue value; //Field offset: 0x0

	}

	[Token(Token = "0x20005E9")]
	internal struct Enumerator : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001866")]
		private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001867")]
		private int _version; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001868")]
		private int _index; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001869")]
		private KeyValuePair<TKey, TValue> _current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400186A")]
		private int _getEnumeratorRetType; //Field offset: 0x0

		[Token(Token = "0x170006FC")]
		public override KeyValuePair<TKey, TValue> Current
		{
			[Address(RVA = "0x661A70", Offset = "0x660E70", Length = "0x13")]
			[Token(Token = "0x6002C51")]
			 get { } //Length: 19
		}

		[Token(Token = "0x170006FE")]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			[Address(RVA = "0x19AED50", Offset = "0x19AE150", Length = "0x101")]
			[Token(Token = "0x6002C55")]
			private get { } //Length: 257
		}

		[Token(Token = "0x170006FF")]
		private override object System.Collections.IDictionaryEnumerator.Key
		{
			[Address(RVA = "0x19AF320", Offset = "0x19AE720", Length = "0x84")]
			[Token(Token = "0x6002C56")]
			private get { } //Length: 132
		}

		[Token(Token = "0x17000700")]
		private override object System.Collections.IDictionaryEnumerator.Value
		{
			[Address(RVA = "0x19AF750", Offset = "0x19AEB50", Length = "0x84")]
			[Token(Token = "0x6002C57")]
			private get { } //Length: 132
		}

		[Token(Token = "0x170006FD")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19AFEA0", Offset = "0x19AF2A0", Length = "0x22A")]
			[Token(Token = "0x6002C53")]
			private get { } //Length: 554
		}

		[Address(RVA = "0x19B1FB0", Offset = "0x19B13B0", Length = "0x55")]
		[Token(Token = "0x6002C4F")]
		internal Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6002C52")]
		public override void Dispose() { }

		[Address(RVA = "0x661A70", Offset = "0x660E70", Length = "0x13")]
		[Token(Token = "0x6002C51")]
		public override KeyValuePair<TKey, TValue> get_Current() { }

		[Address(RVA = "0x19ADAE0", Offset = "0x19ACEE0", Length = "0x158")]
		[Token(Token = "0x6002C50")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19AED50", Offset = "0x19AE150", Length = "0x101")]
		[Token(Token = "0x6002C55")]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		[Address(RVA = "0x19AF320", Offset = "0x19AE720", Length = "0x84")]
		[Token(Token = "0x6002C56")]
		private override object System.Collections.IDictionaryEnumerator.get_Key() { }

		[Address(RVA = "0x19AF750", Offset = "0x19AEB50", Length = "0x84")]
		[Token(Token = "0x6002C57")]
		private override object System.Collections.IDictionaryEnumerator.get_Value() { }

		[Address(RVA = "0x19AFEA0", Offset = "0x19AF2A0", Length = "0x22A")]
		[Token(Token = "0x6002C53")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x19AF990", Offset = "0x19AED90", Length = "0x3D")]
		[Token(Token = "0x6002C54")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView`2))]
	[Token(Token = "0x20005EA")]
	internal sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		[Token(Token = "0x20005EB")]
		internal struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400186C")]
			private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400186D")]
			private int _index; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400186E")]
			private int _version; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400186F")]
			private TKey _currentKey; //Field offset: 0x0

			[Token(Token = "0x17000705")]
			public override TKey Current
			{
				[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
				[Token(Token = "0x6002C69")]
				 get { } //Length: 11
			}

			[Token(Token = "0x17000706")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x19B06B0", Offset = "0x19AFAB0", Length = "0x72")]
				[Token(Token = "0x6002C6A")]
				private get { } //Length: 114
			}

			[Address(RVA = "0x19B1F60", Offset = "0x19B1360", Length = "0x41")]
			[Token(Token = "0x6002C66")]
			internal Enumerator(Dictionary<TKey, TValue> dictionary) { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x6002C67")]
			public override void Dispose() { }

			[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
			[Token(Token = "0x6002C69")]
			public override TKey get_Current() { }

			[Address(RVA = "0x19AE8A0", Offset = "0x19ADCA0", Length = "0xA9")]
			[Token(Token = "0x6002C68")]
			public override bool MoveNext() { }

			[Address(RVA = "0x19B06B0", Offset = "0x19AFAB0", Length = "0x72")]
			[Token(Token = "0x6002C6A")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x19AF9D0", Offset = "0x19AEDD0", Length = "0x39")]
			[Token(Token = "0x6002C6B")]
			private override void System.Collections.IEnumerator.Reset() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400186B")]
		private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		[Token(Token = "0x17000701")]
		public override int Count
		{
			[Address(RVA = "0xAD47E0", Offset = "0xAD3BE0", Length = "0x2A")]
			[Token(Token = "0x6002C5B")]
			 get { } //Length: 42
		}

		[Token(Token = "0x17000702")]
		private override bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002C5C")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000703")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6002C64")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000704")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0xAD3E30", Offset = "0xAD3230", Length = "0x49")]
			[Token(Token = "0x6002C65")]
			private get { } //Length: 73
		}

		[Address(RVA = "0xAD4790", Offset = "0xAD3B90", Length = "0x42")]
		[Token(Token = "0x6002C58")]
		public KeyCollection(Dictionary<TKey, TValue> dictionary) { }

		[Address(RVA = "0xACAC50", Offset = "0xACA050", Length = "0x14E")]
		[Token(Token = "0x6002C5A")]
		public override void CopyTo(TKey[] array, int index) { }

		[Address(RVA = "0xAD47E0", Offset = "0xAD3BE0", Length = "0x2A")]
		[Token(Token = "0x6002C5B")]
		public override int get_Count() { }

		[Address(RVA = "0xACB390", Offset = "0xACA790", Length = "0x34")]
		[Token(Token = "0x6002C59")]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[Address(RVA = "0xACB4B0", Offset = "0xACA8B0", Length = "0xC")]
		[Token(Token = "0x6002C5D")]
		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		[Address(RVA = "0xACB4B0", Offset = "0xACA8B0", Length = "0xC")]
		[Token(Token = "0x6002C5E")]
		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		[Address(RVA = "0xACB730", Offset = "0xACAB30", Length = "0x38")]
		[Token(Token = "0x6002C5F")]
		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002C5C")]
		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		[Address(RVA = "0xACBA80", Offset = "0xACAE80", Length = "0x17")]
		[Token(Token = "0x6002C60")]
		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		[Address(RVA = "0xACBB10", Offset = "0xACAF10", Length = "0x66")]
		[Token(Token = "0x6002C61")]
		private override IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

		[Address(RVA = "0xACDF30", Offset = "0xACD330", Length = "0x372")]
		[Token(Token = "0x6002C63")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002C64")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0xAD3E30", Offset = "0xAD3230", Length = "0x49")]
		[Token(Token = "0x6002C65")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0xACBB10", Offset = "0xACAF10", Length = "0x66")]
		[Token(Token = "0x6002C62")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView`2))]
	[Token(Token = "0x20005EC")]
	internal sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		[Token(Token = "0x20005ED")]
		internal struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001871")]
			private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001872")]
			private int _index; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001873")]
			private int _version; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4001874")]
			private TValue _currentValue; //Field offset: 0x0

			[Token(Token = "0x1700070B")]
			public override TValue Current
			{
				[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
				[Token(Token = "0x6002C7D")]
				 get { } //Length: 11
			}

			[Token(Token = "0x1700070C")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x19B06B0", Offset = "0x19AFAB0", Length = "0x72")]
				[Token(Token = "0x6002C7E")]
				private get { } //Length: 114
			}

			[Address(RVA = "0x19B1F60", Offset = "0x19B1360", Length = "0x41")]
			[Token(Token = "0x6002C7A")]
			internal Enumerator(Dictionary<TKey, TValue> dictionary) { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x6002C7B")]
			public override void Dispose() { }

			[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
			[Token(Token = "0x6002C7D")]
			public override TValue get_Current() { }

			[Address(RVA = "0x19AD0B0", Offset = "0x19AC4B0", Length = "0xA6")]
			[Token(Token = "0x6002C7C")]
			public override bool MoveNext() { }

			[Address(RVA = "0x19B06B0", Offset = "0x19AFAB0", Length = "0x72")]
			[Token(Token = "0x6002C7E")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x19AF9D0", Offset = "0x19AEDD0", Length = "0x39")]
			[Token(Token = "0x6002C7F")]
			private override void System.Collections.IEnumerator.Reset() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001870")]
		private Dictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		[Token(Token = "0x17000707")]
		public override int Count
		{
			[Address(RVA = "0xAD47E0", Offset = "0xAD3BE0", Length = "0x2A")]
			[Token(Token = "0x6002C6F")]
			 get { } //Length: 42
		}

		[Token(Token = "0x17000708")]
		private override bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002C70")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000709")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6002C78")]
			private get { } //Length: 3
		}

		[Token(Token = "0x1700070A")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x11EEB30", Offset = "0x11EDF30", Length = "0x49")]
			[Token(Token = "0x6002C79")]
			private get { } //Length: 73
		}

		[Address(RVA = "0xAD4790", Offset = "0xAD3B90", Length = "0x42")]
		[Token(Token = "0x6002C6C")]
		public ValueCollection(Dictionary<TKey, TValue> dictionary) { }

		[Address(RVA = "0x11EDE00", Offset = "0x11ED200", Length = "0x14E")]
		[Token(Token = "0x6002C6E")]
		public override void CopyTo(TValue[] array, int index) { }

		[Address(RVA = "0xAD47E0", Offset = "0xAD3BE0", Length = "0x2A")]
		[Token(Token = "0x6002C6F")]
		public override int get_Count() { }

		[Address(RVA = "0xACB390", Offset = "0xACA790", Length = "0x34")]
		[Token(Token = "0x6002C6D")]
		public Enumerator<TKey, TValue> GetEnumerator() { }

		[Address(RVA = "0x11EE090", Offset = "0x11ED490", Length = "0xC")]
		[Token(Token = "0x6002C71")]
		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		[Address(RVA = "0x11EE090", Offset = "0x11ED490", Length = "0xC")]
		[Token(Token = "0x6002C73")]
		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		[Address(RVA = "0x11EE0A0", Offset = "0x11ED4A0", Length = "0x38")]
		[Token(Token = "0x6002C74")]
		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002C70")]
		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		[Address(RVA = "0x11EE110", Offset = "0x11ED510", Length = "0x17")]
		[Token(Token = "0x6002C72")]
		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		[Address(RVA = "0xACBB10", Offset = "0xACAF10", Length = "0x66")]
		[Token(Token = "0x6002C75")]
		private override IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

		[Address(RVA = "0x11EE7B0", Offset = "0x11EDBB0", Length = "0x372")]
		[Token(Token = "0x6002C77")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002C78")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0x11EEB30", Offset = "0x11EDF30", Length = "0x49")]
		[Token(Token = "0x6002C79")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0xACBB10", Offset = "0xACAF10", Length = "0x66")]
		[Token(Token = "0x6002C76")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001858")]
	private Int32[] _buckets; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001859")]
	private Entry<TKey, TValue>[] _entries; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400185A")]
	private int _count; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400185B")]
	private int _freeList; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400185C")]
	private int _freeCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400185D")]
	private int _version; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400185E")]
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400185F")]
	private KeyCollection<TKey, TValue> _keys; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001860")]
	private ValueCollection<TKey, TValue> _values; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001861")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x170006EC")]
	public override int Count
	{
		[Address(RVA = "0x17EF480", Offset = "0x17EE880", Length = "0x7")]
		[Token(Token = "0x6002C1F")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170006F3")]
	public override TValue Item
	{
		[Address(RVA = "0x17EF600", Offset = "0x17EEA00", Length = "0xBC")]
		[Token(Token = "0x6002C26")]
		 get { } //Length: 188
		[Address(RVA = "0x17EF920", Offset = "0x17EED20", Length = "0x43")]
		[Token(Token = "0x6002C27")]
		 set { } //Length: 67
	}

	[Token(Token = "0x170006ED")]
	public KeyCollection<TKey, TValue> Keys
	{
		[Address(RVA = "0x17E55F0", Offset = "0x17E49F0", Length = "0x9A")]
		[Token(Token = "0x6002C20")]
		 get { } //Length: 154
	}

	[Token(Token = "0x170006F4")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002C3D")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006EE")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0x17E55F0", Offset = "0x17E49F0", Length = "0x9A")]
		[Token(Token = "0x6002C21")]
		private get { } //Length: 154
	}

	[Token(Token = "0x170006F1")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0x17E5690", Offset = "0x17E4A90", Length = "0x9A")]
		[Token(Token = "0x6002C24")]
		private get { } //Length: 154
	}

	[Token(Token = "0x170006EF")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0x17E55F0", Offset = "0x17E49F0", Length = "0x9A")]
		[Token(Token = "0x6002C22")]
		private get { } //Length: 154
	}

	[Token(Token = "0x170006F2")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0x17E5690", Offset = "0x17E4A90", Length = "0x9A")]
		[Token(Token = "0x6002C25")]
		private get { } //Length: 154
	}

	[Token(Token = "0x170006F5")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002C42")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006F6")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x17E7330", Offset = "0x17E6730", Length = "0x68")]
		[Token(Token = "0x6002C43")]
		private get { } //Length: 104
	}

	[Token(Token = "0x170006F7")]
	private override bool System.Collections.IDictionary.IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002C44")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006F8")]
	private override bool System.Collections.IDictionary.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002C45")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006FB")]
	private override object System.Collections.IDictionary.Item
	{
		[Address(RVA = "0x17E9360", Offset = "0x17E8760", Length = "0x14E")]
		[Token(Token = "0x6002C48")]
		private get { } //Length: 334
		[Address(RVA = "0x17E9B60", Offset = "0x17E8F60", Length = "0x1FA")]
		[Token(Token = "0x6002C49")]
		private set { } //Length: 506
	}

	[Token(Token = "0x170006F9")]
	private override ICollection System.Collections.IDictionary.Keys
	{
		[Address(RVA = "0x17E9830", Offset = "0x17E8C30", Length = "0xA9")]
		[Token(Token = "0x6002C46")]
		private get { } //Length: 169
	}

	[Token(Token = "0x170006FA")]
	private override ICollection System.Collections.IDictionary.Values
	{
		[Address(RVA = "0x17E98E0", Offset = "0x17E8CE0", Length = "0xA9")]
		[Token(Token = "0x6002C47")]
		private get { } //Length: 169
	}

	[Token(Token = "0x170006F0")]
	public ValueCollection<TKey, TValue> Values
	{
		[Address(RVA = "0x17E5690", Offset = "0x17E4A90", Length = "0x9A")]
		[Token(Token = "0x6002C23")]
		 get { } //Length: 154
	}

	[Address(RVA = "0x17EEE70", Offset = "0x17EE270", Length = "0x59")]
	[Token(Token = "0x6002C18")]
	public Dictionary`2() { }

	[Address(RVA = "0x17EF440", Offset = "0x17EE840", Length = "0x16")]
	[Token(Token = "0x6002C19")]
	public Dictionary`2(int capacity) { }

	[Address(RVA = "0x17EF090", Offset = "0x17EE490", Length = "0x63")]
	[Token(Token = "0x6002C1A")]
	public Dictionary`2(IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x17EE900", Offset = "0x17EDD00", Length = "0x91")]
	[Token(Token = "0x6002C1B")]
	public Dictionary`2(int capacity, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x17EE7C0", Offset = "0x17EDBC0", Length = "0x17")]
	[Token(Token = "0x6002C1C")]
	public Dictionary`2(IDictionary<TKey, TValue> dictionary) { }

	[Address(RVA = "0x17ED3A0", Offset = "0x17EC7A0", Length = "0x3EF")]
	[Token(Token = "0x6002C1D")]
	public Dictionary`2(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x17EF170", Offset = "0x17EE570", Length = "0x87")]
	[Token(Token = "0x6002C1E")]
	protected Dictionary`2(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x17DC1E0", Offset = "0x17DB5E0", Length = "0x43")]
	[Token(Token = "0x6002C28")]
	public override void Add(TKey key, TValue value) { }

	[Address(RVA = "0x17DC380", Offset = "0x17DB780", Length = "0x62")]
	[Token(Token = "0x6002C2C")]
	public override void Clear() { }

	[Address(RVA = "0x17DC460", Offset = "0x17DB860", Length = "0x32")]
	[Token(Token = "0x6002C2D")]
	public override bool ContainsKey(TKey key) { }

	[Address(RVA = "0x17DC8C0", Offset = "0x17DBCC0", Length = "0xED")]
	[Token(Token = "0x6002C2E")]
	public bool ContainsValue(TValue value) { }

	[Address(RVA = "0x17DC9B0", Offset = "0x17DBDB0", Length = "0x1A5")]
	[Token(Token = "0x6002C2F")]
	private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	[Address(RVA = "0x17DD190", Offset = "0x17DC590", Length = "0xDA")]
	[Token(Token = "0x6002C41")]
	public int EnsureCapacity(int capacity) { }

	[Address(RVA = "0x17DEA10", Offset = "0x17DDE10", Length = "0x46A")]
	[Token(Token = "0x6002C33")]
	private int FindEntry(TKey key) { }

	[Address(RVA = "0x17EF480", Offset = "0x17EE880", Length = "0x7")]
	[Token(Token = "0x6002C1F")]
	public override int get_Count() { }

	[Address(RVA = "0x17EF600", Offset = "0x17EEA00", Length = "0xBC")]
	[Token(Token = "0x6002C26")]
	public override TValue get_Item(TKey key) { }

	[Address(RVA = "0x17E55F0", Offset = "0x17E49F0", Length = "0x9A")]
	[Token(Token = "0x6002C20")]
	public KeyCollection<TKey, TValue> get_Keys() { }

	[Address(RVA = "0x17E5690", Offset = "0x17E4A90", Length = "0x9A")]
	[Token(Token = "0x6002C23")]
	public ValueCollection<TKey, TValue> get_Values() { }

	[Address(RVA = "0x17DEF50", Offset = "0x17DE350", Length = "0x43")]
	[Token(Token = "0x6002C30")]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[Address(RVA = "0x17DF950", Offset = "0x17DED50", Length = "0x1EF")]
	[Token(Token = "0x6002C32")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x17DFDE0", Offset = "0x17DF1E0", Length = "0xD3")]
	[Token(Token = "0x6002C34")]
	private int Initialize(int capacity) { }

	[Address(RVA = "0x17E0080", Offset = "0x17DF480", Length = "0x6E")]
	[Token(Token = "0x6002C4A")]
	private static bool IsCompatibleKey(object key) { }

	[Address(RVA = "0x17E00F0", Offset = "0x17DF4F0", Length = "0x3D8")]
	[Token(Token = "0x6002C36")]
	public override void OnDeserialization(object sender) { }

	[Address(RVA = "0x17E34A0", Offset = "0x17E28A0", Length = "0x373")]
	[Token(Token = "0x6002C39")]
	public override bool Remove(TKey key) { }

	[Address(RVA = "0x17E2300", Offset = "0x17E1700", Length = "0x39E")]
	[Token(Token = "0x6002C3A")]
	public bool Remove(TKey key, out TValue value) { }

	[Address(RVA = "0x17E4430", Offset = "0x17E3830", Length = "0x80")]
	[Token(Token = "0x6002C37")]
	private void Resize() { }

	[Address(RVA = "0x17E42D0", Offset = "0x17E36D0", Length = "0x150")]
	[Token(Token = "0x6002C38")]
	private void Resize(int newSize, bool forceNewHashCodes) { }

	[Address(RVA = "0x17EF920", Offset = "0x17EED20", Length = "0x43")]
	[Token(Token = "0x6002C27")]
	public override void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0x17E49B0", Offset = "0x17E3DB0", Length = "0x55")]
	[Token(Token = "0x6002C29")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x17E4DA0", Offset = "0x17E41A0", Length = "0xD5")]
	[Token(Token = "0x6002C2A")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x17E4F40", Offset = "0x17E4340", Length = "0x17")]
	[Token(Token = "0x6002C3E")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002C3D")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	[Address(RVA = "0x17E53E0", Offset = "0x17E47E0", Length = "0x10E")]
	[Token(Token = "0x6002C2B")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x17E55F0", Offset = "0x17E49F0", Length = "0x9A")]
	[Token(Token = "0x6002C21")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0x17E5690", Offset = "0x17E4A90", Length = "0x9A")]
	[Token(Token = "0x6002C24")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0x17E57C0", Offset = "0x17E4BC0", Length = "0x9C")]
	[Token(Token = "0x6002C31")]
	private override IEnumerator<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0x17E55F0", Offset = "0x17E49F0", Length = "0x9A")]
	[Token(Token = "0x6002C22")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0x17E5690", Offset = "0x17E4A90", Length = "0x9A")]
	[Token(Token = "0x6002C25")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0x17E69E0", Offset = "0x17E5DE0", Length = "0x454")]
	[Token(Token = "0x6002C3F")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002C42")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x17E7330", Offset = "0x17E6730", Length = "0x68")]
	[Token(Token = "0x6002C43")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x17E79B0", Offset = "0x17E6DB0", Length = "0x1FA")]
	[Token(Token = "0x6002C4B")]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[Address(RVA = "0x17E84B0", Offset = "0x17E78B0", Length = "0x114")]
	[Token(Token = "0x6002C4C")]
	private override bool System.Collections.IDictionary.Contains(object key) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002C44")]
	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002C45")]
	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	[Address(RVA = "0x17E9360", Offset = "0x17E8760", Length = "0x14E")]
	[Token(Token = "0x6002C48")]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[Address(RVA = "0x17E9830", Offset = "0x17E8C30", Length = "0xA9")]
	[Token(Token = "0x6002C46")]
	private override ICollection System.Collections.IDictionary.get_Keys() { }

	[Address(RVA = "0x17E98E0", Offset = "0x17E8CE0", Length = "0xA9")]
	[Token(Token = "0x6002C47")]
	private override ICollection System.Collections.IDictionary.get_Values() { }

	[Address(RVA = "0x17E8810", Offset = "0x17E7C10", Length = "0x9C")]
	[Token(Token = "0x6002C4D")]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[Address(RVA = "0x17E8BC0", Offset = "0x17E7FC0", Length = "0xFB")]
	[Token(Token = "0x6002C4E")]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[Address(RVA = "0x17E9B60", Offset = "0x17E8F60", Length = "0x1FA")]
	[Token(Token = "0x6002C49")]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[Address(RVA = "0x17E57C0", Offset = "0x17E4BC0", Length = "0x9C")]
	[Token(Token = "0x6002C40")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x17EA680", Offset = "0x17E9A80", Length = "0x43")]
	[Token(Token = "0x6002C3C")]
	public bool TryAdd(TKey key, TValue value) { }

	[Address(RVA = "0x17EA9B0", Offset = "0x17E9DB0", Length = "0x89")]
	[Token(Token = "0x6002C3B")]
	public override bool TryGetValue(TKey key, out TValue value) { }

	[Address(RVA = "0x17EB070", Offset = "0x17EA470", Length = "0x666")]
	[Token(Token = "0x6002C35")]
	private bool TryInsert(TKey key, TValue value, InsertionBehavior behavior) { }

}

