namespace Mono.Btls;

[Token(Token = "0x200007B")]
internal class MonoBtlsPkcs12 : MonoBtlsObject
{
	[Token(Token = "0x200007C")]
	public class BoringPkcs12Handle : MonoBtlsHandle
	{

		[Address(RVA = "0x22BAFD0", Offset = "0x22BA3D0", Length = "0xB")]
		[Token(Token = "0x60001F3")]
		public BoringPkcs12Handle(IntPtr handle) { }

		[Address(RVA = "0x22BB060", Offset = "0x22BA460", Length = "0x7B")]
		[Token(Token = "0x60001F4")]
		protected virtual bool ReleaseHandle() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400014C")]
	private MonoBtlsKey privateKey; //Field offset: 0x20

	[Token(Token = "0x17000060")]
	public int Count
	{
		[Address(RVA = "0x22C55F0", Offset = "0x22C49F0", Length = "0x91")]
		[Token(Token = "0x60001EE")]
		 get { } //Length: 145
	}

	[Token(Token = "0x1700005F")]
	internal BoringPkcs12Handle Handle
	{
		[Address(RVA = "0x22C5690", Offset = "0x22C4A90", Length = "0x75")]
		[Token(Token = "0x60001E5")]
		internal get { } //Length: 117
	}

	[Token(Token = "0x17000061")]
	public bool HasPrivateKey
	{
		[Address(RVA = "0x22C5710", Offset = "0x22C4B10", Length = "0x9A")]
		[Token(Token = "0x60001F1")]
		 get { } //Length: 154
	}

	[Address(RVA = "0x22C5510", Offset = "0x22C4910", Length = "0xD6")]
	[Token(Token = "0x60001ED")]
	internal MonoBtlsPkcs12() { }

	[Address(RVA = "0x22C55F0", Offset = "0x22C49F0", Length = "0x91")]
	[Token(Token = "0x60001EE")]
	public int get_Count() { }

	[Address(RVA = "0x22C5690", Offset = "0x22C4A90", Length = "0x75")]
	[Token(Token = "0x60001E5")]
	internal BoringPkcs12Handle get_Handle() { }

	[Address(RVA = "0x22C5710", Offset = "0x22C4B10", Length = "0x9A")]
	[Token(Token = "0x60001F1")]
	public bool get_HasPrivateKey() { }

	[Address(RVA = "0x22C4F80", Offset = "0x22C4380", Length = "0x1FB")]
	[Token(Token = "0x60001EF")]
	public MonoBtlsX509 GetCertificate(int index) { }

	[Address(RVA = "0x22C5180", Offset = "0x22C4580", Length = "0x219")]
	[Token(Token = "0x60001F2")]
	public MonoBtlsKey GetPrivateKey() { }

	[Address(RVA = "0x22C53A0", Offset = "0x22C47A0", Length = "0x169")]
	[Token(Token = "0x60001F0")]
	public void Import(Byte[] buffer, SafePasswordHandle password) { }

	[Address(RVA = "0x22C57B0", Offset = "0x22C4BB0", Length = "0x78")]
	[Token(Token = "0x60001E6")]
	private static void mono_btls_pkcs12_free(IntPtr handle) { }

	[Address(RVA = "0x22C5830", Offset = "0x22C4C30", Length = "0x85")]
	[Token(Token = "0x60001E9")]
	private static IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index) { }

	[Address(RVA = "0x22C58C0", Offset = "0x22C4CC0", Length = "0x78")]
	[Token(Token = "0x60001E8")]
	private static int mono_btls_pkcs12_get_count(IntPtr handle) { }

	[Address(RVA = "0x22C5940", Offset = "0x22C4D40", Length = "0x78")]
	[Token(Token = "0x60001EC")]
	private static IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12) { }

	[Address(RVA = "0x22C59C0", Offset = "0x22C4DC0", Length = "0x78")]
	[Token(Token = "0x60001EB")]
	private static int mono_btls_pkcs12_has_private_key(IntPtr pkcs12) { }

	[Address(RVA = "0x22C5A40", Offset = "0x22C4E40", Length = "0xED")]
	[Token(Token = "0x60001EA")]
	private static int mono_btls_pkcs12_import(IntPtr chain, Void* data, int len, SafePasswordHandle password) { }

	[Address(RVA = "0x22C5B30", Offset = "0x22C4F30", Length = "0x65")]
	[Token(Token = "0x60001E7")]
	private static IntPtr mono_btls_pkcs12_new() { }

}

