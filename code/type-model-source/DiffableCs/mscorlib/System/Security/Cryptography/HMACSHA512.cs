namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x2000303")]
public class HMACSHA512 : HMAC
{
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000CE8")]
	private bool m_useLegacyBlockSize; //Field offset: 0x68

	[Token(Token = "0x17000274")]
	private int BlockSize
	{
		[Address(RVA = "0x1EB9490", Offset = "0x1EB8890", Length = "0x12")]
		[Token(Token = "0x600189B")]
		private get { } //Length: 18
	}

	[Address(RVA = "0x1EB95C0", Offset = "0x1EB89C0", Length = "0x11B")]
	[Token(Token = "0x6001899")]
	public HMACSHA512() { }

	[Address(RVA = "0x1EB94B0", Offset = "0x1EB88B0", Length = "0x103")]
	[Token(Token = "0x600189A")]
	public HMACSHA512(Byte[] key) { }

	[Address(RVA = "0x1EB9490", Offset = "0x1EB8890", Length = "0x12")]
	[Token(Token = "0x600189B")]
	private int get_BlockSize() { }

}

