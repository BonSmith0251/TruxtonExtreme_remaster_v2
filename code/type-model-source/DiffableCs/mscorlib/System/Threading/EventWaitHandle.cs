namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x2000221")]
public class EventWaitHandle : WaitHandle
{

	[Address(RVA = "0x209D8C0", Offset = "0x209CCC0", Length = "0x1A")]
	[Token(Token = "0x6001248")]
	public EventWaitHandle(bool initialState, EventResetMode mode) { }

	[Address(RVA = "0x209D8E0", Offset = "0x209CCE0", Length = "0x31D")]
	[Token(Token = "0x6001249")]
	public EventWaitHandle(bool initialState, EventResetMode mode, string name) { }

	[Address(RVA = "0x209D800", Offset = "0x209CC00", Length = "0x5B")]
	[Token(Token = "0x600124A")]
	public bool Reset() { }

	[Address(RVA = "0x209D860", Offset = "0x209CC60", Length = "0x5B")]
	[Token(Token = "0x600124B")]
	public bool Set() { }

}

