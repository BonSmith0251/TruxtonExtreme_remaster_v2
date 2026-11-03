namespace TMPro;

[Token(Token = "0x2000005")]
public class FastAction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000B")]
	private LinkedList<Action> delegates; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000C")]
	private Dictionary<Action, LinkedListNode`1<Action>> lookup; //Field offset: 0x18

	[Address(RVA = "0x2E984F0", Offset = "0x2E978F0", Length = "0xBD")]
	[Token(Token = "0x6000006")]
	public FastAction() { }

	[Address(RVA = "0x2E982E0", Offset = "0x2E976E0", Length = "0xB0")]
	[Token(Token = "0x6000003")]
	public void Add(Action rhs) { }

	[Address(RVA = "0x2E983A0", Offset = "0x2E977A0", Length = "0x89")]
	[Token(Token = "0x6000005")]
	public void Call() { }

	[Address(RVA = "0x2E98430", Offset = "0x2E97830", Length = "0xB0")]
	[Token(Token = "0x6000004")]
	public void Remove(Action rhs) { }

}

