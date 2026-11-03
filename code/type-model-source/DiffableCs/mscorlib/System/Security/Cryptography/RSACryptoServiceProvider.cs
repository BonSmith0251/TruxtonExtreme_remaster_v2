namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000314")]
public sealed class RSACryptoServiceProvider : RSA
{
	[Token(Token = "0x4000D21")]
	private static CspProviderFlags s_UseMachineKeyStore; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D22")]
	private KeyPairPersistence store; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D23")]
	private bool persistKey; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000D24")]
	private bool persisted; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000D25")]
	private bool privateKeyExportable; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x4000D26")]
	private bool m_disposed; //Field offset: 0x2B
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D27")]
	private RSAManaged rsa; //Field offset: 0x30

	[Token(Token = "0x17000286")]
	public virtual int KeySize
	{
		[Address(RVA = "0x1EBF130", Offset = "0x1EBE530", Length = "0x23")]
		[Token(Token = "0x6001905")]
		 get { } //Length: 35
	}

	[ComVisible(False)]
	[Token(Token = "0x17000287")]
	public bool PublicOnly
	{
		[Address(RVA = "0x1EBF160", Offset = "0x1EBE560", Length = "0x1D")]
		[Token(Token = "0x6001906")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000285")]
	public static bool UseMachineKeyStore
	{
		[Address(RVA = "0x1EBF180", Offset = "0x1EBE580", Length = "0x43")]
		[Token(Token = "0x60018FD")]
		 get { } //Length: 67
	}

	[Address(RVA = "0x1EBF100", Offset = "0x1EBE500", Length = "0x2C")]
	[Token(Token = "0x60018FE")]
	public RSACryptoServiceProvider() { }

	[Address(RVA = "0x1EBEFB0", Offset = "0x1EBE3B0", Length = "0x146")]
	[Token(Token = "0x60018FF")]
	public RSACryptoServiceProvider(CspParameters parameters) { }

	[Address(RVA = "0x1EBEE20", Offset = "0x1EBE220", Length = "0x34")]
	[Token(Token = "0x6001900")]
	public RSACryptoServiceProvider(int dwKeySize) { }

	[Address(RVA = "0x1EBEE60", Offset = "0x1EBE260", Length = "0x145")]
	[Token(Token = "0x6001901")]
	public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters) { }

	[Address(RVA = "0x1EBE270", Offset = "0x1EBD670", Length = "0x288")]
	[Token(Token = "0x6001902")]
	private void Common(int dwKeySize, bool parameters) { }

	[Address(RVA = "0x1EBE500", Offset = "0x1EBD900", Length = "0x120")]
	[Token(Token = "0x6001903")]
	private void Common(CspParameters p) { }

	[Address(RVA = "0x1EBE630", Offset = "0x1EBDA30", Length = "0x4C")]
	[Token(Token = "0x600190C")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1EBE680", Offset = "0x1EBDA80", Length = "0x2A")]
	[Token(Token = "0x6001907")]
	public virtual Byte[] EncryptValue(Byte[] rgb) { }

	[Address(RVA = "0x1EBE6B0", Offset = "0x1EBDAB0", Length = "0x19B")]
	[Token(Token = "0x6001908")]
	public virtual RSAParameters ExportParameters(bool includePrivateParameters) { }

	[Address(RVA = "0x1E56230", Offset = "0x1E55630", Length = "0x65")]
	[Token(Token = "0x6001904")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1EBF130", Offset = "0x1EBE530", Length = "0x23")]
	[Token(Token = "0x6001905")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x1EBF160", Offset = "0x1EBE560", Length = "0x1D")]
	[Token(Token = "0x6001906")]
	public bool get_PublicOnly() { }

	[Address(RVA = "0x1EBF180", Offset = "0x1EBE580", Length = "0x43")]
	[Token(Token = "0x60018FD")]
	public static bool get_UseMachineKeyStore() { }

	[Address(RVA = "0x1EBE850", Offset = "0x1EBDC50", Length = "0x1A3")]
	[Token(Token = "0x600190A")]
	private string GetHashNameFromOID(string oid) { }

	[Address(RVA = "0x1EBEA00", Offset = "0x1EBDE00", Length = "0x52")]
	[Token(Token = "0x6001909")]
	public virtual void ImportParameters(RSAParameters parameters) { }

	[Address(RVA = "0x1EBEA60", Offset = "0x1EBDE60", Length = "0x81")]
	[Token(Token = "0x600190D")]
	private void OnKeyGenerated(object sender, EventArgs e) { }

	[Address(RVA = "0x1EBEAF0", Offset = "0x1EBDEF0", Length = "0x328")]
	[Token(Token = "0x600190B")]
	public bool VerifyHash(Byte[] rgbHash, string str, Byte[] rgbSignature) { }

}

