namespace System.Security.Cryptography;

[Token(Token = "0x200032C")]
internal class RC2Transform : SymmetricTransform
{
	[Token(Token = "0x4000D6E")]
	private static readonly Byte[] pitable; //Field offset: 0x0
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D68")]
	private ushort R0; //Field offset: 0x58
	[FieldOffset(Offset = "0x5A")]
	[Token(Token = "0x4000D69")]
	private ushort R1; //Field offset: 0x5A
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000D6A")]
	private ushort R2; //Field offset: 0x5C
	[FieldOffset(Offset = "0x5E")]
	[Token(Token = "0x4000D6B")]
	private ushort R3; //Field offset: 0x5E
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D6C")]
	private UInt16[] K; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D6D")]
	private int j; //Field offset: 0x68

	[Address(RVA = "0x1ECC620", Offset = "0x1ECBA20", Length = "0x8C")]
	[Token(Token = "0x60019BA")]
	private static RC2Transform() { }

	[Address(RVA = "0x1ECC6B0", Offset = "0x1ECBAB0", Length = "0x5EE")]
	[Token(Token = "0x60019B8")]
	public RC2Transform(RC2 rc2Algo, bool encryption, Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x1ECBAE0", Offset = "0x1ECAEE0", Length = "0xB39")]
	[Token(Token = "0x60019B9")]
	protected virtual void ECB(Byte[] input, Byte[] output) { }

}

