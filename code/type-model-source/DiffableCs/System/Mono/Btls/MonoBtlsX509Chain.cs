namespace Mono.Btls;

[Token(Token = "0x200008F")]
internal class MonoBtlsX509Chain : MonoBtlsObject
{
	[Token(Token = "0x2000090")]
	public class BoringX509ChainHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x25F8FC0", Offset = "0x25F83C0", Length = "0xB")]
		[Token(Token = "0x6000296")]
		public BoringX509ChainHandle(IntPtr handle) { }

		[Address(RVA = "0x25F9060", Offset = "0x25F8460", Length = "0x7B")]
		[Token(Token = "0x6000297")]
		protected virtual bool ReleaseHandle() { }

	}


	[Token(Token = "0x1700006E")]
	public int Count
	{
		[Address(RVA = "0x2603240", Offset = "0x2602640", Length = "0x91")]
		[Token(Token = "0x6000292")]
		 get { } //Length: 145
	}

	[Token(Token = "0x1700006D")]
	internal BoringX509ChainHandle Handle
	{
		[Address(RVA = "0x26032E0", Offset = "0x26026E0", Length = "0x71")]
		[Token(Token = "0x6000289")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x2603170", Offset = "0x2602570", Length = "0xCA")]
	[Token(Token = "0x6000290")]
	public MonoBtlsX509Chain() { }

	[Address(RVA = "0x25123E0", Offset = "0x25117E0", Length = "0x8")]
	[Token(Token = "0x6000291")]
	internal MonoBtlsX509Chain(BoringX509ChainHandle handle) { }

	[Address(RVA = "0x2602DF0", Offset = "0x26021F0", Length = "0xB9")]
	[Token(Token = "0x6000294")]
	public void AddCertificate(MonoBtlsX509 x509) { }

	[Address(RVA = "0x2602EB0", Offset = "0x26022B0", Length = "0x12D")]
	[Token(Token = "0x6000295")]
	internal MonoBtlsX509Chain Copy() { }

	[Address(RVA = "0x2603240", Offset = "0x2602640", Length = "0x91")]
	[Token(Token = "0x6000292")]
	public int get_Count() { }

	[Address(RVA = "0x26032E0", Offset = "0x26026E0", Length = "0x71")]
	[Token(Token = "0x6000289")]
	internal BoringX509ChainHandle get_Handle() { }

	[Address(RVA = "0x2602FE0", Offset = "0x26023E0", Length = "0x185")]
	[Token(Token = "0x6000293")]
	public MonoBtlsX509 GetCertificate(int index) { }

	[Address(RVA = "0x2603360", Offset = "0x2602760", Length = "0x87")]
	[Token(Token = "0x600028D")]
	private static int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509) { }

	[Address(RVA = "0x26033F0", Offset = "0x26027F0", Length = "0x78")]
	[Token(Token = "0x600028F")]
	private static void mono_btls_x509_chain_free(IntPtr handle) { }

	[Address(RVA = "0x2603470", Offset = "0x2602870", Length = "0x85")]
	[Token(Token = "0x600028C")]
	private static IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index) { }

	[Address(RVA = "0x2603500", Offset = "0x2602900", Length = "0x78")]
	[Token(Token = "0x600028B")]
	private static int mono_btls_x509_chain_get_count(IntPtr handle) { }

	[Address(RVA = "0x2603580", Offset = "0x2602980", Length = "0x65")]
	[Token(Token = "0x600028A")]
	private static IntPtr mono_btls_x509_chain_new() { }

	[Address(RVA = "0x26035F0", Offset = "0x26029F0", Length = "0x78")]
	[Token(Token = "0x600028E")]
	private static IntPtr mono_btls_x509_chain_up_ref(IntPtr handle) { }

}

