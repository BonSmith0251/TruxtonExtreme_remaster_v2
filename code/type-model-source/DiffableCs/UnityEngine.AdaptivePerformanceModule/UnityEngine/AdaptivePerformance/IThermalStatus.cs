namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000030")]
public interface IThermalStatus
{

	[Token(Token = "0x17000074")]
	public ThermalMetrics ThermalMetrics
	{
		[Token(Token = "0x6000157")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000157")]
	public ThermalMetrics get_ThermalMetrics() { }

}

