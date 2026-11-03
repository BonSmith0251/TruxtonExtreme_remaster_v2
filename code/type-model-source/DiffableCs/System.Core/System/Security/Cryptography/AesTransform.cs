namespace System.Security.Cryptography;

[Token(Token = "0x2000015")]
internal class AesTransform : SymmetricTransform
{
	[Token(Token = "0x4000005")]
	private static readonly UInt32[] Rcon; //Field offset: 0x0
	[Token(Token = "0x4000006")]
	private static readonly Byte[] SBox; //Field offset: 0x8
	[Token(Token = "0x4000007")]
	private static readonly Byte[] iSBox; //Field offset: 0x10
	[Token(Token = "0x4000008")]
	private static readonly UInt32[] T0; //Field offset: 0x18
	[Token(Token = "0x4000009")]
	private static readonly UInt32[] T1; //Field offset: 0x20
	[Token(Token = "0x400000A")]
	private static readonly UInt32[] T2; //Field offset: 0x28
	[Token(Token = "0x400000B")]
	private static readonly UInt32[] T3; //Field offset: 0x30
	[Token(Token = "0x400000C")]
	private static readonly UInt32[] iT0; //Field offset: 0x38
	[Token(Token = "0x400000D")]
	private static readonly UInt32[] iT1; //Field offset: 0x40
	[Token(Token = "0x400000E")]
	private static readonly UInt32[] iT2; //Field offset: 0x48
	[Token(Token = "0x400000F")]
	private static readonly UInt32[] iT3; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000002")]
	private UInt32[] expandedKey; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000003")]
	private int Nk; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000004")]
	private int Nr; //Field offset: 0x64

	[Address(RVA = "0x222F7E0", Offset = "0x222EBE0", Length = "0x448")]
	[Token(Token = "0x6000051")]
	private static AesTransform() { }

	[Address(RVA = "0x222FC30", Offset = "0x222F030", Length = "0x7DA")]
	[Token(Token = "0x600004C")]
	public AesTransform(Aes algo, bool encryption, Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x2229AE0", Offset = "0x2228EE0", Length = "0x2DF6")]
	[Token(Token = "0x6000050")]
	private void Decrypt128(Byte[] indata, Byte[] outdata, UInt32[] ekey) { }

	[Address(RVA = "0x222C8E0", Offset = "0x222BCE0", Length = "0x2B")]
	[Token(Token = "0x600004D")]
	protected virtual void ECB(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x222C910", Offset = "0x222BD10", Length = "0x2DC4")]
	[Token(Token = "0x600004F")]
	private void Encrypt128(Byte[] indata, Byte[] outdata, UInt32[] ekey) { }

	[Address(RVA = "0x222F6E0", Offset = "0x222EAE0", Length = "0xF2")]
	[Token(Token = "0x600004E")]
	private uint SubByte(uint a) { }

}

