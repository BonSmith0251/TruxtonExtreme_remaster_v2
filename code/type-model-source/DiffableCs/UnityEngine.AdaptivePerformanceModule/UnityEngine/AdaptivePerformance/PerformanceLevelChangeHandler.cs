namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000027")]
public sealed class PerformanceLevelChangeHandler : MulticastDelegate
{

	[Address(RVA = "0x1B5CE70", Offset = "0x1B5C270", Length = "0xA6")]
	[Token(Token = "0x600012E")]
	public PerformanceLevelChangeHandler(object object, IntPtr method) { }

	[Address(RVA = "0xE2BDE0", Offset = "0xE2B1E0", Length = "0x2F")]
	[Token(Token = "0x600012F")]
	public override void Invoke(PerformanceLevelChangeEventArgs levelChangeEventArgs) { }

}

