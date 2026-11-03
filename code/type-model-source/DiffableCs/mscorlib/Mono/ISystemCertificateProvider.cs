namespace Mono;

[Token(Token = "0x200002D")]
internal interface ISystemCertificateProvider
{

	[Token(Token = "0x6000044")]
	public X509CertificateImpl Import(Byte[] data, CertificateImportFlags importFlags = 0) { }

	[Token(Token = "0x6000045")]
	public X509CertificateImpl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0) { }

	[Token(Token = "0x6000046")]
	public X509CertificateImpl Import(X509Certificate cert, CertificateImportFlags importFlags = 0) { }

}

