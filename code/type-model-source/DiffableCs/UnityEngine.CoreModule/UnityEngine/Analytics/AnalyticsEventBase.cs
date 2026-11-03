namespace UnityEngine.Analytics;

[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000332")]
public class AnalyticsEventBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000855")]
	private string eventName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000856")]
	private int eventVersion; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000857")]
	private string eventPrefix; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000858")]
	private SendEventOptions sendEventOptions; //Field offset: 0x28

	[Address(RVA = "0x30768A0", Offset = "0x3075CA0", Length = "0x63")]
	[Token(Token = "0x60019DE")]
	public AnalyticsEventBase(string eventName, int eventVersion, SendEventOptions sendEventOptions = 0, string eventPrefix = "") { }

}

