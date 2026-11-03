namespace UnityEngine.AdaptivePerformance.Provider;

[Token(Token = "0x2000053")]
public interface IDevicePerformanceLevelControl
{

	[Token(Token = "0x170000BC")]
	public int MaxCpuPerformanceLevel
	{
		[Token(Token = "0x6000261")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000BD")]
	public int MaxGpuPerformanceLevel
	{
		[Token(Token = "0x6000262")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000264")]
	public bool EnableCpuBoost() { }

	[Token(Token = "0x6000265")]
	public bool EnableGpuBoost() { }

	[Token(Token = "0x6000261")]
	public int get_MaxCpuPerformanceLevel() { }

	[Token(Token = "0x6000262")]
	public int get_MaxGpuPerformanceLevel() { }

	[Token(Token = "0x6000263")]
	public bool SetPerformanceLevel(ref int cpu, ref int gpu) { }

}

