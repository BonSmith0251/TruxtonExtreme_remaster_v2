namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200000A")]
internal class AutoPerformanceModeController
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400003D")]
	private string m_FeatureName; //Field offset: 0x10

	[Address(RVA = "0x2F96F00", Offset = "0x2F96300", Length = "0x185")]
	[Token(Token = "0x6000071")]
	public AutoPerformanceModeController(IPerformanceModeStatus perfModeStat) { }

	[Address(RVA = "0x2F96D90", Offset = "0x2F96190", Length = "0x170")]
	[CompilerGenerated]
	[Token(Token = "0x6000073")]
	private void <.ctor>b__1_0(PerformanceMode mode) { }

	[Address(RVA = "0x2F96D90", Offset = "0x2F96190", Length = "0x170")]
	[Token(Token = "0x6000072")]
	private void OnPerformanceModeChange(PerformanceMode performanceMode) { }

}

