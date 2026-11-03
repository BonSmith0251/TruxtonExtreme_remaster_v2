namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200030F")]
public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable
{
	[Token(Token = "0x4000D0F")]
	private static readonly Byte[] s_Sbox; //Field offset: 0x0
	[Token(Token = "0x4000D10")]
	private static readonly Int32[] s_Rcon; //Field offset: 0x8
	[Token(Token = "0x4000D11")]
	private static readonly Int32[] s_T; //Field offset: 0x10
	[Token(Token = "0x4000D12")]
	private static readonly Int32[] s_TF; //Field offset: 0x18
	[Token(Token = "0x4000D13")]
	private static readonly Int32[] s_iT; //Field offset: 0x20
	[Token(Token = "0x4000D14")]
	private static readonly Int32[] s_iTF; //Field offset: 0x28
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CFD")]
	private CipherMode m_cipherMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000CFE")]
	private PaddingMode m_paddingValue; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CFF")]
	private RijndaelManagedTransformMode m_transformMode; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000D00")]
	private int m_blockSizeBits; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D01")]
	private int m_blockSizeBytes; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000D02")]
	private int m_inputBlockSize; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D03")]
	private int m_outputBlockSize; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D04")]
	private Int32[] m_encryptKeyExpansion; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D05")]
	private Int32[] m_decryptKeyExpansion; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D06")]
	private int m_Nr; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000D07")]
	private int m_Nb; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000D08")]
	private int m_Nk; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000D09")]
	private Int32[] m_encryptindex; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000D0A")]
	private Int32[] m_decryptindex; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000D0B")]
	private Int32[] m_IV; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000D0C")]
	private Int32[] m_lastBlockBuffer; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000D0D")]
	private Byte[] m_depadBuffer; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000D0E")]
	private Byte[] m_shiftRegister; //Field offset: 0x78

	[Token(Token = "0x17000284")]
	public override bool CanTransformMultipleBlocks
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x60018D8")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000282")]
	public override int InputBlockSize
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x60018D6")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000283")]
	public override int OutputBlockSize
	{
		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[Token(Token = "0x60018D7")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1EC2F20", Offset = "0x1EC2320", Length = "0x26E")]
	[Token(Token = "0x60018E6")]
	private static RijndaelManagedTransform() { }

	[Address(RVA = "0x1EC3190", Offset = "0x1EC2590", Length = "0x6CB")]
	[Token(Token = "0x60018D3")]
	internal RijndaelManagedTransform(Byte[] rgbKey, CipherMode mode, Byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	[Address(RVA = "0x1EBFD30", Offset = "0x1EBF130", Length = "0x22E")]
	[Token(Token = "0x60018DF")]
	private void Dec(Int32* decryptindex, Int32* decryptKeyExpansion, Int32* iT, Int32* iTF, Int32* work, Int32* temp) { }

	[Address(RVA = "0x1EBFF60", Offset = "0x1EBF360", Length = "0xEEA")]
	[Token(Token = "0x60018DD")]
	private int DecryptData(Byte[] inputBuffer, int inputOffset, int inputCount, ref Byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	[Address(RVA = "0x1EC0E50", Offset = "0x1EC0250", Length = "0x11C")]
	[Token(Token = "0x60018D4")]
	public override void Dispose() { }

	[Address(RVA = "0x1EC0F70", Offset = "0x1EC0370", Length = "0x124")]
	[Token(Token = "0x60018D5")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x1EC10A0", Offset = "0x1EC04A0", Length = "0x204")]
	[Token(Token = "0x60018DE")]
	private void Enc(Int32* encryptindex, Int32* encryptKeyExpansion, Int32* T, Int32* TF, Int32* work, Int32* temp) { }

	[Address(RVA = "0x1EC12B0", Offset = "0x1EC06B0", Length = "0xCA2")]
	[Token(Token = "0x60018DC")]
	private int EncryptData(Byte[] inputBuffer, int inputOffset, int inputCount, ref Byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	[Address(RVA = "0x1EC1F60", Offset = "0x1EC1360", Length = "0x623")]
	[Token(Token = "0x60018E0")]
	private void GenerateKeyExpansion(Byte[] rgbKey) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x60018D8")]
	public override bool get_CanTransformMultipleBlocks() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x60018D6")]
	public override int get_InputBlockSize() { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x60018D7")]
	public override int get_OutputBlockSize() { }

	[Address(RVA = "0x1EC2590", Offset = "0x1EC1990", Length = "0x24")]
	[Token(Token = "0x60018E5")]
	private static int MulX(int x) { }

	[Address(RVA = "0x1EC25C0", Offset = "0x1EC19C0", Length = "0x75")]
	[Token(Token = "0x60018DB")]
	public void Reset() { }

	[Address(RVA = "0x1EC3860", Offset = "0x1EC2C60", Length = "0xE")]
	[Token(Token = "0x60018E1")]
	private static int rot1(int val) { }

	[Address(RVA = "0x1EC3870", Offset = "0x1EC2C70", Length = "0xE")]
	[Token(Token = "0x60018E2")]
	private static int rot2(int val) { }

	[Address(RVA = "0x1EC3880", Offset = "0x1EC2C80", Length = "0x10")]
	[Token(Token = "0x60018E3")]
	private static int rot3(int val) { }

	[Address(RVA = "0x1EC2640", Offset = "0x1EC1A40", Length = "0xE7")]
	[Token(Token = "0x60018E4")]
	private static int SubWord(int a) { }

	[Address(RVA = "0x1EC2730", Offset = "0x1EC1B30", Length = "0x41F")]
	[Token(Token = "0x60018D9")]
	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	[Address(RVA = "0x1EC2B50", Offset = "0x1EC1F50", Length = "0x3C2")]
	[Token(Token = "0x60018DA")]
	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

