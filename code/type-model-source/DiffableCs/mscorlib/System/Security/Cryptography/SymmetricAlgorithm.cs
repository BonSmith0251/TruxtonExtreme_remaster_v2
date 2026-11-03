namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000324")]
public abstract class SymmetricAlgorithm : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D40")]
	protected int BlockSizeValue; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000D41")]
	protected int FeedbackSizeValue; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D42")]
	protected Byte[] IVValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D43")]
	protected Byte[] KeyValue; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D44")]
	protected KeySizes[] LegalBlockSizesValue; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D45")]
	protected KeySizes[] LegalKeySizesValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000D46")]
	protected int KeySizeValue; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000D47")]
	protected CipherMode ModeValue; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000D48")]
	protected PaddingMode PaddingValue; //Field offset: 0x40

	[Token(Token = "0x1700028C")]
	public override int BlockSize
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6001961")]
		 get { } //Length: 85
		[Address(RVA = "0x1ED4A20", Offset = "0x1ED3E20", Length = "0x145")]
		[Token(Token = "0x6001962")]
		 set { } //Length: 325
	}

	[Token(Token = "0x1700028D")]
	public override int FeedbackSize
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6001963")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700028E")]
	public override Byte[] IV
	{
		[Address(RVA = "0x1ED4860", Offset = "0x1ED3C60", Length = "0x94")]
		[Token(Token = "0x6001964")]
		 get { } //Length: 148
		[Address(RVA = "0x1ED4B70", Offset = "0x1ED3F70", Length = "0x16B")]
		[Token(Token = "0x6001965")]
		 set { } //Length: 363
	}

	[Token(Token = "0x1700028F")]
	public override Byte[] Key
	{
		[Address(RVA = "0x1ED4900", Offset = "0x1ED3D00", Length = "0x94")]
		[Token(Token = "0x6001966")]
		 get { } //Length: 148
		[Address(RVA = "0x1ED4D80", Offset = "0x1ED4180", Length = "0x183")]
		[Token(Token = "0x6001967")]
		 set { } //Length: 387
	}

	[Token(Token = "0x17000291")]
	public override int KeySize
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x6001969")]
		 get { } //Length: 4
		[Address(RVA = "0x1ED4CE0", Offset = "0x1ED40E0", Length = "0x90")]
		[Token(Token = "0x600196A")]
		 set { } //Length: 144
	}

	[Token(Token = "0x17000290")]
	public override KeySizes[] LegalKeySizes
	{
		[Address(RVA = "0x1ED49A0", Offset = "0x1ED3DA0", Length = "0x77")]
		[Token(Token = "0x6001968")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000292")]
	public override CipherMode Mode
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x600196B")]
		 get { } //Length: 4
		[Address(RVA = "0x1ED4F10", Offset = "0x1ED4310", Length = "0x7D")]
		[Token(Token = "0x600196C")]
		 set { } //Length: 125
	}

	[Token(Token = "0x17000293")]
	public override PaddingMode Padding
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x600196D")]
		 get { } //Length: 4
		[Address(RVA = "0x1ED4F90", Offset = "0x1ED4390", Length = "0x7D")]
		[Token(Token = "0x600196E")]
		 set { } //Length: 125
	}

	[Address(RVA = "0x1ED4830", Offset = "0x1ED3C30", Length = "0x24")]
	[Token(Token = "0x600195D")]
	protected SymmetricAlgorithm() { }

	[Address(RVA = "0x1ED4440", Offset = "0x1ED3840", Length = "0xAE")]
	[Token(Token = "0x600195F")]
	public void Clear() { }

	[Address(RVA = "0x1ED45D0", Offset = "0x1ED39D0", Length = "0xC6")]
	[Token(Token = "0x6001970")]
	public static SymmetricAlgorithm Create(string algName) { }

	[Token(Token = "0x6001974")]
	public abstract ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1ED44F0", Offset = "0x1ED38F0", Length = "0x61")]
	[Token(Token = "0x6001973")]
	public override ICryptoTransform CreateDecryptor() { }

	[Token(Token = "0x6001972")]
	public abstract ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1ED4560", Offset = "0x1ED3960", Length = "0x61")]
	[Token(Token = "0x6001971")]
	public override ICryptoTransform CreateEncryptor() { }

	[Address(RVA = "0x1ED4720", Offset = "0x1ED3B20", Length = "0x61")]
	[Token(Token = "0x600195E")]
	public override void Dispose() { }

	[Address(RVA = "0x1ED46A0", Offset = "0x1ED3AA0", Length = "0x72")]
	[Token(Token = "0x6001960")]
	protected override void Dispose(bool disposing) { }

	[Token(Token = "0x6001976")]
	public abstract void GenerateIV() { }

	[Token(Token = "0x6001975")]
	public abstract void GenerateKey() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6001961")]
	public override int get_BlockSize() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6001963")]
	public override int get_FeedbackSize() { }

	[Address(RVA = "0x1ED4860", Offset = "0x1ED3C60", Length = "0x94")]
	[Token(Token = "0x6001964")]
	public override Byte[] get_IV() { }

	[Address(RVA = "0x1ED4900", Offset = "0x1ED3D00", Length = "0x94")]
	[Token(Token = "0x6001966")]
	public override Byte[] get_Key() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x6001969")]
	public override int get_KeySize() { }

	[Address(RVA = "0x1ED49A0", Offset = "0x1ED3DA0", Length = "0x77")]
	[Token(Token = "0x6001968")]
	public override KeySizes[] get_LegalKeySizes() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x600196B")]
	public override CipherMode get_Mode() { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x600196D")]
	public override PaddingMode get_Padding() { }

	[Address(RVA = "0x1ED4A20", Offset = "0x1ED3E20", Length = "0x145")]
	[Token(Token = "0x6001962")]
	public override void set_BlockSize(int value) { }

	[Address(RVA = "0x1ED4B70", Offset = "0x1ED3F70", Length = "0x16B")]
	[Token(Token = "0x6001965")]
	public override void set_IV(Byte[] value) { }

	[Address(RVA = "0x1ED4D80", Offset = "0x1ED4180", Length = "0x183")]
	[Token(Token = "0x6001967")]
	public override void set_Key(Byte[] value) { }

	[Address(RVA = "0x1ED4CE0", Offset = "0x1ED40E0", Length = "0x90")]
	[Token(Token = "0x600196A")]
	public override void set_KeySize(int value) { }

	[Address(RVA = "0x1ED4F10", Offset = "0x1ED4310", Length = "0x7D")]
	[Token(Token = "0x600196C")]
	public override void set_Mode(CipherMode value) { }

	[Address(RVA = "0x1ED4F90", Offset = "0x1ED4390", Length = "0x7D")]
	[Token(Token = "0x600196E")]
	public override void set_Padding(PaddingMode value) { }

	[Address(RVA = "0x1ED4790", Offset = "0x1ED3B90", Length = "0x90")]
	[Token(Token = "0x600196F")]
	public bool ValidKeySize(int bitLength) { }

}

