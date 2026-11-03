namespace Mono.Btls;

[Token(Token = "0x2000077")]
internal class MonoBtlsKey : MonoBtlsObject
{
	[Token(Token = "0x2000078")]
	public class BoringKeyHandle : MonoBtlsHandle
	{

		[Address(RVA = "0x22BAFD0", Offset = "0x22BA3D0", Length = "0xB")]
		[Token(Token = "0x60001D3")]
		internal BoringKeyHandle(IntPtr handle) { }

		[Address(RVA = "0x22BAFE0", Offset = "0x22BA3E0", Length = "0x7B")]
		[Token(Token = "0x60001D4")]
		protected virtual bool ReleaseHandle() { }

	}


	[Token(Token = "0x1700005B")]
	internal BoringKeyHandle Handle
	{
		[Address(RVA = "0x22C44C0", Offset = "0x22C38C0", Length = "0x75")]
		[Token(Token = "0x60001CE")]
		internal get { } //Length: 117
	}

	[Address(RVA = "0x67F6E0", Offset = "0x67EAE0", Length = "0x31")]
	[Token(Token = "0x60001CF")]
	internal MonoBtlsKey(BoringKeyHandle handle) { }

	[Address(RVA = "0x22C3FA0", Offset = "0x22C33A0", Length = "0x143")]
	[Token(Token = "0x60001D1")]
	public MonoBtlsKey Copy() { }

	[Address(RVA = "0x22C40F0", Offset = "0x22C34F0", Length = "0x1F9")]
	[Token(Token = "0x60001D2")]
	public static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey) { }

	[Address(RVA = "0x22C44C0", Offset = "0x22C38C0", Length = "0x75")]
	[Token(Token = "0x60001CE")]
	internal BoringKeyHandle get_Handle() { }

	[Address(RVA = "0x22C42F0", Offset = "0x22C36F0", Length = "0x1C3")]
	[Token(Token = "0x60001D0")]
	public Byte[] GetBytes(bool include_private_bits) { }

	[Address(RVA = "0x22C4540", Offset = "0x22C3940", Length = "0xA2")]
	[Token(Token = "0x60001CD")]
	private static int mono_btls_key_assign_rsa_private_key(IntPtr handle, Byte[] der, int der_length) { }

	[Address(RVA = "0x22C45F0", Offset = "0x22C39F0", Length = "0x78")]
	[Token(Token = "0x60001CA")]
	private static void mono_btls_key_free(IntPtr handle) { }

	[Address(RVA = "0x22C4670", Offset = "0x22C3A70", Length = "0xA2")]
	[Token(Token = "0x60001CC")]
	private static int mono_btls_key_get_bytes(IntPtr handle, out IntPtr data, out int size, int include_private_bits) { }

	[Address(RVA = "0x22C4720", Offset = "0x22C3B20", Length = "0x65")]
	[Token(Token = "0x60001C9")]
	private static IntPtr mono_btls_key_new() { }

	[Address(RVA = "0x22C4790", Offset = "0x22C3B90", Length = "0x78")]
	[Token(Token = "0x60001CB")]
	private static IntPtr mono_btls_key_up_ref(IntPtr handle) { }

}

