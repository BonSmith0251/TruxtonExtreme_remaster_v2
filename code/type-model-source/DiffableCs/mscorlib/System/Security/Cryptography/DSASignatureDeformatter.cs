namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002FB")]
public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CDD")]
	private DSA _dsaKey; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CDE")]
	private string _oid; //Field offset: 0x18

	[Address(RVA = "0x1EB7BE0", Offset = "0x1EB6FE0", Length = "0x73")]
	[Token(Token = "0x600187B")]
	public DSASignatureDeformatter() { }

	[Address(RVA = "0x1EB7A70", Offset = "0x1EB6E70", Length = "0x168")]
	[Token(Token = "0x600187C")]
	public DSASignatureDeformatter(AsymmetricAlgorithm key) { }

	[Address(RVA = "0x1EB7770", Offset = "0x1EB6B70", Length = "0xBE")]
	[Token(Token = "0x600187E")]
	public virtual void SetHashAlgorithm(string strName) { }

	[Address(RVA = "0x1EB7830", Offset = "0x1EB6C30", Length = "0x103")]
	[Token(Token = "0x600187D")]
	public virtual void SetKey(AsymmetricAlgorithm key) { }

	[Address(RVA = "0x1EB7940", Offset = "0x1EB6D40", Length = "0x128")]
	[Token(Token = "0x600187F")]
	public virtual bool VerifySignature(Byte[] rgbHash, Byte[] rgbSignature) { }

}

