namespace System.Security.Cryptography;

[Token(Token = "0x2000329")]
internal class DESTransform : SymmetricTransform
{
	[Token(Token = "0x4000D4E")]
	internal static readonly int KEY_BIT_SIZE; //Field offset: 0x0
	[Token(Token = "0x4000D4F")]
	internal static readonly int KEY_BYTE_SIZE; //Field offset: 0x4
	[Token(Token = "0x4000D50")]
	internal static readonly int BLOCK_BIT_SIZE; //Field offset: 0x8
	[Token(Token = "0x4000D51")]
	internal static readonly int BLOCK_BYTE_SIZE; //Field offset: 0xC
	[Token(Token = "0x4000D55")]
	private static readonly UInt32[] spBoxes; //Field offset: 0x10
	[Token(Token = "0x4000D56")]
	private static readonly Byte[] PC1; //Field offset: 0x18
	[Token(Token = "0x4000D57")]
	private static readonly Byte[] leftRotTotal; //Field offset: 0x20
	[Token(Token = "0x4000D58")]
	private static readonly Byte[] PC2; //Field offset: 0x28
	[Token(Token = "0x4000D59")]
	internal static readonly UInt32[] ipTab; //Field offset: 0x30
	[Token(Token = "0x4000D5A")]
	internal static readonly UInt32[] fpTab; //Field offset: 0x38
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D52")]
	private Byte[] keySchedule; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D53")]
	private Byte[] byteBuff; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D54")]
	private UInt32[] dwordBuff; //Field offset: 0x68

	[Address(RVA = "0x1EC9510", Offset = "0x1EC8910", Length = "0x2E3")]
	[Token(Token = "0x60019A2")]
	private static DESTransform() { }

	[Address(RVA = "0x1EC9800", Offset = "0x1EC8C00", Length = "0x323")]
	[Token(Token = "0x600199A")]
	internal DESTransform(SymmetricAlgorithm symmAlgo, bool encryption, Byte[] key, Byte[] iv) { }

	[Address(RVA = "0x1EC8460", Offset = "0x1EC7860", Length = "0x81")]
	[Token(Token = "0x600199D")]
	private static void BSwap(Byte[] byteBuff) { }

	[Address(RVA = "0x1EC84F0", Offset = "0x1EC78F0", Length = "0x2C1")]
	[Token(Token = "0x600199B")]
	private uint CipherFunct(uint r, int n) { }

	[Address(RVA = "0x1EC87C0", Offset = "0x1EC7BC0", Length = "0xC2")]
	[Token(Token = "0x60019A0")]
	protected virtual void ECB(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x1EC8890", Offset = "0x1EC7C90", Length = "0xAF")]
	[Token(Token = "0x60019A1")]
	internal static Byte[] GetStrongKey() { }

	[Address(RVA = "0x1EC8940", Offset = "0x1EC7D40", Length = "0x38B")]
	[Token(Token = "0x600199C")]
	internal static void Permutation(Byte[] input, Byte[] output, UInt32[] permTab, bool preSwap) { }

	[Address(RVA = "0x1EC8CD0", Offset = "0x1EC80D0", Length = "0x44A")]
	[Token(Token = "0x600199F")]
	public void ProcessBlock(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x1EC9120", Offset = "0x1EC8520", Length = "0x3E8")]
	[Token(Token = "0x600199E")]
	internal void SetKey(Byte[] key) { }

}

