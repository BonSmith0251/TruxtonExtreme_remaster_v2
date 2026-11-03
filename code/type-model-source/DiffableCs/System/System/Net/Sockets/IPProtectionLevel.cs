namespace System.Net.Sockets;

[Token(Token = "0x2000304")]
public enum IPProtectionLevel : int
{
	Unspecified = -1,
	Unrestricted = 10,
	EdgeRestricted = 20,
	Restricted = 30,
}

