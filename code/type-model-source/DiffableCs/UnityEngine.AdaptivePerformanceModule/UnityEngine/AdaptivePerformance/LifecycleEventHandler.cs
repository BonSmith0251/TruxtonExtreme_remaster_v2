namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000012")]
public sealed class LifecycleEventHandler : MulticastDelegate
{

	[Address(RVA = "0x2F98B00", Offset = "0x2F97F00", Length = "0x125")]
	[Token(Token = "0x60000A5")]
	public LifecycleEventHandler(object object, IntPtr method) { }

	[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
	[Token(Token = "0x60000A6")]
	public override void Invoke(IAdaptivePerformance instance, LifecycleChangeType changeType) { }

}

