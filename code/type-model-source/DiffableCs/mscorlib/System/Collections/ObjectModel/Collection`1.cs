namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
[DefaultMember("Item")]
[Token(Token = "0x20005DE")]
public class Collection : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001843")]
	private IList<T> items; //Field offset: 0x0

	[Token(Token = "0x170006BA")]
	public override int Count
	{
		[Address(RVA = "0x16D7580", Offset = "0x16D6980", Length = "0x46")]
		[Token(Token = "0x6002B80")]
		 get { } //Length: 70
	}

	[Token(Token = "0x170006BC")]
	public override T Item
	{
		[Address(RVA = "0x16D7090", Offset = "0x16D6490", Length = "0x54")]
		[Token(Token = "0x6002B82")]
		 get { } //Length: 84
		[Address(RVA = "0x16D7830", Offset = "0x16D6C30", Length = "0xEE")]
		[Token(Token = "0x6002B83")]
		 set { } //Length: 238
	}

	[Token(Token = "0x170006BB")]
	protected IList<T> Items
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6002B81")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006BD")]
	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		[Address(RVA = "0x16D5520", Offset = "0x16D4920", Length = "0x49")]
		[Token(Token = "0x6002B91")]
		private get { } //Length: 73
	}

	[Token(Token = "0x170006BE")]
	private override bool System.Collections.ICollection.IsSynchronized
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6002B93")]
		private get { } //Length: 3
	}

	[Token(Token = "0x170006BF")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x16D5E20", Offset = "0x16D5220", Length = "0x5C")]
		[Token(Token = "0x6002B94")]
		private get { } //Length: 92
	}

	[Token(Token = "0x170006C2")]
	private override bool System.Collections.IList.IsFixedSize
	{
		[Address(RVA = "0x16D6F30", Offset = "0x16D6330", Length = "0xA7")]
		[Token(Token = "0x6002B99")]
		private get { } //Length: 167
	}

	[Token(Token = "0x170006C1")]
	private override bool System.Collections.IList.IsReadOnly
	{
		[Address(RVA = "0x16D5520", Offset = "0x16D4920", Length = "0x49")]
		[Token(Token = "0x6002B98")]
		private get { } //Length: 73
	}

	[Token(Token = "0x170006C0")]
	private override object System.Collections.IList.Item
	{
		[Address(RVA = "0x16D7090", Offset = "0x16D6490", Length = "0x54")]
		[Token(Token = "0x6002B96")]
		private get { } //Length: 84
		[Address(RVA = "0x16D7340", Offset = "0x16D6740", Length = "0x1B1")]
		[Token(Token = "0x6002B97")]
		private set { } //Length: 433
	}

	[Address(RVA = "0x16D7500", Offset = "0x16D6900", Length = "0x7C")]
	[Token(Token = "0x6002B7E")]
	public Collection`1() { }

	[Address(RVA = "0xEB6850", Offset = "0xEB5C50", Length = "0x42")]
	[Token(Token = "0x6002B7F")]
	public Collection`1(IList<T> list) { }

	[Address(RVA = "0x16D43F0", Offset = "0x16D37F0", Length = "0xD5")]
	[Token(Token = "0x6002B84")]
	public override void Add(T item) { }

	[Address(RVA = "0x16D46A0", Offset = "0x16D3AA0", Length = "0x7C")]
	[Token(Token = "0x6002B85")]
	public override void Clear() { }

	[Address(RVA = "0x16D4650", Offset = "0x16D3A50", Length = "0x49")]
	[Token(Token = "0x6002B8D")]
	protected override void ClearItems() { }

	[Address(RVA = "0x16D4810", Offset = "0x16D3C10", Length = "0x58")]
	[Token(Token = "0x6002B87")]
	public override bool Contains(T item) { }

	[Address(RVA = "0x16D4870", Offset = "0x16D3C70", Length = "0x6A")]
	[Token(Token = "0x6002B86")]
	public override void CopyTo(T[] array, int index) { }

	[Address(RVA = "0x16D7580", Offset = "0x16D6980", Length = "0x46")]
	[Token(Token = "0x6002B80")]
	public override int get_Count() { }

	[Address(RVA = "0x16D7090", Offset = "0x16D6490", Length = "0x54")]
	[Token(Token = "0x6002B82")]
	public override T get_Item(int index) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6002B81")]
	protected IList<T> get_Items() { }

	[Address(RVA = "0x16D48E0", Offset = "0x16D3CE0", Length = "0x46")]
	[Token(Token = "0x6002B88")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0x16D4930", Offset = "0x16D3D30", Length = "0x58")]
	[Token(Token = "0x6002B89")]
	public override int IndexOf(T item) { }

	[Address(RVA = "0x16D4BF0", Offset = "0x16D3FF0", Length = "0xEE")]
	[Token(Token = "0x6002B8A")]
	public override void Insert(int index, T item) { }

	[Address(RVA = "0x16D4B80", Offset = "0x16D3F80", Length = "0x6A")]
	[Token(Token = "0x6002B8E")]
	protected override void InsertItem(int index, T item) { }

	[Address(RVA = "0x16D4FB0", Offset = "0x16D43B0", Length = "0x5E")]
	[Token(Token = "0x6002B9F")]
	private static bool IsCompatibleObject(object value) { }

	[Address(RVA = "0x16D5150", Offset = "0x16D4550", Length = "0xE3")]
	[Token(Token = "0x6002B8B")]
	public override bool Remove(T item) { }

	[Address(RVA = "0x16D5010", Offset = "0x16D4410", Length = "0xDC")]
	[Token(Token = "0x6002B8C")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x16D50F0", Offset = "0x16D44F0", Length = "0x57")]
	[Token(Token = "0x6002B8F")]
	protected override void RemoveItem(int index) { }

	[Address(RVA = "0x16D7830", Offset = "0x16D6C30", Length = "0xEE")]
	[Token(Token = "0x6002B83")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0x16D54B0", Offset = "0x16D48B0", Length = "0x6A")]
	[Token(Token = "0x6002B90")]
	protected override void SetItem(int index, T item) { }

	[Address(RVA = "0x16D5520", Offset = "0x16D4920", Length = "0x49")]
	[Token(Token = "0x6002B91")]
	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	[Address(RVA = "0x16D5570", Offset = "0x16D4970", Length = "0x3F9")]
	[Token(Token = "0x6002B95")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6002B93")]
	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	[Address(RVA = "0x16D5E20", Offset = "0x16D5220", Length = "0x5C")]
	[Token(Token = "0x6002B94")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

	[Address(RVA = "0x16D5ED0", Offset = "0x16D52D0", Length = "0x46")]
	[Token(Token = "0x6002B92")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[Address(RVA = "0x16D5F20", Offset = "0x16D5320", Length = "0x24B")]
	[Token(Token = "0x6002B9A")]
	private override int System.Collections.IList.Add(object value) { }

	[Address(RVA = "0x16D6460", Offset = "0x16D5860", Length = "0x139")]
	[Token(Token = "0x6002B9B")]
	private override bool System.Collections.IList.Contains(object value) { }

	[Address(RVA = "0x16D6F30", Offset = "0x16D6330", Length = "0xA7")]
	[Token(Token = "0x6002B99")]
	private override bool System.Collections.IList.get_IsFixedSize() { }

	[Address(RVA = "0x16D5520", Offset = "0x16D4920", Length = "0x49")]
	[Token(Token = "0x6002B98")]
	private override bool System.Collections.IList.get_IsReadOnly() { }

	[Address(RVA = "0x16D7090", Offset = "0x16D6490", Length = "0x54")]
	[Token(Token = "0x6002B96")]
	private override object System.Collections.IList.get_Item(int index) { }

	[Address(RVA = "0x16D65A0", Offset = "0x16D59A0", Length = "0x13E")]
	[Token(Token = "0x6002B9C")]
	private override int System.Collections.IList.IndexOf(object value) { }

	[Address(RVA = "0x16D69D0", Offset = "0x16D5DD0", Length = "0x205")]
	[Token(Token = "0x6002B9D")]
	private override void System.Collections.IList.Insert(int index, object value) { }

	[Address(RVA = "0x16D6D40", Offset = "0x16D6140", Length = "0x1E8")]
	[Token(Token = "0x6002B9E")]
	private override void System.Collections.IList.Remove(object value) { }

	[Address(RVA = "0x16D7340", Offset = "0x16D6740", Length = "0x1B1")]
	[Token(Token = "0x6002B97")]
	private override void System.Collections.IList.set_Item(int index, object value) { }

}

