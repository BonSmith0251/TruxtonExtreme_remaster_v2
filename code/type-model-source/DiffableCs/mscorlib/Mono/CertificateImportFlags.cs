namespace Mono;

[Flags]
[Token(Token = "0x200002B")]
internal enum CertificateImportFlags : int
{
	None = 0,
	DisableNativeBackend = 1,
	DisableAutomaticFallback = 2,
}

