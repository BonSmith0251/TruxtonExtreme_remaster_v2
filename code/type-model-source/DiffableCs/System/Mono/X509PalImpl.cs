namespace Mono;

[Token(Token = "0x2000006")]
internal abstract class X509PalImpl
{
	[Token(Token = "0x4000008")]
	private static Byte[] signedData; //Field offset: 0x0

	[Token(Token = "0x17000007")]
	public bool SupportsLegacyBasicConstraintsExtension
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x22D34D0", Offset = "0x22D28D0", Length = "0x8C")]
	[Token(Token = "0x6000021")]
	private static X509PalImpl() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000020")]
	protected X509PalImpl() { }

	[Address(RVA = "0x22D2D10", Offset = "0x22D2110", Length = "0x1B3")]
	[Token(Token = "0x600001B")]
	protected static Byte[] ConvertData(Byte[] data) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600001E")]
	public bool get_SupportsLegacyBasicConstraintsExtension() { }

	[Address(RVA = "0x22D2ED0", Offset = "0x22D22D0", Length = "0x317")]
	[Token(Token = "0x600001F")]
	public X509ContentType GetCertContentType(Byte[] rawData) { }

	[Token(Token = "0x6000017")]
	public abstract X509CertificateImpl Import(Byte[] data) { }

	[Token(Token = "0x6000018")]
	public abstract X509Certificate2Impl Import(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[Token(Token = "0x6000019")]
	public abstract X509Certificate2Impl Import(X509Certificate cert) { }

	[Address(RVA = "0x22D31F0", Offset = "0x22D25F0", Length = "0x13E")]
	[Token(Token = "0x600001C")]
	internal X509Certificate2Impl ImportFallback(Byte[] data) { }

	[Address(RVA = "0x22D3330", Offset = "0x22D2730", Length = "0x7A")]
	[Token(Token = "0x600001D")]
	internal X509Certificate2Impl ImportFallback(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x22D33B0", Offset = "0x22D27B0", Length = "0x116")]
	[Token(Token = "0x600001A")]
	private static Byte[] PEM(string type, Byte[] data) { }

}

