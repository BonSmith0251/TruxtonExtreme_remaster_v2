namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000004")]
internal class BottleneckUtil
{

	[Address(RVA = "0x2F97090", Offset = "0x2F96490", Length = "0x16E")]
	[Token(Token = "0x6000003")]
	public static PerformanceBottleneck DetermineBottleneck(PerformanceBottleneck prevBottleneck, float averageCpuFrameTime, float averageGpuFrametime, float averageOverallFrametime, float targetFrameTime) { }

	[Address(RVA = "0x2F97200", Offset = "0x2F96600", Length = "0x30")]
	[Token(Token = "0x6000004")]
	private static bool HittingFrameRateLimit(float actualFrameTime, float thresholdFactor, float targetFrameTime) { }

}

