namespace TMPro;

[Token(Token = "0x2000008")]
public class FastAction
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000011")]
	private LinkedList<Action`3<A, B, C>> delegates; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000012")]
	private Dictionary<Action`3<A, B, C>, LinkedListNode`1<Action`3<A, B, C>>> lookup; //Field offset: 0x0

	[Address(RVA = "0x1BB4A80", Offset = "0x1BB3E80", Length = "0xD8")]
	[Token(Token = "0x6000012")]
	public FastAction`3() { }

	[Address(RVA = "0x1BB33E0", Offset = "0x1BB27E0", Length = "0x9E")]
	[Token(Token = "0x600000F")]
	public void Add(Action<A, B, C> rhs) { }

	[Address(RVA = "0x1BB48F0", Offset = "0x1BB3CF0", Length = "0xA8")]
	[Token(Token = "0x6000011")]
	public void Call(A a, B b, C c) { }

	[Address(RVA = "0x1BB38C0", Offset = "0x1BB2CC0", Length = "0x9E")]
	[Token(Token = "0x6000010")]
	public void Remove(Action<A, B, C> rhs) { }

}

