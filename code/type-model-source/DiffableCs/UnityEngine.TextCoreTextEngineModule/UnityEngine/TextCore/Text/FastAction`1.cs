namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200001D")]
public class FastAction
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B1")]
	private LinkedList<Action`1<A>> delegates; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B2")]
	private Dictionary<Action`1<A>, LinkedListNode`1<Action`1<A>>> lookup; //Field offset: 0x0

	[Address(RVA = "0x1BB3960", Offset = "0x1BB2D60", Length = "0xD1")]
	[Token(Token = "0x6000056")]
	public FastAction`1() { }

}

