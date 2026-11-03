namespace Mono.Btls;

[Token(Token = "0x200009E")]
internal class MonoBtlsX509Store : MonoBtlsObject
{
	[Token(Token = "0x200009F")]
	public class BoringX509StoreHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x25F8FC0", Offset = "0x25F83C0", Length = "0xB")]
		[Token(Token = "0x60002DA")]
		public BoringX509StoreHandle(IntPtr handle) { }

		[Address(RVA = "0x25F93D0", Offset = "0x25F87D0", Length = "0x7B")]
		[Token(Token = "0x60002DB")]
		protected virtual bool ReleaseHandle() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001DB")]
	private Dictionary<IntPtr, MonoBtlsX509Lookup> lookupHash; //Field offset: 0x20

	[Token(Token = "0x17000072")]
	internal BoringX509StoreHandle Handle
	{
		[Address(RVA = "0x2608280", Offset = "0x2607680", Length = "0x71")]
		[Token(Token = "0x60002CC")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x2608040", Offset = "0x2607440", Length = "0x107")]
	[Token(Token = "0x60002D3")]
	internal MonoBtlsX509Store() { }

	[Address(RVA = "0x2608150", Offset = "0x2607550", Length = "0x12A")]
	[Token(Token = "0x60002D4")]
	internal MonoBtlsX509Store(BoringSslCtxHandle ctx) { }

	[Address(RVA = "0x2607870", Offset = "0x2606C70", Length = "0xFC")]
	[Token(Token = "0x60002D5")]
	public void AddCertificate(MonoBtlsX509 x509) { }

	[Address(RVA = "0x2607970", Offset = "0x2606D70", Length = "0xC0")]
	[Token(Token = "0x60002D8")]
	public void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust) { }

	[Address(RVA = "0x2607A40", Offset = "0x2606E40", Length = "0x42")]
	[Token(Token = "0x60002D7")]
	public void AddDirectoryLookup(string dir, MonoBtlsX509FileType type) { }

	[Address(RVA = "0x2607A90", Offset = "0x2606E90", Length = "0x1CE")]
	[Token(Token = "0x60002D6")]
	public MonoBtlsX509Lookup AddLookup(MonoBtlsX509LookupType type) { }

	[Address(RVA = "0x2607C60", Offset = "0x2607060", Length = "0x1AF")]
	[Token(Token = "0x60002D9")]
	protected virtual void Close() { }

	[Address(RVA = "0x2607F40", Offset = "0x2607340", Length = "0xF1")]
	[Token(Token = "0x60002D1")]
	private static BoringX509StoreHandle Create_internal() { }

	[Address(RVA = "0x2607E20", Offset = "0x2607220", Length = "0x114")]
	[Token(Token = "0x60002D2")]
	private static BoringX509StoreHandle Create_internal(BoringSslCtxHandle ctx) { }

	[Address(RVA = "0x2608280", Offset = "0x2607680", Length = "0x71")]
	[Token(Token = "0x60002CC")]
	internal BoringX509StoreHandle get_Handle() { }

	[Address(RVA = "0x2608300", Offset = "0x2607700", Length = "0x87")]
	[Token(Token = "0x60002CF")]
	private static int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509) { }

	[Address(RVA = "0x2608390", Offset = "0x2607790", Length = "0x78")]
	[Token(Token = "0x60002D0")]
	private static void mono_btls_x509_store_free(IntPtr handle) { }

	[Address(RVA = "0x2608410", Offset = "0x2607810", Length = "0x78")]
	[Token(Token = "0x60002CE")]
	private static IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle) { }

	[Address(RVA = "0x2608490", Offset = "0x2607890", Length = "0x65")]
	[Token(Token = "0x60002CD")]
	private static IntPtr mono_btls_x509_store_new() { }

}

