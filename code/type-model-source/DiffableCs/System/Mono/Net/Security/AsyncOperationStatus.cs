namespace Mono.Net.Security;

[Token(Token = "0x2000048")]
internal enum AsyncOperationStatus : int
{
	Initialize = 0,
	Continue = 1,
	ReadDone = 2,
	Complete = 3,
}

