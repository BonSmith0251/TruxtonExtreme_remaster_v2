namespace System.Net.Security;

[Token(Token = "0x200031C")]
public sealed class LocalCertificateSelectionCallback : MulticastDelegate
{

	[Address(RVA = "0x25DEAE0", Offset = "0x25DDEE0", Length = "0x125")]
	[Token(Token = "0x60014C7")]
	public LocalCertificateSelectionCallback(object object, IntPtr method) { }

	[Address(RVA = "0x1BB00C0", Offset = "0x1BAF4C0", Length = "0x14")]
	[Token(Token = "0x60014C8")]
	public override X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

}

