namespace Mono;

[Token(Token = "0x2000002")]
internal class SystemCertificateProvider : ISystemCertificateProvider
{
	[Token(Token = "0x4000001")]
	private static MonoTlsProvider provider; //Field offset: 0x0
	[Token(Token = "0x4000002")]
	private static int initialized; //Field offset: 0x8
	[Token(Token = "0x4000003")]
	private static X509PalImpl x509pal; //Field offset: 0x10
	[Token(Token = "0x4000004")]
	private static object syncRoot; //Field offset: 0x18

	[Token(Token = "0x17000001")]
	public X509PalImpl X509Pal
	{
		[Address(RVA = "0x22CAFE0", Offset = "0x22CA3E0", Length = "0x53")]
		[Token(Token = "0x6000003")]
		 get { } //Length: 83
	}

	[Address(RVA = "0x22CAF60", Offset = "0x22CA360", Length = "0x78")]
	[Token(Token = "0x600000A")]
	private static SystemCertificateProvider() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000009")]
	public SystemCertificateProvider() { }

	[Address(RVA = "0x22CA680", Offset = "0x22C9A80", Length = "0x198")]
	[Token(Token = "0x6000002")]
	private static void EnsureInitialized() { }

	[Address(RVA = "0x22CAFE0", Offset = "0x22CA3E0", Length = "0x53")]
	[Token(Token = "0x6000003")]
	public X509PalImpl get_X509Pal() { }

	[Address(RVA = "0x22CA820", Offset = "0x22C9C20", Length = "0x22A")]
	[Token(Token = "0x6000001")]
	private static X509PalImpl GetX509Pal() { }

	[Address(RVA = "0x22CAA50", Offset = "0x22C9E50", Length = "0x9E")]
	[Token(Token = "0x6000004")]
	public override X509CertificateImpl Import(Byte[] data, CertificateImportFlags importFlags = 0) { }

	[Address(RVA = "0x22CAAF0", Offset = "0x22C9EF0", Length = "0xB9")]
	[Token(Token = "0x6000006")]
	public X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0) { }

	[Address(RVA = "0x22CABB0", Offset = "0x22C9FB0", Length = "0x16B")]
	[Token(Token = "0x6000008")]
	public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = 0) { }

	[Address(RVA = "0x22CAD20", Offset = "0x22CA120", Length = "0xB7")]
	[Token(Token = "0x6000005")]
	private override X509CertificateImpl Mono.ISystemCertificateProvider.Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	[Address(RVA = "0x22CADE0", Offset = "0x22CA1E0", Length = "0x171")]
	[Token(Token = "0x6000007")]
	private override X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

}

