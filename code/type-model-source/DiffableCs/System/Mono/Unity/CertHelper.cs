namespace Mono.Unity;

[Token(Token = "0x2000008")]
internal static class CertHelper
{

	[Address(RVA = "0x22BB9C0", Offset = "0x22BADC0", Length = "0x128")]
	[Token(Token = "0x6000023")]
	public static void AddCertificatesToNativeChain(unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x22BB7F0", Offset = "0x22BABF0", Length = "0x1C9")]
	[Token(Token = "0x6000024")]
	public static void AddCertificateToNativeChain(unitytls_x509list* nativeCertificateChain, X509Certificate certificate, unitytls_errorstate* errorState) { }

}

