namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F2")]
public sealed class KeySizes
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CC1")]
	private int m_minSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000CC2")]
	private int m_maxSize; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CC3")]
	private int m_skipSize; //Field offset: 0x18

	[Token(Token = "0x1700026D")]
	public int MaxSize
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x6001852")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700026C")]
	public int MinSize
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[Token(Token = "0x6001851")]
		 get { } //Length: 85
	}

	[Token(Token = "0x1700026E")]
	public int SkipSize
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6001853")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x11EB3F0", Offset = "0x11EA7F0", Length = "0x44")]
	[Token(Token = "0x6001854")]
	public KeySizes(int minSize, int maxSize, int skipSize) { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x6001852")]
	public int get_MaxSize() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[Token(Token = "0x6001851")]
	public int get_MinSize() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6001853")]
	public int get_SkipSize() { }

	[Address(RVA = "0x1EBAAA0", Offset = "0x1EB9EA0", Length = "0x2B")]
	[Token(Token = "0x6001855")]
	internal bool IsLegal(int keySize) { }

	[Address(RVA = "0x1EBAA10", Offset = "0x1EB9E10", Length = "0x84")]
	[Token(Token = "0x6001856")]
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }

}

