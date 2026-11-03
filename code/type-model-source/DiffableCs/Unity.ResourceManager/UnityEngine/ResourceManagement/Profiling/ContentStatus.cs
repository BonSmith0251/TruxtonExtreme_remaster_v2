namespace UnityEngine.ResourceManagement.Profiling;

[Flags]
[Token(Token = "0x2000072")]
internal enum ContentStatus : int
{
	None = 0,
	Queue = 2,
	Downloading = 4,
	Released = 16,
	Loading = 64,
	Active = 256,
}

