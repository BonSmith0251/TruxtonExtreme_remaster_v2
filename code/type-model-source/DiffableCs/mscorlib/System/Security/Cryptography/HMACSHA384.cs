namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000302")]
public class HMACSHA384 : HMAC
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000CE7")]
	private bool m_useLegacyBlockSize; //Field offset: 0x68

	[Token(Token = "0x17000273")]
	private int BlockSize
	{
		[Address(RVA = "0x1EB9490", Offset = "0x1EB8890", Length = "0x12")]
		[Token(Token = "0x6001898")]
		private get { } //Length: 18
	}

	[Address(RVA = "0x1EB9260", Offset = "0x1EB8660", Length = "0x11B")]
	[Token(Token = "0x6001896")]
	public HMACSHA384() { }

	[Address(RVA = "0x1EB9380", Offset = "0x1EB8780", Length = "0x103")]
	[Token(Token = "0x6001897")]
	public HMACSHA384(Byte[] key) { }

	[Address(RVA = "0x1EB9490", Offset = "0x1EB8890", Length = "0x12")]
	[Token(Token = "0x6001898")]
	private int get_BlockSize() { }

}

