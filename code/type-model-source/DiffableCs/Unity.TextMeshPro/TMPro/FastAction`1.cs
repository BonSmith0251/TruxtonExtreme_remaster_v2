namespace TMPro;

[Token(Token = "0x2000006")]
public class FastAction
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000D")]
	private LinkedList<Action`1<A>> delegates; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400000E")]
	private Dictionary<Action`1<A>, LinkedListNode`1<Action`1<A>>> lookup; //Field offset: 0x0

	[Address(RVA = "0x1BB3B20", Offset = "0x1BB2F20", Length = "0xD8")]
	[Token(Token = "0x600000A")]
	public FastAction`1() { }

	[Address(RVA = "0x1BB33E0", Offset = "0x1BB27E0", Length = "0x9E")]
	[Token(Token = "0x6000007")]
	public void Add(Action<A> rhs) { }

	[Address(RVA = "0x1BB36E0", Offset = "0x1BB2AE0", Length = "0x79")]
	[Token(Token = "0x6000009")]
	public void Call(A a) { }

	[Address(RVA = "0x1BB38C0", Offset = "0x1BB2CC0", Length = "0x9E")]
	[Token(Token = "0x6000008")]
	public void Remove(Action<A> rhs) { }

}

