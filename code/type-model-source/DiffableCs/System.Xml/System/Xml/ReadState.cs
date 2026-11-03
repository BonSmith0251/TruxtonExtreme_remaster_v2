namespace System.Xml;

[Token(Token = "0x200003B")]
public enum ReadState : int
{
	Initial = 0,
	Interactive = 1,
	Error = 2,
	EndOfFile = 3,
	Closed = 4,
}

