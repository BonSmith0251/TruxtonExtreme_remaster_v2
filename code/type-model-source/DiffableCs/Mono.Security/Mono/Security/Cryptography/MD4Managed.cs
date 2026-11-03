namespace Mono.Security.Cryptography;

[Token(Token = "0x200004C")]
public class MD4Managed : MD4
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000213")]
	private UInt32[] state; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000214")]
	private Byte[] buffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000215")]
	private UInt32[] count; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000216")]
	private UInt32[] x; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000217")]
	private Byte[] digest; //Field offset: 0x48

	[Address(RVA = "0x1E508B0", Offset = "0x1E4FCB0", Length = "0x103")]
	[Token(Token = "0x600018D")]
	public MD4Managed() { }

	[Address(RVA = "0x1E4F610", Offset = "0x1E4EA10", Length = "0xA4")]
	[Token(Token = "0x600019A")]
	private void Decode(UInt32[] output, Byte[] input, int index) { }

	[Address(RVA = "0x1E4F6C0", Offset = "0x1E4EAC0", Length = "0xA5")]
	[Token(Token = "0x6000199")]
	private void Encode(Byte[] output, UInt32[] input) { }

	[Address(RVA = "0x1E4F7B0", Offset = "0x1E4EBB0", Length = "0xD")]
	[Token(Token = "0x6000192")]
	private uint F(uint x, uint y, uint z) { }

	[Address(RVA = "0x1E4F770", Offset = "0x1E4EB70", Length = "0x38")]
	[Token(Token = "0x6000196")]
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	[Address(RVA = "0x1E4F810", Offset = "0x1E4EC10", Length = "0xF")]
	[Token(Token = "0x6000193")]
	private uint G(uint x, uint y, uint z) { }

	[Address(RVA = "0x1E4F7C0", Offset = "0x1E4EBC0", Length = "0x42")]
	[Token(Token = "0x6000197")]
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	[Address(RVA = "0x1E4F860", Offset = "0x1E4EC60", Length = "0x9")]
	[Token(Token = "0x6000194")]
	private uint H(uint x, uint y, uint z) { }

	[Address(RVA = "0x1E4F870", Offset = "0x1E4EC70", Length = "0x17B")]
	[Token(Token = "0x600018F")]
	protected virtual void HashCore(Byte[] array, int ibStart, int cbSize) { }

	[Address(RVA = "0x1E4F9F0", Offset = "0x1E4EDF0", Length = "0x2BF")]
	[Token(Token = "0x6000190")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1E4F820", Offset = "0x1E4EC20", Length = "0x3B")]
	[Token(Token = "0x6000198")]
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	[Address(RVA = "0x1E4FCB0", Offset = "0x1E4F0B0", Length = "0xCE")]
	[Token(Token = "0x600018E")]
	public virtual void Initialize() { }

	[Address(RVA = "0x1E4FD80", Offset = "0x1E4F180", Length = "0xAAF")]
	[Token(Token = "0x600019B")]
	private void MD4Transform(UInt32[] state, Byte[] block, int index) { }

	[Address(RVA = "0x1E50830", Offset = "0x1E4FC30", Length = "0x5E")]
	[Token(Token = "0x6000191")]
	private Byte[] Padding(int nLength) { }

	[Address(RVA = "0x1E50890", Offset = "0x1E4FC90", Length = "0x1A")]
	[Token(Token = "0x6000195")]
	private uint ROL(uint x, byte n) { }

}

