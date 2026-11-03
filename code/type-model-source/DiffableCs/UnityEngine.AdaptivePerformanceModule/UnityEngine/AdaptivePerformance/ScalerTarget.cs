namespace UnityEngine.AdaptivePerformance;

[Flags]
[Token(Token = "0x200001E")]
public enum ScalerTarget : int
{
	CPU = 1,
	GPU = 2,
	FillRate = 4,
}

