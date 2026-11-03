namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200001C")]
public class FastAction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000AF")]
	private LinkedList<Action> delegates; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000B0")]
	private Dictionary<Action, LinkedListNode`1<Action>> lookup; //Field offset: 0x18

	[Address(RVA = "0x31720C0", Offset = "0x31714C0", Length = "0xBD")]
	[Token(Token = "0x6000055")]
	public FastAction() { }

}

