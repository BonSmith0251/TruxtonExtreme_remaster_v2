namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200012F")]
internal abstract class X509Certificate2Impl : X509CertificateImpl
{

	[Token(Token = "0x17000130")]
	public abstract IEnumerable<X509Extension> Extensions
	{
		[Token(Token = "0x6000725")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000136")]
	internal abstract X509CertificateImplCollection IntermediateCertificates
	{
		[Token(Token = "0x600072C")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x17000131")]
	public abstract X500DistinguishedName IssuerName
	{
		[Token(Token = "0x6000726")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000132")]
	public abstract AsymmetricAlgorithm PrivateKey
	{
		[Token(Token = "0x6000727")]
		 get { } //Length: 0
		[Token(Token = "0x6000728")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000133")]
	public abstract string SignatureAlgorithm
	{
		[Token(Token = "0x6000729")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000134")]
	public abstract X500DistinguishedName SubjectName
	{
		[Token(Token = "0x600072A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000135")]
	public abstract int Version
	{
		[Token(Token = "0x600072B")]
		 get { } //Length: 0
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000730")]
	protected X509Certificate2Impl() { }

	[Token(Token = "0x600072F")]
	public abstract void AppendPrivateKeyInfo(StringBuilder sb) { }

	[Token(Token = "0x6000725")]
	public abstract IEnumerable<X509Extension> get_Extensions() { }

	[Token(Token = "0x600072C")]
	internal abstract X509CertificateImplCollection get_IntermediateCertificates() { }

	[Token(Token = "0x6000726")]
	public abstract X500DistinguishedName get_IssuerName() { }

	[Token(Token = "0x6000727")]
	public abstract AsymmetricAlgorithm get_PrivateKey() { }

	[Token(Token = "0x6000729")]
	public abstract string get_SignatureAlgorithm() { }

	[Token(Token = "0x600072A")]
	public abstract X500DistinguishedName get_SubjectName() { }

	[Token(Token = "0x600072B")]
	public abstract int get_Version() { }

	[Token(Token = "0x600072D")]
	public abstract string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[Token(Token = "0x6000728")]
	public abstract void set_PrivateKey(AsymmetricAlgorithm value) { }

	[Token(Token = "0x600072E")]
	public abstract bool Verify(X509Certificate2 thisCertificate) { }

}

