namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView`2))]
[DefaultMember("Item")]
[Token(Token = "0x20001F3")]
public class SortedDictionary : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair`2<TKey, TValue>>
{
	[CompilerGenerated]
	[Token(Token = "0x20001FE")]
	private sealed class <>c__DisplayClass34_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000764")]
		public bool found; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000765")]
		public TValue value; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D0B")]
		public <>c__DisplayClass34_0() { }

		[Address(RVA = "0xA72330", Offset = "0xA71730", Length = "0x27")]
		[Token(Token = "0x6000D0C")]
		internal bool <ContainsValue>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20001FF")]
	private sealed class <>c__DisplayClass34_1
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000766")]
		public EqualityComparer<TValue> valueComparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000767")]
		public <>c__DisplayClass34_0<TKey, TValue> CS$<>8__locals1; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000D0D")]
		public <>c__DisplayClass34_1() { }

		[Address(RVA = "0xA72620", Offset = "0xA71A20", Length = "0x6B")]
		[Token(Token = "0x6000D0E")]
		internal bool <ContainsValue>b__1(Node<KeyValuePair<TKey, TValue>> node) { }

	}

	[Token(Token = "0x20001F4")]
	internal struct Enumerator : IEnumerator<KeyValuePair`2<TKey, TValue>>, IDisposable, IEnumerator, IDictionaryEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000755")]
		private Enumerator<KeyValuePair<TKey, TValue>> _treeEnum; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000756")]
		private int _getEnumeratorRetType; //Field offset: 0x0

		[Token(Token = "0x17000289")]
		public override KeyValuePair<TKey, TValue> Current
		{
			[Address(RVA = "0x19C7D90", Offset = "0x19C7190", Length = "0xA2")]
			[Token(Token = "0x6000CD3")]
			 get { } //Length: 162
		}

		[Token(Token = "0x1700028A")]
		internal bool NotStartedOrEnded
		{
			[Address(RVA = "0x19C7EA0", Offset = "0x19C72A0", Length = "0x84")]
			[Token(Token = "0x6000CD4")]
			internal get { } //Length: 132
		}

		[Token(Token = "0x1700028E")]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
		{
			[Address(RVA = "0x19C2C00", Offset = "0x19C2000", Length = "0x15C")]
			[Token(Token = "0x6000CDA")]
			private get { } //Length: 348
		}

		[Token(Token = "0x1700028C")]
		private override object System.Collections.IDictionaryEnumerator.Key
		{
			[Address(RVA = "0x19C3100", Offset = "0x19C2500", Length = "0xD4")]
			[Token(Token = "0x6000CD8")]
			private get { } //Length: 212
		}

		[Token(Token = "0x1700028D")]
		private override object System.Collections.IDictionaryEnumerator.Value
		{
			[Address(RVA = "0x19C3410", Offset = "0x19C2810", Length = "0xD9")]
			[Token(Token = "0x6000CD9")]
			private get { } //Length: 217
		}

		[Token(Token = "0x1700028B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x19C5B90", Offset = "0x19C4F90", Length = "0x284")]
			[Token(Token = "0x6000CD7")]
			private get { } //Length: 644
		}

		[Address(RVA = "0x19C7800", Offset = "0x19C6C00", Length = "0x8E")]
		[Token(Token = "0x6000CD0")]
		internal Enumerator(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType) { }

		[Address(RVA = "0x19BFCD0", Offset = "0x19BF0D0", Length = "0x84")]
		[Token(Token = "0x6000CD2")]
		public override void Dispose() { }

		[Address(RVA = "0x19C7D90", Offset = "0x19C7190", Length = "0xA2")]
		[Token(Token = "0x6000CD3")]
		public override KeyValuePair<TKey, TValue> get_Current() { }

		[Address(RVA = "0x19C7EA0", Offset = "0x19C72A0", Length = "0x84")]
		[Token(Token = "0x6000CD4")]
		internal bool get_NotStartedOrEnded() { }

		[Address(RVA = "0x19C1EE0", Offset = "0x19C12E0", Length = "0x84")]
		[Token(Token = "0x6000CD1")]
		public override bool MoveNext() { }

		[Address(RVA = "0x19C2590", Offset = "0x19C1990", Length = "0x84")]
		[Token(Token = "0x6000CD5")]
		internal void Reset() { }

		[Address(RVA = "0x19C2C00", Offset = "0x19C2000", Length = "0x15C")]
		[Token(Token = "0x6000CDA")]
		private override DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

		[Address(RVA = "0x19C3100", Offset = "0x19C2500", Length = "0xD4")]
		[Token(Token = "0x6000CD8")]
		private override object System.Collections.IDictionaryEnumerator.get_Key() { }

		[Address(RVA = "0x19C3410", Offset = "0x19C2810", Length = "0xD9")]
		[Token(Token = "0x6000CD9")]
		private override object System.Collections.IDictionaryEnumerator.get_Value() { }

		[Address(RVA = "0x19C5B90", Offset = "0x19C4F90", Length = "0x284")]
		[Token(Token = "0x6000CD7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x19C2590", Offset = "0x19C1990", Length = "0x84")]
		[Token(Token = "0x6000CD6")]
		private override void System.Collections.IEnumerator.Reset() { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView`2))]
	[Token(Token = "0x20001F5")]
	internal sealed class KeyCollection : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey>
	{
		[CompilerGenerated]
		[Token(Token = "0x20001F7")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000759")]
			public TKey[] array; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400075A")]
			public int index; //Field offset: 0x0

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000CEE")]
			public <>c__DisplayClass5_0() { }

			[Address(RVA = "0xA74820", Offset = "0xA73C20", Length = "0x50")]
			[Token(Token = "0x6000CEF")]
			internal bool <CopyTo>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x20001F8")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400075B")]
			public int index; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400075C")]
			public Object[] objects; //Field offset: 0x0

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000CF0")]
			public <>c__DisplayClass6_0() { }

			[Address(RVA = "0xA75200", Offset = "0xA74600", Length = "0x90")]
			[Token(Token = "0x6000CF1")]
			internal bool <System.Collections.ICollection.CopyTo>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

		}

		[Token(Token = "0x20001F6")]
		internal struct Enumerator : IEnumerator<TKey>, IDisposable, IEnumerator
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000758")]
			private Enumerator<TKey, TValue> _dictEnum; //Field offset: 0x0

			[Token(Token = "0x17000293")]
			public override TKey Current
			{
				[Address(RVA = "0x19C7CC0", Offset = "0x19C70C0", Length = "0xCB")]
				[Token(Token = "0x6000CEB")]
				 get { } //Length: 203
			}

			[Token(Token = "0x17000294")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x19C5910", Offset = "0x19C4D10", Length = "0xAA")]
				[Token(Token = "0x6000CEC")]
				private get { } //Length: 170
			}

			[Address(RVA = "0x19C75C0", Offset = "0x19C69C0", Length = "0x75")]
			[Token(Token = "0x6000CE8")]
			internal Enumerator(SortedDictionary<TKey, TValue> dictionary) { }

			[Address(RVA = "0x19BFC90", Offset = "0x19BF090", Length = "0x36")]
			[Token(Token = "0x6000CE9")]
			public override void Dispose() { }

			[Address(RVA = "0x19C7CC0", Offset = "0x19C70C0", Length = "0xCB")]
			[Token(Token = "0x6000CEB")]
			public override TKey get_Current() { }

			[Address(RVA = "0x19C1330", Offset = "0x19C0730", Length = "0x36")]
			[Token(Token = "0x6000CEA")]
			public override bool MoveNext() { }

			[Address(RVA = "0x19C5910", Offset = "0x19C4D10", Length = "0xAA")]
			[Token(Token = "0x6000CEC")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x19C38C0", Offset = "0x19C2CC0", Length = "0x36")]
			[Token(Token = "0x6000CED")]
			private override void System.Collections.IEnumerator.Reset() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000757")]
		private SortedDictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		[Token(Token = "0x1700028F")]
		public override int Count
		{
			[Address(RVA = "0xAE3460", Offset = "0xAE2860", Length = "0x100")]
			[Token(Token = "0x6000CE0")]
			 get { } //Length: 256
		}

		[Token(Token = "0x17000290")]
		private override bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6000CE1")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000291")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000CE6")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000292")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0xAE2350", Offset = "0xAE1750", Length = "0x49")]
			[Token(Token = "0x6000CE7")]
			private get { } //Length: 73
		}

		[Address(RVA = "0xAE33E0", Offset = "0xAE27E0", Length = "0x7F")]
		[Token(Token = "0x6000CDB")]
		public KeyCollection(SortedDictionary<TKey, TValue> dictionary) { }

		[Address(RVA = "0xAD5940", Offset = "0xAD4D40", Length = "0x254")]
		[Token(Token = "0x6000CDE")]
		public override void CopyTo(TKey[] array, int index) { }

		[Address(RVA = "0xAE3460", Offset = "0xAE2860", Length = "0x100")]
		[Token(Token = "0x6000CE0")]
		public override int get_Count() { }

		[Address(RVA = "0xAD6420", Offset = "0xAD5820", Length = "0x49")]
		[Token(Token = "0x6000CE2")]
		private override void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }

		[Address(RVA = "0xAD6470", Offset = "0xAD5870", Length = "0x49")]
		[Token(Token = "0x6000CE3")]
		private override void System.Collections.Generic.ICollection<TKey>.Clear() { }

		[Address(RVA = "0xAD66D0", Offset = "0xAD5AD0", Length = "0x2D")]
		[Token(Token = "0x6000CE4")]
		private override bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000CE1")]
		private override bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }

		[Address(RVA = "0xAD6420", Offset = "0xAD5820", Length = "0x49")]
		[Token(Token = "0x6000CE5")]
		private override bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }

		[Address(RVA = "0xAD69C0", Offset = "0xAD5DC0", Length = "0x7B")]
		[Token(Token = "0x6000CDC")]
		private override IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }

		[Address(RVA = "0xAD8440", Offset = "0xAD7840", Length = "0x44C")]
		[Token(Token = "0x6000CDF")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000CE6")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0xAE2350", Offset = "0xAE1750", Length = "0x49")]
		[Token(Token = "0x6000CE7")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0xAD69C0", Offset = "0xAD5DC0", Length = "0x7B")]
		[Token(Token = "0x6000CDD")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x20001FD")]
	public sealed class KeyValuePairComparer : Comparer<KeyValuePair`2<TKey, TValue>>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000763")]
		internal IComparer<TKey> keyComparer; //Field offset: 0x0

		[Address(RVA = "0xAE8D70", Offset = "0xAE8170", Length = "0x6B")]
		[Token(Token = "0x6000D09")]
		public KeyValuePairComparer(IComparer<TKey> keyComparer) { }

		[Address(RVA = "0xAE8A70", Offset = "0xAE7E70", Length = "0xC1")]
		[Token(Token = "0x6000D0A")]
		public virtual int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y) { }

	}

	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView`2))]
	[Token(Token = "0x20001F9")]
	internal sealed class ValueCollection : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue>
	{
		[CompilerGenerated]
		[Token(Token = "0x20001FB")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400075F")]
			public TValue[] array; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000760")]
			public int index; //Field offset: 0x0

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000D05")]
			public <>c__DisplayClass5_0() { }

			[Address(RVA = "0xA747C0", Offset = "0xA73BC0", Length = "0x55")]
			[Token(Token = "0x6000D06")]
			internal bool <CopyTo>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

		}

		[CompilerGenerated]
		[Token(Token = "0x20001FC")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000761")]
			public int index; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000762")]
			public Object[] objects; //Field offset: 0x0

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000D07")]
			public <>c__DisplayClass6_0() { }

			[Address(RVA = "0xA75160", Offset = "0xA74560", Length = "0x95")]
			[Token(Token = "0x6000D08")]
			internal bool <System.Collections.ICollection.CopyTo>b__0(Node<KeyValuePair<TKey, TValue>> node) { }

		}

		[Token(Token = "0x20001FA")]
		internal struct Enumerator : IEnumerator<TValue>, IDisposable, IEnumerator
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400075E")]
			private Enumerator<TKey, TValue> _dictEnum; //Field offset: 0x0

			[Token(Token = "0x17000299")]
			public override TValue Current
			{
				[Address(RVA = "0x19C7B40", Offset = "0x19C6F40", Length = "0xCB")]
				[Token(Token = "0x6000D02")]
				 get { } //Length: 203
			}

			[Token(Token = "0x1700029A")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x19C5520", Offset = "0x19C4920", Length = "0xAA")]
				[Token(Token = "0x6000D03")]
				private get { } //Length: 170
			}

			[Address(RVA = "0x19C75C0", Offset = "0x19C69C0", Length = "0x75")]
			[Token(Token = "0x6000CFF")]
			internal Enumerator(SortedDictionary<TKey, TValue> dictionary) { }

			[Address(RVA = "0x19BFC90", Offset = "0x19BF090", Length = "0x36")]
			[Token(Token = "0x6000D00")]
			public override void Dispose() { }

			[Address(RVA = "0x19C7B40", Offset = "0x19C6F40", Length = "0xCB")]
			[Token(Token = "0x6000D02")]
			public override TValue get_Current() { }

			[Address(RVA = "0x19C1330", Offset = "0x19C0730", Length = "0x36")]
			[Token(Token = "0x6000D01")]
			public override bool MoveNext() { }

			[Address(RVA = "0x19C5520", Offset = "0x19C4920", Length = "0xAA")]
			[Token(Token = "0x6000D03")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x19C38C0", Offset = "0x19C2CC0", Length = "0x36")]
			[Token(Token = "0x6000D04")]
			private override void System.Collections.IEnumerator.Reset() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400075D")]
		private SortedDictionary<TKey, TValue> _dictionary; //Field offset: 0x0

		[Token(Token = "0x17000295")]
		public override int Count
		{
			[Address(RVA = "0xAE3460", Offset = "0xAE2860", Length = "0x100")]
			[Token(Token = "0x6000CF7")]
			 get { } //Length: 256
		}

		[Token(Token = "0x17000296")]
		private override bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
		{
			[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
			[Token(Token = "0x6000CF8")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000297")]
		private override bool System.Collections.ICollection.IsSynchronized
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x6000CFD")]
			private get { } //Length: 3
		}

		[Token(Token = "0x17000298")]
		private override object System.Collections.ICollection.SyncRoot
		{
			[Address(RVA = "0x120B2D0", Offset = "0x120A6D0", Length = "0x49")]
			[Token(Token = "0x6000CFE")]
			private get { } //Length: 73
		}

		[Address(RVA = "0xAE33E0", Offset = "0xAE27E0", Length = "0x7F")]
		[Token(Token = "0x6000CF2")]
		public ValueCollection(SortedDictionary<TKey, TValue> dictionary) { }

		[Address(RVA = "0xAD5940", Offset = "0xAD4D40", Length = "0x254")]
		[Token(Token = "0x6000CF5")]
		public override void CopyTo(TValue[] array, int index) { }

		[Address(RVA = "0xAE3460", Offset = "0xAE2860", Length = "0x100")]
		[Token(Token = "0x6000CF7")]
		public override int get_Count() { }

		[Address(RVA = "0x12001C0", Offset = "0x11FF5C0", Length = "0x49")]
		[Token(Token = "0x6000CF9")]
		private override void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }

		[Address(RVA = "0x1200210", Offset = "0x11FF610", Length = "0x49")]
		[Token(Token = "0x6000CFA")]
		private override void System.Collections.Generic.ICollection<TValue>.Clear() { }

		[Address(RVA = "0x1200A80", Offset = "0x11FFE80", Length = "0x2D")]
		[Token(Token = "0x6000CFB")]
		private override bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }

		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000CF8")]
		private override bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }

		[Address(RVA = "0x12001C0", Offset = "0x11FF5C0", Length = "0x49")]
		[Token(Token = "0x6000CFC")]
		private override bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }

		[Address(RVA = "0xAD69C0", Offset = "0xAD5DC0", Length = "0x7B")]
		[Token(Token = "0x6000CF3")]
		private override IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }

		[Address(RVA = "0x1209B70", Offset = "0x1208F70", Length = "0x44C")]
		[Token(Token = "0x6000CF6")]
		private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000CFD")]
		private override bool System.Collections.ICollection.get_IsSynchronized() { }

		[Address(RVA = "0x120B2D0", Offset = "0x120A6D0", Length = "0x49")]
		[Token(Token = "0x6000CFE")]
		private override object System.Collections.ICollection.get_SyncRoot() { }

		[Address(RVA = "0xAD69C0", Offset = "0xAD5DC0", Length = "0x7B")]
		[Token(Token = "0x6000CF4")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000752")]
	private KeyCollection<TKey, TValue> _keys; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000753")]
	private ValueCollection<TKey, TValue> _values; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000754")]
	private TreeSet<KeyValuePair`2<TKey, TValue>> _set; //Field offset: 0x0

	[Token(Token = "0x1700027B")]
	public override int Count
	{
		[Address(RVA = "0xF69910", Offset = "0xF68D10", Length = "0x34")]
		[Token(Token = "0x6000CB1")]
		 get { } //Length: 52
	}

	[Token(Token = "0x1700027A")]
	public override TValue Item
	{
		[Address(RVA = "0xF69EA0", Offset = "0xF692A0", Length = "0x135")]
		[Token(Token = "0x6000CAF")]
		 get { } //Length: 309
		[Address(RVA = "0xF6A260", Offset = "0xF69660", Length = "0x199")]
		[Token(Token = "0x6000CB0")]
		 set { } //Length: 409
	}

	[Token(Token = "0x1700027C")]
	public KeyCollection<TKey, TValue> Keys
	{
		[Address(RVA = "0xF69FE0", Offset = "0xF693E0", Length = "0x9A")]
		[Token(Token = "0x6000CB2")]
		 get { } //Length: 154
	}

	[Token(Token = "0x17000279")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000CAE")]
		private get { } //Length: 3
	}

	[Token(Token = "0x1700027D")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0xF67680", Offset = "0xF66A80", Length = "0x17")]
		[Token(Token = "0x6000CB3")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000280")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0xF676E0", Offset = "0xF66AE0", Length = "0x17")]
		[Token(Token = "0x6000CB6")]
		private get { } //Length: 23
	}

	[Token(Token = "0x1700027E")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys
	{
		[Address(RVA = "0xF67680", Offset = "0xF66A80", Length = "0x17")]
		[Token(Token = "0x6000CB4")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000281")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values
	{
		[Address(RVA = "0xF676E0", Offset = "0xF66AE0", Length = "0x17")]
		[Token(Token = "0x6000CB7")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000287")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000CCD")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000288")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0xF67900", Offset = "0xF66D00", Length = "0x49")]
		[Token(Token = "0x6000CCE")]
		private get { } //Length: 73
	}

	[Token(Token = "0x17000282")]
	private override bool System.Collections.IDictionary.IsFixedSize
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000CC2")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000283")]
	private override bool System.Collections.IDictionary.IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000CC3")]
		private get { } //Length: 3
	}

	[Token(Token = "0x17000286")]
	private override object System.Collections.IDictionary.Item
	{
		[Address(RVA = "0xF688C0", Offset = "0xF67CC0", Length = "0x1AB")]
		[Token(Token = "0x6000CC6")]
		private get { } //Length: 427
		[Address(RVA = "0xF68E90", Offset = "0xF68290", Length = "0x275")]
		[Token(Token = "0x6000CC7")]
		private set { } //Length: 629
	}

	[Token(Token = "0x17000284")]
	private override ICollection System.Collections.IDictionary.Keys
	{
		[Address(RVA = "0xF67680", Offset = "0xF66A80", Length = "0x17")]
		[Token(Token = "0x6000CC4")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000285")]
	private override ICollection System.Collections.IDictionary.Values
	{
		[Address(RVA = "0xF676E0", Offset = "0xF66AE0", Length = "0x17")]
		[Token(Token = "0x6000CC5")]
		private get { } //Length: 23
	}

	[Token(Token = "0x1700027F")]
	public ValueCollection<TKey, TValue> Values
	{
		[Address(RVA = "0xF6A120", Offset = "0xF69520", Length = "0x9A")]
		[Token(Token = "0x6000CB5")]
		 get { } //Length: 154
	}

	[Address(RVA = "0xF69730", Offset = "0xF68B30", Length = "0xD9")]
	[Token(Token = "0x6000CA9")]
	public SortedDictionary`2() { }

	[Address(RVA = "0xF69650", Offset = "0xF68A50", Length = "0xD2")]
	[Token(Token = "0x6000CAA")]
	public SortedDictionary`2(IComparer<TKey> comparer) { }

	[Address(RVA = "0xF65E40", Offset = "0xF65240", Length = "0xB2")]
	[Token(Token = "0x6000CB8")]
	public override void Add(TKey key, TValue value) { }

	[Address(RVA = "0xF65F00", Offset = "0xF65300", Length = "0x2A")]
	[Token(Token = "0x6000CB9")]
	public override void Clear() { }

	[Address(RVA = "0xF66240", Offset = "0xF65640", Length = "0xB5")]
	[Token(Token = "0x6000CBA")]
	public override bool ContainsKey(TKey key) { }

	[Address(RVA = "0xF66300", Offset = "0xF65700", Length = "0x20D")]
	[Token(Token = "0x6000CBB")]
	public bool ContainsValue(TValue value) { }

	[Address(RVA = "0xF668B0", Offset = "0xF65CB0", Length = "0x2D")]
	[Token(Token = "0x6000CBC")]
	public override void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }

	[Address(RVA = "0xF69910", Offset = "0xF68D10", Length = "0x34")]
	[Token(Token = "0x6000CB1")]
	public override int get_Count() { }

	[Address(RVA = "0xF69EA0", Offset = "0xF692A0", Length = "0x135")]
	[Token(Token = "0x6000CAF")]
	public override TValue get_Item(TKey key) { }

	[Address(RVA = "0xF69FE0", Offset = "0xF693E0", Length = "0x9A")]
	[Token(Token = "0x6000CB2")]
	public KeyCollection<TKey, TValue> get_Keys() { }

	[Address(RVA = "0xF6A120", Offset = "0xF69520", Length = "0x9A")]
	[Token(Token = "0x6000CB5")]
	public ValueCollection<TKey, TValue> get_Values() { }

	[Address(RVA = "0xF66920", Offset = "0xF65D20", Length = "0x3D")]
	[Token(Token = "0x6000CBD")]
	public Enumerator<TKey, TValue> GetEnumerator() { }

	[Address(RVA = "0xF66960", Offset = "0xF65D60", Length = "0xA1")]
	[Token(Token = "0x6000CCA")]
	private static bool IsCompatibleKey(object key) { }

	[Address(RVA = "0xF66A10", Offset = "0xF65E10", Length = "0xB5")]
	[Token(Token = "0x6000CBF")]
	public override bool Remove(TKey key) { }

	[Address(RVA = "0xF6A260", Offset = "0xF69660", Length = "0x199")]
	[Token(Token = "0x6000CB0")]
	public override void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0xF66DF0", Offset = "0xF661F0", Length = "0x37")]
	[Token(Token = "0x6000CAB")]
	private override void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0xF671F0", Offset = "0xF665F0", Length = "0xD2")]
	[Token(Token = "0x6000CAC")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000CAE")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	[Address(RVA = "0xF67590", Offset = "0xF66990", Length = "0xE8")]
	[Token(Token = "0x6000CAD")]
	private override bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }

	[Address(RVA = "0xF67680", Offset = "0xF66A80", Length = "0x17")]
	[Token(Token = "0x6000CB3")]
	private override ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0xF676E0", Offset = "0xF66AE0", Length = "0x17")]
	[Token(Token = "0x6000CB6")]
	private override ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0xF67700", Offset = "0xF66B00", Length = "0x86")]
	[Token(Token = "0x6000CBE")]
	private override IEnumerator<KeyValuePair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0xF67680", Offset = "0xF66A80", Length = "0x17")]
	[Token(Token = "0x6000CB4")]
	private override IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }

	[Address(RVA = "0xF676E0", Offset = "0xF66AE0", Length = "0x17")]
	[Token(Token = "0x6000CB7")]
	private override IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }

	[Address(RVA = "0xF67890", Offset = "0xF66C90", Length = "0x67")]
	[Token(Token = "0x6000CC1")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000CCD")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0xF67900", Offset = "0xF66D00", Length = "0x49")]
	[Token(Token = "0x6000CCE")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0xF67DC0", Offset = "0xF671C0", Length = "0x2C9")]
	[Token(Token = "0x6000CC8")]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[Address(RVA = "0xF681C0", Offset = "0xF675C0", Length = "0x17E")]
	[Token(Token = "0x6000CC9")]
	private override bool System.Collections.IDictionary.Contains(object key) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000CC2")]
	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000CC3")]
	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	[Address(RVA = "0xF688C0", Offset = "0xF67CC0", Length = "0x1AB")]
	[Token(Token = "0x6000CC6")]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[Address(RVA = "0xF67680", Offset = "0xF66A80", Length = "0x17")]
	[Token(Token = "0x6000CC4")]
	private override ICollection System.Collections.IDictionary.get_Keys() { }

	[Address(RVA = "0xF676E0", Offset = "0xF66AE0", Length = "0x17")]
	[Token(Token = "0x6000CC5")]
	private override ICollection System.Collections.IDictionary.get_Values() { }

	[Address(RVA = "0xF683D0", Offset = "0xF677D0", Length = "0x86")]
	[Token(Token = "0x6000CCB")]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[Address(RVA = "0xF68580", Offset = "0xF67980", Length = "0x17D")]
	[Token(Token = "0x6000CCC")]
	private override void System.Collections.IDictionary.Remove(object key) { }

	[Address(RVA = "0xF68E90", Offset = "0xF68290", Length = "0x275")]
	[Token(Token = "0x6000CC7")]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[Address(RVA = "0xF67700", Offset = "0xF66B00", Length = "0x86")]
	[Token(Token = "0x6000CCF")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0xF69110", Offset = "0xF68510", Length = "0xF3")]
	[Token(Token = "0x6000CC0")]
	public override bool TryGetValue(TKey key, out TValue value) { }

}

