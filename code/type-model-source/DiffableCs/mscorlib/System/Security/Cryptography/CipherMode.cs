namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F0")]
public enum CipherMode : int
{
	CBC = 1,
	ECB = 2,
	OFB = 3,
	CFB = 4,
	CTS = 5,
}

