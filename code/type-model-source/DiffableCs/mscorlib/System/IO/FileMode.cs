namespace System.IO;

[Token(Token = "0x200063C")]
public enum FileMode : int
{
	CreateNew = 1,
	Create = 2,
	Open = 3,
	OpenOrCreate = 4,
	Truncate = 5,
	Append = 6,
}

