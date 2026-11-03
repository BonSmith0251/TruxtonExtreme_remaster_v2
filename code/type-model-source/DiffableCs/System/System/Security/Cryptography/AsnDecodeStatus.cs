namespace System.Security.Cryptography;

[Token(Token = "0x200011B")]
internal enum AsnDecodeStatus : int
{
	NotDecoded = -1,
	Ok = 0,
	BadAsn = 1,
	BadTag = 2,
	BadLength = 3,
	InformationNotAvailable = 4,
}

