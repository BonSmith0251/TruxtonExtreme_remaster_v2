namespace System.Net.Sockets;

[Token(Token = "0x2000308")]
public enum SelectMode : int
{
	SelectRead = 0,
	SelectWrite = 1,
	SelectError = 2,
}

