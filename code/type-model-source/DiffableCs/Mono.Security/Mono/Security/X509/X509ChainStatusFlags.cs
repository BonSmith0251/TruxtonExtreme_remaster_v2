namespace Mono.Security.X509;

[Flags]
[Token(Token = "0x2000015")]
public enum X509ChainStatusFlags : int
{
	InvalidBasicConstraints = 1024,
	NoError = 0,
	NotSignatureValid = 8,
	NotTimeNested = 2,
	NotTimeValid = 1,
	PartialChain = 65536,
	UntrustedRoot = 32,
}

