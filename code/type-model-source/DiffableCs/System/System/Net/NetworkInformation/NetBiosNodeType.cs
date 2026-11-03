namespace System.Net.NetworkInformation;

[Token(Token = "0x20002E0")]
public enum NetBiosNodeType : int
{
	Unknown = 0,
	Broadcast = 1,
	Peer2Peer = 2,
	Mixed = 4,
	Hybrid = 8,
}

