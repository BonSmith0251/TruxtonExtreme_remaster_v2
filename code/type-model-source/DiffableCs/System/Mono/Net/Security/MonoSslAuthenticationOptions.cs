namespace Mono.Net.Security;

[Token(Token = "0x200005E")]
internal abstract class MonoSslAuthenticationOptions
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000112")]
	private ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000040")]
	public abstract bool AllowRenegotiation
	{
		[Token(Token = "0x6000140")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000043")]
	public abstract X509RevocationMode CertificateRevocationCheckMode
	{
		[Token(Token = "0x6000144")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000047")]
	public abstract bool ClientCertificateRequired
	{
		[Token(Token = "0x600014A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000046")]
	public abstract X509CertificateCollection ClientCertificates
	{
		[Token(Token = "0x6000148")]
		 get { } //Length: 0
		[Token(Token = "0x6000149")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000041")]
	public abstract SslProtocols EnabledSslProtocols
	{
		[Token(Token = "0x6000141")]
		 get { } //Length: 0
		[Token(Token = "0x6000142")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000042")]
	public abstract EncryptionPolicy EncryptionPolicy
	{
		[Token(Token = "0x6000143")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000045")]
	public abstract X509Certificate ServerCertificate
	{
		[Token(Token = "0x6000147")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000048")]
	internal ServerCertSelectionCallback ServerCertSelectionDelegate
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600014B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700003F")]
	public abstract bool ServerMode
	{
		[Token(Token = "0x600013F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000044")]
	public abstract string TargetHost
	{
		[Token(Token = "0x6000145")]
		 get { } //Length: 0
		[Token(Token = "0x6000146")]
		 set { } //Length: 0
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600014C")]
	protected MonoSslAuthenticationOptions() { }

	[Token(Token = "0x6000140")]
	public abstract bool get_AllowRenegotiation() { }

	[Token(Token = "0x600014A")]
	public abstract bool get_ClientCertificateRequired() { }

	[Token(Token = "0x6000148")]
	public abstract X509CertificateCollection get_ClientCertificates() { }

	[Token(Token = "0x6000141")]
	public abstract SslProtocols get_EnabledSslProtocols() { }

	[Token(Token = "0x6000147")]
	public abstract X509Certificate get_ServerCertificate() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600014B")]
	internal ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }

	[Token(Token = "0x600013F")]
	public abstract bool get_ServerMode() { }

	[Token(Token = "0x6000145")]
	public abstract string get_TargetHost() { }

	[Token(Token = "0x6000144")]
	public abstract void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	[Token(Token = "0x6000149")]
	public abstract void set_ClientCertificates(X509CertificateCollection value) { }

	[Token(Token = "0x6000142")]
	public abstract void set_EnabledSslProtocols(SslProtocols value) { }

	[Token(Token = "0x6000143")]
	public abstract void set_EncryptionPolicy(EncryptionPolicy value) { }

	[Token(Token = "0x6000146")]
	public abstract void set_TargetHost(string value) { }

}

