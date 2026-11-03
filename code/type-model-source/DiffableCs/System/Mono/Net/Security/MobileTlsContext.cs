namespace Mono.Net.Security;

[Token(Token = "0x200005C")]
internal abstract class MobileTlsContext : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000108")]
	private ChainValidationHelper certificateValidator; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000109")]
	private readonly MonoSslAuthenticationOptions <Options>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400010A")]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400010B")]
	private readonly bool <IsServer>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400010C")]
	private readonly string <TargetHost>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400010D")]
	private readonly string <ServerName>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400010E")]
	private readonly bool <AskForClientCertificate>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400010F")]
	private readonly SslProtocols <EnabledProtocols>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000110")]
	private readonly X509CertificateCollection <ClientCertificates>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000111")]
	private X509Certificate <LocalServerCertificate>k__BackingField; //Field offset: 0x50

	[Token(Token = "0x17000039")]
	protected bool AskForClientCertificate
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000125")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003B")]
	protected X509CertificateCollection ClientCertificates
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000127")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003A")]
	protected SslProtocols EnabledProtocols
	{
		[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000126")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000035")]
	public abstract bool IsAuthenticated
	{
		[Token(Token = "0x6000121")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000036")]
	public bool IsServer
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000122")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003D")]
	internal abstract X509Certificate LocalClientCertificate
	{
		[Token(Token = "0x600012E")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x1700003C")]
	internal X509Certificate LocalServerCertificate
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600012C")]
		internal get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600012D")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000032")]
	internal MonoSslAuthenticationOptions Options
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600011E")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000033")]
	internal MobileAuthenticatedStream Parent
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600011F")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700003E")]
	public abstract X509Certificate2 RemoteCertificate
	{
		[Token(Token = "0x600012F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000038")]
	protected string ServerName
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000124")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000034")]
	public MonoTlsSettings Settings
	{
		[Address(RVA = "0x22BFF20", Offset = "0x22BF320", Length = "0x1E")]
		[Token(Token = "0x6000120")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000037")]
	internal string TargetHost
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000123")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x22BFC70", Offset = "0x22BF070", Length = "0x2A4")]
	[Token(Token = "0x600011D")]
	protected MobileTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[Address(RVA = "0x22BF250", Offset = "0x22BE650", Length = "0x61")]
	[Token(Token = "0x6000139")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600013A")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x22BF2C0", Offset = "0x22BE6C0", Length = "0x65")]
	[Token(Token = "0x600013B")]
	protected virtual void Finalize() { }

	[Token(Token = "0x600012B")]
	public abstract void FinishHandshake() { }

	[Token(Token = "0x6000130")]
	public abstract void Flush() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000125")]
	protected bool get_AskForClientCertificate() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000127")]
	protected X509CertificateCollection get_ClientCertificates() { }

	[Address(RVA = "0xF472B0", Offset = "0xF466B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000126")]
	protected SslProtocols get_EnabledProtocols() { }

	[Token(Token = "0x6000121")]
	public abstract bool get_IsAuthenticated() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000122")]
	public bool get_IsServer() { }

	[Token(Token = "0x600012E")]
	internal abstract X509Certificate get_LocalClientCertificate() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600012C")]
	internal X509Certificate get_LocalServerCertificate() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600011E")]
	internal MonoSslAuthenticationOptions get_Options() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600011F")]
	internal MobileAuthenticatedStream get_Parent() { }

	[Token(Token = "0x600012F")]
	public abstract X509Certificate2 get_RemoteCertificate() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000124")]
	protected string get_ServerName() { }

	[Address(RVA = "0x22BFF20", Offset = "0x22BF320", Length = "0x1E")]
	[Token(Token = "0x6000120")]
	public MonoTlsSettings get_Settings() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000123")]
	internal string get_TargetHost() { }

	[Address(RVA = "0x22BF330", Offset = "0x22BE730", Length = "0xE4")]
	[Token(Token = "0x6000128")]
	protected void GetProtocolVersions(out Nullable<TlsProtocolCode>& min, out Nullable<TlsProtocolCode>& max) { }

	[Token(Token = "0x6000134")]
	public abstract bool PendingRenegotiation() { }

	[Token(Token = "0x600012A")]
	public abstract bool ProcessHandshake() { }

	[Token(Token = "0x6000131")]
	public abstract ValueTuple<Int32, Boolean> Read(Byte[] buffer, int offset, int count) { }

	[Token(Token = "0x6000138")]
	public abstract void Renegotiate() { }

	[Address(RVA = "0x22BF420", Offset = "0x22BE820", Length = "0x524")]
	[Token(Token = "0x6000137")]
	protected X509Certificate SelectClientCertificate(String[] acceptableIssuers) { }

	[Address(RVA = "0x22BF950", Offset = "0x22BED50", Length = "0x2B7")]
	[Token(Token = "0x6000136")]
	protected X509Certificate SelectServerCertificate(string serverIdentity) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600012D")]
	private void set_LocalServerCertificate(X509Certificate value) { }

	[Token(Token = "0x6000133")]
	public abstract void Shutdown() { }

	[Token(Token = "0x6000129")]
	public abstract void StartHandshake() { }

	[Address(RVA = "0x22BFC10", Offset = "0x22BF010", Length = "0x52")]
	[Token(Token = "0x6000135")]
	protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	[Token(Token = "0x6000132")]
	public abstract ValueTuple<Int32, Boolean> Write(Byte[] buffer, int offset, int count) { }

}

