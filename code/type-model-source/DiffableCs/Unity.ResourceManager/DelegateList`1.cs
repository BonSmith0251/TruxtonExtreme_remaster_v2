//Type is in global namespace

[Token(Token = "0x2000004")]
internal class DelegateList
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000001")]
	private Func<Action`1<T>, LinkedListNode`1<Action`1<T>>> m_acquireFunc; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000002")]
	private Action<LinkedListNode`1<Action`1<T>>> m_releaseFunc; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000003")]
	private LinkedList<Action`1<T>> m_callbacks; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000004")]
	private bool m_invoking; //Field offset: 0x0

	[Token(Token = "0x17000001")]
	public int Count
	{
		[Address(RVA = "0x17D67A0", Offset = "0x17D5BA0", Length = "0x12")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x17D66C0", Offset = "0x17D5AC0", Length = "0xDE")]
	[Token(Token = "0x6000003")]
	public DelegateList`1(Func<Action`1<T>, LinkedListNode`1<Action`1<T>>> acquireFunc, Action<LinkedListNode`1<Action`1<T>>> releaseFunc) { }

	[Address(RVA = "0x17D54E0", Offset = "0x17D48E0", Length = "0xCA")]
	[Token(Token = "0x6000005")]
	public void Add(Action<T> action) { }

	[Address(RVA = "0x17D5790", Offset = "0x17D4B90", Length = "0xA6")]
	[Token(Token = "0x6000008")]
	public void Clear() { }

	[Address(RVA = "0x17D5840", Offset = "0x17D4C40", Length = "0x2BD")]
	[Token(Token = "0x6000009")]
	public static DelegateList<T> CreateWithGlobalCache() { }

	[Address(RVA = "0x17D67A0", Offset = "0x17D5BA0", Length = "0x12")]
	[Token(Token = "0x6000004")]
	public int get_Count() { }

	[Address(RVA = "0x17D5DD0", Offset = "0x17D51D0", Length = "0x1A9")]
	[Token(Token = "0x6000007")]
	public void Invoke(T res) { }

	[Address(RVA = "0x17D65D0", Offset = "0x17D59D0", Length = "0xE3")]
	[Token(Token = "0x6000006")]
	public void Remove(Action<T> action) { }

}

