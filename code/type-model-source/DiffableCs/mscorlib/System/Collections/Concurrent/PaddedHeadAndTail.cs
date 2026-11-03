namespace System.Collections.Concurrent;

[DebuggerDisplay("Head = {Head}, Tail = {Tail}")]
[Token(Token = "0x20005D5")]
internal struct PaddedHeadAndTail
{
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400182A")]
	public int Head; //Field offset: 0x80
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400182B")]
	public int Tail; //Field offset: 0x100

}

