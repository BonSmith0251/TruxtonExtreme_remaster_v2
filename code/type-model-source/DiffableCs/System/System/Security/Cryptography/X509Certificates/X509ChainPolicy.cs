namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200013B")]
public sealed class X509ChainPolicy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005B0")]
	private OidCollection apps; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005B1")]
	private OidCollection cert; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005B2")]
	private X509CertificateCollection store; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005B3")]
	private X509Certificate2Collection store2; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005B4")]
	private X509RevocationFlag rflag; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40005B5")]
	private X509RevocationMode mode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005B6")]
	private TimeSpan timeout; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005B7")]
	private X509VerificationFlags vflags; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005B8")]
	private DateTime vtime; //Field offset: 0x48

	[Token(Token = "0x1700016A")]
	public internal X509Certificate2Collection ExtraStore
	{
		[Address(RVA = "0x2656E50", Offset = "0x2656250", Length = "0x356")]
		[Token(Token = "0x60007C6")]
		 get { } //Length: 854
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60007C7")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700016B")]
	public X509RevocationFlag RevocationFlag
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[Token(Token = "0x60007C8")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700016C")]
	public X509RevocationMode RevocationMode
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[Token(Token = "0x60007C9")]
		 get { } //Length: 4
		[Address(RVA = "0x26571B0", Offset = "0x26565B0", Length = "0x63")]
		[Token(Token = "0x60007CA")]
		 set { } //Length: 99
	}

	[Token(Token = "0x1700016D")]
	public X509VerificationFlags VerificationFlags
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x60007CB")]
		 get { } //Length: 4
		[Address(RVA = "0x2657220", Offset = "0x2656620", Length = "0x6C")]
		[Token(Token = "0x60007CC")]
		 set { } //Length: 108
	}

	[Token(Token = "0x1700016E")]
	public DateTime VerificationTime
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60007CD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2656D30", Offset = "0x2656130", Length = "0x112")]
	[Token(Token = "0x60007C5")]
	public X509ChainPolicy() { }

	[Address(RVA = "0x2656E50", Offset = "0x2656250", Length = "0x356")]
	[Token(Token = "0x60007C6")]
	public X509Certificate2Collection get_ExtraStore() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[Token(Token = "0x60007C8")]
	public X509RevocationFlag get_RevocationFlag() { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[Token(Token = "0x60007C9")]
	public X509RevocationMode get_RevocationMode() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x60007CB")]
	public X509VerificationFlags get_VerificationFlags() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60007CD")]
	public DateTime get_VerificationTime() { }

	[Address(RVA = "0x2656C20", Offset = "0x2656020", Length = "0x10B")]
	[Token(Token = "0x60007CE")]
	public void Reset() { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60007C7")]
	internal void set_ExtraStore(X509Certificate2Collection value) { }

	[Address(RVA = "0x26571B0", Offset = "0x26565B0", Length = "0x63")]
	[Token(Token = "0x60007CA")]
	public void set_RevocationMode(X509RevocationMode value) { }

	[Address(RVA = "0x2657220", Offset = "0x2656620", Length = "0x6C")]
	[Token(Token = "0x60007CC")]
	public void set_VerificationFlags(X509VerificationFlags value) { }

}

