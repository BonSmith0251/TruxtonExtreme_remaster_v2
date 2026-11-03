namespace System.IO;

[Flags]
[Token(Token = "0x200063F")]
public enum FileShare : int
{
	None = 0,
	Read = 1,
	Write = 2,
	ReadWrite = 3,
	Delete = 4,
	Inheritable = 16,
}

