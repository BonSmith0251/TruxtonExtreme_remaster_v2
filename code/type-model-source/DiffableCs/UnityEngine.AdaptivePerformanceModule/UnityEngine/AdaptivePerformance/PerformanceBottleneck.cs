namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200002C")]
public enum PerformanceBottleneck : int
{
	Unknown = 0,
	CPU = 1,
	GPU = 2,
	TargetFrameRate = 3,
}

