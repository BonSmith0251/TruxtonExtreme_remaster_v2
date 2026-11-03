namespace UnityEngine.TextCore.Text;

[DebuggerDisplay("Item count = {m_Count}")]
[Token(Token = "0x200006C")]
internal struct TextProcessingStack
{
	[Token(Token = "0x4000474")]
	private const int k_DefaultCapacity = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400046E")]
	public T[] itemStack; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400046F")]
	public int index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000470")]
	private T m_DefaultItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000471")]
	private int m_Capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000472")]
	private int m_RolloverSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000473")]
	private int m_Count; //Field offset: 0x0

	[Token(Token = "0x17000087")]
	public int Count
	{
		[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
		[Token(Token = "0x6000331")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000088")]
	public T current
	{
		[Address(RVA = "0xFDAA30", Offset = "0xFD9E30", Length = "0x45")]
		[Token(Token = "0x6000332")]
		 get { } //Length: 69
	}

	[Address(RVA = "0xFDB880", Offset = "0xFDAC80", Length = "0x3D")]
	[Token(Token = "0x600032E")]
	public TextProcessingStack`1(T[] stack) { }

	[Address(RVA = "0xFDB780", Offset = "0xFDAB80", Length = "0x70")]
	[Token(Token = "0x600032F")]
	public TextProcessingStack`1(int capacity) { }

	[Address(RVA = "0xFDB6B0", Offset = "0xFDAAB0", Length = "0x7F")]
	[Token(Token = "0x6000330")]
	public TextProcessingStack`1(int capacity, int rolloverSize) { }

	[Address(RVA = "0xFDA910", Offset = "0xFD9D10", Length = "0x39")]
	[Token(Token = "0x6000336")]
	public void Add(T item) { }

	[Address(RVA = "0xFDA9A0", Offset = "0xFD9DA0", Length = "0x9")]
	[Token(Token = "0x6000334")]
	public void Clear() { }

	[Address(RVA = "0xFDAA30", Offset = "0xFD9E30", Length = "0x45")]
	[Token(Token = "0x600033B")]
	public T CurrentItem() { }

	[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
	[Token(Token = "0x6000331")]
	public int get_Count() { }

	[Address(RVA = "0xFDAA30", Offset = "0xFD9E30", Length = "0x45")]
	[Token(Token = "0x6000332")]
	public T get_current() { }

	[Address(RVA = "0xFDAAE0", Offset = "0xFD9EE0", Length = "0x3A")]
	[Token(Token = "0x600033A")]
	public T Peek() { }

	[Address(RVA = "0xFDABB0", Offset = "0xFD9FB0", Length = "0x8C")]
	[Token(Token = "0x6000339")]
	public T Pop() { }

	[Address(RVA = "0x10721D0", Offset = "0x10715D0", Length = "0xBE")]
	[Token(Token = "0x6000338")]
	public void Push(T item) { }

	[Address(RVA = "0xFDB020", Offset = "0xFDA420", Length = "0x60")]
	[Token(Token = "0x6000337")]
	public T Remove() { }

	[Address(RVA = "0xFDB240", Offset = "0xFDA640", Length = "0x115")]
	[Token(Token = "0x6000333")]
	internal static void SetDefault(TextProcessingStack<T>[] stack, T item) { }

	[Address(RVA = "0xFDB420", Offset = "0xFDA820", Length = "0xA2")]
	[Token(Token = "0x6000335")]
	public void SetDefault(T item) { }

}

