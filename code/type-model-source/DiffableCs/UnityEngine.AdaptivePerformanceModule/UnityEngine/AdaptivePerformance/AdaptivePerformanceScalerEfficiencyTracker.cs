namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200001A")]
internal class AdaptivePerformanceScalerEfficiencyTracker
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400006E")]
	private AdaptivePerformanceScaler m_Scaler; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400006F")]
	private float m_LastAverageGpuFrameTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000070")]
	private float m_LastAverageCpuFrameTime; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000071")]
	private bool m_IsApplied; //Field offset: 0x20

	[Token(Token = "0x17000039")]
	public bool IsRunning
	{
		[Address(RVA = "0x2F92950", Offset = "0x2F91D50", Length = "0x50")]
		[Token(Token = "0x60000B4")]
		 get { } //Length: 80
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60000B7")]
	public AdaptivePerformanceScalerEfficiencyTracker() { }

	[Address(RVA = "0x2F92950", Offset = "0x2F91D50", Length = "0x50")]
	[Token(Token = "0x60000B4")]
	public bool get_IsRunning() { }

	[Address(RVA = "0x2F925F0", Offset = "0x2F919F0", Length = "0x1CD")]
	[Token(Token = "0x60000B5")]
	public void Start(AdaptivePerformanceScaler scaler, bool isApply) { }

	[Address(RVA = "0x2F927C0", Offset = "0x2F91BC0", Length = "0x187")]
	[Token(Token = "0x60000B6")]
	public void Stop() { }

}

