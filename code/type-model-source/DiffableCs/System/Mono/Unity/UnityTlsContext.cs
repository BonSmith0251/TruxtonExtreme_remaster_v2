namespace Mono.Unity;

[Token(Token = "0x2000041")]
internal class UnityTlsContext : MobileTlsContext
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000082")]
	private unitytls_tlsctx* tlsContext; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000083")]
	private unitytls_x509list* requestedClientCertChain; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000084")]
	private unitytls_key* requestedClientKey; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000085")]
	private unitytls_tlsctx_read_callback readCallback; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000086")]
	private unitytls_tlsctx_write_callback writeCallback; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000087")]
	private unitytls_tlsctx_certificate_callback certificateCallback; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000088")]
	private unitytls_tlsctx_x509verify_callback verifyCallback; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000089")]
	private X509Certificate localClientCertificate; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400008A")]
	private X509Certificate2 remoteCertificate; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400008B")]
	private MonoTlsConnectionInfo connectioninfo; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400008C")]
	private bool isAuthenticated; //Field offset: 0xA8
	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x400008D")]
	private bool hasContext; //Field offset: 0xA9
	[FieldOffset(Offset = "0xAA")]
	[Token(Token = "0x400008E")]
	private bool closedGraceful; //Field offset: 0xAA
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400008F")]
	private Byte[] writeBuffer; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000090")]
	private Byte[] readBuffer; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000091")]
	private GCHandle handle; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000092")]
	private Exception lastException; //Field offset: 0xC8

	[Token(Token = "0x1700000A")]
	public virtual bool IsAuthenticated
	{
		[Address(RVA = "0x1D16D50", Offset = "0x1D16150", Length = "0x8")]
		[Token(Token = "0x6000079")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000B")]
	internal virtual X509Certificate LocalClientCertificate
	{
		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[Token(Token = "0x600007A")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700000C")]
	public virtual X509Certificate2 RemoteCertificate
	{
		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[Token(Token = "0x600007B")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x22D0870", Offset = "0x22CFC70", Length = "0xBB0")]
	[Token(Token = "0x6000077")]
	public UnityTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[Address(RVA = "0x22CEAA0", Offset = "0x22CDEA0", Length = "0x134")]
	[MonoPInvokeCallback(typeof(unitytls_tlsctx_certificate_callback))]
	[Token(Token = "0x600008C")]
	private static void CertificateCallback(Void* userData, unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x22CE750", Offset = "0x22CDB50", Length = "0x347")]
	[Token(Token = "0x600008D")]
	private void CertificateCallback(unitytls_tlsctx* ctx, Byte* cn, IntPtr cnLen, unitytls_x509name* caList, IntPtr caListLen, unitytls_x509list_ref* chain, unitytls_key_ref* key, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x22CEBE0", Offset = "0x22CDFE0", Length = "0x15E")]
	[Token(Token = "0x6000082")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x22CED40", Offset = "0x22CE140", Length = "0x31D")]
	[Token(Token = "0x6000078")]
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, unitytls_errorstate* errorState, out unitytls_x509list* nativeCertChain, out unitytls_key* nativeKey) { }

	[Address(RVA = "0x22CF060", Offset = "0x22CE460", Length = "0x179")]
	[Token(Token = "0x6000085")]
	public virtual void FinishHandshake() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600007C")]
	public virtual void Flush() { }

	[Address(RVA = "0x1D16D50", Offset = "0x1D16150", Length = "0x8")]
	[Token(Token = "0x6000079")]
	public virtual bool get_IsAuthenticated() { }

	[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
	[Token(Token = "0x600007A")]
	internal virtual X509Certificate get_LocalClientCertificate() { }

	[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
	[Token(Token = "0x600007B")]
	public virtual X509Certificate2 get_RemoteCertificate() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000080")]
	public virtual bool PendingRenegotiation() { }

	[Address(RVA = "0x22CF1E0", Offset = "0x22CE5E0", Length = "0x32E")]
	[Token(Token = "0x6000084")]
	public virtual bool ProcessHandshake() { }

	[Address(RVA = "0x22CF900", Offset = "0x22CED00", Length = "0x20D")]
	[Token(Token = "0x600007D")]
	public virtual ValueTuple<Int32, Boolean> Read(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x22CF510", Offset = "0x22CE910", Length = "0x131")]
	[MonoPInvokeCallback(typeof(unitytls_tlsctx_read_callback))]
	[Token(Token = "0x6000088")]
	private static IntPtr ReadCallback(Void* userData, Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x22CF650", Offset = "0x22CEA50", Length = "0x2A3")]
	[Token(Token = "0x6000089")]
	private IntPtr ReadCallback(Byte* buffer, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x22CFB10", Offset = "0x22CEF10", Length = "0x3E")]
	[Token(Token = "0x600007F")]
	public virtual void Renegotiate() { }

	[Address(RVA = "0x22CFB50", Offset = "0x22CEF50", Length = "0x13D")]
	[Token(Token = "0x6000081")]
	public virtual void Shutdown() { }

	[Address(RVA = "0x22CFC90", Offset = "0x22CF090", Length = "0x24B")]
	[Token(Token = "0x6000083")]
	public virtual void StartHandshake() { }

	[Address(RVA = "0x22D01F0", Offset = "0x22CF5F0", Length = "0x113")]
	[MonoPInvokeCallback(typeof(unitytls_tlsctx_x509verify_callback))]
	[Token(Token = "0x600008A")]
	private static unitytls_x509verify_result VerifyCallback(Void* userData, unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x22CFEE0", Offset = "0x22CF2E0", Length = "0x2FF")]
	[Token(Token = "0x600008B")]
	private unitytls_x509verify_result VerifyCallback(unitytls_x509list_ref chain, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x22D0660", Offset = "0x22CFA60", Length = "0x204")]
	[Token(Token = "0x600007E")]
	public virtual ValueTuple<Int32, Boolean> Write(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x22D0520", Offset = "0x22CF920", Length = "0x131")]
	[MonoPInvokeCallback(typeof(unitytls_tlsctx_write_callback))]
	[Token(Token = "0x6000086")]
	private static IntPtr WriteCallback(Void* userData, Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x22D0310", Offset = "0x22CF710", Length = "0x205")]
	[Token(Token = "0x6000087")]
	private IntPtr WriteCallback(Byte* data, IntPtr bufferLen, unitytls_errorstate* errorState) { }

}

