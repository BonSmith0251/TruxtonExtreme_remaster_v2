namespace System.Net.Sockets;

[Token(Token = "0x200030F")]
public enum SocketShutdown : int
{
	Receive = 0,
	Send = 1,
	Both = 2,
}

