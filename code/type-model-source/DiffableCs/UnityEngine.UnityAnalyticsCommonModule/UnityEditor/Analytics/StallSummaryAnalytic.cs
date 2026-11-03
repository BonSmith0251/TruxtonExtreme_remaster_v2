namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000020")]
public class StallSummaryAnalytic : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400005A")]
	public double Duration; //Field offset: 0x30

	[Address(RVA = "0x3478EE0", Offset = "0x34782E0", Length = "0x64")]
	[Token(Token = "0x600003A")]
	public StallSummaryAnalytic() { }

	[Address(RVA = "0x3478E50", Offset = "0x3478250", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600003B")]
	internal static StallSummaryAnalytic CreateStallSummaryAnalytic() { }

}

