namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F8")]
public sealed class DESCryptoServiceProvider : DES
{

	[Address(RVA = "0x1EB6B60", Offset = "0x1EB5F60", Length = "0x149")]
	[Token(Token = "0x600186F")]
	public DESCryptoServiceProvider() { }

	[Address(RVA = "0x1EB66C0", Offset = "0x1EB5AC0", Length = "0x19E")]
	[Token(Token = "0x6001871")]
	public virtual ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1EB6860", Offset = "0x1EB5C60", Length = "0x19E")]
	[Token(Token = "0x6001870")]
	public virtual ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1EB6A00", Offset = "0x1EB5E00", Length = "0x77")]
	[Token(Token = "0x6001873")]
	public virtual void GenerateIV() { }

	[Address(RVA = "0x1EB6A80", Offset = "0x1EB5E80", Length = "0xDE")]
	[Token(Token = "0x6001872")]
	public virtual void GenerateKey() { }

}

