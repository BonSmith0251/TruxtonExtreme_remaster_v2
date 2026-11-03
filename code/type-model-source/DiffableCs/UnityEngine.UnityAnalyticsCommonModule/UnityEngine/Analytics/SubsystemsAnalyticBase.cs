namespace UnityEngine.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000002")]
public class SubsystemsAnalyticBase : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000001")]
	public string subsystem; //Field offset: 0x30

	[Address(RVA = "0x3478F50", Offset = "0x3478350", Length = "0x60")]
	[Token(Token = "0x6000001")]
	public SubsystemsAnalyticBase(string eventName) { }

}

