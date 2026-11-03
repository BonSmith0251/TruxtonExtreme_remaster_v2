namespace Mono.Security.Cryptography;

[Token(Token = "0x2000051")]
public class RSAManaged : RSA
{
	[Token(Token = "0x2000052")]
	internal sealed class KeyGeneratedEventHandler : MulticastDelegate
	{

		[Address(RVA = "0xB0AF90", Offset = "0xB0A390", Length = "0x125")]
		[Token(Token = "0x60001CC")]
		public KeyGeneratedEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x60001CD")]
		public override void Invoke(object sender, EventArgs e) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000224")]
	private bool isCRTpossible; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000225")]
	private bool keyBlinding; //Field offset: 0x21
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x4000226")]
	private bool keypairGenerated; //Field offset: 0x22
	[FieldOffset(Offset = "0x23")]
	[Token(Token = "0x4000227")]
	private bool m_disposed; //Field offset: 0x23
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000228")]
	private BigInteger d; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000229")]
	private BigInteger p; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400022A")]
	private BigInteger q; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400022B")]
	private BigInteger dp; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400022C")]
	private BigInteger dq; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400022D")]
	private BigInteger qInv; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400022E")]
	private BigInteger n; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400022F")]
	private BigInteger e; //Field offset: 0x60
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000230")]
	private KeyGeneratedEventHandler KeyGenerated; //Field offset: 0x68

	[Token(Token = "0x17000081")]
	public virtual int KeySize
	{
		[Address(RVA = "0x1E57840", Offset = "0x1E56C40", Length = "0xA5")]
		[Token(Token = "0x60001C4")]
		 get { } //Length: 165
	}

	[Token(Token = "0x17000082")]
	public bool PublicOnly
	{
		[Address(RVA = "0x1E578F0", Offset = "0x1E56CF0", Length = "0x9A")]
		[Token(Token = "0x60001C5")]
		 get { } //Length: 154
	}

	[Address(RVA = "0x1E57660", Offset = "0x1E56A60", Length = "0xE3")]
	[Token(Token = "0x60001C0")]
	public RSAManaged() { }

	[Address(RVA = "0x1E57750", Offset = "0x1E56B50", Length = "0xEC")]
	[Token(Token = "0x60001C1")]
	public RSAManaged(int keySize) { }

	[Address(RVA = "0x1E55800", Offset = "0x1E54C00", Length = "0x40F")]
	[Token(Token = "0x60001C9")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1E55C10", Offset = "0x1E55010", Length = "0x1F8")]
	[Token(Token = "0x60001C6")]
	public virtual Byte[] EncryptValue(Byte[] rgb) { }

	[Address(RVA = "0x1E55E10", Offset = "0x1E55210", Length = "0x41A")]
	[Token(Token = "0x60001C7")]
	public virtual RSAParameters ExportParameters(bool includePrivateParameters) { }

	[Address(RVA = "0x1E56230", Offset = "0x1E55630", Length = "0x65")]
	[Token(Token = "0x60001C2")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1E562A0", Offset = "0x1E556A0", Length = "0x567")]
	[Token(Token = "0x60001C3")]
	private void GenerateKeyPair() { }

	[Address(RVA = "0x1E57840", Offset = "0x1E56C40", Length = "0xA5")]
	[Token(Token = "0x60001C4")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x1E578F0", Offset = "0x1E56CF0", Length = "0x9A")]
	[Token(Token = "0x60001C5")]
	public bool get_PublicOnly() { }

	[Address(RVA = "0x1E56810", Offset = "0x1E55C10", Length = "0xA9")]
	[Token(Token = "0x60001CB")]
	private Byte[] GetPaddedValue(BigInteger value, int length) { }

	[Address(RVA = "0x1E568C0", Offset = "0x1E55CC0", Length = "0x7BE")]
	[Token(Token = "0x60001C8")]
	public virtual void ImportParameters(RSAParameters parameters) { }

	[Address(RVA = "0x1E57080", Offset = "0x1E56480", Length = "0x5D6")]
	[Token(Token = "0x60001CA")]
	public virtual string ToXmlString(bool includePrivateParameters) { }

}

