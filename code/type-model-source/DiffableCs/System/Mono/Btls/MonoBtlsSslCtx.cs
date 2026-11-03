namespace Mono.Btls;

[Token(Token = "0x2000084")]
internal class MonoBtlsSslCtx : MonoBtlsObject
{
	[Token(Token = "0x2000085")]
	public class BoringSslCtxHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x25F8FC0", Offset = "0x25F83C0", Length = "0xB")]
		[Token(Token = "0x6000268")]
		public BoringSslCtxHandle(IntPtr handle) { }

		[Address(RVA = "0x25F8F40", Offset = "0x25F8340", Length = "0x7B")]
		[Token(Token = "0x6000269")]
		protected virtual bool ReleaseHandle() { }

	}

	[Token(Token = "0x2000087")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class NativeSelectFunc : MulticastDelegate
	{

		[Address(RVA = "0x260A370", Offset = "0x2609770", Length = "0xA6")]
		[Token(Token = "0x600026C")]
		public NativeSelectFunc(object object, IntPtr method) { }

		[Address(RVA = "0x60D5C0", Offset = "0x60C9C0", Length = "0x14")]
		[Token(Token = "0x600026D")]
		public override int Invoke(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	}

	[Token(Token = "0x2000088")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class NativeServerNameFunc : MulticastDelegate
	{

		[Address(RVA = "0x1C11BF0", Offset = "0x1C10FF0", Length = "0xA6")]
		[Token(Token = "0x600026E")]
		public NativeServerNameFunc(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x600026F")]
		public override int Invoke(IntPtr instance) { }

	}

	[Token(Token = "0x2000086")]
	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	private sealed class NativeVerifyFunc : MulticastDelegate
	{

		[Address(RVA = "0x260A420", Offset = "0x2609820", Length = "0xA6")]
		[Token(Token = "0x600026A")]
		public NativeVerifyFunc(object object, IntPtr method) { }

		[Address(RVA = "0x60D850", Offset = "0x60CC50", Length = "0x14")]
		[Token(Token = "0x600026B")]
		public override int Invoke(IntPtr instance, int preverify_ok, IntPtr ctx) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000150")]
	private NativeVerifyFunc verifyFunc; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000151")]
	private NativeSelectFunc selectFunc; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000152")]
	private NativeServerNameFunc serverNameFunc; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000153")]
	private IntPtr verifyFuncPtr; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000154")]
	private IntPtr selectFuncPtr; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000155")]
	private IntPtr serverNameFuncPtr; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000156")]
	private MonoBtlsVerifyCallback verifyCallback; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000157")]
	private MonoBtlsSelectCallback selectCallback; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000158")]
	private MonoBtlsServerNameCallback serverNameCallback; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000159")]
	private MonoBtlsX509Store store; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400015A")]
	private GCHandle instance; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400015B")]
	private IntPtr instancePtr; //Field offset: 0x78

	[Token(Token = "0x1700006B")]
	public MonoBtlsX509Store CertificateStore
	{
		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[Token(Token = "0x6000259")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700006A")]
	internal BoringSslCtxHandle Handle
	{
		[Address(RVA = "0x25FF660", Offset = "0x25FEA60", Length = "0x71")]
		[Token(Token = "0x600024B")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x25FF190", Offset = "0x25FE590", Length = "0x4C7")]
	[Token(Token = "0x6000258")]
	internal MonoBtlsSslCtx(BoringSslCtxHandle handle) { }

	[Address(RVA = "0x25FF0C0", Offset = "0x25FE4C0", Length = "0xCA")]
	[Token(Token = "0x6000257")]
	public MonoBtlsSslCtx() { }

	[Address(RVA = "0x25FDAB0", Offset = "0x25FCEB0", Length = "0x4F")]
	[Token(Token = "0x6000267")]
	protected virtual void Close() { }

	[Address(RVA = "0x25FDB00", Offset = "0x25FCF00", Length = "0x42C")]
	[Token(Token = "0x600025D")]
	private static String[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr) { }

	[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
	[Token(Token = "0x6000259")]
	public MonoBtlsX509Store get_CertificateStore() { }

	[Address(RVA = "0x25FF660", Offset = "0x25FEA60", Length = "0x71")]
	[Token(Token = "0x600024B")]
	internal BoringSslCtxHandle get_Handle() { }

	[Address(RVA = "0x25FF6E0", Offset = "0x25FEAE0", Length = "0x78")]
	[Token(Token = "0x600024D")]
	private static int mono_btls_ssl_ctx_free(IntPtr handle) { }

	[Address(RVA = "0x25FF760", Offset = "0x25FEB60", Length = "0x87")]
	[Token(Token = "0x600024E")]
	private static void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance) { }

	[Address(RVA = "0x25FF7F0", Offset = "0x25FEBF0", Length = "0x65")]
	[Token(Token = "0x600024C")]
	private static IntPtr mono_btls_ssl_ctx_new() { }

	[Address(RVA = "0x25FF860", Offset = "0x25FEC60", Length = "0x87")]
	[Token(Token = "0x6000250")]
	private static void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func) { }

	[Address(RVA = "0x25FF8F0", Offset = "0x25FECF0", Length = "0x93")]
	[Token(Token = "0x600024F")]
	private static void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required) { }

	[Address(RVA = "0x25FF990", Offset = "0x25FED90", Length = "0xA0")]
	[Token(Token = "0x6000253")]
	private static int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported) { }

	[Address(RVA = "0x25FFA30", Offset = "0x25FEE30", Length = "0xA0")]
	[Token(Token = "0x6000255")]
	private static int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data) { }

	[Address(RVA = "0x25FFAD0", Offset = "0x25FEED0", Length = "0x85")]
	[Token(Token = "0x6000252")]
	private static void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version) { }

	[Address(RVA = "0x25FFB60", Offset = "0x25FEF60", Length = "0x85")]
	[Token(Token = "0x6000251")]
	private static void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version) { }

	[Address(RVA = "0x25FFBF0", Offset = "0x25FEFF0", Length = "0x87")]
	[Token(Token = "0x6000256")]
	private static void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func) { }

	[Address(RVA = "0x25FFC80", Offset = "0x25FF080", Length = "0x87")]
	[Token(Token = "0x6000254")]
	private static int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param) { }

	[Address(RVA = "0x25FDF30", Offset = "0x25FD330", Length = "0x177")]
	[MonoPInvokeCallback(typeof(NativeSelectFunc))]
	[Token(Token = "0x600025C")]
	private static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data) { }

	[Address(RVA = "0x25FE0B0", Offset = "0x25FD4B0", Length = "0x13B")]
	[MonoPInvokeCallback(typeof(NativeServerNameFunc))]
	[Token(Token = "0x6000266")]
	private static int NativeServerNameCallback(IntPtr instance) { }

	[Address(RVA = "0x25FE1F0", Offset = "0x25FD5F0", Length = "0x35E")]
	[MonoPInvokeCallback(typeof(NativeVerifyFunc))]
	[Token(Token = "0x600025B")]
	private static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx) { }

	[Address(RVA = "0x25FE550", Offset = "0x25FD950", Length = "0x20B")]
	[Token(Token = "0x6000262")]
	public void SetCiphers(Int16[] ciphers, bool allow_unsupported) { }

	[Address(RVA = "0x25FE760", Offset = "0x25FDB60", Length = "0x455")]
	[Token(Token = "0x6000264")]
	public void SetClientCertificateIssuers(String[] acceptableIssuers) { }

	[Address(RVA = "0x25FEBC0", Offset = "0x25FDFC0", Length = "0xA4")]
	[Token(Token = "0x6000261")]
	public void SetMaxVersion(int version) { }

	[Address(RVA = "0x25FEC70", Offset = "0x25FE070", Length = "0xA4")]
	[Token(Token = "0x6000260")]
	public void SetMinVersion(int version) { }

	[Address(RVA = "0x25FED20", Offset = "0x25FE120", Length = "0xBA")]
	[Token(Token = "0x600025F")]
	public void SetSelectCallback(MonoBtlsSelectCallback callback) { }

	[Address(RVA = "0x25FEDE0", Offset = "0x25FE1E0", Length = "0xBA")]
	[Token(Token = "0x6000265")]
	public void SetServerNameCallback(MonoBtlsServerNameCallback callback) { }

	[Address(RVA = "0x25FEEA0", Offset = "0x25FE2A0", Length = "0xD1")]
	[Token(Token = "0x600025E")]
	public void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required) { }

	[Address(RVA = "0x25FEF80", Offset = "0x25FE380", Length = "0x106")]
	[Token(Token = "0x6000263")]
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	[Address(RVA = "0x25FF090", Offset = "0x25FE490", Length = "0x23")]
	[Token(Token = "0x600025A")]
	private int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx) { }

}

