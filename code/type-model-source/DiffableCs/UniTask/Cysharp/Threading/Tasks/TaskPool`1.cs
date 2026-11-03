namespace Cysharp.Threading.Tasks;

[Token(Token = "0x2000070")]
public struct TaskPool
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000EE")]
	private int gate; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000EF")]
	private int size; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000F0")]
	private T root; //Field offset: 0x0

	[Token(Token = "0x1700002D")]
	public int Size
	{
		[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
		[Token(Token = "0x6000176")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x6466B0", Offset = "0x645AB0", Length = "0x4")]
	[Token(Token = "0x6000176")]
	public int get_Size() { }

	[Address(RVA = "0xE1C8A0", Offset = "0xE1BCA0", Length = "0x206")]
	[Token(Token = "0x6000177")]
	public bool TryPop(out T result) { }

	[Address(RVA = "0xFF0290", Offset = "0xFEF690", Length = "0x126")]
	[Token(Token = "0x6000178")]
	public bool TryPush(T item) { }

}

