namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000025")]
public sealed class PerformanceBoostChangeHandler : MulticastDelegate
{

	[Address(RVA = "0x2F98C30", Offset = "0x2F98030", Length = "0xA6")]
	[Token(Token = "0x6000120")]
	public PerformanceBoostChangeHandler(object object, IntPtr method) { }

	[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
	[Token(Token = "0x6000121")]
	public override void Invoke(PerformanceBoostChangeEventArgs boostEventArgs) { }

}

