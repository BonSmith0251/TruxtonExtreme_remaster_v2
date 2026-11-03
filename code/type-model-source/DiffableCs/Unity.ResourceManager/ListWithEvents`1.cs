//Type is in global namespace

[DefaultMember("Item")]
[Token(Token = "0x2000005")]
internal class ListWithEvents : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000005")]
	private List<T> m_List; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000006")]
	private Action<T> OnElementAdded; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000007")]
	private Action<T> OnElementRemoved; //Field offset: 0x0

	[Token(Token = "0x14000001")]
	public event Action<T> OnElementAdded
	{
		[Address(RVA = "0xB0EAC0", Offset = "0xB0DEC0", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x600000A")]
		 add { } //Length: 192
		[Address(RVA = "0xB0EE00", Offset = "0xB0E200", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x600000B")]
		 remove { } //Length: 192
	}

	[Token(Token = "0x14000002")]
	public event Action<T> OnElementRemoved
	{
		[Address(RVA = "0xB0EB90", Offset = "0xB0DF90", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x600000C")]
		 add { } //Length: 192
		[Address(RVA = "0xB0EED0", Offset = "0xB0E2D0", Length = "0xC0")]
		[CompilerGenerated]
		[Token(Token = "0x600000D")]
		 remove { } //Length: 192
	}

	[Token(Token = "0x17000003")]
	public override int Count
	{
		[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000004")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0xB0ECB0", Offset = "0xB0E0B0", Length = "0x49")]
		[Token(Token = "0x6000013")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000002")]
	public override T Item
	{
		[Address(RVA = "0xB0EDD0", Offset = "0xB0E1D0", Length = "0x2A")]
		[Token(Token = "0x6000010")]
		 get { } //Length: 42
		[Address(RVA = "0xB0F270", Offset = "0xB0E670", Length = "0xBF")]
		[Token(Token = "0x6000011")]
		 set { } //Length: 191
	}

	[Address(RVA = "0xB0EA30", Offset = "0xB0DE30", Length = "0x83")]
	[Token(Token = "0x600001E")]
	public ListWithEvents`1() { }

	[Address(RVA = "0xB0D620", Offset = "0xB0CA20", Length = "0xAC")]
	[Token(Token = "0x6000014")]
	public override void Add(T item) { }

	[Address(RVA = "0xB0EAC0", Offset = "0xB0DEC0", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x600000A")]
	public void add_OnElementAdded(Action<T> value) { }

	[Address(RVA = "0xB0EB90", Offset = "0xB0DF90", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x600000C")]
	public void add_OnElementRemoved(Action<T> value) { }

	[Address(RVA = "0xB0DB90", Offset = "0xB0CF90", Length = "0x16C")]
	[Token(Token = "0x6000015")]
	public override void Clear() { }

	[Address(RVA = "0xB0DDF0", Offset = "0xB0D1F0", Length = "0x2D")]
	[Token(Token = "0x6000016")]
	public override bool Contains(T item) { }

	[Address(RVA = "0xB0DE20", Offset = "0xB0D220", Length = "0x2D")]
	[Token(Token = "0x6000017")]
	public override void CopyTo(T[] array, int arrayIndex) { }

	[Address(RVA = "0xB0EC60", Offset = "0xB0E060", Length = "0x1A")]
	[Token(Token = "0x6000012")]
	public override int get_Count() { }

	[Address(RVA = "0xB0ECB0", Offset = "0xB0E0B0", Length = "0x49")]
	[Token(Token = "0x6000013")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0xB0EDD0", Offset = "0xB0E1D0", Length = "0x2A")]
	[Token(Token = "0x6000010")]
	public override T get_Item(int index) { }

	[Address(RVA = "0xB0DE80", Offset = "0xB0D280", Length = "0x65")]
	[Token(Token = "0x6000018")]
	public override IEnumerator<T> GetEnumerator() { }

	[Address(RVA = "0xB0E090", Offset = "0xB0D490", Length = "0x2D")]
	[Token(Token = "0x6000019")]
	public override int IndexOf(T item) { }

	[Address(RVA = "0xB0E0C0", Offset = "0xB0D4C0", Length = "0x5A")]
	[Token(Token = "0x600001A")]
	public override void Insert(int index, T item) { }

	[Address(RVA = "0xB0E3B0", Offset = "0xB0D7B0", Length = "0x19")]
	[Token(Token = "0x600000E")]
	private void InvokeAdded(T element) { }

	[Address(RVA = "0xB0E3D0", Offset = "0xB0D7D0", Length = "0x19")]
	[Token(Token = "0x600000F")]
	private void InvokeRemoved(T element) { }

	[Address(RVA = "0xB0E880", Offset = "0xB0DC80", Length = "0x7F")]
	[Token(Token = "0x600001B")]
	public override bool Remove(T item) { }

	[Address(RVA = "0xB0EE00", Offset = "0xB0E200", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x600000B")]
	public void remove_OnElementAdded(Action<T> value) { }

	[Address(RVA = "0xB0EED0", Offset = "0xB0E2D0", Length = "0xC0")]
	[CompilerGenerated]
	[Token(Token = "0x600000D")]
	public void remove_OnElementRemoved(Action<T> value) { }

	[Address(RVA = "0xB0E670", Offset = "0xB0DA70", Length = "0x92")]
	[Token(Token = "0x600001C")]
	public override void RemoveAt(int index) { }

	[Address(RVA = "0xB0F270", Offset = "0xB0E670", Length = "0xBF")]
	[Token(Token = "0x6000011")]
	public override void set_Item(int index, T value) { }

	[Address(RVA = "0xB0E900", Offset = "0xB0DD00", Length = "0x46")]
	[Token(Token = "0x600001D")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

