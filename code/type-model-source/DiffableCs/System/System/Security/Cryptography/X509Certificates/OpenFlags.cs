namespace System.Security.Cryptography.X509Certificates;

[Flags]
[Token(Token = "0x200011D")]
public enum OpenFlags : int
{
	ReadOnly = 0,
	ReadWrite = 1,
	MaxAllowed = 2,
	OpenExistingOnly = 4,
	IncludeArchived = 8,
}

