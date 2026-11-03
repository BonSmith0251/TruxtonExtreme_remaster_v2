namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002FA")]
public abstract class DSA : AsymmetricAlgorithm
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001874")]
	protected DSA() { }

	[Address(RVA = "0x1EB7CE0", Offset = "0x1EB70E0", Length = "0x44")]
	[Token(Token = "0x6001875")]
	public static DSA Create() { }

	[Token(Token = "0x6001879")]
	public abstract DSAParameters ExportParameters(bool includePrivateParameters) { }

	[Address(RVA = "0x1EB7D30", Offset = "0x1EB7130", Length = "0x9C6")]
	[Token(Token = "0x6001877")]
	public virtual void FromXmlString(string xmlString) { }

	[Token(Token = "0x600187A")]
	public abstract void ImportParameters(DSAParameters parameters) { }

	[Address(RVA = "0x1EB8700", Offset = "0x1EB7B00", Length = "0x411")]
	[Token(Token = "0x6001878")]
	public virtual string ToXmlString(bool includePrivateParameters) { }

	[Token(Token = "0x6001876")]
	public abstract bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

