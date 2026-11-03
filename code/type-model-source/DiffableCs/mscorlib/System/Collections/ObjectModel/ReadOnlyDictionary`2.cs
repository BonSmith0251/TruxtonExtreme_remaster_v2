namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(DictionaryDebugView`2))]
[DefaultMember("Item")]
[Token(Token = "0x20005E1")]
public class ReadOnlyDictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>
{
	[Token(Token = "0x20005E2")]
	private struct DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400184E")]
		private readonly IDictionary<TKey, TValue> _dictionary; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400184F")]
		private IEnumerator<KeyValuePair`2<TKey, TValue>> _enumerator; //Field offset: 0x0

		[Token(Token = "0x170006E3")]
		public override object Current
		{
			[Address(RVA = "0x17D7720", Offset = "0x17D6B20", Length = "0xA7")]
			[Token(Token = "0x6002BF8")]
			 get { } //Length: 167
		}

		[Token(Token = "0x170006E0")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x17D78B0", Offset = "0x17D6CB0", Length = "0x34E")]
			[Token(Token = "0x6002BF5")]
			 get { } //Length: 846
		}

		[Token(Token = "0x170006E1")]
		public override object Key
		{
			[Address(RVA = "0x17D8340", Offset = "0x17D7740", Length = "0x1DC")]
			[Token(Token = "0x6002BF6")]
			 get { } //Length: 476
		}

		[Token(Token = "0x170006E2")]
		public override object Value
		{
			[Address(RVA = "0x17D8600", Offset = "0x17D7A00", Length = "0x1DC")]
			[Token(Token = "0x6002BF7")]
			 get { } //Length: 476
		}

		[Address(RVA = "0x17D7470", Offset = "0x17D6870", Length = "0x87")]
		[Token(Token = "0x6002BF4")]
		public DictionaryEnumerator(IDictionary<TKey, TValue> dictionary) { }

		[Address(RVA = "0x17D7720", Offset = "0x17D6B20", Length = "0xA7")]
		[Token(Token = "0x6002BF8")]
		public override object get_Current() { }

		[Address(RVA = "0x17D78B0", Offset = "0x17D6CB0", Length = "0x34E")]
		[Token(Token = "0x6002BF5")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x17D8340", Offset = "0x17D7740", Length = "0x1DC")]
		[Token(Token = "0x6002BF6")]
		public override object get_Key() { }

		[Address(RVA = "0x17D8600", Offset = "0x17D7A00", Length = "0x1DC")]
		[Token(Token = "0x6002BF7")]
		public override object get_Value() { }

		[Address(RVA = "0x17D7280", Offset = "0x17D6680", Length = "0x46")]
		[Token(Token = "0x6002BF9")]
		public override bool MoveNext() { }

		[Address(RVA = "0x17D72D0", Offset = "0x17D66D0", Length = "0x49")]
		[Token(Token = "0x6002BFA")]
		public override void Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebugView`1))]
	[Token(Token = "0x20005E3")]
	internal sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001850")]
		private readonly ICollection<TKey> _collection; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001851")]
		private object _syncRoot; //Field offset: 0x0

		[Token(Token = "0x170006E4")]
		public override int Count
		{
			[Address(RVA = "0xAE73A0", Offset = "0xAE67A0", Length = "0xB1")]
			[Token(Token = "0x6002C00")]
			 get { } //Length: 177
		}

		[Token(Token = "0x170006E5")]
		private override bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002C01")]
			private get { } //Length: 3
		}

		[Token(Token = "0x170006E6")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6002C06")]
			private get { } //Length: 3
		}

		[Token(Token = "0x170006E7")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0xAE7050", Offset = "0xAE6450", Length = "0xD4")]
			[Token(Token = "0x6002C07")]
			private get { } //Length: 212
		}

		[Address(RVA = "0xAE7320", Offset = "0xAE6720", Length = "0x7F")]
		[Token(Token = "0x6002BFB")]
		internal KeyCollection(ICollection<TKey> collection) { }

		[Address(RVA = "0xAE7310", Offset = "0xAE6710", Length = "0xC")]
		[Token(Token = "0x6002C08")]
		internal KeyCollection() { }

		[Address(RVA = "0xAE3CC0", Offset = "0xAE30C0", Length = "0xC9")]
		[Token(Token = "0x6002BFF")]
		public override void CopyTo(TKey[] array, int arrayIndex) { }

		[Address(RVA = "0xAE73A0", Offset = "0xAE67A0", Length = "0xB1")]
		[Token(Token = "0x6002C00")]
		public override int get_Count() { }

		[Address(RVA = "0xAE3F60", Offset = "0xAE3360", Length = "0x46")]
		[Token(Token = "0x6002C03")]
		public override IEnumerator<TKey> GetEnumerator() { }

		[Address(RVA = "0xAE3FF0", Offset = "0xAE33F0", Length = "0x49")]
		[Token(Token = "0x6002BFC")]
		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		[Address(RVA = "0xAE4040", Offset = "0xAE3440", Length = "0x49")]
		[Token(Token = "0x6002BFD")]
		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		[Address(RVA = "0xAE4350", Offset = "0xAE3750", Length = "0x165")]
		[Token(Token = "0x6002BFE")]
		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002C01")]
		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		[Address(RVA = "0xAE3FF0", Offset = "0xAE33F0", Length = "0x49")]
		[Token(Token = "0x6002C02")]
		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		[Address(RVA = "0xAE6E50", Offset = "0xAE6250", Length = "0x19")]
		[Token(Token = "0x6002C05")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002C06")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0xAE7050", Offset = "0xAE6450", Length = "0xD4")]
		[Token(Token = "0x6002C07")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0xAE72C0", Offset = "0xAE66C0", Length = "0x46")]
		[Token(Token = "0x6002C04")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebugView`1))]
	[Token(Token = "0x20005E4")]
	internal sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001852")]
		private readonly ICollection<TValue> _collection; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001853")]
		private object _syncRoot; //Field offset: 0x0

		[Token(Token = "0x170006E8")]
		public override int Count
		{
			[Address(RVA = "0xAE73A0", Offset = "0xAE67A0", Length = "0xB1")]
			[Token(Token = "0x6002C0E")]
			 get { } //Length: 177
		}

		[Token(Token = "0x170006E9")]
		private override bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6002C0F")]
			private get { } //Length: 3
		}

		[Token(Token = "0x170006EA")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6002C14")]
			private get { } //Length: 3
		}

		[Token(Token = "0x170006EB")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x120B690", Offset = "0x120AA90", Length = "0xD4")]
			[Token(Token = "0x6002C15")]
			private get { } //Length: 212
		}

		[Address(RVA = "0xAE7320", Offset = "0xAE6720", Length = "0x7F")]
		[Token(Token = "0x6002C09")]
		internal ValueCollection(ICollection<TValue> collection) { }

		[Address(RVA = "0xAE7310", Offset = "0xAE6710", Length = "0xC")]
		[Token(Token = "0x6002C16")]
		internal ValueCollection() { }

		[Address(RVA = "0xAE3CC0", Offset = "0xAE30C0", Length = "0xC9")]
		[Token(Token = "0x6002C0D")]
		public override void CopyTo(TValue[] array, int arrayIndex) { }

		[Address(RVA = "0xAE73A0", Offset = "0xAE67A0", Length = "0xB1")]
		[Token(Token = "0x6002C0E")]
		public override int get_Count() { }

		[Address(RVA = "0xAE3F60", Offset = "0xAE3360", Length = "0x46")]
		[Token(Token = "0x6002C11")]
		public override IEnumerator<TValue> GetEnumerator() { }

		[Address(RVA = "0xAE3FF0", Offset = "0xAE33F0", Length = "0x49")]
		[Token(Token = "0x6002C0A")]
		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		[Address(RVA = "0xAE4040", Offset = "0xAE3440", Length = "0x49")]
		[Token(Token = "0x6002C0B")]
		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		[Address(RVA = "0xAE4350", Offset = "0xAE3750", Length = "0x165")]
		[Token(Token = "0x6002C0C")]
		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002C0F")]
		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		[Address(RVA = "0xAE3FF0", Offset = "0xAE33F0", Length = "0x49")]
		[Token(Token = "0x6002C10")]
		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		[Address(RVA = "0xAE6E50", Offset = "0xAE6250", Length = "0x19")]
		[Token(Token = "0x6002C13")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002C14")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0x120B690", Offset = "0x120AA90", Length = "0xD4")]
		[Token(Token = "0x6002C15")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0x120C1C0", Offset = "0x120B5C0", Length = "0x46")]
		[Token(Token = "0x6002C12")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400184A")]
	private readonly IDictionary<TKey, TValue> m_dictionary; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400184B")]
	private object _syncRoot; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400184C")]
	private KeyCollection<TKey, TValue> _keys; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400184D")]
	private ValueCollection<TKey, TValue> _values; //Field offset: 0x0

	[Token(Token = "0x170006D5")]
	public override int Count
	{
		[Address(RVA = "0xF187D0", Offset = "0xF17BD0", Length = "0x49")]
		[Token(Token = "0x6002BDA")]
		 get { } //Length: 73
	}

	[Token(Token = "0x170006D3")]
	public override TValue Item
	{
		[Address(RVA = "0xF17630", Offset = "0xF16A30", Length = "0x13D")]
		[Token(Token = "0x6002BD5")]
		 get { } //Length: 317
	}

	[Token(Token = "0x170006CF")]
	public KeyCollection<TKey, TValue> Keys
	{
		[Address(RVA = "0xF18820", Offset = "0xF17C20", Length = "0xD9")]
		[Token(Token = "0x6002BCF")]
		 get { } //Length: 217
	}

	[Token(Token = "0x170006D6")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002BDD")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006D4")]
	private override TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item
	{
		[Address(RVA = "0xF17630", Offset = "0xF16A30", Length = "0x13D")]
		[Token(Token = "0x6002BD8")]
		private get { } //Length: 317
		[Address(RVA = "0xF175E0", Offset = "0xF169E0", Length = "0x49")]
		[Token(Token = "0x6002BD9")]
		private set { } //Length: 73
	}

	[Token(Token = "0x170006D1")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0xF17770", Offset = "0xF16B70", Length = "0x18")]
		[Token(Token = "0x6002BD2")]
		private get { } //Length: 24
	}

	[Token(Token = "0x170006D2")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0xF17790", Offset = "0xF16B90", Length = "0x18")]
		[Token(Token = "0x6002BD4")]
		private get { } //Length: 24
	}

	[Token(Token = "0x170006DE")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0xF17770", Offset = "0xF16B70", Length = "0x18")]
		[Token(Token = "0x6002BF2")]
		private get { } //Length: 24
	}

	[Token(Token = "0x170006DF")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0xF17790", Offset = "0xF16B90", Length = "0x18")]
		[Token(Token = "0x6002BF3")]
		private get { } //Length: 24
	}

	[Token(Token = "0x170006DC")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002BF0")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006DD")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xF181D0", Offset = "0xF175D0", Length = "0xD4")]
		[Token(Token = "0x6002BF1")]
		private get { } //Length: 212
	}

	[Token(Token = "0x170006D7")]
	private override bool System.Collections.IDictionary.IsFixedSize
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002BE8")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006D8")]
	private override bool System.Collections.IDictionary.IsReadOnly
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6002BE9")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006DB")]
	private override object System.Collections.IDictionary.Item
	{
		[Address(RVA = "0xF18490", Offset = "0xF17890", Length = "0x16B")]
		[Token(Token = "0x6002BED")]
		private get { } //Length: 363
		[Address(RVA = "0xF175E0", Offset = "0xF169E0", Length = "0x49")]
		[Token(Token = "0x6002BEE")]
		private set { } //Length: 73
	}

	[Token(Token = "0x170006D9")]
	private override ICollection System.Collections.IDictionary.Keys
	{
		[Address(RVA = "0xF17770", Offset = "0xF16B70", Length = "0x18")]
		[Token(Token = "0x6002BEA")]
		private get { } //Length: 24
	}

	[Token(Token = "0x170006DA")]
	private override ICollection System.Collections.IDictionary.Values
	{
		[Address(RVA = "0xF17790", Offset = "0xF16B90", Length = "0x18")]
		[Token(Token = "0x6002BEC")]
		private get { } //Length: 24
	}

	[Token(Token = "0x170006D0")]
	public ValueCollection<TKey, TValue> Values
	{
		[Address(RVA = "0xF18900", Offset = "0xF17D00", Length = "0xD9")]
		[Token(Token = "0x6002BD0")]
		 get { } //Length: 217
	}

	[Address(RVA = "0xF172D0", Offset = "0xF166D0", Length = "0xEA")]
	[Token(Token = "0x6002BD1")]
	public override bool ContainsKey(TKey key) { }

	[Address(RVA = "0xF187D0", Offset = "0xF17BD0", Length = "0x49")]
	[Token(Token = "0x6002BDA")]
	public override int get_Count() { }

	[Address(RVA = "0xF17630", Offset = "0xF16A30", Length = "0x13D")]
	[Token(Token = "0x6002BD5")]
	public override TValue get_Item(TKey key) { }

	[Address(RVA = "0xF18820", Offset = "0xF17C20", Length = "0xD9")]
	[Token(Token = "0x6002BCF")]
	public KeyCollection<TKey, TValue> get_Keys() { }

	[Address(RVA = "0xF18900", Offset = "0xF17D00", Length = "0xD9")]
	[Token(Token = "0x6002BD0")]
	public ValueCollection<TKey, TValue> get_Values() { }

	[Address(RVA = "0xF173C0", Offset = "0xF167C0", Length = "0x49")]
	[Token(Token = "0x6002BE1")]
	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	[Address(RVA = "0xF17410", Offset = "0xF16810", Length = "0x9E")]
	[Token(Token = "0x6002BE3")]
	private static bool IsCompatibleKey(object key) { }

	[Address(RVA = "0xAE3FF0", Offset = "0xAE33F0", Length = "0x49")]
	[Token(Token = "0x6002BDE")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }

	[Address(RVA = "0xAE4040", Offset = "0xAE3440", Length = "0x49")]
	[Token(Token = "0x6002BDF")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }

	[Address(RVA = "0xF174B0", Offset = "0xF168B0", Length = "0xB4")]
	[Token(Token = "0x6002BDB")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }

	[Address(RVA = "0xF17570", Offset = "0xF16970", Length = "0x6D")]
	[Token(Token = "0x6002BDC")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6002BDD")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	[Address(RVA = "0xAE3FF0", Offset = "0xAE33F0", Length = "0x49")]
	[Token(Token = "0x6002BE0")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }

	[Address(RVA = "0xF175E0", Offset = "0xF169E0", Length = "0x49")]
	[Token(Token = "0x6002BD6")]
	private override void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	[Address(RVA = "0xF17630", Offset = "0xF16A30", Length = "0x13D")]
	[Token(Token = "0x6002BD8")]
	private override TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }

	[Address(RVA = "0xF17770", Offset = "0xF16B70", Length = "0x18")]
	[Token(Token = "0x6002BD2")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0xF17790", Offset = "0xF16B90", Length = "0x18")]
	[Token(Token = "0x6002BD4")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0xAE3FF0", Offset = "0xAE33F0", Length = "0x49")]
	[Token(Token = "0x6002BD7")]
	private override bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	[Address(RVA = "0xF175E0", Offset = "0xF169E0", Length = "0x49")]
	[Token(Token = "0x6002BD9")]
	private override void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }

	[Address(RVA = "0xF17770", Offset = "0xF16B70", Length = "0x18")]
	[Token(Token = "0x6002BF2")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0xF17790", Offset = "0xF16B90", Length = "0x18")]
	[Token(Token = "0x6002BF3")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0xF177B0", Offset = "0xF16BB0", Length = "0xA10")]
	[Token(Token = "0x6002BEF")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002BF0")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0xF181D0", Offset = "0xF175D0", Length = "0xD4")]
	[Token(Token = "0x6002BF1")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xF175E0", Offset = "0xF169E0", Length = "0x49")]
	[Token(Token = "0x6002BE4")]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[Address(RVA = "0xAE4040", Offset = "0xAE3440", Length = "0x49")]
	[Token(Token = "0x6002BE5")]
	private override void System.Collections.IDictionary.Clear() { }

	[Address(RVA = "0xF182B0", Offset = "0xF176B0", Length = "0x11B")]
	[Token(Token = "0x6002BE6")]
	private override bool System.Collections.IDictionary.Contains(object key) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6002BE8")]
	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6002BE9")]
	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	[Address(RVA = "0xF18490", Offset = "0xF17890", Length = "0x16B")]
	[Token(Token = "0x6002BED")]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[Address(RVA = "0xF17770", Offset = "0xF16B70", Length = "0x18")]
	[Token(Token = "0x6002BEA")]
	private override ICollection System.Collections.IDictionary.get_Keys() { }

	[Address(RVA = "0xF17790", Offset = "0xF16B90", Length = "0x18")]
	[Token(Token = "0x6002BEC")]
	private override ICollection System.Collections.IDictionary.get_Values() { }

	[Address(RVA = "0xF183D0", Offset = "0xF177D0", Length = "0xB9")]
	[Token(Token = "0x6002BE7")]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[Address(RVA = "0xAE3FF0", Offset = "0xAE33F0", Length = "0x49")]
	[Token(Token = "0x6002BEB")]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[Address(RVA = "0xF175E0", Offset = "0xF169E0", Length = "0x49")]
	[Token(Token = "0x6002BEE")]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[Address(RVA = "0xF18600", Offset = "0xF17A00", Length = "0x46")]
	[Token(Token = "0x6002BE2")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xF18650", Offset = "0xF17A50", Length = "0x178")]
	[Token(Token = "0x6002BD3")]
	public override bool TryGetValue(TKey key, out TValue value) { }

}

