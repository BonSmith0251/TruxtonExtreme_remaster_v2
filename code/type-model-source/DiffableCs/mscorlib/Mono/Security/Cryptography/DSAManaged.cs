namespace Mono.Security.Cryptography;

[Token(Token = "0x2000069")]
internal class DSAManaged : DSA
{
	[Token(Token = "0x200006A")]
	internal sealed class KeyGeneratedEventHandler : MulticastDelegate
	{

		[Address(RVA = "0x1BAC980", Offset = "0x1BABD80", Length = "0x125")]
		[Token(Token = "0x6000199")]
		public KeyGeneratedEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x600019A")]
		public override void Invoke(object sender, EventArgs e) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001EC")]
	private bool keypairGenerated; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40001ED")]
	private bool m_disposed; //Field offset: 0x21
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001EE")]
	private BigInteger p; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001EF")]
	private BigInteger q; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001F0")]
	private BigInteger g; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001F1")]
	private BigInteger x; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001F2")]
	private BigInteger y; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001F3")]
	private BigInteger j; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001F4")]
	private BigInteger seed; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001F5")]
	private int counter; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40001F6")]
	private bool j_missing; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001F7")]
	private RandomNumberGenerator rng; //Field offset: 0x68
	[CompilerGenerated]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001F8")]
	private KeyGeneratedEventHandler KeyGenerated; //Field offset: 0x70

	[Token(Token = "0x14000002")]
	public event KeyGeneratedEventHandler KeyGenerated
	{
		[Address(RVA = "0x1E72F40", Offset = "0x1E72340", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000197")]
		 add { } //Length: 158
		[Address(RVA = "0x1E73150", Offset = "0x1E72550", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000198")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000029")]
	public virtual int KeySize
	{
		[Address(RVA = "0x1E73080", Offset = "0x1E72480", Length = "0x2B")]
		[Token(Token = "0x6000190")]
		 get { } //Length: 43
	}

	[Token(Token = "0x1700002A")]
	public bool PublicOnly
	{
		[Address(RVA = "0x1E730B0", Offset = "0x1E724B0", Length = "0x5E")]
		[Token(Token = "0x6000191")]
		 get { } //Length: 94
	}

	[Token(Token = "0x17000028")]
	private RandomNumberGenerator Random
	{
		[Address(RVA = "0x1E73110", Offset = "0x1E72510", Length = "0x3B")]
		[Token(Token = "0x600018F")]
		private get { } //Length: 59
	}

	[Address(RVA = "0x1E72E70", Offset = "0x1E72270", Length = "0xCA")]
	[Token(Token = "0x6000189")]
	public DSAManaged(int dwKeySize) { }

	[Address(RVA = "0x1E72FE0", Offset = "0x1E723E0", Length = "0x9E")]
	[Token(Token = "0x600018D")]
	private void add(Byte[] a, Byte[] b, int value) { }

	[Address(RVA = "0x1E72F40", Offset = "0x1E72340", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000197")]
	public void add_KeyGenerated(KeyGeneratedEventHandler value) { }

	[Address(RVA = "0x1E71130", Offset = "0x1E70530", Length = "0x2B8")]
	[Token(Token = "0x6000196")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1E713F0", Offset = "0x1E707F0", Length = "0x3A9")]
	[Token(Token = "0x6000193")]
	public virtual DSAParameters ExportParameters(bool includePrivateParameters) { }

	[Address(RVA = "0x1E56230", Offset = "0x1E55630", Length = "0x65")]
	[Token(Token = "0x600018A")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1E72380", Offset = "0x1E71780", Length = "0x4D")]
	[Token(Token = "0x600018B")]
	private void Generate() { }

	[Address(RVA = "0x1E717A0", Offset = "0x1E70BA0", Length = "0x240")]
	[Token(Token = "0x600018C")]
	private void GenerateKeyPair() { }

	[Address(RVA = "0x1E719F0", Offset = "0x1E70DF0", Length = "0x984")]
	[Token(Token = "0x600018E")]
	private void GenerateParams(int keyLength) { }

	[Address(RVA = "0x1E73080", Offset = "0x1E72480", Length = "0x2B")]
	[Token(Token = "0x6000190")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x1E730B0", Offset = "0x1E724B0", Length = "0x5E")]
	[Token(Token = "0x6000191")]
	public bool get_PublicOnly() { }

	[Address(RVA = "0x1E73110", Offset = "0x1E72510", Length = "0x3B")]
	[Token(Token = "0x600018F")]
	private RandomNumberGenerator get_Random() { }

	[Address(RVA = "0x1E723D0", Offset = "0x1E717D0", Length = "0x42A")]
	[Token(Token = "0x6000194")]
	public virtual void ImportParameters(DSAParameters parameters) { }

	[Address(RVA = "0x1E72800", Offset = "0x1E71C00", Length = "0xAD")]
	[Token(Token = "0x6000192")]
	private Byte[] NormalizeArray(Byte[] array) { }

	[Address(RVA = "0x1E73150", Offset = "0x1E72550", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000198")]
	public void remove_KeyGenerated(KeyGeneratedEventHandler value) { }

	[Address(RVA = "0x1E728B0", Offset = "0x1E71CB0", Length = "0x5BF")]
	[Token(Token = "0x6000195")]
	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

