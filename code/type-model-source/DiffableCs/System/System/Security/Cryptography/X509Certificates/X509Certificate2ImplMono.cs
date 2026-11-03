namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000130")]
internal class X509Certificate2ImplMono : X509Certificate2ImplUnix
{
	[Token(Token = "0x4000593")]
	private static string empty_error; //Field offset: 0x0
	[Token(Token = "0x4000594")]
	private static Byte[] signedData; //Field offset: 0x8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000591")]
	private X509CertificateImplCollection intermediateCerts; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000592")]
	private X509Certificate _cert; //Field offset: 0xB8

	[Token(Token = "0x17000138")]
	private X509Certificate Cert
	{
		[Address(RVA = "0x2612C10", Offset = "0x2612010", Length = "0x1D")]
		[Token(Token = "0x6000736")]
		private get { } //Length: 29
	}

	[Token(Token = "0x17000139")]
	public virtual bool HasPrivateKey
	{
		[Address(RVA = "0x264D9C0", Offset = "0x264CDC0", Length = "0x22")]
		[Token(Token = "0x6000738")]
		 get { } //Length: 34
	}

	[Token(Token = "0x1700013B")]
	internal virtual X509CertificateImplCollection IntermediateCertificates
	{
		[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
		[Token(Token = "0x6000740")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000137")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x24865B0", Offset = "0x24859B0", Length = "0xC")]
		[Token(Token = "0x6000731")]
		 get { } //Length: 12
	}

	[Token(Token = "0x1700013C")]
	internal X509Certificate MonoCertificate
	{
		[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
		[Token(Token = "0x6000741")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700013A")]
	public virtual AsymmetricAlgorithm PrivateKey
	{
		[Address(RVA = "0x264D9F0", Offset = "0x264CDF0", Length = "0x43F")]
		[Token(Token = "0x6000739")]
		 get { } //Length: 1087
		[Address(RVA = "0x264DE40", Offset = "0x264D240", Length = "0x25F")]
		[Token(Token = "0x600073A")]
		 set { } //Length: 607
	}

	[Address(RVA = "0x264D590", Offset = "0x264C990", Length = "0xD2")]
	[Token(Token = "0x6000742")]
	private static X509Certificate2ImplMono() { }

	[Address(RVA = "0x264D8C0", Offset = "0x264CCC0", Length = "0x37")]
	[Token(Token = "0x6000732")]
	public X509Certificate2ImplMono(X509Certificate cert) { }

	[Address(RVA = "0x264D900", Offset = "0x264CD00", Length = "0xB4")]
	[Token(Token = "0x6000733")]
	private X509Certificate2ImplMono(X509Certificate2ImplMono other) { }

	[Address(RVA = "0x264D670", Offset = "0x264CA70", Length = "0x234")]
	[Token(Token = "0x6000734")]
	public X509Certificate2ImplMono(Byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x264CA30", Offset = "0x264BE30", Length = "0xEC")]
	[Token(Token = "0x6000735")]
	public virtual X509CertificateImpl Clone() { }

	[Address(RVA = "0x2612C10", Offset = "0x2612010", Length = "0x1D")]
	[Token(Token = "0x6000736")]
	private X509Certificate get_Cert() { }

	[Address(RVA = "0x264D9C0", Offset = "0x264CDC0", Length = "0x22")]
	[Token(Token = "0x6000738")]
	public virtual bool get_HasPrivateKey() { }

	[Address(RVA = "0x2144800", Offset = "0x2143C00", Length = "0x8")]
	[Token(Token = "0x6000740")]
	internal virtual X509CertificateImplCollection get_IntermediateCertificates() { }

	[Address(RVA = "0x24865B0", Offset = "0x24859B0", Length = "0xC")]
	[Token(Token = "0x6000731")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x1CF2E70", Offset = "0x1CF2270", Length = "0x8")]
	[Token(Token = "0x6000741")]
	internal X509Certificate get_MonoCertificate() { }

	[Address(RVA = "0x264D9F0", Offset = "0x264CDF0", Length = "0x43F")]
	[Token(Token = "0x6000739")]
	public virtual AsymmetricAlgorithm get_PrivateKey() { }

	[Address(RVA = "0x264CB20", Offset = "0x264BF20", Length = "0x87")]
	[Token(Token = "0x600073C")]
	public virtual DSA GetDSAPrivateKey() { }

	[Address(RVA = "0x264CC40", Offset = "0x264C040", Length = "0x44")]
	[Token(Token = "0x6000737")]
	protected virtual Byte[] GetRawCertData() { }

	[Address(RVA = "0x264CBB0", Offset = "0x264BFB0", Length = "0x87")]
	[Token(Token = "0x600073B")]
	public virtual RSA GetRSAPrivateKey() { }

	[Address(RVA = "0x264D390", Offset = "0x264C790", Length = "0x66")]
	[Token(Token = "0x600073D")]
	private X509Certificate ImportPkcs12(Byte[] rawData, SafePasswordHandle password) { }

	[Address(RVA = "0x264CC90", Offset = "0x264C090", Length = "0x6FB")]
	[Token(Token = "0x600073E")]
	private X509Certificate ImportPkcs12(Byte[] rawData, string password) { }

	[Address(RVA = "0x264DE40", Offset = "0x264D240", Length = "0x25F")]
	[Token(Token = "0x600073A")]
	public virtual void set_PrivateKey(AsymmetricAlgorithm value) { }

	[Address(RVA = "0x264D400", Offset = "0x264C800", Length = "0x18C")]
	[MonoTODO("by default this depends on the incomplete X509Chain")]
	[Token(Token = "0x600073F")]
	public virtual bool Verify(X509Certificate2 thisCertificate) { }

}

