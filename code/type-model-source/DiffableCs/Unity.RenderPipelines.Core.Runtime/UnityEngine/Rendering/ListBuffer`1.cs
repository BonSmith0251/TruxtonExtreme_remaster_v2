namespace UnityEngine.Rendering;

[DefaultMember("Item")]
[Token(Token = "0x2000051")]
public struct ListBuffer
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000138")]
	private T* m_BufferPtr; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000139")]
	private int m_Capacity; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013A")]
	private Int32* m_CountPtr; //Field offset: 0x0

	[Token(Token = "0x1700003C")]
	internal T* BufferPtr
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000511")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x1700003E")]
	public int Capacity
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000513")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700003D")]
	public int Count
	{
		[Address(RVA = "0xB0A860", Offset = "0xB09C60", Length = "0x7")]
		[Token(Token = "0x6000512")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700003F")]
	public T Item
	{
		[Address(RVA = "0xB0A870", Offset = "0xB09C70", Length = "0x182")]
		[Token(Token = "0x6000515")]
		 get { } //Length: 386
	}

	[Address(RVA = "0xB0A850", Offset = "0xB09C50", Length = "0xC")]
	[Token(Token = "0x6000514")]
	public ListBuffer`1(T* bufferPtr, Int32* countPtr, int capacity) { }

	[Address(RVA = "0xB0A150", Offset = "0xB09550", Length = "0xD8")]
	[Token(Token = "0x6000518")]
	public void CopyTo(T* dstBuffer, int startDstIndex, int copyCount) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000511")]
	internal T* get_BufferPtr() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6000513")]
	public int get_Capacity() { }

	[Address(RVA = "0xB0A860", Offset = "0xB09C60", Length = "0x7")]
	[Token(Token = "0x6000512")]
	public int get_Count() { }

	[Address(RVA = "0xB0A870", Offset = "0xB09C70", Length = "0x182")]
	[Token(Token = "0x6000515")]
	public T get_Item(in int index) { }

	[Address(RVA = "0xB0A230", Offset = "0xB09630", Length = "0x4C")]
	[Token(Token = "0x6000516")]
	public T GetUnchecked(in int index) { }

	[Address(RVA = "0xB0A280", Offset = "0xB09680", Length = "0x1A7")]
	[Token(Token = "0x6000517")]
	public bool TryAdd(in T value) { }

	[Address(RVA = "0xB0A430", Offset = "0xB09830", Length = "0x185")]
	[Token(Token = "0x600051A")]
	public bool TryCopyFrom(T* srcPtr, int count) { }

	[Address(RVA = "0xB0A5C0", Offset = "0xB099C0", Length = "0x289")]
	[Token(Token = "0x6000519")]
	public bool TryCopyTo(ListBuffer<T> other) { }

}

