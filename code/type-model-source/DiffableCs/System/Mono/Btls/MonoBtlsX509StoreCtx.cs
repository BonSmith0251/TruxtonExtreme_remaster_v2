namespace Mono.Btls;

[Token(Token = "0x20000A0")]
internal class MonoBtlsX509StoreCtx : MonoBtlsObject
{
	[Token(Token = "0x20000A1")]
	public class BoringX509StoreCtxHandle : MonoBtlsHandle
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001DD")]
		private bool dontFree; //Field offset: 0x20

		[Address(RVA = "0x25F9310", Offset = "0x25F8710", Length = "0x2C")]
		[Token(Token = "0x60002F3")]
		internal BoringX509StoreCtxHandle(IntPtr handle, bool ownsHandle = true) { }

		[Address(RVA = "0x25F9340", Offset = "0x25F8740", Length = "0x88")]
		[Token(Token = "0x60002F4")]
		protected virtual bool ReleaseHandle() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001DC")]
	private Nullable<Int32> verifyResult; //Field offset: 0x20

	[Token(Token = "0x17000073")]
	internal BoringX509StoreCtxHandle Handle
	{
		[Address(RVA = "0x2606C10", Offset = "0x2606010", Length = "0x71")]
		[Token(Token = "0x60002DC")]
		internal get { } //Length: 113
	}

	[Token(Token = "0x17000074")]
	public int VerifyResult
	{
		[Address(RVA = "0x2606C90", Offset = "0x2606090", Length = "0x84")]
		[Token(Token = "0x60002F0")]
		 get { } //Length: 132
	}

	[Address(RVA = "0x2606B10", Offset = "0x2605F10", Length = "0xCE")]
	[Token(Token = "0x60002E7")]
	internal MonoBtlsX509StoreCtx() { }

	[Address(RVA = "0x2606BE0", Offset = "0x2605FE0", Length = "0x27")]
	[Token(Token = "0x60002EA")]
	internal MonoBtlsX509StoreCtx(BoringX509StoreCtxHandle ptr, Nullable<Int32> verifyResult) { }

	[Address(RVA = "0x26069A0", Offset = "0x2605DA0", Length = "0x169")]
	[Token(Token = "0x60002E9")]
	internal MonoBtlsX509StoreCtx(int preverify_ok, IntPtr store_ctx) { }

	[Address(RVA = "0x26060F0", Offset = "0x26054F0", Length = "0x143")]
	[Token(Token = "0x60002F2")]
	public MonoBtlsX509StoreCtx Copy() { }

	[Address(RVA = "0x2606240", Offset = "0x2605640", Length = "0x104")]
	[Token(Token = "0x60002E8")]
	private static BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx) { }

	[Address(RVA = "0x2606C10", Offset = "0x2606010", Length = "0x71")]
	[Token(Token = "0x60002DC")]
	internal BoringX509StoreCtxHandle get_Handle() { }

	[Address(RVA = "0x2606C90", Offset = "0x2606090", Length = "0x84")]
	[Token(Token = "0x60002F0")]
	public int get_VerifyResult() { }

	[Address(RVA = "0x2606350", Offset = "0x2605750", Length = "0x12D")]
	[Token(Token = "0x60002EC")]
	public MonoBtlsX509Chain GetChain() { }

	[Address(RVA = "0x2606480", Offset = "0x2605880", Length = "0xA3")]
	[Token(Token = "0x60002EB")]
	public MonoBtlsX509Error GetError() { }

	[Address(RVA = "0x2606530", Offset = "0x2605930", Length = "0x12D")]
	[Token(Token = "0x60002ED")]
	public MonoBtlsX509Chain GetUntrusted() { }

	[Address(RVA = "0x2606660", Offset = "0x2605A60", Length = "0x136")]
	[Token(Token = "0x60002EE")]
	public void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain) { }

	[Address(RVA = "0x2606D20", Offset = "0x2606120", Length = "0x78")]
	[Token(Token = "0x60002E6")]
	private static void mono_btls_x509_store_ctx_free(IntPtr handle) { }

	[Address(RVA = "0x2606DA0", Offset = "0x26061A0", Length = "0x78")]
	[Token(Token = "0x60002DE")]
	private static IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx) { }

	[Address(RVA = "0x2606E20", Offset = "0x2606220", Length = "0x78")]
	[Token(Token = "0x60002E0")]
	private static IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle) { }

	[Address(RVA = "0x2606EA0", Offset = "0x26062A0", Length = "0x87")]
	[Token(Token = "0x60002DF")]
	private static MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, out IntPtr error_string) { }

	[Address(RVA = "0x2606F30", Offset = "0x2606330", Length = "0x78")]
	[Token(Token = "0x60002E4")]
	private static IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle) { }

	[Address(RVA = "0x2606FB0", Offset = "0x26063B0", Length = "0x93")]
	[Token(Token = "0x60002E1")]
	private static int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain) { }

	[Address(RVA = "0x2607050", Offset = "0x2606450", Length = "0x65")]
	[Token(Token = "0x60002DD")]
	private static IntPtr mono_btls_x509_store_ctx_new() { }

	[Address(RVA = "0x26070C0", Offset = "0x26064C0", Length = "0x87")]
	[Token(Token = "0x60002E2")]
	private static int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param) { }

	[Address(RVA = "0x2607150", Offset = "0x2606550", Length = "0x78")]
	[Token(Token = "0x60002E5")]
	private static IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle) { }

	[Address(RVA = "0x26071D0", Offset = "0x26065D0", Length = "0x78")]
	[Token(Token = "0x60002E3")]
	private static int mono_btls_x509_store_ctx_verify_cert(IntPtr handle) { }

	[Address(RVA = "0x26067A0", Offset = "0x2605BA0", Length = "0xFC")]
	[Token(Token = "0x60002EF")]
	public void SetVerifyParam(MonoBtlsX509VerifyParam param) { }

	[Address(RVA = "0x26068A0", Offset = "0x2605CA0", Length = "0xFB")]
	[Token(Token = "0x60002F1")]
	public int Verify() { }

}

