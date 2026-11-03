namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000326")]
public sealed class TripleDESCryptoServiceProvider : TripleDES
{

	[Address(RVA = "0x1ED5390", Offset = "0x1ED4790", Length = "0xE5")]
	[Token(Token = "0x600197F")]
	public TripleDESCryptoServiceProvider() { }

	[Address(RVA = "0x1ED5010", Offset = "0x1ED4410", Length = "0x112")]
	[Token(Token = "0x6001981")]
	public virtual ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1ED5130", Offset = "0x1ED4530", Length = "0x112")]
	[Token(Token = "0x6001980")]
	public virtual ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1ED5250", Offset = "0x1ED4650", Length = "0x77")]
	[Token(Token = "0x6001983")]
	public virtual void GenerateIV() { }

	[Address(RVA = "0x1ED52D0", Offset = "0x1ED46D0", Length = "0xBC")]
	[Token(Token = "0x6001982")]
	public virtual void GenerateKey() { }

}

