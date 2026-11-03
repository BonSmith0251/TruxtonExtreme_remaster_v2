namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200001E")]
public class FastAction
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B3")]
	private LinkedList<Action`2<A, B>> delegates; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B4")]
	private Dictionary<Action`2<A, B>, LinkedListNode`1<Action`2<A, B>>> lookup; //Field offset: 0x0

	[Address(RVA = "0x1BB4470", Offset = "0x1BB3870", Length = "0xD2")]
	[Token(Token = "0x6000058")]
	public FastAction`2() { }

	[Address(RVA = "0x1BB4100", Offset = "0x1BB3500", Length = "0x87")]
	[Token(Token = "0x6000057")]
	public void Call(A a, B b) { }

}

