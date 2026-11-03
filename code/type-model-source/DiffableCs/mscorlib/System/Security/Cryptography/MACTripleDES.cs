namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000306")]
public class MACTripleDES : KeyedHashAlgorithm
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000CEA")]
	private ICryptoTransform m_encryptor; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000CEB")]
	private CryptoStream _cs; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000CEC")]
	private TailStream _ts; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000CED")]
	private int m_bytesPerBlock; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000CEE")]
	private TripleDES des; //Field offset: 0x50

	[Address(RVA = "0x1EBB140", Offset = "0x1EBA540", Length = "0x17B")]
	[Token(Token = "0x60018A5")]
	public MACTripleDES() { }

	[Address(RVA = "0x1EBACC0", Offset = "0x1EBA0C0", Length = "0xCF")]
	[Token(Token = "0x60018A9")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1EBAD90", Offset = "0x1EBA190", Length = "0x1B3")]
	[Token(Token = "0x60018A7")]
	protected virtual void HashCore(Byte[] rgbData, int ibStart, int cbSize) { }

	[Address(RVA = "0x1EBAF50", Offset = "0x1EBA350", Length = "0x1EB")]
	[Token(Token = "0x60018A8")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1DFC480", Offset = "0x1DFB880", Length = "0x13")]
	[Token(Token = "0x60018A6")]
	public virtual void Initialize() { }

}

