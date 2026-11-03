namespace Newtonsoft.Json.Utilities;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000A8")]
internal class DictionaryWrapper : IDictionary<TKey, TValue>, ICollection<KeyValuePair`2<TKey, TValue>>, IEnumerable<KeyValuePair`2<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection
{
	[CompilerGenerated]
	[Token(Token = "0x20000AA")]
	private sealed class <>c
	{
		[Nullable(0)]
		[Token(Token = "0x400040A")]
		public static readonly <>c<TKey, TValue> <>9; //Field offset: 0x0
		[Nullable(0)]
		[Token(Token = "0x400040B")]
		public static Func<DictionaryEntry, KeyValuePair`2<TKey, TValue>> <>9__29_0; //Field offset: 0x0

		[Address(RVA = "0xA508A0", Offset = "0xA4FCA0", Length = "0x11F")]
		[Token(Token = "0x60005A1")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60005A2")]
		public <>c() { }

		[Address(RVA = "0xA34FB0", Offset = "0xA343B0", Length = "0x218")]
		[NullableContext(0)]
		[Token(Token = "0x60005A3")]
		internal KeyValuePair<TKey, TValue> <GetEnumerator>b__29_0(DictionaryEntry de) { }

	}

	[IsReadOnly]
	[Nullable(0)]
	[Token(Token = "0x20000A9")]
	private struct DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[FieldOffset(Offset = "0x0")]
		[Nullable(new IL2CPP_TYPE_U1[] {1, 0, 1, 1})]
		[Token(Token = "0x4000409")]
		private readonly IEnumerator<KeyValuePair`2<TEnumeratorKey, TEnumeratorValue>> _e; //Field offset: 0x0

		[Token(Token = "0x170000C7")]
		public override object Current
		{
			[Address(RVA = "0x17D6C40", Offset = "0x17D6040", Length = "0x37E")]
			[Token(Token = "0x600059E")]
			 get { } //Length: 894
		}

		[Token(Token = "0x170000C4")]
		public override DictionaryEntry Entry
		{
			[Address(RVA = "0x17D6FC0", Offset = "0x17D63C0", Length = "0xCE")]
			[Token(Token = "0x600059B")]
			 get { } //Length: 206
		}

		[Token(Token = "0x170000C5")]
		public override object Key
		{
			[Address(RVA = "0x17D7090", Offset = "0x17D6490", Length = "0x75")]
			[Token(Token = "0x600059C")]
			 get { } //Length: 117
		}

		[Nullable(2)]
		[Token(Token = "0x170000C6")]
		public override object Value
		{
			[Address(RVA = "0x17D7110", Offset = "0x17D6510", Length = "0x76")]
			[NullableContext(2)]
			[Token(Token = "0x600059D")]
			 get { } //Length: 118
		}

		[Address(RVA = "0x17D6BE0", Offset = "0x17D5FE0", Length = "0x56")]
		[Token(Token = "0x600059A")]
		public DictionaryEnumerator`2(IEnumerator<KeyValuePair`2<TEnumeratorKey, TEnumeratorValue>> e) { }

		[Address(RVA = "0x17D6C40", Offset = "0x17D6040", Length = "0x37E")]
		[Token(Token = "0x600059E")]
		public override object get_Current() { }

		[Address(RVA = "0x17D6FC0", Offset = "0x17D63C0", Length = "0xCE")]
		[Token(Token = "0x600059B")]
		public override DictionaryEntry get_Entry() { }

		[Address(RVA = "0x17D7090", Offset = "0x17D6490", Length = "0x75")]
		[Token(Token = "0x600059C")]
		public override object get_Key() { }

		[Address(RVA = "0x17D7110", Offset = "0x17D6510", Length = "0x76")]
		[NullableContext(2)]
		[Token(Token = "0x600059D")]
		public override object get_Value() { }

		[Address(RVA = "0x17D6B40", Offset = "0x17D5F40", Length = "0x45")]
		[Token(Token = "0x600059F")]
		public override bool MoveNext() { }

