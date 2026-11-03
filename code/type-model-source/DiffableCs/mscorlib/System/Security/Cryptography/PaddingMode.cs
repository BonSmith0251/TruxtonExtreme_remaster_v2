namespace System.Security.Cryptography;

[ComVisible(True)]
[Token(Token = "0x20002F1")]
public enum PaddingMode : int
{
	None = 1,
	PKCS7 = 2,
	Zeros = 3,
	ANSIX923 = 4,
	ISO10126 = 5,
}

