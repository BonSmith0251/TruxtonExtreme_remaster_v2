namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000313")]
public abstract class RSA : AsymmetricAlgorithm
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60018F6")]
	protected RSA() { }

	[Address(RVA = "0x1EBF1D0", Offset = "0x1EBE5D0", Length = "0x5B")]
	[Token(Token = "0x60018F7")]
	public static RSA Create() { }

	[Address(RVA = "0x1EBF230", Offset = "0x1EBE630", Length = "0x5F")]
	[Token(Token = "0x60018F8")]
	public override Byte[] EncryptValue(Byte[] rgb) { }

	[Token(Token = "0x60018FB")]
	public abstract RSAParameters ExportParameters(bool includePrivateParameters) { }

	[Address(RVA = "0x1EBF290", Offset = "0x1EBE690", Length = "0x61C")]
	[Token(Token = "0x60018F9")]
	public virtual void FromXmlString(string xmlString) { }

	[Token(Token = "0x60018FC")]
	public abstract void ImportParameters(RSAParameters parameters) { }

	[Address(RVA = "0x1EBF8B0", Offset = "0x1EBECB0", Length = "0x3BE")]
	[Token(Token = "0x60018FA")]
	public virtual string ToXmlString(bool includePrivateParameters) { }

}

