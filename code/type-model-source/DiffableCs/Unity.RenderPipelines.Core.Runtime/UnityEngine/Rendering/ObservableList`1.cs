namespace UnityEngine.Rendering;

[DefaultMember("Item")]
[Token(Token = "0x2000060")]
public class ObservableList : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400014E")]
	private List<T> m_List; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400014F")]
	private readonly Comparison<T> m_Comparison; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000150")]
	private ListChangedEventHandler<T> ItemAdded; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000151")]
	private ListChangedEventHandler<T> ItemRemoved; //Field offset: 0x0

	[Token(Token = "0x14000003")]
	public event ListChangedEventHandler<T> ItemAdded
	{
		[Address(RVA = "0xB0EB90", Offset = "0xB0DF90", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x600054D")]
		 add { } //Length: 192
		[Address(RVA = "0xB0EED0", Offset = "0xB0E2D0", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x600054E")]
		 remove { } //Length: 192
	}

	[Token(Token = "0x14000004")]
	public event ListChangedEventHandler<T> ItemRemoved
	{
		[Address(RVA = "0xE0F860", Offset = "0xE0EC60", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x600054F")]
		 add { } //Length: 192
		[Address(RVA = "0xE0FA60", Offset = "0xE0EE60", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x6000550")]
		 remove { } //Length: 192
	}

	[Token(Token = "0x17000045")]
	public override int Count
	{
		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x6000553")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000046")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x6000554")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000044")]
	public override T Item
	{
		[Address(RVA = "0xE0F960", Offset = "0xE0ED60", Length = "0x2A")]
		[Token(Token = "0x6000551")]
		 get { } //Length: 42
		[Address(RVA = "0xE0FB30", Offset = "0xE0EF30", Length = "0xD7")]
		[Token(Token = "0x6000552")]
		 set { } //Length: 215
	}

	[Address(RVA = "0xE0F530", Offset = "0xE0E930", Length = "0xEC")]
	[Token(Token = "0x6000557")]
	public ObservableList`1(IEnumerable<T> collection, Comparison<T> comparison = null) { }

	[Address(RVA = "0xE0F6E0", Offset = "0xE0EAE0", Length = "0xAC")]
	[Token(Token = "0x6000556")]
	public ObservableList`1(int capacity, Comparison<T> comparison = null) { }

	[Address(RVA = "0xE0F620", Offset = "0xE0EA20", Length = "0x9E")]
	[Token(Token = "0x6000555")]
	public ObservableList`1() { }

	[Address(RVA = "0xE0DB70", Offset = "0xE0CF70", Length = "0x1A4")]
	[Token(Token = "0x600055C")]
	public void Add(T[] items) { }

	[Address(RVA = "0xE0DF80", Offset = "0xE0D380", Length = "0x13E")]
	[Token(Token = "0x600055B")]
	public override void Add(T item) { }

	[Address(RVA = "0xB0EB90", Offset = "0xB0DF90", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x600054D")]
	public void add_ItemAdded(ListChangedEventHandler<T> value) { }

	[Address(RVA = "0xE0F860", Offset = "0xE0EC60", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x600054F")]
	public void add_ItemRemoved(ListChangedEventHandler<T> value) { }

	[Address(RVA = "0xE0E160", Offset = "0xE0D560", Length = "0xF1")]
	[Token(Token = "0x6000561")]
	public override void Clear() { }

	[Address(RVA = "0xE0E350", Offset = "0xE0D750", Length = "0x2D")]
	[Token(Token = "0x6000559")]
	public override bool Contains(T item) { }

	[Address(RVA = "0xE0E380", Offset = "0xE0D780", Length = "0x2D")]
	[Token(Token = "0x6000562")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x6000553")]
	public override int get_Count() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000554")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0xE0F960", Offset = "0xE0ED60", Length = "0x2A")]
	[Token(Token = "0x6000551")]
	public override T get_Item(int index) { }

	[Address(RVA = "0xE0E3E0", Offset = "0xE0D7E0", Length = "0x6B")]
	[Token(Token = "0x6000563")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0xE0E510", Offset = "0xE0D910", Length = "0x2D")]
	[Token(Token = "0x600055A")]
	public override int IndexOf(T item) { }

	[Address(RVA = "0xE0E810", Offset = "0xE0DC10", Length = "0xBD")]
	[Token(Token = "0x600055D")]
	public override void Insert(int index, T item) { }

	[Address(RVA = "0xE0E8D0", Offset = "0xE0DCD0", Length = "0xAB")]
	[Token(Token = "0x6000558")]
	private void OnEvent(ListChangedEventHandler<T> e, int index, T item) { }

	[Address(RVA = "0xE0F040", Offset = "0xE0E440", Length = "0xBD")]
	[Token(Token = "0x600055E")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xE0ED50", Offset = "0xE0E150", Length = "0x143")]
	[Token(Token = "0x600055F")]
	public int Remove(T[] items) { }

	[Address(RVA = "0xB0EED0", Offset = "0xB0E2D0", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x600054E")]
	public void remove_ItemAdded(ListChangedEventHandler<T> value) { }

	[Address(RVA = "0xE0FA60", Offset = "0xE0EE60", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x6000550")]
	public void remove_ItemRemoved(ListChangedEventHandler<T> value) { }

	[Address(RVA = "0xE0EAE0", Offset = "0xE0DEE0", Length = "0x9E")]
	[Token(Token = "0x6000560")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0xE0FB30", Offset = "0xE0EF30", Length = "0xD7")]
	[Token(Token = "0x6000552")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0xE0F340", Offset = "0xE0E740", Length = "0x40")]
	[Token(Token = "0x6000565")]
	private void Sort() { }

	[Address(RVA = "0xE0F400", Offset = "0xE0E800", Length = "0x7A")]
	[Token(Token = "0x6000564")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

