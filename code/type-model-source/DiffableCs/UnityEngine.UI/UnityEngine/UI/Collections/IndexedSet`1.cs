namespace UnityEngine.UI.Collections;

[DefaultMember("Item")]
[Token(Token = "0x2000089")]
internal class IndexedSet : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000275")]
	private readonly List<T> m_List; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000276")]
	private Dictionary<T, Int32> m_Dictionary; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000277")]
	private int m_EnabledObjectCount; //Field offset: 0x0

	[Token(Token = "0x1700015A")]
	public int Capacity
	{
		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x6000559")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000159")]
	public override int Count
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000558")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700015B")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600055A")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700015C")]
	public override T Item
	{
		[Address(RVA = "0x1C7C080", Offset = "0x1C7B480", Length = "0x6E")]
		[Token(Token = "0x600055F")]
		 get { } //Length: 110
		[Address(RVA = "0x1C7C0F0", Offset = "0x1C7B4F0", Length = "0xC7")]
		[Token(Token = "0x6000560")]
		 set { } //Length: 199
	}

	[Address(RVA = "0x1C7BE60", Offset = "0x1C7B260", Length = "0xD8")]
	[Token(Token = "0x6000563")]
	public IndexedSet`1() { }

	[Address(RVA = "0x1C7A280", Offset = "0x1C79680", Length = "0x17")]
	[Token(Token = "0x600054D")]
	public override void Add(T item) { }

	[Address(RVA = "0x1C7A2A0", Offset = "0x1C796A0", Length = "0x100")]
	[Token(Token = "0x600054E")]
	public void Add(T item, bool isActive) { }

	[Address(RVA = "0x1C79E10", Offset = "0x1C79210", Length = "0x11E")]
	[Token(Token = "0x600054F")]
	public bool AddUnique(T item, bool isActive = true) { }

	[Address(RVA = "0x1C7A420", Offset = "0x1C79820", Length = "0x71")]
	[Token(Token = "0x6000555")]
	public override void Clear() { }

	[Address(RVA = "0x1C7A4A0", Offset = "0x1C798A0", Length = "0x2A")]
	[Token(Token = "0x6000556")]
	public override bool Contains(T item) { }

	[Address(RVA = "0x1C7A5C0", Offset = "0x1C799C0", Length = "0x2D")]
	[Token(Token = "0x6000557")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0x1C7A620", Offset = "0x1C79A20", Length = "0x90")]
	[Token(Token = "0x6000551")]
	public bool DisableItem(T item) { }

	[Address(RVA = "0x1C7A970", Offset = "0x1C79D70", Length = "0x87")]
	[Token(Token = "0x6000550")]
	public bool EnableItem(T item) { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x6000559")]
	public int get_Capacity() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000558")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600055A")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0x1C7C080", Offset = "0x1C7B480", Length = "0x6E")]
	[Token(Token = "0x600055F")]
	public override T get_Item(int index) { }

	[Address(RVA = "0xABEAA0", Offset = "0xABDEA0", Length = "0x39")]
	[Token(Token = "0x6000553")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0x1C7AB10", Offset = "0x1C79F10", Length = "0x47")]
	[Token(Token = "0x600055B")]
	public override int IndexOf(T item) { }

	[Address(RVA = "0x1C7AB60", Offset = "0x1C79F60", Length = "0x49")]
	[Token(Token = "0x600055C")]
	public override void Insert(int index, T item) { }

	[Address(RVA = "0x1C7B3F0", Offset = "0x1C7A7F0", Length = "0x78")]
	[Token(Token = "0x6000552")]
	public override bool Remove(T item) { }

	[Address(RVA = "0x1C7ABB0", Offset = "0x1C79FB0", Length = "0xCB")]
	[Token(Token = "0x6000561")]
	public void RemoveAll(Predicate<T> match) { }

	[Address(RVA = "0x1C7B160", Offset = "0x1C7A560", Length = "0x149")]
	[Token(Token = "0x600055D")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0x1C7C0F0", Offset = "0x1C7B4F0", Length = "0xC7")]
	[Token(Token = "0x6000560")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0x1C7B6A0", Offset = "0x1C7AAA0", Length = "0xB7")]
	[Token(Token = "0x6000562")]
	public void Sort(Comparison<T> sortLayoutFunction) { }

	[Address(RVA = "0x1C7B760", Offset = "0x1C7AB60", Length = "0x130")]
	[Token(Token = "0x600055E")]
	private void Swap(int index1, int index2) { }

	[Address(RVA = "0x1C7BD50", Offset = "0x1C7B150", Length = "0x29")]
	[Token(Token = "0x6000554")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

