namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200032E")]
public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D71")]
	private RSA rsa; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D72")]
	private string hashName; //Field offset: 0x18

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60019C5")]
	public RSAPKCS1SignatureDeformatter() { }

	[Address(RVA = "0x1ECD5C0", Offset = "0x1ECC9C0", Length = "0x3B")]
	[Token(Token = "0x60019C6")]
	public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key) { }

	[Address(RVA = "0x1ECD250", Offset = "0x1ECC650", Length = "0x6C")]
	[Token(Token = "0x60019C7")]
	public virtual void SetHashAlgorithm(string strName) { }

	[Address(RVA = "0x1ECD2C0", Offset = "0x1ECC6C0", Length = "0x103")]
	[Token(Token = "0x60019C8")]
	public virtual void SetKey(AsymmetricAlgorithm key) { }

	[Address(RVA = "0x1ECD3D0", Offset = "0x1ECC7D0", Length = "0x1E6")]
	[Token(Token = "0x60019C9")]
	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

