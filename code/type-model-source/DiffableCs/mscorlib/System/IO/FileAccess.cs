namespace System.IO;

[Flags]
[Token(Token = "0x200063A")]
public enum FileAccess : int
{
	Read = 1,
	Write = 2,
	ReadWrite = 3,
}

