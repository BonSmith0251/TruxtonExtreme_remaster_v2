namespace Mono.Security.Cryptography;

[Token(Token = "0x2000066")]
internal class RSAManaged : RSA
{
	[Token(Token = "0x2000067")]
	internal sealed class KeyGeneratedEventHandler : MulticastDelegate
	{

		[Address(RVA = "0x1BAC980", Offset = "0x1BABD80", Length = "0x125")]
		[Token(Token = "0x6000171")]
		public KeyGeneratedEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000172")]
		public override void Invoke(object sender, EventArgs e) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001D3")]
	private bool isCRTpossible; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40001D4")]
	private bool keyBlinding; //Field offset: 0x21
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x40001D5")]
	private bool keypairGenerated; //Field offset: 0x22
	[FieldOffset(Offset = "0x23")]
	[Token(Token = "0x40001D6")]
	private bool m_disposed; //Field offset: 0x23
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001D7")]
	private BigInteger d; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001D8")]
	private BigInteger p; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001D9")]
	private BigInteger q; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001DA")]
	private BigInteger dp; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001DB")]
	private BigInteger dq; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001DC")]
	private BigInteger qInv; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001DD")]
	private BigInteger n; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001DE")]
	private BigInteger e; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001DF")]
	private KeyGeneratedEventHandler KeyGenerated; //Field offset: 0x68

	[Token(Token = "0x14000001")]
	public event KeyGeneratedEventHandler KeyGenerated
	{
		[Address(RVA = "0x1E797D0", Offset = "0x1E78BD0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600016D")]
		 add { } //Length: 158
		[Address(RVA = "0x1E799C0", Offset = "0x1E78DC0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600016E")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000022")]
	public virtual int KeySize
	{
		[Address(RVA = "0x1E79870", Offset = "0x1E78C70", Length = "0xA5")]
		[Token(Token = "0x6000167")]
		 get { } //Length: 165
	}

	[Token(Token = "0x17000023")]
	public bool PublicOnly
	{
		[Address(RVA = "0x1E79920", Offset = "0x1E78D20", Length = "0x9A")]
		[Token(Token = "0x6000168")]
		 get { } //Length: 154
	}

	[Address(RVA = "0x1E796E0", Offset = "0x1E78AE0", Length = "0xEC")]
	[Token(Token = "0x6000164")]
	public RSAManaged(int keySize) { }

	[Address(RVA = "0x1E797D0", Offset = "0x1E78BD0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600016D")]
	public void add_KeyGenerated(KeyGeneratedEventHandler value) { }

	[Address(RVA = "0x1E77950", Offset = "0x1E76D50", Length = "0x40F")]
	[Token(Token = "0x600016C")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1E77D60", Offset = "0x1E77160", Length = "0x19A")]
	[Token(Token = "0x6000169")]
	public virtual Byte[] EncryptValue(Byte[] rgb) { }

	[Address(RVA = "0x1E77F00", Offset = "0x1E77300", Length = "0x41A")]
	[Token(Token = "0x600016A")]
	public virtual RSAParameters ExportParameters(bool includePrivateParameters) { }

	[Address(RVA = "0x1E56230", Offset = "0x1E55630", Length = "0x65")]
	[Token(Token = "0x6000165")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1E78320", Offset = "0x1E77720", Length = "0x567")]
	[Token(Token = "0x6000166")]
	private void GenerateKeyPair() { }

	[Address(RVA = "0x1E79870", Offset = "0x1E78C70", Length = "0xA5")]
	[Token(Token = "0x6000167")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x1E79920", Offset = "0x1E78D20", Length = "0x9A")]
	[Token(Token = "0x6000168")]
	public bool get_PublicOnly() { }

	[Address(RVA = "0x1E78890", Offset = "0x1E77C90", Length = "0xA9")]
	[Token(Token = "0x6000170")]
	private Byte[] GetPaddedValue(BigInteger value, int length) { }

	[Address(RVA = "0x1E78940", Offset = "0x1E77D40", Length = "0x7BE")]
	[Token(Token = "0x600016B")]
	public virtual void ImportParameters(RSAParameters parameters) { }

	[Address(RVA = "0x1E799C0", Offset = "0x1E78DC0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600016E")]
	public void remove_KeyGenerated(KeyGeneratedEventHandler value) { }

	[Address(RVA = "0x1E79100", Offset = "0x1E78500", Length = "0x5D6")]
	[Token(Token = "0x600016F")]
	public virtual string ToXmlString(bool includePrivateParameters) { }

}

