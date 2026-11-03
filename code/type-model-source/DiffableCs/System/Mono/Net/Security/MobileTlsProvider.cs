namespace Mono.Net.Security;

[Token(Token = "0x200005D")]
internal abstract class MobileTlsProvider : MonoTlsProvider
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600013E")]
	protected MobileTlsProvider() { }

	[Token(Token = "0x600013C")]
	internal abstract MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	[Token(Token = "0x600013D")]
	internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

}

