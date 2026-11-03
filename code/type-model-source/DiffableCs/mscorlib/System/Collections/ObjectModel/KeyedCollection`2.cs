namespace System.Collections.ObjectModel;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView`1))]
[DefaultMember("Item")]
[Token(Token = "0x20005E0")]
public abstract class KeyedCollection : Collection<TItem>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001846")]
	private readonly IEqualityComparer<TKey> comparer; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001847")]
	private Dictionary<TKey, TItem> dict; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001848")]
	private int keyCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001849")]
	private readonly int threshold; //Field offset: 0x0

	[Token(Token = "0x170006CE")]
	protected IDictionary<TKey, TItem> Dictionary
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6002BC6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170006CD")]
	public TItem Item
	{
		[Address(RVA = "0xAF3FD0", Offset = "0xAF33D0", Length = "0xB5")]
		[Token(Token = "0x6002BC3")]
		 get { } //Length: 181
	}

	[Token(Token = "0x170006CC")]
	private List<TItem> Items
	{
		[Address(RVA = "0xAF4140", Offset = "0xAF3540", Length = "0x86")]
		[Token(Token = "0x6002BC2")]
		private get { } //Length: 134
	}

	[Address(RVA = "0xAF3BF0", Offset = "0xAF2FF0", Length = "0x18")]
	[Token(Token = "0x6002BBF")]
	protected KeyedCollection`2() { }

	[Address(RVA = "0xAF37D0", Offset = "0xAF2BD0", Length = "0x1B9")]
	[Token(Token = "0x6002BC0")]
	protected KeyedCollection`2(IEqualityComparer<TKey> comparer) { }

	[Address(RVA = "0xAF39D0", Offset = "0xAF2DD0", Length = "0x219")]
	[Token(Token = "0x6002BC1")]
	protected KeyedCollection`2(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold) { }

	[Address(RVA = "0xAF0B40", Offset = "0xAEFF40", Length = "0x110")]
	[Token(Token = "0x6002BCC")]
	private void AddKey(TKey key, TItem item) { }

	[Address(RVA = "0xAF0CD0", Offset = "0xAF00D0", Length = "0x65")]
	[Token(Token = "0x6002BC7")]
	protected virtual void ClearItems() { }

	[Address(RVA = "0xAF12E0", Offset = "0xAF06E0", Length = "0x2BD")]
	[Token(Token = "0x6002BC4")]
	public bool Contains(TKey key) { }

	[Address(RVA = "0xAF15A0", Offset = "0xAF09A0", Length = "0x257")]
	[Token(Token = "0x6002BCD")]
	private void CreateDictionary() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6002BC6")]
	protected IDictionary<TKey, TItem> get_Dictionary() { }

	[Address(RVA = "0xAF3FD0", Offset = "0xAF33D0", Length = "0xB5")]
	[Token(Token = "0x6002BC3")]
	public TItem get_Item(TKey key) { }

	[Address(RVA = "0xAF4140", Offset = "0xAF3540", Length = "0x86")]
	[Token(Token = "0x6002BC2")]
	private List<TItem> get_Items() { }

	[Token(Token = "0x6002BC8")]
	protected abstract TKey GetKeyForItem(TItem item) { }

	[Address(RVA = "0xAF1D10", Offset = "0xAF1110", Length = "0x8D")]
	[Token(Token = "0x6002BC9")]
	protected virtual void InsertItem(int index, TItem item) { }

	[Address(RVA = "0xAF2090", Offset = "0xAF1490", Length = "0x150")]
	[Token(Token = "0x6002BCA")]
	protected virtual void RemoveItem(int index) { }

	[Address(RVA = "0xAF2450", Offset = "0xAF1850", Length = "0x3C")]
	[Token(Token = "0x6002BCE")]
	private void RemoveKey(TKey key) { }

	[Address(RVA = "0xAF2580", Offset = "0xAF1980", Length = "0x21B")]
	[Token(Token = "0x6002BCB")]
	protected virtual void SetItem(int index, TItem item) { }

	[Address(RVA = "0xAF2E50", Offset = "0xAF2250", Length = "0x2F0")]
	[Token(Token = "0x6002BC5")]
	public bool TryGetValue(TKey key, out TItem item) { }

}

