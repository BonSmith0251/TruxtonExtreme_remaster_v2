namespace KANAI.Kernel.Crypto;

[Token(Token = "0x2000049")]
public class Encryptor : CryptoBase
{

	[Address(RVA = "0x1DE8EB0", Offset = "0x1DE82B0", Length = "0x96")]
	[Token(Token = "0x600025F")]
	private Byte[] _createInitialVector() { }

	[Address(RVA = "0x1DE70F0", Offset = "0x1DE64F0", Length = "0x55")]
	[Token(Token = "0x600025D")]
	public Encryptor(Byte[] keyData, BitArray maskData) { }

	[Address(RVA = "0x1DE8C70", Offset = "0x1DE8070", Length = "0x234")]
	[Token(Token = "0x600025E")]
	public virtual void Receive(Byte[] data, int offset, int length) { }

}

