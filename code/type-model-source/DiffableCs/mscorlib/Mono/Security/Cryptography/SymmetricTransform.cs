namespace Mono.Security.Cryptography;

[Token(Token = "0x2000068")]
internal abstract class SymmetricTransform : ICryptoTransform, IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E0")]
	protected SymmetricAlgorithm algo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E1")]
	protected bool encrypt; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40001E2")]
	protected int BlockSizeByte; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001E3")]
	protected Byte[] temp; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001E4")]
	protected Byte[] temp2; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001E5")]
	private Byte[] workBuff; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001E6")]
	private Byte[] workout; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001E7")]
	protected PaddingMode padmode; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40001E8")]
	protected int FeedBackByte; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001E9")]
	private bool m_disposed; //Field offset: 0x48
	[FieldOffset(Offset = "0x49")]
	[Token(Token = "0x40001EA")]
	protected bool lastBlock; //Field offset: 0x49
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001EB")]
	private RandomNumberGenerator _rng; //Field offset: 0x50

	[Token(Token = "0x17000024")]
	public override bool CanTransformMultipleBlocks
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000177")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000025")]
	public override int InputBlockSize
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000178")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000027")]
	private bool KeepLastBlock
	{
		[Address(RVA = "0x1E8AA20", Offset = "0x1E89E20", Length = "0x17")]
		[Token(Token = "0x6000182")]
		private get { } //Length: 23
	}

	[Token(Token = "0x17000026")]
	public override int OutputBlockSize
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x6000179")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1E8A720", Offset = "0x1E89B20", Length = "0x2FA")]
	[Token(Token = "0x6000173")]
	public SymmetricTransform(SymmetricAlgorithm symmAlgo, bool encryption, Byte[] rgbIV) { }

	[Address(RVA = "0x1E89050", Offset = "0x1E88450", Length = "0x14B")]
	[Token(Token = "0x600017C")]
	protected override void CBC(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x1E891A0", Offset = "0x1E885A0", Length = "0x1EE")]
	[Token(Token = "0x600017D")]
	protected override void CFB(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x1E893E0", Offset = "0x1E887E0", Length = "0x19B")]
	[Token(Token = "0x6000180")]
	private void CheckInput(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	[Address(RVA = "0x1E89390", Offset = "0x1E88790", Length = "0x4E")]
	[Token(Token = "0x600017F")]
	protected override void CTS(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x1E89580", Offset = "0x1E88980", Length = "0x67")]
	[Token(Token = "0x6000176")]
	protected override void Dispose(bool disposing) { }

	[Token(Token = "0x600017B")]
	protected abstract void ECB(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x1E895F0", Offset = "0x1E889F0", Length = "0x337")]
	[Token(Token = "0x6000187")]
	protected override Byte[] FinalDecrypt(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	[Address(RVA = "0x1E89930", Offset = "0x1E88D30", Length = "0x34D")]
	[Token(Token = "0x6000186")]
	protected override Byte[] FinalEncrypt(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	[Address(RVA = "0x1E89C80", Offset = "0x1E89080", Length = "0x65")]
	[Token(Token = "0x6000174")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000177")]
	public override bool get_CanTransformMultipleBlocks() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000178")]
	public override int get_InputBlockSize() { }

	[Address(RVA = "0x1E8AA20", Offset = "0x1E89E20", Length = "0x17")]
	[Token(Token = "0x6000182")]
	private bool get_KeepLastBlock() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x6000179")]
	public override int get_OutputBlockSize() { }

	[Address(RVA = "0x1E89CF0", Offset = "0x1E890F0", Length = "0x1E9")]
	[Token(Token = "0x6000183")]
	private int InternalTransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	[Address(RVA = "0x1E89EE0", Offset = "0x1E892E0", Length = "0x4E")]
	[Token(Token = "0x600017E")]
	protected override void OFB(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x1E89F30", Offset = "0x1E89330", Length = "0xCE")]
	[Token(Token = "0x6000184")]
	private void Random(Byte[] buffer, int start, int length) { }

	[Address(RVA = "0x1E8A000", Offset = "0x1E89400", Length = "0x61")]
	[Token(Token = "0x6000175")]
	private override void System.IDisposable.Dispose() { }

	[Address(RVA = "0x1E8A070", Offset = "0x1E89470", Length = "0x139")]
	[Token(Token = "0x6000185")]
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	[Address(RVA = "0x1E8A5A0", Offset = "0x1E899A0", Length = "0x172")]
	[Token(Token = "0x600017A")]
	protected override void Transform(Byte[] input, Byte[] output) { }

	[Address(RVA = "0x1E8A1B0", Offset = "0x1E895B0", Length = "0x315")]
	[Token(Token = "0x6000181")]
	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	[Address(RVA = "0x1E8A4D0", Offset = "0x1E898D0", Length = "0xCB")]
	[Token(Token = "0x6000188")]
	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