		[Address(RVA = "0x17D6B90", Offset = "0x17D5F90", Length = "0x48")]
		[Token(Token = "0x60005A0")]
		public override void Reset() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Nullable(2)]
	[Token(Token = "0x4000405")]
	private readonly IDictionary _dictionary; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	[Token(Token = "0x4000406")]
	private readonly IDictionary<TKey, TValue> _genericDictionary; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1})]
	[Token(Token = "0x4000407")]
	private readonly IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Nullable(2)]
	[Token(Token = "0x4000408")]
	private object _syncRoot; //Field offset: 0x0

	[Token(Token = "0x170000BB")]
	public override int Count
	{
		[Address(RVA = "0x17DB800", Offset = "0x17DAC00", Length = "0xE1")]
		[Token(Token = "0x6000588")]
		 get { } //Length: 225
	}

	[Token(Token = "0x170000B7")]
	internal IDictionary<TKey, TValue> GenericDictionary
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600057B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000BC")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x17DB8F0", Offset = "0x17DACF0", Length = "0xD0")]
		[Token(Token = "0x6000589")]
		 get { } //Length: 208
	}

	[Token(Token = "0x170000BA")]
	public override TValue Item
	{
		[Address(RVA = "0x17DB9D0", Offset = "0x17DADD0", Length = "0x296")]
		[Token(Token = "0x6000582")]
		 get { } //Length: 662
		[Address(RVA = "0x17DBF30", Offset = "0x17DB330", Length = "0x2A5")]
		[Token(Token = "0x6000583")]
		 set { } //Length: 677
	}

	[Token(Token = "0x170000B8")]
	public override ICollection<TKey> Keys
	{
		[Address(RVA = "0x17DBC70", Offset = "0x17DB070", Length = "0x13D")]
		[Token(Token = "0x600057E")]
		 get { } //Length: 317
	}

	[Token(Token = "0x170000C1")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x17DA5B0", Offset = "0x17D99B0", Length = "0x4E")]
		[Token(Token = "0x6000597")]
		private get { } //Length: 78
	}

	[Token(Token = "0x170000C2")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x17DA600", Offset = "0x17D9A00", Length = "0x6B")]
		[Token(Token = "0x6000598")]
		private get { } //Length: 107
	}

	[Token(Token = "0x170000BE")]
	private override bool System.Collections.IDictionary.IsFixedSize
	{
		[Address(RVA = "0x17DAC00", Offset = "0x17DA000", Length = "0x67")]
		[Token(Token = "0x6000592")]
		private get { } //Length: 103
	}

	[Nullable(2)]
	[Token(Token = "0x170000BD")]
	private override object System.Collections.IDictionary.Item
	{
		[Address(RVA = "0x17DAC70", Offset = "0x17DA070", Length = "0x240")]
		[Token(Token = "0x600058E")]
		private get { } //Length: 576
		[Address(RVA = "0x17DB0C0", Offset = "0x17DA4C0", Length = "0x234")]
		[Token(Token = "0x600058F")]
		private set { } //Length: 564
	}

	[Token(Token = "0x170000BF")]
	private override ICollection System.Collections.IDictionary.Keys
	{
		[Address(RVA = "0x17DAEC0", Offset = "0x17DA2C0", Length = "0xF9")]
		[Token(Token = "0x6000593")]
		private get { } //Length: 249
	}

	[Token(Token = "0x170000C0")]
	private override ICollection System.Collections.IDictionary.Values
	{
		[Address(RVA = "0x17DAFC0", Offset = "0x17DA3C0", Length = "0xFC")]
		[Token(Token = "0x6000595")]
		private get { } //Length: 252
	}

	[Token(Token = "0x170000C3")]
	public override object UnderlyingDictionary
	{
		[Address(RVA = "0x17DBDB0", Offset = "0x17DB1B0", Length = "0x30")]
		[Token(Token = "0x6000599")]
		 get { } //Length: 48
	}

	[Token(Token = "0x170000B9")]
	public override ICollection<TValue> Values
	{
		[Address(RVA = "0x17DBDE0", Offset = "0x17DB1E0", Length = "0x143")]
		[Token(Token = "0x6000581")]
		 get { } //Length: 323
	}

	[Address(RVA = "0x17DB6B0", Offset = "0x17DAAB0", Length = "0x62")]
	[Token(Token = "0x6000578")]
	public DictionaryWrapper`2(IDictionary dictionary) { }

	[Address(RVA = "0x17DB790", Offset = "0x17DAB90", Length = "0x62")]
	[Token(Token = "0x6000579")]
	public DictionaryWrapper`2(IDictionary<TKey, TValue> dictionary) { }

	[Address(RVA = "0x17DB720", Offset = "0x17DAB20", Length = "0x62")]
	[Token(Token = "0x600057A")]
	public DictionaryWrapper`2(IReadOnlyDictionary<TKey, TValue> dictionary) { }

	[Address(RVA = "0x17D8A50", Offset = "0x17D7E50", Length = "0x284")]
	[Token(Token = "0x600057C")]
	public override void Add(TKey key, TValue value) { }

	[Address(RVA = "0x17D8CE0", Offset = "0x17D80E0", Length = "0x29C")]
	[Token(Token = "0x6000584")]
	public override void Add(KeyValuePair<TKey, TValue> item) { }

	[Address(RVA = "0x17D8F80", Offset = "0x17D8380", Length = "0xF4")]
	[Token(Token = "0x6000585")]
	public override void Clear() { }

	[Address(RVA = "0x17D92A0", Offset = "0x17D86A0", Length = "0x1F6")]
	[Token(Token = "0x6000586")]
	public override bool Contains(KeyValuePair<TKey, TValue> item) { }

	[Address(RVA = "0x17D9080", Offset = "0x17D8480", Length = "0x21A")]
	[Token(Token = "0x600057D")]
	public override bool ContainsKey(TKey key) { }

	[Address(RVA = "0x17D94A0", Offset = "0x17D88A0", Length = "0x551")]
	[Token(Token = "0x6000587")]
	public override void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }

	[Address(RVA = "0x17DB800", Offset = "0x17DAC00", Length = "0xE1")]
	[Token(Token = "0x6000588")]
	public override int get_Count() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600057B")]
	internal IDictionary<TKey, TValue> get_GenericDictionary() { }

	[Address(RVA = "0x17DB8F0", Offset = "0x17DACF0", Length = "0xD0")]
	[Token(Token = "0x6000589")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x17DB9D0", Offset = "0x17DADD0", Length = "0x296")]
	[Token(Token = "0x6000582")]
	public override TValue get_Item(TKey key) { }

	[Address(RVA = "0x17DBC70", Offset = "0x17DB070", Length = "0x13D")]
	[Token(Token = "0x600057E")]
	public override ICollection<TKey> get_Keys() { }

	[Address(RVA = "0x17DBDB0", Offset = "0x17DB1B0", Length = "0x30")]
	[Token(Token = "0x6000599")]
	public override object get_UnderlyingDictionary() { }

	[Address(RVA = "0x17DBDE0", Offset = "0x17DB1E0", Length = "0x143")]
	[Token(Token = "0x6000581")]
	public override ICollection<TValue> get_Values() { }

	[Address(RVA = "0x17D9A00", Offset = "0x17D8E00", Length = "0x28F")]
	[Token(Token = "0x600058B")]
	public override IEnumerator<KeyValuePair`2<TKey, TValue>> GetEnumerator() { }

	[Address(RVA = "0x17D9C90", Offset = "0x17D9090", Length = "0x358")]
	[Token(Token = "0x600058A")]
	public override bool Remove(KeyValuePair<TKey, TValue> item) { }

	[Address(RVA = "0x17DA190", Offset = "0x17D9590", Length = "0x240")]
	[Token(Token = "0x600057F")]
	public override bool Remove(TKey key) { }

	[Address(RVA = "0x17D9FF0", Offset = "0x17D93F0", Length = "0x19D")]
	[Token(Token = "0x6000594")]
	public override void Remove(object key) { }

	[Address(RVA = "0x17DBF30", Offset = "0x17DB330", Length = "0x2A5")]
	[Token(Token = "0x6000583")]
	public override void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0x17DA3E0", Offset = "0x17D97E0", Length = "0x1CC")]
	[Token(Token = "0x6000596")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x17DA5B0", Offset = "0x17D99B0", Length = "0x4E")]
	[Token(Token = "0x6000597")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x17DA600", Offset = "0x17D9A00", Length = "0x6B")]
	[Token(Token = "0x6000598")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x17DA670", Offset = "0x17D9A70", Length = "0x234")]
	[Token(Token = "0x600058D")]
	private override void System.Collections.IDictionary.Add(object key, object value) { }

	[Address(RVA = "0x17DA8B0", Offset = "0x17D9CB0", Length = "0x1D6")]
	[Token(Token = "0x6000591")]
	private override bool System.Collections.IDictionary.Contains(object key) { }

	[Address(RVA = "0x17DAC00", Offset = "0x17DA000", Length = "0x67")]
	[Token(Token = "0x6000592")]
	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	[Address(RVA = "0x17DAC70", Offset = "0x17DA070", Length = "0x240")]
	[Token(Token = "0x600058E")]
	private override object System.Collections.IDictionary.get_Item(object key) { }

	[Address(RVA = "0x17DAEC0", Offset = "0x17DA2C0", Length = "0xF9")]
	[Token(Token = "0x6000593")]
	private override ICollection System.Collections.IDictionary.get_Keys() { }

	[Address(RVA = "0x17DAFC0", Offset = "0x17DA3C0", Length = "0xFC")]
	[Token(Token = "0x6000595")]
	private override ICollection System.Collections.IDictionary.get_Values() { }

	[Address(RVA = "0x17DAA90", Offset = "0x17D9E90", Length = "0x168")]
	[Token(Token = "0x6000590")]
	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	[Address(RVA = "0x17DB0C0", Offset = "0x17DA4C0", Length = "0x234")]
	[Token(Token = "0x600058F")]
	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	[Address(RVA = "0x17DB300", Offset = "0x17DA700", Length = "0x1B")]
	[Token(Token = "0x600058C")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x17DB320", Offset = "0x17DA720", Length = "0x384")]
	[Token(Token = "0x6000580")]
	public override bool TryGetValue(TKey key, out TValue value) { }

}

