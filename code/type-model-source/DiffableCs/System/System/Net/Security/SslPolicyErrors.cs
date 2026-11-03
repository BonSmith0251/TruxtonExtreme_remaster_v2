namespace System.Net.Security;

[Flags]
[Token(Token = "0x200031E")]
public enum SslPolicyErrors : int
{
	None = 0,
	RemoteCertificateNotAvailable = 1,
	RemoteCertificateNameMismatch = 2,
	RemoteCertificateChainErrors = 4,
}

