namespace System.Security.Cryptography;

[Token(Token = "0x20002EB")]
public abstract class HashAlgorithm : IDisposable, ICryptoTransform
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CAD")]
	private bool _disposed; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000CAE")]
	protected int HashSizeValue; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CAF")]
	protected private Byte[] HashValue; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000CB0")]
	protected int State; //Field offset: 0x20

	[Token(Token = "0x1700026A")]
	public override bool CanTransformMultipleBlocks
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6001839")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000267")]
	public override Byte[] Hash
	{
		[Address(RVA = "0x1EBA900", Offset = "0x1EB9D00", Length = "0x108")]
		[Token(Token = "0x6001830")]
		 get { } //Length: 264
	}

	[Token(Token = "0x17000266")]
	public override int HashSize
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x600182F")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000268")]
	public override int InputBlockSize
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6001837")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000269")]
	public override int OutputBlockSize
	{
		[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
		[Token(Token = "0x6001838")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600182D")]
	protected HashAlgorithm() { }

	[Address(RVA = "0x1EBA070", Offset = "0x1EB9470", Length = "0xB6")]
	[Token(Token = "0x6001833")]
	private Byte[] CaptureHashCodeAndReinitialize() { }

	[Address(RVA = "0x1EBA130", Offset = "0x1EB9530", Length = "0x3B")]
	[Token(Token = "0x6001835")]
	public void Clear() { }

	[Address(RVA = "0x1EBA170", Offset = "0x1EB9570", Length = "0xC7")]
	[Token(Token = "0x6001831")]
	public Byte[] ComputeHash(Byte[] buffer) { }

	[Address(RVA = "0x1EBA240", Offset = "0x1EB9640", Length = "0x1E1")]
	[Token(Token = "0x6001832")]
	public Byte[] ComputeHash(Byte[] buffer, int offset, int count) { }

	[Address(RVA = "0x1EBA430", Offset = "0x1EB9830", Length = "0x71")]
	[Token(Token = "0x600182E")]
	public static HashAlgorithm Create(string hashName) { }

	[Address(RVA = "0x1EBA4C0", Offset = "0x1EB98C0", Length = "0x61")]
	[Token(Token = "0x6001834")]
	public override void Dispose() { }

	[Address(RVA = "0x1EBA4B0", Offset = "0x1EB98B0", Length = "0x9")]
	[Token(Token = "0x6001836")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6001839")]
	public override bool get_CanTransformMultipleBlocks() { }

	[Address(RVA = "0x1EBA900", Offset = "0x1EB9D00", Length = "0x108")]
	[Token(Token = "0x6001830")]
	public override Byte[] get_Hash() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x600182F")]
	public override int get_HashSize() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6001837")]
	public override int get_InputBlockSize() { }

	[Address(RVA = "0x665330", Offset = "0x664730", Length = "0x6")]
	[Token(Token = "0x6001838")]
	public override int get_OutputBlockSize() { }

	[Token(Token = "0x600183D")]
	protected abstract void HashCore(Byte[] array, int ibStart, int cbSize) { }

	[Token(Token = "0x600183E")]
	protected abstract Byte[] HashFinal() { }

	[Token(Token = "0x600183F")]
	public abstract void Initialize() { }

	[Address(RVA = "0x1EBA530", Offset = "0x1EB9930", Length = "0xA1")]
	[Token(Token = "0x600183A")]
	public override int TransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount, Byte[] outputBuffer, int outputOffset) { }

	[Address(RVA = "0x1EBA5E0", Offset = "0x1EB99E0", Length = "0x156")]
	[Token(Token = "0x600183B")]
	public override Byte[] TransformFinalBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

	[Address(RVA = "0x1EBA740", Offset = "0x1EB9B40", Length = "0x1BC")]
	[Token(Token = "0x600183C")]
	private void ValidateTransformBlock(Byte[] inputBuffer, int inputOffset, int inputCount) { }

}

