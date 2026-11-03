namespace Unity.IO.Archive;

[RequiredByNativeCode]
[Token(Token = "0x2000048")]
public enum ArchiveStatus : int
{
	InProgress = 0,
	Complete = 1,
	Failed = 2,
}

