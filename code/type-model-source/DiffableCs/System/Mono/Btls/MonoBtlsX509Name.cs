namespace Mono.Btls;

[Token(Token = "0x200009B")]
internal class MonoBtlsX509Name : MonoBtlsObject
{
	[Token(Token = "0x200009C")]
	public class BoringX509NameHandle : MonoBtlsHandle
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001C8")]
		private bool dontFree; //Field offset: 0x20

		[Address(RVA = "0x25F9310", Offset = "0x25F8710", Length = "0x2C")]
		[Token(Token = "0x60002CA")]
		internal BoringX509NameHandle(IntPtr handle, bool ownsHandle) { }

		[Address(RVA = "0x25F9280", Offset = "0x25F8680", Length = "0x88")]
		[Token(Token = "0x60002CB")]
		protected virtual bool ReleaseHandle() { }

	}


	[Token(Token = "0x17000071")]
	internal BoringX509NameHandle Handle
	{
		[Address(RVA = "0x2605BE0", Offset = "0x2604FE0", Length = "0x71")]
		[Token(Token = "0x60002C1")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x25123E0", Offset = "0x25117E0", Length = "0x8")]
	[Token(Token = "0x60002C2")]
	internal MonoBtlsX509Name(BoringX509NameHandle handle) { }

	[Address(RVA = "0x2605280", Offset = "0x2604680", Length = "0x180")]
	[Token(Token = "0x60002C9")]
	public static MonoBtlsX509Name CreateFromData(Byte[] data, bool use_canon_enc) { }

	[Address(RVA = "0x2605BE0", Offset = "0x2604FE0", Length = "0x71")]
	[Token(Token = "0x60002C1")]
	internal BoringX509NameHandle get_Handle() { }

	[Address(RVA = "0x2605410", Offset = "0x2604810", Length = "0x91")]
	[Token(Token = "0x60002C4")]
	public int GetEntryCount() { }

	[Address(RVA = "0x2605610", Offset = "0x2604A10", Length = "0x22F")]
	[Token(Token = "0x60002C6")]
	public string GetEntryOid(int index) { }

	[Address(RVA = "0x26054B0", Offset = "0x26048B0", Length = "0x157")]
	[Token(Token = "0x60002C7")]
	public Byte[] GetEntryOidData(int index) { }

	[Address(RVA = "0x2605840", Offset = "0x2604C40", Length = "0xE9")]
	[Token(Token = "0x60002C5")]
	public MonoBtlsX509NameEntryType GetEntryType(int index) { }

	[Address(RVA = "0x2605930", Offset = "0x2604D30", Length = "0x205")]
	[Token(Token = "0x60002C8")]
	public string GetEntryValue(int index, out int tag) { }

	[Address(RVA = "0x2605B40", Offset = "0x2604F40", Length = "0x91")]
	[Token(Token = "0x60002C3")]
	public long GetHash() { }

	[Address(RVA = "0x2605C60", Offset = "0x2605060", Length = "0x78")]
	[Token(Token = "0x60002C0")]
	private static void mono_btls_x509_name_free(IntPtr handle) { }

	[Address(RVA = "0x2605CE0", Offset = "0x26050E0", Length = "0x91")]
	[Token(Token = "0x60002BF")]
	private static IntPtr mono_btls_x509_name_from_data(Void* data, int len, int use_canon_enc) { }

	[Address(RVA = "0x2605D80", Offset = "0x2605180", Length = "0x78")]
	[Token(Token = "0x60002BA")]
	private static int mono_btls_x509_name_get_entry_count(IntPtr handle) { }

	[Address(RVA = "0x2605EA0", Offset = "0x26052A0", Length = "0xA0")]
	[Token(Token = "0x60002BC")]
	private static int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size) { }

	[Address(RVA = "0x2605E00", Offset = "0x2605200", Length = "0x91")]
	[Token(Token = "0x60002BD")]
	private static int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, out IntPtr data) { }

	[Address(RVA = "0x2605F40", Offset = "0x2605340", Length = "0x85")]
	[Token(Token = "0x60002BB")]
	private static MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index) { }

	[Address(RVA = "0x2605FD0", Offset = "0x26053D0", Length = "0xA0")]
	[Token(Token = "0x60002BE")]
	private static int mono_btls_x509_name_get_entry_value(IntPtr name, int index, out int tag, out IntPtr str) { }

	[Address(RVA = "0x2606070", Offset = "0x2605470", Length = "0x78")]
	[Token(Token = "0x60002B9")]
	private static long mono_btls_x509_name_hash(IntPtr handle) { }

}

