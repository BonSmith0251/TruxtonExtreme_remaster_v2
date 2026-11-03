namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000020")]
public sealed class PerformanceModeEventHandler : MulticastDelegate
{

	[Address(RVA = "0x63A190", Offset = "0x639590", Length = "0xA6")]
	[Token(Token = "0x6000114")]
	public PerformanceModeEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000115")]
	public override void Invoke(PerformanceMode performanceMode) { }

}

