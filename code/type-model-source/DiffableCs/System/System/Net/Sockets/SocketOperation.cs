namespace System.Net.Sockets;

[Token(Token = "0x2000317")]
internal enum SocketOperation : int
{
	Accept = 0,
	Connect = 1,
	Receive = 2,
	ReceiveFrom = 3,
	Send = 4,
	SendTo = 5,
	RecvJustCallback = 6,
	SendJustCallback = 7,
	Disconnect = 8,
	AcceptReceive = 9,
	ReceiveGeneric = 10,
	SendGeneric = 11,
}

