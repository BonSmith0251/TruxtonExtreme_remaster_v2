namespace Mono.Btls;

[Token(Token = "0x200007D")]
internal class MonoBtlsProvider : MobileTlsProvider
{

	[Token(Token = "0x17000062")]
	public virtual Guid ID
	{
		[Address(RVA = "0x22C8110", Offset = "0x22C7510", Length = "0x5B")]
		[Token(Token = "0x60001F5")]
		 get { } //Length: 91
	}

	[Token(Token = "0x17000063")]
	public virtual string Name
	{
		[Address(RVA = "0x22C8170", Offset = "0x22C7570", Length = "0x2C")]
		[Token(Token = "0x60001F6")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000068")]
	public virtual SslProtocols SupportedProtocols
	{
		[Address(RVA = "0x22C81A0", Offset = "0x22C75A0", Length = "0x6")]
		[Token(Token = "0x60001FC")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000067")]
	internal virtual bool SupportsCleanShutdown
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60001FB")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000066")]
	public virtual bool SupportsConnectionInfo
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60001FA")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000065")]
	public virtual bool SupportsMonoExtensions
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60001F9")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000064")]
	public virtual bool SupportsSslStream
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60001F8")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x22C8070", Offset = "0x22C7470", Length = "0x9B")]
	[Token(Token = "0x60001F7")]
	internal MonoBtlsProvider() { }

	[Address(RVA = "0x22C5BA0", Offset = "0x22C4FA0", Length = "0x53")]
	[Token(Token = "0x6000209")]
	private static void AddMachineStore(MonoBtlsX509Store store) { }

	[Address(RVA = "0x22C5C00", Offset = "0x22C5000", Length = "0x3A")]
	[Token(Token = "0x600020A")]
	private static void AddTrustedRoots(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	[Address(RVA = "0x22C5C40", Offset = "0x22C5040", Length = "0x53")]
	[Token(Token = "0x6000208")]
	private static void AddUserStore(MonoBtlsX509Store store) { }

	[Address(RVA = "0x22C5CA0", Offset = "0x22C50A0", Length = "0x2A4")]
	[Token(Token = "0x6000204")]
	private void CheckValidationResult(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, X509Chain chain, MonoBtlsX509StoreCtx storeCtx, bool success, ref SslPolicyErrors errors, ref int status11) { }

	[Address(RVA = "0x22C5FD0", Offset = "0x22C53D0", Length = "0x103")]
	[Token(Token = "0x600020B")]
	public static X509Certificate2 CreateCertificate(MonoBtlsX509 x509) { }

	[Address(RVA = "0x22C60E0", Offset = "0x22C54E0", Length = "0x9A")]
	[Token(Token = "0x60001FD")]
	internal virtual MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	[Address(RVA = "0x22C8110", Offset = "0x22C7510", Length = "0x5B")]
	[Token(Token = "0x60001F5")]
	public virtual Guid get_ID() { }

	[Address(RVA = "0x22C8170", Offset = "0x22C7570", Length = "0x2C")]
	[Token(Token = "0x60001F6")]
	public virtual string get_Name() { }

	[Address(RVA = "0x22C81A0", Offset = "0x22C75A0", Length = "0x6")]
	[Token(Token = "0x60001FC")]
	public virtual SslProtocols get_SupportedProtocols() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60001FB")]
	internal virtual bool get_SupportsCleanShutdown() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60001FA")]
	public virtual bool get_SupportsConnectionInfo() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60001F9")]
	public virtual bool get_SupportsMonoExtensions() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60001F8")]
	public virtual bool get_SupportsSslStream() { }

	[Address(RVA = "0x22C6180", Offset = "0x22C5580", Length = "0xAA")]
	[Token(Token = "0x600020D")]
	public static MonoBtlsX509 GetBtlsCertificate(X509Certificate certificate) { }

	[Address(RVA = "0x22C6230", Offset = "0x22C5630", Length = "0x7D")]
	[Token(Token = "0x600020C")]
	public static X509Chain GetManagedChain(MonoBtlsX509Chain chain) { }

	[Address(RVA = "0x22C6470", Offset = "0x22C5870", Length = "0x118")]
	[Token(Token = "0x60001FF")]
	internal X509Certificate2Impl GetNativeCertificate(X509Certificate certificate) { }

	[Address(RVA = "0x22C63F0", Offset = "0x22C57F0", Length = "0x7A")]
	[Token(Token = "0x6000200")]
	internal X509Certificate2Impl GetNativeCertificate(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags flags) { }

	[Address(RVA = "0x22C62B0", Offset = "0x22C56B0", Length = "0x136")]
	[Token(Token = "0x60001FE")]
	internal X509Certificate2Impl GetNativeCertificate(Byte[] data, string password, X509KeyStorageFlags flags) { }

	[Address(RVA = "0x22C6590", Offset = "0x22C5990", Length = "0x2CE")]
	[Token(Token = "0x600020E")]
	public static MonoBtlsX509Chain GetNativeChain(X509CertificateCollection certificates) { }

	[Address(RVA = "0x22C6860", Offset = "0x22C5C60", Length = "0x183")]
	[Token(Token = "0x6000201")]
	internal static MonoBtlsX509VerifyParam GetVerifyParam(MonoTlsSettings settings, string targetHost, bool serverMode) { }

	[Address(RVA = "0x22C69F0", Offset = "0x22C5DF0", Length = "0x20")]
	[Token(Token = "0x6000205")]
	internal static X509ChainStatusFlags MapVerifyErrorToChainStatus(MonoBtlsX509Error code) { }

	[Address(RVA = "0x22C6C40", Offset = "0x22C6040", Length = "0x3A1")]
	[Token(Token = "0x6000206")]
	internal static void SetupCertificateStore(MonoBtlsX509Store store, MonoTlsSettings settings, bool server) { }

	[Address(RVA = "0x22C6FF0", Offset = "0x22C63F0", Length = "0x89")]
	[Token(Token = "0x6000207")]
	private static void SetupDefaultCertificateStore(MonoBtlsX509Store store) { }

	[Address(RVA = "0x22C7A40", Offset = "0x22C6E40", Length = "0x622")]
	[Token(Token = "0x6000203")]
	internal static bool ValidateCertificate(MonoBtlsX509Chain chain, MonoBtlsX509VerifyParam param) { }

	[Address(RVA = "0x22C7080", Offset = "0x22C6480", Length = "0x9B4")]
	[Token(Token = "0x6000202")]
	internal virtual bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

}

