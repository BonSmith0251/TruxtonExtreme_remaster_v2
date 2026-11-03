namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000331")]
public sealed class SHA1CryptoServiceProvider : SHA1
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000D78")]
	private SHA1Internal sha; //Field offset: 0x28

	[Address(RVA = "0x1EEEBD0", Offset = "0x1EEDFD0", Length = "0x66")]
	[Token(Token = "0x60019D4")]
	public SHA1CryptoServiceProvider() { }

	[Address(RVA = "0x1EEEB40", Offset = "0x1EEDF40", Length = "0x8")]
	[Token(Token = "0x60019D6")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1ECA1D0", Offset = "0x1EC95D0", Length = "0x65")]
	[Token(Token = "0x60019D5")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1EEEB50", Offset = "0x1EEDF50", Length = "0x2B")]
	[Token(Token = "0x60019D7")]
	protected virtual void HashCore(Byte[] rgb, int ibStart, int cbSize) { }

	[Address(RVA = "0x1EEEB80", Offset = "0x1EEDF80", Length = "0x24")]
	[Token(Token = "0x60019D8")]
	protected virtual Byte[] HashFinal() { }

	[Address(RVA = "0x1EEEBB0", Offset = "0x1EEDFB0", Length = "0x1D")]
	[Token(Token = "0x60019D9")]
	public virtual void Initialize() { }

}

