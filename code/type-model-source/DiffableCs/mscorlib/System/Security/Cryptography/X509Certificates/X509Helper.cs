namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000338")]
internal static class X509Helper
{

	[Token(Token = "0x170002A9")]
	private static ISystemCertificateProvider CertificateProvider
	{
		[Address(RVA = "0x1EF6C50", Offset = "0x1EF6050", Length = "0xBC")]
		[Token(Token = "0x6001A1C")]
		private get { } //Length: 188
	}

	[Address(RVA = "0x1EF6C50", Offset = "0x1EF6050", Length = "0xBC")]
	[Token(Token = "0x6001A1C")]
	private static ISystemCertificateProvider get_CertificateProvider() { }

	[Address(RVA = "0x1EF68B0", Offset = "0x1EF5CB0", Length = "0x6E")]
	[Token(Token = "0x6001A21")]
	internal static Exception GetInvalidContextException() { }

	[Address(RVA = "0x1EF6A30", Offset = "0x1EF5E30", Length = "0xBE")]
	[Token(Token = "0x6001A22")]
	public static X509CertificateImpl Import(Byte[] rawData) { }

	[Address(RVA = "0x1EF6920", Offset = "0x1EF5D20", Length = "0x102")]
	[Token(Token = "0x6001A23")]
	public static X509CertificateImpl Import(Byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x1EF6AF0", Offset = "0x1EF5EF0", Length = "0xC6")]
	[Token(Token = "0x6001A1D")]
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	[Address(RVA = "0x1EF6BC0", Offset = "0x1EF5FC0", Length = "0x1C")]
	[Token(Token = "0x6001A1E")]
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	[Address(RVA = "0x1EF6BE0", Offset = "0x1EF5FE0", Length = "0x1C")]
	[Token(Token = "0x6001A1F")]
	public static bool IsValid(X509CertificateImpl impl) { }

	[Address(RVA = "0x1EF6C00", Offset = "0x1EF6000", Length = "0x50")]
	[Token(Token = "0x6001A20")]
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

}

