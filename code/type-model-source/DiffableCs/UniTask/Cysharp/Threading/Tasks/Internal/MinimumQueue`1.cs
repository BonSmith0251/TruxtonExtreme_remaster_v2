namespace Cysharp.Threading.Tasks.Internal;

[Token(Token = "0x2000210")]
internal class MinimumQueue
{
	[Token(Token = "0x40005B8")]
	private const int MinimumGrow = 4; //Field offset: 0x0
	[Token(Token = "0x40005B9")]
	private const int GrowFactor = 200; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005BA")]
	private T[] array; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005BB")]
	private int head; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005BC")]
	private int tail; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005BD")]
	private int size; //Field offset: 0x0

	[Token(Token = "0x1700006E")]
	public int Count
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000C06")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xD0FD50", Offset = "0xD0F150", Length = "0xB0")]
	[Token(Token = "0x6000C05")]
	public MinimumQueue`1(int capacity) { }

	[Address(RVA = "0xD0F540", Offset = "0xD0E940", Length = "0x9F")]
	[Token(Token = "0x6000C09")]
	public T Dequeue() { }

	[Address(RVA = "0xD0F5E0", Offset = "0xD0E9E0", Length = "0x19D")]
	[Token(Token = "0x6000C08")]
	public void Enqueue(T item) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000C06")]
	public int get_Count() { }

	[Address(RVA = "0xD0F960", Offset = "0xD0ED60", Length = "0x129")]
	[Token(Token = "0x6000C0A")]
	private void Grow() { }

	[Address(RVA = "0xD0FA90", Offset = "0xD0EE90", Length = "0x26")]
	[Token(Token = "0x6000C0C")]
	private void MoveNext(ref int index) { }

	[Address(RVA = "0xD0FBA0", Offset = "0xD0EFA0", Length = "0x58")]
	[Token(Token = "0x6000C07")]
	public T Peek() { }

	[Address(RVA = "0xD0FC00", Offset = "0xD0F000", Length = "0xF3")]
	[Token(Token = "0x6000C0B")]
	private void SetCapacity(int capacity) { }

	[Address(RVA = "0xD0FD00", Offset = "0xD0F100", Length = "0x49")]
	[Token(Token = "0x6000C0D")]
	private void ThrowForEmptyQueue() { }

}

