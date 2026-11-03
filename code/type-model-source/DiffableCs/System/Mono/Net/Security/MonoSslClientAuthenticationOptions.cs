namespace Mono.Net.Security;

[Token(Token = "0x200005F")]
internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000113")]
	private readonly SslClientAuthenticationOptions <Options>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700004B")]
	public virtual bool AllowRenegotiation
	{
		[Address(RVA = "0x22C8220", Offset = "0x22C7620", Length = "0x1B")]
		[Token(Token = "0x6000150")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700004C")]
	public virtual X509RevocationMode CertificateRevocationCheckMode
	{
		[Address(RVA = "0x22C82C0", Offset = "0x22C76C0", Length = "0x1E")]
		[Token(Token = "0x6000151")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000050")]
	public virtual bool ClientCertificateRequired
	{
		[Address(RVA = "0x22C8240", Offset = "0x22C7640", Length = "0x3E")]
		[Token(Token = "0x6000157")]
		 get { } //Length: 62
	}

	[Token(Token = "0x17000051")]
	public virtual X509CertificateCollection ClientCertificates
	{
		[Address(RVA = "0x21B1A00", Offset = "0x21B0E00", Length = "0x1B")]
		[Token(Token = "0x6000158")]
		 get { } //Length: 27
		[Address(RVA = "0x22C82E0", Offset = "0x22C76E0", Length = "0x23")]
		[Token(Token = "0x6000159")]
		 set { } //Length: 35
	}

	[Token(Token = "0x1700004E")]
	public virtual SslProtocols EnabledSslProtocols
	{
		[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
		[Token(Token = "0x6000153")]
		 get { } //Length: 26
		[Address(RVA = "0x22C8310", Offset = "0x22C7710", Length = "0x1A")]
		[Token(Token = "0x6000154")]
		 set { } //Length: 26
	}

	[Token(Token = "0x1700004D")]
	public virtual EncryptionPolicy EncryptionPolicy
	{
		[Address(RVA = "0x22C8330", Offset = "0x22C7730", Length = "0x1E")]
		[Token(Token = "0x6000152")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000049")]
	public SslClientAuthenticationOptions Options
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600014D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000052")]
	public virtual X509Certificate ServerCertificate
	{
		[Address(RVA = "0x22C8280", Offset = "0x22C7680", Length = "0x3E")]
		[Token(Token = "0x600015A")]
		 get { } //Length: 62
	}

	[Token(Token = "0x1700004A")]
	public virtual bool ServerMode
	{
		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x600014E")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700004F")]
	public virtual string TargetHost
	{
		[Address(RVA = "0x21B18C0", Offset = "0x21B0CC0", Length = "0x1B")]
		[Token(Token = "0x6000155")]
		 get { } //Length: 27
		[Address(RVA = "0x21B1930", Offset = "0x21B0D30", Length = "0x23")]
		[Token(Token = "0x6000156")]
		 set { } //Length: 35
	}

	[Address(RVA = "0x22C81B0", Offset = "0x22C75B0", Length = "0x66")]
	[Token(Token = "0x600014F")]
	public MonoSslClientAuthenticationOptions() { }

	[Address(RVA = "0x22C8220", Offset = "0x22C7620", Length = "0x1B")]
	[Token(Token = "0x6000150")]
	public virtual bool get_AllowRenegotiation() { }

	[Address(RVA = "0x22C8240", Offset = "0x22C7640", Length = "0x3E")]
	[Token(Token = "0x6000157")]
	public virtual bool get_ClientCertificateRequired() { }

	[Address(RVA = "0x21B1A00", Offset = "0x21B0E00", Length = "0x1B")]
	[Token(Token = "0x6000158")]
	public virtual X509CertificateCollection get_ClientCertificates() { }

	[Address(RVA = "0xFBEA80", Offset = "0xFBDE80", Length = "0x1A")]
	[Token(Token = "0x6000153")]
	public virtual SslProtocols get_EnabledSslProtocols() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600014D")]
	public SslClientAuthenticationOptions get_Options() { }

	[Address(RVA = "0x22C8280", Offset = "0x22C7680", Length = "0x3E")]
	[Token(Token = "0x600015A")]
	public virtual X509Certificate get_ServerCertificate() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x600014E")]
	public virtual bool get_ServerMode() { }

	[Address(RVA = "0x21B18C0", Offset = "0x21B0CC0", Length = "0x1B")]
	[Token(Token = "0x6000155")]
	public virtual string get_TargetHost() { }

	[Address(RVA = "0x22C82C0", Offset = "0x22C76C0", Length = "0x1E")]
	[Token(Token = "0x6000151")]
	public virtual void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	[Address(RVA = "0x22C82E0", Offset = "0x22C76E0", Length = "0x23")]
	[Token(Token = "0x6000159")]
	public virtual void set_ClientCertificates(X509CertificateCollection value) { }

	[Address(RVA = "0x22C8310", Offset = "0x22C7710", Length = "0x1A")]
	[Token(Token = "0x6000154")]
	public virtual void set_EnabledSslProtocols(SslProtocols value) { }

	[Address(RVA = "0x22C8330", Offset = "0x22C7730", Length = "0x1E")]
	[Token(Token = "0x6000152")]
	public virtual void set_EncryptionPolicy(EncryptionPolicy value) { }

	[Address(RVA = "0x21B1930", Offset = "0x21B0D30", Length = "0x23")]
	[Token(Token = "0x6000156")]
	public virtual void set_TargetHost(string value) { }

}

