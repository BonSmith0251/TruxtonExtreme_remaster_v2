namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x200030B")]
public sealed class RC2CryptoServiceProvider : RC2
{
	[Token(Token = "0x4000CF7")]
	private static KeySizes[] s_legalKeySizes; //Field offset: 0x0
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000CF6")]
	private bool m_use40bitSalt; //Field offset: 0x50

	[Token(Token = "0x17000281")]
	public virtual int EffectiveKeySize
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x60018C5")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1EBB5D0", Offset = "0x1EBA9D0", Length = "0xD7")]
	[Token(Token = "0x60018CA")]
	private static RC2CryptoServiceProvider() { }

	[Address(RVA = "0x1EBB6B0", Offset = "0x1EBAAB0", Length = "0x211")]
	[Token(Token = "0x60018C4")]
	public RC2CryptoServiceProvider() { }

	[Address(RVA = "0x1EBB330", Offset = "0x1EBA730", Length = "0xCD")]
	[Token(Token = "0x60018C7")]
	public virtual ICryptoTransform CreateDecryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1EBB400", Offset = "0x1EBA800", Length = "0xCD")]
	[Token(Token = "0x60018C6")]
	public virtual ICryptoTransform CreateEncryptor(Byte[] rgbKey, Byte[] rgbIV) { }

	[Address(RVA = "0x1EBB4D0", Offset = "0x1EBA8D0", Length = "0x77")]
	[Token(Token = "0x60018C9")]
	public virtual void GenerateIV() { }

	[Address(RVA = "0x1EBB550", Offset = "0x1EBA950", Length = "0x7E")]
	[Token(Token = "0x60018C8")]
	public virtual void GenerateKey() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x60018C5")]
	public virtual int get_EffectiveKeySize() { }

}

