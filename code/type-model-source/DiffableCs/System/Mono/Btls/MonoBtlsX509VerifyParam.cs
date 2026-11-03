namespace Mono.Btls;

[Token(Token = "0x20000A5")]
internal class MonoBtlsX509VerifyParam : MonoBtlsObject
{
	[Token(Token = "0x20000A6")]
	public class BoringX509VerifyParamHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x25F8FC0", Offset = "0x25F83C0", Length = "0xB")]
		[Token(Token = "0x6000308")]
		public BoringX509VerifyParamHandle(IntPtr handle) { }

		[Address(RVA = "0x25F9450", Offset = "0x25F8850", Length = "0x7B")]
		[Token(Token = "0x6000309")]
		protected virtual bool ReleaseHandle() { }

	}


	[Token(Token = "0x17000076")]
	public bool CanModify
	{
		[Address(RVA = "0x2608D80", Offset = "0x2608180", Length = "0x9A")]
		[Token(Token = "0x6000304")]
		 get { } //Length: 154
	}

	[Token(Token = "0x17000075")]
	internal BoringX509VerifyParamHandle Handle
	{
		[Address(RVA = "0x2608E20", Offset = "0x2608220", Length = "0x71")]
		[Token(Token = "0x60002F8")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x25123E0", Offset = "0x25117E0", Length = "0x8")]
	[Token(Token = "0x60002FF")]
	internal MonoBtlsX509VerifyParam(BoringX509VerifyParamHandle handle) { }

	[Address(RVA = "0x2608500", Offset = "0x2607900", Length = "0x12D")]
	[Token(Token = "0x6000300")]
	public MonoBtlsX509VerifyParam Copy() { }

	[Address(RVA = "0x2608D80", Offset = "0x2608180", Length = "0x9A")]
	[Token(Token = "0x6000304")]
	public bool get_CanModify() { }

	[Address(RVA = "0x2608E20", Offset = "0x2608220", Length = "0x71")]
	[Token(Token = "0x60002F8")]
	internal BoringX509VerifyParamHandle get_Handle() { }

	[Address(RVA = "0x2608630", Offset = "0x2607A30", Length = "0x35")]
	[Token(Token = "0x6000301")]
	public static MonoBtlsX509VerifyParam GetSslClient() { }

	[Address(RVA = "0x2608670", Offset = "0x2607A70", Length = "0x35")]
	[Token(Token = "0x6000302")]
	public static MonoBtlsX509VerifyParam GetSslServer() { }

	[Address(RVA = "0x26086B0", Offset = "0x2607AB0", Length = "0x271")]
	[Token(Token = "0x6000303")]
	public static MonoBtlsX509VerifyParam Lookup(string name, bool fail = false) { }

	[Address(RVA = "0x2608EA0", Offset = "0x26082A0", Length = "0x78")]
	[Token(Token = "0x60002FB")]
	private static int mono_btls_x509_verify_param_can_modify(IntPtr param) { }

	[Address(RVA = "0x2608F20", Offset = "0x2608320", Length = "0x78")]
	[Token(Token = "0x60002F9")]
	private static IntPtr mono_btls_x509_verify_param_copy(IntPtr handle) { }

	[Address(RVA = "0x2608FA0", Offset = "0x26083A0", Length = "0x78")]
	[Token(Token = "0x60002FE")]
	private static void mono_btls_x509_verify_param_free(IntPtr handle) { }

	[Address(RVA = "0x2609020", Offset = "0x2608420", Length = "0x78")]
	[Token(Token = "0x60002FA")]
	private static IntPtr mono_btls_x509_verify_param_lookup(IntPtr name) { }

	[Address(RVA = "0x26090A0", Offset = "0x26084A0", Length = "0x93")]
	[Token(Token = "0x60002FC")]
	private static int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen) { }

	[Address(RVA = "0x2609140", Offset = "0x2608540", Length = "0x87")]
	[Token(Token = "0x60002FD")]
	private static int mono_btls_x509_verify_param_set_time(IntPtr handle, long time) { }

	[Address(RVA = "0x2608930", Offset = "0x2607D30", Length = "0x1AC")]
	[Token(Token = "0x6000306")]
	public void SetHost(string name) { }

	[Address(RVA = "0x2608AE0", Offset = "0x2607EE0", Length = "0x1A2")]
	[Token(Token = "0x6000307")]
	public void SetTime(DateTime time) { }

	[Address(RVA = "0x2608C90", Offset = "0x2608090", Length = "0xE2")]
	[Token(Token = "0x6000305")]
	private void WantToModify() { }

}

