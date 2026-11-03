namespace System.Net;

[Flags]
[Token(Token = "0x2000233")]
internal enum FtpMethodFlags : int
{
	None = 0,
	IsDownload = 1,
	IsUpload = 2,
	TakesParameter = 4,
	MayTakeParameter = 8,
	DoesNotTakeParameter = 16,
	ParameterIsDirectory = 32,
	ShouldParseForResponseUri = 64,
	HasHttpCommand = 128,
	MustChangeWorkingDirectoryToPath = 256,
}

