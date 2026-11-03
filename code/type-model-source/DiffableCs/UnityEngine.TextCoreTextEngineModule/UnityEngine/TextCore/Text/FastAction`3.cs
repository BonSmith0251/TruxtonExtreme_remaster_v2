namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200001F")]
public class FastAction
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B5")]
	private LinkedList<Action`3<A, B, C>> delegates; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B6")]
	private Dictionary<Action`3<A, B, C>, LinkedListNode`1<Action`3<A, B, C>>> lookup; //Field offset: 0x0

	[Address(RVA = "0x1BB3960", Offset = "0x1BB2D60", Length = "0xD1")]
	[Token(Token = "0x6000059")]
	public FastAction`3() { }

}

