namespace TMPro;

[Token(Token = "0x2000007")]
public class FastAction
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000F")]
	private LinkedList<Action`2<A, B>> delegates; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000010")]
	private Dictionary<Action`2<A, B>, LinkedListNode`1<Action`2<A, B>>> lookup; //Field offset: 0x0

	[Address(RVA = "0x1BB42B0", Offset = "0x1BB36B0", Length = "0xD8")]
	[Token(Token = "0x600000E")]
	public FastAction`2() { }

	[Address(RVA = "0x1BB33E0", Offset = "0x1BB27E0", Length = "0x9E")]
	[Token(Token = "0x600000B")]
	public void Add(Action<A, B> rhs) { }

	[Address(RVA = "0x1BB4220", Offset = "0x1BB3620", Length = "0x8A")]
	[Token(Token = "0x600000D")]
	public void Call(A a, B b) { }

	[Address(RVA = "0x1BB38C0", Offset = "0x1BB2CC0", Length = "0x9E")]
	[Token(Token = "0x600000C")]
	public void Remove(Action<A, B> rhs) { }

}

