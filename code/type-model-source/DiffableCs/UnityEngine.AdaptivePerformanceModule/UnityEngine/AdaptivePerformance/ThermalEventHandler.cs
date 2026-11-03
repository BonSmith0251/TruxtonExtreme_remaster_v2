namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x200002E")]
public sealed class ThermalEventHandler : MulticastDelegate
{

	[Address(RVA = "0x10AB210", Offset = "0x10AA610", Length = "0xA6")]
	[Token(Token = "0x600014F")]
	public ThermalEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0xE2BDB0", Offset = "0xE2B1B0", Length = "0x2D")]
	[Token(Token = "0x6000150")]
	public override void Invoke(ThermalMetrics thermalMetrics) { }

}

