namespace Mono.Btls;

[Token(Token = "0x200006D")]
internal class MonoBtlsBioMemory : MonoBtlsBio
{

	[Address(RVA = "0x22C0160", Offset = "0x22BF560", Length = "0xD6")]
	[Token(Token = "0x6000189")]
	public MonoBtlsBioMemory() { }

	[Address(RVA = "0x22BFF40", Offset = "0x22BF340", Length = "0x213")]
	[Token(Token = "0x600018A")]
	public Byte[] GetData() { }

	[Address(RVA = "0x22C0240", Offset = "0x22BF640", Length = "0x87")]
	[Token(Token = "0x6000188")]
	private static int mono_btls_bio_mem_get_data(IntPtr handle, out IntPtr data) { }

	[Address(RVA = "0x22C02D0", Offset = "0x22BF6D0", Length = "0x65")]
	[Token(Token = "0x6000187")]
	private static IntPtr mono_btls_bio_mem_new() { }

}

