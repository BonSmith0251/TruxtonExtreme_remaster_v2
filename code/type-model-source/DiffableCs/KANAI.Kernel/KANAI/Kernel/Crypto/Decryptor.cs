namespace KANAI.Kernel.Crypto;

[Token(Token = "0x2000048")]
public class Decryptor : CryptoBase
{

	[Address(RVA = "0x1DE70F0", Offset = "0x1DE64F0", Length = "0x55")]
	[Token(Token = "0x600025B")]
	public Decryptor(Byte[] keyData, BitArray maskData) { }

	[Address(RVA = "0x1DE7CB0", Offset = "0x1DE70B0", Length = "0x214")]
	[Token(Token = "0x600025C")]
	public virtual void Receive(Byte[] data, int offset, int length) { }

}

