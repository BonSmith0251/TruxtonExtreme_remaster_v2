namespace UnityEditor.Analytics;

[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000023")]
public class VCProviderAnalytics : AnalyticsEventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400005F")]
	public string Mode; //Field offset: 0x30

	[Address(RVA = "0x34794D0", Offset = "0x34788D0", Length = "0x64")]
	[Token(Token = "0x6000040")]
	public VCProviderAnalytics() { }

	[Address(RVA = "0x3479440", Offset = "0x3478840", Length = "0x8F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000041")]
	internal static VCProviderAnalytics CreateVCProviderAnalytics() { }

}

