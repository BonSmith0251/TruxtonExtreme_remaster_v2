namespace TMPro;

[DebuggerDisplay("Item count = {m_Count}")]
[Token(Token = "0x20000B4")]
public struct TMP_TextProcessingStack
{
	[Token(Token = "0x400067C")]
	private const int k_DefaultCapacity = 4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000676")]
	public T[] itemStack; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000677")]
	public int index; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000678")]
	private T m_DefaultItem; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000679")]
	private int m_Capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400067A")]
	private int m_RolloverSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400067B")]
	private int m_Count; //Field offset: 0x0

	[Token(Token = "0x170001A4")]
	public int Count
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60006D4")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170001A5")]
	public T current
	{
		[Address(RVA = "0xFDAA30", Offset = "0xFD9E30", Length = "0x45")]
		[Token(Token = "0x60006D5")]
		 get { } //Length: 69
	}

	[Token(Token = "0x170001A6")]
	public int rolloverSize
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x60006D6")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x60006D7")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xFDB880", Offset = "0xFDAC80", Length = "0x3D")]
	[Token(Token = "0x60006D1")]
	public TMP_TextProcessingStack`1(T[] stack) { }

	[Address(RVA = "0xFDB780", Offset = "0xFDAB80", Length = "0x70")]
	[Token(Token = "0x60006D2")]
	public TMP_TextProcessingStack`1(int capacity) { }

	[Address(RVA = "0xFDB6B0", Offset = "0xFDAAB0", Length = "0x7F")]
	[Token(Token = "0x60006D3")]
	public TMP_TextProcessingStack`1(int capacity, int rolloverSize) { }

	[Address(RVA = "0xFDA910", Offset = "0xFD9D10", Length = "0x39")]
	[Token(Token = "0x60006DB")]
	public void Add(T item) { }

	[Address(RVA = "0xFDA9A0", Offset = "0xFD9DA0", Length = "0x9")]
	[Token(Token = "0x60006D9")]
	public void Clear() { }

	[Address(RVA = "0xFDAA30", Offset = "0xFD9E30", Length = "0x45")]
	[Token(Token = "0x60006E0")]
	public T CurrentItem() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60006D4")]
	public int get_Count() { }

	[Address(RVA = "0xFDAA30", Offset = "0xFD9E30", Length = "0x45")]
	[Token(Token = "0x60006D5")]
	public T get_current() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x60006D6")]
	public int get_rolloverSize() { }

	[Address(RVA = "0xFDAAE0", Offset = "0xFD9EE0", Length = "0x3A")]
	[Token(Token = "0x60006DF")]
	public T Peek() { }

	[Address(RVA = "0xFDABB0", Offset = "0xFD9FB0", Length = "0x8C")]
	[Token(Token = "0x60006DE")]
	public T Pop() { }

	[Address(RVA = "0xFDAD80", Offset = "0xFDA180", Length = "0x46")]
	[Token(Token = "0x60006E1")]
	public T PreviousItem() { }

	[Address(RVA = "0xFDAEA0", Offset = "0xFDA2A0", Length = "0xBE")]
	[Token(Token = "0x60006DD")]
	public void Push(T item) { }

	[Address(RVA = "0xFDB020", Offset = "0xFDA420", Length = "0x60")]
	[Token(Token = "0x60006DC")]
	public T Remove() { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x60006D7")]
	public void set_rolloverSize(int value) { }

	[Address(RVA = "0xFDB240", Offset = "0xFDA640", Length = "0x115")]
	[Token(Token = "0x60006D8")]
	internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item) { }

	[Address(RVA = "0xFDB420", Offset = "0xFDA820", Length = "0xA2")]
	[Token(Token = "0x60006DA")]
	public void SetDefault(T item) { }

}

