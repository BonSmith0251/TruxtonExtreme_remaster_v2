namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000309")]
public abstract class RandomNumberGenerator : IDisposable
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60018BA")]
	protected RandomNumberGenerator() { }

	[Address(RVA = "0x1EBFC70", Offset = "0x1EBF070", Length = "0x44")]
	[Token(Token = "0x60018BB")]
	public static RandomNumberGenerator Create() { }

	[Address(RVA = "0x1EBFCC0", Offset = "0x1EBF0C0", Length = "0x61")]
	[Token(Token = "0x60018BC")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60018BD")]
	protected override void Dispose(bool disposing) { }

	[Token(Token = "0x60018BE")]
	public abstract void GetBytes(Byte[] data) { }

}

