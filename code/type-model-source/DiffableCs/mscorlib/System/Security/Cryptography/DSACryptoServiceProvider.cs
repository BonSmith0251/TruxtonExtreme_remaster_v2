namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200032A")]
public sealed class DSACryptoServiceProvider : DSA
{
	[Token(Token = "0x4000D61")]
	private static bool useMachineKeyStore; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000D5B")]
	private KeyPairPersistence store; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D5C")]
	private bool persistKey; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x4000D5D")]
	private bool persisted; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Token(Token = "0x4000D5E")]
	private bool privateKeyExportable; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2B")]
	[Token(Token = "0x4000D5F")]
	private bool m_disposed; //Field offset: 0x2B
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D60")]
	private DSAManaged dsa; //Field offset: 0x30

	[Token(Token = "0x17000297")]
	public virtual int KeySize
	{
		[Address(RVA = "0x1EC9F70", Offset = "0x1EC9370", Length = "0x2A")]
		[Token(Token = "0x60019A7")]
		 get { } //Length: 42
	}

	[ComVisible(False)]
	[Token(Token = "0x17000298")]
	public bool PublicOnly
	{
		[Address(RVA = "0x1EC9FA0", Offset = "0x1EC93A0", Length = "0x1D")]
		[Token(Token = "0x60019A8")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x1EC9F40", Offset = "0x1EC9340", Length = "0x2C")]
	[Token(Token = "0x60019A3")]
	public DSACryptoServiceProvider() { }

	[Address(RVA = "0x1EC9F00", Offset = "0x1EC9300", Length = "0x34")]
	[Token(Token = "0x60019A4")]
	public DSACryptoServiceProvider(int dwKeySize) { }

	[Address(RVA = "0x1EC9B30", Offset = "0x1EC8F30", Length = "0x236")]
	[Token(Token = "0x60019A5")]
	private void Common(int dwKeySize, bool parameters) { }

	[Address(RVA = "0x1EBE630", Offset = "0x1EBDA30", Length = "0x4C")]
	[Token(Token = "0x60019AC")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1EC9D70", Offset = "0x1EC9170", Length = "0xC1")]
	[Token(Token = "0x60019A9")]
	public virtual DSAParameters ExportParameters(bool includePrivateParameters) { }

	[Address(RVA = "0x1E56230", Offset = "0x1E55630", Length = "0x65")]
	[Token(Token = "0x60019A6")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1EC9F70", Offset = "0x1EC9370", Length = "0x2A")]
	[Token(Token = "0x60019A7")]
	public virtual int get_KeySize() { }

	[Address(RVA = "0x1EC9FA0", Offset = "0x1EC93A0", Length = "0x1D")]
	[Token(Token = "0x60019A8")]
	public bool get_PublicOnly() { }

	[Address(RVA = "0x1EBEA00", Offset = "0x1EBDE00", Length = "0x52")]
	[Token(Token = "0x60019AA")]
	public virtual void ImportParameters(DSAParameters parameters) { }

	[Address(RVA = "0x1EC9E40", Offset = "0x1EC9240", Length = "0x81")]
	[Token(Token = "0x60019AD")]
	private void OnKeyGenerated(object sender, EventArgs e) { }

	[Address(RVA = "0x1EC9ED0", Offset = "0x1EC92D0", Length = "0x2A")]
	[Token(Token = "0x60019AB")]
	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

