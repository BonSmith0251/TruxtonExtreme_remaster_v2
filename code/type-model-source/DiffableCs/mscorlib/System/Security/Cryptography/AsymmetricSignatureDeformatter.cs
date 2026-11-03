namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002EE")]
public abstract class AsymmetricSignatureDeformatter
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600184C")]
	protected AsymmetricSignatureDeformatter() { }

	[Token(Token = "0x600184E")]
	public abstract void SetHashAlgorithm(string strName) { }

	[Token(Token = "0x600184D")]
	public abstract void SetKey(AsymmetricAlgorithm key) { }

	[Token(Token = "0x600184F")]
	public abstract bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

