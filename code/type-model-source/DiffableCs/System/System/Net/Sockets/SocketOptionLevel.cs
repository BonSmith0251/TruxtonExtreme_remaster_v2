namespace System.Net.Sockets;

[Token(Token = "0x200030D")]
public enum SocketOptionLevel : int
{
	Socket = 65535,
	IP = 0,
	IPv6 = 41,
	Tcp = 6,
	Udp = 17,
}

