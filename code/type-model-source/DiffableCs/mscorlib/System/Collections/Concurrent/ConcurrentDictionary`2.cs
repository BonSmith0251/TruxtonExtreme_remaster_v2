namespace System.Collections.Concurrent;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
[Token(Token = "0x20005D7")]
public class ConcurrentDictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>
{
	[CompilerGenerated]
	[Token(Token = "0x20005DB")]
	private sealed class <GetEnumerator>d__35 : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400183D")]
		private int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400183E")]
		private KeyValuePair<TKey, TValue> <>2__current; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400183F")]
		public ConcurrentDictionary<TKey, TValue> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001840")]
		private Node<TKey, TValue>[] <buckets>5__2; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001841")]
		private int <i>5__3; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001842")]
		private Node<TKey, TValue> <current>5__4; //Field offset: 0x0

		[Token(Token = "0x170006B8")]
		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current
		{
			[Address(RVA = "0xABF730", Offset = "0xABEB30", Length = "0x15")]
			[DebuggerHidden]
			[Token(Token = "0x6002B7B")]
			private get { } //Length: 21
		}

		[Token(Token = "0x170006B9")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x1806240", Offset = "0x1805640", Length = "0x36")]
			[DebuggerHidden]
			[Token(Token = "0x6002B7D")]
			private get { } //Length: 54
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6002B78")]
		public <GetEnumerator>d__35(int <>1__state) { }

		[Address(RVA = "0x1805F30", Offset = "0x1805330", Length = "0x178")]
		[Token(Token = "0x6002B7A")]
		private override bool MoveNext() { }

		[Address(RVA = "0xABF730", Offset = "0xABEB30", Length = "0x15")]
		[DebuggerHidden]
		[Token(Token = "0x6002B7B")]
		private override KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }

		[Address(RVA = "0x1806240", Offset = "0x1805640", Length = "0x36")]
		[DebuggerHidden]
		[Token(Token = "0x6002B7D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0xA663F0", Offset = "0xA657F0", Length = "0x39")]
		[DebuggerHidden]
		[Token(Token = "0x6002B7C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6002B79")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x20005DA")]
	private sealed class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400183C")]
		private IEnumerator<KeyValuePair`2<TKey, TValue>> _enumerator; //Field offset: 0x0

		[Token(Token = "0x170006B7")]
		public override object Current
		{
			[Address(RVA = "0x17D75D0", Offset = "0x17D69D0", Length = "0x14E")]
			[Token(Token = "0x6002B75")]
			 get { } //Length: 334
		}

		[Token(Token = "0x170006B4")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x17D8020", Offset = "0x17D7420", Length = "0x10B")]
			[Token(Token = "0x6002B72")]
			 get { } //Length: 267
		}

		[Token(Token = "0x170006B5")]
		public override object Key
		{
			[Address(RVA = "0x17D8520", Offset = "0x17D7920", Length = "0x79")]
			[Token(Token = "0x6002B73")]
			 get { } //Length: 121
		}

		[Token(Token = "0x170006B6")]
		public override object Value
		{
			[Address(RVA = "0x17D85A0", Offset = "0x17D79A0", Length = "0x5C")]
			[Token(Token = "0x6002B74")]
			 get { } //Length: 92
		}

		[Address(RVA = "0x17D7410", Offset = "0x17D6810", Length = "0x5F")]
		[Token(Token = "0x6002B71")]
		internal DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary) { }

		[Address(RVA = "0x17D75D0", Offset = "0x17D69D0", Length = "0x14E")]
		[Token(Token = "0x6002B75")]
		public override object get_Current() { }

		[Address(RVA = "0x17D8020", Offset = "0x17D7420", Length = "0x10B")]
		[Token(Token = "0x6002B72")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x17D8520", Offset = "0x17D7920", Length = "0x79")]
		[Token(Token = "0x6002B73")]
		public override object get_Key() { }

		[Address(RVA = "0x17D85A0", Offset = "0x17D79A0", Length = "0x5C")]
		[Token(Token = "0x6002B74")]
		public override object get_Value() { }

		[Address(RVA = "0x17D7190", Offset = "0x17D6590", Length = "0x46")]
		[Token(Token = "0x6002B76")]
		public override bool MoveNext() { }

		[Address(RVA = "0x17D7320", Offset = "0x17D6720", Length = "0x49")]
		[Token(Token = "0x6002B77")]
		public override void Reset() { }

	}

	[Token(Token = "0x20005D9")]
	private sealed class Node
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001838")]
		internal readonly TKey _key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001839")]
		internal TValue _value; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400183A")]
		internal Node<TKey, TValue> _next; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400183B")]
		internal readonly int _hashcode; //Field offset: 0x0

		[Address(RVA = "0xD99830", Offset = "0xD98C30", Length = "0x78")]
		[Token(Token = "0x6002B70")]
		internal Node(TKey key, TValue value, int hashcode, Node<TKey, TValue> next) { }

	}

	[Token(Token = "0x20005D8")]
	private sealed class Tables
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001835")]
		internal readonly Node<TKey, TValue>[] _buckets; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001836")]
		internal readonly Object[] _locks; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001837")]
		internal Int32[] _countPerLock; //Field offset: 0x0

		[Address(RVA = "0xFE2E70", Offset = "0xFE2270", Length = "0x70")]
		[Token(Token = "0x6002B6F")]
		internal Tables(Node<TKey, TValue>[] buckets, Object[] locks, Int32[] countPerLock) { }

	}

	[Token(Token = "0x4001834")]
	private static readonly bool s_isValueWriteAtomic; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400182D")]
	private Tables<TKey, TValue> _tables; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400182E")]
	private IEqualityComparer<TKey> _comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400182F")]
	private readonly bool _growLockArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001830")]
	private int _budget; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001831")]
	private KeyValuePair<TKey, TValue>[] _serializationArray; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001832")]
	private int _serializationConcurrencyLevel; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001833")]
	private int _serializationCapacity; //Field offset: 0x0

	[Token(Token = "0x170006A6")]
	public override int Count
	{
		[Address(RVA = "0x17ABA40", Offset = "0x17AAE40", Length = "0xED")]
		[Token(Token = "0x6002B46")]
		 get { } //Length: 237
	}

	[Token(Token = "0x170006B3")]
	private static int DefaultConcurrencyLevel
	{
		[Address(RVA = "0x17ABB30", Offset = "0x17AAF30", Length = "0x40")]
		[Token(Token = "0x6002B65")]
		private get { } //Length: 64
	}

	[Token(Token = "0x170006A5")]
	public override TValue Item
	{
		[Address(RVA = "0x17ABB70", Offset = "0x17AAF70", Length = "0xC0")]
		[Token(Token = "0x6002B42")]
		 get { } //Length: 192
		[Address(RVA = "0x17ABC40", Offset = "0x17AB040", Length = "0x148")]
		[Token(Token = "0x6002B43")]
		 set { } //Length: 328
	}

	[Token(Token = "0x170006A7")]
	public override ICollection<TKey> Keys
	{
		[Address(RVA = "0x17A8D40", Offset = "0x17A8140", Length = "0x17")]
		[Token(Token = "0x6002B4C")]
		 get { } //Length: 23
	}

	[Token(Token = "0x170006AB")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002B52")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006A8")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0x17A8D40", Offset = "0x17A8140", Length = "0x17")]
		[Token(Token = "0x6002B4D")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170006AA")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0x17A8D60", Offset = "0x17A8160", Length = "0x17")]
		[Token(Token = "0x6002B4F")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170006B1")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002B60")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006B2")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x17A9420", Offset = "0x17A8820", Length = "0x49")]
		[Token(Token = "0x6002B61")]
		private get { } //Length: 73
	}

	[Token(Token = "0x170006AC")]
	private override bool System.Collections.IDictionary.IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002B58")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006AD")]
	private override bool System.Collections.IDictionary.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002B59")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006B0")]
	private override object System.Collections.IDictionary.Item
	{
		[Address(RVA = "0x17A99F0", Offset = "0x17A8DF0", Length = "0x119")]
		[Token(Token = "0x6002B5D")]
		private get { } //Length: 281
		[Address(RVA = "0x17A9B10", Offset = "0x17A8F10", Length = "0x333")]
		[Token(Token = "0x6002B5E")]
		private set { } //Length: 819
	}

	[Token(Token = "0x170006AE")]
	private override ICollection System.Collections.IDictionary.Keys
	{
		[Address(RVA = "0x17A8D40", Offset = "0x17A8140", Length = "0x17")]
		[Token(Token = "0x6002B5A")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170006AF")]
	private override ICollection System.Collections.IDictionary.Values
	{
		[Address(RVA = "0x17A8D60", Offset = "0x17A8160", Length = "0x17")]
		[Token(Token = "0x6002B5C")]
		private get { } //Length: 23
	}

	[Token(Token = "0x170006A9")]
	public override ICollection<TValue> Values
	{
		[Address(RVA = "0x17A8D60", Offset = "0x17A8160", Length = "0x17")]
		[Token(Token = "0x6002B4E")]
		 get { } //Length: 23
	}

	[Address(RVA = "0x17AB380", Offset = "0x17AA780", Length = "0x124")]
	[Token(Token = "0x6002B6E")]
	private static ConcurrentDictionary`2() { }

	[Address(RVA = "0x17AB4E0", Offset = "0x17AA8E0", Length = "0xB4")]
	[Token(Token = "0x6002B30")]
	public ConcurrentDictionary`2() { }

	[Address(RVA = "0x17AB980", Offset = "0x17AAD80", Length = "0xBD")]
	[Token(Token = "0x6002B31")]
	public ConcurrentDictionary`2(IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x17AB5A0", Offset = "0x17AA9A0", Length = "0x3DC")]
	[Token(Token = "0x6002B33")]
	internal ConcurrentDictionary`2(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0x17A6160", Offset = "0x17A5560", Length = "0x167")]
	[Token(Token = "0x6002B66")]
	private void AcquireAllLocks(ref int locksAcquired) { }

	[Address(RVA = "0x17A62D0", Offset = "0x17A56D0", Length = "0xF1")]
	[Token(Token = "0x6002B67")]
	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }

	[Address(RVA = "0x17A63D0", Offset = "0x17A57D0", Length = "0x2C2")]
	[Token(Token = "0x6002B3A")]
	public override void Clear() { }

	[Address(RVA = "0x17A66A0", Offset = "0x17A5AA0", Length = "0x3B")]
	[Token(Token = "0x6002B35")]
	public override bool ContainsKey(TKey key) { }

	[Address(RVA = "0x17A66E0", Offset = "0x17A5AE0", Length = "0x160")]
	[Token(Token = "0x6002B3E")]
	private void CopyToEntries(DictionaryEntry[] array, int index) { }

	[Address(RVA = "0x17A6850", Offset = "0x17A5C50", Length = "0x1C1")]
	[Token(Token = "0x6002B3F")]
	private void CopyToObjects(Object[] array, int index) { }

	[Address(RVA = "0x17A6A20", Offset = "0x17A5E20", Length = "0x177")]
	[Token(Token = "0x6002B3D")]
	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) { }

	[Address(RVA = "0x17ABA40", Offset = "0x17AAE40", Length = "0xED")]
	[Token(Token = "0x6002B46")]
	public override int get_Count() { }

	[Address(RVA = "0x17ABB30", Offset = "0x17AAF30", Length = "0x40")]
	[Token(Token = "0x6002B65")]
	private static int get_DefaultConcurrencyLevel() { }

	[Address(RVA = "0x17ABB70", Offset = "0x17AAF70", Length = "0xC0")]
	[Token(Token = "0x6002B42")]
	public override TValue get_Item(TKey key) { }

	[Address(RVA = "0x17A8D40", Offset = "0x17A8140", Length = "0x17")]
	[Token(Token = "0x6002B4C")]
	public override ICollection<TKey> get_Keys() { }

	[Address(RVA = "0x17A8D60", Offset = "0x17A8160", Length = "0x17")]
	[Token(Token = "0x6002B4E")]
	public override ICollection<TValue> get_Values() { }

	[Address(RVA = "0x17A6BC0", Offset = "0x17A5FC0", Length = "0x10")]
	[Token(Token = "0x6002B63")]
	private static int GetBucket(int hashcode, int bucketCount) { }

	[Address(RVA = "0x17A6BA0", Offset = "0x17A5FA0", Length = "0x1B")]
	[Token(Token = "0x6002B64")]
	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }

	[Address(RVA = "0x17A6BD0", Offset = "0x17A5FD0", Length = "0xAC")]
	[Token(Token = "0x6002B47")]
	private int GetCountInternal() { }

	[Address(RVA = "0x17A6C80", Offset = "0x17A6080", Length = "0x8C")]
	[IteratorStateMachine(typeof(<GetEnumerator>d__35))]
	[Token(Token = "0x6002B40")]
	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	[Address(RVA = "0x17A6D10", Offset = "0x17A6110", Length = "0x2DA")]
	[Token(Token = "0x6002B69")]
	private ReadOnlyCollection<TKey> GetKeys() { }

	[Address(RVA = "0x17A71E0", Offset = "0x17A65E0", Length = "0x188")]
	[Token(Token = "0x6002B49")]
	public TValue GetOrAdd(TKey key, TValue value) { }

	[Address(RVA = "0x17A6FF0", Offset = "0x17A63F0", Length = "0x1EC")]
	[Token(Token = "0x6002B48")]
	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) { }

	[Address(RVA = "0x17A7370", Offset = "0x17A6770", Length = "0x2CC")]
	[Token(Token = "0x6002B6A")]
	private ReadOnlyCollection<TValue> GetValues() { }

	[Address(RVA = "0x17A7640", Offset = "0x17A6A40", Length = "0x840")]
	[Token(Token = "0x6002B62")]
	private void GrowTable(Tables<TKey, TValue> tables) { }

	[Address(RVA = "0x17A7E90", Offset = "0x17A7290", Length = "0x3FC")]
	[Token(Token = "0x6002B32")]
	private void InitializeFromCollection(IEnumerable<KeyValuePair`2<TKey, TValue>> collection) { }

	[Address(RVA = "0x17A8290", Offset = "0x17A7690", Length = "0xC0")]
	[Token(Token = "0x6002B2F")]
	private static bool IsValueWriteAtomic() { }

	[Address(RVA = "0x17A8380", Offset = "0x17A7780", Length = "0x1FA")]
	[OnDeserialized]
	[Token(Token = "0x6002B6D")]
	private void OnDeserialized(StreamingContext context) { }

	[Address(RVA = "0x17A8580", Offset = "0x17A7980", Length = "0x13")]
	[OnSerialized]
	[Token(Token = "0x6002B6C")]
	private void OnSerialized(StreamingContext context) { }

	[Address(RVA = "0x17A85A0", Offset = "0x17A79A0", Length = "0x80")]
	[OnSerializing]
	[Token(Token = "0x6002B6B")]
	private void OnSerializing(StreamingContext context) { }

	[Address(RVA = "0x17A8630", Offset = "0x17A7A30", Length = "0x88")]
	[Token(Token = "0x6002B68")]
	private void ReleaseLocks(int fromInclusive, int toExclusive) { }

	[Address(RVA = "0x17ABC40", Offset = "0x17AB040", Length = "0x148")]
	[Token(Token = "0x6002B43")]
	public override void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0x17A86C0", Offset = "0x17A7AC0", Length = "0xD0")]
	[Token(Token = "0x6002B50")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x17A87A0", Offset = "0x17A7BA0", Length = "0x9F")]
	[Token(Token = "0x6002B51")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x17A8840", Offset = "0x17A7C40", Length = "0x2A5")]
	[Token(Token = "0x6002B3B")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002B52")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	[Address(RVA = "0x17A8AF0", Offset = "0x17A7EF0", Length = "0x4C")]
	[Token(Token = "0x6002B53")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x17A8B40", Offset = "0x17A7F40", Length = "0x19D")]
	[Token(Token = "0x6002B4A")]
	private override void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	[Address(RVA = "0x17A8CE0", Offset = "0x17A80E0", Length = "0x56")]
	[Token(Token = "0x6002B4B")]
	private override bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	[Address(RVA = "0x17A8D40", Offset = "0x17A8140", Length = "0x17")]
	[Token(Token = "0x6002B4D")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0x17A8D60", Offset = "0x17A8160", Length = "0x17")]
	[Token(Token = "0x6002B4F")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0x17A8D80", Offset = "0x17A8180", Length = "0x69C")]
	[Token(Token = "0x6002B5F")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002B60")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x17A9420", Offset = "0x17A8820", Length = "0x49")]
	[Token(Token = "0x6002B61")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x17A9470", Offset = "0x17A8870", Length = "0x281")]
	[Token(Token = "0x6002B55")]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[Address(RVA = "0x17A9700", Offset = "0x17A8B00", Length = "0x12F")]
	[Token(Token = "0x6002B56")]
	private override bool System.Collections.IDictionary.Contains(object key) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002B58")]
	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002B59")]
	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	[Address(RVA = "0x17A99F0", Offset = "0x17A8DF0", Length = "0x119")]
	[Token(Token = "0x6002B5D")]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[Address(RVA = "0x17A8D40", Offset = "0x17A8140", Length = "0x17")]
	[Token(Token = "0x6002B5A")]
	private override ICollection System.Collections.IDictionary.get_Keys() { }

	[Address(RVA = "0x17A8D60", Offset = "0x17A8160", Length = "0x17")]
	[Token(Token = "0x6002B5C")]
	private override ICollection System.Collections.IDictionary.get_Values() { }

	[Address(RVA = "0x17A9830", Offset = "0x17A8C30", Length = "0x73")]
	[Token(Token = "0x6002B57")]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[Address(RVA = "0x17A98B0", Offset = "0x17A8CB0", Length = "0x134")]
	[Token(Token = "0x6002B5B")]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[Address(RVA = "0x17A9B10", Offset = "0x17A8F10", Length = "0x333")]
	[Token(Token = "0x6002B5E")]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[Address(RVA = "0x17A9E50", Offset = "0x17A9250", Length = "0x9B")]
	[Token(Token = "0x6002B54")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x17A9EF0", Offset = "0x17A92F0", Length = "0x77")]
	[Token(Token = "0x6002B44")]
	private static void ThrowKeyNotFoundException(object key) { }

	[Address(RVA = "0x17A9F70", Offset = "0x17A9370", Length = "0x49")]
	[Token(Token = "0x6002B45")]
	private static void ThrowKeyNullException() { }

	[Address(RVA = "0x17A9FC0", Offset = "0x17A93C0", Length = "0x2E5")]
	[Token(Token = "0x6002B3C")]
	public KeyValuePair<TKey, TValue>[] ToArray() { }

	[Address(RVA = "0x17AA9C0", Offset = "0x17A9DC0", Length = "0x148")]
	[Token(Token = "0x6002B34")]
	public bool TryAdd(TKey key, TValue value) { }

	[Address(RVA = "0x17AA2B0", Offset = "0x17A96B0", Length = "0x707")]
	[Token(Token = "0x6002B41")]
	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }

	[Address(RVA = "0x17AACF0", Offset = "0x17AA0F0", Length = "0x126")]
	[Token(Token = "0x6002B38")]
	public override bool TryGetValue(TKey key, out TValue value) { }

	[Address(RVA = "0x17AAB10", Offset = "0x17A9F10", Length = "0x1DD")]
	[Token(Token = "0x6002B39")]
	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }

	[Address(RVA = "0x17AB340", Offset = "0x17AA740", Length = "0x3E")]
	[Token(Token = "0x6002B36")]
	public bool TryRemove(TKey key, out TValue value) { }

	[Address(RVA = "0x17AAE20", Offset = "0x17AA220", Length = "0x515")]
	[Token(Token = "0x6002B37")]
	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }

}

