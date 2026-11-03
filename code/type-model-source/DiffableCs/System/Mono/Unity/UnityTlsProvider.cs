namespace Mono.Unity;

[Token(Token = "0x2000043")]
internal class UnityTlsProvider : MobileTlsProvider
{

	[Token(Token = "0x1700000E")]
	public virtual Guid ID
	{
		[Address(RVA = "0x22D2120", Offset = "0x22D1520", Length = "0x5B")]
		[Token(Token = "0x6000095")]
		 get { } //Length: 91
	}

	[Token(Token = "0x1700000D")]
	public virtual string Name
	{
		[Address(RVA = "0x22D2180", Offset = "0x22D1580", Length = "0x2C")]
		[Token(Token = "0x6000094")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000013")]
	public virtual SslProtocols SupportedProtocols
	{
		[Address(RVA = "0x22C81A0", Offset = "0x22C75A0", Length = "0x6")]
		[Token(Token = "0x600009A")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000012")]
	internal virtual bool SupportsCleanShutdown
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000099")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000011")]
	public virtual bool SupportsConnectionInfo
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000098")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000010")]
	public virtual bool SupportsMonoExtensions
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000097")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700000F")]
	public virtual bool SupportsSslStream
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000096")]
		 get { } //Length: 3
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600009E")]
	public UnityTlsProvider() { }

	[Address(RVA = "0x22D15B0", Offset = "0x22D09B0", Length = "0x1EC")]
	[Token(Token = "0x600009B")]
	internal virtual MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	[Address(RVA = "0x22D2120", Offset = "0x22D1520", Length = "0x5B")]
	[Token(Token = "0x6000095")]
	public virtual Guid get_ID() { }

	[Address(RVA = "0x22D2180", Offset = "0x22D1580", Length = "0x2C")]
	[Token(Token = "0x6000094")]
	public virtual string get_Name() { }

	[Address(RVA = "0x22C81A0", Offset = "0x22C75A0", Length = "0x6")]
	[Token(Token = "0x600009A")]
	public virtual SslProtocols get_SupportedProtocols() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000099")]
	internal virtual bool get_SupportsCleanShutdown() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000098")]
	public virtual bool get_SupportsConnectionInfo() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000097")]
	public virtual bool get_SupportsMonoExtensions() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000096")]
	public virtual bool get_SupportsSslStream() { }

	[Address(RVA = "0x22D17A0", Offset = "0x22D0BA0", Length = "0x97E")]
	[Token(Token = "0x600009D")]
	internal virtual bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	[Address(RVA = "0x22D21B0", Offset = "0x22D15B0", Length = "0x73")]
	[MonoPInvokeCallback(typeof(unitytls_x509verify_callback))]
	[Token(Token = "0x600009C")]
	private static unitytls_x509verify_result x509verify_callback(Void* userData, unitytls_x509_ref cert, unitytls_x509verify_result result, unitytls_errorstate* errorState) { }

}

