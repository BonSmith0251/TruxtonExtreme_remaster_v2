namespace Mono.Btls;

[Token(Token = "0x2000094")]
internal class MonoBtlsX509Lookup : MonoBtlsObject
{
	[Token(Token = "0x2000095")]
	public class BoringX509LookupHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x25F8FC0", Offset = "0x25F83C0", Length = "0xB")]
		[Token(Token = "0x60002A5")]
		public BoringX509LookupHandle(IntPtr handle) { }

		[Address(RVA = "0x25F9180", Offset = "0x25F8580", Length = "0x7B")]
		[Token(Token = "0x60002A6")]
		protected virtual bool ReleaseHandle() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001B7")]
	private MonoBtlsX509Store store; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001B8")]
	private MonoBtlsX509LookupType type; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001B9")]
	private List<MonoBtlsX509LookupMono> monoLookups; //Field offset: 0x30

	[Token(Token = "0x1700006F")]
	internal BoringX509LookupHandle Handle
	{
		[Address(RVA = "0x2604F40", Offset = "0x2604340", Length = "0x71")]
		[Token(Token = "0x6000298")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x2604DD0", Offset = "0x26041D0", Length = "0x16E")]
	[Token(Token = "0x600029F")]
	internal MonoBtlsX509Lookup(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	[Address(RVA = "0x2604540", Offset = "0x2603940", Length = "0x106")]
	[Token(Token = "0x60002A3")]
	internal void AddCertificate(MonoBtlsX509 certificate) { }

	[Address(RVA = "0x2604650", Offset = "0x2603A50", Length = "0x19B")]
	[Token(Token = "0x60002A1")]
	public void AddDirectory(string dir, MonoBtlsX509FileType type) { }

	[Address(RVA = "0x26047F0", Offset = "0x2603BF0", Length = "0x271")]
	[Token(Token = "0x60002A2")]
	internal void AddMono(MonoBtlsX509LookupMono monoLookup) { }

	[Address(RVA = "0x2604A70", Offset = "0x2603E70", Length = "0x185")]
	[Token(Token = "0x60002A4")]
	protected virtual void Close() { }

	[Address(RVA = "0x2604C00", Offset = "0x2604000", Length = "0x12A")]
	[Token(Token = "0x600029E")]
	private static BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type) { }

	[Address(RVA = "0x2604F40", Offset = "0x2604340", Length = "0x71")]
	[Token(Token = "0x6000298")]
	internal BoringX509LookupHandle get_Handle() { }

	[Address(RVA = "0x2604D30", Offset = "0x2604130", Length = "0x91")]
	[Token(Token = "0x60002A0")]
	internal IntPtr GetNativeLookup() { }

	[Address(RVA = "0x2604FC0", Offset = "0x26043C0", Length = "0x93")]
	[Token(Token = "0x600029A")]
	private static int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type) { }

	[Address(RVA = "0x2605060", Offset = "0x2604460", Length = "0x87")]
	[Token(Token = "0x600029B")]
	private static int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup) { }

	[Address(RVA = "0x26050F0", Offset = "0x26044F0", Length = "0x78")]
	[Token(Token = "0x600029C")]
	private static void mono_btls_x509_lookup_free(IntPtr handle) { }

	[Address(RVA = "0x2605170", Offset = "0x2604570", Length = "0x85")]
	[Token(Token = "0x6000299")]
	private static IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type) { }

	[Address(RVA = "0x2605200", Offset = "0x2604600", Length = "0x78")]
	[Token(Token = "0x600029D")]
	private static IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle) { }

}

