namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000131")]
internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000595")]
	private bool readCertData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000596")]
	private CertificateData certData; //Field offset: 0x18

	[Token(Token = "0x17000149")]
	public virtual IEnumerable<X509Extension> Extensions
	{
		[Address(RVA = "0x264E880", Offset = "0x264DC80", Length = "0x1D")]
		[Token(Token = "0x6000752")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000146")]
	public virtual string Issuer
	{
		[Address(RVA = "0x264E8C0", Offset = "0x264DCC0", Length = "0x2A")]
		[Token(Token = "0x600074E")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000144")]
	public virtual X500DistinguishedName IssuerName
	{
		[Address(RVA = "0x264E8A0", Offset = "0x264DCA0", Length = "0x1A")]
		[Token(Token = "0x600074C")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700013D")]
	public virtual string KeyAlgorithm
	{
		[Address(RVA = "0x264E910", Offset = "0x264DD10", Length = "0x1A")]
		[Token(Token = "0x6000745")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700013E")]
	public virtual Byte[] KeyAlgorithmParameters
	{
		[Address(RVA = "0x264E8F0", Offset = "0x264DCF0", Length = "0x1A")]
		[Token(Token = "0x6000746")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700014A")]
	public virtual DateTime NotAfter
	{
		[Address(RVA = "0x264E930", Offset = "0x264DD30", Length = "0x54")]
		[Token(Token = "0x6000753")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700014B")]
	public virtual DateTime NotBefore
	{
		[Address(RVA = "0x264E990", Offset = "0x264DD90", Length = "0x54")]
		[Token(Token = "0x6000754")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700013F")]
	public virtual Byte[] PublicKeyValue
	{
		[Address(RVA = "0x264E9F0", Offset = "0x264DDF0", Length = "0x1A")]
		[Token(Token = "0x6000747")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000147")]
	public virtual Byte[] RawData
	{
		[Address(RVA = "0x264EA10", Offset = "0x264DE10", Length = "0x1A")]
		[Token(Token = "0x600074F")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000140")]
	public virtual Byte[] SerialNumber
	{
		[Address(RVA = "0x264EA30", Offset = "0x264DE30", Length = "0x1A")]
		[Token(Token = "0x6000748")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000141")]
	public virtual string SignatureAlgorithm
	{
		[Address(RVA = "0x264EA50", Offset = "0x264DE50", Length = "0x1D")]
		[Token(Token = "0x6000749")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000145")]
	public virtual string Subject
	{
		[Address(RVA = "0x264EA90", Offset = "0x264DE90", Length = "0x2A")]
		[Token(Token = "0x600074D")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000143")]
	public virtual X500DistinguishedName SubjectName
	{
		[Address(RVA = "0x264EA70", Offset = "0x264DE70", Length = "0x1A")]
		[Token(Token = "0x600074B")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000148")]
	public virtual Byte[] Thumbprint
	{
		[Address(RVA = "0x264EAC0", Offset = "0x264DEC0", Length = "0xD3")]
		[Token(Token = "0x6000750")]
		 get { } //Length: 211
	}

	[Token(Token = "0x17000142")]
	public virtual int Version
	{
		[Address(RVA = "0x264EBA0", Offset = "0x264DFA0", Length = "0x1B")]
		[Token(Token = "0x600074A")]
		 get { } //Length: 27
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000759")]
	protected X509Certificate2ImplUnix() { }

	[Address(RVA = "0x264E0A0", Offset = "0x264D4A0", Length = "0x81")]
	[Token(Token = "0x6000755")]
	public virtual void AppendPrivateKeyInfo(StringBuilder sb) { }

	[Address(RVA = "0x264E130", Offset = "0x264D530", Length = "0x10F")]
	[Token(Token = "0x6000743")]
	private void EnsureCertData() { }

	[Address(RVA = "0x264E6C0", Offset = "0x264DAC0", Length = "0x17E")]
	[Token(Token = "0x6000756")]
	public virtual Byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	[Address(RVA = "0x264E240", Offset = "0x264D640", Length = "0x55")]
	[Token(Token = "0x6000757")]
	private Byte[] ExportPkcs12(SafePasswordHandle password) { }

	[Address(RVA = "0x264E2A0", Offset = "0x264D6A0", Length = "0x41F")]
	[Token(Token = "0x6000758")]
	private Byte[] ExportPkcs12(string password) { }

	[Address(RVA = "0x264E880", Offset = "0x264DC80", Length = "0x1D")]
	[Token(Token = "0x6000752")]
	public virtual IEnumerable<X509Extension> get_Extensions() { }

	[Address(RVA = "0x264E8C0", Offset = "0x264DCC0", Length = "0x2A")]
	[Token(Token = "0x600074E")]
	public virtual string get_Issuer() { }

	[Address(RVA = "0x264E8A0", Offset = "0x264DCA0", Length = "0x1A")]
	[Token(Token = "0x600074C")]
	public virtual X500DistinguishedName get_IssuerName() { }

	[Address(RVA = "0x264E910", Offset = "0x264DD10", Length = "0x1A")]
	[Token(Token = "0x6000745")]
	public virtual string get_KeyAlgorithm() { }

	[Address(RVA = "0x264E8F0", Offset = "0x264DCF0", Length = "0x1A")]
	[Token(Token = "0x6000746")]
	public virtual Byte[] get_KeyAlgorithmParameters() { }

	[Address(RVA = "0x264E930", Offset = "0x264DD30", Length = "0x54")]
	[Token(Token = "0x6000753")]
	public virtual DateTime get_NotAfter() { }

	[Address(RVA = "0x264E990", Offset = "0x264DD90", Length = "0x54")]
	[Token(Token = "0x6000754")]
	public virtual DateTime get_NotBefore() { }

	[Address(RVA = "0x264E9F0", Offset = "0x264DDF0", Length = "0x1A")]
	[Token(Token = "0x6000747")]
	public virtual Byte[] get_PublicKeyValue() { }

	[Address(RVA = "0x264EA10", Offset = "0x264DE10", Length = "0x1A")]
	[Token(Token = "0x600074F")]
	public virtual Byte[] get_RawData() { }

	[Address(RVA = "0x264EA30", Offset = "0x264DE30", Length = "0x1A")]
	[Token(Token = "0x6000748")]
	public virtual Byte[] get_SerialNumber() { }

	[Address(RVA = "0x264EA50", Offset = "0x264DE50", Length = "0x1D")]
	[Token(Token = "0x6000749")]
	public virtual string get_SignatureAlgorithm() { }

	[Address(RVA = "0x264EA90", Offset = "0x264DE90", Length = "0x2A")]
	[Token(Token = "0x600074D")]
	public virtual string get_Subject() { }

	[Address(RVA = "0x264EA70", Offset = "0x264DE70", Length = "0x1A")]
	[Token(Token = "0x600074B")]
	public virtual X500DistinguishedName get_SubjectName() { }

	[Address(RVA = "0x264EAC0", Offset = "0x264DEC0", Length = "0xD3")]
	[Token(Token = "0x6000750")]
	public virtual Byte[] get_Thumbprint() { }

	[Address(RVA = "0x264EBA0", Offset = "0x264DFA0", Length = "0x1B")]
	[Token(Token = "0x600074A")]
	public virtual int get_Version() { }

	[Address(RVA = "0x264E840", Offset = "0x264DC40", Length = "0x40")]
	[Token(Token = "0x6000751")]
	public virtual string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[Token(Token = "0x6000744")]
	protected abstract Byte[] GetRawCertData() { }

}

