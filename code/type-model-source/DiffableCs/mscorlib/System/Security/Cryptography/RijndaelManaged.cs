namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200030D")]
public sealed class RijndaelManaged : Rijndael
{

	[Address(RVA = "0x1EC3BE0", Offset = "0x1EC2FE0", Length = "0x15B")]
	[Token(Token = "0x60018CD")]
	public RijndaelManaged() { }

	[Address(RVA = "0x1EC3890", Offset = "0x1EC2C90", Length = "0xE9")]
	[Token(Token = "0x60018CF")]
	public virtual ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1EC3980", Offset = "0x1EC2D80", Length = "0xE3")]
	[Token(Token = "0x60018CE")]
	public virtual ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1EC3A70", Offset = "0x1EC2E70", Length = "0x32")]
	[Token(Token = "0x60018D1")]
	public virtual void GenerateIV() { }

	[Address(RVA = "0x1EC3AB0", Offset = "0x1EC2EB0", Length = "0x32")]
	[Token(Token = "0x60018D0")]
	public virtual void GenerateKey() { }

	[Address(RVA = "0x1EC3AF0", Offset = "0x1EC2EF0", Length = "0xE4")]
	[Token(Token = "0x60018D2")]
	private ICryptoTransform NewEncryptor(Byte[] rgbKey, CipherMode mode, Byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }

}

