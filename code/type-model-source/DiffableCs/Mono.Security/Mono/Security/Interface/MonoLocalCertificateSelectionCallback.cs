namespace Mono.Security.Interface;

[Token(Token = "0x2000041")]
public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate
{

	[Address(RVA = "0x1E51CC0", Offset = "0x1E510C0", Length = "0xB5")]
	[Token(Token = "0x6000150")]
	public MonoLocalCertificateSelectionCallback(object object, IntPtr method) { }

	[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
	[Token(Token = "0x6000151")]
	public override X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

}

