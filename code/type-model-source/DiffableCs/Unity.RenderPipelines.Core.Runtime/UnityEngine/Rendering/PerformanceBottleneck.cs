namespace UnityEngine.Rendering;

[Token(Token = "0x20000C9")]
internal enum PerformanceBottleneck : int
{
	Indeterminate = 0,
	PresentLimited = 1,
	CPU = 2,
	GPU = 3,
	Balanced = 4,
}

