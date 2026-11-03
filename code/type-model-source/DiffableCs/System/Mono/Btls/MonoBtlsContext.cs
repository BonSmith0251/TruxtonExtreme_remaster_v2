namespace Mono.Btls;

[Token(Token = "0x2000074")]
internal class MonoBtlsContext : MobileTlsContext, IMonoBtlsBioMono
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400013E")]
	private X509Certificate2 remoteCertificate; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400013F")]
	private X509Certificate clientCertificate; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000140")]
	private X509CertificateImplBtls nativeServerCertificate; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000141")]
	private X509CertificateImplBtls nativeClientCertificate; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000142")]
	private MonoBtlsSslCtx ctx; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000143")]
	private MonoBtlsSsl ssl; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000144")]
	private MonoBtlsBio bio; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000145")]
	private MonoBtlsBio errbio; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000146")]
	private MonoTlsConnectionInfo connectionInfo; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000147")]
	private bool certificateValidated; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA1")]
	[Token(Token = "0x4000148")]
	private bool isAuthenticated; //Field offset: 0xA1
	[FieldOffset(Offset = "0xA2")]
	[Token(Token = "0x4000149")]
	private bool connected; //Field offset: 0xA2

	[Token(Token = "0x17000058")]
	public virtual bool IsAuthenticated
	{
		[Address(RVA = "0x215EEF0", Offset = "0x215E2F0", Length = "0x8")]
		[Token(Token = "0x60001BA")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000059")]
	internal virtual X509Certificate LocalClientCertificate
	{
		[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
		[Token(Token = "0x60001BB")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700005A")]
	public virtual X509Certificate2 RemoteCertificate
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x60001BC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x22C3880", Offset = "0x22C2C80", Length = "0x44")]
	[Token(Token = "0x600019F")]
	public MonoBtlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[Address(RVA = "0x22C14D0", Offset = "0x22C08D0", Length = "0x155")]
	[Token(Token = "0x60001B5")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x88A0E0", Offset = "0x8894E0", Length = "0x8A")]
	[Token(Token = "0x60001B4")]
	private void Dispose(ref T disposable) { }

	[Address(RVA = "0x22C1630", Offset = "0x22C0A30", Length = "0x51")]
	[Token(Token = "0x60001A8")]
	private MonoBtlsSslError DoProcessHandshake() { }

	[Address(RVA = "0x22C1690", Offset = "0x22C0A90", Length = "0x1D")]
	[Token(Token = "0x60001A9")]
	public virtual void FinishHandshake() { }

	[Address(RVA = "0x22C16B0", Offset = "0x22C0AB0", Length = "0x3E")]
	[Token(Token = "0x60001AE")]
	public virtual void Flush() { }

	[Address(RVA = "0x215EEF0", Offset = "0x215E2F0", Length = "0x8")]
	[Token(Token = "0x60001BA")]
	public virtual bool get_IsAuthenticated() { }

	[Address(RVA = "0x1388F80", Offset = "0x1388380", Length = "0x5")]
	[Token(Token = "0x60001BB")]
	internal virtual X509Certificate get_LocalClientCertificate() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x60001BC")]
	public virtual X509Certificate2 get_RemoteCertificate() { }

	[Address(RVA = "0x22C16F0", Offset = "0x22C0AF0", Length = "0x457")]
	[Token(Token = "0x60001A6")]
	private static Exception GetException(MonoBtlsSslError status) { }

	[Address(RVA = "0x22C1B50", Offset = "0x22C0F50", Length = "0xD9")]
	[Token(Token = "0x60001AB")]
	private void GetPeerCertificate() { }

	[Address(RVA = "0x22C1C30", Offset = "0x22C1030", Length = "0x224")]
	[Token(Token = "0x60001A0")]
	private static X509CertificateImplBtls GetPrivateCertificate(X509Certificate certificate) { }

	[Address(RVA = "0x22C1E60", Offset = "0x22C1260", Length = "0x79")]
	[Token(Token = "0x60001AD")]
	private static TlsProtocols GetProtocol(TlsProtocolCode protocol) { }

	[Address(RVA = "0x22C1EE0", Offset = "0x22C12E0", Length = "0x808")]
	[Token(Token = "0x60001AA")]
	private void InitializeConnection() { }

	[Address(RVA = "0x22C26F0", Offset = "0x22C1AF0", Length = "0x1F7")]
	[Token(Token = "0x60001AC")]
	private void InitializeSession() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001B9")]
	private override void Mono.Btls.IMonoBtlsBioMono.Close() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60001B8")]
	private override void Mono.Btls.IMonoBtlsBioMono.Flush() { }

	[Address(RVA = "0x22C28F0", Offset = "0x22C1CF0", Length = "0x24")]
	[Token(Token = "0x60001B6")]
	private override int Mono.Btls.IMonoBtlsBioMono.Read(Byte[] buffer, int offset, int size, out bool wantMore) { }

	[Address(RVA = "0x22C2920", Offset = "0x22C1D20", Length = "0x24")]
	[Token(Token = "0x60001B7")]
	private override bool Mono.Btls.IMonoBtlsBioMono.Write(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x22C2950", Offset = "0x22C1D50", Length = "0x20")]
	[Token(Token = "0x60001B3")]
	public virtual bool PendingRenegotiation() { }

	[Address(RVA = "0x22C2980", Offset = "0x22C1D80", Length = "0x15A")]
	[Token(Token = "0x60001A7")]
	public virtual bool ProcessHandshake() { }

	[Address(RVA = "0x22C2AE0", Offset = "0x22C1EE0", Length = "0x2C5")]
	[Token(Token = "0x60001AF")]
	public virtual ValueTuple<Int32, Boolean> Read(Byte[] buffer, int offset, int size) { }

	[Address(RVA = "0x22C2DB0", Offset = "0x22C21B0", Length = "0x3E")]
	[Token(Token = "0x60001B1")]
	public virtual void Renegotiate() { }

	[Address(RVA = "0x22C2DF0", Offset = "0x22C21F0", Length = "0xC8")]
	[Token(Token = "0x60001A2")]
	private int SelectCallback(String[] acceptableIssuers) { }

	[Address(RVA = "0x22C2EC0", Offset = "0x22C22C0", Length = "0x68")]
	[Token(Token = "0x60001A3")]
	private int ServerNameCallback() { }

	[Address(RVA = "0x22C2F30", Offset = "0x22C2330", Length = "0x30D")]
	[Token(Token = "0x60001A5")]
	private void SetPrivateCertificate(X509CertificateImplBtls privateCert) { }

	[Address(RVA = "0x22C3240", Offset = "0x22C2640", Length = "0x59")]
	[Token(Token = "0x60001B2")]
	public virtual void Shutdown() { }

	[Address(RVA = "0x22C32A0", Offset = "0x22C26A0", Length = "0x151")]
	[Token(Token = "0x60001A4")]
	public virtual void StartHandshake() { }

	[Address(RVA = "0x22C3400", Offset = "0x22C2800", Length = "0x20B")]
	[Token(Token = "0x60001A1")]
	private int VerifyCallback(MonoBtlsX509StoreCtx storeCtx) { }

	[Address(RVA = "0x22C3610", Offset = "0x22C2A10", Length = "0x26B")]
	[Token(Token = "0x60001B0")]
	public virtual ValueTuple<Int32, Boolean> Write(Byte[] buffer, int offset, int size) { }

}

