namespace System.Net.Security;

[Token(Token = "0x2000318")]
public class SslClientAuthenticationOptions
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E6C")]
	private EncryptionPolicy _encryptionPolicy; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000E6D")]
	private X509RevocationMode _checkCertificateRevocation; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E6E")]
	private SslProtocols _enabledSslProtocols; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000E6F")]
	private bool _allowRenegotiation; //Field offset: 0x1C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E70")]
	private string <TargetHost>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E71")]
	private X509CertificateCollection <ClientCertificates>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x1700046F")]
	public bool AllowRenegotiation
	{
		[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
		[Token(Token = "0x60014B9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000472")]
	public X509RevocationMode CertificateRevocationCheckMode
	{
		[Address(RVA = "0x25EE3F0", Offset = "0x25ED7F0", Length = "0x9C")]
		[Token(Token = "0x60014BE")]
		 set { } //Length: 156
	}

	[Token(Token = "0x17000471")]
	public X509CertificateCollection ClientCertificates
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60014BC")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60014BD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000474")]
	public SslProtocols EnabledSslProtocols
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60014C0")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[Token(Token = "0x60014C1")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000473")]
	public EncryptionPolicy EncryptionPolicy
	{
		[Address(RVA = "0x25EE490", Offset = "0x25ED890", Length = "0x9C")]
		[Token(Token = "0x60014BF")]
		 set { } //Length: 156
	}

	[Token(Token = "0x17000470")]
	public string TargetHost
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60014BA")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60014BB")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x25EE3E0", Offset = "0x25ED7E0", Length = "0xB")]
	[Token(Token = "0x60014C2")]
	public SslClientAuthenticationOptions() { }

	[Address(RVA = "0xB0B7A0", Offset = "0xB0ABA0", Length = "0x5")]
	[Token(Token = "0x60014B9")]
	public bool get_AllowRenegotiation() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60014BC")]
	public X509CertificateCollection get_ClientCertificates() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60014C0")]
	public SslProtocols get_EnabledSslProtocols() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60014BA")]
	public string get_TargetHost() { }

	[Address(RVA = "0x25EE3F0", Offset = "0x25ED7F0", Length = "0x9C")]
	[Token(Token = "0x60014BE")]
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60014BD")]
	public void set_ClientCertificates(X509CertificateCollection value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[Token(Token = "0x60014C1")]
	public void set_EnabledSslProtocols(SslProtocols value) { }

	[Address(RVA = "0x25EE490", Offset = "0x25ED890", Length = "0x9C")]
	[Token(Token = "0x60014BF")]
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60014BB")]
	public void set_TargetHost(string value) { }

}

