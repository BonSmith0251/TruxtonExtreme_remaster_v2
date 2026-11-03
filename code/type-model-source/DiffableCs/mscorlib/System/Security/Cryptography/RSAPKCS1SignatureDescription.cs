namespace System.Security.Cryptography;

[Token(Token = "0x200031E")]
internal abstract class RSAPKCS1SignatureDescription : SignatureDescription
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000D3F")]
	private string _hashAlgorithm; //Field offset: 0x30

	[Address(RVA = "0x1ECD600", Offset = "0x1ECCA00", Length = "0xC1")]
	[Token(Token = "0x6001957")]
	protected RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm) { }

}

