namespace System.Security.Cryptography;

[Token(Token = "0x2000332")]
internal class TripleDESTransform : SymmetricTransform
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D79")]
	private DESTransform E1; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D7A")]
	private DESTransform D2; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D7B")]
	private DESTransform E3; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D7C")]
	private DESTransform D1; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D7D")]
	private DESTransform E2; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D7E")]
	private DESTransform D3; //Field offset: 0x80

	[Address(RVA = "0x1EF21E0", Offset = "0x1EF15E0", Length = "0x43B")]
	[Token(Token = "0x60019DA")]
	public TripleDESTransform(TripleDES algo, bool encryption, Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x1EF1FD0", Offset = "0x1EF13D0", Length = "0x15B")]
	[Token(Token = "0x60019DB")]
	protected virtual void ECB(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x1EF2130", Offset = "0x1EF1530", Length = "0xA1")]
	[Token(Token = "0x60019DC")]
	internal static Byte[] GetStrongKey() { }

}

