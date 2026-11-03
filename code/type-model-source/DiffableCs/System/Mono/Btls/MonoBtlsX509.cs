namespace Mono.Btls;

[Token(Token = "0x200008D")]
internal class MonoBtlsX509 : MonoBtlsObject
{
	[Token(Token = "0x200008E")]
	public class BoringX509Handle : MonoBtlsHandle
	{

		[Address(RVA = "0x25F8FC0", Offset = "0x25F83C0", Length = "0xB")]
		[Token(Token = "0x6000286")]
		public BoringX509Handle(IntPtr handle) { }

		[Address(RVA = "0x25F90E0", Offset = "0x25F84E0", Length = "0x89")]
		[Token(Token = "0x6000287")]
		protected virtual bool ReleaseHandle() { }

		[Address(RVA = "0x25F9170", Offset = "0x25F8570", Length = "0xE")]
		[Token(Token = "0x6000288")]
		public IntPtr StealHandle() { }

	}


	[Token(Token = "0x1700006C")]
	internal BoringX509Handle Handle
	{
		[Address(RVA = "0x2609CA0", Offset = "0x26090A0", Length = "0x71")]
		[Token(Token = "0x6000276")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x25123E0", Offset = "0x25117E0", Length = "0x8")]
	[Token(Token = "0x6000277")]
	internal MonoBtlsX509(BoringX509Handle handle) { }

	[Address(RVA = "0x26091D0", Offset = "0x26085D0", Length = "0xE4")]
	[Token(Token = "0x6000285")]
	public void AddExplicitTrust(MonoBtlsX509TrustKind kind) { }

	[Address(RVA = "0x26092C0", Offset = "0x26086C0", Length = "0xC2")]
	[Token(Token = "0x6000284")]
	public static int Compare(MonoBtlsX509 a, MonoBtlsX509 b) { }

	[Address(RVA = "0x2609390", Offset = "0x2608790", Length = "0x12D")]
	[Token(Token = "0x600027F")]
	internal MonoBtlsX509 Copy() { }

	[Address(RVA = "0x2609CA0", Offset = "0x26090A0", Length = "0x71")]
	[Token(Token = "0x6000276")]
	internal BoringX509Handle get_Handle() { }

	[Address(RVA = "0x26094C0", Offset = "0x26088C0", Length = "0x1E3")]
	[Token(Token = "0x6000283")]
	public Byte[] GetRawData(MonoBtlsX509Format format) { }

	[Address(RVA = "0x26098B0", Offset = "0x2608CB0", Length = "0x131")]
	[Token(Token = "0x6000281")]
	public MonoBtlsX509Name GetSubjectName() { }

	[Address(RVA = "0x26096B0", Offset = "0x2608AB0", Length = "0x1FF")]
	[Token(Token = "0x6000282")]
	public long GetSubjectNameHash() { }

	[Address(RVA = "0x26099F0", Offset = "0x2608DF0", Length = "0x2A7")]
	[Token(Token = "0x6000280")]
	public static MonoBtlsX509 LoadFromData(Byte[] buffer, MonoBtlsX509Format format) { }

	[Address(RVA = "0x2609D20", Offset = "0x2609120", Length = "0x85")]
	[Token(Token = "0x600027E")]
	private static int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind) { }

	[Address(RVA = "0x2609DB0", Offset = "0x26091B0", Length = "0x87")]
	[Token(Token = "0x600027C")]
	private static int mono_btls_x509_cmp(IntPtr a, IntPtr b) { }

	[Address(RVA = "0x2609E40", Offset = "0x2609240", Length = "0x78")]
	[Token(Token = "0x600027D")]
	private static void mono_btls_x509_free(IntPtr handle) { }

	[Address(RVA = "0x2609EC0", Offset = "0x26092C0", Length = "0x91")]
	[Token(Token = "0x6000279")]
	private static IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format) { }

	[Address(RVA = "0x2609F60", Offset = "0x2609360", Length = "0x93")]
	[Token(Token = "0x600027B")]
	private static int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format) { }

	[Address(RVA = "0x260A000", Offset = "0x2609400", Length = "0x78")]
	[Token(Token = "0x600027A")]
	private static IntPtr mono_btls_x509_get_subject_name(IntPtr handle) { }

	[Address(RVA = "0x260A080", Offset = "0x2609480", Length = "0x78")]
	[Token(Token = "0x6000278")]
	private static IntPtr mono_btls_x509_up_ref(IntPtr handle) { }

}

