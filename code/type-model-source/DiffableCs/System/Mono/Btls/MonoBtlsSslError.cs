namespace Mono.Btls;

[Token(Token = "0x2000089")]
internal enum MonoBtlsSslError : int
{
	None = 0,
	Ssl = 1,
	WantRead = 2,
	WantWrite = 3,
	WantX509Lookup = 4,
	Syscall = 5,
	ZeroReturn = 6,
	WantConnect = 7,
	WantAccept = 8,
	WantChannelIdLookup = 9,
	PendingSession = 11,
	PendingCertificate = 12,
	WantPrivateKeyOperation = 13,
}

