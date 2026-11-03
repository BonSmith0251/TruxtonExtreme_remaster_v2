namespace Mono.Btls;

[Token(Token = "0x2000081")]
internal class MonoBtlsSsl : MonoBtlsObject
{
	[Token(Token = "0x2000082")]
	public class BoringSslHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x25F8FC0", Offset = "0x25F83C0", Length = "0xB")]
		[Token(Token = "0x6000247")]
		public BoringSslHandle(IntPtr handle) { }

		[Address(RVA = "0x25F8FD0", Offset = "0x25F83D0", Length = "0x8F")]
		[Token(Token = "0x6000248")]
		protected virtual bool ReleaseHandle() { }

	}

	[Token(Token = "0x2000083")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class PrintErrorsCallbackFunc : MulticastDelegate
	{

		[Address(RVA = "0x25F94D0", Offset = "0x25F88D0", Length = "0xA6")]
		[Token(Token = "0x6000249")]
		public PrintErrorsCallbackFunc(object object, IntPtr method) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x600024A")]
		public override int Invoke(IntPtr str, IntPtr len, IntPtr ctx) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400014D")]
	private MonoBtlsBio bio; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400014E")]
	private PrintErrorsCallbackFunc printErrorsFunc; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400014F")]
	private IntPtr printErrorsFuncPtr; //Field offset: 0x30

	[Token(Token = "0x17000069")]
	internal BoringSslHandle Handle
	{
		[Address(RVA = "0x2601750", Offset = "0x2600B50", Length = "0x71")]
		[Token(Token = "0x600022E")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x26014F0", Offset = "0x26008F0", Length = "0x252")]
	[Token(Token = "0x600022D")]
	public MonoBtlsSsl(MonoBtlsSslCtx ctx) { }

	[Address(RVA = "0x25FFD10", Offset = "0x25FF110", Length = "0xB1")]
	[Token(Token = "0x6000235")]
	public MonoBtlsSslError Accept() { }

	[Address(RVA = "0x25FFDD0", Offset = "0x25FF1D0", Length = "0xF3")]
	[Token(Token = "0x6000234")]
	public void AddIntermediateCertificate(MonoBtlsX509 x509) { }

	[Address(RVA = "0x25FFED0", Offset = "0x25FF2D0", Length = "0xBB")]
	[Token(Token = "0x6000244")]
	protected virtual void Close() { }

	[Address(RVA = "0x25FFF90", Offset = "0x25FF390", Length = "0xB1")]
	[Token(Token = "0x6000236")]
	public MonoBtlsSslError Connect() { }

	[Address(RVA = "0x2600050", Offset = "0x25FF450", Length = "0x127")]
	[Token(Token = "0x600022C")]
	private static BoringSslHandle Create_internal(MonoBtlsSslCtx ctx) { }

	[Address(RVA = "0x2601750", Offset = "0x2600B50", Length = "0x71")]
	[Token(Token = "0x600022E")]
	internal BoringSslHandle get_Handle() { }

	[Address(RVA = "0x2600180", Offset = "0x25FF580", Length = "0xDF")]
	[Token(Token = "0x600023E")]
	public int GetCipher() { }

	[Address(RVA = "0x2600260", Offset = "0x25FF660", Length = "0x79")]
	[Token(Token = "0x6000231")]
	private MonoBtlsSslError GetError(int ret_code) { }

	[Address(RVA = "0x26002E0", Offset = "0x25FF6E0", Length = "0x188")]
	[Token(Token = "0x6000239")]
	public string GetErrors() { }

	[Address(RVA = "0x2600470", Offset = "0x25FF870", Length = "0x11E")]
	[Token(Token = "0x600023F")]
	public MonoBtlsX509 GetPeerCertificate() { }

	[Address(RVA = "0x2600590", Offset = "0x25FF990", Length = "0xE6")]
	[Token(Token = "0x6000241")]
	public string GetServerName() { }

	[Address(RVA = "0x2600680", Offset = "0x25FFA80", Length = "0x97")]
	[Token(Token = "0x600023D")]
	public int GetVersion() { }

	[Address(RVA = "0x2600720", Offset = "0x25FFB20", Length = "0xB1")]
	[Token(Token = "0x6000237")]
	public MonoBtlsSslError Handshake() { }

	[Address(RVA = "0x26017D0", Offset = "0x2600BD0", Length = "0x78")]
	[Token(Token = "0x600021A")]
	private static int mono_btls_ssl_accept(IntPtr handle) { }

	[Address(RVA = "0x2601850", Offset = "0x2600C50", Length = "0x87")]
	[Token(Token = "0x6000219")]
	private static int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509) { }

	[Address(RVA = "0x26018E0", Offset = "0x2600CE0", Length = "0x78")]
	[Token(Token = "0x600021D")]
	private static void mono_btls_ssl_close(IntPtr handle) { }

	[Address(RVA = "0x2601960", Offset = "0x2600D60", Length = "0x78")]
	[Token(Token = "0x600021B")]
	private static int mono_btls_ssl_connect(IntPtr handle) { }

	[Address(RVA = "0x26019E0", Offset = "0x2600DE0", Length = "0x78")]
	[Token(Token = "0x6000215")]
	private static void mono_btls_ssl_destroy(IntPtr handle) { }

	[Address(RVA = "0x2601A60", Offset = "0x2600E60", Length = "0x78")]
	[Token(Token = "0x6000225")]
	private static int mono_btls_ssl_get_cipher(IntPtr handle) { }

	[Address(RVA = "0x2601AE0", Offset = "0x2600EE0", Length = "0x85")]
	[Token(Token = "0x6000223")]
	private static int mono_btls_ssl_get_error(IntPtr handle, int ret_code) { }

	[Address(RVA = "0x2601B70", Offset = "0x2600F70", Length = "0x78")]
	[Token(Token = "0x6000226")]
	private static IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle) { }

	[Address(RVA = "0x2601BF0", Offset = "0x2600FF0", Length = "0x78")]
	[Token(Token = "0x6000229")]
	private static IntPtr mono_btls_ssl_get_server_name(IntPtr handle) { }

	[Address(RVA = "0x2601C70", Offset = "0x2601070", Length = "0x78")]
	[Token(Token = "0x6000224")]
	private static int mono_btls_ssl_get_version(IntPtr handle) { }

	[Address(RVA = "0x2601CF0", Offset = "0x26010F0", Length = "0x78")]
	[Token(Token = "0x600021C")]
	private static int mono_btls_ssl_handshake(IntPtr handle) { }

	[Address(RVA = "0x2601D70", Offset = "0x2601170", Length = "0x78")]
	[Token(Token = "0x6000216")]
	private static IntPtr mono_btls_ssl_new(IntPtr handle) { }

	[Address(RVA = "0x2601DF0", Offset = "0x26011F0", Length = "0x87")]
	[Token(Token = "0x6000227")]
	private static void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx) { }

	[Address(RVA = "0x2601E80", Offset = "0x2601280", Length = "0x93")]
	[Token(Token = "0x6000221")]
	private static int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len) { }

	[Address(RVA = "0x2601F20", Offset = "0x2601320", Length = "0x78")]
	[Token(Token = "0x600022B")]
	private static int mono_btls_ssl_renegotiate_pending(IntPtr handle) { }

	[Address(RVA = "0x2601FA0", Offset = "0x26013A0", Length = "0x87")]
	[Token(Token = "0x6000220")]
	private static void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio) { }

	[Address(RVA = "0x2602030", Offset = "0x2601430", Length = "0x85")]
	[Token(Token = "0x600021F")]
	private static void mono_btls_ssl_set_quiet_shutdown(IntPtr handle, int mode) { }

	[Address(RVA = "0x26020C0", Offset = "0x26014C0", Length = "0x85")]
	[Token(Token = "0x600022A")]
	private static void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode) { }

	[Address(RVA = "0x2602150", Offset = "0x2601550", Length = "0x87")]
	[Token(Token = "0x6000228")]
	private static int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name) { }

	[Address(RVA = "0x26021E0", Offset = "0x26015E0", Length = "0x78")]
	[Token(Token = "0x600021E")]
	private static int mono_btls_ssl_shutdown(IntPtr handle) { }

	[Address(RVA = "0x2602260", Offset = "0x2601660", Length = "0x87")]
	[Token(Token = "0x6000217")]
	private static int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509) { }

	[Address(RVA = "0x26022F0", Offset = "0x26016F0", Length = "0x87")]
	[Token(Token = "0x6000218")]
	private static int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key) { }

	[Address(RVA = "0x2602380", Offset = "0x2601780", Length = "0x93")]
	[Token(Token = "0x6000222")]
	private static int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len) { }

	[Address(RVA = "0x2600920", Offset = "0x25FFD20", Length = "0xC4")]
	[Token(Token = "0x600023A")]
	public void PrintErrors() { }

	[Address(RVA = "0x26007E0", Offset = "0x25FFBE0", Length = "0x13C")]
	[MonoPInvokeCallback(typeof(PrintErrorsCallbackFunc))]
	[Token(Token = "0x6000238")]
	private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx) { }

	[Address(RVA = "0x26009F0", Offset = "0x25FFDF0", Length = "0xFE")]
	[Token(Token = "0x600023B")]
	public MonoBtlsSslError Read(IntPtr data, ref int dataSize) { }

	[Address(RVA = "0x2600AF0", Offset = "0x25FFEF0", Length = "0x9A")]
	[Token(Token = "0x6000246")]
	public bool RenegotiatePending() { }

	[Address(RVA = "0x2600B90", Offset = "0x25FFF90", Length = "0xE4")]
	[Token(Token = "0x600022F")]
	public void SetBio(MonoBtlsBio bio) { }

	[Address(RVA = "0x2600C80", Offset = "0x2600080", Length = "0xF3")]
	[Token(Token = "0x6000232")]
	public void SetCertificate(MonoBtlsX509 x509) { }

	[Address(RVA = "0x2600D80", Offset = "0x2600180", Length = "0xF3")]
	[Token(Token = "0x6000233")]
	public void SetPrivateKey(MonoBtlsKey key) { }

	[Address(RVA = "0x2600E80", Offset = "0x2600280", Length = "0x9C")]
	[Token(Token = "0x6000243")]
	public void SetQuietShutdown() { }

	[Address(RVA = "0x2600F20", Offset = "0x2600320", Length = "0xA4")]
	[Token(Token = "0x6000245")]
	public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode) { }

	[Address(RVA = "0x2600FD0", Offset = "0x26003D0", Length = "0x19A")]
	[Token(Token = "0x6000240")]
	public void SetServerName(string name) { }

	[Address(RVA = "0x2601170", Offset = "0x2600570", Length = "0xC4")]
	[Token(Token = "0x6000242")]
	public void Shutdown() { }

	[Address(RVA = "0x2601240", Offset = "0x2600640", Length = "0x19F")]
	[Token(Token = "0x6000230")]
	private Exception ThrowError(string callerName = null) { }

	[Address(RVA = "0x26013E0", Offset = "0x26007E0", Length = "0x101")]
	[Token(Token = "0x600023C")]
	public MonoBtlsSslError Write(IntPtr data, ref int dataSize) { }

}

